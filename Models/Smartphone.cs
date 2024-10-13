using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_celular_em_C_Sharp.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int armazenamento)
        {
            Numero = numero;

            Modelo = modelo;

            IMEI = imei;

            Armazenamento = armazenamento;
        }
        public string Numero { get; set; }

        private string Modelo { get; set; }

        private string IMEI { get; set; }

        private int Armazenamento { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Realizando ligação...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string app);
    }
}
