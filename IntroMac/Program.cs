namespace IntroMac
{
    internal class Program
    {
        public static void Main()
        {
            LittleMan();
            CtoF(20);
            FtoC(68);
            CarpetCost(7, 6, 17);
            NumberOfBalls(1, 0.5, 0.075);
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

        public static void CtoF(double Centigrade)
        {
            double output = (Centigrade * 1.8) + 32;
            Console.WriteLine(output);
        }

        public static void FtoC(double Fahrenheit)
        {
            double output = (Fahrenheit - 32) / 1.8;
            Console.WriteLine(output);
        }

        public static void CarpetCost(double width, double length, double price)
        {
            double BasePrice = price * width * length;
            double Underlay = 3 * width * length;
            double Grippers = width * 2 + length * 2;
            int FittingFee = 50;
            Console.WriteLine(BasePrice + Underlay + Grippers + FittingFee);
        }

        public static void NumberOfBalls(double PitRadius, double PitHeight, double BallRadius)
        {
            double PackingDensity = 0.75;
            double BallPitVolume = Math.PI * PitRadius * PitRadius * PitHeight;
            double BallVolume = 4 * Math.PI * BallRadius * BallRadius * BallRadius / 3;
            Console.WriteLine(Math.Ceiling((BallPitVolume / BallVolume) * PackingDensity));
        }
    }
}