using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio.EntidadesDelDominio.Entidades;
using Negocio.ILogicaNegocio;

namespace Negocio.ControlRepository
{
    class ControlRegistrarAlojamiento : IControlRegistroAlojamiento
    {
        
        public bool RegistrarAlojamiento(Alojamiento alojamiento)
        {
            using (RoomServicesEntities entidades = new RoomServicesEntities())
            {
                if (this.VerificarCampos(alojamiento) == true)
                {
                    Alojamientos s=new Alojamientos()
                    {
                       titulo= alojamiento.Titulo,
                       precio= alojamiento.Precio,
                       descripcionAlojamiento= alojamiento.DescripcionAlojamiento,
            
                       
                    };
                    entidades.Alojamientos.Add(s);
                    return true;
                }
                else
                {
                    return false;
                }
            }   

        }

       
        public bool VerificarCampos(Alojamiento alojamiento)
        {
            using (RoomServicesEntities entidades = new RoomServicesEntities()) 
            {
                return alojamiento.Precio > 0 && alojamiento.DescripcionAlojamiento != null && alojamiento.Titulo != null && alojamiento.Fotos.Count() > 0 ? true : false; 
            }
        }

        public String EnviarSolicitudAprovacion(Alojamiento alojamiento)
        {

            using (RoomServicesEntities entidades = new RoomServicesEntities())
            {
               bool siga= VerificarCampos(alojamiento);

                if (siga==true)
                {
                    return "Exito";
                }
                else
                {
                    return "no se pudo";
                }
                
            }
        }



    }
}
