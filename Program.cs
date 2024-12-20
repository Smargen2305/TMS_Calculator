namespace TmsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continueProgram = true;

            while (continueProgram)
            {

                double firstValue, secondValue;
                string userAction;

                try
                {
                    Console.WriteLine("Введите первое число: ");
                    firstValue = double.Parse(Console.ReadLine());
                    var sqrtValue = firstValue;                         // sqrtValue используется для извлечения квадратного корня из числа

                    Console.WriteLine("Введите второе число: ");
                    secondValue = double.Parse(Console.ReadLine());

                    double percentResult = (firstValue / secondValue) * 100;

                    Console.WriteLine("Выберите операцию: [+] [-] [*] [/] [%] [sqrt]");
                    userAction = Console.ReadLine();

                        switch (userAction)
                        {
                            case "+":
                                Console.WriteLine("Сумма двух чисел = " + (firstValue + secondValue));
                                break;
                            case "-":
                                Console.WriteLine("Разность двух чисел = " + (firstValue - secondValue));
                                break;
                            case "*":
                                Console.WriteLine("Произведение двух чисел = " + (firstValue * secondValue));
                                break;
                            case "/":
                                if (secondValue == 0 && userAction == "/")
                                {
                                    Console.WriteLine("На ноль делить нельзя");
                                }
                                else
                                {
                                    Console.WriteLine("Деление двух чисел = " + (firstValue / secondValue));
                                }
                                break;
                            case "%":
                                Console.WriteLine($"Число {firstValue} равно = " + percentResult + "%" + $" от числа {secondValue}");
                                break;
                            case "sqrt":
                                Console.WriteLine($"Квадратные корень из числа {firstValue} равен = " + Math.Sqrt(sqrtValue));
                                break;
                            default:
                                Console.WriteLine("Вы ввели неверный символ");
                                break;
                        }
                    }
                catch (Exception ex)
                {
                    Console.WriteLine($"Это не число: {ex.Message}");
                }
            Console.Write("Хотите выполнить новый расчёт? (да/нет): ");
            string input = Console.ReadLine();
                if (input.ToLower() != "да")
                {
                    continueProgram = false;
                    Console.WriteLine("Программа завершена.");
                }
            }
        }

    }
}
