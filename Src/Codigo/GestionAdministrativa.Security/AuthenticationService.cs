﻿using GestionAdministrativa.Security.Interfaces;
using System;
using System.Linq;
using GestionAdministrativa.Data.Interfaces;
using GestionAdministrativa.Entities;

namespace GestionAdministrativa.Security
{
    public class AuthenticationService : IAuthenticationService
    {
        private IGestionAdministrativaUow _uow;
        private readonly IEncryptionService _encryptionService;

        public AuthenticationService(IGestionAdministrativaUow uow, IEncryptionService encryptionService)
        {
            _uow = uow;
            _encryptionService = encryptionService;
        }

        public Operador AuthenticateUser(string username, string clearTextPassword)
        {
            var hashPassword = _encryptionService.CalculateHash(clearTextPassword, username);
            var operador =
                _uow.Operadores.Obtener(
                    o => o.Usuario.ToUpper().Equals(username) && o.Clave.Equals(hashPassword) && o.Habilitado,
                    o => o.Roles,
                    o => o.Personal,
                    o => o.Personal.Provincias,
                    o => o.Personal.Localidades,
                    o => o.OperadoresSucursales.Select(op => op.Sucursales));
            //var operador =
            //    _uow.Operadores.Obtener(
            //        o => o.Usuario.ToUpper().Equals(username) && o.Clave.Equals(hashPassword) && o.Habilitado);

            if (operador == null)
                throw new UnauthorizedAccessException("Access denied. Please provide some valid credentials.");

            return operador;
        }

        public void Dispose()
        {
            if (_uow != null)
            {
                _uow.Dispose();
                _uow = null;
            }
        }
    }
}
