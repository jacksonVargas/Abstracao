using System;

namespace Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoafisica = new PessoaFisica();
            pessoafisica.TaxaEmprestimo(1500);
            Console.WriteLine("----------------------------------");

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.TaxaEmprestimo(1500);
        }
    }
}
