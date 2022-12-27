// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.compra
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    public class compra
    {
        private bool canceladaField;

        private bool canceladaFieldSpecified;

        private DateTime fecha_cancelacionField;

        private bool fecha_cancelacionFieldSpecified;

        private string fecha_compraField;

        private string id_compraField;

        private string id_pedidoField;

        private string id_proveedorField;

        private short no_entradaField;

        private bool no_entradaFieldSpecified;

        private string no_facturaField;

        private string observacionesField;

        public bool cancelada
        {
            get
            {
                return canceladaField;
            }
            set
            {
                canceladaField = value;
            }
        }

        [XmlIgnore]
        public bool canceladaSpecified
        {
            get
            {
                return canceladaFieldSpecified;
            }
            set
            {
                canceladaFieldSpecified = value;
            }
        }

        public DateTime fecha_cancelacion
        {
            get
            {
                return fecha_cancelacionField;
            }
            set
            {
                fecha_cancelacionField = value;
            }
        }

        [XmlIgnore]
        public bool fecha_cancelacionSpecified
        {
            get
            {
                return fecha_cancelacionFieldSpecified;
            }
            set
            {
                fecha_cancelacionFieldSpecified = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string fecha_compra
        {
            get
            {
                return fecha_compraField;
            }
            set
            {
                fecha_compraField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string id_compra
        {
            get
            {
                return id_compraField;
            }
            set
            {
                id_compraField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string id_pedido
        {
            get
            {
                return id_pedidoField;
            }
            set
            {
                id_pedidoField = value;
            }
        }

        [XmlElement(IsNullable = true)]
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

        public short no_entrada
        {
            get
            {
                return no_entradaField;
            }
            set
            {
                no_entradaField = value;
            }
        }

        [XmlIgnore]
        public bool no_entradaSpecified
        {
            get
            {
                return no_entradaFieldSpecified;
            }
            set
            {
                no_entradaFieldSpecified = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string no_factura
        {
            get
            {
                return no_facturaField;
            }
            set
            {
                no_facturaField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string observaciones
        {
            get
            {
                return observacionesField;
            }
            set
            {
                observacionesField = value;
            }
        }
    }

}
