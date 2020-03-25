using APIRest.IServices;
using Dominio.EntidadesDelDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocio.ControlRepository;


namespace APIRest.APIRestService
{
    public class ControlRegistrarAlojamiento : IControlRegistrarAlojamiento
    {
        readonly Negocio.ILogicaNegocio.IControlRegistroAlojamiento control;

        public string EnviarSolicitudAprovacion(Alojamiento alojamiento)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarAlojamiento(Alojamiento alojamiento)
        {
            throw new NotImplementedException();
        }

        public bool VerificarCampos(Alojamiento alojamiento)
        {
            throw new NotImplementedException();
        }
    }
}