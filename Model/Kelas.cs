using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class Kelas
    {
        public int KelasID { get; set; }
        public int IDPertemuan { get; set; }
        public int IDPelajaran { get; set; }
        public string NamaKelas { get; set; }
    }
}
