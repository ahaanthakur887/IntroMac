namespace IntroMac
{
    internal class Program
    {
        public static void Main()
        {
            LittleMan();
            Console.WriteLine(CtoF(20.0));
            Console.ReadLine();
        }

        public static void LittleMan()
        {
            Console.WriteLine("*******");
            Console.WriteLine("*     *");
            Console.WriteLine("*  0  *");
            Console.WriteLine("* /|\\ *");
            Console.WriteLine("* / \\ *");
            Console.WriteLine("*******");
        }

        public static void CtoF(float Centigrade)
        {
            float output = (Centigrade * 1.8) + 32;
            Console.WriteLine(output);
        }

        public static void FtoC()
        {

        }
    }
}