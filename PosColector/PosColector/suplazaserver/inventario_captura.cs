// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.inventario_captura
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    public class inventario_captura
    {
        private string cant_cjaField;

        private string cant_pzaField;

        private string cod_barrasField;

        private string fecha_capturaField;

        private string id_capturaField;

        private string id_inventario_fisicoField;

        private string num_capturaField;

        [XmlElement(IsNullable = true)]
        public string cant_cja
        {
            get
            {
                return cant_cjaField;
            }
            set
            {
                cant_cjaField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string cant_pza
        {
            get
            {
                return cant_pzaField;
            }
            set
            {
                cant_pzaField = value;
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
        public string fecha_captura
        {
            get
            {
                return fecha_capturaField;
            }
            set
            {
                fecha_capturaField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string id_captura
        {
            get
            {
                return id_capturaField;
            }
            set
            {
                id_capturaField = value;
            }
        }

        [XmlElement(IsNullable = true)]
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

        [XmlElement(IsNullable = true)]
        public string num_captura
        {
            get
            {
                return num_capturaField;
            }
            set
            {
                num_capturaField = value;
            }
        }
    }

}
