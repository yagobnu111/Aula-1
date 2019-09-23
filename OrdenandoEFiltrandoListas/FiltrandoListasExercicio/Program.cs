using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrandoListasExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoas = new List<Pessoa>();
            var inf = @"1,Spears,07/11/2004,846.96;
2,Swanson,20/06/2003,233.09;
3,Gay,03/12/2001,911.92;
4,Gregory,02/01/2000,469.01;
5,Olson,18/07/2001,261.90;
6,Garza,01/04/2000,360.41;
7,Sweet,12/03/2003,312.76;
8,Cline,26/03/2002,484.51;
9,Oliver,05/07/2004,513.76;
10,Vang,10/07/2000,271.05;
11,Maddox,29/05/2004,783.97;
12,Garrett,03/06/2006,154.11;
13,Mcintosh,06/07/2006,902.80;
14,Yang,29/04/2005,550.48;
15,Hendricks,05/09/2003,410.56;
16,Cain,12/01/2002,221.13;
17,Blackburn,10/05/2000,135.67;
18,Howe,27/09/2005,360.14;
19,Pratt,18/09/2000,991.83;
20,Sherman,20/02/2003,667.00";
;

            var pessoaSplitter = inf.Split(';');
            var id = 0;
            var nome = "";
            DateTime data ;
            double carteira = 0;

            for (int i = 0; i < 20; i++)
            {
                id = int.Parse(pessoaSplitter[i].Split(',')[0]);
                nome = pessoaSplitter[i].Split(',')[1];
                data = DateTime.Parse(pessoaSplitter[i].Split(',')[2]);
                carteira = Double.Parse(pessoaSplitter[i].Split(',')[3].Replace('.', ','));

                listaPessoas.Add(new Pessoa(id, nome, data, carteira));
                /*listaPessoas.Add(new Pessoa()
                {
                    Id = id,
                    Nome = nome,
                    DataNascimento = data,
                    Carteira = carteira
                });*/



            }

            Console.WriteLine("---------------------Lista Por ID----------------------------\n");
            listaPessoas.ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Data: {i.DataNascimento.ToString("dd:MM:yyyy")} Carteira: {i.Carteira}"));
            
            
            Console.WriteLine("---------------------Lista por Nome--------------------------\n");
            //ordenando pelo nome e convertendo em uma lista
            List<Pessoa> listaPorNome = listaPessoas.OrderBy(x => x.Nome).ToList();
            //listando essa lista ordenada
            listaPorNome.ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Data: {i.DataNascimento.ToString("dd:MM:yyyy")} Carteira: {i.Carteira}"));



            Console.WriteLine("---------------------Lista por Data Nasc--------------------------\n");
            List<Pessoa> listaPorData = listaPessoas.OrderByDescending(x => x.DataNascimento).ToList();
            listaPorNome.ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Data: {i.DataNascimento.ToString("dd:MM:yyyy")} Carteira: {i.Carteira}"));

            Console.WriteLine("---------------------Lista de Ricos------------------------------\n");
            List<Pessoa> listaPorCarteira = listaPessoas.Where(x => x.Carteira > 500.00).ToList();
            listaPorCarteira.ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Data: {i.DataNascimento.ToString("dd:MM:yyyy")} Carteira: {i.Carteira}"));

            Console.WriteLine("--------------------Lista 18+ -----------------------------------\n");
            List<Pessoa> listaPorMaiores18 = listaPessoas.Where(x => DateTime.Now.Year - x.DataNascimento.Year >= 18).ToList();
            listaPorMaiores18.ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Data: {i.DataNascimento.ToString("dd:MM:yyyy")} Carteira: {i.Carteira}"));

            Console.WriteLine("--------------------Lista 16- -----------------------------------\n");
            List<Pessoa> listaPorMenores18 = listaPessoas.Where(x => DateTime.Now.Year - x.DataNascimento.Year <= 16).ToList();
            listaPorMenores18.ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Data: {i.DataNascimento.ToString("dd:MM:yyyy")} Carteira: {i.Carteira}"));


            Console.ReadLine();
 
        }

    }
}
