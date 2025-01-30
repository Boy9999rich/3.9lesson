namespace _3._9lesson
{
    internal class Program
    {
        public delegate void Calculate(int otabekzor, int islomzor);
        static void Main(string[] args)
        {
            //Calculate calculatde = Add;
            //calculatde += multiply;
            //calculatde += divide;
            //calculatde += minus;

            //calculatde.Invoke(10, 5);


            Func<int, int, int> func = Add;
            func += minus;
            func.Invoke(15, 10);
            
            

        }
        public static int Add(int number, int nomer)
        {
            var res = number + nomer;
            return res;
        }
        public static void multiply(int number, int nomer)
        {
            var res = number * nomer;
            Console.WriteLine($"{res} is multiply result");
        }
        public static void divide(int number, int nomer)
        {
            var res = number / nomer;
            Console.WriteLine($"{res} is divide result");
        }
        public static int minus(int number, int nomer)
        {
            var res = number - nomer;
            return res;
        }
    }
}
