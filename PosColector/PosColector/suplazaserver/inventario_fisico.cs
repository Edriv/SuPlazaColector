// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.inventario_fisico
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    [DesignerCategory("code")]
    [DebuggerStepThrough]
    public class inventario_fisico
    {
        private string fecha_finField;

        private DateTime fecha_iniField;

        private bool fecha_iniFieldSpecified;

        private DateTime fecha_registroField;

        private bool fecha_registroFieldSpecified;

        private string id_inventario_fisicoField;

        private string id_proveedorField;

        private string user_nameField;

        [XmlElement(IsNullable = true)]
        public string fecha_fin
        {
            get
            {
                return fecha_finField;
            }
            set
            {
                fecha_finField = value;
            }
        }

        public DateTime fecha_ini
        {
            get
            {
                return fecha_iniField;
            }
            set
            {
                fecha_iniField = value;
            }
        }

        [XmlIgnore]
        public bool fecha_iniSpecified
        {
            get
            {
                return fecha_iniFieldSpecified;
            }
            set
            {
                fecha_iniFieldSpecified = value;
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

        public string id_inventario_fisico
        {
            get
            {
                return id_inventario_fisicoField;
            }
            set
            {
                id_inventario_fisicoField = value;
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

        [XmlElement(IsNullable = true)]
        public string user_name
        {
            get
            {
                return user_nameField;
            }
            set
            {
                user_nameField = value;
            }
        }
    }

}
