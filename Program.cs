using System;

namespace Exercicio1_Estruturas_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Digite uma nota entre 0 e 10 ! : ");//exibição da mensagem 
            float nota = float.Parse(Console.ReadLine());//entrada e armazenamento da nota

            while(nota <0 || nota >10){//enquanto for verdadeira a condição -->>(nota for menor que 0 ou maior que 10),então :
            Console.WriteLine("Nota Inválida !");//exibição da mensagem
            Console.Write("Digite novamente uma nota entre 0 e 10 ! : ");//exibição da mensagem
            nota = float.Parse(Console.ReadLine());//entrada e armazenamento da nota        
            
            }

            Console.WriteLine("Nota Válida !");//se falsa a condição , então exiba a mensagem e encerra

        }

    }
}
