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
    
    public partial class tbl_gastos_administrativos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_gastos_administrativos()
        {
            this.tbl_gastos_administrativos_detalle_empresas = new HashSet<tbl_gastos_administrativos_detalle_empresas>();
        }
    
        public string id_gasto { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Distribucion_Proporcional_socios { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_gastos_administrativos_detalle_empresas> tbl_gastos_administrativos_detalle_empresas { get; set; }
    }
}