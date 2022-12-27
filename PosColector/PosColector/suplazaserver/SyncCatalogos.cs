// POSColector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// POSColector.suplazaserver.SyncCatalogos
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using PosColector.suplazaserver;

namespace PosColector.suplazaserver
{
    [WebServiceBinding(Name = "BasicHttpBinding_ISyncCatalogos", Namespace = "http://tempuri.org/")]
    [DesignerCategory("code")]
    [DebuggerStepThrough]
    public class SyncCatalogos : SoapHttpClientProtocol
    {
        public SyncCatalogos()
        {
            ((WebClientProtocol)this).Url = "http://192.168.88.100:8732/SyncPOS.SyncCatalogos.svc";
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        [return: XmlArrayItem(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
        [return: XmlArray(IsNullable = true)]
        public unidad_medida[] getUnidades([XmlElement(IsNullable = true)] string lastChangeDateTime)
        {
            object[] array = (this).Invoke("getUnidades", new object[1] { lastChangeDateTime });
            return (unidad_medida[])array[0];
        }

        public IAsyncResult BegingetUnidades(string lastChangeDateTime, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("getUnidades", new object[1] { lastChangeDateTime }, callback, asyncState);
        }

        public unidad_medida[] EndgetUnidades(IAsyncResult asyncResult)
        {
            object[] array = (this).EndInvoke(asyncResult);
            return (unidad_medida[])array[0];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        [return: XmlArrayItem(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
        [return: XmlArray(IsNullable = true)]
        public proveedor[] getProveedores([XmlElement(IsNullable = true)] string lastChangeDateTime)
        {
            object[] array = (this).Invoke("getProveedores", new object[1] { lastChangeDateTime });
            return (proveedor[])array[0];
        }

        public IAsyncResult BegingetProveedores(string lastChangeDateTime, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("getProveedores", new object[1] { lastChangeDateTime }, callback, asyncState);
        }

        public proveedor[] EndgetProveedores(IAsyncResult asyncResult)
        {
            object[] array = (this).EndInvoke(asyncResult);
            return (proveedor[])array[0];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        [return: XmlArray(IsNullable = true)]
        [return: XmlArrayItem(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
        public articulo[] getArticulos([XmlElement(IsNullable = true)] string lastChangeDateTime)
        {
            object[] array = (this).Invoke("getArticulos", new object[1] { lastChangeDateTime });
            return (articulo[])array[0];
        }

        public IAsyncResult BegingetArticulos(string lastChangeDateTime, AsyncCallback callback, object asyncState)
        {
            return ((this).BeginInvoke("getArticulos", new object[1] { lastChangeDateTime }, callback, asyncState));
        }

        public articulo[] EndgetArticulos(IAsyncResult asyncResult)
        {
            object[] array = ((this).EndInvoke(asyncResult));
            return (articulo[])array[0];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        [return: XmlArray(IsNullable = true)]
        [return: XmlArrayItem(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
        public usuario[] getUsuarios([XmlElement(IsNullable = true)] string lastChangeDateTime)
        {
            object[] array = (this).Invoke("getUsuarios", new object[1] { lastChangeDateTime });
            return (usuario[])array[0];
        }

        public IAsyncResult BegingetUsuarios(string lastChangeDateTime, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("getUsuarios", new object[1] { lastChangeDateTime }, callback, asyncState);
        }

        public usuario[] EndgetUsuarios(IAsyncResult asyncResult)
        {
            object[] array = (this).EndInvoke(asyncResult);
            return (usuario[])array[0];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        [return: XmlArray(IsNullable = true)]
        [return: XmlArrayItem(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
        public usuario_permiso[] getPermisosUsuarios([XmlElement(IsNullable = true)] string lastChangeDateTime)
        {
            object[] array = (this).Invoke("getPermisosUsuarios", new object[1] { lastChangeDateTime });
            return (usuario_permiso[])array[0];
        }

        public IAsyncResult BegingetPermisosUsuarios(string lastChangeDateTime, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("getPermisosUsuarios", new object[1] { lastChangeDateTime }, callback, asyncState);
        }

        public usuario_permiso[] EndgetPermisosUsuarios(IAsyncResult asyncResult)
        {
            object[] array = (this).EndInvoke(asyncResult);
            return (usuario_permiso[])array[0];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        [return: XmlArrayItem(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
        [return: XmlArray(IsNullable = true)]
        public pedido[] GetOrders([XmlElement(IsNullable = true)] string lastChangeDateTime)
        {
            object[] array = (this).Invoke("GetOrders", new object[1] { lastChangeDateTime });
            return (pedido[])array[0];
        }

        public IAsyncResult BeginGetOrders(string lastChangeDateTime, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("GetOrders", new object[1] { lastChangeDateTime }, callback, asyncState);
        }

        public pedido[] EndGetOrders(IAsyncResult asyncResult)
        {
            object[] array = (this).EndInvoke(asyncResult);
            return (pedido[])array[0];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        [return: XmlArray(IsNullable = true)]
        [return: XmlArrayItem(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
        public pedido_articulo[] GetOrderDetail(string id_pedido)
        {
            object[] array = (this).Invoke("GetOrderDetail", new object[1] { id_pedido });
            return (pedido_articulo[])array[0];
        }

        public IAsyncResult BeginGetOrderDetail(string id_pedido, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("GetOrderDetail", new object[1] { id_pedido }, callback, asyncState);
        }

        public pedido_articulo[] EndGetOrderDetail(IAsyncResult asyncResult)
        {
            object[] array = (this).EndInvoke(asyncResult);
            return (pedido_articulo[])array[0];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        [return: XmlArray(IsNullable = true)]
        [return: XmlArrayItem(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
        public pedido_articulo[] GetOrderDetailUpdate([XmlElement(IsNullable = true)] string lastChangeDateTime)
        {
            object[] array = (this).Invoke("GetOrderDetailUpdate", new object[1] { lastChangeDateTime });
            return (pedido_articulo[])array[0];
        }

        public IAsyncResult BeginGetOrderDetailUpdate(string lastChangeDateTime, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("GetOrderDetailUpdate", new object[1] { lastChangeDateTime }, callback, asyncState);
        }

        public pedido_articulo[] EndGetOrderDetailUpdate(IAsyncResult asyncResult)
        {
            object[] array = (this).EndInvoke(asyncResult);
            return (pedido_articulo[])array[0];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        [return: XmlArrayItem(Namespace = "http://schemas.datacontract.org/2004/07/SyncPOS.domain")]
        [return: XmlArray(IsNullable = true)]
        public inventario_fisico[] GetInventarios([XmlElement(IsNullable = true)] string lastChangeDateTime)
        {
            object[] array = (this).Invoke("GetInventarios", new object[1] { lastChangeDateTime });
            return (inventario_fisico[])array[0];
        }

        public IAsyncResult BeginGetInventarios(string lastChangeDateTime, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("GetInventarios", new object[1] { lastChangeDateTime }, callback, asyncState);
        }

        public inventario_fisico[] EndGetInventarios(IAsyncResult asyncResult)
        {
            object[] array = (this).EndInvoke(asyncResult);
            return (inventario_fisico[])array[0];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        public void SetInventarios([XmlElement(IsNullable = true)] inventario_captura p, out bool SetInventariosResult, [XmlIgnore] out bool SetInventariosResultSpecified)
        {
            object[] array = (this).Invoke("SetInventarios", new object[1] { p });
            SetInventariosResult = (bool)array[0];
            SetInventariosResultSpecified = (bool)array[1];
        }

        public IAsyncResult BeginSetInventarios(inventario_captura p, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("SetInventarios", new object[1] { p }, callback, asyncState);
        }

        public void EndSetInventarios(IAsyncResult asyncResult, out bool SetInventariosResult, out bool SetInventariosResultSpecified)
        {
            object[] array = (this).EndInvoke(asyncResult);
            SetInventariosResult = (bool)array[0];
            SetInventariosResultSpecified = (bool)array[1];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        public void CreatePurchase([XmlElement(IsNullable = true)] compra c, out bool CreatePurchaseResult, [XmlIgnore] out bool CreatePurchaseResultSpecified)
        {
            object[] array = (this).Invoke("CreatePurchase", new object[1] { c });
            CreatePurchaseResult = (bool)array[0];
            CreatePurchaseResultSpecified = (bool)array[1];
        }

        public IAsyncResult BeginCreatePurchase(compra c, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("CreatePurchase", new object[1] { c }, callback, asyncState);
        }

        public void EndCreatePurchase(IAsyncResult asyncResult, out bool CreatePurchaseResult, out bool CreatePurchaseResultSpecified)
        {
            object[] array = (this).EndInvoke(asyncResult);
            CreatePurchaseResult = (bool)array[0];
            CreatePurchaseResultSpecified = (bool)array[1];
        }

        [SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
        public void CreatePurchaseDetail([XmlElement(IsNullable = true)] compra_articulo p, out bool CreatePurchaseDetailResult, [XmlIgnore] out bool CreatePurchaseDetailResultSpecified)
        {
            object[] array = (this).Invoke("CreatePurchaseDetail", new object[1] { p });
            CreatePurchaseDetailResult = (bool)array[0];
            CreatePurchaseDetailResultSpecified = (bool)array[1];
        }

        public IAsyncResult BeginCreatePurchaseDetail(compra_articulo p, AsyncCallback callback, object asyncState)
        {
            return (this).BeginInvoke("CreatePurchaseDetail", new object[1] { p }, callback, asyncState);
        }

        public void EndCreatePurchaseDetail(IAsyncResult asyncResult, out bool CreatePurchaseDetailResult, out bool CreatePurchaseDetailResultSpecified)
        {
            object[] array = (this).EndInvoke(asyncResult);
            CreatePurchaseDetailResult = (bool)array[0];
            CreatePurchaseDetailResultSpecified = (bool)array[1];
        }
    }

}
