import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;

public class PracticalWork31 {
    
    private static void writeToFile(String filename, String content) {
        try (FileWriter writer = new FileWriter(filename)) {
            writer.write(content);
            System.out.println("-> Результат успешно записан в файл: " + filename);
        } catch (IOException e) {
            System.err.println("ОШИБКА ВЫВОДА: Не удалось записать в файл " + filename + ". " + e.getMessage());
        }
    }
    
    private static List<Integer> readIntsFromFile(String filename) throws IOException {
        List<Integer> numbers = new ArrayList<>();
        File file = new File(filename);

        if (!file.exists()) {
            throw new FileNotFoundException("Файл не найден: " + filename);
        }

        try (Scanner fileScanner = new Scanner(file)) {
            while (fileScanner.hasNext()) {
                if (fileScanner.hasNextInt()) {
                    int num = fileScanner.nextInt();
                    if (num <= 0) {
                        throw new IllegalArgumentException("Число должно быть положительным: " + num);
                    }
                    numbers.add(num);
                } else {
                    String invalidToken = fileScanner.next();
                    throw new NumberFormatException("Некорректные данные: ожидалось целое число, получено \"" + invalidToken + "\".");
                }
            }
        }
        return numbers;
    }

    private static String readStringFromFile(String filename) throws IOException {
        File file = new File(filename);
        if (!file.exists()) {
            throw new FileNotFoundException("Файл не найден: " + filename);
        }
        try (Scanner fileScanner = new Scanner(file).useDelimiter("\\A")) {
            if (fileScanner.hasNext()) {
                String content = fileScanner.next();
                if (content.length() < 30) {
                    throw new IllegalArgumentException(String.format(
                            "Длина строки недостаточна (%d символов). Требуется не менее 30.", content.length()));
                }
                return content;
            } else {
                return "";
            }
        }
    }

    private static void solveTask1(String inputFilename, String outputFilename) {
        System.out.println("\n Задание 1: Сумма двух наибольших из 5 чисел ");
        try {
            List<Integer> numbers = readIntsFromFile(inputFilename);

            if (numbers.size() != 5) {
                throw new IllegalArgumentException(
                        "Файл должен содержать ровно 5 целых положительных чисел. Найдено: " + numbers.size());
            }

            numbers.sort(Comparator.reverseOrder());
            int max1 = numbers.get(0);
            int max2 = numbers.get(1);
            int sum = max1 + max2;

            String result = String.format("Два наибольших числа: %d и %d. Сумма: %d", max1, max2, sum);
            System.out.println(result);
            writeToFile(outputFilename, String.valueOf(sum));

        } catch (Exception e) {
            System.err.println("ОШИБКА (Задание 1): " + e.getMessage());
        }
    }
    
    private static void solveTask2(String inputFilename, String outputFilename) {
        System.out.println("\n Задание 2: Сумма произведений цифр четырехзначного числа ");
        try {
            List<Integer> numbers = readIntsFromFile(inputFilename);

            if (numbers.size() != 1) {
                throw new IllegalArgumentException(
                        "Файл должен содержать ровно одно целое положительное число. Найдено: " + numbers.size());
            }

            int n = numbers.get(0);

            if (n < 1000 || n > 9999) {
                throw new IllegalArgumentException(
                        String.format("Число N должно быть четырехзначным (от %d до %d). Получено: %d", 1000, 9999, n));
            }

            int d4 = n % 10;
            int d3 = (n / 10) % 10;
            int d2 = (n / 100) % 10;
            int d1 = (n / 1000) % 10;

            int product1 = d1 * d2;
            int product2 = d3 * d4;

            int sum = product1 + product2;

            String result = String.format("Число N: %d. Произведение первых двух (%d*%d)=%d. Произведение последних двух (%d*%d)=%d. Сумма произведений: %d",
                    n, d1, d2, product1, d3, d4, product2, sum);
            System.out.println(result);
            writeToFile(outputFilename, String.valueOf(sum));

        } catch (Exception e) {
            System.err.println("ОШИБКА (Задание 2): " + e.getMessage());
        }
    }

    private static void solveTask3(String inputFilename, String outputFilename) {
        System.out.println("\n Задание 3: Обмен Min и Max элементами массива ");
        try {
            List<Integer> numList = new ArrayList<>();
            File file = new File(inputFilename);

            if (!file.exists()) {
                throw new FileNotFoundException("Файл не найден: " + inputFilename);
            }

            try (Scanner fileScanner = new Scanner(file)) {
                while (fileScanner.hasNext()) {
                    if (fileScanner.hasNextInt()) {
                        numList.add(fileScanner.nextInt());
                    } else {
                        String invalidToken = fileScanner.next();
                        throw new NumberFormatException("Некорректные данные: ожидалось целое число, получено \"" + invalidToken + "\".");
                    }
                }
            }

            if (numList.size() < 25) {
                throw new IllegalArgumentException(
                        String.format("Размер массива недостаточен (%d элементов). Требуется не менее %d.",
                                numList.size(), 25));
            }

            int[] arr = numList.stream().mapToInt(i -> i).toArray();
            System.out.println("Исходный массив (первые 10): " + Arrays.toString(Arrays.copyOfRange(arr, 0, 10)) + "...");

            int minVal = arr[0];
            int maxVal = arr[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < arr.length; i++) {
                if (arr[i] < minVal) {
                    minVal = arr[i];
                    minIndex = i;
                }
                if (arr[i] > maxVal) {
                    maxVal = arr[i];
                    maxIndex = i;
                }
            }

            arr[minIndex] = maxVal;
            arr[maxIndex] = minVal;

            String newArrayString = Arrays.toString(arr);
            System.out.println(String.format("Поменяны местами Min (%d, индекс %d) и Max (%d, индекс %d).", minVal, minIndex, maxVal, maxIndex));
            System.out.println("Новый массив (первые 10): " + Arrays.toString(Arrays.copyOfRange(arr, 0, 10)) + "...");

            writeToFile(outputFilename, newArrayString);

        } catch (Exception e) {
            System.err.println("ОШИБКА (Задание 3): " + e.getMessage());
        }
    }

    private static void solveTask4(String inputFilename, String outputFilename) {
        System.out.println("\n Задание 4: Слово с наибольшим числом 'd' ");
        try {
            String sentence = readStringFromFile(inputFilename);
            System.out.println("Исходная строка: " + sentence);

            String[] words = sentence.toLowerCase().split("[^a-z]+");

            String bestWord = "";
            int maxDCount = -1;

            for (String word : words) {
                if (word.isEmpty()) continue;

                int currentDCount = 0;
                for (char c : word.toCharArray()) {
                    if (c == 'd') {
                        currentDCount++;
                    }
                }

                if (currentDCount > maxDCount) {
                    maxDCount = currentDCount;
                    bestWord = word;
                }
            }

            String result;
            if (maxDCount > 0) {
                result = String.format("Слово с наибольшим числом 'd' (найдено %d раз): %s", maxDCount, bestWord);
            } else {
                result = "В строке не найдено слов, содержащих букву 'd'.";
                bestWord = result;
            }

            System.out.println(result);
            writeToFile(outputFilename, bestWord);

        } catch (Exception e) {
            System.err.println("ОШИБКА (Задание 4): " + e.getMessage());
        }
    }

    public static void main(String[] args) {
        System.out.println(" Практическая работа № 31: Файловый ввод/вывод ");

        // Вызов всех заданий
        solveTask1("input1.txt", "output1.txt");
        solveTask2("input2.txt", "output2.txt");
        solveTask3("input3.txt", "output3.txt");
        solveTask4("input4.txt", "output4.txt");

        System.out.println("\n Все задания завершены. Проверьте файлы outputN.txt ");
    }
}