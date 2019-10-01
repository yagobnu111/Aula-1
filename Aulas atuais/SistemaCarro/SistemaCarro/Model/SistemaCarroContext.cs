
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCarro.Model
{
    public class SistemaCarrosContext
    {
        public List<Carro> listaDeCarros { get; set; }
        public SistemaCarrosContext()
        {
            listaDeCarros = new List<Carro>();

            listaDeCarros.Add(new Carro { Id = 1, Marca = "Ford", Modelo = "Fiesta", Ano = 2015, Cilindradas = 150, Portas = 4 });
            listaDeCarros.Add(new Carro { Id = 2, Marca = "Toyota", Modelo = "Hilux", Ano = 2017, Cilindradas = 177, Portas = 4 });
            listaDeCarros.Add(new Carro { Id = 3, Marca = "Citroen", Modelo = "PICASSO", Ano = 2012, Cilindradas = 136, Portas = 4 });
            listaDeCarros.Add(new Carro { Id = 4, Marca = "Renault", Modelo = "Triber", Ano = 2014, Cilindradas = 144, Portas = 4 });
            listaDeCarros.Add(new Carro { Id = 5, Marca = "Honda", Modelo = "Civic", Ano = 2011, Cilindradas = 180, Portas = 4 });
            listaDeCarros.Add(new Carro { Id = 6, Marca = "Volkswagen", Modelo = "Fusca", Ano = 2000, Cilindradas = 80, Portas = 2 });
            listaDeCarros.Add(new Carro { Id = 7, Marca = "Ford", Modelo = "Focus", Ano = 2015, Cilindradas = 140, Portas = 2 });
            listaDeCarros.Add(new Carro { Id = 8, Marca = "Honda", Modelo = "City", Ano = 2012, Cilindradas = 150, Portas = 4 });
            listaDeCarros.Add(new Carro { Id = 9, Marca = "Tesla", Modelo = "Model3", Ano = 2015, Cilindradas = 0, Portas = 4 });
            listaDeCarros.Add(new Carro { Id = 10, Marca = "Toyota", Modelo = "Corolla", Ano = 2016, Cilindradas = 170, Portas = 2 });
        }
    }
}

