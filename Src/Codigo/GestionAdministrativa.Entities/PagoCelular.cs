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
    
    public partial class PagoCelular
    {
        public System.Guid Id { get; set; }
        public Nullable<System.DateTime> Desde { get; set; }
        public Nullable<System.DateTime> Hasta { get; set; }
        public Nullable<decimal> Efectivo { get; set; }
        public Nullable<decimal> Vales { get; set; }
        public Nullable<decimal> Taller { get; set; }
        public decimal Monto { get; set; }
        public System.Guid CelularId { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public System.Guid OperadorAltaId { get; set; }
        public int SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<decimal> Senia { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<System.Guid> ChoferId { get; set; }
        public Nullable<System.Guid> MovilId { get; set; }
        public Nullable<bool> Anulada { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public Nullable<System.Guid> OperadorAutoriza { get; set; }
    
        public virtual Operador Operadores { get; set; }
        public virtual Operador Operadores1 { get; set; }
        public virtual Sucursal Sucursales { get; set; }
        public virtual Sucursal Sucursales1 { get; set; }
        public virtual Celular Celulare { get; set; }
        public virtual Chofer Chofere { get; set; }
        public virtual Movil Movile { get; set; }
        public virtual Operador Operadore1 { get; set; }
    }
}
