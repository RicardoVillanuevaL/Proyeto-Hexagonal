using common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace services
{
    public class ProductServices
    {
        public void registrarProducto(Producto producto)
        {
            JsonConvert.SerializeObject(producto, Formatting.Indented);
        }
        public List<Producto> consultaProductos()
        {
            List<Producto> lista = new List<Producto>();
            string url = "https://api-pruebas2020.herokuapp.com/Producto/ConsultarProducto";
            var jsonResult = new WebClient().DownloadString(url);
            dynamic m = JsonConvert.DeserializeObject(jsonResult);
            foreach(var i in m)
            {
                Producto temp = JsonConvert.DeserializeObject<Producto>(i);
                lista.Add(temp);
            }
            return lista;
        }
    }
}
