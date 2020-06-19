using System;
using System.Collections.Generic;

namespace OOPCollection
{
    abstract public class Mobil
    {
        public int Kode { get; set; }
        public string Tipe { get; set; }
        public string Nama { get; set; }
        public int Tahun { get; set; }
        public abstract double Pajak();
    }

    class Sedan : Mobil
    {
        public double Mesin { get; set; }
        public double PenggerakRoda { get; set; }
        public override double Pajak() => Mesin * PenggerakRoda * 60;
    }

    class MPV : Mobil
    {
        public double Mesin { get; set; }
        public double PenggerakRoda { get; set; }
        public double KapasitasPenumpang { get; set; }
        public override double Pajak() => Mesin * PenggerakRoda * KapasitasPenumpang * 60;
    }

    class SUV : Mobil
    {
        public double Mesin { get; set; }
        public double PenggerakRoda { get; set; }
        public double JumlahSilinder { get; set; }
        public override double Pajak() => Mesin * PenggerakRoda * JumlahSilinder * 60;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Sedan sedan = new Sedan();
            sedan.Kode = 19112710;
            sedan.Tipe = "Sedan";
            sedan.Nama = "BMW 7 Series";
            sedan.Tahun = 2020;
            sedan.Mesin = 4400;
            sedan.PenggerakRoda = 4;

            MPV mpv = new MPV();
            mpv.Kode = 19112711;
            mpv.Tipe = "MPV";
            mpv.Nama = "Toyota Alphard";
            mpv.Tahun = 2020;
            mpv.Mesin = 3500;
            mpv.PenggerakRoda = 2;
            mpv.KapasitasPenumpang = 7;

            SUV suv = new SUV();
            suv.Kode = 19112712;
            suv.Tipe = "SUV";
            suv.Nama = "Mercedes-Benz GLS 500";
            suv.Tahun = 2020;
            suv.Mesin = 4700;
            suv.PenggerakRoda = 4;
            suv.JumlahSilinder = 8;
            

            List<Mobil> listMobil = new List<Mobil>();
            listMobil.Add(sedan);
            listMobil.Add(mpv);
            listMobil.Add(suv);

            int i = 1;

            foreach (Mobil mobil in listMobil)
            {
                Console.WriteLine("{0}\tKode: {1}\n\tTipe: {2}\n\tNama: {3}\n\tTahun: {4}\n\tPajak: Rp {5},00\n", i, mobil.Kode, mobil.Tipe, mobil.Nama, mobil.Tahun, mobil.Pajak());
                i++;
            }

        }
    }
}
