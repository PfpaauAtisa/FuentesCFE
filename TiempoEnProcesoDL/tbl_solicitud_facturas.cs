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
    
    public partial class tbl_solicitud_facturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_solicitud_facturas()
        {
            this.tbl_solicitud_facturas_distribucion_socios = new HashSet<tbl_solicitud_facturas_distribucion_socios>();
        }
    
        public decimal id_solicitud { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string situacion { get; set; }
        public string id_oficina { get; set; }
        public string id_empleado { get; set; }
        public string id_job { get; set; }
        public string id_cliente { get; set; }
        public Nullable<System.DateTime> fecha_a_emitir { get; set; }
        public string instrucciones { get; set; }
        public string id_entidad { get; set; }
        public string facturar_en_perido { get; set; }
        public Nullable<int> estado { get; set; }
        public string tipo_entrega { get; set; }
        public Nullable<decimal> total_solicitud { get; set; }
        public Nullable<System.DateTime> fecha_tentativa_cobro { get; set; }
        public string elaborado { get; set; }
        public Nullable<decimal> tasa_cambio { get; set; }
        public Nullable<decimal> total_solicitud_moneda_local { get; set; }
        public Nullable<int> Imprime_moneda_Tep { get; set; }
        public string codigo_moneda_impresion { get; set; }
        public Nullable<bool> Lenguaje_Impresion_spanish { get; set; }
        public Nullable<decimal> Tasa_cambio_Fiscal { get; set; }
        public string Condicion_Venta { get; set; }
        public string Id_Actividad_Economica_CR { get; set; }
        public Nullable<bool> es_exportacion { get; set; }
        public Nullable<decimal> monto_exoneracion { get; set; }
        public string numero_documento_referencia { get; set; }
        public Nullable<System.DateTime> fecha_documento_referencia { get; set; }
        public Nullable<int> tasa_impuesto { get; set; }
        public string correo_electronico { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_solicitud_facturas_distribucion_socios> tbl_solicitud_facturas_distribucion_socios { get; set; }
    }
}