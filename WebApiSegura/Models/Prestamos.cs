//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiSegura.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prestamos
    {
        public int Codigo { get; set; }
        public System.DateTime FechaLimite { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public decimal MontoPago { get; set; }
        public int TipoPrestamo { get; set; }
        public decimal Interes { get; set; }
        public int CodigoCuenta { get; set; }
        public int CodigoSucursal { get; set; }
    
        public virtual Cuenta Cuenta { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Tipo_Prestamo Tipo_Prestamo { get; set; }
    }
}