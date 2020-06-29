using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Lab_9.ClassInduk
{
    public abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }

        public abstract double Gaji();

        public abstract string jenis();
    }
}
