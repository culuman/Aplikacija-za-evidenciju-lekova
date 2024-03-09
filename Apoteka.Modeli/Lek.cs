using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Modeli
{
    public class Lek
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string Proizvodjac { get; set; }
        public string Bolest { get; set; }
        public string Kolicina { get; set; }
    }
}