//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiempoEnProcesoDL
{
    using System;
    
    public partial class rpt_Productividad_Control_Rentabilidad_Result
    {
        public string id_oficina { get; set; }
        public string Nombre_Oficina { get; set; }
        public Nullable<System.DateTime> Fecha_Desde { get; set; }
        public Nullable<System.DateTime> Fecha_Hasta { get; set; }
        public string Socio { get; set; }
        public string NombreSocio { get; set; }
        public Nullable<decimal> Valor_Total_Factura_Socio { get; set; }
        public Nullable<decimal> Horas_cargadas_socios { get; set; }
        public Nullable<decimal> Honorarios_socios { get; set; }
        public Nullable<decimal> Gastos_socio { get; set; }
    }
}