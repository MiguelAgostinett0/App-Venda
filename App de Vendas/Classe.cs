using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_de_Vendas
{
    class Classe
    {
        public int id { get; set; }
        public string produto { get; set; }
        public int quantidade { get; set; }
        public double valor_uni { get; set; }
        public string valor_total { get { return string.Format("{0}$", valor_uni * quantidade); } }
    }
}
