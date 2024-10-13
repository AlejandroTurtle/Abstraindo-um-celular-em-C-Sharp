using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_celular_em_C_Sharp.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string nome, string modelo, string imei, int armazenamento) : base(nome, modelo, imei, armazenamento)
        {

        }

        public override void InstalarAplicativo(string app)
        {
            Console.WriteLine($"{app} instalado no iphone");
        }
    }
}
