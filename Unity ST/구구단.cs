namespace Unity_ST
{
    internal class 구구단
    {
        static void Main(string[] args)
        {

            for (int a = 2; a < 10; a++)
            {
                Console.WriteLine(a + "단");
                
                    for (int b = 1; b < 10; b++)   
                    {
                        Console.WriteLine($"{a} * {b} = {a * b}");
                    }
                }
            
            
            

        }
    }
}
