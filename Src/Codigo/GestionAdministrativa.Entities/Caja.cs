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
    
    public partial class Caja
    {
        public Caja()
        {
            this.OrdenesPagoDetalle = new HashSet<OrdenPagoDetalle>();
        }
    
        public System.Guid Id { get; set; }
        public int SucursalId { get; set; }
        public Nullable<System.Guid> OperadorId { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<System.DateTime> FCierre { get; set; }
        public Nullable<decimal> Inicio { get; set; }
        public Nullable<decimal> Ingresos { get; set; }
        public Nullable<decimal> Egresos { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<decimal> Cheques { get; set; }
        public Nullable<decimal> Bonos { get; set; }
        public string PcAlta { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public Nullable<bool> Aprobada { get; set; }
        public Nullable<decimal> Vales { get; set; }
        public Nullable<decimal> Efectivo { get; set; }
        public Nullable<decimal> ValesReal { get; set; }
        public Nullable<decimal> EfectivoReal { get; set; }
    
        public virtual Operador Operadores { get; set; }
        public virtual Operador Operadores1 { get; set; }
        public virtual Operador Operadores2 { get; set; }
        public virtual Sucursal Sucursales { get; set; }
        public virtual Sucursal Sucursales1 { get; set; }
        public virtual Sucursal Sucursales2 { get; set; }
        public virtual ICollection<OrdenPagoDetalle> OrdenesPagoDetalle { get; set; }
    }
}
