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
    using System.Collections.Generic;
    
    public partial class tbl_det_Solicitud_temp
    {
        public decimal linea { get; set; }
        public decimal line_detalle { get; set; }
        public string concepto { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Impuesto_por { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string atencion_a { get; set; }
        public string id_empleado { get; set; }
    
        public virtual tbl_solicitud_facturas_temp tbl_solicitud_facturas_temp { get; set; }
    }
}