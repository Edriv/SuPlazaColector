// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.compra_articulo
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    [DesignerCategory("code")]
    public class compra_articulo
    {
        private string cant_cjaField;

        private string cant_pzaField;

        private string cod_barrasField;

        private string id_compraField;

        private string no_capturaField;

        private string no_entregaField;

        private string num_articuloField;

        private string precio_compraField;

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
        public string no_captura
        {
            get
            {
                return no_capturaField;
            }
            set
            {
                no_capturaField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string no_entrega
        {
            get
            {
                return no_entregaField;
            }
            set
            {
                no_entregaField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string num_articulo
        {
            get
            {
                return num_articuloField;
            }
            set
            {
                num_articuloField = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string precio_compra
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
    }
}
