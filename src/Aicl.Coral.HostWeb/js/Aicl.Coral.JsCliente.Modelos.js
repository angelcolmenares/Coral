(function() {
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Actividad
	var $Aicl_Coral_Modelos_Actividad = function() {
	};
	$Aicl_Coral_Modelos_Actividad.createInstance = function() {
		return $Aicl_Coral_Modelos_Actividad.$ctor();
	};
	$Aicl_Coral_Modelos_Actividad.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nombre = null;
		$this.IdTipoActividad = 0;
		$this.Codigo = null;
		$this.BloquearEnPeriodoCerrado = false;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.ActividadClase
	var $Aicl_Coral_Modelos_ActividadClase = function() {
	};
	$Aicl_Coral_Modelos_ActividadClase.createInstance = function() {
		return $Aicl_Coral_Modelos_ActividadClase.$ctor();
	};
	$Aicl_Coral_Modelos_ActividadClase.$ctor = function() {
		var $this = {};
		$this.Id = null;
		$this.IdActividad = 0;
		$this.IdClase = 0;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Administradora
	var $Aicl_Coral_Modelos_Administradora = function() {
	};
	$Aicl_Coral_Modelos_Administradora.createInstance = function() {
		return $Aicl_Coral_Modelos_Administradora.$ctor();
	};
	$Aicl_Coral_Modelos_Administradora.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nit = null;
		$this.Dv = null;
		$this.Nombre = null;
		$this.IdServicio = 0;
		$this.Codigo = null;
		$this.Direccion = null;
		$this.Telefono = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.AdminLogin
	var $Aicl_Coral_Modelos_AdminLogin = function() {
	};
	$Aicl_Coral_Modelos_AdminLogin.createInstance = function() {
		return $Aicl_Coral_Modelos_AdminLogin.$ctor();
	};
	$Aicl_Coral_Modelos_AdminLogin.$ctor = function() {
		var $this = {};
		$this.Nombre = null;
		$this.Clave = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.AdminLoginResponse
	var $Aicl_Coral_Modelos_AdminLoginResponse = function() {
	};
	$Aicl_Coral_Modelos_AdminLoginResponse.createInstance = function() {
		return $Aicl_Coral_Modelos_AdminLoginResponse.$ctor();
	};
	$Aicl_Coral_Modelos_AdminLoginResponse.$ctor = function() {
		var $this = {};
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.AdminLogout
	var $Aicl_Coral_Modelos_AdminLogout = function() {
	};
	$Aicl_Coral_Modelos_AdminLogout.createInstance = function() {
		return $Aicl_Coral_Modelos_AdminLogout.$ctor();
	};
	$Aicl_Coral_Modelos_AdminLogout.$ctor = function() {
		var $this = {};
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Candidato
	var $Aicl_Coral_Modelos_Candidato = function() {
	};
	$Aicl_Coral_Modelos_Candidato.createInstance = function() {
		return $Aicl_Coral_Modelos_Candidato.$ctor();
	};
	$Aicl_Coral_Modelos_Candidato.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Documento = null;
		$this.IdTipoDocumento = 0;
		$this.IdLugarExpedicion = 0;
		$this.Nombres = null;
		$this.PrimerApellido = null;
		$this.SegundoApellido = null;
		$this.IdEstadoCivil = 0;
		$this.FechaNacimiento = new Date(0);
		$this.IdSanguineo = 0;
		$this.Sexo = null;
		$this.IdCiudadNacimiento = 0;
		$this.DireccionResidencia = null;
		$this.Telefono = null;
		$this.Celular = null;
		$this.Email = null;
		$this.IdEps = 0;
		$this.IdAfp = 0;
		$this.IdCesantias = 0;
		$this.IdProfesion = 0;
		$this.IdNivelAcademico = 0;
		$this.LibretaMilitar = null;
		$this.FechaExpedicionDas = null;
		$this.IdPuesto = null;
		$this.TarjetaProfesional = null;
		$this.IdUsuarioAprueba = null;
		$this.IdUsuarioRegistra = 0;
		$this.FechaRegistro = new Date(0);
		$this.PasadoJudicial = null;
		$this.FechaAprobacion = null;
		$this.IdEstado = 0;
		$this.IdBarrioResidencia = null;
		$this.Observacion = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Centro
	var $Aicl_Coral_Modelos_Centro = function() {
	};
	$Aicl_Coral_Modelos_Centro.createInstance = function() {
		return $Aicl_Coral_Modelos_Centro.$ctor();
	};
	$Aicl_Coral_Modelos_Centro.$ctor = function() {
		var $this = {};
		$this.IdEmpresa = 0;
		$this.Id = 0;
		$this.Codigo = null;
		$this.Nombre = null;
		$this.FechaInicio = new Date(0);
		$this.FechaTerminacion = null;
		$this.NumeroContrato = null;
		$this.IdTercero = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.CentroSucursal
	var $Aicl_Coral_Modelos_CentroSucursal = function() {
	};
	$Aicl_Coral_Modelos_CentroSucursal.createInstance = function() {
		return $Aicl_Coral_Modelos_CentroSucursal.$ctor();
	};
	$Aicl_Coral_Modelos_CentroSucursal.$ctor = function() {
		var $this = {};
		$this.Id = null;
		$this.IdEmpresa = 0;
		$this.IdSucursal = 0;
		$this.IdCentro = 0;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.ClaseCliente
	var $Aicl_Coral_Modelos_ClaseCliente = function() {
	};
	$Aicl_Coral_Modelos_ClaseCliente.createInstance = function() {
		return $Aicl_Coral_Modelos_ClaseCliente.$ctor();
	};
	$Aicl_Coral_Modelos_ClaseCliente.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nombre = null;
		$this.Titulo = null;
		$this.Icono = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Departamento
	var $Aicl_Coral_Modelos_Departamento = function() {
	};
	$Aicl_Coral_Modelos_Departamento.createInstance = function() {
		return $Aicl_Coral_Modelos_Departamento.$ctor();
	};
	$Aicl_Coral_Modelos_Departamento.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Codigo = null;
		$this.Nombre = null;
		$this.IdPais = 0;
		$this.CodigoAlternativo = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Empresa
	var $Aicl_Coral_Modelos_Empresa = function() {
	};
	$Aicl_Coral_Modelos_Empresa.createInstance = function() {
		return $Aicl_Coral_Modelos_Empresa.$ctor();
	};
	$Aicl_Coral_Modelos_Empresa.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Codigo = null;
		$this.Nombre = null;
		$this.Direccion = null;
		$this.Nit = null;
		$this.Dv = null;
		$this.Telefono = null;
		$this.Email = null;
		$this.RepresentanteLegal = null;
		$this.IdMunicipio = 0;
		$this.IdAdministradora = 0;
		$this.FormaPresentacionSS = null;
		$this.IdTipoDocumento = 0;
		$this.TipoAportanteSS = 0;
		$this.UsarXmpp = false;
		$this.ConexionContabilidad = null;
		$this.IdRepresentanteLegal = null;
		$this.CargoFirma = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.EmpresaCcf
	var $Aicl_Coral_Modelos_EmpresaCcf = function() {
	};
	$Aicl_Coral_Modelos_EmpresaCcf.createInstance = function() {
		return $Aicl_Coral_Modelos_EmpresaCcf.$ctor();
	};
	$Aicl_Coral_Modelos_EmpresaCcf.$ctor = function() {
		var $this = {};
		$this.Id = null;
		$this.IdEmpresa = 0;
		$this.IdDepartamento = 0;
		$this.IdAdministradora = 0;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.EmpresaCreate
	var $Aicl_Coral_Modelos_EmpresaCreate = function() {
	};
	$Aicl_Coral_Modelos_EmpresaCreate.createInstance = function() {
		return $Aicl_Coral_Modelos_EmpresaCreate.$ctor();
	};
	$Aicl_Coral_Modelos_EmpresaCreate.$ctor = function() {
		var $this = {};
		$this.Codigo = null;
		$this.Nombre = null;
		$this.Direccion = null;
		$this.Nit = null;
		$this.Dv = null;
		$this.Telefono = null;
		$this.Email = null;
		$this.RepresentanteLegal = null;
		$this.IdMunicipio = 0;
		$this.IdAdministradora = 0;
		$this.FormaPresentacionSS = null;
		$this.IdTipoDocumento = 0;
		$this.TipoAportanteSS = 0;
		$this.UsarXmpp = false;
		$this.ConexionContabilidad = null;
		$this.IdRepresentanteLegal = null;
		$this.CargoFirma = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.EmpresaDestroy
	var $Aicl_Coral_Modelos_EmpresaDestroy = function() {
	};
	$Aicl_Coral_Modelos_EmpresaDestroy.createInstance = function() {
		return $Aicl_Coral_Modelos_EmpresaDestroy.$ctor();
	};
	$Aicl_Coral_Modelos_EmpresaDestroy.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.EmpresaRead
	var $Aicl_Coral_Modelos_EmpresaRead = function() {
	};
	$Aicl_Coral_Modelos_EmpresaRead.createInstance = function() {
		return $Aicl_Coral_Modelos_EmpresaRead.$ctor();
	};
	$Aicl_Coral_Modelos_EmpresaRead.$ctor = function() {
		var $this = {};
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.EmpresaUpdate
	var $Aicl_Coral_Modelos_EmpresaUpdate = function() {
	};
	$Aicl_Coral_Modelos_EmpresaUpdate.createInstance = function() {
		return $Aicl_Coral_Modelos_EmpresaUpdate.$ctor();
	};
	$Aicl_Coral_Modelos_EmpresaUpdate.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Codigo = null;
		$this.Nombre = null;
		$this.Direccion = null;
		$this.Nit = null;
		$this.Dv = null;
		$this.Telefono = null;
		$this.Email = null;
		$this.RepresentanteLegal = null;
		$this.IdMunicipio = 0;
		$this.IdAdministradora = 0;
		$this.FormaPresentacionSS = null;
		$this.IdTipoDocumento = 0;
		$this.TipoAportanteSS = 0;
		$this.UsarXmpp = false;
		$this.ConexionContabilidad = null;
		$this.IdRepresentanteLegal = null;
		$this.CargoFirma = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Estado
	var $Aicl_Coral_Modelos_Estado = function() {
	};
	$Aicl_Coral_Modelos_Estado.createInstance = function() {
		return $Aicl_Coral_Modelos_Estado.$ctor();
	};
	$Aicl_Coral_Modelos_Estado.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Descripcion = null;
		$this.Comentario = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.EstadoCivil
	var $Aicl_Coral_Modelos_EstadoCivil = function() {
	};
	$Aicl_Coral_Modelos_EstadoCivil.createInstance = function() {
		return $Aicl_Coral_Modelos_EstadoCivil.$ctor();
	};
	$Aicl_Coral_Modelos_EstadoCivil.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nombre = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Grupo
	var $Aicl_Coral_Modelos_Grupo = function() {
	};
	$Aicl_Coral_Modelos_Grupo.createInstance = function() {
		return $Aicl_Coral_Modelos_Grupo.$ctor();
	};
	$Aicl_Coral_Modelos_Grupo.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nombre = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.GrupoActividad
	var $Aicl_Coral_Modelos_GrupoActividad = function() {
	};
	$Aicl_Coral_Modelos_GrupoActividad.createInstance = function() {
		return $Aicl_Coral_Modelos_GrupoActividad.$ctor();
	};
	$Aicl_Coral_Modelos_GrupoActividad.$ctor = function() {
		var $this = {};
		$this.Id = null;
		$this.IdGrupo = 0;
		$this.IdActividad = 0;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.GrupoUsuario
	var $Aicl_Coral_Modelos_GrupoUsuario = function() {
	};
	$Aicl_Coral_Modelos_GrupoUsuario.createInstance = function() {
		return $Aicl_Coral_Modelos_GrupoUsuario.$ctor();
	};
	$Aicl_Coral_Modelos_GrupoUsuario.$ctor = function() {
		var $this = {};
		$this.Id = null;
		$this.IdGrupo = 0;
		$this.IdUsuario = 0;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Item
	var $Aicl_Coral_Modelos_Item = function() {
	};
	$Aicl_Coral_Modelos_Item.createInstance = function() {
		return $Aicl_Coral_Modelos_Item.$ctor();
	};
	$Aicl_Coral_Modelos_Item.$ctor = function() {
		var $this = {};
		$this.Titulo = null;
		$this.Modulo = null;
		$this.Icono = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Menu
	var $Aicl_Coral_Modelos_Menu = function() {
	};
	$Aicl_Coral_Modelos_Menu.createInstance = function() {
		return $Aicl_Coral_Modelos_Menu.$ctor();
	};
	$Aicl_Coral_Modelos_Menu.$ctor = function() {
		var $this = {};
		$this.Titulo = null;
		$this.Items = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Municipio
	var $Aicl_Coral_Modelos_Municipio = function() {
	};
	$Aicl_Coral_Modelos_Municipio.createInstance = function() {
		return $Aicl_Coral_Modelos_Municipio.$ctor();
	};
	$Aicl_Coral_Modelos_Municipio.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Codigo = null;
		$this.Nombre = null;
		$this.IDDepartamento = 0;
		$this.CodigoAlternativo = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.NivelAcademico
	var $Aicl_Coral_Modelos_NivelAcademico = function() {
	};
	$Aicl_Coral_Modelos_NivelAcademico.createInstance = function() {
		return $Aicl_Coral_Modelos_NivelAcademico.$ctor();
	};
	$Aicl_Coral_Modelos_NivelAcademico.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nombre = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Pais
	var $Aicl_Coral_Modelos_Pais = function() {
	};
	$Aicl_Coral_Modelos_Pais.createInstance = function() {
		return $Aicl_Coral_Modelos_Pais.$ctor();
	};
	$Aicl_Coral_Modelos_Pais.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nombre = null;
		$this.Codigo = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Profesion
	var $Aicl_Coral_Modelos_Profesion = function() {
	};
	$Aicl_Coral_Modelos_Profesion.createInstance = function() {
		return $Aicl_Coral_Modelos_Profesion.$ctor();
	};
	$Aicl_Coral_Modelos_Profesion.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nombre = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Sanguineo
	var $Aicl_Coral_Modelos_Sanguineo = function() {
	};
	$Aicl_Coral_Modelos_Sanguineo.createInstance = function() {
		return $Aicl_Coral_Modelos_Sanguineo.$ctor();
	};
	$Aicl_Coral_Modelos_Sanguineo.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nombre = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.ServicioAdministradora
	var $Aicl_Coral_Modelos_ServicioAdministradora = function() {
	};
	$Aicl_Coral_Modelos_ServicioAdministradora.createInstance = function() {
		return $Aicl_Coral_Modelos_ServicioAdministradora.$ctor();
	};
	$Aicl_Coral_Modelos_ServicioAdministradora.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.TipoServicio = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.Sucursal
	var $Aicl_Coral_Modelos_Sucursal = function() {
	};
	$Aicl_Coral_Modelos_Sucursal.createInstance = function() {
		return $Aicl_Coral_Modelos_Sucursal.$ctor();
	};
	$Aicl_Coral_Modelos_Sucursal.$ctor = function() {
		var $this = {};
		$this.IdEmpresa = 0;
		$this.Id = 0;
		$this.Codigo = null;
		$this.IdMunicipio = 0;
		$this.Direccion = null;
		$this.Telefono = null;
		$this.Nombre = null;
		$this.Gerente = null;
		$this.IdRepresentante = null;
		$this.CargoFirma = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.SucursalAutorizada
	var $Aicl_Coral_Modelos_SucursalAutorizada = function() {
	};
	$Aicl_Coral_Modelos_SucursalAutorizada.createInstance = function() {
		return $Aicl_Coral_Modelos_SucursalAutorizada.$ctor();
	};
	$Aicl_Coral_Modelos_SucursalAutorizada.$ctor = function() {
		var $this = {};
		$this.Sucursal = null;
		$this.IdCentros = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.TipoActividad
	var $Aicl_Coral_Modelos_TipoActividad = function() {
	};
	$Aicl_Coral_Modelos_TipoActividad.createInstance = function() {
		return $Aicl_Coral_Modelos_TipoActividad.$ctor();
	};
	$Aicl_Coral_Modelos_TipoActividad.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Nombre = null;
		$this.Codigo = null;
		$this.NivelChequeo = 0;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.TipoDocumento
	var $Aicl_Coral_Modelos_TipoDocumento = function() {
	};
	$Aicl_Coral_Modelos_TipoDocumento.createInstance = function() {
		return $Aicl_Coral_Modelos_TipoDocumento.$ctor();
	};
	$Aicl_Coral_Modelos_TipoDocumento.$ctor = function() {
		var $this = {};
		$this.Id = 0;
		$this.Descripcion = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.UserLogin
	var $Aicl_Coral_Modelos_UserLogin = function() {
	};
	$Aicl_Coral_Modelos_UserLogin.createInstance = function() {
		return $Aicl_Coral_Modelos_UserLogin.$ctor();
	};
	$Aicl_Coral_Modelos_UserLogin.$ctor = function() {
		var $this = {};
		$this.Nit = null;
		$this.Nombre = null;
		$this.Clave = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.UserLoginResponse
	var $Aicl_Coral_Modelos_UserLoginResponse = function() {
	};
	$Aicl_Coral_Modelos_UserLoginResponse.createInstance = function() {
		return $Aicl_Coral_Modelos_UserLoginResponse.$ctor();
	};
	$Aicl_Coral_Modelos_UserLoginResponse.$ctor = function() {
		var $this = {};
		$this.DisplayName = null;
		$this.Email = null;
		$this.Empresa = null;
		$this.Centros = null;
		$this.SucursalesAutorizadas = null;
		$this.Actividades = null;
		$this.Menu = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.UserLogout
	var $Aicl_Coral_Modelos_UserLogout = function() {
	};
	$Aicl_Coral_Modelos_UserLogout.createInstance = function() {
		return $Aicl_Coral_Modelos_UserLogout.$ctor();
	};
	$Aicl_Coral_Modelos_UserLogout.$ctor = function() {
		var $this = {};
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.UsuarioCentroSucursal
	var $Aicl_Coral_Modelos_UsuarioCentroSucursal = function() {
	};
	$Aicl_Coral_Modelos_UsuarioCentroSucursal.createInstance = function() {
		return $Aicl_Coral_Modelos_UsuarioCentroSucursal.$ctor();
	};
	$Aicl_Coral_Modelos_UsuarioCentroSucursal.$ctor = function() {
		var $this = {};
		$this.Id = null;
		$this.IdEmpresa = 0;
		$this.IdSucursal = 0;
		$this.IdCentro = 0;
		$this.IdUsuario = 0;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.UsuarioEmpresa
	var $Aicl_Coral_Modelos_UsuarioEmpresa = function() {
	};
	$Aicl_Coral_Modelos_UsuarioEmpresa.createInstance = function() {
		return $Aicl_Coral_Modelos_UsuarioEmpresa.$ctor();
	};
	$Aicl_Coral_Modelos_UsuarioEmpresa.$ctor = function() {
		var $this = {};
		$this.Id = null;
		$this.IdEmpresa = 0;
		$this.IdUsuario = 0;
		$this.RequiereSucursal = false;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// Aicl.Coral.Modelos.UsuarioSucursal
	var $Aicl_Coral_Modelos_UsuarioSucursal = function() {
	};
	$Aicl_Coral_Modelos_UsuarioSucursal.createInstance = function() {
		return $Aicl_Coral_Modelos_UsuarioSucursal.$ctor();
	};
	$Aicl_Coral_Modelos_UsuarioSucursal.$ctor = function() {
		var $this = {};
		$this.Id = null;
		$this.IdEmpresa = 0;
		$this.IdSucursal = 0;
		$this.IdUsuario = 0;
		$this.RequiereCentro = false;
		return $this;
	};
	ss.registerClass(global, 'Aicl.Coral.Modelos.Actividad', $Aicl_Coral_Modelos_Actividad);
	ss.registerClass(global, 'Aicl.Coral.Modelos.ActividadClase', $Aicl_Coral_Modelos_ActividadClase);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Administradora', $Aicl_Coral_Modelos_Administradora);
	ss.registerClass(global, 'Aicl.Coral.Modelos.AdminLogin', $Aicl_Coral_Modelos_AdminLogin);
	ss.registerClass(global, 'Aicl.Coral.Modelos.AdminLoginResponse', $Aicl_Coral_Modelos_AdminLoginResponse);
	ss.registerClass(global, 'Aicl.Coral.Modelos.AdminLogout', $Aicl_Coral_Modelos_AdminLogout);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Candidato', $Aicl_Coral_Modelos_Candidato);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Centro', $Aicl_Coral_Modelos_Centro);
	ss.registerClass(global, 'Aicl.Coral.Modelos.CentroSucursal', $Aicl_Coral_Modelos_CentroSucursal);
	ss.registerClass(global, 'Aicl.Coral.Modelos.ClaseCliente', $Aicl_Coral_Modelos_ClaseCliente);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Departamento', $Aicl_Coral_Modelos_Departamento);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Empresa', $Aicl_Coral_Modelos_Empresa);
	ss.registerClass(global, 'Aicl.Coral.Modelos.EmpresaCcf', $Aicl_Coral_Modelos_EmpresaCcf);
	ss.registerClass(global, 'Aicl.Coral.Modelos.EmpresaCreate', $Aicl_Coral_Modelos_EmpresaCreate);
	ss.registerClass(global, 'Aicl.Coral.Modelos.EmpresaDestroy', $Aicl_Coral_Modelos_EmpresaDestroy);
	ss.registerClass(global, 'Aicl.Coral.Modelos.EmpresaRead', $Aicl_Coral_Modelos_EmpresaRead);
	ss.registerClass(global, 'Aicl.Coral.Modelos.EmpresaUpdate', $Aicl_Coral_Modelos_EmpresaUpdate);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Estado', $Aicl_Coral_Modelos_Estado);
	ss.registerClass(global, 'Aicl.Coral.Modelos.EstadoCivil', $Aicl_Coral_Modelos_EstadoCivil);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Grupo', $Aicl_Coral_Modelos_Grupo);
	ss.registerClass(global, 'Aicl.Coral.Modelos.GrupoActividad', $Aicl_Coral_Modelos_GrupoActividad);
	ss.registerClass(global, 'Aicl.Coral.Modelos.GrupoUsuario', $Aicl_Coral_Modelos_GrupoUsuario);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Item', $Aicl_Coral_Modelos_Item);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Menu', $Aicl_Coral_Modelos_Menu);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Municipio', $Aicl_Coral_Modelos_Municipio);
	ss.registerClass(global, 'Aicl.Coral.Modelos.NivelAcademico', $Aicl_Coral_Modelos_NivelAcademico);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Pais', $Aicl_Coral_Modelos_Pais);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Profesion', $Aicl_Coral_Modelos_Profesion);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Sanguineo', $Aicl_Coral_Modelos_Sanguineo);
	ss.registerClass(global, 'Aicl.Coral.Modelos.ServicioAdministradora', $Aicl_Coral_Modelos_ServicioAdministradora);
	ss.registerClass(global, 'Aicl.Coral.Modelos.Sucursal', $Aicl_Coral_Modelos_Sucursal);
	ss.registerClass(global, 'Aicl.Coral.Modelos.SucursalAutorizada', $Aicl_Coral_Modelos_SucursalAutorizada);
	ss.registerClass(global, 'Aicl.Coral.Modelos.TipoActividad', $Aicl_Coral_Modelos_TipoActividad);
	ss.registerClass(global, 'Aicl.Coral.Modelos.TipoDocumento', $Aicl_Coral_Modelos_TipoDocumento);
	ss.registerClass(global, 'Aicl.Coral.Modelos.UserLogin', $Aicl_Coral_Modelos_UserLogin);
	ss.registerClass(global, 'Aicl.Coral.Modelos.UserLoginResponse', $Aicl_Coral_Modelos_UserLoginResponse);
	ss.registerClass(global, 'Aicl.Coral.Modelos.UserLogout', $Aicl_Coral_Modelos_UserLogout);
	ss.registerClass(global, 'Aicl.Coral.Modelos.UsuarioCentroSucursal', $Aicl_Coral_Modelos_UsuarioCentroSucursal);
	ss.registerClass(global, 'Aicl.Coral.Modelos.UsuarioEmpresa', $Aicl_Coral_Modelos_UsuarioEmpresa);
	ss.registerClass(global, 'Aicl.Coral.Modelos.UsuarioSucursal', $Aicl_Coral_Modelos_UsuarioSucursal);
})();
