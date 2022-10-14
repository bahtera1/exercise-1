using System;


namespace exercise_1
{
    class exercise
    {
        private int[] a = new int[78];

        private int n;

        public void read()
        {
            while(true)
            {
                Console.WriteLine("masukan banyak pada elemen array");
                string s = Console.ReadLine();
                n =Int32.Parse(s);
                if (n < 78)
                    break;
                else
                    Console.WriteLine("array dapat memiliki nilai maksimal 78 elemen");

            }
        }
    }
}
 












static void Main(string[] args)
{
    
}
