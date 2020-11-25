using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Confirme a sua categoria, informe a sua idade");
            Console.WriteLine("------------");

            Console.WriteLine("Digite a sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade >=5 && idade  <=7)
            {
                Console.WriteLine("Categoria: Infantil A");
                 Console.WriteLine("Atençã ao anuncio das categorias. Boa Sorte!");
            }
            else if (idade >=8 && idade <= 10)
            {
                Console.WriteLine("Categoria: Infantil B");
                 Console.WriteLine("Atenção ao anuncio das categorias. Boa Sorte!");
            }
            else if( idade >=11 && idade <=13)
            {
                Console.WriteLine("Categoria: Juvenil A");
                 Console.WriteLine("Atenção ao anuncio das categorias. Boa Sorte!");
            }
             else if( idade >=14 && idade <=17)
            {
                Console.WriteLine("Categoria: Juvenil B");
                 Console.WriteLine("Atenção ao anuncio das categorias. Boa Sorte!");
            }
              else if( idade >=18)
            {
                Console.WriteLine("Categoria: Adulto");
                 Console.WriteLine("Atenção ao anuncio das categorias. Boa Sorte!");
            }
            else if(idade <= 4)
            {
                Console.WriteLine(" Poxa! A idade minima para particpar é 5 anos");
            }
           

        }
    }
}
