//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionAdministrativa.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chofer
    {
        public Chofer()
        {
            this.ChoferesMontosFavor = new HashSet<ChoferMontoFavor>();
            this.ChoferesMovils = new HashSet<ChoferesMovil>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<int> Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public int SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaModficacion { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.Guid> MovilId { get; set; }
        public Nullable<System.Guid> CelularId { get; set; }
    
        public virtual Operador OperadorAlta { get; set; }
        public virtual Operador OperadorModificacion { get; set; }
        public virtual Sucursal SucursalAlta { get; set; }
        public virtual Sucursal SucursalModificacion { get; set; }
        public virtual ICollection<ChoferMontoFavor> ChoferesMontosFavor { get; set; }
        public virtual Movil Movil { get; set; }
        public virtual Celular Celulare { get; set; }
        public virtual ICollection<ChoferesMovil> ChoferesMovils { get; set; }
    }
}
