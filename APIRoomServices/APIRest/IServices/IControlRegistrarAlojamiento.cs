using Dominio.EntidadesDelDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIRest.IServices
{
    public interface IControlRegistrarAlojamiento
    {
        bool VerificarCampos(Alojamiento alojamiento);
        String EnviarSolicitudAprovacion(Alojamiento alojamiento);
        bool RegistrarAlojamiento(Alojamiento alojamiento);
    }
}