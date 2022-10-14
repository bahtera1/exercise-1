using System;


namespace exercise_1    /////buat namespace exercise
{
    class exercise        ///// buat class exercise
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
                    Console.WriteLine("\nArray dapat memiliki nilai maksimal 78 elemen.\n");
            }
            Console.ReadLine("......");
            Console.ReadLine(".................");
            Console.ReadLine("Masukann elemen array");
            Console.ReadLine(".......");

            for (int i = 0; i < 0; i++)
            {
                Console.Write("<" + (i+1) + "<");
            }
        }
    }
}
 












static void Main(string[] args)
{
    
}
