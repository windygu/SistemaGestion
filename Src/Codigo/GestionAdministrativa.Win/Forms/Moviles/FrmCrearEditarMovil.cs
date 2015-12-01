﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Framework.Common.Utility;
using GestionAdministrativa.Data.Interfaces;
using Telerik.WinControls;
using GestionAdministrativa.Entities;
using GestionAdministrativa.Win.Enums;

namespace GestionAdministrativa.Win.Forms.Moviles
{
    public partial class FrmCrearEditarMovil : EditFormBase
    {
        #region InitializeComponents
            private ActionFormMode _actionForm;
            private IClock _clock;
            private Movil _movil;
        private Guid _movilId;

            public FrmCrearEditarMovil(ActionFormMode mode, IGestionAdministrativaUow uow,IClock clock,Guid id)
            {
                _actionForm = mode;
                _clock = clock;
                _movilId = id;
                Uow = uow;
                InitializeComponent();
                InicializarForm(mode);
            }

            private void InicializarForm(ActionFormMode mode)
            {
                if (_actionForm == ActionFormMode.Create)
                    this.Text = "Crear Movil";
                else
                    this.Text = "Editar Movil";
            }
        #endregion
            #region Events
            public event EventHandler<Movil> MovilAgregado;
            #endregion

            #region Properties

            public int Numero
        {
            get
            {
                int numero;
                return int.TryParse(TxtNumero.Text, out numero) ? numero : numero;
            }
            set { TxtNumero.Text = value.ToString(); } 
        }

        public string Patente
        {
            get
            {
                return (TxtPatente.Text);
            }
            set { TxtPatente.Text = value; }
        }

        #endregion

    #region Methods
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            CrearEditarMovil();
        }

        private void OnEntityAgregada(Movil movil)
        {
            if (MovilAgregado != null)
                MovilAgregado(this, movil);
        }

        private void CrearEditarMovil()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
                this.DialogResult=DialogResult.None;
            else
            {
                var entity = ObtenerEntityDesdeForm();
                if (_actionForm==ActionFormMode.Create)
                    Uow.Moviles.Agregar(entity);
                else
                    Uow.Moviles.Modificar(entity);
                Uow.Commit();
                if (_actionForm == ActionFormMode.Create)
                {
                    OnEntityAgregada(entity);
                }
            }    
        }

        private Movil ObtenerEntityDesdeForm()
        {
            _movil = new Movil();
            _movil.Id = Guid.NewGuid();
            _movil.FechaAlta = DtpFechaAlta.Value;
            _movil.Patente = Patente;
            _movil.Numero = Numero;
            _movil.SucursalAltaId = _actionForm == ActionFormMode.Create
               ? Context.SucursalActual.Id
               : _movil.SucursalAltaId;
            _movil.OperadorAltaId = _actionForm == ActionFormMode.Create
                ? Context.OperadorActual.Id
                : _movil.OperadorAltaId;
            _movil.FechaAlta = _actionForm == ActionFormMode.Create ? _clock.Now : _movil.FechaAlta;

            _movil.OperadorModificacionId = Context.OperadorActual.Id;
            _movil.SucursalModificacionId = Context.SucursalActual.Id;
            _movil.FechaModificacion = _actionForm == ActionFormMode.Edit ? _clock.Now : (DateTime?) null;

            return _movil;
        }

        protected override object ObtenerEntidad()
        {
            return (ObtenerEntityDesdeForm());
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtPatente,"Patente");
            this.ValidarControl(TxtNumero,"Numero");
        }

        #endregion

       
       

        
    }
}
