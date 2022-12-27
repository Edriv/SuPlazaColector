using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PosColector
{
    public class POSDataCacheSyncAgent : SyncAgent
    {

        public class articuloSyncTable : SyncTable
        {
            public articuloSyncTable()
            {
                InitializeTableOptions();
            }

            [DebuggerNonUserCode]
            private void InitializeTableOptions()
            {
                base.TableName = "articulo";
                base.CreationOption = TableCreationOption.DropExistingOrCreateNewTable;
            }
        }

        public class proveedorSyncTable : SyncTable
        {
            public proveedorSyncTable()
            {
                InitializeTableOptions();
            }

            [DebuggerNonUserCode]
            private void InitializeTableOptions()
            {
                base.TableName = "proveedor";
                base.CreationOption = TableCreationOption.DropExistingOrCreateNewTable;
            }
        }

        public class unidad_medidaSyncTable : SyncTable
        {
            public unidad_medidaSyncTable()
            {
                InitializeTableOptions();
            }

            [DebuggerNonUserCode]
            private void InitializeTableOptions()
            {
                base.TableName = "unidad_medida";
                base.CreationOption = TableCreationOption.DropExistingOrCreateNewTable;
            }
        }

        public class usuarioSyncTable : SyncTable
        {
            public usuarioSyncTable()
            {
                InitializeTableOptions();
            }

            [DebuggerNonUserCode]
            private void InitializeTableOptions()
            {
                base.TableName = "usuario";
                base.CreationOption = TableCreationOption.DropExistingOrCreateNewTable;
            }
        }

        public class usuario_permisoSyncTable : SyncTable
        {
            public usuario_permisoSyncTable()
            {
                InitializeTableOptions();
            }

            [DebuggerNonUserCode]
            private void InitializeTableOptions()
            {
                base.TableName = "usuario_permiso";
                base.CreationOption = TableCreationOption.DropExistingOrCreateNewTable;
            }
        }

        private articuloSyncTable _articuloSyncTable;

        private proveedorSyncTable _proveedorSyncTable;

        private unidad_medidaSyncTable _unidad_medidaSyncTable;

        private usuarioSyncTable _usuarioSyncTable;

        private usuario_permisoSyncTable _usuario_permisoSyncTable;

        [DebuggerNonUserCode]
        public articuloSyncTable articulo
        {
            get
            {
                return _articuloSyncTable;
            }
            set
            {
                base.Configuration.SyncTables.Remove(_articuloSyncTable);
                _articuloSyncTable = value;
                base.Configuration.SyncTables.Add(_articuloSyncTable);
            }
        }

        [DebuggerNonUserCode]
        public proveedorSyncTable proveedor
        {
            get
            {
                return _proveedorSyncTable;
            }
            set
            {
                base.Configuration.SyncTables.Remove(_proveedorSyncTable);
                _proveedorSyncTable = value;
                base.Configuration.SyncTables.Add(_proveedorSyncTable);
            }
        }

        [DebuggerNonUserCode]
        public unidad_medidaSyncTable unidad_medida
        {
            get
            {
                return _unidad_medidaSyncTable;
            }
            set
            {
                base.Configuration.SyncTables.Remove(_unidad_medidaSyncTable);
                _unidad_medidaSyncTable = value;
                base.Configuration.SyncTables.Add(_unidad_medidaSyncTable);
            }
        }

        [DebuggerNonUserCode]
        public usuarioSyncTable usuario
        {
            get
            {
                return _usuarioSyncTable;
            }
            set
            {
                base.Configuration.SyncTables.Remove(_usuarioSyncTable);
                _usuarioSyncTable = value;
                base.Configuration.SyncTables.Add(_usuarioSyncTable);
            }
        }

        [DebuggerNonUserCode]
        public usuario_permisoSyncTable usuario_permiso
        {
            get
            {
                return _usuario_permisoSyncTable;
            }
            set
            {
                base.Configuration.SyncTables.Remove(_usuario_permisoSyncTable);
                _usuario_permisoSyncTable = value;
                base.Configuration.SyncTables.Add(_usuario_permisoSyncTable);
            }
        }

        public POSDataCacheSyncAgent()
        {
            InitializeSyncProviders();
            InitializeSyncTables();
        }

        public POSDataCacheSyncAgent(object remoteSyncProviderProxy)
        {
            InitializeSyncProviders();
            InitializeSyncTables();
            base.RemoteProvider = new ServerSyncProviderProxy(remoteSyncProviderProxy);
        }

        [DebuggerNonUserCode]
        private void InitializeSyncProviders()
        {
            base.LocalProvider = (SyncProvider)(object)new POSDataCacheClientSyncProvider();
        }

        [DebuggerNonUserCode]
        private void InitializeSyncTables()
        {
            _articuloSyncTable = new articuloSyncTable();
            _articuloSyncTable.SyncGroup = new SyncGroup("articuloSyncTableSyncGroup");
            base.Configuration.SyncTables.Add(_articuloSyncTable);
            _proveedorSyncTable = new proveedorSyncTable();
            _proveedorSyncTable.SyncGroup = new SyncGroup("proveedorSyncTableSyncGroup");
            base.Configuration.SyncTables.Add(_proveedorSyncTable);
            _unidad_medidaSyncTable = new unidad_medidaSyncTable();
            _unidad_medidaSyncTable.SyncGroup = new SyncGroup("unidad_medidaSyncTableSyncGroup");
            base.Configuration.SyncTables.Add(_unidad_medidaSyncTable);
            _usuarioSyncTable = new usuarioSyncTable();
            _usuarioSyncTable.SyncGroup = new SyncGroup("usuarioSyncTableSyncGroup");
            base.Configuration.SyncTables.Add(_usuarioSyncTable);
            _usuario_permisoSyncTable = new usuario_permisoSyncTable();
            _usuario_permisoSyncTable.SyncGroup = new SyncGroup("usuario_permisoSyncTableSyncGroup");
            base.Configuration.SyncTables.Add(_usuario_permisoSyncTable);
        }

    }
}
