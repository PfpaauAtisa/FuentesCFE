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
    
    public partial class tbl_certificacion_documento
    {
        public string id_oficina { get; set; }
        public string id_entidad { get; set; }
        public string tipo_documento { get; set; }
        public decimal numero_documento { get; set; }
        public System.DateTime fecha_envio { get; set; }
        public string firma_electronica { get; set; }
        public System.DateTime fecha_firma { get; set; }
    
        public virtual tbl_cuenta_corriente tbl_cuenta_corriente { get; set; }
    }
}