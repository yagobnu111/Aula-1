using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CalculandoImcV3.Models;

namespace CalculandoImcV3.Controllers
{
    public class ImcController : ApiController
    {
        List<ObjetoImc> listaDeObjetos = new List<ObjetoImc>()
        {
            new ObjetoImc(){Nome = "Gabriel"},
            new ObjetoImc(){Nome = "Yago"},
            new ObjetoImc(){Nome = "Souza"},
            new ObjetoImc(){Nome = "Silva"}
        };

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<ObjetoImc> Get()
        {
            return listaDeObjetos;
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get(string nome, double peso, double altura)
        {
            var imc = peso / Math.Pow(altura, 2);

            return ($"Olá {nome} seu IMC é {imc} e ele foi calculado de acordo com sua Altura:{altura} e Peso:{peso}");
                
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public double Get(double peso, double altura)
        {
            var imc = peso / Math.Pow(altura, 2);

            return imc;
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public string Get (double imc)
        {
            if (imc < 18.5)
                return "Abaixo do peso";
            else if (imc < 25)
                return "Peso normal";
            else if (imc < 30)
                return "Sobrepeso";
            else if (imc < 35)
                return "Obesidade grau 1";
            else if (imc < 40)
                return "Obesidade grau 2";

            return "Obesidade grau 3";

        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ObjetoImc Post(ObjetoImc values)
        {
            ObjetoImc imcCalc = values;

            imcCalc.ImcValue = imcCalc.Peso / Math.Pow(imcCalc.Altura, 2);
            if (imcCalc.ImcValue < 18.5)
                imcCalc.Situacao = "Abaixo do peso";
            else if (imcCalc.ImcValue < 25)
                imcCalc.Situacao = "Peso normal";
            else if (imcCalc.ImcValue < 30)
                imcCalc.Situacao = "Sobrepeso";
            else if (imcCalc.ImcValue < 35)
                imcCalc.Situacao = "Obesidade grau 1";
            else if (imcCalc.ImcValue < 40)
                imcCalc.Situacao = "Obesidade grau 2";
            else
                imcCalc.Situacao = "Obesidade grau 3";


            listaDeObjetos.Add(imcCalc);

            return imcCalc;
        }




    }
}
