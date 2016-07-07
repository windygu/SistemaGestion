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
    
    public partial class Sucursal
    {
        public Sucursal()
        {
            this.Bancos = new HashSet<Banco>();
            this.Bancos1 = new HashSet<Banco>();
            this.Cajas = new HashSet<Caja>();
            this.Cajas1 = new HashSet<Caja>();
            this.Cajas2 = new HashSet<Caja>();
            this.CajasMovimientos = new HashSet<CajaMovimiento>();
            this.CajasMovimientos1 = new HashSet<CajaMovimiento>();
            this.CategoriasOperadores = new HashSet<CategoriaOperador>();
            this.CategoriasOperadores1 = new HashSet<CategoriaOperador>();
            this.CelularesMovimiento = new HashSet<CelularMovimiento>();
            this.CelularesMovimiento1 = new HashSet<CelularMovimiento>();
            this.CentrosCostos = new HashSet<CentroCosto>();
            this.CentrosCostos1 = new HashSet<CentroCosto>();
            this.ChoferesMontosFavor = new HashSet<ChoferMontoFavor>();
            this.ChoferesMontosFavor1 = new HashSet<ChoferMontoFavor>();
            this.Conceptos = new HashSet<Concepto>();
            this.Conceptos1 = new HashSet<Concepto>();
            this.CondicionesCompra = new HashSet<CondicionCompra>();
            this.CondicionesCompra1 = new HashSet<CondicionCompra>();
            this.Funciones = new HashSet<Funcion>();
            this.Funciones1 = new HashSet<Funcion>();
            this.GruposProveedores = new HashSet<GrupoProveedor>();
            this.GruposProveedores1 = new HashSet<GrupoProveedor>();
            this.Localidades = new HashSet<Localidad>();
            this.Localidades1 = new HashSet<Localidad>();
            this.Moviles = new HashSet<Movil>();
            this.Moviles1 = new HashSet<Movil>();
            this.Operadores = new HashSet<Operador>();
            this.Operadores1 = new HashSet<Operador>();
            this.OperadoresFunciones = new HashSet<OperadorFuncion>();
            this.OperadoresFunciones1 = new HashSet<OperadorFuncion>();
            this.OperadoresSucursales = new HashSet<OperadorSucursal>();
            this.OperadoresSucursales1 = new HashSet<OperadorSucursal>();
            this.OrdenesPago = new HashSet<OrdenPago>();
            this.OrdenesPago1 = new HashSet<OrdenPago>();
            this.OrdenesPago2 = new HashSet<OrdenPago>();
            this.OrdenesPago3 = new HashSet<OrdenPago>();
            this.OrdenesPagoDetalle = new HashSet<OrdenPagoDetalle>();
            this.OrdenesPagoDetalle1 = new HashSet<OrdenPagoDetalle>();
            this.PagosCelular = new HashSet<PagoCelular>();
            this.PagosCelular1 = new HashSet<PagoCelular>();
            this.Personal = new HashSet<Personal>();
            this.Personal1 = new HashSet<Personal>();
            this.PersonalConcepto = new HashSet<PersonalConcepto>();
            this.PersonalConcepto1 = new HashSet<PersonalConcepto>();
            this.PersonalNovedades = new HashSet<PersonalNovedad>();
            this.PersonalNovedades1 = new HashSet<PersonalNovedad>();
            this.Proveedores = new HashSet<Proveedor>();
            this.Proveedores1 = new HashSet<Proveedor>();
            this.ProveedoresBanco = new HashSet<ProveedorBanco>();
            this.ProveedoresBanco1 = new HashSet<ProveedorBanco>();
            this.Provincias = new HashSet<Provincia>();
            this.Provincias1 = new HashSet<Provincia>();
            this.Recibos = new HashSet<Recibo>();
            this.Recibos1 = new HashSet<Recibo>();
            this.RecibosDetalle = new HashSet<ReciboDetalle>();
            this.RecibosDetalle1 = new HashSet<ReciboDetalle>();
            this.Sucursales1 = new HashSet<Sucursal>();
            this.Sucursales11 = new HashSet<Sucursal>();
            this.TiposCelulares = new HashSet<TipoCelular>();
            this.TiposCelulares1 = new HashSet<TipoCelular>();
            this.TiposComprobantes = new HashSet<TipoComprobante>();
            this.TiposComprobantes1 = new HashSet<TipoComprobante>();
            this.TiposGastos = new HashSet<TipoGasto>();
            this.TiposGastos1 = new HashSet<TipoGasto>();
            this.TiposMovimientosCajas = new HashSet<TipoMovimientoCaja>();
            this.TiposMovimientosCajas1 = new HashSet<TipoMovimientoCaja>();
            this.Choferes = new HashSet<Chofer>();
            this.Choferes1 = new HashSet<Chofer>();
            this.Celulares = new HashSet<Celular>();
            this.Celulares1 = new HashSet<Celular>();
            this.CajaBalances = new HashSet<CajaBalance>();
            this.CajaBalances1 = new HashSet<CajaBalance>();
            this.ChoferesMovils = new HashSet<ChoferesMovil>();
            this.ChoferesMovils1 = new HashSet<ChoferesMovil>();
            this.ChoferCelulars = new HashSet<ChoferCelular>();
            this.ChoferCelulars1 = new HashSet<ChoferCelular>();
            this.Comentarios = new HashSet<Comentario>();
            this.ComentariosChofers = new HashSet<ComentariosChofer>();
            this.PagosMoviles = new HashSet<PagosMovile>();
            this.PagosMoviles1 = new HashSet<PagosMovile>();
            this.Promociones = new HashSet<Promocione>();
            this.Promociones1 = new HashSet<Promocione>();
            this.PromocionesMoviles = new HashSet<PromocionesMovile>();
            this.PromocionesMoviles1 = new HashSet<PromocionesMovile>();
            this.Talleres = new HashSet<Tallere>();
            this.Talleres1 = new HashSet<Tallere>();
            this.TalleresMoviles = new HashSet<TalleresMovile>();
            this.TalleresMoviles1 = new HashSet<TalleresMovile>();
            this.Tarifas = new HashSet<Tarifa>();
            this.Tarifas1 = new HashSet<Tarifa>();
            this.Titulares = new HashSet<Titulare>();
            this.Titulares1 = new HashSet<Titulare>();
            this.PagosBases = new HashSet<PagosBas>();
            this.PagosBases1 = new HashSet<PagosBas>();
            this.MovilesMontoFavors = new HashSet<MovilesMontoFavor>();
            this.MovilesMontoFavors1 = new HashSet<MovilesMontoFavor>();
            this.Clientes = new HashSet<Cliente>();
            this.Clientes1 = new HashSet<Cliente>();
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
    
        public virtual ICollection<Banco> Bancos { get; set; }
        public virtual ICollection<Banco> Bancos1 { get; set; }
        public virtual ICollection<Caja> Cajas { get; set; }
        public virtual ICollection<Caja> Cajas1 { get; set; }
        public virtual ICollection<Caja> Cajas2 { get; set; }
        public virtual ICollection<CajaMovimiento> CajasMovimientos { get; set; }
        public virtual ICollection<CajaMovimiento> CajasMovimientos1 { get; set; }
        public virtual ICollection<CategoriaOperador> CategoriasOperadores { get; set; }
        public virtual ICollection<CategoriaOperador> CategoriasOperadores1 { get; set; }
        public virtual ICollection<CelularMovimiento> CelularesMovimiento { get; set; }
        public virtual ICollection<CelularMovimiento> CelularesMovimiento1 { get; set; }
        public virtual ICollection<CentroCosto> CentrosCostos { get; set; }
        public virtual ICollection<CentroCosto> CentrosCostos1 { get; set; }
        public virtual ICollection<ChoferMontoFavor> ChoferesMontosFavor { get; set; }
        public virtual ICollection<ChoferMontoFavor> ChoferesMontosFavor1 { get; set; }
        public virtual ICollection<Concepto> Conceptos { get; set; }
        public virtual ICollection<Concepto> Conceptos1 { get; set; }
        public virtual ICollection<CondicionCompra> CondicionesCompra { get; set; }
        public virtual ICollection<CondicionCompra> CondicionesCompra1 { get; set; }
        public virtual ICollection<Funcion> Funciones { get; set; }
        public virtual ICollection<Funcion> Funciones1 { get; set; }
        public virtual ICollection<GrupoProveedor> GruposProveedores { get; set; }
        public virtual ICollection<GrupoProveedor> GruposProveedores1 { get; set; }
        public virtual ICollection<Localidad> Localidades { get; set; }
        public virtual ICollection<Localidad> Localidades1 { get; set; }
        public virtual Localidad Localidades2 { get; set; }
        public virtual ICollection<Movil> Moviles { get; set; }
        public virtual ICollection<Movil> Moviles1 { get; set; }
        public virtual ICollection<Operador> Operadores { get; set; }
        public virtual ICollection<Operador> Operadores1 { get; set; }
        public virtual Operador Operadores2 { get; set; }
        public virtual Operador Operadores3 { get; set; }
        public virtual ICollection<OperadorFuncion> OperadoresFunciones { get; set; }
        public virtual ICollection<OperadorFuncion> OperadoresFunciones1 { get; set; }
        public virtual ICollection<OperadorSucursal> OperadoresSucursales { get; set; }
        public virtual ICollection<OperadorSucursal> OperadoresSucursales1 { get; set; }
        public virtual ICollection<OrdenPago> OrdenesPago { get; set; }
        public virtual ICollection<OrdenPago> OrdenesPago1 { get; set; }
        public virtual ICollection<OrdenPago> OrdenesPago2 { get; set; }
        public virtual ICollection<OrdenPago> OrdenesPago3 { get; set; }
        public virtual ICollection<OrdenPagoDetalle> OrdenesPagoDetalle { get; set; }
        public virtual ICollection<OrdenPagoDetalle> OrdenesPagoDetalle1 { get; set; }
        public virtual ICollection<PagoCelular> PagosCelular { get; set; }
        public virtual ICollection<PagoCelular> PagosCelular1 { get; set; }
        public virtual ICollection<Personal> Personal { get; set; }
        public virtual ICollection<Personal> Personal1 { get; set; }
        public virtual ICollection<PersonalConcepto> PersonalConcepto { get; set; }
        public virtual ICollection<PersonalConcepto> PersonalConcepto1 { get; set; }
        public virtual ICollection<PersonalNovedad> PersonalNovedades { get; set; }
        public virtual ICollection<PersonalNovedad> PersonalNovedades1 { get; set; }
        public virtual ICollection<Proveedor> Proveedores { get; set; }
        public virtual ICollection<Proveedor> Proveedores1 { get; set; }
        public virtual ICollection<ProveedorBanco> ProveedoresBanco { get; set; }
        public virtual ICollection<ProveedorBanco> ProveedoresBanco1 { get; set; }
        public virtual ICollection<Provincia> Provincias { get; set; }
        public virtual ICollection<Provincia> Provincias1 { get; set; }
        public virtual Provincia Provincias2 { get; set; }
        public virtual ICollection<Recibo> Recibos { get; set; }
        public virtual ICollection<Recibo> Recibos1 { get; set; }
        public virtual ICollection<ReciboDetalle> RecibosDetalle { get; set; }
        public virtual ICollection<ReciboDetalle> RecibosDetalle1 { get; set; }
        public virtual ICollection<Sucursal> Sucursales1 { get; set; }
        public virtual Sucursal Sucursales2 { get; set; }
        public virtual ICollection<Sucursal> Sucursales11 { get; set; }
        public virtual Sucursal Sucursales3 { get; set; }
        public virtual ICollection<TipoCelular> TiposCelulares { get; set; }
        public virtual ICollection<TipoCelular> TiposCelulares1 { get; set; }
        public virtual ICollection<TipoComprobante> TiposComprobantes { get; set; }
        public virtual ICollection<TipoComprobante> TiposComprobantes1 { get; set; }
        public virtual ICollection<TipoGasto> TiposGastos { get; set; }
        public virtual ICollection<TipoGasto> TiposGastos1 { get; set; }
        public virtual ICollection<TipoMovimientoCaja> TiposMovimientosCajas { get; set; }
        public virtual ICollection<TipoMovimientoCaja> TiposMovimientosCajas1 { get; set; }
        public virtual ICollection<Chofer> Choferes { get; set; }
        public virtual ICollection<Chofer> Choferes1 { get; set; }
        public virtual ICollection<Celular> Celulares { get; set; }
        public virtual ICollection<Celular> Celulares1 { get; set; }
        public virtual ICollection<CajaBalance> CajaBalances { get; set; }
        public virtual ICollection<CajaBalance> CajaBalances1 { get; set; }
        public virtual ICollection<ChoferesMovil> ChoferesMovils { get; set; }
        public virtual ICollection<ChoferesMovil> ChoferesMovils1 { get; set; }
        public virtual ICollection<ChoferCelular> ChoferCelulars { get; set; }
        public virtual ICollection<ChoferCelular> ChoferCelulars1 { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual ICollection<ComentariosChofer> ComentariosChofers { get; set; }
        public virtual ICollection<PagosMovile> PagosMoviles { get; set; }
        public virtual ICollection<PagosMovile> PagosMoviles1 { get; set; }
        public virtual ICollection<Promocione> Promociones { get; set; }
        public virtual ICollection<Promocione> Promociones1 { get; set; }
        public virtual ICollection<PromocionesMovile> PromocionesMoviles { get; set; }
        public virtual ICollection<PromocionesMovile> PromocionesMoviles1 { get; set; }
        public virtual ICollection<Tallere> Talleres { get; set; }
        public virtual ICollection<Tallere> Talleres1 { get; set; }
        public virtual ICollection<TalleresMovile> TalleresMoviles { get; set; }
        public virtual ICollection<TalleresMovile> TalleresMoviles1 { get; set; }
        public virtual ICollection<Tarifa> Tarifas { get; set; }
        public virtual ICollection<Tarifa> Tarifas1 { get; set; }
        public virtual ICollection<Titulare> Titulares { get; set; }
        public virtual ICollection<Titulare> Titulares1 { get; set; }
        public virtual ICollection<PagosBas> PagosBases { get; set; }
        public virtual ICollection<PagosBas> PagosBases1 { get; set; }
        public virtual ICollection<MovilesMontoFavor> MovilesMontoFavors { get; set; }
        public virtual ICollection<MovilesMontoFavor> MovilesMontoFavors1 { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Cliente> Clientes1 { get; set; }
    }
}
