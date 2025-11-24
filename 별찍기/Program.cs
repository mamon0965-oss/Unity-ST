namespace 별찍기
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int a = 1; a < 11; a++)
                if (a % 2 == 0)
                {
                    Console.WriteLine(a + "는 짝수 입니다.");
                }
            else
                {
                    Console.WriteLine(a + "는 홀수 입니다.");
                }

            
            }
        }
    }

