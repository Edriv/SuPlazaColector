// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.usuario_permiso
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    [DesignerCategory("code")]
    [DebuggerStepThrough]
    public class usuario_permiso
    {
        private DateTime fecha_registroField;

        private bool fecha_registroFieldSpecified;

        private string id_permisoField;

        private string user_nameField;

        private decimal valor_numField;

        private bool valor_numFieldSpecified;

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

        [XmlElement(IsNullable = true)]
        public string id_permiso
        {
            get
            {
                return id_permisoField;
            }
            set
            {
                id_permisoField = value;
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

        public decimal valor_num
        {
            get
            {
                return valor_numField;
            }
            set
            {
                valor_numField = value;
            }
        }

        [XmlIgnore]
        public bool valor_numSpecified
        {
            get
            {
                return valor_numFieldSpecified;
            }
            set
            {
                valor_numFieldSpecified = value;
            }
        }
    }
}
