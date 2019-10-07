using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : 
        DbContext // DbContext = Classe pronta que contém todos os processos de conexão com o banco de dados,
                  // listagem de tabelas e seleção das informações   
    {
        public DbSet// palavra reservada para o entity que indica que vamos definir uma tabela do nosso 
                    // banco de dados
            <Pessoa>// Aqui definimos nossa tabela pessoas, ou seja, especificamos qual de nossas classes
                    // será uma referência de uma tabela no banco de dados
            ListaDePessoas { get; set; } // nessa parte liberamos nossa tabela para acessar
    }
}
