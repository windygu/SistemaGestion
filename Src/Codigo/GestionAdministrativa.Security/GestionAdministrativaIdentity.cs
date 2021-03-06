﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using GestionAdministrativa.Entities;

namespace GestionAdministrativa.Security
{
    public class GestionAdministrativaIdentity : IIdentity
    {
        public GestionAdministrativaIdentity(Operador operador, Sucursal sucursal)
        {
            Name = operador.Usuario;
            Email = string.Empty;
            Roles = operador.Roles.Select(r => r.Description).ToArray();
            Operador = operador;
            Sucursal = sucursal;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string[] Roles { get; private set; }
        public Operador Operador { get; private set; }
        public Sucursal Sucursal { get; private set; }

        #region IIdentity Members

        public string AuthenticationType
        {
            get { return "GestionAdministrativa authentication"; }
        }

        public bool IsAuthenticated
        {
            get { return !string.IsNullOrEmpty(Name); }
        }

        #endregion
    }

    public class AnonymousIdentity : GestionAdministrativaIdentity
    {
        public AnonymousIdentity()
            : base(new Operador(), new Sucursal())
        { }
    }
}
