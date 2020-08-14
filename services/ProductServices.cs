using common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using RestSharp;
using System.IO;
using System.Web;

namespace services
{
    public class ProductServices
    {
        public dynamic registrarProducto(Producto producto)
        {
            string jsonconvertProdcuto = JsonConvert.SerializeObject(producto);
            string url = "https://api-pruebas2020.herokuapp.com/Producto/registroProducto";
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", jsonconvertProdcuto,ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);

                dynamic datos = JsonConvert.DeserializeObject(response.Content);

                return datos;

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Producto> consultaProductos()
        {
            List<Producto> lista = new List<Producto>();
            string url = "https://api-pruebas2020.herokuapp.com/Producto/ConsultarProducto";

            HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(url);
            httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
            httpWebRequest.Proxy = null;
            HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string data = HttpUtility.HtmlDecode(streamReader.ReadToEnd());
            dynamic listdata = JsonConvert.DeserializeObject(data);
            foreach(var i in listdata)
            {
                Producto temp = JsonConvert.DeserializeObject(i);
                lista.Add(temp);
            }
            return lista;
        }
    }
}
