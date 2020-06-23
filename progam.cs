using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 2673
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19119080";
            karyawanTetap.Nama = "Paul Pogba";
            karyawanTetap.GajiBulanan = 10000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "1911998";
            karyawanHarian.Nama = "Wayne Rooney";
            karyawanHarian.JumlahJamKerja = 10;
            karyawanHarian.UpahPerJam = 50000;

            Sales sales = new Sales();
            sales.Nik = "19118012";
            sales.Nama = "Zlatan Ibrahimovic";
            sales.JumlahPenjualan = 20;
            sales.Komisi = 95000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}