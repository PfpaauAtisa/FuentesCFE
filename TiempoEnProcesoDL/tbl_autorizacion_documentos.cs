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
    
    public partial class tbl_autorizacion_documentos
    {
        public string id_oficina { get; set; }
        public string id_entidad { get; set; }
        public string id_tipo_documento { get; set; }
        public string numero_autorizacion { get; set; }
        public System.DateTime fecha_autorizacion { get; set; }
        public string serie { get; set; }
        public int numero_inicial { get; set; }
        public int numero_final { get; set; }
        public string tipo_docface { get; set; }
        public Nullable<int> numero_dispositivo { get; set; }
    
        public virtual tbl_tipo_documento tbl_tipo_documento { get; set; }
    }
}
