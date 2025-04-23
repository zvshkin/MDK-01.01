using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_15
{
    public class Car
    {
        public string Brand { get; set; }
        public int Cylinders { get; set; }
        public double Power { get; set; }

        public Car(string brand, int cylinders, double power)
        {
            if (string.IsNullOrEmpty(brand))
                throw new ArgumentException("Марка не может быть пустой");
            if (cylinders <= 0)
                throw new ArgumentException("Количество цилиндров должно быть положительным");
            if (power <= 0)
                throw new ArgumentException("Мощность должна быть положительной");

            Brand = brand;
            Cylinders = cylinders;
            Power = power;
        }

        public void ChangePower(double newPower)
        {
            if (newPower <= 0)
                throw new ArgumentException("Новая мощность должна быть положительной");
            Power = newPower;
        }

        public override string ToString()
        {
            return $"Машина: Марка={Brand}, Цилиндры={Cylinders}, Мощность={Power} л.с.";
        }

        public static Car GetCarInstance(string brand, int cylinders, double power)
        {
            return new Car(brand, cylinders, power);
        }
    }

    public class Lorry : Car
    {
        public double PayloadCapacity { get; set; }

        public Lorry(string brand, int cylinders, double power, double payloadCapacity)
            : base(brand, cylinders, power)
        {
            if (payloadCapacity <= 0)
                throw new ArgumentException("Грузоподъемность должна быть положительной");
            PayloadCapacity = payloadCapacity;
        }

        public void ChangeBrand(string newBrand)
        {
            if (string.IsNullOrEmpty(newBrand))
                throw new ArgumentException("Новая марка не может быть пустой");
            Brand = newBrand;
        }

        public void ChangePayloadCapacity(double newCapacity)
        {
            if (newCapacity <= 0)
                throw new ArgumentException("Новая грузоподъемность должна быть положительной");
            PayloadCapacity = newCapacity;
        }

        public override string ToString()
        {
            return $"Грузовик: Марка={Brand}, Цилиндры={Cylinders}, Мощность={Power} л.с., Грузоподъемность={PayloadCapacity} кг";
        }
    }

    // Задание 2
    public class Liquid
    {
        public string Name { get; set; }
        public double Density { get; set; }

        public Liquid(string name, double density)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Название не может быть пустым");
            if (density <= 0)
                throw new ArgumentException("Плотность должна быть положительной");

            Name = name;
            Density = density;
        }

        public void ChangeDensity(double newDensity)
        {
            if (newDensity <= 0)
                throw new ArgumentException("Новая плотность должна быть положительной");
            Density = newDensity;
        }

        public override string ToString()
        {
            return $"Жидкость: Название={Name}, Плотность={Density} г/см^(3)";
        }

        public static Liquid GetLiquidInstance(string name, double density)
        {
            return new Liquid(name, density);
        }
    }

    public class Alcohol : Liquid
    {
        public double Strength { get; set; }

        public Alcohol(string name, double density, double strength)
            : base(name, density)
        {
            if (strength <= 0 || strength > 100)
                throw new ArgumentException("Крепость должна быть в диапазоне 0-100%");
            Strength = strength;
        }

        public void ChangeName(string newName)
        {
            if (string.IsNullOrEmpty(newName))
                throw new ArgumentException("Новое название не может быть пустым");
            Name = newName;
        }

        public void ChangeStrength(double newStrength)
        {
            if (newStrength <= 0 || newStrength > 100)
                throw new ArgumentException("Новая крепость должна быть в диапазоне 0-100%");
            Strength = newStrength;
        }

        public override string ToString()
        {
            return $"Алкоголь: Название={Name}, Плотность={Density} г/см^(3), Крепость={Strength}%";
        }
    }

    // Задание 3

    public class Man
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }

        public Man(string firstName, string lastName, int age, string gender, double weight)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                throw new ArgumentException("Имя и фамилия не могут быть пустыми");
            if (age <= 0)
                throw new ArgumentException("Возраст должен быть положительным");
            if (weight <= 0)
                throw new ArgumentException("Вес должен быть положительным");

            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Weight = weight;
        }

        public void ChangeFirstName(string newFirstName)
        {
            if (string.IsNullOrEmpty(newFirstName))
                throw new ArgumentException("Новое имя не может быть пустым");
            FirstName = newFirstName;
        }

        public void ChangeAge(int newAge)
        {
            if (newAge <= 0)
                throw new ArgumentException("Новый возраст должен быть положительным");
            Age = newAge;
        }

        public void ChangeWeight(double newWeight)
        {
            if (newWeight <= 0)
                throw new ArgumentException("Новый вес должен быть положительным");
            Weight = newWeight;
        }

        public override string ToString()
        {
            return $"Человек: Имя={FirstName}, Фамилия={LastName}, Возраст={Age} лет, Пол={Gender}, Вес={Weight} кг";
        }

        public static Man GetManInstance(string firstName, string lastName, int age, string gender, double weight)
        {
            return new Man(firstName, lastName, age, gender, weight);
        }
    }

    public class Student : Man
    {
        public int YearOfStudy { get; set; }
        public string Major { get; set; }

        public Student(string firstName, string lastName, int age, string gender, double weight, int yearOfStudy, string major)
            : base(firstName, lastName, age, gender, weight)
        {
            if (yearOfStudy <= 0)
                throw new ArgumentException("Год обучения должен быть положительным");
            if (string.IsNullOrEmpty(major))
                throw new ArgumentException("Специальность не может быть пустой");

            YearOfStudy = yearOfStudy;
            Major = major;
        }

        public void IncreaseYearOfStudy()
        {
            if (YearOfStudy >= 6)
                throw new ArgumentException("Год обучения не может превышать 6");
            YearOfStudy++;
        }

        public override string ToString()
        {
            return $"Студент: Имя={FirstName}, Фамилия={LastName}, Возраст={Age} лет, Пол={Gender}, Вес={Weight} кг, Год={YearOfStudy}, Специальность={Major}";
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Задание 1.");
                Car car = Car.GetCarInstance("Toyota", 4, 150.0);
                Lorry lorry = new Lorry("Volvo", 6, 400.0, 10000.0);
                Console.WriteLine(car);
                Console.WriteLine(lorry);

                Console.WriteLine("\nЗадание 2.");
                Liquid liquid = Liquid.GetLiquidInstance("Вода", 1.0);
                Alcohol alcohol = new Alcohol("Водка", 0.789, 40.0);
                Console.WriteLine(liquid);
                Console.WriteLine(alcohol);

                Console.WriteLine("\nЗадание 3.");
                Man man = Man.GetManInstance("Иван", "Иванов", 30, "Мужской", 75.0);
                Student student = new Student("Анна", "Сидорова", 20, "Женский", 55.0, 2, "Информатика");
                Console.WriteLine(man);
                Console.WriteLine(student);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
