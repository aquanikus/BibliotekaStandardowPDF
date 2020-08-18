using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaStandardowPDF.Models
{
    public class Dokument
    {
        [Key]
        public int Id_dokumentu { get; set; }
        public string Temat { get; set; }
        public string Tresc { get; set; }
    }
}
