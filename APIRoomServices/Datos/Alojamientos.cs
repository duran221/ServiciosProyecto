//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alojamientos
    {
        public Alojamientos()
        {
            this.AlbumFotograficos = new HashSet<AlbumFotograficos>();
            this.AlquilersAlojamientos = new HashSet<AlquilersAlojamientos>();
            this.CalificacionesAlojamiento = new HashSet<CalificacionesAlojamiento>();
        }
    
        public int idAlojamiento { get; set; }
        public string titulo { get; set; }
        public string descripcionAlojamiento { get; set; }
        public double precio { get; set; }
        public string tipoAlojamiento { get; set; }
        public int idUbicacion { get; set; }
        public string cedulaArrendador { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual ICollection<AlbumFotograficos> AlbumFotograficos { get; set; }
        public virtual Arrendadores Arrendadores { get; set; }
        public virtual Ubicaciones Ubicaciones { get; set; }
        public virtual ICollection<AlquilersAlojamientos> AlquilersAlojamientos { get; set; }
        public virtual ICollection<CalificacionesAlojamiento> CalificacionesAlojamiento { get; set; }
    }
}
