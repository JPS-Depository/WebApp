using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class Guru : User
    {
        public int NIP { get; set; }
        public int KelasID {get; set;}
        public int NamaGuru { get; set; }
    }
}
