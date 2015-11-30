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
    
    public partial class Personal
    {
        public Personal()
        {
            this.Operadores = new HashSet<Operador>();
            this.PersonalConcepto = new HashSet<PersonalConcepto>();
            this.PersonalNovedades = new HashSet<PersonalNovedad>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> ContactoId { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public Nullable<int> ProvinciaId { get; set; }
        public Nullable<int> LocalidadId { get; set; }
        public Nullable<int> CategoriaId { get; set; }
        public Nullable<int> SucursalId { get; set; }
        public Nullable<int> TipoLiquidacionId { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Fax { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public string HoraDesdeM { get; set; }
        public string HoraHastaM { get; set; }
        public string HoraDesdeT { get; set; }
        public string HoraHastaT { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
    
        public virtual CategoriaOperador CategoriasOperadores { get; set; }
        public virtual Localidad Localidades { get; set; }
        public virtual ICollection<Operador> Operadores { get; set; }
        public virtual Operador Operadores1 { get; set; }
        public virtual Operador Operadores2 { get; set; }
        public virtual Provincia Provincias { get; set; }
        public virtual Sucursal Sucursales { get; set; }
        public virtual Sucursal Sucursales1 { get; set; }
        public virtual ICollection<PersonalConcepto> PersonalConcepto { get; set; }
        public virtual ICollection<PersonalNovedad> PersonalNovedades { get; set; }
    }
}
