// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.pedido
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    [DebuggerStepThrough]
    public class pedido
    {
        private DateTime fecha_pedidoField;

        private bool fecha_pedidoFieldSpecified;

        private DateTime fecha_registroField;

        private bool fecha_registroFieldSpecified;

        private string id_pedidoField;

        private string id_proveedorField;

        private long num_pedidoField;

        private bool num_pedidoFieldSpecified;

        private string status_pedidoField;

        public DateTime fecha_pedido
        {
            get
            {
                return fecha_pedidoField;
            }
            set
            {
                fecha_pedidoField = value;
            }
        }

        [XmlIgnore]
        public bool fecha_pedidoSpecified
        {
            get
            {
                return fecha_pedidoFieldSpecified;
            }
            set
            {
                fecha_pedidoFieldSpecified = value;
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

        public long num_pedido
        {
            get
            {
                return num_pedidoField;
            }
            set
            {
                num_pedidoField = value;
            }
        }

        [XmlIgnore]
        public bool num_pedidoSpecified
        {
            get
            {
                return num_pedidoFieldSpecified;
            }
            set
            {
                num_pedidoFieldSpecified = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string status_pedido
        {
            get
            {
                return status_pedidoField;
            }
            set
            {
                status_pedidoField = value;
            }
        }
    }
}
