using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Conditionals
    {
        //- Enum serve para enumerar, procurar na documentação para maiores detalhes Lucas
        enum Cor { Azul, Verde, Amarelo, Vermelho };

        enum Opcao { Criar, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
         {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            


            Console.ReadLine();





            //- Condicionais de if/else:
            //Console.Write("Digite dua idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //    if (idade >= 00 && idade <= 11)
            //    {
            //        Console.WriteLine("Você é uma criança!");
            //    }
            //    else if (idade >= 12 && idade <= 18)
            //    {
            //        Console.WriteLine("Você é um adolescente!");
            //    }
            //    else if (idade >= 19 && idade < 60)
            //    {
            //        Console.WriteLine("Você é um adulto!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Você é um idoso!");
            //    } 

            //- Condicional switch
            //caso a cor(dado) informado pelo usuário for inválido, ou seja, não conste na lista de casos
            //vai para a última condicional que é o "default", para não ficarmos sem retorno por não conter o valor.

            //string cor = "Azul";

            //switch (cor)
            //{
            //    case "Vermelho":
            //        Console.WriteLine("Sua cor favorita é Vermelho!");
            //        break;
            //    case "Amarelo":
            //        Console.WriteLine("Sua cor favorita é Amarelo!");
            //        break;
            //    case "Azul":
            //        Console.WriteLine("Sua cor favorita é Azul!");
            //        break;
            //    case "Rosa":
            //        Console.WriteLine("Sua cor favorita é Rosa!");
            //        break;
            //    default:
            //        Console.WriteLine("Cor inválida.");
            //        break;
            //}

            ////- Enum
            //Cor corFavorita = Cor.Vermelho;
            //Cor corFavoritaCarla = Cor.Azul;

            ////Uma das formas de acessar os valores dentro de um objeto do tipo enum:
            //Console.WriteLine(corFavorita);
            //Console.WriteLine(corFavoritaCarla);
            ////Desta forma abaixo o valor retornado será o numero da posicao deste enum
            //Console.WriteLine((int)corFavorita);
            ////Desta outra forma o valor retornado será o dado daquela posicao no enum
            //Console.WriteLine((Cor)2);



        }
    }
}
