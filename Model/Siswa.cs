using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class Siswa : User
    {
        public int NIS { get; set; }
        public string NamaSiswa { get; set; }
        public int KelasID { get; set; }
    }
}
