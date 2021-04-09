create database if not exists dbCVIERP;
use dbCVIERP;
#Base de datos Seguridad-----------------------------------------------------------------------------------
create table if not exists LOGIN(
	pk_id_login 						int(10) not null primary key auto_increment,
    usuario_login 						varchar(45),
    contraseña_login 					varchar(45),
    nombreCompleto_login				varchar(100),
    estado_login						int(2)
);
create table if not exists MODULO(
	pk_id_modulo 						int(10)not null auto_increment,
    nombre_modulo 						varchar(30)not null,
    descripcion_modulo 					varchar(50)not null,
    estado_modulo 						int(1)not null,
    primary key(pk_id_modulo),
    key(pk_id_modulo)
);
create table if not exists APLICACION(
	pk_id_aplicacion 					int(10)not null auto_increment,
    fk_id_modulo 						int(10)not null,
    nombre_aplicacion 					varchar(40)not null,
    descripcion_aplicacion 				varchar(45)not null,
    estado_aplicacion 					int(1)not null,
    primary key(pk_id_aplicacion),
    key(pk_id_aplicacion)
);
alter table APLICACION add constraint fk_aplicacion_modulo foreign key(fk_id_modulo) references MODULO(pk_id_modulo);

create table if not exists PERFIL(
	pk_id_perfil						int(10) not null primary key auto_increment,
    nombre_perfil						varchar(50),
    descripcion_perfil					varchar(100),
    estado_perfil						int(2)
);
create table if not exists PERMISO(
	pk_id_permiso						int(10) not null primary key auto_increment,
    insertar_permiso					boolean,
    modificar_permiso					boolean,
    eliminar_permiso					boolean,
    consultar_permiso					boolean,
    imprimir_permiso					boolean
);
create table if not exists APLICACION_PERFIL(
	pk_id_aplicacion_perfil				int(10) not null primary key auto_increment,
    fk_idaplicacion_aplicacion_perfil	int(10),
    fk_idperfil_aplicacion_perfil		int(10),
    fk_idpermiso_aplicacion_perfil		int(10)
);
alter table APLICACION_PERFIL add constraint fk_aplicacionperfil_aplicacion foreign key (fk_idaplicacion_aplicacion_perfil) references APLICACION(pk_id_aplicacion)on delete restrict on update cascade;
alter table APLICACION_PERFIL add constraint fk_aplicacionperfil_perfil foreign key (fk_idperfil_aplicacion_perfil) references PERFIL(pk_id_perfil)on delete restrict on update cascade;
alter table APLICACION_PERFIL add constraint fk_aplicacionperfil_permiso foreign key (fk_idpermiso_aplicacion_perfil) references PERMISO (pk_id_permiso)on delete restrict on update cascade;

create table if not exists PERFIL_USUARIO(
	pk_id_perfil_usuario				int(10) not null primary key auto_increment,
    fk_idusuario_perfil_usuario			int(10),
    fk_idperfil_perfil_usuario			int(10)
);
alter table PERFIL_USUARIO add constraint fk_perfil_usuario_login foreign key(fk_idusuario_perfil_usuario) references LOGIN(pk_id_login) on delete restrict on update cascade;
alter table PERFIL_USUARIO add constraint fk_perfil_usuario_perfil foreign key (fk_idperfil_perfil_usuario) references PERFIL(pk_id_perfil) on delete restrict on update cascade;

create table if not exists APLICACION_USUARIO(
	pk_id_aplicacion_usuario			int(10) not null primary key auto_increment,
    fk_idlogin_aplicacion_usuario		int(10),
    fk_idaplicacion_aplicacion_usuario	int(10),
    fk_idpermiso_aplicacion_usuario		int(10)
);
alter table APLICACION_USUARIO add constraint fk_aplicacionusuario_login foreign key(fk_idlogin_aplicacion_usuario) references LOGIN(pk_id_login) on delete restrict on update cascade;
alter table APLICACION_USUARIO add constraint fk_aplicacionusuario_aplicacion foreign key (fk_idaplicacion_aplicacion_usuario) references APLICACION(pk_id_aplicacion) on delete restrict on update cascade;
alter table APLICACION_USUARIO add constraint fk_aplicacionusuario_permiso foreign key(fk_idpermiso_aplicacion_usuario) references PERMISO (pk_id_permiso)on delete restrict on update cascade;

create table if not exists BITACORA(
	pk_id_bitacora						int(10) not null primary key auto_increment, #pk
    fk_idusuario_bitacora				int(10),
    fk_idaplicacion_bitacora			int(10),
    fechahora_bitacora					varchar(50),
    direccionhost_bitacora				varchar(20),
    nombrehost_bitacora					varchar(20),
    accion_bitacora						varchar(250)
);
CREATE TABLE IF NOT EXISTS DETALLE_BITACORA (
    pk_id_detalle_bitacora 				INT(10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
    fk_idbitacora_detalle_bitacora 		INT(10),
    querryantigua_detalle_bitacora 		VARCHAR(50),
    querrynueva_detalle_bitacora 		VARCHAR(50)
);
alter table BITACORA add constraint fk_login_bitacora foreign key (fk_idusuario_bitacora) references LOGIN (pk_id_login) on delete restrict on update cascade;
alter table BITACORA add constraint fk_aplicacion_bitacora foreign key (fk_idaplicacion_bitacora) references APLICACION(pk_id_aplicacion) on delete restrict on update cascade;
alter table DETALLE_BITACORA add constraint fk_bitacora_detallebitacora foreign key(fk_idbitacora_detalle_bitacora) references BITACORA(pk_id_bitacora) on delete restrict on update cascade;

#REPORTEADOR---------------------------------------------------------------------------------------
create table if not exists REPORTE(
	pk_id_reporte 						int(10)not null auto_increment,
    nombre_reporte 						varchar(40)not null,
    ruta_reporte 						varchar(100)not null,
    estado_reporte 						int(1)not null,
    primary key(pk_id_reporte),
    key(pk_id_reporte)
);
create table if not exists REPORTE_MODULO(
	fk_id_reporte 						int(10)not null ,
    fk_id_modulo 						int(10)not null,
    estado_reporte_modulo 				int(1)not null,
    primary key(fk_id_reporte,fk_id_modulo),
    key(fk_id_reporte,fk_id_modulo)
);
alter table REPORTE_MODULO add constraint fk_reporte_de_modulo foreign key(fk_id_reporte) references REPORTE(pk_id_reporte);
alter table REPORTE_MODULO add constraint fk_reporte_de_modulo_reportes foreign key(fk_id_modulo) references MODULO(pk_id_modulo);

create table if not exists REPORTE_APLICATIVO(
	fk_id_reporte 						int(10)not null,
    fk_id_aplicacion 					int(10)not null,
    fk_id_modulo 						int(10)not null,
    estado_reporte_aplicativo 			int(1)not null,
    primary key(fk_id_reporte,fk_id_aplicacion,fk_id_modulo),
    key(fk_id_reporte,fk_id_aplicacion,fk_id_modulo)
);
alter table REPORTE_APLICATIVO add constraint fk_reporte_aplicativo_reporte foreign key(fk_id_reporte) references REPORTE(pk_id_reporte);
alter table REPORTE_APLICATIVO add constraint fk_reporte_aplicativo_modulo foreign key(fk_id_modulo) references MODULO(pk_id_modulo);
alter table REPORTE_APLICATIVO add constraint fk_report_aplicativo foreign key(fk_id_aplicacion) references APLICACION(pk_id_aplicacion);

#COMPRAS---------------------------------------------------------------------------------------------------
create table if not exists DEPARTAMENTO(
	pkIdDepar					int(10)not null primary key auto_increment,
    nombreDepar 				varchar(30)not null,
    descripcionDepar 			varchar(45)not null,
    estadoDepar					int(1)not null
);
create table if not exists MUNICIPIO(
	pkIdMuni 					int(10)not null primary key auto_increment,
    fkIdDepar 					int(10)not null,
    nombreMuni 					varchar(30)not null,
    descripcionMuni 			varchar(45)not null,
    estadoMuni 					int(1)not null
);
alter table MUNICIPIO add constraint fk_municipio_departamento foreign key(fkIdDepar) references DEPARTAMENTO(pkIdDepar);

create table if not exists BODEGA(
	pkIdBodega 					int(10)not null primary key auto_increment,
    fkIdMuni 					int(10)not null,
    descripcionBodega 			varchar(250)not null,
    direccionBodega 			varchar(45)not null,
    telefonoBodega 				int(8)not null,
    estadoBodega 				int(1)not null
);
alter table BODEGA add constraint fk_bodega_municipio foreign key(fkIdMuni) references MUNICIPIO(pkIdMuni);

create table if not exists LINEAPRODUCTO(
	pkIdLineaPro 				int(10)not null primary key auto_increment,
    nombreLineaPro 				varchar(25)not null,
    descripcionLineaPro 		varchar(50) not null,
    estadoLineaPro 				int(1) not null
);
create table if not exists CATEGORIAPRODUCTO(
	pkIdCatePro 				int(10) not null primary key auto_increment,
    nombreCatePro 				varchar(35)not null,
    descripcionCatePro 			varchar(60)not null,
    estadoCatePro 				int(1)not null
);
create table if not exists PRODUCTO(
	pkIdPro 					int(10)not null primary key auto_increment,
    fkIdLineaPro 				int(10)not null,
    fkIdCatePro 				int(10)not null,
    nombrePro 					varchar(50)not null,
    precioPro 					double(12,2)not null,
    descripcionPro 				varchar(45)not null,
    estadoPro 					int(1)not null
);
alter table PRODUCTO add constraint fk_producto_lineaProducto foreign key(fkIdLineaPro) references LINEAPRODUCTO(pkIdLineaPro);
alter table PRODUCTO add constraint fk_producto_categoriaProducto foreign key(fkIdCatePro) references CATEGORIAPRODUCTO(pkIdCatePro);

create table if not exists EXISTENCIA(
	pkIdExis 					int(10)not null primary key auto_increment,
    fkIdBodega 					int(10)not null,
    fkIdPro 					int(10)not null,
    cantidad_existencia 		int(10)not null,
    estado_existencia 			int(1)not null
);
alter table EXISTENCIA add constraint fk_inventario_producto foreign key(fkIdBodega) references PRODUCTO(pkIdPro);
alter table EXISTENCIA add constraint fk_inventario_bodega foreign key(fkIdPro) references BODEGA(pkIdBodega);

create table if not exists PAIS(
	pkIdPais 					int(10)not null primary key auto_increment,
    nombrePais 					varchar(40)not null,
    capitalPais 				varchar(40)not null,
    estadoPais 					int(1)not null
);
create table if not exists PROVEEDOR(
	pkIdProv 					int(10)not null primary key auto_increment,
    fkIdPais 					int(10)not null,
    direccionProv				varchar(50)not null,
    nitProv 					varchar(20)not null,
    telProv						int(8)not null,
    correoProv					varchar(30)not null,
    estadoProv 					int(1)not null
);
alter table PROVEEDOR add constraint fk_proveedor_pais foreign key(fkIdPais) references PAIS(pkIdPais);

create table if not exists CARGOBODEGA(
	pkIdCargo					int(10) not null primary key auto_increment,
    nombreCargo					varchar(50) not null,
    descripcionCargo			varchar(250) not null,
    estadoCargo					int(1) not null
);
create table if not exists PERSONALBODEGA(
	pkIdpersonal				int(10) not null primary key auto_increment,
    fkIdEmpleado				int(10) not null,
    fkIdBodega					int(10) not null,
    fkIdCargo					int(10) not null,
    estadoPerBodega				int(1)
); 
#alter table PERSONALBODEGA add constraint fk_personal_empleado foreign key(fkIdEmpleado) references Empleado(pkIdEmpleado)
alter table PERSONALBODEGA add constraint fk_personal_bodega foreign key(fkIdBodega) references BODEGA(pkIdBodega);
alter table PERSONALBODEGA add constraint fk_personal_cargo foreign key(fkIdCargo) references CARGOBODEGA(pkIdCargo);

create table if not exists COMPRAENCABEZADO(
	pkNoDocumentoEnca 			int(10)not null primary key auto_increment,
    fkIdProv 					int(10)not null,
    fechaCompra 				date not null,
    totalCompra 				double(12,2) not null,
    estadoCompra 				int(1)not null
);
alter table COMPRAENCABEZADO add constraint fk_compra_proveedor foreign key(fkIdProv) references PROVEEDOR(pkIdProv);

create table COMPRADETALLE(
	pkIdCompraDetalle			int(10)not null primary key auto_increment,
	fkNoDocumentoEnca 			int(10)not null,
	fkIdPro 					int(10)not null,
    cantidadCompraDe 			int(10)not null,
    precioCompraDe 				double(8,2)not null,
    fkIdBodega 					int(10)not null
);
alter table COMPRADETALLE add constraint fk_compra_detalle_encabezado foreign key(fkNoDocumentoEnca) references COMPRAENCABEZADO(pkNoDocumentoEnca);
alter table COMPRADETALLE add constraint fk_compra_producto foreign key(fkIdPro) references PRODUCTO(pkIdPro);
alter table COMPRADETALLE add constraint fk_compra_bodega foreign key(fkIdBodega) references BODEGA(pkIdBodega);

create table if not exists CLIENTE(
	pkIdCliente 				int(5)not null primary key auto_increment,
    nombreCliente 				varchar(60),
    direccionCliente 			varchar(60),
    nitCliente 					varchar(20),
    telCliente 					varchar(50),
    estadoCliente 				int(1)
);
create table if not exists VENTAENCABEZADO(
	pkDocumentoVentaEnca 		int(10)not null primary key auto_increment,
    fkIdCliente 				int(10),
	fkIdVendedor				int(10),
    fechaVenta 					date,
    totalVenta 					float(10,2),
    estadoVentaEnca 			int(1)
);
alter table VENTAENCABEZADO add constraint fk_venta_cliente foreign key(fkIdCliente) references CLIENTE(pkIdCliente);

create table if not exists VENTADETALLE(
	pkIdVentaDetalle 			int(10)not null primary key auto_increment,
    fkDocumentoVentaEnca		int(10),
	fkIdPro						int(10),
    cantidadVenta 				int(10),
    costoVenta 					float(10,2),
    precioVenta 				float(10,2),
    fkIdBodega 					int(10)
);
alter table VENTADETALLE add constraint fk_venta_encabezado foreign key(fkDocumentoVentaEnca) references VENTAENCABEZADO(pkDocumentoVentaEnca);
alter table VENTADETALLE add constraint fk_venta_producto foreign key(fkIdPro) references PRODUCTO(pkIdPro);
alter table VENTADETALLE add constraint fk_venta_bodega foreign key(fkIdBodega) references BODEGA(pkIdBodega);

create table if not exists COTIZAENCABEZADO(
	pkDocumentoCotizaEnca 		int(10)not null primary key auto_increment,
    fkIdCliente 				int(10),
	fkIdVendedor				int(10),
    fechaCotizacion				date,
    totalCotizacion				float(10,2),
    estadoCotizacion 			int(1)
);
alter table COTIZAENCABEZADO add constraint fk_cotiza_cliente foreign key(fkIdCliente) references CLIENTE(pkIdCliente);

create table if not exists COTIZADETALLE(
	pkIdCotizaDetalle 			int(10)not null primary key auto_increment,
    fkDocumentoCotizaEnca		int(10),
	fkIdPro						int(10),
    cantidadCotizar				int(10),
    precioCotiza 				float(10,2)
);
alter table COTIZADETALLE add constraint fk_cotiza_encabezado foreign key(fkDocumentoCotizaEnca) references COTIZAENCABEZADO(pkDocumentoCotizaEnca);
alter table COTIZADETALLE add constraint fk_cotiza_producto foreign key(fkIdPro) references PRODUCTO(pkIdPro);
