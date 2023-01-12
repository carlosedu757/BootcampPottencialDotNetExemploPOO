using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampPottencialDotNetExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor() 
        { 

        }
        public Professor(string nome) : base(nome) { }
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é {Salario.ToString("C")}");
        }
    }
}
