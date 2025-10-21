import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // ------------------- ЗАДАНИЕ 1 -------------------
        System.out.println("Задание 1: Проверка, что ровно два из чисел A, B, C положительные.");
        System.out.print("Введите A: ");
        int A = scanner.nextInt();
        System.out.print("Введите B: ");
        int B = scanner.nextInt();
        System.out.print("Введите C: ");
        int C = scanner.nextInt();

        int countPositive = 0;
        if (A > 0) countPositive++;
        if (B > 0) countPositive++;
        if (C > 0) countPositive++;

        if (countPositive == 2) {
            System.out.println("Истинно: ровно два числа положительные.");
        } else {
            System.out.println("Ложно: условие не выполняется.");
        }

        // ------------------- ЗАДАНИЕ 2 -------------------
        System.out.println("\nЗадание 2: Проверка, что все цифры четырехзначного числа различны.");
        System.out.print("Введите четырехзначное число: ");
        int number = scanner.nextInt();

        if (number < 1000 || number > 9999) {
            System.out.println("Ошибка: число должно быть четырехзначным!");
        } else {
            int d1 = number / 1000;
            int d2 = (number / 100) % 10;
            int d3 = (number / 10) % 10;
            int d4 = number % 10;

            boolean allDifferent = d1 != d2 && d1 != d3 && d1 != d4 &&
                    d2 != d3 && d2 != d4 &&
                    d3 != d4;

            if (allDifferent)
                System.out.println("Истинно: все цифры различны.");
            else
                System.out.println("Ложно: есть одинаковые цифры.");
        }

        // ------------------- ЗАДАНИЕ 3 -------------------
        System.out.println("\nЗадание 3: Разница между суммой всех цифр и произведением четных цифр пятизначного числа.");
        System.out.print("Введите пятизначное число N (>0): ");
        int N = scanner.nextInt();

        if (N < 10000 || N > 99999) {
            System.out.println("Ошибка: число должно быть пятизначным и положительным!");
        } else {
            int sum = 0;
            int productEven = 1;
            boolean hasEven = false;

            int temp = N;
            while (temp > 0) {
                int digit = temp % 10;
                sum += digit;
                if (digit % 2 == 0) {
                    productEven *= digit;
                    hasEven = true;
                }
                temp /= 10;
            }

            if (!hasEven) productEven = 0; // если нет четных цифр
            int result = sum - productEven;

            System.out.println("Сумма цифр: " + sum);
            System.out.println("Произведение четных цифр: " + productEven);
            System.out.println("Разница (сумма - произведение): " + result);
        }

        // ------------------- ЗАДАНИЕ 4 -------------------
        System.out.println("\nЗадание 4: Определение количества полных метров в сантиметрах.");
        System.out.print("Введите расстояние L (в см): ");
        int L = scanner.nextInt();

        if (L < 0) {
            System.out.println("Ошибка: расстояние не может быть отрицательным!");
        } else {
            int meters = L / 100;
            System.out.println("Полных метров: " + meters);
        }

        // ------------------- ЗАДАНИЕ 5 -------------------
        System.out.println("\nЗадание 5: Описание оценки по числу K (1–5).");
        System.out.print("Введите оценку K: ");
        int K = scanner.nextInt();

        String gradeDescription = switch (K) {
            case 1 -> "плохо";
            case 2 -> "неудовлетворительно";
            case 3 -> "удовлетворительно";
            case 4 -> "хорошо";
            case 5 -> "отлично";
            default -> "Ошибка";
        };
        System.out.println("Результат: " + gradeDescription);
    }
}
