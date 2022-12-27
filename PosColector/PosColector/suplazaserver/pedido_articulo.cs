// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.pedido_articulo
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PosColector.suplazaserver
{
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
    [DesignerCategory("code")]
    [DebuggerStepThrough]
    public class pedido_articulo
    {
        private decimal cantidadField;

        private bool cantidadFieldSpecified;

        private string cod_anexoField;

        private string cod_barrasField;

        private DateTime fecha_registroField;

        private bool fecha_registroFieldSpecified;

        private string id_pedidoField;

        private short no_articuloField;

        private bool no_articuloFieldSpecified;

        private decimal por_surtirField;

        private bool por_surtirFieldSpecified;

        private decimal por_surtir_pzasField;

        private bool por_surtir_pzasFieldSpecified;

        private decimal precio_articuloField;

        private bool precio_articuloFieldSpecified;

        public decimal cantidad
        {
            get
            {
                return cantidadField;
            }
            set
            {
                cantidadField = value;
            }
        }

        [XmlIgnore]
        public bool cantidadSpecified
        {
            get
            {
                return cantidadFieldSpecified;
            }
            set
            {
                cantidadFieldSpecified = value;
            }
        }

        [XmlElement(IsNullable = true)]
        public string cod_anexo
        {
            get
            {
                return cod_anexoField;
            }
            set
            {
                cod_anexoField = value;
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

        public short no_articulo
        {
            get
            {
                return no_articuloField;
            }
            set
            {
                no_articuloField = value;
            }
        }

        [XmlIgnore]
        public bool no_articuloSpecified
        {
            get
            {
                return no_articuloFieldSpecified;
            }
            set
            {
                no_articuloFieldSpecified = value;
            }
        }

        public decimal por_surtir
        {
            get
            {
                return por_surtirField;
            }
            set
            {
                por_surtirField = value;
            }
        }

        [XmlIgnore]
        public bool por_surtirSpecified
        {
            get
            {
                return por_surtirFieldSpecified;
            }
            set
            {
                por_surtirFieldSpecified = value;
            }
        }

        public decimal por_surtir_pzas
        {
            get
            {
                return por_surtir_pzasField;
            }
            set
            {
                por_surtir_pzasField = value;
            }
        }

        [XmlIgnore]
        public bool por_surtir_pzasSpecified
        {
            get
            {
                return por_surtir_pzasFieldSpecified;
            }
            set
            {
                por_surtir_pzasFieldSpecified = value;
            }
        }

        public decimal precio_articulo
        {
            get
            {
                return precio_articuloField;
            }
            set
            {
                precio_articuloField = value;
            }
        }

        [XmlIgnore]
        public bool precio_articuloSpecified
        {
            get
            {
                return precio_articuloFieldSpecified;
            }
            set
            {
                precio_articuloFieldSpecified = value;
            }
        }
    }

}
