using System;

namespace TestTaskMironovKrossInform
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = { { 9, 1, 2 }, { 3, 4, 5 }, {6, 7, 8 } };
            //int[,] table = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
            int answer = Task(table);
            if (answer != 0)
            {
                Console.WriteLine("Ответ: {0}", answer);
                Console.WriteLine("Нажмите любую клавишу для завершения.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Числа в таблице должны быть в диапазоне от 1 до 9.");
                Console.ReadKey();
            }
        }

        static int Task(int[,] table)
        {
            int k = 0;
            int answer = 0;
            for (int i=0; i<3; i++)
                for (int j=0; j<3; j++)
                {
                    if ((table[i, j] >= 1) && (table[i, j] <= 9))
                    {
                        switch (table[i, j])
                        {
                            case 9:
                                answer = answer + 900000000;
                                break;
                            case 8:
                                answer = answer + 80000000;
                                break;
                            case 7:
                                answer = answer + 7000000;
                                break;
                            case 6:
                                answer = answer + 600000;
                                break;
                            case 5:
                                answer = answer + 50000;
                                break;
                            case 4:
                                answer = answer + 4000;
                                break;
                            case 3:
                                answer = answer + 300;
                                break;
                            case 2:
                                answer = answer + 20;
                                break;
                            case 1:
                                answer = answer + 1;
                                break;
                        }

                    }
                    else
                    {
                        k = 1;
                    }
                }

            if (k==0)
            {
                return answer;
            }
            else
            {
                return 0;
            }
        }
    }
}
