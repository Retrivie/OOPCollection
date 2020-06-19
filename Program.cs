using System;
using System.Collections.Generic;

namespace OOPCollection
{
    abstract public class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }

    class Karyawantetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji() => GajiBulanan;
    }

    class Karyawanharian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji() => UpahPerJam * JumlahJamKerja;
    }

    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji() => JumlahPenjualan * Komisi;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Karyawantetap karyawanTetap = new Karyawantetap();
            karyawanTetap.Nik = "19.11.2710";
            karyawanTetap.Nama = "Reychandra";
            karyawanTetap.GajiBulanan = 400000;

            Karyawanharian karyawanHarian = new Karyawanharian();
            karyawanHarian.Nik = "19.11.2711";
            karyawanHarian.Nama = "Tristan";
            karyawanHarian.JumlahJamKerja = 12;
            karyawanHarian.UpahPerJam = 100000;

            Sales sales = new Sales();
            sales.Nik = "19.11.2712";
            sales.Nama = "Fahlevie";
            sales.JumlahPenjualan = 10000;
            sales.Komisi = 25000;


            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int i = 1;

            Console.WriteLine("===Karyawan===\n");

            foreach (Karyawan karyawan in listKaryawan)
            {

                Console.WriteLine(" {0}.\tNIK: {1}\n\tNama: {2} \n\tGaji: {3:N0}\n", i, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                i++;
            }

        }
    }
}
