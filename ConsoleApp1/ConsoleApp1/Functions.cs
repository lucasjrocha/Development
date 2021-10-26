using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Functions
    {
        static void Main(string[] args)
        {
            //Calculando o preço final de um produto com a função GerarPreco, utilizada mais abaixo:
            Console.WriteLine("Digite o valor do Produto: ");
            int preco = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produtos: ");
            int quantidade = int.Parse(Console.ReadLine());
            //As variaveis utilizadas ao coletar os dados nas funcoes Console acima são passados
            //para dentro dos parametros da função GerarPreco, onde são realizados os "tramites",
            //para gerar o valor desejado com tal função.
            GerarPreco(preco, quantidade);
        }

        static void ExibirMsg()
        {
            Console.WriteLine("Teste de função!");
            Console.WriteLine("Welcome");
        }

        static void GerarPreco(int preco, int quantidade)
        {
            //Console.WriteLine("Nome Produto: " + nome);
            //Console.WriteLine("Valor Produto: " + preco);
            //Para retornar sempre o valor positivo de uma variavel,
            //utiliza-se a função Abs, conforme abaixo:
            //int precoAbs = Math.Abs(preco);

            int valorFinal = (quantidade * preco);
            Console.WriteLine("Valor Final: " + valorFinal);
        }
    }
}
