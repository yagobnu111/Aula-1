using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        // realizo minha conexão com o banco de dados
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable // Aqui temos nossa primeira interface com a classe IQueryable, essa classe
                          // contém várias funcionalidades prontas para usar igual ao banco de dados
                          // com os selects  
            <Pessoa> // definimos o tipo que irá retornar 
            GetPessoas()// damos um nome ao nosso método
        {
            return contextDB.ListaDePessoas; // retornamos nossa lista de pessoas
        }
        public void AddPessoa(Pessoa item)
        {
            contextDB.ListaDePessoas.Add(item);
            contextDB.SaveChanges();
        }
    }
}
