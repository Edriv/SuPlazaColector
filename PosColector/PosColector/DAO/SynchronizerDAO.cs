using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.Linq;
using PosColector.DAO;
using PosColector.suplazaserver;

namespace PosColector.DAO
{
	public class SynchronizerDAO : pos_colector
	{
		private string dateInitial = "01/05/2017 07:00:00";

		public static int count { get; set; }

        public void syncProveedores()
        {
            //IL_0087: Unknown result type (might be due to invalid IL or missing references)
            //IL_008d: Expected O, but got Unknown
            count = 0;

            List<proveedor> list = new SyncCatalogos().getProveedores(getLastChangeDateTimeProvider()).ToList();
            if (list.Count > 0)
            {
                count += list.Count;
                foreach (proveedor item in list)
                {
                    string text = (new proveedorDAO().exist(new Guid(item.id_proveedor)) ? "UPDATE proveedor SET rfc=@rfc,razon_social=@razon_social,fecha_registro=@fecha_registro,estatus=@estatus WHERE id_proveedor=@id_proveedor" : "INSERT INTO proveedor(id_proveedor,rfc,razon_social,fecha_registro,estatus) VALUES(@id_proveedor,@rfc,@razon_social,@fecha_registro,@estatus)");
                    SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
                    ((DbParameter)(object)val.Parameters.Add("@id_proveedor", SqlDbType.UniqueIdentifier)).Value = item.id_proveedor;
                    ((DbParameter)(object)val.Parameters.Add("@rfc", SqlDbType.NVarChar)).Value = item.rfc;
                    ((DbParameter)(object)val.Parameters.Add("@razon_social", SqlDbType.NVarChar)).Value = item.razon_social;
                    ((DbParameter)(object)val.Parameters.Add("@estatus", SqlDbType.NVarChar)).Value = item.estatus;
                    ((DbParameter)(object)val.Parameters.Add("@fecha_registro", SqlDbType.DateTime)).Value = item.last_change_datetime;
                    ((DbCommand)(object)val).CommandType = CommandType.Text;
                    ((DbCommand)(object)val).ExecuteNonQuery();
                    ((Component)(object)val).Dispose();
                    val = null;
                    GC.Collect();
                }
            }
            list.Clear();
            list = null;
            GC.Collect();
        }

        public void syncArticulos()
        {
            //IL_007b: Unknown result type (might be due to invalid IL or missing references)
            //IL_0081: Expected O, but got Unknown
            List<articulo> list = new SyncCatalogos().getArticulos(getLastChangeDateTimeItems()).ToList();
            if (list.Count > 0)
            {
                count += list.Count;
                foreach (articulo item in list)
                {
                    string text = (new articuloDAO().exist(item.cod_barras) ? "UPDATE articulo SET cod_asociado=@cod_asociado,id_clasificacion=@id_clasificacion,cod_interno=@cod_interno,descripcion=@descripcion,descripcion_corta=@descripcion_corta,cantidad_um=@cantidad_um,id_unidad=@id_unidad,id_proveedor=@id_proveedor,precio_compra=@precio_compra,utilidad=@utilidad,precio_venta=@precio_venta,tipo_articulo=@tipo_articulo,iva=@iva,articulo_disponible=@articulo_disponible,fecha_registro=@fecha_registro,visible=@visible,last_update_inventory=@last_update_inventory WHERE cod_barras=@cod_barras" : "INSERT INTO articulo(cod_barras,cod_asociado,id_clasificacion,cod_interno,descripcion,descripcion_corta,cantidad_um,id_unidad,id_proveedor,precio_compra,utilidad,precio_venta,tipo_articulo,iva,articulo_disponible,fecha_registro,visible,last_update_inventory,stock,stock_min,stock_max,kit,puntos,cve_producto) \r\nVALUES(@cod_barras,@cod_asociado,@id_clasificacion,@cod_interno,@descripcion,@descripcion_corta,@cantidad_um,@id_unidad,@id_proveedor,@precio_compra,@utilidad,@precio_venta,@tipo_articulo,@iva,@articulo_disponible,@fecha_registro,@visible,@last_update_inventory,0,0,0,0,0,'0')");
                    SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
                    ((DbParameter)(object)val.Parameters.Add("@cod_barras", SqlDbType.NVarChar)).Value = item.cod_barras;
                    ((DbParameter)(object)val.Parameters.Add("@cod_asociado", SqlDbType.NVarChar)).Value = ((object)item.cod_asociado) ?? ((object)DBNull.Value);
                    ((DbParameter)(object)val.Parameters.Add("@id_clasificacion", SqlDbType.BigInt)).Value = item.id_clasificacion;
                    ((DbParameter)(object)val.Parameters.Add("@cod_interno", SqlDbType.NVarChar)).Value = ((object)item.cod_interno) ?? ((object)DBNull.Value);
                    ((DbParameter)(object)val.Parameters.Add("@descripcion", SqlDbType.NVarChar)).Value = item.descripcion;
                    ((DbParameter)(object)val.Parameters.Add("@descripcion_corta", SqlDbType.NVarChar)).Value = item.descripcion_corta;
                    ((DbParameter)(object)val.Parameters.Add("@cantidad_um", SqlDbType.Decimal)).Value = item.cantidad_um;
                    ((DbParameter)(object)val.Parameters.Add("@id_unidad", SqlDbType.UniqueIdentifier)).Value = item.id_unidad;
                    ((DbParameter)(object)val.Parameters.Add("@id_proveedor", SqlDbType.UniqueIdentifier)).Value = item.id_proveedor;
                    ((DbParameter)(object)val.Parameters.Add("@precio_compra", SqlDbType.Decimal)).Value = item.precio_compra;
                    ((DbParameter)(object)val.Parameters.Add("@utilidad", SqlDbType.Decimal)).Value = item.utilidad;
                    ((DbParameter)(object)val.Parameters.Add("@precio_venta", SqlDbType.Decimal)).Value = item.precio_venta;
                    ((DbParameter)(object)val.Parameters.Add("@tipo_articulo", SqlDbType.NVarChar)).Value = item.tipo_articulo;
                    ((DbParameter)(object)val.Parameters.Add("@iva", SqlDbType.Decimal)).Value = item.iva;
                    ((DbParameter)(object)val.Parameters.Add("@articulo_disponible", SqlDbType.Bit)).Value = item.articulo_disponible;
                    ((DbParameter)(object)val.Parameters.Add("@fecha_registro", SqlDbType.DateTime)).Value = item.fecha_registro;
                    ((DbParameter)(object)val.Parameters.Add("@visible", SqlDbType.Bit)).Value = item.visible;
                    ((DbParameter)(object)val.Parameters.Add("@last_update_inventory", SqlDbType.DateTime)).Value = item.last_update_inventory;
                    ((DbCommand)(object)val).CommandType = CommandType.Text;
                    ((DbCommand)(object)val).ExecuteNonQuery();
                    ((Component)(object)val).Dispose();
                    val = null;
                    GC.Collect();
                }
            }
            list.Clear();
            list = null;
            GC.Collect();
        }

        public void syncUnidades()
        {
            //IL_0080: Unknown result type (might be due to invalid IL or missing references)
            //IL_0086: Expected O, but got Unknown
            List<unidad_medida> list = new SyncCatalogos().getUnidades(getLastChangeDateTimeUnits()).ToList();
            if (list.Count > 0)
            {
                count += list.Count;
                foreach (unidad_medida item in list)
                {
                    string text = (new unidad_medidaDAO().exist(new Guid(item.id_unidad)) ? "UPDATE unidad_medida SET descripcion=@descripcion,fecha_registro=@fecha_registro WHERE id_unidad=@id_unidad" : "INSERT INTO unidad_medida(id_unidad,descripcion,fecha_registro) VALUES(@id_unidad,@descripcion,@fecha_registro)");
                    SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
                    ((DbParameter)(object)val.Parameters.Add("@id_unidad", SqlDbType.UniqueIdentifier)).Value = item.id_unidad;
                    ((DbParameter)(object)val.Parameters.Add("@descripcion", SqlDbType.NVarChar)).Value = item.descripcion;
                    ((DbParameter)(object)val.Parameters.Add("@fecha_registro", SqlDbType.DateTime)).Value = item.fecha_registro;
                    ((DbCommand)(object)val).CommandType = CommandType.Text;
                    ((DbCommand)(object)val).ExecuteNonQuery();
                    ((Component)(object)val).Dispose();
                    val = null;
                    GC.Collect();
                }
            }
            list.Clear();
            list = null;
            GC.Collect();
        }

        public void syncUsuarios()
        {
            //IL_007b: Unknown result type (might be due to invalid IL or missing references)
            //IL_0081: Expected O, but got Unknown
            List<usuario> list = new SyncCatalogos().getUsuarios(getLastChangeDateTimeUsers()).ToList();
            if (list.Count > 0)
            {
                count += list.Count;
                foreach (usuario item in list)
                {
                    string text = (new usuarioDAO().existUser(item.user_name) ? "UPDATE usuario SET password=@password, tipo_usuario=@tipo_usuario, enable=@enable, fecha_registro=@fecha_registro WHERE user_name=@user_name" : "INSERT INTO usuario(user_name,password,tipo_usuario,enable,fecha_registro) VALUES(@user_name,@password,@tipo_usuario,@enable,@fecha_registro)");
                    SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
                    ((DbParameter)(object)val.Parameters.Add("@user_name", SqlDbType.NVarChar)).Value = item.user_name;
                    ((DbParameter)(object)val.Parameters.Add("@password", SqlDbType.NVarChar)).Value = item.password;
                    ((DbParameter)(object)val.Parameters.Add("@tipo_usuario", SqlDbType.NVarChar)).Value = item.tipo_usuario;
                    ((DbParameter)(object)val.Parameters.Add("@enable", SqlDbType.Bit)).Value = item.enable;
                    ((DbParameter)(object)val.Parameters.Add("@fecha_registro", SqlDbType.DateTime)).Value = item.fecha_registro;
                    ((DbCommand)(object)val).CommandType = CommandType.Text;
                    ((DbCommand)(object)val).ExecuteNonQuery();
                    ((Component)(object)val).Dispose();
                    val = null;
                    GC.Collect();
                }
            }
            list.Clear();
            list = null;
            GC.Collect();
        }

        public void syncPermisosUsuarios()
        {
            //IL_0081: Unknown result type (might be due to invalid IL or missing references)
            //IL_0087: Expected O, but got Unknown
            List<usuario_permiso> list = new SyncCatalogos().getPermisosUsuarios(getLastChangeDateTimeUsuarioPermiso()).ToList();
            if (list.Count > 0)
            {
                count += list.Count;
                foreach (usuario_permiso item in list)
                {
                    string text = (new usuarioDAO().existPermision(item.user_name, item.id_permiso) ? "UPDATE usuario_permiso SET valor_num=@valor_num,fecha_registro=@fecha_registro WHERE user_name=@user_name AND id_permiso=@id_permiso" : "INSERT INTO usuario_permiso(user_name,id_permiso,valor_num,fecha_registro) VALUES(@user_name,@id_permiso,@valor_num,@fecha_registro)");
                    SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
                    ((DbParameter)(object)val.Parameters.Add("@user_name", SqlDbType.NVarChar)).Value = item.user_name;
                    ((DbParameter)(object)val.Parameters.Add("@id_permiso", SqlDbType.NVarChar)).Value = item.id_permiso;
                    ((DbParameter)(object)val.Parameters.Add("@valor_num", SqlDbType.Decimal)).Value = ((object)item.valor_num) ?? DBNull.Value;
                    ((DbParameter)(object)val.Parameters.Add("@fecha_registro", SqlDbType.DateTime)).Value = item.fecha_registro;
                    ((DbCommand)(object)val).CommandType = CommandType.Text;
                    ((DbCommand)(object)val).ExecuteNonQuery();
                    ((Component)(object)val).Dispose();
                    val = null;
                    GC.Collect();
                }
            }
            list.Clear();
            list = null;
            GC.Collect();
        }

        public void syncPedidosDiferecia()
        {
            //IL_008c: Unknown result type (might be due to invalid IL or missing references)
            //IL_0093: Expected O, but got Unknown
            List<pedido_articulo> list = new SyncCatalogos().GetOrderDetailUpdate(getLastChangeDateTimeOrdersDetail()).ToList();
            if (list.Count > 0)
            {
                count += list.Count;
                foreach (pedido_articulo item in list)
                {
                    if (new pedido_articuloDAO().existOrderItem(new Guid(item.id_pedido), item.no_articulo))
                    {
                        string text = "UPDATE orden_articulo SET cod_barras=@cod_barras,cod_anexo=@cod_anexo,cantidad=@cantidad,precio_articulo=@precio_articulo,por_surtir=@por_surtir,por_surtir_pzas=@por_surtir_pzas,fecha_registro=@fecha_registro WHERE id_pedido=@id_pedido AND no_articulo=@no_articulo";
                        SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
                        ((DbParameter)(object)val.Parameters.Add("@id_pedido", SqlDbType.UniqueIdentifier)).Value = item.id_pedido;
                        ((DbParameter)(object)val.Parameters.Add("@no_articulo", SqlDbType.SmallInt)).Value = item.no_articulo;
                        ((DbParameter)(object)val.Parameters.Add("@cod_barras", SqlDbType.NVarChar)).Value = item.cod_barras;
                        ((DbParameter)(object)val.Parameters.Add("@cod_anexo", SqlDbType.NVarChar)).Value = item.cod_anexo;
                        ((DbParameter)(object)val.Parameters.Add("@cantidad", SqlDbType.Decimal)).Value = item.cantidad;
                        ((DbParameter)(object)val.Parameters.Add("@precio_articulo", SqlDbType.Decimal)).Value = item.precio_articulo;
                        ((DbParameter)(object)val.Parameters.Add("@por_surtir", SqlDbType.Decimal)).Value = item.por_surtir;
                        ((DbParameter)(object)val.Parameters.Add("@por_surtir_pzas", SqlDbType.Decimal)).Value = item.por_surtir_pzas;
                        ((DbParameter)(object)val.Parameters.Add("@fecha_registro", SqlDbType.DateTime)).Value = item.fecha_registro;
                        ((DbCommand)(object)val).CommandType = CommandType.Text;
                        ((DbCommand)(object)val).ExecuteNonQuery();
                        ((Component)(object)val).Dispose();
                        val = null;
                        GC.Collect();
                    }
                }
            }
            list.Clear();
            list = null;
            GC.Collect();
        }

        public void syncPedidos(string date)
        {
            //IL_0083: Unknown result type (might be due to invalid IL or missing references)
            //IL_0089: Expected O, but got Unknown
            //IL_01c3: Unknown result type (might be due to invalid IL or missing references)
            //IL_01c9: Expected O, but got Unknown
            count = 0;
            syncPedidosDiferecia();
            List<pedido> list = new SyncCatalogos().GetOrders(date).ToList();
            if (list.Count > 0)
            {
                count = list.Count;
                foreach (pedido item in list)
                {
                    string text = (new pedidoDAO().existOrder(new Guid(item.id_pedido)) ? "UPDATE orden SET num_pedido=@num_pedido, fecha_pedido=@fecha_pedido, id_proveedor=@id_proveedor, status_pedido=@status_pedido, fecha_registro=@fecha_registro WHERE id_pedido=@id_pedido" : "INSERT INTO orden(id_pedido,num_pedido,fecha_pedido,id_proveedor,status_pedido,fecha_registro) VALUES(@id_pedido,@num_pedido,@fecha_pedido,@id_proveedor,@status_pedido,@fecha_registro)");
                    SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
                    ((DbParameter)(object)val.Parameters.Add("@id_pedido", SqlDbType.UniqueIdentifier)).Value = item.id_pedido;
                    ((DbParameter)(object)val.Parameters.Add("@num_pedido", SqlDbType.BigInt)).Value = item.num_pedido;
                    ((DbParameter)(object)val.Parameters.Add("@fecha_pedido", SqlDbType.DateTime)).Value = item.fecha_pedido;
                    ((DbParameter)(object)val.Parameters.Add("@id_proveedor", SqlDbType.UniqueIdentifier)).Value = item.id_proveedor;
                    ((DbParameter)(object)val.Parameters.Add("@status_pedido", SqlDbType.NVarChar)).Value = item.status_pedido;
                    ((DbParameter)(object)val.Parameters.Add("@fecha_registro", SqlDbType.DateTime)).Value = item.fecha_registro;
                    ((DbCommand)(object)val).CommandType = CommandType.Text;
                    ((DbCommand)(object)val).ExecuteNonQuery();
                    ((Component)(object)val).Dispose();
                    val = null;
                    List<pedido_articulo> list2 = new SyncCatalogos().GetOrderDetail(item.id_pedido).ToList();
                    foreach (pedido_articulo item2 in list2)
                    {
                        text = (new pedido_articuloDAO().existOrderItem(new Guid(item2.id_pedido), item2.no_articulo) ? "UPDATE orden_articulo SET cod_barras=@cod_barras,cod_anexo=@cod_anexo,cantidad=@cantidad,precio_articulo=@precio_articulo,por_surtir=@por_surtir,por_surtir_pzas=@por_surtir_pzas,fecha_registro=@fecha_registro WHERE id_pedido=@id_pedido AND no_articulo=@no_articulo" : "INSERT INTO orden_articulo(id_pedido,no_articulo,cod_barras,cod_anexo,cantidad,precio_articulo,por_surtir,por_surtir_pzas,fecha_registro) VALUES(@id_pedido,@no_articulo,@cod_barras,@cod_anexo,@cantidad,@precio_articulo,@por_surtir,@por_surtir_pzas,@fecha_registro)");
                        val = new SqlCeCommand(text, pos_colector.getConnection());
                        ((DbParameter)(object)val.Parameters.Add("@id_pedido", SqlDbType.UniqueIdentifier)).Value = item2.id_pedido;
                        ((DbParameter)(object)val.Parameters.Add("@no_articulo", SqlDbType.SmallInt)).Value = item2.no_articulo;
                        ((DbParameter)(object)val.Parameters.Add("@cod_barras", SqlDbType.NVarChar)).Value = item2.cod_barras;
                        ((DbParameter)(object)val.Parameters.Add("@cod_anexo", SqlDbType.NVarChar)).Value = item2.cod_anexo;
                        ((DbParameter)(object)val.Parameters.Add("@cantidad", SqlDbType.Decimal)).Value = item2.cantidad;
                        ((DbParameter)(object)val.Parameters.Add("@precio_articulo", SqlDbType.Decimal)).Value = item2.precio_articulo;
                        ((DbParameter)(object)val.Parameters.Add("@por_surtir", SqlDbType.Decimal)).Value = item2.por_surtir;
                        ((DbParameter)(object)val.Parameters.Add("@por_surtir_pzas", SqlDbType.Decimal)).Value = item2.por_surtir_pzas;
                        ((DbParameter)(object)val.Parameters.Add("@fecha_registro", SqlDbType.DateTime)).Value = item2.fecha_registro;
                        ((DbCommand)(object)val).CommandType = CommandType.Text;
                        ((DbCommand)(object)val).ExecuteNonQuery();
                        ((Component)(object)val).Dispose();
                        val = null;
                        GC.Collect();
                    }
                    list2.Clear();
                    list2 = null;
                    GC.Collect();
                }
            }
            list.Clear();
            list = null;
            GC.Collect();
        }

        public void syncDowloadInventory(string date)
        {
            //IL_007c: Unknown result type (might be due to invalid IL or missing references)
            //IL_0082: Expected O, but got Unknown
            count = 0;
            List<inventario_fisico> list = new SyncCatalogos().GetInventarios(date).ToList();
            if (list.Count > 0)
            {
                count = list.Count;
                foreach (inventario_fisico item in list)
                {
                    string text = (new inventarioDAO().existInventario(new Guid(item.id_inventario_fisico)) ? "UPDATE inventario_fisico SET id_proveedor=@id_proveedor,user_name=@user_name,fecha_ini=@fecha_ini,fecha_fin=@fecha_fin,fecha_registro=@fecha_registro WHERE id_inventario_fisico=@id_inventario_fisico" : "INSERT INTO inventario_fisico(id_inventario_fisico,id_proveedor,user_name,fecha_ini,fecha_fin,fecha_registro) VALUES(@id_inventario_fisico,@id_proveedor,@user_name,@fecha_ini,@fecha_fin,@fecha_registro)");
                    SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
                    ((DbParameter)(object)val.Parameters.Add("@id_inventario_fisico", SqlDbType.UniqueIdentifier)).Value = item.id_inventario_fisico;
                    ((DbParameter)(object)val.Parameters.Add("@id_proveedor", SqlDbType.UniqueIdentifier)).Value = item.id_proveedor;
                    ((DbParameter)(object)val.Parameters.Add("@user_name", SqlDbType.NVarChar)).Value = item.user_name;
                    ((DbParameter)(object)val.Parameters.Add("@fecha_ini", SqlDbType.DateTime)).Value = item.fecha_ini;
                    ((DbParameter)(object)val.Parameters.Add("@fecha_fin", SqlDbType.DateTime)).Value = ((object)item.fecha_fin) ?? ((object)DBNull.Value);
                    ((DbParameter)(object)val.Parameters.Add("@fecha_registro", SqlDbType.DateTime)).Value = item.fecha_registro;
                    ((DbCommand)(object)val).CommandType = CommandType.Text;
                    ((DbCommand)(object)val).ExecuteNonQuery();
                    ((Component)(object)val).Dispose();
                    val = null;
                    GC.Collect();
                }
            }
            list.Clear();
            list = null;
            GC.Collect();
        }

        public void syncCompras()
        {
            //IL_0014: Unknown result type (might be due to invalid IL or missing references)
            //IL_001a: Expected O, but got Unknown
            //IL_0022: Unknown result type (might be due to invalid IL or missing references)
            //IL_0029: Expected O, but got Unknown
            //IL_0145: Unknown result type (might be due to invalid IL or missing references)
            //IL_014c: Expected O, but got Unknown
            //IL_0178: Unknown result type (might be due to invalid IL or missing references)
            //IL_017f: Expected O, but got Unknown
            //IL_02df: Unknown result type (might be due to invalid IL or missing references)
            //IL_02e6: Expected O, but got Unknown
            count = 0;
            string text = "SELECT id_compra,id_proveedor,CONVERT(nvarchar,fecha_compra,121) fecha_compra,id_pedido FROM compra WHERE upload=0 ORDER BY fecha_compra";
            SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
            DataTable dataTable = new DataTable();
            SqlCeDataAdapter val2 = new SqlCeDataAdapter(val);
            ((DbDataAdapter)(object)val2).Fill(dataTable);
            SyncCatalogos syncCatalogos = new SyncCatalogos();
            foreach (DataRow row in dataTable.Rows)
            {
                compra compra = new compra();
                compra.id_compra = row["id_compra"].ToString();
                if (row["id_proveedor"] == DBNull.Value)
                {
                    compra.id_proveedor = null;
                }
                else
                {
                    compra.id_proveedor = row["id_proveedor"].ToString();
                }
                compra.fecha_compra = row["fecha_compra"].ToString();
                if (row["id_pedido"] == DBNull.Value)
                {
                    compra.id_pedido = null;
                }
                else
                {
                    compra.id_pedido = row["id_pedido"].ToString();
                }
                syncCatalogos.CreatePurchase(compra, out var CreatePurchaseResult, out var CreatePurchaseResultSpecified);
                if (CreatePurchaseResult)
                {
                    DataTable dataTable2 = new DataTable();
                    text = "SELECT id_compra,cod_barras,num_articulo,cant_cja,cant_pza,precio_compra,no_captura,no_entrega FROM compra_articulo WHERE id_compra=@id_compra";
                    SqlCeCommand val3 = new SqlCeCommand(text, pos_colector.getConnection());
                    ((DbParameter)(object)val3.Parameters.Add("@id_compra", SqlDbType.UniqueIdentifier)).Value = new Guid(compra.id_compra);
                    val2 = new SqlCeDataAdapter(val3);
                    ((DbDataAdapter)(object)val2).Fill(dataTable2);
                    foreach (DataRow row2 in dataTable2.Rows)
                    {
                        compra_articulo compra_articulo = new compra_articulo();
                        compra_articulo.id_compra = row2["id_compra"].ToString();
                        compra_articulo.cod_barras = row2["cod_barras"].ToString();
                        compra_articulo.num_articulo = row2["num_articulo"].ToString();
                        compra_articulo.cant_cja = row2["cant_cja"].ToString();
                        compra_articulo.cant_pza = row2["cant_pza"].ToString();
                        compra_articulo.precio_compra = row2["precio_compra"].ToString();
                        compra_articulo.no_captura = "0";
                        compra_articulo.no_entrega = "0";
                        syncCatalogos.CreatePurchaseDetail(compra_articulo, out CreatePurchaseResult, out CreatePurchaseResultSpecified);
                        compra_articulo = null;
                        if (!CreatePurchaseResult)
                        {
                            throw new Exception("No se insertaron los Artículos de la Compra");
                        }
                    }
                    dataTable2.Clear();
                    dataTable2.Dispose();
                    dataTable2 = null;
                    if (CreatePurchaseResult)
                    {
                        SqlCeCommand val4 = new SqlCeCommand("UPDATE compra SET upload=1 WHERE id_compra=@id_compra", pos_colector.getConnection());
                        ((DbParameter)(object)val4.Parameters.Add("@id_compra", SqlDbType.UniqueIdentifier)).Value = new Guid(row["id_compra"].ToString());
                        ((DbCommand)(object)val4).ExecuteNonQuery();
                        ((Component)(object)val4).Dispose();
                    }
                    GC.Collect();
                    continue;
                }
                throw new Exception("No se insertó la Compra");
            }
            count = dataTable.Rows.Count;
            dataTable.Clear();
            dataTable.Dispose();
            dataTable = null;
            GC.Collect();
        }

        public void syncUploadInventario()
        {
            //IL_0014: Unknown result type (might be due to invalid IL or missing references)
            //IL_001a: Expected O, but got Unknown
            //IL_0022: Unknown result type (might be due to invalid IL or missing references)
            //IL_0029: Expected O, but got Unknown
            //IL_0139: Unknown result type (might be due to invalid IL or missing references)
            //IL_0140: Expected O, but got Unknown
            count = 0;
            string text = "SELECT id_captura,id_inventario_fisico,num_captura,cod_barras,CONVERT(nvarchar,fecha_captura,121) fecha_captura,cant_cja,cant_pza FROM inventario_captura WHERE upload=0 ORDER BY fecha_captura";
            SqlCeCommand val = new SqlCeCommand(text, pos_colector.getConnection());
            DataTable dataTable = new DataTable();
            SqlCeDataAdapter val2 = new SqlCeDataAdapter(val);
            ((DbDataAdapter)(object)val2).Fill(dataTable);
            SyncCatalogos syncCatalogos = new SyncCatalogos();
            foreach (DataRow row in dataTable.Rows)
            {
                inventario_captura inventario_captura = new inventario_captura();
                inventario_captura.id_captura = row["id_captura"].ToString();
                inventario_captura.id_inventario_fisico = row["id_inventario_fisico"].ToString();
                inventario_captura.num_captura = row["num_captura"].ToString();
                inventario_captura.cod_barras = row["cod_barras"].ToString();
                inventario_captura.fecha_captura = row["fecha_captura"].ToString();
                inventario_captura.cant_cja = row["cant_cja"].ToString();
                inventario_captura.cant_pza = row["cant_pza"].ToString();
                syncCatalogos.SetInventarios(inventario_captura, out var SetInventariosResult, out var _);
                if (SetInventariosResult)
                {
                    SqlCeCommand val3 = new SqlCeCommand("UPDATE inventario_captura SET upload=1 WHERE id_inventario_fisico=@id_inventario_fisico AND num_captura=@num_captura AND cod_barras=@cod_barras", pos_colector.getConnection());
                    ((DbParameter)(object)val3.Parameters.Add("@id_inventario_fisico", SqlDbType.UniqueIdentifier)).Value = new Guid(row["id_inventario_fisico"].ToString());
                    ((DbParameter)(object)val3.Parameters.Add("@num_captura", SqlDbType.BigInt)).Value = long.Parse(row["num_captura"].ToString());
                    ((DbParameter)(object)val3.Parameters.Add("@cod_barras", SqlDbType.NVarChar)).Value = row["cod_barras"].ToString();
                    ((DbCommand)(object)val3).ExecuteNonQuery();
                    ((Component)(object)val3).Dispose();
                    val3 = null;
                    GC.Collect();
                    continue;
                }
                throw new Exception("No se subieron correctamente los Inventarios");
            }
            count = dataTable.Rows.Count;
            dataTable.Clear();
            dataTable.Dispose();
            dataTable = null;
            GC.Collect();
        }

        private string getLastChangeDateTimeItems()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM articulo ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		private string getLastChangeDateTimeProvider()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM proveedor ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		private string getLastChangeDateTimeUnits()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM unidad_medida ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		private string getLastChangeDateTimeUsers()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM usuario ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		private string getLastChangeDateTimeUsuarioPermiso()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM usuario_permiso ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		public static string getLastChangeDateTimeOrders()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM orden ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : null;
		}

		private string getLastChangeDateTimeOrdersDetail()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM orden_articulo ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		public static string getLastChangeDateTimeInventarios()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM inventario_fisico ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : null;
		}

    }
}
