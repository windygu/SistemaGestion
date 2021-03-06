﻿using Framework.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativa.Entities.Dto
{
    public class PagosDto : IMapFrom<PagoCelular>
    {
        public System.Guid Id { get; set; }

        public Nullable<System.DateTime> Desde { get; set; }
        public Nullable<System.DateTime> Hasta { get; set; }
        public Nullable<decimal> Efectivo { get; set; }
        public Nullable<decimal> Vales { get; set; }
        public Nullable<decimal> Taller { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Senia { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public System.Guid CelularId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public Nullable<System.Guid> OperadorAltaId { get; set; }
        public Nullable<int> SucursalAltaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<System.Guid> OperadorModificacionId { get; set; }
        public Nullable<int> SucursalModificacionId { get; set; }
        public System.Guid ChoferId { get; set; }
        public System.Guid MovilId { get; set; }
        public Nullable<bool> Anulada { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public Nullable<System.Guid> OperadorAutorizaId { get; set; }


       
        
        
    }
}
