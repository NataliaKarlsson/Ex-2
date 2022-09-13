namespace Ex_2
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {


                Console.Write("Enter a number between 1 to 10: ");
                string? str = Console.ReadLine();
                int num = Convert.ToInt32(str);
                bool s = (num >= 1 && num <= 10);

                while (s == false)
                {
                    Console.Write("Enter a number between 1 to 10: ");
                    str = Console.ReadLine();
                    num = Convert.ToInt32(str);
                    s = (num >= 1 && num <= 10);

                }





            }
        
    }
}
    
