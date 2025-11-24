namespace Unity_ST
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int c = 2; c < 10; c++)
            {
                Console.WriteLine(c + "단");
                {
                    for (int a = 1; a < 10; a++)

                    {
                        Console.WriteLine($"{c} * {a} = {c * a}");
                    }
                }
            }
            
            

        }
    }
}
