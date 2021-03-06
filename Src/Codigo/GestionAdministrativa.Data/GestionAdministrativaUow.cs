﻿using System;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Threading.Tasks;
using GestionAdministrativa.Data.Helpers;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;


namespace GestionAdministrativa.Data
{
    public class GestionAdministrativaUow : IGestionAdministrativaUow
    {
        public GestionAdministrativaUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        public IReporteRepository Reportes { get { return GetRepo<IReporteRepository>(); } }
        public IRepository<Caja> Cajas { get { return GetStandardRepo<Caja>(); } }
        public IRepository<Chofer> Choferes { get { return GetStandardRepo<Chofer>(); } }
        public IRepository<Operador> Operadores { get { return GetStandardRepo<Operador>(); } }
        public IRepository<MotivosTallere> MotivosTalleres { get { return GetStandardRepo<MotivosTallere>(); } } 
        public IRepository<Movil> Moviles { get { return GetStandardRepo<Movil>(); } }
        public IRepository<Promocione> Promociones { get { return GetStandardRepo<Promocione>(); } }
        public IRepository<PromocionesMovile> PromocionesMoviles { get { return GetStandardRepo<PromocionesMovile>(); } }
        public IRepository<Tarifa> Tarifas { get { return GetStandardRepo<Tarifa>(); } }
        public IRepository<PagoCelular> PagosCelulares { get { return GetStandardRepo<PagoCelular>(); } }
        public IRepository<PagosBas> PagosBases { get { return GetStandardRepo<PagosBas>(); } }
        public IRepository<Celular> Celulares { get { return GetStandardRepo<Celular>(); } }
        public IRepository<PagosMovile> PagosMoviles { get { return GetStandardRepo<PagosMovile>(); } }
        //public IReporteRepository Reportes { get; private set; }
        public IRepository<Sucursal> Sucursales { get { return GetStandardRepo<Sucursal>(); } }
        public IRepository<Dia> Dias { get { return GetStandardRepo<Dia>(); } }
        public IRepository<EmpresasCelulare> EmpresasCelulares{get { return GetStandardRepo<EmpresasCelulare>(); }}
        public IRepository<ModelosCelulare> ModelosCelulares { get { return GetStandardRepo<ModelosCelulare>(); } }
        public IRepository<TipoCelular> TiposCelulares { get { return GetStandardRepo<TipoCelular>(); } }
        public IRepository<ChoferMontoFavor> ChoferesMontosFavor { get { return GetStandardRepo<ChoferMontoFavor>(); } }
        public IRepository<CajaMovimiento> CajaMovimientos { get { return GetStandardRepo<CajaMovimiento>(); } }
        public IRepository<ChoferesMovil> ChoferesMoviles { get { return GetStandardRepo<ChoferesMovil>(); } }
        public IRepository<ChoferCelular> ChoferCelulares { get { return GetStandardRepo<ChoferCelular>(); } }
        public IRepository<OperadorSucursal> OperadorSucursales { get { return GetStandardRepo<OperadorSucursal>(); } }
        public IRepository<CajaBalance> CajaBalances { get { return GetStandardRepo<CajaBalance>(); } }
        public IRepository<Comentario> Comentarios { get { return GetStandardRepo<Comentario>(); } }
        public IRepository<ComentariosChofer> ComentariosChoferes { get { return GetStandardRepo<ComentariosChofer>(); } }
        public IRepository<OrdenPago> OrdenesPagos { get { return GetStandardRepo<OrdenPago>(); } }
        public IRepository<OrdenPagoDetalle> OrdenesPagosDetalles { get { return GetStandardRepo<OrdenPagoDetalle>(); } }
        public IRepository<Proveedor> Proveedores { get { return GetStandardRepo<Proveedor>(); } }
        public IRepository<Tallere> Talleres { get { return GetStandardRepo<Tallere>(); } }
        public IRepository<TalleresMovile> TalleresMoviles { get { return GetStandardRepo<TalleresMovile>(); } }
        public IRepository<TalleresMotivosMovile> TalleresMotivosMoviles { get { return GetStandardRepo<TalleresMotivosMovile>(); } }
        public IRepository<Titulare> Titulares { get { return GetStandardRepo<Titulare>(); } }
        public IRepository<MovilesMontoFavor> MovilesMontosFavor { get { return GetStandardRepo<MovilesMontoFavor>(); } }
        public IRepository<Cliente> Clientes { get { return GetStandardRepo<Cliente>(); } }
        public string ConnectionString
        {
            get
            {
                var builder = new EntityConnectionStringBuilder();
                builder.Metadata = @"res://*/OfficeModel.csdl|res://*/OfficeModel.ssdl|res://*/OfficeModel.msl";
                builder.Provider = "System.Data.SqlClient";
                builder.ProviderConnectionString = ConfigurationManager.ConnectionStrings["OfficeEntities"].ConnectionString;
                return builder.ToString();
            }
        }

        public bool IsDisposed { get; private set; }

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public Task CommitAsync()
        {
            return DbContext.SaveChangesAsync();
        }

        protected void CreateDbContext()
        {
            DbContext = new GestionAdministrativaDbContext();  

            // Do NOT enable proxied entities, else serialization fails
            DbContext.Configuration.ProxyCreationEnabled = false;

            // Load navigation properties explicitly (avoid serialization trouble)
            DbContext.Configuration.LazyLoadingEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            DbContext.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need 
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
        }

        protected IRepositoryProvider RepositoryProvider { get; set; }

        private IRepository<T> GetStandardRepo<T>() where T : class
        {
            //return RepositoryProvider.GetRepositoryForEntityType<T>();
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        public GestionAdministrativaDbContext DbContext { get; set; }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }

        #endregion


        
    }
}
