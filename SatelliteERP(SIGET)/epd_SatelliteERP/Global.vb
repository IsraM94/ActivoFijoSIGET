Imports System.IO

Module Globales
    Friend Data_Id_Company As Long = 1
    Friend Data_BusinessDay As Date = Now() 'New DateTime(2016, 01, 01)  ' Se tiene que cambiar a fecha del dia.
    Friend Data_LongAccount As Integer = 7 ' Parametro se tiene que hacer una pantalla para esto despues de llenar el catalogo y le 
    ' mostrara los niveles para seleccione su nivel de cuenta de mayor
    Friend Data_LevelBalance As Integer = 3 ' Nivel del balance general para reporteria
    Friend Data_TaxPercentage As Decimal = 0.13
    Friend _Address As String = "C:" & Path.DirectorySeparatorChar & "temp"
    Friend _ID_Company As Integer = 1
    Friend _Equipo As String = My.Computer.Name
    Friend _User As String = My.User.Name
    Friend _ID_Customer As Long = 0 ' Codigo de proveedor para productos locales
    Friend _SystemUser As String = "Prueba" ' Este se obtendra del login
    Friend _CompanyName As String = "Superintendencia General de Electricidad y Telecomunicaciones " ' Nombre de la Empresa que se mostrará en los reportes
    Friend _CompanyLogo As String = "C:\temp\logo.jpg" ' Nombre de la Empresa que se mostrará en los reportes
    Friend _Background As String = "images\fondo.jpg" ' Nombre de la Empresa que se mostrará en los reportes
    Friend _HeaderReportColor As String = "SteelBlue"
    Friend _Giro As String = "CONSULTORÍAS Y GESTIÓN DE SERVICIOS INFORMÁTICOS"
    Friend _DireccionEmpresa As String = "Col. Flor Blanca, Prolongación Calle el Progreso, Pasaje El Rosedal # 18, San Salvador, El Salvador"
    Friend _NRC As String = "230625-0"
    Friend _NIT As String = "0614-100214-101-3"
    Friend _RepresentanteLegal As String = "Patricia Guadalupe Estrada"
    Friend _ContadorGeneral As String = "Marvyn Eliseo Chevez"
    Friend ValidarAnimales As Boolean = False
    Friend _UserSQL As String = ""
    Friend _Parammargencod As String = "0"
    Friend _Parammargensup As String = "0"
    Friend _Password As String = ""
    Friend _Conexion As String = ""
    Friend _FiltradoPor As String = " "
    Friend _MostrarFiltro As Boolean = False
    Friend _Id_EmployeeGlobal As Integer = 0
    Friend _Id_DepartmentGlobal As Integer = 0
    Friend _Id_DepartmentAlmacen As Integer = 0
    Friend _PasswordMail As String = "SIGETERP@2018"
    Friend _VerTodos As Boolean = False
    Friend _Id_DptoPlani As Integer = 0
    Friend _NombreDepartamento As String = ""
    Friend _MesReportado As String = ""
    Friend _IdMesReportado As Integer = 0
    Friend _DepartamentoHijo As Boolean = False
    Friend _SuperUsuarioPlanificacion As Boolean = False
    Friend _RutaArchivosRespaldoOri As String = "c:/temp/imgPlani/"
    Friend _RutaArchivosRespaldo As String = ""
    'Friend _CadenaConexion As String = "Data Source=DESKTOP-7KRC517;Initial Catalog=SatelliteERP;integrated security=false; user id=sa; password=123456789;"

    'Friend _CadenaConexion As String = "Data Source=EPD_POCA\SQLEXPRESS;Initial Catalog=SatelliteERPIntegrado;integrated security=false; user id=[user]; password=[password];"
    'Friend _CadenaConexionLogin As String = "Data Source=inf-des-05/infdes05;Initial Catalog=SatelliteERPIntegrado;integrated security=false; user id=sa; password=siget4321*;"
    Friend _CadenaConexion As String = ""    '"Data Source=inf-des-05/infdes05;Initial Catalog=SatelliteERPIntegrado;integrated security=false; user id=sa; password=siget4321*;"
    'Friend _CadenaConexion As String = "Data Source=sig-des-02;Initial Catalog=PlanificacionERP;integrated security=false; user id=sa; password=12345abc*;"

    Enum TypeAccount
        CuentaDeMayor = 2
        CuentaDeTitulo = 1
        CuentaNoMayor = 3
        NoDefinida = 0
    End Enum
End Module
