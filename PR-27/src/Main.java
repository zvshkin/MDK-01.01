import java.util.Arrays;
import java.util.InputMismatchException;
import java.util.Random;
import java.util.Scanner;

public class Main {

    private static final int MIN_ARRAY_SIZE = 30;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Random random = new Random();

        System.out.println("\n--- ЗАДАЧА 1: Проверка нечетности суммы цифр трехзначного числа ---");
        int n;

        while (true) {
            System.out.print("Введите целое положительное трехзначное число N (100-999): ");
            try {
                if (scanner.hasNextInt()) {
                    n = scanner.nextInt();
                    scanner.nextLine();

                    if (n < 100 || n > 999) {
                        throw new IllegalArgumentException("Число должно быть положительным и трехзначным (от 100 до 999).");
                    }
                    break;
                } else {
                    String invalidInput = scanner.next();
                    scanner.nextLine();
                    throw new InputMismatchException("Введено нецелое значение: \"" + invalidInput + "\".");
                }
            } catch (InputMismatchException e) {
                System.out.println("ОШИБКА: Требуется ввести целое число. Попробуйте снова.");
            } catch (IllegalArgumentException e) {
                System.out.println("ОШИБКА ВВОДА! " + e.getMessage());
            } catch (Exception e) {
                System.out.println("Произошла непредвиденная ошибка: " + e.getMessage());
            }
        }

        int sumOfDigits = 0;
        int tempN = n;

        while (tempN > 0) {
            sumOfDigits += tempN % 10;
            tempN /= 10;
        }

        boolean isSumOdd = (sumOfDigits % 2 != 0);

        System.out.println("Сумма цифр числа " + n + ": " + sumOfDigits);
        System.out.println("Результат: \"Сумма цифр является нечетным числом\" - " + (isSumOdd ? "ИСТИНА" : "ЛОЖЬ"));


        int size;
        int[] originalArray;

        System.out.println("\n--- ПОДГОТОВКА МАССИВА (для Задач 2 и 3) ---");
        while (true) {
            System.out.print("Введите размер массива (N), минимум " + MIN_ARRAY_SIZE + " элементов: ");
            try {
                if (scanner.hasNextInt()) {
                    size = scanner.nextInt();
                    scanner.nextLine();

                    if (size < MIN_ARRAY_SIZE) {
                        throw new IllegalArgumentException("Размер массива N должен быть не менее " + MIN_ARRAY_SIZE + ".");
                    }
                    originalArray = new int[size];
                    break;
                } else {
                    String invalidInput = scanner.next();
                    scanner.nextLine();
                    throw new InputMismatchException("Введено нецелое значение: \"" + invalidInput + "\".");
                }
            } catch (InputMismatchException e) {
                System.out.println("ОШИБКА: Требуется ввести целое число. Попробуйте снова.");
            } catch (IllegalArgumentException e) {
                System.out.println("ОШИБКА ВВОДА! " + e.getMessage());
            }
        }

        System.out.print("Заполнить массив случайными числами? (y/n): ");
        String choice = scanner.nextLine().trim().toLowerCase();

        if (choice.equals("y")) {
            for (int i = 0; i < size; i++) {
                originalArray[i] = random.nextInt(21) - 10;
            }
        } else {
            System.out.println("Введите " + size + " целых чисел для массива:");
            for (int i = 0; i < size; i++) {
                while (true) {
                    System.out.print("Элемент [" + i + "]: ");
                    try {
                        if (scanner.hasNextInt()) {
                            originalArray[i] = scanner.nextInt();
                            scanner.nextLine();
                            break;
                        } else {
                            String invalidInput = scanner.next();
                            scanner.nextLine();
                            throw new InputMismatchException("Введено нецелое значение: \"" + invalidInput + "\".");
                        }
                    } catch (InputMismatchException e) {
                        System.out.println("ОШИБКА: Требуется ввести целое число. Попробуйте снова.");
                    }
                }
            }
        }
        System.out.println("Исходный массив (длина " + originalArray.length + "): " + Arrays.toString(originalArray));


        System.out.println("\n--- ЗАДАЧА 2: Вставка нулей после отрицательных элементов ---");

        int negativeCount = 0;
        for (int x : originalArray) {
            if (x < 0) {
                negativeCount++;
            }
        }

        int newLength = originalArray.length + negativeCount;
        int[] newArray = new int[newLength];
        int newIndex = 0;

        for (int element : originalArray) {
            newArray[newIndex++] = element;
            if (element < 0) {
                newArray[newIndex++] = 0;
            }
        }

        System.out.println("Новый массив (длина " + newArray.length + "): " + Arrays.toString(newArray));


        System.out.println("\n--- ЗАДАЧА 3: Проверка чередования четных и нечетных чисел ---");

        int resultIndex = 0;

        if (originalArray.length > 1) {
            for (int i = 1; i < originalArray.length; i++) {
                if ((originalArray[i] % 2) == (originalArray[i-1] % 2)) {
                    resultIndex = i + 1;
                    break;
                }
            }
        }

        if (resultIndex == 0) {
            System.out.println("Результат: 0. Четные и нечетные числа чередуются.");
        } else {
            System.out.println("Результат: " + resultIndex + ". Закономерность нарушается на " + resultIndex + "-м элементе (значение: " + originalArray[resultIndex - 1] + ").");
        }

        System.out.println("\n--- ЗАДАЧА 5: Количество слов с одинаковым 2-м и последним символом ---");
        System.out.print("Введите строку со словами, разделенными подчеркиваниями (e.g., apple_banana__level): ");
        String inputString5 = scanner.nextLine();

        int count5 = 0;
        String[] words5 = inputString5.split("_+");

        for (String word : words5) {
            if (word.isEmpty()) continue;

            if (word.length() >= 2) {
                char secondChar = Character.toLowerCase(word.charAt(1));
                char lastChar = Character.toLowerCase(word.charAt(word.length() - 1));

                if (secondChar == lastChar) {
                    count5++;
                }
            }
        }

        System.out.println("Количество слов, у которых второй и последний символ одинаковые: " + count5);

        scanner.close();
    }
}