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
    
    public partial class rpt_consulta_cobros_factura_Result
    {
        public string id_oficina { get; set; }
        public string id_entidad { get; set; }
        public string tipo_documento { get; set; }
        public string tipo_documento_aplicado { get; set; }
        public decimal numero_documento { get; set; }
        public decimal numero_documento_aplicado { get; set; }
        public Nullable<decimal> valor_aplicado { get; set; }
        public Nullable<decimal> aplicado_impuestos { get; set; }
        public Nullable<decimal> aplicado_anticipos { get; set; }
        public string tipo_factura { get; set; }
        public Nullable<decimal> aplicado_preliminar { get; set; }
        public Nullable<decimal> aplicado_definitivo { get; set; }
        public decimal aplicado_impuesto { get; set; }
        public string periodo_tep { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<decimal> valor_total { get; set; }
        public Nullable<decimal> impuesto_porcentaje { get; set; }
        public string impuesto_incluido { get; set; }
        public Nullable<decimal> valor_impuesto { get; set; }
        public Nullable<decimal> saldo { get; set; }
        public Nullable<decimal> saldo_impuesto { get; set; }
        public Nullable<decimal> factura_preliminar { get; set; }
        public Nullable<decimal> anticipo_aplicar { get; set; }
        public Nullable<decimal> factura_definitiva { get; set; }
        public string concepto { get; set; }
        public Nullable<decimal> id_solicitud { get; set; }
        public string id_job { get; set; }
        public string id_cliente { get; set; }
        public Nullable<decimal> tasa_cambio { get; set; }
        public Nullable<decimal> flag_impreso { get; set; }
        public decimal estado { get; set; }
        public Nullable<decimal> linea { get; set; }
    }
}
