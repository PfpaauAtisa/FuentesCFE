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
    
    public partial class tbl_creditos_aplicaciones
    {
        public decimal id_transaccion { get; set; }
        public string periodo_tep { get; set; }
        public string id_oficina { get; set; }
        public string id_job { get; set; }
        public string id_cliente { get; set; }
        public Nullable<decimal> realizacion_gastos { get; set; }
        public Nullable<decimal> realizacion_honorarios { get; set; }
        public string realizado_por { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    }
}