using System;
public class Program
{
    public static void Main()
    {
        bool m = true;
        while (m)
        {
            {
                Console.WriteLine("Введите числа:");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    m = false;
                }
                while (n > 0)
                {  
                    int count = 0;
                    int res = 0;
                    int b = n;
                    while (b > 0)
                    {
                        if ((b % 10) % 2 != 0)
                        {
                            b = b / 10;
                        }
                        else
                        {
                            res = res * 10 + b % 10;
                            b = b / 10;
                            count++;
                        }
                    }
                    
                    if (count == 0)
                    {
                        Console.WriteLine("Четных цифр нет");
                        break;
                    }
                    
                    else
                    {
                        Console.WriteLine(res);
                        break;
                    }
                    
                }
            }
        }
    }  
}