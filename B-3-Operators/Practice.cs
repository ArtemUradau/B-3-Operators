using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            int a, b, c;
            Console.WriteLine("Введите первое число: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Int32.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine($"Сумма чисел: {c}");
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            int a, b, c1,c2;
            Console.WriteLine("Введите первое число: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Int32.Parse(Console.ReadLine());
            c1 = a + b;
            Console.WriteLine("Введите результат вычисления: ");
            c2 = Int32.Parse(Console.ReadLine());
            if(c2==c1)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            int a, b, c1, c2;
            Console.WriteLine("Введите первое число: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Int32.Parse(Console.ReadLine());
            c1 = a + b;
            Console.WriteLine("Введите результат вычисления: ");
            c2 = Int32.Parse(Console.ReadLine());
            if (c2 == c1)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }
            if (c2 < c1)
            {
                Console.WriteLine("Должно быть больше");
            }
            if (c2 > c1)
            {
                Console.WriteLine("Должно быть меньше");
            }
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            int a, b, c1 = 0, c2, op;
            Console.WriteLine("Введите первое число: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Выберите оператор(1+/2-)");
            op = Int32.Parse(Console.ReadLine());
            if (op == 1)
            {
                c1 = a + b;
            }
            if (op == 2)
            {
                c1 = a - b;
            }
            Console.WriteLine("Введите результат вычисления: ");
            c2 = Int32.Parse(Console.ReadLine());
            if (c2 == c1)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }
            if (c2 < c1)
            {
                Console.WriteLine("Должно быть больше");
            }
            if (c2 > c1)
            {
                Console.WriteLine("Должно быть меньше");
            }
        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            int a, b, c1 = 0, c2, op;
            Console.WriteLine("Введите первое число: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Выберите оператор(1+/2-)");
            op = Int32.Parse(Console.ReadLine());
            if (op == 1)
            {
                c1 = a + b;
            }
            if (op == 2)
            {
                c1 = a - b;
            }
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Введите результат вычисления: ");
                c2 = Int32.Parse(Console.ReadLine());
                if (c2 == c1)
                {
                    Console.WriteLine("Правильно");
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильно");
                }
                if (c2 < c1)
                {
                    Console.WriteLine("Должно быть больше");
                }
                if (c2 > c1)
                {
                    Console.WriteLine("Должно быть меньше");
                }
            }
        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            const int N = 5;
            int[] num = new int[N];
            int c2,sum=0;
            for(int i=0;i<N;i++)
            {
                Console.WriteLine($"Введите {i+1} число: ");
                num[i] = Int32.Parse(Console.ReadLine());
                sum += num[i];
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите результат вычисления: ");
                c2 = Int32.Parse(Console.ReadLine());
                if (c2 == sum)
                {
                    Console.WriteLine("Правильно");
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильно");
                }
                if (c2 < sum)
                {
                    Console.WriteLine("Должно быть больше");
                }
                if (c2 > sum)
                {
                    Console.WriteLine("Должно быть меньше");
                }
            }
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            //Если решение правильное, цикл прерывается, программа завершается(было реализовано ранее)
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            const double pi = 3.1415926;
            double rad, sq;
            Console.WriteLine("Введите радиус круга: ");
            rad = Double.Parse(Console.ReadLine());
            sq = rad * rad * pi;
            Console.WriteLine($"Радиус круга: {sq}");
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            int credit1,percent;
            double credit2;
            Console.WriteLine("Введите сумму кредита: ");
            credit1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите проценты кредита: ");
            percent = Int32.Parse(Console.ReadLine());
            credit2 = (credit1 / 100) * percent + credit1;
            double mon = credit2 / 12;
            Console.WriteLine("Выплаты по месяцам: ");
            for (int i=1;i<=12;i++)
            {
                Console.WriteLine($"{i} месяц- {i*mon} рублей");
            }
            Console.WriteLine($"Общая сумма выплат составит: {credit2}");
        }
    }
}
