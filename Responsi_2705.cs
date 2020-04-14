using System;

namespace responsi2705
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan = new Karyawan(1, 19112705, "Yudha Tira", 3000000);
            Karyawan karyawan1 = new Karyawan(2, 19112705, "Pamungkas", 2000000);

            Console.WriteLine("NO \t NIK \t\t NAMA \t\t GAJI");
            Console.WriteLine("------------------------------------------------");
            karyawan.tampil();
            karyawan1.tampil();

            Console.WriteLine("\nAsyik naik gaji nih 10%!!\n");

            Console.WriteLine("NO \t NIK \t\t NAMA \t\t GAJI");
            Console.WriteLine("------------------------------------------------");
            karyawan.hitunggaji();
            karyawan1.hitunggaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int no { get; set; }
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int no, int nik, string nama, int gaji)
        {
            this.no = no;
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0) {
                this.gajiBulanan = 0;
            } else {
                this.gajiBulanan = gaji;
            }
        }

        public void tampil()
        {
            Console.WriteLine("{0} \t {1} \t {2}\t {3}", no, nik, nama, gajiBulanan);
        }

        public void hitunggaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}\t {3}", no, nik, nama, gajiBulanan);
        }
    }
}
