// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.usuario
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    public class usuario
    {
        private bool enableField;

        private bool enableFieldSpecified;

        private DateTime fecha_registroField;

        private bool fecha_registroFieldSpecified;

        private string passwordField;

        private string tipo_usuarioField;

        private string user_nameField;

        public bool enable
        {
            get
            {
                return enableField;
            }
            set
            {
                enableField = value;
            }
        }

        [XmlIgnore]
        public bool enableSpecified
        {
            get
            {
                return enableFieldSpecified;
            }
            set
            {
                enableFieldSpecified = value;
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

        [XmlElement(IsNullable = true)]
        public string password
        {
            get
            {
                return passwordField;
            }
            set
            {
                passwordField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string tipo_usuario
        {
            get
            {
                return tipo_usuarioField;
            }
            set
            {
                tipo_usuarioField = value;
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
