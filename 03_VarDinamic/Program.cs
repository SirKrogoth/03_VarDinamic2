using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 123456;
            t2 = "";

            var v1 = "";
            var v2 = 123456;
            //Apresenta ERRO var v3;

            dynamic d1 = new Usuario {nome = "joão"};

            Console.WriteLine(d1.nome);
            //Só apresenta erro em tempo de execução Console.WriteLine(d1.senha);
            //RunTime Exception

            d1 = "";
            Console.ReadKey();
        }
    }

    class Usuario
    {
        public string nome { get; set; }
    }
}
