using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab2_Uchebniy_otdel
{
    public class Lector
    {
        [Required(ErrorMessage = "Отсутствуем имя лектора", AllowEmptyStrings = false)]
        public string lastname { get; set; }
        public string name { get; set; }
        public string otchestvo { get; set; }
        public string audience { get; set; }
    }
}
