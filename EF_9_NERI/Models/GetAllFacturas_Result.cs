//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_9_NERI.Models
{
    using System;
    
    public partial class GetAllFacturas_Result
    {
        public int IDLINEAFRA { get; set; }
        public int IDPACIENTE { get; set; }
        public string NOMBRE_Y_APELLIDOS { get; set; }
        public string DNI { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public string Nº_FACTURA { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
    }
}
