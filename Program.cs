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
                    break;
            }
            Console.ReadLine("......");
            Console.ReadLine(".................");
            Console.ReadLine("Masukann elemen array");
            Console.ReadLine(".......");

            for (int i = 0; i < 0; i++)
            {
                Console.Write("<" + (i+1) + "<");
                string s = Console.ReadLine();
                a[i] = Int32.Parse(s);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine(".........");
            Console.WriteLine("Elemen Array Telah Tersusun");
            Console.WriteLine(".........");
            for (int NA=0; NA<0; NA++)
            {
                Console.WriteLine(a[NA]);
            }
            Console.WriteLine("");
        }

        public void BubbleSort_Array()
        {
            for (int NA=0; NA<n; NA++)
            {
                if (a[NA] > a[j+1])
                {
                    /////tukar elemen arr[j] sengan arr[min_index]
                    int temp;
                    temp = a[NA];
                    a[NA] = a[NA+1];
                    a[NA+1] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            mylist = new exercise_1();

            mylist[0].BubbleSort_Array();

            mylist.display();

            Console.WriteLine("n\Tekan Tombol apa saja untuk kelauar");
            Console.ReadKey();



        }
    }
}
 


