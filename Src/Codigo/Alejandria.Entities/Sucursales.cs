//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionAdministrativa.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sucursales
    {
        public Sucursales()
        {
            this.Bancos = new HashSet<Bancos>();
            this.Bancos1 = new HashSet<Bancos>();
            this.Cajas = new HashSet<Cajas>();
            this.Cajas1 = new HashSet<Cajas>();
            this.Cajas2 = new HashSet<Cajas>();
            this.CajasMovimientos = new HashSet<CajasMovimientos>();
            this.CajasMovimientos1 = new HashSet<CajasMovimientos>();
            this.CategoriasOperadores = new HashSet<CategoriasOperadores>();
            this.CategoriasOperadores1 = new HashSet<CategoriasOperadores>();
            this.Celulares = new HashSet<Celulares>();
            this.Celulares1 = new HashSet<Celulares>();
            this.CelularesMovimiento = new HashSet<CelularesMovimiento>();
            this.CelularesMovimiento1 = new HashSet<CelularesMovimiento>();
            this.CentrosCostos = new HashSet<CentrosCostos>();
            this.CentrosCostos1 = new HashSet<CentrosCostos>();
            this.Choferes = new HashSet<Choferes>();
            this.Choferes1 = new HashSet<Choferes>();
            this.ChoferesMontosFavor = new HashSet<ChoferesMontosFavor>();
            this.ChoferesMontosFavor1 = new HashSet<ChoferesMontosFavor>();
            this.Conceptos = new HashSet<Conceptos>();
            this.Conceptos1 = new HashSet<Conceptos>();
            this.CondicionesCompra = new HashSet<CondicionesCompra>();
            this.CondicionesCompra1 = new HashSet<CondicionesCompra>();
            this.Funciones = new HashSet<Funciones>();
            this.Funciones1 = new HashSet<Funciones>();
            this.GruposProveedores = new HashSet<GruposProveedores>();
            this.GruposProveedores1 = new HashSet<GruposProveedores>();
            this.Localidades = new HashSet<Localidades>();
            this.Localidades1 = new HashSet<Localidades>();
            this.Moviles = new HashSet<Moviles>();
            this.Moviles1 = new HashSet<Moviles>();
            this.Operadores = new HashSet<Operadores>();
            this.Operadores1 = new HashSet<Operadores>();
            this.OperadoresFunciones = new HashSet<OperadoresFunciones>();
            this.OperadoresFunciones1 = new HashSet<OperadoresFunciones>();
            this.OperadoresSucursales = new HashSet<OperadoresSucursales>();
            this.OperadoresSucursales1 = new HashSet<OperadoresSucursales>();
            this.OrdenesPago = new HashSet<OrdenesPago>();
            this.OrdenesPago1 = new HashSet<OrdenesPago>();
            this.OrdenesPago2 = new HashSet<OrdenesPago>();
            this.OrdenesPago3 = new HashSet<OrdenesPago>();
            this.OrdenesPagoDetalle = new HashSet<OrdenesPagoDetalle>();
            this.OrdenesPagoDetalle1 = new HashSet<OrdenesPagoDetalle>();
            this.PagosCelular = new HashSet<PagosCelular>();
            this.PagosCelular1 = new HashSet<PagosCelular>();
            this.Personal = new HashSet<Personal>();
            this.Personal1 = new HashSet<Personal>();
            this.PersonalConcepto = new HashSet<PersonalConcepto>();
            this.PersonalConcepto1 = new HashSet<PersonalConcepto>();
            this.PersonalNovedades = new HashSet<PersonalNovedades>();
            this.PersonalNovedades1 = new HashSet<PersonalNovedades>();
            this.Proveedores = new HashSet<Proveedores>();
            this.Proveedores1 = new HashSet<Proveedores>();
            this.ProveedoresBanco = new HashSet<ProveedoresBanco>();
            this.ProveedoresBanco1 = new HashSet<ProveedoresBanco>();
            this.Provincias = new HashSet<Provincias>();
            this.Provincias1 = new HashSet<Provincias>();
            this.Recibos = new HashSet<Recibos>();
            this.Recibos1 = new HashSet<Recibos>();
            this.RecibosDetalle = new HashSet<RecibosDetalle>();
            this.RecibosDetalle1 = new HashSet<RecibosDetalle>();
            this.Sucursales1 = new HashSet<Sucursales>();
            this.Sucursales11 = new HashSet<Sucursales>();
            this.TiposCelulares = new HashSet<TiposCelulares>();
            this.TiposCelulares1 = new HashSet<TiposCelulares>();
            this.TiposComprobantes = new HashSet<TiposComprobantes>();
            this.TiposComprobantes1 = new HashSet<TiposComprobantes>();
            this.TiposGastos = new HashSet<TiposGastos>();
            this.TiposGastos1 = new HashSet<TiposGastos>();
            this.TiposMovimientosCajas = new HashSet<TiposMovimientosCajas>();
            this.TiposMovimientosCajas1 = new HashSet<TiposMovimientosCajas>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public Nullable<int> ProvinciaId { get; set; }
        public Nullable<int> LocalidadId { get; set; }
        public string Direccion { get; set; }
        public string TelPart { get; set; }
        public string TelCel { get; set; }
        public string Fax { get; set; }
        public string Responsable { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public decimal MaximoImporteVenta { get; set; }
        public decimal MaximoPorcentajeDescuento { get; set; }
        public int MaximoNroLineasPorVenta { get; set; }
        public Nullable<int> SucursalNumero { get; set; }
    
        public virtual ICollection<Bancos> Bancos { get; set; }
        public virtual ICollection<Bancos> Bancos1 { get; set; }
        public virtual ICollection<Cajas> Cajas { get; set; }
        public virtual ICollection<Cajas> Cajas1 { get; set; }
        public virtual ICollection<Cajas> Cajas2 { get; set; }
        public virtual ICollection<CajasMovimientos> CajasMovimientos { get; set; }
        public virtual ICollection<CajasMovimientos> CajasMovimientos1 { get; set; }
        public virtual ICollection<CategoriasOperadores> CategoriasOperadores { get; set; }
        public virtual ICollection<CategoriasOperadores> CategoriasOperadores1 { get; set; }
        public virtual ICollection<Celulares> Celulares { get; set; }
        public virtual ICollection<Celulares> Celulares1 { get; set; }
        public virtual ICollection<CelularesMovimiento> CelularesMovimiento { get; set; }
        public virtual ICollection<CelularesMovimiento> CelularesMovimiento1 { get; set; }
        public virtual ICollection<CentrosCostos> CentrosCostos { get; set; }
        public virtual ICollection<CentrosCostos> CentrosCostos1 { get; set; }
        public virtual ICollection<Choferes> Choferes { get; set; }
        public virtual ICollection<Choferes> Choferes1 { get; set; }
        public virtual ICollection<ChoferesMontosFavor> ChoferesMontosFavor { get; set; }
        public virtual ICollection<ChoferesMontosFavor> ChoferesMontosFavor1 { get; set; }
        public virtual ICollection<Conceptos> Conceptos { get; set; }
        public virtual ICollection<Conceptos> Conceptos1 { get; set; }
        public virtual ICollection<CondicionesCompra> CondicionesCompra { get; set; }
        public virtual ICollection<CondicionesCompra> CondicionesCompra1 { get; set; }
        public virtual ICollection<Funciones> Funciones { get; set; }
        public virtual ICollection<Funciones> Funciones1 { get; set; }
        public virtual ICollection<GruposProveedores> GruposProveedores { get; set; }
        public virtual ICollection<GruposProveedores> GruposProveedores1 { get; set; }
        public virtual ICollection<Localidades> Localidades { get; set; }
        public virtual ICollection<Localidades> Localidades1 { get; set; }
        public virtual Localidades Localidades2 { get; set; }
        public virtual ICollection<Moviles> Moviles { get; set; }
        public virtual ICollection<Moviles> Moviles1 { get; set; }
        public virtual ICollection<Operadores> Operadores { get; set; }
        public virtual ICollection<Operadores> Operadores1 { get; set; }
        public virtual Operadores Operadores2 { get; set; }
        public virtual Operadores Operadores3 { get; set; }
        public virtual ICollection<OperadoresFunciones> OperadoresFunciones { get; set; }
        public virtual ICollection<OperadoresFunciones> OperadoresFunciones1 { get; set; }
        public virtual ICollection<OperadoresSucursales> OperadoresSucursales { get; set; }
        public virtual ICollection<OperadoresSucursales> OperadoresSucursales1 { get; set; }
        public virtual ICollection<OrdenesPago> OrdenesPago { get; set; }
        public virtual ICollection<OrdenesPago> OrdenesPago1 { get; set; }
        public virtual ICollection<OrdenesPago> OrdenesPago2 { get; set; }
        public virtual ICollection<OrdenesPago> OrdenesPago3 { get; set; }
        public virtual ICollection<OrdenesPagoDetalle> OrdenesPagoDetalle { get; set; }
        public virtual ICollection<OrdenesPagoDetalle> OrdenesPagoDetalle1 { get; set; }
        public virtual ICollection<PagosCelular> PagosCelular { get; set; }
        public virtual ICollection<PagosCelular> PagosCelular1 { get; set; }
        public virtual ICollection<Personal> Personal { get; set; }
        public virtual ICollection<Personal> Personal1 { get; set; }
        public virtual ICollection<PersonalConcepto> PersonalConcepto { get; set; }
        public virtual ICollection<PersonalConcepto> PersonalConcepto1 { get; set; }
        public virtual ICollection<PersonalNovedades> PersonalNovedades { get; set; }
        public virtual ICollection<PersonalNovedades> PersonalNovedades1 { get; set; }
        public virtual ICollection<Proveedores> Proveedores { get; set; }
        public virtual ICollection<Proveedores> Proveedores1 { get; set; }
        public virtual ICollection<ProveedoresBanco> ProveedoresBanco { get; set; }
        public virtual ICollection<ProveedoresBanco> ProveedoresBanco1 { get; set; }
        public virtual ICollection<Provincias> Provincias { get; set; }
        public virtual ICollection<Provincias> Provincias1 { get; set; }
        public virtual Provincias Provincias2 { get; set; }
        public virtual ICollection<Recibos> Recibos { get; set; }
        public virtual ICollection<Recibos> Recibos1 { get; set; }
        public virtual ICollection<RecibosDetalle> RecibosDetalle { get; set; }
        public virtual ICollection<RecibosDetalle> RecibosDetalle1 { get; set; }
        public virtual ICollection<Sucursales> Sucursales1 { get; set; }
        public virtual Sucursales Sucursales2 { get; set; }
        public virtual ICollection<Sucursales> Sucursales11 { get; set; }
        public virtual Sucursales Sucursales3 { get; set; }
        public virtual ICollection<TiposCelulares> TiposCelulares { get; set; }
        public virtual ICollection<TiposCelulares> TiposCelulares1 { get; set; }
        public virtual ICollection<TiposComprobantes> TiposComprobantes { get; set; }
        public virtual ICollection<TiposComprobantes> TiposComprobantes1 { get; set; }
        public virtual ICollection<TiposGastos> TiposGastos { get; set; }
        public virtual ICollection<TiposGastos> TiposGastos1 { get; set; }
        public virtual ICollection<TiposMovimientosCajas> TiposMovimientosCajas { get; set; }
        public virtual ICollection<TiposMovimientosCajas> TiposMovimientosCajas1 { get; set; }
    }
}
