    using System;

    namespace tugas_modul4
    {
        class Program
        {
            static void non_return(string a, string b, string c)
            {
                Console.WriteLine("Program By {0} dan {1} dari kelompok {2}", a, b, c);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Menghitung Keuntungan Investasi SBR");
                Console.WriteLine("-----------------------------------");
                
                //info pembeli
                string nama;
                Console.WriteLine("Masukan Nama Anda = ");
                nama = (Console.ReadLine());
                //rumus
                double nominal, keuntungan, untung;
                Console.WriteLine("Masukan Nominal Pembelian SBR Anda = ");
                nominal = Convert.ToInt32(Console.ReadLine());
                keuntungan = nominal * 0.063 * 0.85 / 12;
                untung = keuntungan * 12;
                Console.WriteLine("Nama Anda Adalah = ");
                if (nominal < 1000000)
                {
                    Console.WriteLine("Minimal Pembelian SBR Adalah Rp. 1000000 dan maksimal Rp. 3000000000");
                }
                else if (nominal >= 1000000 || nominal <= 3000000000)
                {
                    int i = 1;
                    while (i < 13)
                    {
                        Console.WriteLine("Keuntungan Bulan ke-" + i);
                        Console.WriteLine("Sebesar = Rp. " + keuntungan);
                        i++;
                    }

                Console.ReadKey();
                Console.WriteLine("Total Keuntungan Tahunan Sebesar = Rp. " + untung);
            }


            non_return("Gusti", "Bowo", "Kelompok 07");


        }
    }
}
