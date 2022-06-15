using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AplicacaoReferenciasComerciais
{
    public class Referencia
    {
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
      
        public string JsonSerializar(Referencia referencia)
        {
            return JsonConvert.SerializeObject(referencia);
        }
        public static Referencia JsonDeserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Referencia>(Json);
        }


        /*public static void Main(string[] args)
        {

            Referencia referencia = new Referencia();

            referencia.Nome = "Joao";
            referencia.Telefone = "991098256";
            referencia.Observacao = "Não passa";
            referencia.Cidade = "Porto calvo";
            referencia.Email = "Guabi@outlook.com";


            string output = JsonConvert.SerializeObject(referencia);


            Referencia deserializedReferencias = JsonConvert.DeserializeObject<Referencia>(output);
            Console.Write(output);
        }*/

    }
}

