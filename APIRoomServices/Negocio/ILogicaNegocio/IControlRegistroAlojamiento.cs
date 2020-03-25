using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.EntidadesDelDominio.Entidades;
namespace Negocio.ILogicaNegocio
{
    public interface IControlRegistroAlojamiento
    {   
      bool VerificarCampos(Alojamiento alojamiento);
      String EnviarSolicitudAprovacion(Alojamiento alojamiento);
      bool RegistrarAlojamiento(Alojamiento alojamiento);
      

    }
}
