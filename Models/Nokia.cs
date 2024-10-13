using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_celular_em_C_Sharp.Models
{
    public class Nokia : Smartphone
    {

        public Nokia(string nome, string modelo, string imei, int armazenamento) : base(nome, modelo, imei, armazenamento)
        {

        }
        public override void InstalarAplicativo(string app)
        {
            Console.WriteLine($"{app} instalado no Nokia");
        }
    }
}
