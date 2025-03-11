using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace db_example_pr16
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string moviesPath = Path.Combine(baseDirectory, "../../ml-latest/movies.csv");
            string ratingsPath = Path.Combine(baseDirectory, "../../ml-latest/ratings.csv");
            string tagsPath = Path.Combine(baseDirectory, "../../ml-latest/tags.csv");

            moviesPath = Path.GetFullPath(moviesPath);
            ratingsPath = Path.GetFullPath(ratingsPath);
            tagsPath = Path.GetFullPath(tagsPath);

            if (!File.Exists(moviesPath))
            {
                Console.WriteLine($"Файл не найден: {moviesPath}");
                return;
            }

            if (!File.Exists(ratingsPath))
            {
                Console.WriteLine($"Файл не найден: {ratingsPath}");
                return;
            }

            if (!File.Exists(tagsPath))
            {
                Console.WriteLine($"Файл не найден: {tagsPath}");
                return;
            }

            var movies = LoadMovies(moviesPath);
            var ratings = LoadRatings(ratingsPath);
            var tags = LoadTags(tagsPath);

            int vNum = 0;
            while (true)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("\tИС БД MovieLens");
                Console.WriteLine("****************************");
                Console.WriteLine("");

                Console.WriteLine("Пожалуйста, выберите действие:");
                Console.WriteLine("   - 1. Отобразить статистику по всем фильмам (год выхода)");
                Console.WriteLine("   - 2. Отобразить фильмы за указанный год (дата выхода) и жанр");
                Console.WriteLine("   - 3. Отобразить среднее значение рейтинга каждого фильма за указанный год");
                Console.WriteLine("   - 4. ВЫХОД");

                try
                {
                    vNum = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                switch (vNum)
                {
                    case 1:
                        DisplayMovieStatistics(movies);
                        break;
                    case 2:
                        DisplayMoviesByYearAndGenre(movies);
                        break;
                    case 3:
                        DisplayAverageRatingByYear(movies, ratings);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите снова.");
                        break;
                }

                Console.WriteLine("Вернуться в главное меню? (Y/N)");
                if (Console.ReadLine().ToUpper() != "Y")
                    break;
            }
        }

        static List<Movie> LoadMovies(string path)
        {
            var movies = new List<Movie>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                movies = csv.GetRecords<Movie>().ToList();
            }

            return movies;
        }

        static List<Rating> LoadRatings(string path)
        {
            var ratings = new List<Rating>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                ratings = csv.GetRecords<Rating>().ToList();
            }

            return ratings;
        }

        static List<Tag> LoadTags(string path)
        {
            var tags = new List<Tag>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                tags = csv.GetRecords<Tag>().ToList();
            }

            return tags;
        }

        static void DisplayMovieStatistics(List<Movie> movies)
        {
            var yearStats = movies
                .GroupBy(m => m.Year)
                .Select(g => new { Year = g.Key, Count = g.Count() })
                .OrderBy(g => g.Year);

            Console.WriteLine("--- Статистика по всем фильмам ---");

            int yearWidth = 10;
            int countWidth = 15;

            Console.WriteLine("┌" + new string('─', yearWidth) + "┬" + new string('─', countWidth) + "┐");

            Console.WriteLine($"│ {"Год".PadRight(yearWidth - 1)} │ {"Количество".PadRight(countWidth - 1)}│");

            Console.WriteLine("├" + new string('─', yearWidth) + "┼" + new string('─', countWidth) + "┤");

            foreach (var stat in yearStats)
            {
                Console.WriteLine($"│ {stat.Year.ToString().PadRight(yearWidth - 1)} │ {stat.Count.ToString().PadRight(countWidth - 1)}│");
            }

            Console.WriteLine("└" + new string('─', yearWidth) + "┴" + new string('─', countWidth) + "┘");
        }

        static void DisplayMoviesByYearAndGenre(List<Movie> movies)
        {
            int year = ReadIntInput("Введите год:");
            Console.WriteLine("Введите жанр:");
            string genre = Console.ReadLine();

            var filteredMovies = movies
                .Where(m => m.Year == year && m.Genres.Contains(genre))
                .ToList();

            Console.WriteLine("--- Фильмы за указанный год и жанр ---");

            int titleWidth = 50;

            Console.WriteLine("┌" + new string('─', titleWidth) + "┐");

            Console.WriteLine($"│ {"Название фильма".PadRight(titleWidth - 1)}│");

            Console.WriteLine("├" + new string('─', titleWidth) + "┤");

            foreach (var movie in filteredMovies)
            {
                Console.WriteLine($"│ {movie.Title.PadRight(titleWidth - 1)}│");
            }

            Console.WriteLine("└" + new string('─', titleWidth) + "┘");
        }

        static void DisplayAverageRatingByYear(List<Movie> movies, List<Rating> ratings)
        {
            int year = ReadIntInput("Введите год:");

            var movieRatings = movies
                .Where(m => m.Year == year)
                .Join(ratings, m => m.MovieId, r => r.MovieId, (m, r) => new { m.Title, r.RatingValue })
                .GroupBy(mr => mr.Title)
                .Select(g => new { Title = g.Key, AverageRating = g.Average(mr => mr.RatingValue) })
                .OrderByDescending(g => g.AverageRating);

            Console.WriteLine("--- Среднее значение рейтинга фильма за указанный год ---");

            int titleWidth = 50;
            int ratingWidth = 10;

            Console.WriteLine("┌" + new string('─', titleWidth) + "┬" + new string('─', ratingWidth) + "┐");

            Console.WriteLine($"│ {"Название фильма".PadRight(titleWidth - 1)} │ {"Рейтинг".PadRight(ratingWidth - 1)}│");

            Console.WriteLine("├" + new string('─', titleWidth) + "┼" + new string('─', ratingWidth) + "┤");

            foreach (var mr in movieRatings)
            {
                Console.WriteLine($"│ {mr.Title.PadRight(titleWidth - 1)} │ {mr.AverageRating.ToString("F2").PadRight(ratingWidth - 1)}│");
            }

            Console.WriteLine("└" + new string('─', titleWidth) + "┴" + new string('─', ratingWidth) + "┘");
        }

        static int ReadIntInput(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка: введите корректное число.");
            }
        }
    }

    public class Movie
    {
        [Name("movieId")]
        public int MovieId { get; set; }

        [Name("title")]
        public string Title { get; set; }

        [Name("genres")]
        public string Genres { get; set; }

        public int Year
        {
            get
            {
                try
                {
                    int lastOpenParen = Title.LastIndexOf('(');
                    int lastCloseParen = Title.LastIndexOf(')');
                    if (lastOpenParen != -1 && lastCloseParen != -1 && lastCloseParen > lastOpenParen)
                    {
                        string yearString = Title.Substring(lastOpenParen + 1, 4);
                        if (int.TryParse(yearString, out int year))
                        {
                            return year;
                        }
                    }
                    return 0;
                }
                catch
                {
                    return 0;
                }
            }
        }
    }

    public class Rating
    {
        [Name("userId")]
        public int UserId { get; set; }

        [Name("movieId")]
        public int MovieId { get; set; }

        [Name("rating")]
        public double RatingValue { get; set; }

        [Name("timestamp")]
        public long Timestamp { get; set; }
    }

    public class Tag
    {
        [Name("userId")]
        public int UserId { get; set; }

        [Name("movieId")]
        public int MovieId { get; set; }

        [Name("tag")]
        public string TagName { get; set; }

        [Name("timestamp")]
        public long Timestamp { get; set; }
    }
}