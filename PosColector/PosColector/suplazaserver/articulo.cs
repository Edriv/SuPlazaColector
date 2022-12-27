// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.articulo
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class articulo
    {
        private bool articulo_disponibleField;

        private bool articulo_disponibleFieldSpecified;

        private decimal cantidad_umField;

        private bool cantidad_umFieldSpecified;

        private string cod_asociadoField;

        private string cod_barrasField;

        private string cod_internoField;

        private string descripcionField;

        private string descripcion_cortaField;

        private DateTime fecha_registroField;

        private bool fecha_registroFieldSpecified;

        private long id_clasificacionField;

        private bool id_clasificacionFieldSpecified;

        private string id_proveedorField;

        private string id_unidadField;

        private decimal ivaField;

        private bool ivaFieldSpecified;

        private bool kitField;

        private bool kitFieldSpecified;

        private DateTime kit_fecha_finField;

        private bool kit_fecha_finFieldSpecified;

        private DateTime kit_fecha_iniField;

        private bool kit_fecha_iniFieldSpecified;

        private DateTime last_update_inventoryField;

        private bool last_update_inventoryFieldSpecified;

        private decimal precio_compraField;

        private bool precio_compraFieldSpecified;

        private decimal precio_ventaField;

        private bool precio_ventaFieldSpecified;

        private short puntosField;

        private bool puntosFieldSpecified;

        private decimal stockField;

        private bool stockFieldSpecified;

        private decimal stock_maxField;

        private bool stock_maxFieldSpecified;

        private decimal stock_minField;

        private bool stock_minFieldSpecified;

        private string tipo_articuloField;

        private decimal utilidadField;

        private bool utilidadFieldSpecified;

        private bool visibleField;

        private bool visibleFieldSpecified;

        public bool articulo_disponible
        {
            get
            {
                return articulo_disponibleField;
            }
            set
            {
                articulo_disponibleField = value;
            }
        }

        [XmlIgnore]
        public bool articulo_disponibleSpecified
        {
            get
            {
                return articulo_disponibleFieldSpecified;
            }
            set
            {
                articulo_disponibleFieldSpecified = value;
            }
        }

        public decimal cantidad_um
        {
            get
            {
                return cantidad_umField;
            }
            set
            {
                cantidad_umField = value;
            }
        }

        [XmlIgnore]
        public bool cantidad_umSpecified
        {
            get
            {
                return cantidad_umFieldSpecified;
            }
            set
            {
                cantidad_umFieldSpecified = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string cod_asociado
        {
            get
            {
                return cod_asociadoField;
            }
            set
            {
                cod_asociadoField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string cod_barras
        {
            get
            {
                return cod_barrasField;
            }
            set
            {
                cod_barrasField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string cod_interno
        {
            get
            {
                return cod_internoField;
            }
            set
            {
                cod_internoField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string descripcion
        {
            get
            {
                return descripcionField;
            }
            set
            {
                descripcionField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string descripcion_corta
        {
            get
            {
                return descripcion_cortaField;
            }
            set
            {
                descripcion_cortaField = value;
            }
        }

        public DateTime fecha_registro
        {
            get
            {
                return fecha_registroField;
            }
            set
            {
                fecha_registroField = value;
            }
        }

        [XmlIgnore]
        public bool fecha_registroSpecified
        {
            get
            {
                return fecha_registroFieldSpecified;
            }
            set
            {
                fecha_registroFieldSpecified = value;
            }
        }

        public long id_clasificacion
        {
            get
            {
                return id_clasificacionField;
            }
            set
            {
                id_clasificacionField = value;
            }
        }

        [XmlIgnore]
        public bool id_clasificacionSpecified
        {
            get
            {
                return id_clasificacionFieldSpecified;
            }
            set
            {
                id_clasificacionFieldSpecified = value;
            }
        }

        public string id_proveedor
        {
            get
            {
                return id_proveedorField;
            }
            set
            {
                id_proveedorField = value;
            }
        }

        public string id_unidad
        {
            get
            {
                return id_unidadField;
            }
            set
            {
                id_unidadField = value;
            }
        }

        public decimal iva
        {
            get
            {
                return ivaField;
            }
            set
            {
                ivaField = value;
            }
        }

        [XmlIgnore]
        public bool ivaSpecified
        {
            get
            {
                return ivaFieldSpecified;
            }
            set
            {
                ivaFieldSpecified = value;
            }
        }

        public bool kit
        {
            get
            {
                return kitField;
            }
            set
            {
                kitField = value;
            }
        }

        [XmlIgnore]
        public bool kitSpecified
        {
            get
            {
                return kitFieldSpecified;
            }
            set
            {
                kitFieldSpecified = value;
            }
        }

        public DateTime kit_fecha_fin
        {
            get
            {
                return kit_fecha_finField;
            }
            set
            {
                kit_fecha_finField = value;
            }
        }

        [XmlIgnore]
        public bool kit_fecha_finSpecified
        {
            get
            {
                return kit_fecha_finFieldSpecified;
            }
            set
            {
                kit_fecha_finFieldSpecified = value;
            }
        }

        public DateTime kit_fecha_ini
        {
            get
            {
                return kit_fecha_iniField;
            }
            set
            {
                kit_fecha_iniField = value;
            }
        }

        [XmlIgnore]
        public bool kit_fecha_iniSpecified
        {
            get
            {
                return kit_fecha_iniFieldSpecified;
            }
            set
            {
                kit_fecha_iniFieldSpecified = value;
            }
        }

        public DateTime last_update_inventory
        {
            get
            {
                return last_update_inventoryField;
            }
            set
            {
                last_update_inventoryField = value;
            }
        }

        [XmlIgnore]
        public bool last_update_inventorySpecified
        {
            get
            {
                return last_update_inventoryFieldSpecified;
            }
            set
            {
                last_update_inventoryFieldSpecified = value;
            }
        }

        public decimal precio_compra
        {
            get
            {
                return precio_compraField;
            }
            set
            {
                precio_compraField = value;
            }
        }

        [XmlIgnore]
        public bool precio_compraSpecified
        {
            get
            {
                return precio_compraFieldSpecified;
            }
            set
            {
                precio_compraFieldSpecified = value;
            }
        }

        public decimal precio_venta
        {
            get
            {
                return precio_ventaField;
            }
            set
            {
                precio_ventaField = value;
            }
        }

        [XmlIgnore]
        public bool precio_ventaSpecified
        {
            get
            {
                return precio_ventaFieldSpecified;
            }
            set
            {
                precio_ventaFieldSpecified = value;
            }
        }

        public short puntos
        {
            get
            {
                return puntosField;
            }
            set
            {
                puntosField = value;
            }
        }

        [XmlIgnore]
        public bool puntosSpecified
        {
            get
            {
                return puntosFieldSpecified;
            }
            set
            {
                puntosFieldSpecified = value;
            }
        }

        public decimal stock
        {
            get
            {
                return stockField;
            }
            set
            {
                stockField = value;
            }
        }

        [XmlIgnore]
        public bool stockSpecified
        {
            get
            {
                return stockFieldSpecified;
            }
            set
            {
                stockFieldSpecified = value;
            }
        }

        public decimal stock_max
        {
            get
            {
                return stock_maxField;
            }
            set
            {
                stock_maxField = value;
            }
        }

        [XmlIgnore]
        public bool stock_maxSpecified
        {
            get
            {
                return stock_maxFieldSpecified;
            }
            set
            {
                stock_maxFieldSpecified = value;
            }
        }

        public decimal stock_min
        {
            get
            {
                return stock_minField;
            }
            set
            {
                stock_minField = value;
            }
        }

        [XmlIgnore]
        public bool stock_minSpecified
        {
            get
            {
                return stock_minFieldSpecified;
            }
            set
            {
                stock_minFieldSpecified = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string tipo_articulo
        {
            get
            {
                return tipo_articuloField;
            }
            set
            {
                tipo_articuloField = value;
            }
        }

        public decimal utilidad
        {
            get
            {
                return utilidadField;
            }
            set
            {
                utilidadField = value;
            }
        }

        [XmlIgnore]
        public bool utilidadSpecified
        {
            get
            {
                return utilidadFieldSpecified;
            }
            set
            {
                utilidadFieldSpecified = value;
            }
        }

        public bool visible
        {
            get
            {
                return visibleField;
            }
            set
            {
                visibleField = value;
            }
        }

        [XmlIgnore]
        public bool visibleSpecified
        {
            get
            {
                return visibleFieldSpecified;
            }
            set
            {
                visibleFieldSpecified = value;
            }
        }
    }
}
