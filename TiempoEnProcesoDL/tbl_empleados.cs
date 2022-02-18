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
    
    public partial class tbl_empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_empleados()
        {
            this.tbl_trabajos_distribucion = new HashSet<tbl_trabajos_distribucion>();
            this.tbl_solicitud_facturas_distribucion_socios = new HashSet<tbl_solicitud_facturas_distribucion_socios>();
        }
    
        public string id_oficina { get; set; }
        public string id_empleado { get; set; }
        public string iniciales { get; set; }
        public string id_puesto { get; set; }
        public string id_departamento { get; set; }
        public string Nombres { get; set; }
        public string apellidos { get; set; }
        public Nullable<decimal> cuota_facturacion_local { get; set; }
        public Nullable<decimal> cuota_facturacion_interamerica { get; set; }
        public string situacion_actual { get; set; }
        public string ultimo_reporte_entregado { get; set; }
        public string clave { get; set; }
        public Nullable<decimal> presupuesto_horas { get; set; }
        public Nullable<System.DateTime> fecha_ingreso { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public decimal usuario_administrativo { get; set; }
        public string id_team { get; set; }
        public string cem_costo { get; set; }
        public Nullable<System.DateTime> ultima_fecha_pass { get; set; }
        public bool logged { get; set; }
        public Nullable<System.DateTime> fecha_baja { get; set; }
        public string id_workday { get; set; }
        public string empoyee_ppi { get; set; }
        public string FE_Token { get; set; }
        public Nullable<System.DateTime> Fecha_Hora_Expira_Token { get; set; }
        public string partyId { get; set; }
        public Nullable<bool> No_Trabaja_sabado { get; set; }
    
        public virtual tbl_puestos tbl_puestos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_trabajos_distribucion> tbl_trabajos_distribucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_solicitud_facturas_distribucion_socios> tbl_solicitud_facturas_distribucion_socios { get; set; }
    }
}