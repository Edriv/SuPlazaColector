// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.proveedor
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    public class proveedor
    {
        private string estatusField;

        private string id_proveedorField;

        private DateTime last_change_datetimeField;

        private bool last_change_datetimeFieldSpecified;

        private string razon_socialField;

        private string rfcField;

        [XmlElement(IsNullable = true)]
        public string estatus
        {
            get
            {
                return estatusField;
            }
            set
            {
                estatusField = value;
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

        public DateTime last_change_datetime
        {
            get
            {
                return last_change_datetimeField;
            }
            set
            {
                last_change_datetimeField = value;
            }
        }

        [XmlIgnore]
        public bool last_change_datetimeSpecified
        {
            get
            {
                return last_change_datetimeFieldSpecified;
            }
            set
            {
                last_change_datetimeFieldSpecified = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string razon_social
        {
            get
            {
                return razon_socialField;
            }
            set
            {
                razon_socialField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string rfc
        {
            get
            {
                return rfcField;
            }
            set
            {
                rfcField = value;
            }
        }
    }
}
