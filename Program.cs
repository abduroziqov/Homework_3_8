namespace Homework_3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           while (true)
            {
                Console.Write("Enter first number=> "); int.TryParse(Console.ReadLine(), out int firstNum);
                Console.Write("Enter last number=> "); int.TryParse(Console.ReadLine(), out int secondtNum);
                int i = 1, total = 0, flag = 0;

                Console.Write("Perfect numbers between {0} and {1}: ", firstNum, secondtNum);
                for (firstNum = firstNum; firstNum <= secondtNum; firstNum++)
                {
                    for (i = 1; i < firstNum; i++)
                    {
                        if (firstNum % i == 0)
                            total += i;
                    }
                    if ((total == firstNum) && (firstNum != 0))
                    {
                        flag = 1;
                        Console.Write(firstNum + " ");
                    }
                    total = 0;
                }
                if (flag == 0)
                    Console.Write("There in no perfect number between the given range");
                    Console.WriteLine();
            }
        }
    }
}