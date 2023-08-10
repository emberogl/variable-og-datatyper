namespace Opgaver
{
    class Opgave1
    {
        static void Main(string[] args)
        {
            int length = 16;
            double width = 5.1;

            /// Der bliver udskrevet 81.6
            Console.WriteLine(length * width);

            /// Der kan ikke implicit konverteres typen double til int, så der opstår fejl
            int area = width * length;

            /// Der opstår ikke fejl, da operationen width * length giver en decimal værdi
            double d = width * length;
        }
    }
}