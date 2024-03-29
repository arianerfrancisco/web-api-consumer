﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ClientesController : Controller
    {
       private static List<Cliente> clientes = new List<Cliente>();
       
       // Como o nome do método é Get() omite-se o uso de [HttpGet]
       public List<Cliente> Get()
       {
           return clientes;
       }

       public void Post(string nome)
       {
           if(!string.IsNullOrEmpty(nome))
            clientes.Add(new Cliente(nome));
       }

       public void Delete(string nome)
       {
           clientes.RemoveAt(clientes.IndexOf(clientes.First( x => x.Nome.Equals(nome))));
       }
    }
}