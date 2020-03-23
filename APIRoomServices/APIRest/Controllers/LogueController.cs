﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Negocio.ControlRepository;
using Dominio;
using Datos;
using APIRest.IServices;
using APIRest.APIRestService;
using Newtonsoft.Json.Linq;


namespace APIRest.Controllers
{
    public class LogueController : ApiController
    {
        readonly IControlLogueoUsuario control;

        // GET: api/Logueo
        public JObject GetInformacionLogueUsuario(String email, String contrasena)
        {
            return control.informacionLogueUsuario(email, contrasena);
        }

        // GET: api/Logueo/PermisoUsuario
        public bool GetPermisoIngreso(string email, string contrasena)
        {
            return control.permisoIngreso(email, contrasena);
        }

    }
}
