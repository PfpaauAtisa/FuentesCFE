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
    
    public partial class tbl_Log_Documento_Electronico
    {
        public int tbl_Log_Documento_Electronico_id { get; set; }
        public Nullable<System.DateTime> Fecha_Hora_Envio { get; set; }
        public string tipo_documento { get; set; }
        public Nullable<decimal> numero_documento { get; set; }
        public string id_oficina { get; set; }
        public string id_entidad { get; set; }
        public Nullable<System.DateTime> fecha_hora_timbrado { get; set; }
        public string informacion_cliente { get; set; }
        public string docto_electronico { get; set; }
        public string detalle_envio { get; set; }
        public string respuesta_fiscal { get; set; }
        public string resultado_envio { get; set; }
        public Nullable<bool> Aprobado { get; set; }
        public string Numero_Serie_Electronica { get; set; }
        public string Numero_Documento_Electronico { get; set; }
        public Nullable<bool> Anulado { get; set; }
    }
}
