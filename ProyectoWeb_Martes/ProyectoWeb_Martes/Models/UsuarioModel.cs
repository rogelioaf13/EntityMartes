using ProyectoWeb_Martes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb_Martes.Models
{
    public class UsuarioModel
    {
        public string url = "https://localhost:44302/";


        public int RegistrarUsuario(Usuario entidad)
        {
            //llamadaos al API
            using (var cliente = new HttpClient())
            {

                url += "inicio/registrarusuario";

                JsonContent jsonEntidad = JsonContent.Create(entidad);

                var respuesta = cliente.PostAsync(url, jsonEntidad).Result;

                if (respuesta.IsSuccessStatusCode) 
                    return respuesta.Content.ReadFromJsonAsync<int>().Result;

                return 0;
            }
        }

        public List<Usuario> IniciarSesionUsuario(Usuario entidad)
        {
            //llamadaos al API
            using (var cliente = new HttpClient())
            {

                url += "inicio/IniciarSesionUsuario";

                JsonContent jsonEntidad = JsonContent.Create(entidad);

                var respuesta = cliente.PostAsync(url, jsonEntidad).Result;

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<List<Usuario>>().Result;

                return null;
            }
        }
    }
}