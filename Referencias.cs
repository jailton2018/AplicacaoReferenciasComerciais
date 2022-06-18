using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AgendaReferencias
{
    public class Referencias
    {
       public string Nome { get; set; }
        string Empresa { get; set; }
        string Telefone { get; set; }
        string Observacao { get; set; }
        string Cidade    { get; set; }

        public string JsonSerializar(Referencias referencias)
        {
            return JsonConvert.SerializeObject(referencias);
        }
        public static Referencias JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Referencias>(Json);
        }
        public static void Main(string[] args)
        {
            Referencias referencia = new Referencias();
            referencia.Nome = "Joao";
            referencia.Telefone = "991098256";
            referencia.Observacao = "Não passa";
            referencia.Cidade = "Porto calvo";
            referencia.Empresa = "Guabi";

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"c:\json.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, referencia);
                // {"ExpiryDate":new Date(1230375600000),"Price":0}
            }
        }

    }
}
