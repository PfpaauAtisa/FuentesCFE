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
    
    public partial class tbl_reportes_tiempo_temp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_reportes_tiempo_temp()
        {
            this.tbl_detalle_cargable_temp = new HashSet<tbl_detalle_cargable_temp>();
            this.tbl_no_cargables_temp = new HashSet<tbl_no_cargables_temp>();
        }
    
        public string id_oficina { get; set; }
        public string id_empleado { get; set; }
        public string periodo_tep_proceso { get; set; }
        public string periodo_tep_corresponde { get; set; }
        public Nullable<decimal> tasa_cambio { get; set; }
        public Nullable<decimal> de_dia { get; set; }
        public Nullable<decimal> a_dia { get; set; }
        public string captado_por { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_detalle_cargable_temp> tbl_detalle_cargable_temp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_no_cargables_temp> tbl_no_cargables_temp { get; set; }
    }
}