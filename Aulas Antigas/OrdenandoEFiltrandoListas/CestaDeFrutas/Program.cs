using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();

            #region Carregando minha cesta
            //Tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            //Goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95 
            });
            //Manga
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Vermelho",
                Peso = 400,
            });
            #endregion

            //ordena a lista em ordem descendente, por números ou por ordem alfabética OrderBy = Ascendente
            #region lista1
            cestaDeFrutas.OrderByDescending(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id}  Nome: {i.Nome} Cor: {i.Cor} Peso: {i.Peso}"));
            #endregion

            Console.WriteLine("------------------------------------- Filtro 100gr +");

            #region lista2

            var filtroCesta = cestaDeFrutas
                              //aqui filtramos os registros maiores de 100 granas 
                              .Where(x => x.Peso > 100)
                              //Ordernamos estes valores pelo nome 
                              .OrderBy(x => x.Nome);
            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"ID : {i.Id} Nome: {i.Nome} Peso: {i.Peso} "));

            #endregion

            Console.WriteLine("------------------------------------- Filtro nome");
           
            #region lista3
            (from frutinha in cestaDeFrutas
             where frutinha.Nome == "Manga"
             select frutinha).ToList<Fruta>().ForEach(i => Console.WriteLine($"ID: {i.Id} Nome: {i.Nome} Peso: {i.Peso}"));

            #endregion

            Console.WriteLine("------------------------------------- Filtro cor");

            //aqui filtro as informações e obtenho um valor 
            var mostrandoFind = cestaDeFrutas.Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            //aqui mostro o valor filtrado
            Console.WriteLine($"Id {mostrandoFind.Id}  Nome: {mostrandoFind.Nome}");
            //aqui filtro e obtenho todos os items que contém essas informações
            var mostrandoFindAll = cestaDeFrutas.FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            //aqui listo estes items usando a função foreach do LINQ
            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome}"));
            //Aqui ordenamos a lista pelo nome
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            //Como agora ele não é mais um List<Fruta> usamos o foreach para apresentar os valores
            foreach (var item in listaOrdenada)
                Console.WriteLine($"ID {item.Id} Nome {item.Nome}");


            Console.WriteLine("----------------------------------- Find com OrderBy");
            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().Find(x => x.Cor == "Amarelo" || x.Cor == "Verde");

            Console.WriteLine($"{cestaDeFrutasFindOrder.Nome}");

            Console.ReadKey();
        }
    }
}
