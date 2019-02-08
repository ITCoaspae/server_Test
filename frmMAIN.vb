Public Class frmMAIN
    'Inherits MetroFramework.Forms.MetroForm '
    Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem216 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem223 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem224 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem562 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem563 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem564 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem565 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem566 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem569 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem570 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem571 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem572 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem573 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem574 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem578 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem577 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem579 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem580 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem581 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem582 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem583 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem584 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem585 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem586 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem587 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem588 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem589 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem590 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem591 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem592 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem593 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem594 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem595 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem596 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem597 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem598 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem599 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem600 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem601 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem602 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem603 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem604 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem605 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem607 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem608 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem613 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem614 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem615 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem616 As System.Windows.Forms.MenuItem
    Private WithEvents t As New Timer
    Friend WithEvents MenuItem622 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem623 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem624 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem625 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem631 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem632 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem634 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem635 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem633 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem609 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem610 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem611 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem612 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem637 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem638 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem639 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem640 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem641 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem642 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem643 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem644 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem645 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem646 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem647 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem648 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem649 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem650 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem651 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem652 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem656 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem657 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem658 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem659 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem660 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem662 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem665 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem666 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem480 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem483 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem484 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem485 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem667 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem668 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem669 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem674 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem675 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem676 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem677 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem671 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem672 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem678 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem679 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem680 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem681 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem682 As MenuItem
    Friend WithEvents MenuItem267 As MenuItem
    Friend WithEvents MenuItem683 As MenuItem
    Friend WithEvents MenuItem684 As MenuItem
    Friend WithEvents MenuItem685 As MenuItem
    Friend WithEvents MenuItem686 As MenuItem
    Friend WithEvents MenuItem687 As MenuItem
    Friend WithEvents MenuItem688 As MenuItem
    Friend WithEvents MenuItem140 As MenuItem
    Friend WithEvents MenuItem149 As MenuItem
    Friend WithEvents MenuItem155 As MenuItem
    Friend WithEvents MenuItem184 As MenuItem
    Friend WithEvents MenuItem343 As MenuItem
    Friend WithEvents MenuItem344 As MenuItem
    Friend WithEvents MenuItem352 As MenuItem
    Friend WithEvents MenuItem183 As MenuItem
    Friend WithEvents MenuItem473 As MenuItem
    Friend WithEvents MenuItem524 As MenuItem
    Friend WithEvents MenuItem575 As MenuItem
    Friend WithEvents MenuItem576 As MenuItem
    Friend WithEvents MenuItem15 As MenuItem
    Friend WithEvents MenuItem16 As MenuItem
    Friend WithEvents MenuItem17 As MenuItem
    Friend WithEvents MenuItem18 As MenuItem
    Friend WithEvents MenuItem12 As MenuItem
    Friend WithEvents MenuItem13 As MenuItem
    Friend WithEvents MenuItem14 As MenuItem
    Friend WithEvents MenuItem326 As MenuItem
    Friend WithEvents MenuItem606 As MenuItem
    Friend WithEvents MenuItem617 As MenuItem
    Friend WithEvents MenuItem325 As MenuItem
    Friend WithEvents MenuItem353 As MenuItem
    Friend WithEvents MenuItem482 As MenuItem
    Friend WithEvents MenuItem567 As MenuItem
    Friend WithEvents MenuItem568 As MenuItem
    Friend WithEvents MenuItem618 As MenuItem
    Friend WithEvents MenuItem619 As MenuItem
    Friend WithEvents MenuItem138 As MenuItem
    Friend WithEvents MenuItem663 As MenuItem
    Friend WithEvents MenuItem664 As MenuItem
    Friend WithEvents MenuItem20 As MenuItem
    Friend WithEvents MenuItem137 As MenuItem
    Friend WithEvents MenuItem332 As MenuItem
    Friend WithEvents MenuItem333 As MenuItem
    Friend WithEvents MenuItem334 As MenuItem
    Friend WithEvents MenuItem335 As MenuItem
    Friend WithEvents MenuItem340 As MenuItem
    Friend WithEvents MenuItem341 As MenuItem
    Friend WithEvents MenuItem464 As MenuItem
    Friend WithEvents MenuItem620 As MenuItem
    Friend WithEvents MenuItem621 As MenuItem
    Friend WithEvents MenuItem626 As MenuItem
    Friend WithEvents MenuItem627 As MenuItem
    Friend WithEvents MenuItem628 As MenuItem
    Friend WithEvents MenuItem629 As MenuItem
    Friend WithEvents MenuItem630 As MenuItem
    Friend WithEvents MenuItem169 As MenuItem
    Friend WithEvents MenuItem636 As MenuItem
    Friend WithEvents MenuItem653 As MenuItem
    Friend WithEvents MenuItem654 As MenuItem
    Dim Planillas As New wrPlanilla.wsLibPlanilla

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ':  Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInicio As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuContabilidad As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAsociados As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAportaciones As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCreditos As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAhorros As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdministracion As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMAsociados As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMReferencias As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMBeneficiarios As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMAspectosCoop As System.Windows.Forms.MenuItem
    Friend WithEvents mnuControlRetiro As System.Windows.Forms.MenuItem
    Friend WithEvents mnuControlIngreso As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMSolRetiroVol As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMProcRetiroVol As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMInhabilitacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMExclusion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMFallecimiento As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMLibroAsoc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMEstadoAdmision As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuControlPrestamos As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMaestroPrestamos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCaja As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents stbMain As System.Windows.Forms.StatusBar
    Friend WithEvents sbp1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sbp2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCobranza As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem125 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPlanilla As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem194 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInicioSesion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem195 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem196 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem197 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem198 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem199 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem200 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem201 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem202 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem203 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem204 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem205 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem206 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem207 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem208 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem209 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem210 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem211 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem212 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem213 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem214 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem217 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem218 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem219 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem220 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem221 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem222 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem225 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem226 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem232 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem233 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem234 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem173 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem175 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem177 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem178 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem179 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem181 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem182 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem185 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem186 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem187 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem188 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem189 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem190 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem192 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem193 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem215 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuA1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuA2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuA3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuB11 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuB12 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuB13 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuB14 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuB15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGarantias As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem252 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem255 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGerenciales As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem191 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem228 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem244 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem245 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuActivoFijo As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem227 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem229 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem230 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem231 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem246 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem247 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem248 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem249 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem250 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem253 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem251 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem254 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem256 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem257 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem258 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem259 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem260 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem261 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem262 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem264 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem265 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem266 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem176 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGeneral As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem270 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem271 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem272 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem273 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem274 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem275 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem276 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem278 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem279 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem280 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem180 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem281 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem282 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem283 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem284 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem285 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem286 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem287 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem288 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem289 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem290 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem291 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem292 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem293 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem294 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem295 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem296 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem297 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem298 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem299 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem300 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem301 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem302 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem303 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem304 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem305 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem306 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem307 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem308 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem310 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem311 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem314 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem315 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem316 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem317 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem318 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem313 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem319 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem320 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem321 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem322 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem323 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem324 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem277 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem327 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem329 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem330 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem331 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem336 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem337 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem338 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem339 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem342 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem345 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem346 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem347 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem348 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem349 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem350 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem351 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem354 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem355 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem356 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem357 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem358 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem359 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem360 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem361 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem362 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem363 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem364 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem365 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem366 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem367 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem368 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem369 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem370 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem371 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem372 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem373 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem374 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem375 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem376 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem377 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem378 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem379 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem380 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem381 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem382 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem383 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem384 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem385 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem386 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem387 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem388 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem389 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem390 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem391 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem392 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem393 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem394 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem395 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem396 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem397 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem398 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem399 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem400 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem401 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem402 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem403 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem404 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem405 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem406 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem407 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem408 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem409 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem410 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem411 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem412 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem413 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem414 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem415 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem416 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem417 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem419 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem420 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem421 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem422 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem424 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem423 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem425 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem426 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem427 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem428 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem429 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem430 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem431 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem432 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem433 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem434 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem435 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem436 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem437 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem438 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem439 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem440 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem441 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem442 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem444 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem445 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem446 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem448 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem449 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem418 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem328 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem450 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem451 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem312 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem452 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem453 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem454 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem455 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem456 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem457 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem458 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem460 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem459 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem461 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem462 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem463 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem465 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem466 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem467 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem468 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem469 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem470 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem471 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem472 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem475 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem476 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem477 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem478 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem474 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem479 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem309 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem488 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem489 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem443 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem447 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem241 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem481 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem486 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem487 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem237 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem240 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem242 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem490 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem491 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem235 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem236 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem239 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem243 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem492 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem238 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem493 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem494 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem495 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem496 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem497 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem498 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem499 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem500 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem501 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem502 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem503 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem504 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem505 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem506 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem507 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem508 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem510 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem512 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem513 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem514 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem515 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem516 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem517 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem518 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem519 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem520 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem521 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem522 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem523 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem263 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem525 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem511 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem509 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem526 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem527 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem528 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem529 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem530 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem531 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem532 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem533 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem534 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem535 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem536 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem537 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem539 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem540 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem541 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem538 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem542 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem543 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem544 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem268 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem269 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem545 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem546 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem547 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem548 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem549 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem550 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem551 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem552 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem553 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem554 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem555 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem556 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem557 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem558 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem559 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem560 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem561 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMAIN))
        Me.mnuInicio = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.mnuContabilidad = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.mnuA1 = New System.Windows.Forms.MenuItem()
        Me.mnuA2 = New System.Windows.Forms.MenuItem()
        Me.mnuA3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem93 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem326 = New System.Windows.Forms.MenuItem()
        Me.MenuItem606 = New System.Windows.Forms.MenuItem()
        Me.MenuItem617 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem473 = New System.Windows.Forms.MenuItem()
        Me.MenuItem524 = New System.Windows.Forms.MenuItem()
        Me.MenuItem575 = New System.Windows.Forms.MenuItem()
        Me.MenuItem576 = New System.Windows.Forms.MenuItem()
        Me.MenuItem611 = New System.Windows.Forms.MenuItem()
        Me.MenuItem612 = New System.Windows.Forms.MenuItem()
        Me.MenuItem637 = New System.Windows.Forms.MenuItem()
        Me.MenuItem638 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem96 = New System.Windows.Forms.MenuItem()
        Me.MenuItem325 = New System.Windows.Forms.MenuItem()
        Me.MenuItem353 = New System.Windows.Forms.MenuItem()
        Me.MenuItem482 = New System.Windows.Forms.MenuItem()
        Me.MenuItem567 = New System.Windows.Forms.MenuItem()
        Me.MenuItem568 = New System.Windows.Forms.MenuItem()
        Me.MenuItem618 = New System.Windows.Forms.MenuItem()
        Me.MenuItem619 = New System.Windows.Forms.MenuItem()
        Me.MenuItem138 = New System.Windows.Forms.MenuItem()
        Me.MenuItem620 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem123 = New System.Windows.Forms.MenuItem()
        Me.MenuItem125 = New System.Windows.Forms.MenuItem()
        Me.MenuItem192 = New System.Windows.Forms.MenuItem()
        Me.MenuItem414 = New System.Windows.Forms.MenuItem()
        Me.MenuItem165 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem285 = New System.Windows.Forms.MenuItem()
        Me.MenuItem286 = New System.Windows.Forms.MenuItem()
        Me.MenuItem287 = New System.Windows.Forms.MenuItem()
        Me.MenuItem288 = New System.Windows.Forms.MenuItem()
        Me.MenuItem289 = New System.Windows.Forms.MenuItem()
        Me.MenuItem290 = New System.Windows.Forms.MenuItem()
        Me.MenuItem291 = New System.Windows.Forms.MenuItem()
        Me.MenuItem292 = New System.Windows.Forms.MenuItem()
        Me.MenuItem293 = New System.Windows.Forms.MenuItem()
        Me.MenuItem294 = New System.Windows.Forms.MenuItem()
        Me.MenuItem569 = New System.Windows.Forms.MenuItem()
        Me.MenuItem639 = New System.Windows.Forms.MenuItem()
        Me.MenuItem640 = New System.Windows.Forms.MenuItem()
        Me.MenuItem570 = New System.Windows.Forms.MenuItem()
        Me.MenuItem582 = New System.Windows.Forms.MenuItem()
        Me.MenuItem583 = New System.Windows.Forms.MenuItem()
        Me.MenuItem571 = New System.Windows.Forms.MenuItem()
        Me.MenuItem658 = New System.Windows.Forms.MenuItem()
        Me.MenuItem659 = New System.Windows.Forms.MenuItem()
        Me.MenuItem660 = New System.Windows.Forms.MenuItem()
        Me.MenuItem662 = New System.Windows.Forms.MenuItem()
        Me.MenuItem184 = New System.Windows.Forms.MenuItem()
        Me.MenuItem343 = New System.Windows.Forms.MenuItem()
        Me.MenuItem344 = New System.Windows.Forms.MenuItem()
        Me.MenuItem352 = New System.Windows.Forms.MenuItem()
        Me.MenuItem183 = New System.Windows.Forms.MenuItem()
        Me.MenuItem283 = New System.Windows.Forms.MenuItem()
        Me.MenuItem284 = New System.Windows.Forms.MenuItem()
        Me.MenuItem474 = New System.Windows.Forms.MenuItem()
        Me.MenuItem479 = New System.Windows.Forms.MenuItem()
        Me.MenuItem309 = New System.Windows.Forms.MenuItem()
        Me.MenuItem297 = New System.Windows.Forms.MenuItem()
        Me.MenuItem302 = New System.Windows.Forms.MenuItem()
        Me.MenuItem304 = New System.Windows.Forms.MenuItem()
        Me.MenuItem310 = New System.Windows.Forms.MenuItem()
        Me.MenuItem311 = New System.Windows.Forms.MenuItem()
        Me.MenuItem439 = New System.Windows.Forms.MenuItem()
        Me.MenuItem445 = New System.Windows.Forms.MenuItem()
        Me.MenuItem466 = New System.Windows.Forms.MenuItem()
        Me.MenuItem467 = New System.Windows.Forms.MenuItem()
        Me.MenuItem468 = New System.Windows.Forms.MenuItem()
        Me.MenuItem469 = New System.Windows.Forms.MenuItem()
        Me.MenuItem470 = New System.Windows.Forms.MenuItem()
        Me.MenuItem471 = New System.Windows.Forms.MenuItem()
        Me.MenuItem530 = New System.Windows.Forms.MenuItem()
        Me.MenuItem531 = New System.Windows.Forms.MenuItem()
        Me.MenuItem588 = New System.Windows.Forms.MenuItem()
        Me.MenuItem589 = New System.Windows.Forms.MenuItem()
        Me.MenuItem599 = New System.Windows.Forms.MenuItem()
        Me.MenuItem607 = New System.Windows.Forms.MenuItem()
        Me.MenuItem613 = New System.Windows.Forms.MenuItem()
        Me.MenuItem622 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem100 = New System.Windows.Forms.MenuItem()
        Me.MenuItem295 = New System.Windows.Forms.MenuItem()
        Me.MenuItem296 = New System.Windows.Forms.MenuItem()
        Me.MenuItem298 = New System.Windows.Forms.MenuItem()
        Me.MenuItem306 = New System.Windows.Forms.MenuItem()
        Me.MenuItem64 = New System.Windows.Forms.MenuItem()
        Me.MenuItem591 = New System.Windows.Forms.MenuItem()
        Me.MenuItem592 = New System.Windows.Forms.MenuItem()
        Me.MenuItem608 = New System.Windows.Forms.MenuItem()
        Me.MenuItem614 = New System.Windows.Forms.MenuItem()
        Me.MenuItem615 = New System.Windows.Forms.MenuItem()
        Me.MenuItem616 = New System.Windows.Forms.MenuItem()
        Me.MenuItem649 = New System.Windows.Forms.MenuItem()
        Me.MenuItem299 = New System.Windows.Forms.MenuItem()
        Me.MenuItem300 = New System.Windows.Forms.MenuItem()
        Me.MenuItem301 = New System.Windows.Forms.MenuItem()
        Me.MenuItem84 = New System.Windows.Forms.MenuItem()
        Me.MenuItem472 = New System.Windows.Forms.MenuItem()
        Me.MenuItem526 = New System.Windows.Forms.MenuItem()
        Me.MenuItem408 = New System.Windows.Forms.MenuItem()
        Me.MenuItem409 = New System.Windows.Forms.MenuItem()
        Me.MenuItem410 = New System.Windows.Forms.MenuItem()
        Me.MenuItem411 = New System.Windows.Forms.MenuItem()
        Me.mnuAsociados = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.mnuMAsociados = New System.Windows.Forms.MenuItem()
        Me.mnuMReferencias = New System.Windows.Forms.MenuItem()
        Me.mnuMBeneficiarios = New System.Windows.Forms.MenuItem()
        Me.mnuMAspectosCoop = New System.Windows.Forms.MenuItem()
        Me.MenuItem148 = New System.Windows.Forms.MenuItem()
        Me.MenuItem162 = New System.Windows.Forms.MenuItem()
        Me.MenuItem674 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.mnuControlRetiro = New System.Windows.Forms.MenuItem()
        Me.mnuMSolRetiroVol = New System.Windows.Forms.MenuItem()
        Me.mnuMProcRetiroVol = New System.Windows.Forms.MenuItem()
        Me.mnuMInhabilitacion = New System.Windows.Forms.MenuItem()
        Me.mnuMExclusion = New System.Windows.Forms.MenuItem()
        Me.mnuMFallecimiento = New System.Windows.Forms.MenuItem()
        Me.mnuControlIngreso = New System.Windows.Forms.MenuItem()
        Me.mnuMLibroAsoc = New System.Windows.Forms.MenuItem()
        Me.mnuMEstadoAdmision = New System.Windows.Forms.MenuItem()
        Me.MenuItem85 = New System.Windows.Forms.MenuItem()
        Me.MenuItem321 = New System.Windows.Forms.MenuItem()
        Me.MenuItem549 = New System.Windows.Forms.MenuItem()
        Me.MenuItem681 = New System.Windows.Forms.MenuItem()
        Me.MenuItem82 = New System.Windows.Forms.MenuItem()
        Me.MenuItem318 = New System.Windows.Forms.MenuItem()
        Me.MenuItem151 = New System.Windows.Forms.MenuItem()
        Me.MenuItem313 = New System.Windows.Forms.MenuItem()
        Me.MenuItem319 = New System.Windows.Forms.MenuItem()
        Me.MenuItem511 = New System.Windows.Forms.MenuItem()
        Me.MenuItem314 = New System.Windows.Forms.MenuItem()
        Me.MenuItem83 = New System.Windows.Forms.MenuItem()
        Me.MenuItem315 = New System.Windows.Forms.MenuItem()
        Me.MenuItem316 = New System.Windows.Forms.MenuItem()
        Me.MenuItem317 = New System.Windows.Forms.MenuItem()
        Me.MenuItem458 = New System.Windows.Forms.MenuItem()
        Me.MenuItem427 = New System.Windows.Forms.MenuItem()
        Me.MenuItem428 = New System.Windows.Forms.MenuItem()
        Me.MenuItem154 = New System.Windows.Forms.MenuItem()
        Me.MenuItem163 = New System.Windows.Forms.MenuItem()
        Me.MenuItem263 = New System.Windows.Forms.MenuItem()
        Me.MenuItem566 = New System.Windows.Forms.MenuItem()
        Me.MenuItem572 = New System.Windows.Forms.MenuItem()
        Me.MenuItem573 = New System.Windows.Forms.MenuItem()
        Me.MenuItem574 = New System.Windows.Forms.MenuItem()
        Me.MenuItem656 = New System.Windows.Forms.MenuItem()
        Me.MenuItem480 = New System.Windows.Forms.MenuItem()
        Me.MenuItem675 = New System.Windows.Forms.MenuItem()
        Me.MenuItem364 = New System.Windows.Forms.MenuItem()
        Me.MenuItem365 = New System.Windows.Forms.MenuItem()
        Me.MenuItem366 = New System.Windows.Forms.MenuItem()
        Me.MenuItem367 = New System.Windows.Forms.MenuItem()
        Me.mnuAportaciones = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem72 = New System.Windows.Forms.MenuItem()
        Me.MenuItem92 = New System.Windows.Forms.MenuItem()
        Me.MenuItem189 = New System.Windows.Forms.MenuItem()
        Me.MenuItem190 = New System.Windows.Forms.MenuItem()
        Me.MenuItem104 = New System.Windows.Forms.MenuItem()
        Me.MenuItem432 = New System.Windows.Forms.MenuItem()
        Me.MenuItem601 = New System.Windows.Forms.MenuItem()
        Me.MenuItem625 = New System.Windows.Forms.MenuItem()
        Me.MenuItem111 = New System.Windows.Forms.MenuItem()
        Me.MenuItem112 = New System.Windows.Forms.MenuItem()
        Me.MenuItem152 = New System.Windows.Forms.MenuItem()
        Me.MenuItem179 = New System.Windows.Forms.MenuItem()
        Me.MenuItem355 = New System.Windows.Forms.MenuItem()
        Me.MenuItem328 = New System.Windows.Forms.MenuItem()
        Me.MenuItem552 = New System.Windows.Forms.MenuItem()
        Me.MenuItem556 = New System.Windows.Forms.MenuItem()
        Me.MenuItem557 = New System.Windows.Forms.MenuItem()
        Me.MenuItem558 = New System.Windows.Forms.MenuItem()
        Me.MenuItem559 = New System.Windows.Forms.MenuItem()
        Me.MenuItem560 = New System.Windows.Forms.MenuItem()
        Me.MenuItem561 = New System.Windows.Forms.MenuItem()
        Me.MenuItem602 = New System.Windows.Forms.MenuItem()
        Me.MenuItem368 = New System.Windows.Forms.MenuItem()
        Me.MenuItem369 = New System.Windows.Forms.MenuItem()
        Me.MenuItem370 = New System.Windows.Forms.MenuItem()
        Me.MenuItem371 = New System.Windows.Forms.MenuItem()
        Me.mnuCreditos = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem86 = New System.Windows.Forms.MenuItem()
        Me.MenuItem456 = New System.Windows.Forms.MenuItem()
        Me.MenuItem457 = New System.Windows.Forms.MenuItem()
        Me.MenuItem87 = New System.Windows.Forms.MenuItem()
        Me.MenuItem88 = New System.Windows.Forms.MenuItem()
        Me.MenuItem89 = New System.Windows.Forms.MenuItem()
        Me.MenuItem266 = New System.Windows.Forms.MenuItem()
        Me.MenuItem91 = New System.Windows.Forms.MenuItem()
        Me.MenuItem173 = New System.Windows.Forms.MenuItem()
        Me.MenuItem177 = New System.Windows.Forms.MenuItem()
        Me.MenuItem180 = New System.Windows.Forms.MenuItem()
        Me.MenuItem281 = New System.Windows.Forms.MenuItem()
        Me.MenuItem282 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem124 = New System.Windows.Forms.MenuItem()
        Me.MenuItem587 = New System.Windows.Forms.MenuItem()
        Me.MenuItem193 = New System.Windows.Forms.MenuItem()
        Me.MenuItem643 = New System.Windows.Forms.MenuItem()
        Me.MenuItem644 = New System.Windows.Forms.MenuItem()
        Me.MenuItem645 = New System.Windows.Forms.MenuItem()
        Me.MenuItem646 = New System.Windows.Forms.MenuItem()
        Me.MenuItem647 = New System.Windows.Forms.MenuItem()
        Me.MenuItem650 = New System.Windows.Forms.MenuItem()
        Me.MenuItem651 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem65 = New System.Windows.Forms.MenuItem()
        Me.MenuItem66 = New System.Windows.Forms.MenuItem()
        Me.MenuItem176 = New System.Windows.Forms.MenuItem()
        Me.MenuItem139 = New System.Windows.Forms.MenuItem()
        Me.MenuItem416 = New System.Windows.Forms.MenuItem()
        Me.MenuItem417 = New System.Windows.Forms.MenuItem()
        Me.MenuItem433 = New System.Windows.Forms.MenuItem()
        Me.MenuItem551 = New System.Windows.Forms.MenuItem()
        Me.MenuItem584 = New System.Windows.Forms.MenuItem()
        Me.MenuItem624 = New System.Windows.Forms.MenuItem()
        Me.MenuItem648 = New System.Windows.Forms.MenuItem()
        Me.mnuControlPrestamos = New System.Windows.Forms.MenuItem()
        Me.mnuMaestroPrestamos = New System.Windows.Forms.MenuItem()
        Me.MenuItem58 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem71 = New System.Windows.Forms.MenuItem()
        Me.MenuItem113 = New System.Windows.Forms.MenuItem()
        Me.MenuItem174 = New System.Windows.Forms.MenuItem()
        Me.MenuItem175 = New System.Windows.Forms.MenuItem()
        Me.MenuItem178 = New System.Windows.Forms.MenuItem()
        Me.MenuItem323 = New System.Windows.Forms.MenuItem()
        Me.MenuItem676 = New System.Windows.Forms.MenuItem()
        Me.MenuItem677 = New System.Windows.Forms.MenuItem()
        Me.MenuItem94 = New System.Windows.Forms.MenuItem()
        Me.MenuItem95 = New System.Windows.Forms.MenuItem()
        Me.MenuItem440 = New System.Windows.Forms.MenuItem()
        Me.MenuItem441 = New System.Windows.Forms.MenuItem()
        Me.MenuItem97 = New System.Windows.Forms.MenuItem()
        Me.MenuItem182 = New System.Windows.Forms.MenuItem()
        Me.MenuItem185 = New System.Windows.Forms.MenuItem()
        Me.MenuItem324 = New System.Windows.Forms.MenuItem()
        Me.MenuItem438 = New System.Windows.Forms.MenuItem()
        Me.MenuItem437 = New System.Windows.Forms.MenuItem()
        Me.MenuItem348 = New System.Windows.Forms.MenuItem()
        Me.MenuItem349 = New System.Windows.Forms.MenuItem()
        Me.MenuItem350 = New System.Windows.Forms.MenuItem()
        Me.MenuItem351 = New System.Windows.Forms.MenuItem()
        Me.MenuItem357 = New System.Windows.Forms.MenuItem()
        Me.MenuItem412 = New System.Windows.Forms.MenuItem()
        Me.MenuItem436 = New System.Windows.Forms.MenuItem()
        Me.MenuItem158 = New System.Windows.Forms.MenuItem()
        Me.MenuItem578 = New System.Windows.Forms.MenuItem()
        Me.MenuItem585 = New System.Windows.Forms.MenuItem()
        Me.MenuItem641 = New System.Windows.Forms.MenuItem()
        Me.MenuItem642 = New System.Windows.Forms.MenuItem()
        Me.MenuItem672 = New System.Windows.Forms.MenuItem()
        Me.MenuItem678 = New System.Windows.Forms.MenuItem()
        Me.MenuItem679 = New System.Windows.Forms.MenuItem()
        Me.MenuItem680 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem137 = New System.Windows.Forms.MenuItem()
        Me.MenuItem332 = New System.Windows.Forms.MenuItem()
        Me.MenuItem340 = New System.Windows.Forms.MenuItem()
        Me.MenuItem341 = New System.Windows.Forms.MenuItem()
        Me.MenuItem464 = New System.Windows.Forms.MenuItem()
        Me.MenuItem629 = New System.Windows.Forms.MenuItem()
        Me.MenuItem169 = New System.Windows.Forms.MenuItem()
        Me.MenuItem372 = New System.Windows.Forms.MenuItem()
        Me.MenuItem373 = New System.Windows.Forms.MenuItem()
        Me.MenuItem374 = New System.Windows.Forms.MenuItem()
        Me.MenuItem375 = New System.Windows.Forms.MenuItem()
        Me.mnuAhorros = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem110 = New System.Windows.Forms.MenuItem()
        Me.MenuItem103 = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItem107 = New System.Windows.Forms.MenuItem()
        Me.MenuItem609 = New System.Windows.Forms.MenuItem()
        Me.MenuItem682 = New System.Windows.Forms.MenuItem()
        Me.MenuItem98 = New System.Windows.Forms.MenuItem()
        Me.MenuItem99 = New System.Windows.Forms.MenuItem()
        Me.MenuItem101 = New System.Windows.Forms.MenuItem()
        Me.MenuItem167 = New System.Windows.Forms.MenuItem()
        Me.MenuItem303 = New System.Windows.Forms.MenuItem()
        Me.MenuItem305 = New System.Windows.Forms.MenuItem()
        Me.MenuItem322 = New System.Windows.Forms.MenuItem()
        Me.MenuItem593 = New System.Windows.Forms.MenuItem()
        Me.MenuItem594 = New System.Windows.Forms.MenuItem()
        Me.MenuItem595 = New System.Windows.Forms.MenuItem()
        Me.MenuItem596 = New System.Windows.Forms.MenuItem()
        Me.MenuItem610 = New System.Windows.Forms.MenuItem()
        Me.MenuItem657 = New System.Windows.Forms.MenuItem()
        Me.MenuItem105 = New System.Windows.Forms.MenuItem()
        Me.MenuItem106 = New System.Windows.Forms.MenuItem()
        Me.MenuItem109 = New System.Windows.Forms.MenuItem()
        Me.MenuItem146 = New System.Windows.Forms.MenuItem()
        Me.MenuItem150 = New System.Windows.Forms.MenuItem()
        Me.MenuItem166 = New System.Windows.Forms.MenuItem()
        Me.MenuItem307 = New System.Windows.Forms.MenuItem()
        Me.MenuItem308 = New System.Windows.Forms.MenuItem()
        Me.MenuItem142 = New System.Windows.Forms.MenuItem()
        Me.MenuItem338 = New System.Windows.Forms.MenuItem()
        Me.MenuItem339 = New System.Windows.Forms.MenuItem()
        Me.MenuItem342 = New System.Windows.Forms.MenuItem()
        Me.MenuItem168 = New System.Windows.Forms.MenuItem()
        Me.MenuItem423 = New System.Windows.Forms.MenuItem()
        Me.MenuItem465 = New System.Windows.Forms.MenuItem()
        Me.MenuItem532 = New System.Windows.Forms.MenuItem()
        Me.MenuItem345 = New System.Windows.Forms.MenuItem()
        Me.MenuItem346 = New System.Windows.Forms.MenuItem()
        Me.MenuItem347 = New System.Windows.Forms.MenuItem()
        Me.MenuItem356 = New System.Windows.Forms.MenuItem()
        Me.MenuItem425 = New System.Windows.Forms.MenuItem()
        Me.MenuItem426 = New System.Windows.Forms.MenuItem()
        Me.MenuItem435 = New System.Windows.Forms.MenuItem()
        Me.MenuItem418 = New System.Windows.Forms.MenuItem()
        Me.MenuItem597 = New System.Windows.Forms.MenuItem()
        Me.MenuItem598 = New System.Windows.Forms.MenuItem()
        Me.MenuItem600 = New System.Windows.Forms.MenuItem()
        Me.MenuItem685 = New System.Windows.Forms.MenuItem()
        Me.MenuItem686 = New System.Windows.Forms.MenuItem()
        Me.MenuItem687 = New System.Windows.Forms.MenuItem()
        Me.MenuItem688 = New System.Windows.Forms.MenuItem()
        Me.MenuItem140 = New System.Windows.Forms.MenuItem()
        Me.MenuItem149 = New System.Windows.Forms.MenuItem()
        Me.MenuItem155 = New System.Windows.Forms.MenuItem()
        Me.MenuItem360 = New System.Windows.Forms.MenuItem()
        Me.MenuItem361 = New System.Windows.Forms.MenuItem()
        Me.MenuItem362 = New System.Windows.Forms.MenuItem()
        Me.MenuItem363 = New System.Windows.Forms.MenuItem()
        Me.mnuAdministracion = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem75 = New System.Windows.Forms.MenuItem()
        Me.mnuB11 = New System.Windows.Forms.MenuItem()
        Me.mnuB12 = New System.Windows.Forms.MenuItem()
        Me.mnuB13 = New System.Windows.Forms.MenuItem()
        Me.mnuB14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.mnuB15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem376 = New System.Windows.Forms.MenuItem()
        Me.MenuItem377 = New System.Windows.Forms.MenuItem()
        Me.MenuItem378 = New System.Windows.Forms.MenuItem()
        Me.MenuItem379 = New System.Windows.Forms.MenuItem()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem215 = New System.Windows.Forms.MenuItem()
        Me.mnuCaja = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem61 = New System.Windows.Forms.MenuItem()
        Me.MenuItem62 = New System.Windows.Forms.MenuItem()
        Me.MenuItem63 = New System.Windows.Forms.MenuItem()
        Me.MenuItem67 = New System.Windows.Forms.MenuItem()
        Me.MenuItem136 = New System.Windows.Forms.MenuItem()
        Me.MenuItem141 = New System.Windows.Forms.MenuItem()
        Me.MenuItem69 = New System.Windows.Forms.MenuItem()
        Me.MenuItem170 = New System.Windows.Forms.MenuItem()
        Me.MenuItem265 = New System.Windows.Forms.MenuItem()
        Me.MenuItem631 = New System.Windows.Forms.MenuItem()
        Me.MenuItem632 = New System.Windows.Forms.MenuItem()
        Me.MenuItem633 = New System.Windows.Forms.MenuItem()
        Me.MenuItem671 = New System.Windows.Forms.MenuItem()
        Me.MenuItem267 = New System.Windows.Forms.MenuItem()
        Me.MenuItem683 = New System.Windows.Forms.MenuItem()
        Me.MenuItem73 = New System.Windows.Forms.MenuItem()
        Me.MenuItem74 = New System.Windows.Forms.MenuItem()
        Me.MenuItem143 = New System.Windows.Forms.MenuItem()
        Me.MenuItem144 = New System.Windows.Forms.MenuItem()
        Me.MenuItem90 = New System.Windows.Forms.MenuItem()
        Me.MenuItem538 = New System.Windows.Forms.MenuItem()
        Me.MenuItem542 = New System.Windows.Forms.MenuItem()
        Me.MenuItem543 = New System.Windows.Forms.MenuItem()
        Me.MenuItem544 = New System.Windows.Forms.MenuItem()
        Me.MenuItem630 = New System.Windows.Forms.MenuItem()
        Me.MenuItem70 = New System.Windows.Forms.MenuItem()
        Me.MenuItem429 = New System.Windows.Forms.MenuItem()
        Me.MenuItem434 = New System.Windows.Forms.MenuItem()
        Me.MenuItem430 = New System.Windows.Forms.MenuItem()
        Me.MenuItem431 = New System.Windows.Forms.MenuItem()
        Me.MenuItem623 = New System.Windows.Forms.MenuItem()
        Me.MenuItem634 = New System.Windows.Forms.MenuItem()
        Me.MenuItem635 = New System.Windows.Forms.MenuItem()
        Me.MenuItem684 = New System.Windows.Forms.MenuItem()
        Me.MenuItem636 = New System.Windows.Forms.MenuItem()
        Me.MenuItem135 = New System.Windows.Forms.MenuItem()
        Me.MenuItem145 = New System.Windows.Forms.MenuItem()
        Me.MenuItem161 = New System.Windows.Forms.MenuItem()
        Me.MenuItem164 = New System.Windows.Forms.MenuItem()
        Me.MenuItem264 = New System.Windows.Forms.MenuItem()
        Me.MenuItem108 = New System.Windows.Forms.MenuItem()
        Me.MenuItem278 = New System.Windows.Forms.MenuItem()
        Me.MenuItem279 = New System.Windows.Forms.MenuItem()
        Me.MenuItem280 = New System.Windows.Forms.MenuItem()
        Me.MenuItem327 = New System.Windows.Forms.MenuItem()
        Me.MenuItem354 = New System.Windows.Forms.MenuItem()
        Me.MenuItem358 = New System.Windows.Forms.MenuItem()
        Me.MenuItem359 = New System.Windows.Forms.MenuItem()
        Me.MenuItem451 = New System.Windows.Forms.MenuItem()
        Me.MenuItem509 = New System.Windows.Forms.MenuItem()
        Me.MenuItem577 = New System.Windows.Forms.MenuItem()
        Me.MenuItem579 = New System.Windows.Forms.MenuItem()
        Me.MenuItem580 = New System.Windows.Forms.MenuItem()
        Me.MenuItem581 = New System.Windows.Forms.MenuItem()
        Me.MenuItem663 = New System.Windows.Forms.MenuItem()
        Me.MenuItem664 = New System.Windows.Forms.MenuItem()
        Me.MenuItem665 = New System.Windows.Forms.MenuItem()
        Me.MenuItem666 = New System.Windows.Forms.MenuItem()
        Me.MenuItem652 = New System.Windows.Forms.MenuItem()
        Me.MenuItem380 = New System.Windows.Forms.MenuItem()
        Me.MenuItem381 = New System.Windows.Forms.MenuItem()
        Me.MenuItem382 = New System.Windows.Forms.MenuItem()
        Me.MenuItem383 = New System.Windows.Forms.MenuItem()
        Me.stbMain = New System.Windows.Forms.StatusBar()
        Me.sbp1 = New System.Windows.Forms.StatusBarPanel()
        Me.sbp2 = New System.Windows.Forms.StatusBarPanel()
        Me.mnuCobranza = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem114 = New System.Windows.Forms.MenuItem()
        Me.MenuItem116 = New System.Windows.Forms.MenuItem()
        Me.MenuItem117 = New System.Windows.Forms.MenuItem()
        Me.MenuItem118 = New System.Windows.Forms.MenuItem()
        Me.MenuItem115 = New System.Windows.Forms.MenuItem()
        Me.MenuItem119 = New System.Windows.Forms.MenuItem()
        Me.MenuItem120 = New System.Windows.Forms.MenuItem()
        Me.MenuItem121 = New System.Windows.Forms.MenuItem()
        Me.MenuItem171 = New System.Windows.Forms.MenuItem()
        Me.MenuItem129 = New System.Windows.Forms.MenuItem()
        Me.MenuItem122 = New System.Windows.Forms.MenuItem()
        Me.MenuItem127 = New System.Windows.Forms.MenuItem()
        Me.MenuItem128 = New System.Windows.Forms.MenuItem()
        Me.MenuItem147 = New System.Windows.Forms.MenuItem()
        Me.MenuItem413 = New System.Windows.Forms.MenuItem()
        Me.MenuItem460 = New System.Windows.Forms.MenuItem()
        Me.MenuItem463 = New System.Windows.Forms.MenuItem()
        Me.MenuItem134 = New System.Windows.Forms.MenuItem()
        Me.MenuItem131 = New System.Windows.Forms.MenuItem()
        Me.MenuItem68 = New System.Windows.Forms.MenuItem()
        Me.MenuItem102 = New System.Windows.Forms.MenuItem()
        Me.MenuItem603 = New System.Windows.Forms.MenuItem()
        Me.MenuItem604 = New System.Windows.Forms.MenuItem()
        Me.MenuItem333 = New System.Windows.Forms.MenuItem()
        Me.MenuItem334 = New System.Windows.Forms.MenuItem()
        Me.MenuItem133 = New System.Windows.Forms.MenuItem()
        Me.MenuItem181 = New System.Windows.Forms.MenuItem()
        Me.MenuItem186 = New System.Windows.Forms.MenuItem()
        Me.MenuItem187 = New System.Windows.Forms.MenuItem()
        Me.MenuItem188 = New System.Windows.Forms.MenuItem()
        Me.MenuItem508 = New System.Windows.Forms.MenuItem()
        Me.MenuItem527 = New System.Windows.Forms.MenuItem()
        Me.MenuItem528 = New System.Windows.Forms.MenuItem()
        Me.MenuItem529 = New System.Windows.Forms.MenuItem()
        Me.MenuItem533 = New System.Windows.Forms.MenuItem()
        Me.MenuItem605 = New System.Windows.Forms.MenuItem()
        Me.MenuItem419 = New System.Windows.Forms.MenuItem()
        Me.MenuItem420 = New System.Windows.Forms.MenuItem()
        Me.MenuItem421 = New System.Windows.Forms.MenuItem()
        Me.MenuItem422 = New System.Windows.Forms.MenuItem()
        Me.MenuItem424 = New System.Windows.Forms.MenuItem()
        Me.MenuItem442 = New System.Windows.Forms.MenuItem()
        Me.MenuItem444 = New System.Windows.Forms.MenuItem()
        Me.MenuItem446 = New System.Windows.Forms.MenuItem()
        Me.MenuItem448 = New System.Windows.Forms.MenuItem()
        Me.MenuItem449 = New System.Windows.Forms.MenuItem()
        Me.MenuItem450 = New System.Windows.Forms.MenuItem()
        Me.MenuItem312 = New System.Windows.Forms.MenuItem()
        Me.MenuItem452 = New System.Windows.Forms.MenuItem()
        Me.MenuItem453 = New System.Windows.Forms.MenuItem()
        Me.MenuItem454 = New System.Windows.Forms.MenuItem()
        Me.MenuItem540 = New System.Windows.Forms.MenuItem()
        Me.MenuItem548 = New System.Windows.Forms.MenuItem()
        Me.MenuItem455 = New System.Windows.Forms.MenuItem()
        Me.MenuItem475 = New System.Windows.Forms.MenuItem()
        Me.MenuItem476 = New System.Windows.Forms.MenuItem()
        Me.MenuItem477 = New System.Windows.Forms.MenuItem()
        Me.MenuItem478 = New System.Windows.Forms.MenuItem()
        Me.MenuItem80 = New System.Windows.Forms.MenuItem()
        Me.MenuItem81 = New System.Windows.Forms.MenuItem()
        Me.MenuItem512 = New System.Windows.Forms.MenuItem()
        Me.MenuItem513 = New System.Windows.Forms.MenuItem()
        Me.MenuItem514 = New System.Windows.Forms.MenuItem()
        Me.MenuItem335 = New System.Windows.Forms.MenuItem()
        Me.MenuItem384 = New System.Windows.Forms.MenuItem()
        Me.MenuItem385 = New System.Windows.Forms.MenuItem()
        Me.MenuItem386 = New System.Windows.Forms.MenuItem()
        Me.MenuItem387 = New System.Windows.Forms.MenuItem()
        Me.mnuPlanilla = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem194 = New System.Windows.Forms.MenuItem()
        Me.mnuInicioSesion = New System.Windows.Forms.MenuItem()
        Me.mnuSalir = New System.Windows.Forms.MenuItem()
        Me.MenuItem159 = New System.Windows.Forms.MenuItem()
        Me.MenuItem195 = New System.Windows.Forms.MenuItem()
        Me.MenuItem196 = New System.Windows.Forms.MenuItem()
        Me.MenuItem197 = New System.Windows.Forms.MenuItem()
        Me.MenuItem198 = New System.Windows.Forms.MenuItem()
        Me.MenuItem199 = New System.Windows.Forms.MenuItem()
        Me.MenuItem200 = New System.Windows.Forms.MenuItem()
        Me.MenuItem201 = New System.Windows.Forms.MenuItem()
        Me.MenuItem202 = New System.Windows.Forms.MenuItem()
        Me.MenuItem203 = New System.Windows.Forms.MenuItem()
        Me.MenuItem204 = New System.Windows.Forms.MenuItem()
        Me.MenuItem205 = New System.Windows.Forms.MenuItem()
        Me.MenuItem206 = New System.Windows.Forms.MenuItem()
        Me.MenuItem214 = New System.Windows.Forms.MenuItem()
        Me.MenuItem262 = New System.Windows.Forms.MenuItem()
        Me.MenuItem207 = New System.Windows.Forms.MenuItem()
        Me.MenuItem208 = New System.Windows.Forms.MenuItem()
        Me.MenuItem209 = New System.Windows.Forms.MenuItem()
        Me.MenuItem210 = New System.Windows.Forms.MenuItem()
        Me.MenuItem211 = New System.Windows.Forms.MenuItem()
        Me.MenuItem212 = New System.Windows.Forms.MenuItem()
        Me.MenuItem213 = New System.Windows.Forms.MenuItem()
        Me.MenuItem586 = New System.Windows.Forms.MenuItem()
        Me.MenuItem217 = New System.Windows.Forms.MenuItem()
        Me.MenuItem218 = New System.Windows.Forms.MenuItem()
        Me.MenuItem219 = New System.Windows.Forms.MenuItem()
        Me.MenuItem220 = New System.Windows.Forms.MenuItem()
        Me.MenuItem221 = New System.Windows.Forms.MenuItem()
        Me.MenuItem222 = New System.Windows.Forms.MenuItem()
        Me.MenuItem225 = New System.Windows.Forms.MenuItem()
        Me.MenuItem226 = New System.Windows.Forms.MenuItem()
        Me.MenuItem126 = New System.Windows.Forms.MenuItem()
        Me.MenuItem130 = New System.Windows.Forms.MenuItem()
        Me.MenuItem232 = New System.Windows.Forms.MenuItem()
        Me.MenuItem233 = New System.Windows.Forms.MenuItem()
        Me.MenuItem481 = New System.Windows.Forms.MenuItem()
        Me.MenuItem486 = New System.Windows.Forms.MenuItem()
        Me.MenuItem487 = New System.Windows.Forms.MenuItem()
        Me.MenuItem237 = New System.Windows.Forms.MenuItem()
        Me.MenuItem491 = New System.Windows.Forms.MenuItem()
        Me.MenuItem236 = New System.Windows.Forms.MenuItem()
        Me.MenuItem234 = New System.Windows.Forms.MenuItem()
        Me.MenuItem240 = New System.Windows.Forms.MenuItem()
        Me.MenuItem242 = New System.Windows.Forms.MenuItem()
        Me.MenuItem490 = New System.Windows.Forms.MenuItem()
        Me.MenuItem235 = New System.Windows.Forms.MenuItem()
        Me.MenuItem241 = New System.Windows.Forms.MenuItem()
        Me.MenuItem239 = New System.Windows.Forms.MenuItem()
        Me.MenuItem243 = New System.Windows.Forms.MenuItem()
        Me.MenuItem492 = New System.Windows.Forms.MenuItem()
        Me.MenuItem238 = New System.Windows.Forms.MenuItem()
        Me.MenuItem493 = New System.Windows.Forms.MenuItem()
        Me.MenuItem494 = New System.Windows.Forms.MenuItem()
        Me.MenuItem495 = New System.Windows.Forms.MenuItem()
        Me.MenuItem496 = New System.Windows.Forms.MenuItem()
        Me.MenuItem590 = New System.Windows.Forms.MenuItem()
        Me.MenuItem621 = New System.Windows.Forms.MenuItem()
        Me.MenuItem626 = New System.Windows.Forms.MenuItem()
        Me.MenuItem627 = New System.Windows.Forms.MenuItem()
        Me.MenuItem628 = New System.Windows.Forms.MenuItem()
        Me.MenuItem388 = New System.Windows.Forms.MenuItem()
        Me.MenuItem389 = New System.Windows.Forms.MenuItem()
        Me.MenuItem390 = New System.Windows.Forms.MenuItem()
        Me.MenuItem391 = New System.Windows.Forms.MenuItem()
        Me.mnuGarantias = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem76 = New System.Windows.Forms.MenuItem()
        Me.MenuItem77 = New System.Windows.Forms.MenuItem()
        Me.MenuItem78 = New System.Windows.Forms.MenuItem()
        Me.MenuItem252 = New System.Windows.Forms.MenuItem()
        Me.MenuItem255 = New System.Windows.Forms.MenuItem()
        Me.MenuItem320 = New System.Windows.Forms.MenuItem()
        Me.MenuItem415 = New System.Windows.Forms.MenuItem()
        Me.MenuItem510 = New System.Windows.Forms.MenuItem()
        Me.MenuItem525 = New System.Windows.Forms.MenuItem()
        Me.MenuItem132 = New System.Windows.Forms.MenuItem()
        Me.MenuItem216 = New System.Windows.Forms.MenuItem()
        Me.MenuItem488 = New System.Windows.Forms.MenuItem()
        Me.MenuItem489 = New System.Windows.Forms.MenuItem()
        Me.MenuItem443 = New System.Windows.Forms.MenuItem()
        Me.MenuItem447 = New System.Windows.Forms.MenuItem()
        Me.MenuItem545 = New System.Windows.Forms.MenuItem()
        Me.MenuItem546 = New System.Windows.Forms.MenuItem()
        Me.MenuItem547 = New System.Windows.Forms.MenuItem()
        Me.MenuItem223 = New System.Windows.Forms.MenuItem()
        Me.MenuItem224 = New System.Windows.Forms.MenuItem()
        Me.MenuItem562 = New System.Windows.Forms.MenuItem()
        Me.MenuItem563 = New System.Windows.Forms.MenuItem()
        Me.MenuItem564 = New System.Windows.Forms.MenuItem()
        Me.MenuItem565 = New System.Windows.Forms.MenuItem()
        Me.MenuItem392 = New System.Windows.Forms.MenuItem()
        Me.MenuItem393 = New System.Windows.Forms.MenuItem()
        Me.MenuItem394 = New System.Windows.Forms.MenuItem()
        Me.MenuItem395 = New System.Windows.Forms.MenuItem()
        Me.mnuGerenciales = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem79 = New System.Windows.Forms.MenuItem()
        Me.MenuItem172 = New System.Windows.Forms.MenuItem()
        Me.MenuItem191 = New System.Windows.Forms.MenuItem()
        Me.MenuItem228 = New System.Windows.Forms.MenuItem()
        Me.MenuItem244 = New System.Windows.Forms.MenuItem()
        Me.MenuItem245 = New System.Windows.Forms.MenuItem()
        Me.MenuItem258 = New System.Windows.Forms.MenuItem()
        Me.MenuItem259 = New System.Windows.Forms.MenuItem()
        Me.MenuItem260 = New System.Windows.Forms.MenuItem()
        Me.MenuItem261 = New System.Windows.Forms.MenuItem()
        Me.MenuItem329 = New System.Windows.Forms.MenuItem()
        Me.MenuItem330 = New System.Windows.Forms.MenuItem()
        Me.MenuItem331 = New System.Windows.Forms.MenuItem()
        Me.MenuItem535 = New System.Windows.Forms.MenuItem()
        Me.MenuItem536 = New System.Windows.Forms.MenuItem()
        Me.MenuItem537 = New System.Windows.Forms.MenuItem()
        Me.MenuItem539 = New System.Windows.Forms.MenuItem()
        Me.MenuItem541 = New System.Windows.Forms.MenuItem()
        Me.MenuItem550 = New System.Windows.Forms.MenuItem()
        Me.MenuItem554 = New System.Windows.Forms.MenuItem()
        Me.MenuItem160 = New System.Windows.Forms.MenuItem()
        Me.MenuItem268 = New System.Windows.Forms.MenuItem()
        Me.MenuItem269 = New System.Windows.Forms.MenuItem()
        Me.MenuItem553 = New System.Windows.Forms.MenuItem()
        Me.MenuItem555 = New System.Windows.Forms.MenuItem()
        Me.MenuItem396 = New System.Windows.Forms.MenuItem()
        Me.MenuItem397 = New System.Windows.Forms.MenuItem()
        Me.MenuItem398 = New System.Windows.Forms.MenuItem()
        Me.MenuItem399 = New System.Windows.Forms.MenuItem()
        Me.mnuActivoFijo = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem227 = New System.Windows.Forms.MenuItem()
        Me.MenuItem229 = New System.Windows.Forms.MenuItem()
        Me.MenuItem230 = New System.Windows.Forms.MenuItem()
        Me.MenuItem231 = New System.Windows.Forms.MenuItem()
        Me.MenuItem246 = New System.Windows.Forms.MenuItem()
        Me.MenuItem248 = New System.Windows.Forms.MenuItem()
        Me.MenuItem247 = New System.Windows.Forms.MenuItem()
        Me.MenuItem249 = New System.Windows.Forms.MenuItem()
        Me.MenuItem253 = New System.Windows.Forms.MenuItem()
        Me.MenuItem251 = New System.Windows.Forms.MenuItem()
        Me.MenuItem254 = New System.Windows.Forms.MenuItem()
        Me.MenuItem256 = New System.Windows.Forms.MenuItem()
        Me.MenuItem257 = New System.Windows.Forms.MenuItem()
        Me.MenuItem250 = New System.Windows.Forms.MenuItem()
        Me.MenuItem156 = New System.Windows.Forms.MenuItem()
        Me.MenuItem157 = New System.Windows.Forms.MenuItem()
        Me.MenuItem459 = New System.Windows.Forms.MenuItem()
        Me.MenuItem461 = New System.Windows.Forms.MenuItem()
        Me.MenuItem462 = New System.Windows.Forms.MenuItem()
        Me.MenuItem497 = New System.Windows.Forms.MenuItem()
        Me.MenuItem498 = New System.Windows.Forms.MenuItem()
        Me.MenuItem499 = New System.Windows.Forms.MenuItem()
        Me.MenuItem500 = New System.Windows.Forms.MenuItem()
        Me.MenuItem501 = New System.Windows.Forms.MenuItem()
        Me.MenuItem502 = New System.Windows.Forms.MenuItem()
        Me.MenuItem503 = New System.Windows.Forms.MenuItem()
        Me.MenuItem504 = New System.Windows.Forms.MenuItem()
        Me.MenuItem505 = New System.Windows.Forms.MenuItem()
        Me.MenuItem506 = New System.Windows.Forms.MenuItem()
        Me.MenuItem507 = New System.Windows.Forms.MenuItem()
        Me.MenuItem400 = New System.Windows.Forms.MenuItem()
        Me.MenuItem401 = New System.Windows.Forms.MenuItem()
        Me.MenuItem402 = New System.Windows.Forms.MenuItem()
        Me.MenuItem403 = New System.Windows.Forms.MenuItem()
        Me.mnuGeneral = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem270 = New System.Windows.Forms.MenuItem()
        Me.MenuItem271 = New System.Windows.Forms.MenuItem()
        Me.MenuItem272 = New System.Windows.Forms.MenuItem()
        Me.MenuItem273 = New System.Windows.Forms.MenuItem()
        Me.MenuItem274 = New System.Windows.Forms.MenuItem()
        Me.MenuItem275 = New System.Windows.Forms.MenuItem()
        Me.MenuItem276 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem277 = New System.Windows.Forms.MenuItem()
        Me.MenuItem515 = New System.Windows.Forms.MenuItem()
        Me.MenuItem516 = New System.Windows.Forms.MenuItem()
        Me.MenuItem517 = New System.Windows.Forms.MenuItem()
        Me.MenuItem518 = New System.Windows.Forms.MenuItem()
        Me.MenuItem519 = New System.Windows.Forms.MenuItem()
        Me.MenuItem520 = New System.Windows.Forms.MenuItem()
        Me.MenuItem521 = New System.Windows.Forms.MenuItem()
        Me.MenuItem522 = New System.Windows.Forms.MenuItem()
        Me.MenuItem523 = New System.Windows.Forms.MenuItem()
        Me.MenuItem153 = New System.Windows.Forms.MenuItem()
        Me.MenuItem534 = New System.Windows.Forms.MenuItem()
        Me.MenuItem483 = New System.Windows.Forms.MenuItem()
        Me.MenuItem484 = New System.Windows.Forms.MenuItem()
        Me.MenuItem485 = New System.Windows.Forms.MenuItem()
        Me.MenuItem667 = New System.Windows.Forms.MenuItem()
        Me.MenuItem668 = New System.Windows.Forms.MenuItem()
        Me.MenuItem669 = New System.Windows.Forms.MenuItem()
        Me.MenuItem336 = New System.Windows.Forms.MenuItem()
        Me.MenuItem337 = New System.Windows.Forms.MenuItem()
        Me.MenuItem404 = New System.Windows.Forms.MenuItem()
        Me.MenuItem405 = New System.Windows.Forms.MenuItem()
        Me.MenuItem406 = New System.Windows.Forms.MenuItem()
        Me.MenuItem407 = New System.Windows.Forms.MenuItem()
        Me.MenuItem653 = New System.Windows.Forms.MenuItem()
        Me.MenuItem654 = New System.Windows.Forms.MenuItem()
        CType(Me.sbp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuInicio
        '
        Me.mnuInicio.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MdiList = True
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem5, Me.MenuItem4})
        Me.MenuItem1.Text = "&Inicio"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "A1 - Inicio de Sesión"
        '
        'MenuItem5
        '
        Me.MenuItem5.Enabled = False
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "A3 - &Salir"
        '
        'mnuContabilidad
        '
        Me.mnuContabilidad.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7, Me.MenuItem12, Me.MenuItem11, Me.MenuItem611, Me.MenuItem19, Me.MenuItem23, Me.MenuItem24, Me.MenuItem408})
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuA1, Me.mnuA2, Me.mnuA3})
        Me.MenuItem6.Text = "&Inicio"
        '
        'mnuA1
        '
        Me.mnuA1.Index = 0
        Me.mnuA1.Text = "A1 - Cerrar Sesión"
        '
        'mnuA2
        '
        Me.mnuA2.Index = 1
        Me.mnuA2.Text = "A2 - Cargar Aplicación"
        '
        'mnuA3
        '
        Me.mnuA3.Index = 2
        Me.mnuA3.Text = "A3 - &Salir"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem30, Me.MenuItem35, Me.MenuItem40, Me.MenuItem93})
        Me.MenuItem7.Text = "Bancos"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 0
        Me.MenuItem30.Text = "J61 - Maestro de Bancos"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 1
        Me.MenuItem35.Text = "J62 - Maestro de Cuentas de Banco"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 2
        Me.MenuItem40.Text = "J63 - Administración de  Cheques"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 3
        Me.MenuItem93.Text = "J64 - Traslado Partidas Cheques"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem326, Me.MenuItem606, Me.MenuItem617})
        Me.MenuItem12.Text = "Boveda"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Text = "J91 - Catálogo Transacciones Bóveda"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "J92 - Mantenimiento Transacciones de Bóveda por Sucursal"
        '
        'MenuItem326
        '
        Me.MenuItem326.Index = 2
        Me.MenuItem326.Text = "J93 - Administración Bóveda"
        '
        'MenuItem606
        '
        Me.MenuItem606.Index = 3
        Me.MenuItem606.Text = "J94 - Movimientos Bóveda"
        '
        'MenuItem617
        '
        Me.MenuItem617.Index = 4
        Me.MenuItem617.Text = "J95 - Remesar Cheques a Banco"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 3
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem473})
        Me.MenuItem11.Text = "&Catálogos"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem17, Me.MenuItem18})
        Me.MenuItem15.Text = "J10 - Contable"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Text = "J101 - Catálogo"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.Text = "J102 - Centro Costos"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "J103 - Centro de Beneficios"
        '
        'MenuItem473
        '
        Me.MenuItem473.Index = 1
        Me.MenuItem473.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem524, Me.MenuItem575, Me.MenuItem576})
        Me.MenuItem473.Text = "J11 - Niveles"
        '
        'MenuItem524
        '
        Me.MenuItem524.Index = 0
        Me.MenuItem524.Text = "J111 - Contables"
        '
        'MenuItem575
        '
        Me.MenuItem575.Index = 1
        Me.MenuItem575.Text = "J112 - Centros de Costos"
        '
        'MenuItem576
        '
        Me.MenuItem576.Index = 2
        Me.MenuItem576.Text = "J113 - Centros de Beneficios"
        '
        'MenuItem611
        '
        Me.MenuItem611.Index = 4
        Me.MenuItem611.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem612, Me.MenuItem637, Me.MenuItem638})
        Me.MenuItem611.Text = "Compras"
        '
        'MenuItem612
        '
        Me.MenuItem612.Index = 0
        Me.MenuItem612.Text = "J81 - Administración de Proveedores"
        '
        'MenuItem637
        '
        Me.MenuItem637.Index = 1
        Me.MenuItem637.Text = "J82 - Compras"
        '
        'MenuItem638
        '
        Me.MenuItem638.Index = 2
        Me.MenuItem638.Text = "J83 - Libro de Compras"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 5
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem96, Me.MenuItem325})
        Me.MenuItem19.Text = "Partidas"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Text = "J31 - Mantenimiento Partidas"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 1
        Me.MenuItem96.Text = "J32 - Mantenimiento Partidas Transferencias"
        '
        'MenuItem325
        '
        Me.MenuItem325.Index = 2
        Me.MenuItem325.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem353, Me.MenuItem482, Me.MenuItem567, Me.MenuItem568, Me.MenuItem618, Me.MenuItem619, Me.MenuItem138, Me.MenuItem620})
        Me.MenuItem325.Text = "J33 - Partidas Integración"
        '
        'MenuItem353
        '
        Me.MenuItem353.Index = 0
        Me.MenuItem353.Text = "J331 - Provisión de Intereses Ahorros"
        '
        'MenuItem482
        '
        Me.MenuItem482.Index = 1
        Me.MenuItem482.Text = "J332 - Pago Intereses Ahorros"
        '
        'MenuItem567
        '
        Me.MenuItem567.Index = 2
        Me.MenuItem567.Text = "J333 - Corte de Caja"
        '
        'MenuItem568
        '
        Me.MenuItem568.Index = 3
        Me.MenuItem568.Text = "J334 - Liquidación de Aspirantes"
        '
        'MenuItem618
        '
        Me.MenuItem618.Index = 4
        Me.MenuItem618.Text = "J335 - Renuncia de Asociados"
        '
        'MenuItem619
        '
        Me.MenuItem619.Index = 5
        Me.MenuItem619.Text = "J336 - Partida Intereses pagados DPF"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 6
        Me.MenuItem138.Text = "J337 - Parámetros Partidas de Integración"
        '
        'MenuItem620
        '
        Me.MenuItem620.Index = 7
        Me.MenuItem620.Text = "J338 - Aplicaciones Valor Fecha"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 6
        Me.MenuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem123, Me.MenuItem125, Me.MenuItem192, Me.MenuItem414, Me.MenuItem165})
        Me.MenuItem23.Text = "Procesos"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Text = "J41 - Posteo Mensual - Procesar Saldos"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 1
        Me.MenuItem123.Text = "J42 - Generación Partida de &Cierre"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 2
        Me.MenuItem125.Text = "J43 - &Asistente Apertura Ejercicio Contable"
        '
        'MenuItem192
        '
        Me.MenuItem192.Index = 3
        Me.MenuItem192.Text = "J44 - Au&torización de Partidas"
        '
        'MenuItem414
        '
        Me.MenuItem414.Index = 4
        Me.MenuItem414.Text = "J46 - Retiro de Asociados"
        '
        'MenuItem165
        '
        Me.MenuItem165.Index = 5
        Me.MenuItem165.Text = "J47 - Generar Cierre Mensual"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 7
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem285, Me.MenuItem184, Me.MenuItem283, Me.MenuItem27, Me.MenuItem299})
        Me.MenuItem24.Text = "Reportes"
        '
        'MenuItem285
        '
        Me.MenuItem285.Index = 0
        Me.MenuItem285.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem286, Me.MenuItem287, Me.MenuItem288, Me.MenuItem289, Me.MenuItem290, Me.MenuItem291, Me.MenuItem292, Me.MenuItem293, Me.MenuItem294, Me.MenuItem569, Me.MenuItem570, Me.MenuItem571, Me.MenuItem658})
        Me.MenuItem285.Text = "J51 - Reportes Contables"
        '
        'MenuItem286
        '
        Me.MenuItem286.Index = 0
        Me.MenuItem286.Text = "J510 - Balance de Comprobación"
        '
        'MenuItem287
        '
        Me.MenuItem287.Index = 1
        Me.MenuItem287.Text = "J511 - Balance General"
        '
        'MenuItem288
        '
        Me.MenuItem288.Index = 2
        Me.MenuItem288.Text = "J512 - Catálogo de Cuentas"
        '
        'MenuItem289
        '
        Me.MenuItem289.Index = 3
        Me.MenuItem289.Text = "J513 - Partidas Contables"
        '
        'MenuItem290
        '
        Me.MenuItem290.Index = 4
        Me.MenuItem290.Text = "J514 - Estado de Resultados"
        '
        'MenuItem291
        '
        Me.MenuItem291.Index = 5
        Me.MenuItem291.Text = "J515 - Libro Auxiliar de Mayor"
        '
        'MenuItem292
        '
        Me.MenuItem292.Index = 6
        Me.MenuItem292.Text = "J516 - Libro Diario Mayor"
        '
        'MenuItem293
        '
        Me.MenuItem293.Index = 7
        Me.MenuItem293.Text = "J517 - Cheques Emitidos"
        '
        'MenuItem294
        '
        Me.MenuItem294.Index = 8
        Me.MenuItem294.Text = "J518 - Movimientos por Cuenta"
        '
        'MenuItem569
        '
        Me.MenuItem569.Index = 9
        Me.MenuItem569.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem639, Me.MenuItem640})
        Me.MenuItem569.Text = "J519 - Libro Ventas"
        '
        'MenuItem639
        '
        Me.MenuItem639.Index = 0
        Me.MenuItem639.Text = "J5191 - Resumen Libro de Ventas"
        '
        'MenuItem640
        '
        Me.MenuItem640.Index = 1
        Me.MenuItem640.Text = "J5192 - Detalle Libro de Ventas"
        '
        'MenuItem570
        '
        Me.MenuItem570.Index = 10
        Me.MenuItem570.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem582, Me.MenuItem583})
        Me.MenuItem570.Text = "J51A - Diferencias Contabilidad - Sistema"
        '
        'MenuItem582
        '
        Me.MenuItem582.Index = 0
        Me.MenuItem582.Text = "J51A1 - Ahorro, Aportaciones, DPF"
        '
        'MenuItem583
        '
        Me.MenuItem583.Index = 1
        Me.MenuItem583.Text = "J51A2 - Préstamos"
        '
        'MenuItem571
        '
        Me.MenuItem571.Index = 11
        Me.MenuItem571.Text = "J51B - Disponibilidad"
        '
        'MenuItem658
        '
        Me.MenuItem658.Index = 12
        Me.MenuItem658.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem659, Me.MenuItem660, Me.MenuItem662})
        Me.MenuItem658.Text = "J51D - Impuestos"
        '
        'MenuItem659
        '
        Me.MenuItem659.Index = 0
        Me.MenuItem659.Text = "J51D1 - Impuesto Operaciones Financieras"
        '
        'MenuItem660
        '
        Me.MenuItem660.Index = 1
        Me.MenuItem660.Text = "J51D2 - Impuesto Control de la Liquidez"
        '
        'MenuItem662
        '
        Me.MenuItem662.Index = 2
        Me.MenuItem662.Text = "J51D3 - Impuesto Ahorros Mayores a 25000"
        '
        'MenuItem184
        '
        Me.MenuItem184.Index = 1
        Me.MenuItem184.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem343, Me.MenuItem344, Me.MenuItem352, Me.MenuItem183})
        Me.MenuItem184.Text = "J55 - Reportes Boveda"
        '
        'MenuItem343
        '
        Me.MenuItem343.Index = 0
        Me.MenuItem343.Text = "J551 - Estado de Caja Bóveda"
        '
        'MenuItem344
        '
        Me.MenuItem344.Index = 1
        Me.MenuItem344.Text = "J552 - Movimientos de Boveda"
        '
        'MenuItem352
        '
        Me.MenuItem352.Index = 2
        Me.MenuItem352.Text = "J553 - Remesas a Banco"
        '
        'MenuItem183
        '
        Me.MenuItem183.Index = 3
        Me.MenuItem183.Text = "J554- Remesar Cheques a Banco"
        '
        'MenuItem283
        '
        Me.MenuItem283.Index = 2
        Me.MenuItem283.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem284, Me.MenuItem309, Me.MenuItem297, Me.MenuItem302, Me.MenuItem304, Me.MenuItem310, Me.MenuItem311, Me.MenuItem439, Me.MenuItem445, Me.MenuItem466, Me.MenuItem588, Me.MenuItem589, Me.MenuItem599, Me.MenuItem607, Me.MenuItem613, Me.MenuItem622})
        Me.MenuItem283.Text = "J52 - Reportes Préstamos"
        '
        'MenuItem284
        '
        Me.MenuItem284.Index = 0
        Me.MenuItem284.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem474, Me.MenuItem479})
        Me.MenuItem284.Text = "J520 - Movimientos Diarios de Préstamos"
        '
        'MenuItem474
        '
        Me.MenuItem474.Index = 0
        Me.MenuItem474.Text = "J5200 - Abonos a Préstamos"
        '
        'MenuItem479
        '
        Me.MenuItem479.Index = 1
        Me.MenuItem479.Text = "J5201 - Cargos a Préstamos"
        '
        'MenuItem309
        '
        Me.MenuItem309.Index = 1
        Me.MenuItem309.Text = "J521 - Reportes de Tasas Activas"
        '
        'MenuItem297
        '
        Me.MenuItem297.Index = 2
        Me.MenuItem297.Text = "J522 - Saldos Préstamos para Aseguradora"
        '
        'MenuItem302
        '
        Me.MenuItem302.Index = 3
        Me.MenuItem302.Text = "J523 - Saldos Préstamos Administrativos"
        '
        'MenuItem304
        '
        Me.MenuItem304.Index = 4
        Me.MenuItem304.Text = "J524 - Saldos Préstamos Jurídicos"
        '
        'MenuItem310
        '
        Me.MenuItem310.Index = 5
        Me.MenuItem310.Text = "J525 - Saldos Préstamos por Tipo de Crédito"
        '
        'MenuItem311
        '
        Me.MenuItem311.Index = 6
        Me.MenuItem311.Text = "J526 - Saldos Préstamos por Tipo de Línea"
        '
        'MenuItem439
        '
        Me.MenuItem439.Index = 7
        Me.MenuItem439.Text = "J527 - Saldos Préstamos Cartera en Protesto"
        '
        'MenuItem445
        '
        Me.MenuItem445.Index = 8
        Me.MenuItem445.Text = "J528 - Saldos Préstamos Hipotecarios"
        '
        'MenuItem466
        '
        Me.MenuItem466.Index = 9
        Me.MenuItem466.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem467, Me.MenuItem468, Me.MenuItem469, Me.MenuItem470, Me.MenuItem471, Me.MenuItem530, Me.MenuItem531})
        Me.MenuItem466.Text = "J529 - Reportes de Préstamos"
        '
        'MenuItem467
        '
        Me.MenuItem467.Index = 0
        Me.MenuItem467.Text = "J5290 - Por Garantía"
        '
        'MenuItem468
        '
        Me.MenuItem468.Index = 1
        Me.MenuItem468.Text = "J5291 - Por Línea de Crédito"
        '
        'MenuItem469
        '
        Me.MenuItem469.Index = 2
        Me.MenuItem469.Text = "J5292 - Por Categorías"
        '
        'MenuItem470
        '
        Me.MenuItem470.Index = 3
        Me.MenuItem470.Text = "J5293 - Por Plazo"
        '
        'MenuItem471
        '
        Me.MenuItem471.Index = 4
        Me.MenuItem471.Text = "J5294 - Por Rango"
        '
        'MenuItem530
        '
        Me.MenuItem530.Index = 5
        Me.MenuItem530.Text = "J5295 - Refinanciados"
        '
        'MenuItem531
        '
        Me.MenuItem531.Index = 6
        Me.MenuItem531.Text = "J5296 - Con Pagaré y Letras"
        '
        'MenuItem588
        '
        Me.MenuItem588.Index = 10
        Me.MenuItem588.Text = "J52A - Saldos Préstamos por Vencer"
        '
        'MenuItem589
        '
        Me.MenuItem589.Index = 11
        Me.MenuItem589.Text = "J52B - Saldos Préstamos y Cuotas Vencidas"
        '
        'MenuItem599
        '
        Me.MenuItem599.Index = 12
        Me.MenuItem599.Text = "J52C - Saldos Préstamos Arreglos por Mora"
        '
        'MenuItem607
        '
        Me.MenuItem607.Index = 13
        Me.MenuItem607.Text = "J52D - Saldos Carteras Activas"
        '
        'MenuItem613
        '
        Me.MenuItem613.Index = 14
        Me.MenuItem613.Text = "J52E - Diferencias Cartera de Préstamos"
        '
        'MenuItem622
        '
        Me.MenuItem622.Index = 15
        Me.MenuItem622.Text = "J52F - Aplicaciones Valor Fecha por Sucursal"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 3
        Me.MenuItem27.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem100, Me.MenuItem295, Me.MenuItem296, Me.MenuItem298, Me.MenuItem306, Me.MenuItem64, Me.MenuItem591, Me.MenuItem592, Me.MenuItem608, Me.MenuItem614, Me.MenuItem649})
        Me.MenuItem27.Text = "J53 - Reportes Ahorros"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        Me.MenuItem28.Text = "J530 - Movimientos Diarios"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 1
        Me.MenuItem100.Text = "J531 - Saldos Cuentas de Aportación"
        '
        'MenuItem295
        '
        Me.MenuItem295.Index = 2
        Me.MenuItem295.Text = "J532 - Saldos Cuentas de Ahorro"
        '
        'MenuItem296
        '
        Me.MenuItem296.Index = 3
        Me.MenuItem296.Text = "J533 - Saldos Depósitos a Plazo Fijo"
        '
        'MenuItem298
        '
        Me.MenuItem298.Index = 4
        Me.MenuItem298.Text = "J534 - Reporte de Intereses por Asociado"
        '
        'MenuItem306
        '
        Me.MenuItem306.Index = 5
        Me.MenuItem306.Text = "J535 - Saldos de Aportaciones Canceladas por período"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 6
        Me.MenuItem64.Text = "J536 - Reporte de Tasas Pasivas"
        '
        'MenuItem591
        '
        Me.MenuItem591.Index = 7
        Me.MenuItem591.Text = "J537 - Detalle Pago Intereses"
        '
        'MenuItem592
        '
        Me.MenuItem592.Index = 8
        Me.MenuItem592.Text = "J538 - Detalle Retención ISR"
        '
        'MenuItem608
        '
        Me.MenuItem608.Index = 9
        Me.MenuItem608.Text = "J539 - Saldos Carteras Pasivas"
        '
        'MenuItem614
        '
        Me.MenuItem614.Index = 10
        Me.MenuItem614.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem615, Me.MenuItem616})
        Me.MenuItem614.Text = "J53A - Diferencias de Cartera"
        '
        'MenuItem615
        '
        Me.MenuItem615.Index = 0
        Me.MenuItem615.Text = "J53A1 - Diferencia Cartera de Ahorros "
        '
        'MenuItem616
        '
        Me.MenuItem616.Index = 1
        Me.MenuItem616.Text = "J53A2 - Diferencia Cartera de Aportaciones"
        '
        'MenuItem649
        '
        Me.MenuItem649.Index = 11
        Me.MenuItem649.Text = "J53B - Intereses DPF Mundialista"
        '
        'MenuItem299
        '
        Me.MenuItem299.Index = 4
        Me.MenuItem299.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem300, Me.MenuItem301, Me.MenuItem84, Me.MenuItem472, Me.MenuItem526})
        Me.MenuItem299.Text = "J54 - Reportes Asociados"
        '
        'MenuItem300
        '
        Me.MenuItem300.Index = 0
        Me.MenuItem300.Text = "J540 - Saldos por Asociados"
        '
        'MenuItem301
        '
        Me.MenuItem301.Index = 1
        Me.MenuItem301.Text = "J541 - Cuentas de Asociados"
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 2
        Me.MenuItem84.Text = "J542 - Asociados en Mora"
        '
        'MenuItem472
        '
        Me.MenuItem472.Index = 3
        Me.MenuItem472.Text = "J543 - Liquidación de Asociado Retirado"
        '
        'MenuItem526
        '
        Me.MenuItem526.Index = 4
        Me.MenuItem526.Text = "J544 - Dividendos por pagar"
        '
        'MenuItem408
        '
        Me.MenuItem408.Index = 8
        Me.MenuItem408.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem409, Me.MenuItem410, Me.MenuItem411})
        Me.MenuItem408.Text = "Ve&ntana"
        '
        'MenuItem409
        '
        Me.MenuItem409.Index = 0
        Me.MenuItem409.Text = "Cascada"
        '
        'MenuItem410
        '
        Me.MenuItem410.Index = 1
        Me.MenuItem410.Text = "Vertical"
        '
        'MenuItem411
        '
        Me.MenuItem411.Index = 2
        Me.MenuItem411.Text = "Horizontal"
        '
        'mnuAsociados
        '
        Me.mnuAsociados.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem29, Me.MenuItem54, Me.MenuItem55, Me.MenuItem82, Me.MenuItem364})
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 0
        Me.MenuItem29.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem31, Me.MenuItem32, Me.MenuItem33})
        Me.MenuItem29.Text = "&Inicio"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 0
        Me.MenuItem31.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 1
        Me.MenuItem32.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 2
        Me.MenuItem33.Text = "A3 - &Salir"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 1
        Me.MenuItem54.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMAsociados, Me.mnuMReferencias, Me.mnuMBeneficiarios, Me.mnuMAspectosCoop, Me.MenuItem148, Me.MenuItem162, Me.MenuItem674})
        Me.MenuItem54.Text = "Maestros"
        '
        'mnuMAsociados
        '
        Me.mnuMAsociados.Index = 0
        Me.mnuMAsociados.Text = "C11 - Catálogo de Asociados"
        '
        'mnuMReferencias
        '
        Me.mnuMReferencias.Index = 1
        Me.mnuMReferencias.Text = "C12 - Mantenimiento Referencias"
        '
        'mnuMBeneficiarios
        '
        Me.mnuMBeneficiarios.Index = 2
        Me.mnuMBeneficiarios.Text = "C13 - Mantenimiento Beneficiarios"
        '
        'mnuMAspectosCoop
        '
        Me.mnuMAspectosCoop.Index = 3
        Me.mnuMAspectosCoop.Text = "C14 - Aspectos Cooperativos"
        '
        'MenuItem148
        '
        Me.MenuItem148.Index = 4
        Me.MenuItem148.Text = "C15 - Directivos"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 5
        Me.MenuItem162.Text = "C17 - Ti&pos de Cuota de Aspirante"
        '
        'MenuItem674
        '
        Me.MenuItem674.Index = 6
        Me.MenuItem674.Text = "C18 - Mantenimiento Lista Negra Interna"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 2
        Me.MenuItem55.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuControlRetiro, Me.mnuControlIngreso, Me.MenuItem321, Me.MenuItem549, Me.MenuItem681})
        Me.MenuItem55.Text = "Procesos"
        '
        'mnuControlRetiro
        '
        Me.mnuControlRetiro.Index = 0
        Me.mnuControlRetiro.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMSolRetiroVol, Me.mnuMProcRetiroVol, Me.mnuMInhabilitacion, Me.mnuMExclusion, Me.mnuMFallecimiento})
        Me.mnuControlRetiro.Text = "C21 - Control para Retiro de Asociados"
        '
        'mnuMSolRetiroVol
        '
        Me.mnuMSolRetiroVol.Index = 0
        Me.mnuMSolRetiroVol.Text = "C211 - Solicitud de Retiro Voluntario"
        '
        'mnuMProcRetiroVol
        '
        Me.mnuMProcRetiroVol.Index = 1
        Me.mnuMProcRetiroVol.Text = "C212 - Proceso de Retiro Voluntario"
        '
        'mnuMInhabilitacion
        '
        Me.mnuMInhabilitacion.Index = 2
        Me.mnuMInhabilitacion.Text = "C213 - Inhabilitación"
        '
        'mnuMExclusion
        '
        Me.mnuMExclusion.Index = 3
        Me.mnuMExclusion.Text = "C214 - Exclusión "
        '
        'mnuMFallecimiento
        '
        Me.mnuMFallecimiento.Index = 4
        Me.mnuMFallecimiento.Text = "C215 - Fallecimiento"
        '
        'mnuControlIngreso
        '
        Me.mnuControlIngreso.Index = 1
        Me.mnuControlIngreso.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMLibroAsoc, Me.mnuMEstadoAdmision, Me.MenuItem85})
        Me.mnuControlIngreso.Text = "C22 - Control para Ingreso de Asociados"
        '
        'mnuMLibroAsoc
        '
        Me.mnuMLibroAsoc.Index = 0
        Me.mnuMLibroAsoc.Text = "C221 - Control Libro Registro Asociados"
        '
        'mnuMEstadoAdmision
        '
        Me.mnuMEstadoAdmision.Index = 1
        Me.mnuMEstadoAdmision.Text = "C222 - Activación de Aspirante"
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 2
        Me.MenuItem85.Text = "C223 - Activación de Asociado"
        '
        'MenuItem321
        '
        Me.MenuItem321.Index = 2
        Me.MenuItem321.Text = "C23 - Proceso Inhabilitación de Asociados"
        '
        'MenuItem549
        '
        Me.MenuItem549.Index = 3
        Me.MenuItem549.Text = "C24 - Proceso Exclusión de Asociados"
        '
        'MenuItem681
        '
        Me.MenuItem681.Index = 4
        Me.MenuItem681.Text = "C25 - Cambio de DUI"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 3
        Me.MenuItem82.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem318, Me.MenuItem314, Me.MenuItem427, Me.MenuItem428, Me.MenuItem154, Me.MenuItem163, Me.MenuItem263, Me.MenuItem566, Me.MenuItem572, Me.MenuItem573, Me.MenuItem656, Me.MenuItem480, Me.MenuItem675, Me.MenuItem653})
        Me.MenuItem82.Text = "Reportes"
        '
        'MenuItem318
        '
        Me.MenuItem318.Index = 0
        Me.MenuItem318.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem151, Me.MenuItem313, Me.MenuItem319, Me.MenuItem511})
        Me.MenuItem318.Text = "C31 - Ingresos"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 0
        Me.MenuItem151.Text = "C310 - Ingreso de Aspirantes"
        '
        'MenuItem313
        '
        Me.MenuItem313.Index = 1
        Me.MenuItem313.Text = "C311 - Ingreso de Asociados"
        '
        'MenuItem319
        '
        Me.MenuItem319.Index = 2
        Me.MenuItem319.Text = "C312 - Carta de bienvenida de Asociados"
        '
        'MenuItem511
        '
        Me.MenuItem511.Index = 3
        Me.MenuItem511.Text = "C313 - Reingreso de Asociados"
        '
        'MenuItem314
        '
        Me.MenuItem314.Index = 1
        Me.MenuItem314.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem83, Me.MenuItem315, Me.MenuItem316, Me.MenuItem317, Me.MenuItem458})
        Me.MenuItem314.Text = "C32 - Retiros"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 0
        Me.MenuItem83.Text = "C320 - Solicitud de Retiro"
        '
        'MenuItem315
        '
        Me.MenuItem315.Index = 1
        Me.MenuItem315.Text = "C321 - &Retiro de Asociados"
        '
        'MenuItem316
        '
        Me.MenuItem316.Index = 2
        Me.MenuItem316.Text = "C322 - Detalle de Renuncias de Asociados"
        '
        'MenuItem317
        '
        Me.MenuItem317.Index = 3
        Me.MenuItem317.Text = "C323 - Carta Retirados"
        '
        'MenuItem458
        '
        Me.MenuItem458.Index = 4
        Me.MenuItem458.Text = "C324 - Formulario Reconsideración de Renuncia"
        '
        'MenuItem427
        '
        Me.MenuItem427.Index = 2
        Me.MenuItem427.Text = "C33 - Asociados Inhabilitados"
        '
        'MenuItem428
        '
        Me.MenuItem428.Index = 3
        Me.MenuItem428.Text = "C34 - Asociados Excluídos"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 4
        Me.MenuItem154.Text = "C35 - Exportación datos de Asociados"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 5
        Me.MenuItem163.Text = "C36 - Asociados Fallecidos"
        '
        'MenuItem263
        '
        Me.MenuItem263.Index = 6
        Me.MenuItem263.Text = "C37 - Asociados Habilitados"
        '
        'MenuItem566
        '
        Me.MenuItem566.Index = 7
        Me.MenuItem566.Text = "C38 - Recibo Dividendos "
        '
        'MenuItem572
        '
        Me.MenuItem572.Index = 8
        Me.MenuItem572.Text = "C39 - Correos Enviados"
        '
        'MenuItem573
        '
        Me.MenuItem573.Index = 9
        Me.MenuItem573.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem574})
        Me.MenuItem573.Text = "C3A - Asociados"
        '
        'MenuItem574
        '
        Me.MenuItem574.Index = 0
        Me.MenuItem574.Text = "C3A1 - Transacciones  Ctas. de Aportaciones"
        '
        'MenuItem656
        '
        Me.MenuItem656.Index = 10
        Me.MenuItem656.Text = "C3B - Constancia Retención De Impuesto Control a la Liquidez"
        '
        'MenuItem480
        '
        Me.MenuItem480.Index = 11
        Me.MenuItem480.Text = "C3C - Detalle de Transacciones Asociados por Monto"
        '
        'MenuItem675
        '
        Me.MenuItem675.Index = 12
        Me.MenuItem675.Text = "C3D - Lista Negra Interna"
        '
        'MenuItem364
        '
        Me.MenuItem364.Index = 4
        Me.MenuItem364.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem365, Me.MenuItem366, Me.MenuItem367})
        Me.MenuItem364.Text = "Ve&ntana"
        '
        'MenuItem365
        '
        Me.MenuItem365.Index = 0
        Me.MenuItem365.Text = "Cascada"
        '
        'MenuItem366
        '
        Me.MenuItem366.Index = 1
        Me.MenuItem366.Text = "Vertical"
        '
        'MenuItem367
        '
        Me.MenuItem367.Index = 2
        Me.MenuItem367.Text = "Horizontal"
        '
        'mnuAportaciones
        '
        Me.mnuAportaciones.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem34, Me.MenuItem72, Me.MenuItem189, Me.MenuItem111, Me.MenuItem368})
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 0
        Me.MenuItem34.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem36, Me.MenuItem37, Me.MenuItem38})
        Me.MenuItem34.Text = "&Inicio"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 0
        Me.MenuItem36.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 1
        Me.MenuItem37.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 2
        Me.MenuItem38.Text = "A3 - &Salir"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 1
        Me.MenuItem72.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem92})
        Me.MenuItem72.Text = "Maestros"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 0
        Me.MenuItem92.Text = "D11 - Cuentas de &Aportaciones"
        '
        'MenuItem189
        '
        Me.MenuItem189.Index = 2
        Me.MenuItem189.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem190, Me.MenuItem104, Me.MenuItem432, Me.MenuItem601, Me.MenuItem625})
        Me.MenuItem189.Text = "&Procesos"
        '
        'MenuItem190
        '
        Me.MenuItem190.Index = 0
        Me.MenuItem190.Text = "D21 - Cálculo y Aplicación de &Dividendos"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 1
        Me.MenuItem104.Text = "D22 - &Activación Cuentas de Aportación"
        '
        'MenuItem432
        '
        Me.MenuItem432.Index = 2
        Me.MenuItem432.Text = "D23 - Aplicaciones Valor Fecha"
        '
        'MenuItem601
        '
        Me.MenuItem601.Index = 3
        Me.MenuItem601.Text = "D24 - Aplicación Cuota Aportación Inversionistas en Mora"
        '
        'MenuItem625
        '
        Me.MenuItem625.Index = 4
        Me.MenuItem625.Text = "D25 - Capitalización Dividendos no Retirados"
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 3
        Me.MenuItem111.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem112, Me.MenuItem152, Me.MenuItem179, Me.MenuItem355, Me.MenuItem328, Me.MenuItem552, Me.MenuItem556, Me.MenuItem602})
        Me.MenuItem111.Text = "Reportes"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 0
        Me.MenuItem112.Text = "D31 - Consulta de Movimientos"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 1
        Me.MenuItem152.Text = "D32 - &Estado de Cuentas"
        '
        'MenuItem179
        '
        Me.MenuItem179.Index = 2
        Me.MenuItem179.Text = "D33 - Cobro por &Inactividad en Cuentas"
        '
        'MenuItem355
        '
        Me.MenuItem355.Index = 3
        Me.MenuItem355.Text = "D34 - Saldos de Aportaciones canceladas por período"
        '
        'MenuItem328
        '
        Me.MenuItem328.Index = 4
        Me.MenuItem328.Text = "D35 - Ingreso de Asociados"
        '
        'MenuItem552
        '
        Me.MenuItem552.Index = 5
        Me.MenuItem552.Text = "D36 - Orden de Descuento"
        '
        'MenuItem556
        '
        Me.MenuItem556.Index = 6
        Me.MenuItem556.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem557, Me.MenuItem558, Me.MenuItem559, Me.MenuItem560, Me.MenuItem561})
        Me.MenuItem556.Text = "D37 - Dividendos"
        '
        'MenuItem557
        '
        Me.MenuItem557.Index = 0
        Me.MenuItem557.Text = "D370 - Listado Dividendos Cuentas Ahorros"
        '
        'MenuItem558
        '
        Me.MenuItem558.Index = 1
        Me.MenuItem558.Text = "D371 - Listado Dividendos Aportaciones"
        '
        'MenuItem559
        '
        Me.MenuItem559.Index = 2
        Me.MenuItem559.Text = "D372 - Listado Dividendos Préstamos"
        '
        'MenuItem560
        '
        Me.MenuItem560.Index = 3
        Me.MenuItem560.Text = "D373 - Listado Dividendos Pagos en Efectivo"
        '
        'MenuItem561
        '
        Me.MenuItem561.Index = 4
        Me.MenuItem561.Text = "D374 - Listado Dividendos Ex Asociados"
        '
        'MenuItem602
        '
        Me.MenuItem602.Index = 7
        Me.MenuItem602.Text = "D38 - Transferencia Intereses DPF a Cta. de Aportaciones"
        '
        'MenuItem368
        '
        Me.MenuItem368.Index = 4
        Me.MenuItem368.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem369, Me.MenuItem370, Me.MenuItem371})
        Me.MenuItem368.Text = "Ve&ntana"
        '
        'MenuItem369
        '
        Me.MenuItem369.Index = 0
        Me.MenuItem369.Text = "Cascada"
        '
        'MenuItem370
        '
        Me.MenuItem370.Index = 1
        Me.MenuItem370.Text = "Vertical"
        '
        'MenuItem371
        '
        Me.MenuItem371.Index = 2
        Me.MenuItem371.Text = "Horizontal"
        '
        'mnuCreditos
        '
        Me.mnuCreditos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem39, Me.MenuItem22, Me.MenuItem56, Me.mnuControlPrestamos, Me.MenuItem94, Me.MenuItem372})
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 0
        Me.MenuItem39.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem41, Me.MenuItem42, Me.MenuItem43})
        Me.MenuItem39.Text = "&Inicio"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 0
        Me.MenuItem41.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 2
        Me.MenuItem43.Text = "A3 - &Salir"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem86, Me.MenuItem87, Me.MenuItem88, Me.MenuItem89, Me.MenuItem266, Me.MenuItem91, Me.MenuItem173, Me.MenuItem177, Me.MenuItem193})
        Me.MenuItem22.Text = "&Maestros"
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 0
        Me.MenuItem86.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem456, Me.MenuItem457})
        Me.MenuItem86.Text = "F10 - Líneas de Crédito"
        '
        'MenuItem456
        '
        Me.MenuItem456.Index = 0
        Me.MenuItem456.Text = "F100 - Líneas de Crédito"
        '
        'MenuItem457
        '
        Me.MenuItem457.Index = 1
        Me.MenuItem457.Text = "F101 - Rangos de Líneas de Crédito"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 1
        Me.MenuItem87.Text = "F11 - Tipos de Crédito"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 2
        Me.MenuItem88.Text = "F12 - Tipos de Ingresos"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 3
        Me.MenuItem89.Text = "F13 - Tipos de Gastos"
        '
        'MenuItem266
        '
        Me.MenuItem266.Index = 4
        Me.MenuItem266.Text = "F14 - &Empresas Valuadoras"
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 5
        Me.MenuItem91.Text = "F15 - Tipos de Garantía"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 6
        Me.MenuItem173.Text = "F16 - Categorías de Riesgo"
        '
        'MenuItem177
        '
        Me.MenuItem177.Index = 7
        Me.MenuItem177.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem180, Me.MenuItem281, Me.MenuItem282, Me.MenuItem26, Me.MenuItem124, Me.MenuItem587})
        Me.MenuItem177.Text = "F17 - &Deducciones"
        '
        'MenuItem180
        '
        Me.MenuItem180.Index = 0
        Me.MenuItem180.Text = "F171 - Gastos de Escrituración"
        '
        'MenuItem281
        '
        Me.MenuItem281.Index = 1
        Me.MenuItem281.Text = "F172 - Honorarios"
        '
        'MenuItem282
        '
        Me.MenuItem282.Index = 2
        Me.MenuItem282.Text = "F173 - Gastos de Tramitación"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 3
        Me.MenuItem26.Text = "F174 - Gastos de Escrituración por Rango"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 4
        Me.MenuItem124.Text = "F175 - Gastos de Tramitación por Rango"
        '
        'MenuItem587
        '
        Me.MenuItem587.Index = 5
        Me.MenuItem587.Text = "F176 - Catalogo Gastos de Tramitación"
        '
        'MenuItem193
        '
        Me.MenuItem193.Index = 8
        Me.MenuItem193.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem643, Me.MenuItem644, Me.MenuItem645, Me.MenuItem646, Me.MenuItem647, Me.MenuItem650, Me.MenuItem651})
        Me.MenuItem193.Text = "F18 - Pagadurías"
        '
        'MenuItem643
        '
        Me.MenuItem643.Index = 0
        Me.MenuItem643.Text = "F180 - Mantenimiento Pagadurías"
        '
        'MenuItem644
        '
        Me.MenuItem644.Index = 1
        Me.MenuItem644.Text = "F181 - Mantenimiento Tipo de Empresas"
        '
        'MenuItem645
        '
        Me.MenuItem645.Index = 2
        Me.MenuItem645.Text = "F182 - Mantenimiento Giro Empresas"
        '
        'MenuItem646
        '
        Me.MenuItem646.Index = 3
        Me.MenuItem646.Text = "F183 - Mantenimiento Clasificación Pagadurías"
        '
        'MenuItem647
        '
        Me.MenuItem647.Index = 4
        Me.MenuItem647.Text = "F184 - Mantenimiento Criterios de Evaluación Pagadurías"
        '
        'MenuItem650
        '
        Me.MenuItem650.Index = 5
        Me.MenuItem650.Text = "F185 - Mantenimiento Tipo de Evaluaciones"
        '
        'MenuItem651
        '
        Me.MenuItem651.Index = 6
        Me.MenuItem651.Text = "F186 - Mantenimiento Validaciones Criterios de Evaluación"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 2
        Me.MenuItem56.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem57, Me.MenuItem66, Me.MenuItem176, Me.MenuItem139, Me.MenuItem416, Me.MenuItem417, Me.MenuItem433, Me.MenuItem551, Me.MenuItem584, Me.MenuItem624, Me.MenuItem648})
        Me.MenuItem56.Text = "&Proceso Créditos"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 0
        Me.MenuItem57.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem65})
        Me.MenuItem57.Text = "F21 - Proceso Control Solicitud"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 0
        Me.MenuItem65.Text = "F211 - Mantenimiento"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 1
        Me.MenuItem66.Text = "F22 - Cálculo Tabla Pagos"
        '
        'MenuItem176
        '
        Me.MenuItem176.Index = 2
        Me.MenuItem176.Text = "F23 - Valúos"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 3
        Me.MenuItem139.Text = "F24 - Certificación Extractada"
        '
        'MenuItem416
        '
        Me.MenuItem416.Index = 4
        Me.MenuItem416.Text = "F25 - Cálculo de tabla de cuotas"
        '
        'MenuItem417
        '
        Me.MenuItem417.Index = 5
        Me.MenuItem417.Text = "F26 - Generar Historial Categorías de Riesgo"
        '
        'MenuItem433
        '
        Me.MenuItem433.Index = 6
        Me.MenuItem433.Text = "F27 - Proyección de Saldos"
        '
        'MenuItem551
        '
        Me.MenuItem551.Index = 7
        Me.MenuItem551.Text = "F28 - Historial Categorías de Riesgo"
        '
        'MenuItem584
        '
        Me.MenuItem584.Index = 8
        Me.MenuItem584.Text = "F29 - Carga y Pago de Planillas de Préstamos"
        '
        'MenuItem624
        '
        Me.MenuItem624.Index = 9
        Me.MenuItem624.Text = "F2A - Generar Documento de Cartera para BCR"
        '
        'MenuItem648
        '
        Me.MenuItem648.Index = 10
        Me.MenuItem648.Text = "F2B - Evaluación de Pagadurías"
        '
        'mnuControlPrestamos
        '
        Me.mnuControlPrestamos.Index = 3
        Me.mnuControlPrestamos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMaestroPrestamos, Me.MenuItem58, Me.MenuItem3, Me.MenuItem71, Me.MenuItem113, Me.MenuItem174, Me.MenuItem175, Me.MenuItem178, Me.MenuItem323, Me.MenuItem676, Me.MenuItem677})
        Me.mnuControlPrestamos.Text = "&Control Préstamos"
        '
        'mnuMaestroPrestamos
        '
        Me.mnuMaestroPrestamos.Index = 0
        Me.mnuMaestroPrestamos.Text = "F31 - Maestro Préstamos"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 1
        Me.MenuItem58.Text = "F32 - Provisión de Intereses y procesos de Cálculo"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "F33 - Aplicaciones Valor Fecha (Reversiones )"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 3
        Me.MenuItem71.Text = "F34 - Consulta Movimientos y Provisiones (Saldos)"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 4
        Me.MenuItem113.Text = "F35 - Categoría Riesgo por Préstamo y Reserva"
        '
        'MenuItem174
        '
        Me.MenuItem174.Index = 5
        Me.MenuItem174.Text = "F36 - &Solicitud DICOM"
        '
        'MenuItem175
        '
        Me.MenuItem175.Index = 6
        Me.MenuItem175.Text = "F37 - Consulta &DICOM"
        '
        'MenuItem178
        '
        Me.MenuItem178.Index = 7
        Me.MenuItem178.Text = "F38 - Consulta &Pignoración"
        '
        'MenuItem323
        '
        Me.MenuItem323.Index = 8
        Me.MenuItem323.Text = "F39 - Transferencias Automáticas"
        '
        'MenuItem676
        '
        Me.MenuItem676.Index = 9
        Me.MenuItem676.Text = "F40 - Gestión Mora"
        '
        'MenuItem677
        '
        Me.MenuItem677.Index = 10
        Me.MenuItem677.Text = "F4A - Arreglos por Mora"
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 4
        Me.MenuItem94.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem95, Me.MenuItem97, Me.MenuItem182, Me.MenuItem185, Me.MenuItem324, Me.MenuItem348, Me.MenuItem351, Me.MenuItem357, Me.MenuItem412, Me.MenuItem436, Me.MenuItem158, Me.MenuItem578, Me.MenuItem585, Me.MenuItem641, Me.MenuItem642, Me.MenuItem672, Me.MenuItem678, Me.MenuItem679, Me.MenuItem680, Me.MenuItem20, Me.MenuItem340, Me.MenuItem629, Me.MenuItem169})
        Me.MenuItem94.Text = "Reportes"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 0
        Me.MenuItem95.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem440, Me.MenuItem441})
        Me.MenuItem95.Text = "F41 - Estados de Cuenta"
        '
        'MenuItem440
        '
        Me.MenuItem440.Index = 0
        Me.MenuItem440.Text = "F410 - Estado de Cuenta (Reversiones)"
        '
        'MenuItem441
        '
        Me.MenuItem441.Index = 1
        Me.MenuItem441.Text = "F411 - Estado de Cuenta"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 1
        Me.MenuItem97.Text = "F42 - Detalle de Préstamo"
        '
        'MenuItem182
        '
        Me.MenuItem182.Index = 2
        Me.MenuItem182.Text = "F44 - Colocación de Préstamos"
        '
        'MenuItem185
        '
        Me.MenuItem185.Index = 3
        Me.MenuItem185.Text = "F45 - Carta informativa"
        '
        'MenuItem324
        '
        Me.MenuItem324.Index = 4
        Me.MenuItem324.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem438, Me.MenuItem437})
        Me.MenuItem324.Text = "F46 - Reportes de Fiadores"
        '
        'MenuItem438
        '
        Me.MenuItem438.Index = 0
        Me.MenuItem438.Text = "F460 - Datos Fiador"
        '
        'MenuItem437
        '
        Me.MenuItem437.Index = 1
        Me.MenuItem437.Text = "F461 - Fiadores por Préstamo"
        '
        'MenuItem348
        '
        Me.MenuItem348.Index = 5
        Me.MenuItem348.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem349, Me.MenuItem350})
        Me.MenuItem348.Text = "F49 - Provisiones de Préstamos"
        '
        'MenuItem349
        '
        Me.MenuItem349.Index = 0
        Me.MenuItem349.Text = "F490 - Listado de préstamos provisionados"
        '
        'MenuItem350
        '
        Me.MenuItem350.Index = 1
        Me.MenuItem350.Text = "F491 - Listado de préstamos No provisionados"
        '
        'MenuItem351
        '
        Me.MenuItem351.Index = 6
        Me.MenuItem351.Text = "F50 - Orden de descuento"
        '
        'MenuItem357
        '
        Me.MenuItem357.Index = 7
        Me.MenuItem357.Text = "F51 - Aplicaciones valor fecha "
        '
        'MenuItem412
        '
        Me.MenuItem412.Index = 8
        Me.MenuItem412.Text = "F52 - Cuentas de Asociados"
        '
        'MenuItem436
        '
        Me.MenuItem436.Index = 9
        Me.MenuItem436.Text = "F53 - Préstamos cancelados"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 10
        Me.MenuItem158.Text = "F55 - Listado de Créditos Pignorados"
        '
        'MenuItem578
        '
        Me.MenuItem578.Index = 11
        Me.MenuItem578.Text = "F58 - Gestiones por Asociado"
        '
        'MenuItem585
        '
        Me.MenuItem585.Index = 12
        Me.MenuItem585.Text = "F59 - Reporte Detalle de Pago de Planillas de Préstamos"
        '
        'MenuItem641
        '
        Me.MenuItem641.Index = 13
        Me.MenuItem641.Text = "F61 - Asociados Sin Crédito"
        '
        'MenuItem642
        '
        Me.MenuItem642.Index = 14
        Me.MenuItem642.Text = "F62 - Cartera de Préstamos por Sucursal (Hipotecarios,Solidarios)"
        '
        'MenuItem672
        '
        Me.MenuItem672.Index = 15
        Me.MenuItem672.Text = "F68 -Detalle de Cartera"
        '
        'MenuItem678
        '
        Me.MenuItem678.Index = 16
        Me.MenuItem678.Text = "F70 - Consolidado Recuperación"
        '
        'MenuItem679
        '
        Me.MenuItem679.Index = 17
        Me.MenuItem679.Text = "F71 - Tasa Activa"
        '
        'MenuItem680
        '
        Me.MenuItem680.Index = 18
        Me.MenuItem680.Text = "F72 - Detalle de cartera de Prestamo"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 19
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem137, Me.MenuItem332})
        Me.MenuItem20.Text = "F73 - Aseguradora"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 0
        Me.MenuItem137.Text = "F731 - Préstamos Hipotecarios"
        '
        'MenuItem332
        '
        Me.MenuItem332.Index = 1
        Me.MenuItem332.Text = "F732 - Saldos de Préstamos"
        '
        'MenuItem340
        '
        Me.MenuItem340.Index = 20
        Me.MenuItem340.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem341, Me.MenuItem464})
        Me.MenuItem340.Text = "F74 - Deducciones Préstamo"
        '
        'MenuItem341
        '
        Me.MenuItem341.Index = 0
        Me.MenuItem341.Text = "F741 - Detalle Deducciones Préstamo"
        '
        'MenuItem464
        '
        Me.MenuItem464.Index = 1
        Me.MenuItem464.Text = "F742 - Consolidado Deducciones Por Sucursal"
        '
        'MenuItem629
        '
        Me.MenuItem629.Index = 21
        Me.MenuItem629.Text = "F75 - Abonos de Préstamo"
        '
        'MenuItem169
        '
        Me.MenuItem169.Index = 22
        Me.MenuItem169.Text = "F76 - Prestamos Garantía Vehículo"
        '
        'MenuItem372
        '
        Me.MenuItem372.Index = 5
        Me.MenuItem372.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem373, Me.MenuItem374, Me.MenuItem375})
        Me.MenuItem372.Text = "Ve&ntana"
        '
        'MenuItem373
        '
        Me.MenuItem373.Index = 0
        Me.MenuItem373.Text = "Cascada"
        '
        'MenuItem374
        '
        Me.MenuItem374.Index = 1
        Me.MenuItem374.Text = "Vertical"
        '
        'MenuItem375
        '
        Me.MenuItem375.Index = 2
        Me.MenuItem375.Text = "Horizontal"
        '
        'mnuAhorros
        '
        Me.mnuAhorros.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem44, Me.MenuItem45, Me.MenuItem98, Me.MenuItem105, Me.MenuItem360})
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 0
        Me.MenuItem44.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem46, Me.MenuItem47, Me.MenuItem48})
        Me.MenuItem44.Text = "&Inicio"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 0
        Me.MenuItem46.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 1
        Me.MenuItem47.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 2
        Me.MenuItem48.Text = "A3 - &Salir"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 1
        Me.MenuItem45.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem110, Me.MenuItem103, Me.MenuItem60, Me.MenuItem107, Me.MenuItem609, Me.MenuItem682})
        Me.MenuItem45.Text = "Maestros"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 0
        Me.MenuItem110.Text = "E11 - Tasas de Interés"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 1
        Me.MenuItem103.Text = "E12 - &Fechas de Capitalización"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 2
        Me.MenuItem60.Text = "E13 - &Maestro Cuentas de Ahorro"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 3
        Me.MenuItem107.Text = "E14 - &Maestro Cuentas Depósito a Plazo"
        '
        'MenuItem609
        '
        Me.MenuItem609.Index = 4
        Me.MenuItem609.Text = "E15 - Autorizacion Cambio de Tasas DPF"
        '
        'MenuItem682
        '
        Me.MenuItem682.Index = 5
        Me.MenuItem682.Text = "E16 - Tipos de Ahorro"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 2
        Me.MenuItem98.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem99, Me.MenuItem101, Me.MenuItem167, Me.MenuItem303, Me.MenuItem305, Me.MenuItem322, Me.MenuItem593, Me.MenuItem610, Me.MenuItem657})
        Me.MenuItem98.Text = "Procesos"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 0
        Me.MenuItem99.Text = "E21 - &Provisión de Intereses"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 1
        Me.MenuItem101.Text = "E22 - &Consulta de Provisiones"
        '
        'MenuItem167
        '
        Me.MenuItem167.Index = 2
        Me.MenuItem167.Text = "E23 - &Inactividad en Cuentas"
        '
        'MenuItem303
        '
        Me.MenuItem303.Index = 3
        Me.MenuItem303.Text = "E24 - Pi&gnoración Cuentas de Ahorro"
        '
        'MenuItem305
        '
        Me.MenuItem305.Index = 4
        Me.MenuItem305.Text = "E25 - Aplicaciones Valor Fecha"
        '
        'MenuItem322
        '
        Me.MenuItem322.Index = 5
        Me.MenuItem322.Text = "E26 - Transferencia Automática"
        '
        'MenuItem593
        '
        Me.MenuItem593.Index = 6
        Me.MenuItem593.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem594, Me.MenuItem595, Me.MenuItem596})
        Me.MenuItem593.Text = "E27 - Carga de Planillas"
        '
        'MenuItem594
        '
        Me.MenuItem594.Index = 0
        Me.MenuItem594.Text = "E271 - Ahorro"
        '
        'MenuItem595
        '
        Me.MenuItem595.Index = 1
        Me.MenuItem595.Text = "E272 - Aportaciones"
        '
        'MenuItem596
        '
        Me.MenuItem596.Index = 2
        Me.MenuItem596.Text = "E273 - DPF"
        '
        'MenuItem610
        '
        Me.MenuItem610.Index = 7
        Me.MenuItem610.Text = "E28 - Ingresar Matriz Asociados ISR"
        '
        'MenuItem657
        '
        Me.MenuItem657.Index = 8
        Me.MenuItem657.Text = "E29 - Habilitar Cuentas de Ahorro Inactivas"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 3
        Me.MenuItem105.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem106, Me.MenuItem109, Me.MenuItem146, Me.MenuItem150, Me.MenuItem166, Me.MenuItem307, Me.MenuItem345, Me.MenuItem356, Me.MenuItem425, Me.MenuItem426, Me.MenuItem435, Me.MenuItem418, Me.MenuItem597, Me.MenuItem598, Me.MenuItem600, Me.MenuItem685, Me.MenuItem140})
        Me.MenuItem105.Text = "Reportes"
        '
        'MenuItem106
        '
        Me.MenuItem106.Index = 0
        Me.MenuItem106.Text = "E31 - &Listado de Cuentas Prorrogadas"
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 1
        Me.MenuItem109.Text = "E32 - Consulta de Movimientos"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 2
        Me.MenuItem146.Text = "E34 - &Estado de Cuentas de Ahorro"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 3
        Me.MenuItem150.Text = "E35 - &Vencimientos de Cuentas de Ahorros"
        '
        'MenuItem166
        '
        Me.MenuItem166.Index = 4
        Me.MenuItem166.Text = "E36 - Cobro por &Inactividad en Cuentas"
        '
        'MenuItem307
        '
        Me.MenuItem307.Index = 5
        Me.MenuItem307.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem308, Me.MenuItem142, Me.MenuItem338, Me.MenuItem339, Me.MenuItem342, Me.MenuItem168, Me.MenuItem423, Me.MenuItem465, Me.MenuItem532})
        Me.MenuItem307.Text = "E37 - Depósitos Plazo Fijo"
        '
        'MenuItem308
        '
        Me.MenuItem308.Index = 0
        Me.MenuItem308.Text = "E370 - Reporte de Vencimientos"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 1
        Me.MenuItem142.Text = "E371 - Exportación de datos DPF"
        '
        'MenuItem338
        '
        Me.MenuItem338.Index = 2
        Me.MenuItem338.Text = "E372 - Reporte de datos DPF"
        '
        'MenuItem339
        '
        Me.MenuItem339.Index = 3
        Me.MenuItem339.Text = "E373 - Impresión de Certificado de Depósito"
        '
        'MenuItem342
        '
        Me.MenuItem342.Index = 4
        Me.MenuItem342.Text = "E374 - Pago de intereses de DPF"
        '
        'MenuItem168
        '
        Me.MenuItem168.Index = 5
        Me.MenuItem168.Text = "E375 - Vencimientos diarios (Cumplen mes)"
        '
        'MenuItem423
        '
        Me.MenuItem423.Index = 6
        Me.MenuItem423.Text = "E376 - Depósitos a plazo fijo anulados"
        '
        'MenuItem465
        '
        Me.MenuItem465.Index = 7
        Me.MenuItem465.Text = "E377 - Vencimientos diarios proyectados (Cumplen mes)"
        '
        'MenuItem532
        '
        Me.MenuItem532.Index = 8
        Me.MenuItem532.Text = "E378 - Cartera DPF"
        '
        'MenuItem345
        '
        Me.MenuItem345.Index = 6
        Me.MenuItem345.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem346, Me.MenuItem347})
        Me.MenuItem345.Text = "E38 - Provisiones de Cuentas de Ahorro"
        '
        'MenuItem346
        '
        Me.MenuItem346.Index = 0
        Me.MenuItem346.Text = "E380 - Listado de Cuentas provisionadas"
        '
        'MenuItem347
        '
        Me.MenuItem347.Index = 1
        Me.MenuItem347.Text = "E381 - Listado de Cuentas No provisionadas"
        '
        'MenuItem356
        '
        Me.MenuItem356.Index = 7
        Me.MenuItem356.Text = "E39 - Cuentas Pignoradas"
        '
        'MenuItem425
        '
        Me.MenuItem425.Index = 8
        Me.MenuItem425.Text = "E40 - Aplicaciones Valor Fecha"
        '
        'MenuItem426
        '
        Me.MenuItem426.Index = 9
        Me.MenuItem426.Text = "E41 - Asociados Ahorrantes"
        '
        'MenuItem435
        '
        Me.MenuItem435.Index = 10
        Me.MenuItem435.Text = "E42 - Cancelación de Cuentas (Tipo de Transacción)"
        '
        'MenuItem418
        '
        Me.MenuItem418.Index = 11
        Me.MenuItem418.Text = "E43 - Cancelación de Cuentas"
        '
        'MenuItem597
        '
        Me.MenuItem597.Index = 12
        Me.MenuItem597.Text = "E45 - Detalle "
        '
        'MenuItem598
        '
        Me.MenuItem598.Index = 13
        Me.MenuItem598.Text = "E46 - Reporte Detalle de Pago de Planillas Ahorro y Aportaciones"
        '
        'MenuItem600
        '
        Me.MenuItem600.Index = 14
        Me.MenuItem600.Text = "E47 - Apertura de Ctas. por Sucursal"
        '
        'MenuItem685
        '
        Me.MenuItem685.Index = 15
        Me.MenuItem685.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem686, Me.MenuItem687, Me.MenuItem688})
        Me.MenuItem685.Text = "E49 - Saldos Ahorros"
        '
        'MenuItem686
        '
        Me.MenuItem686.Index = 0
        Me.MenuItem686.Text = "E491 - Saldos Ahorro"
        '
        'MenuItem687
        '
        Me.MenuItem687.Index = 1
        Me.MenuItem687.Text = "E492 - Saldos Aportaciones"
        '
        'MenuItem688
        '
        Me.MenuItem688.Index = 2
        Me.MenuItem688.Text = "E493 - Saldos Depositos a Plazo Fijo"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 16
        Me.MenuItem140.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem149, Me.MenuItem155})
        Me.MenuItem140.Text = "E50 - Tasa Pasiva"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 0
        Me.MenuItem149.Text = "E51 - Por Tipo de Ahorro"
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 1
        Me.MenuItem155.Text = "E52 - Por Sucursal"
        '
        'MenuItem360
        '
        Me.MenuItem360.Index = 4
        Me.MenuItem360.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem361, Me.MenuItem362, Me.MenuItem363})
        Me.MenuItem360.Text = "Ve&ntana"
        '
        'MenuItem361
        '
        Me.MenuItem361.Index = 0
        Me.MenuItem361.Text = "Cascada"
        '
        'MenuItem362
        '
        Me.MenuItem362.Index = 1
        Me.MenuItem362.Text = "Vertical"
        '
        'MenuItem363
        '
        Me.MenuItem363.Index = 2
        Me.MenuItem363.Text = "Horizontal"
        '
        'mnuAdministracion
        '
        Me.mnuAdministracion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49, Me.MenuItem75, Me.MenuItem376})
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 0
        Me.MenuItem49.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem51, Me.MenuItem52, Me.MenuItem53})
        Me.MenuItem49.Text = "&Inicio"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 0
        Me.MenuItem51.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 1
        Me.MenuItem52.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 2
        Me.MenuItem53.Text = "A3 - &Salir"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 1
        Me.MenuItem75.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuB11, Me.mnuB12, Me.mnuB13, Me.mnuB14, Me.mnuB15})
        Me.MenuItem75.Text = "&Seguridad"
        '
        'mnuB11
        '
        Me.mnuB11.Index = 0
        Me.mnuB11.Text = "B11 - Grupos/&Roles"
        '
        'mnuB12
        '
        Me.mnuB12.Index = 1
        Me.mnuB12.Text = "B12 - &Usuarios"
        '
        'mnuB13
        '
        Me.mnuB13.Index = 2
        Me.mnuB13.Text = "B13 - Usuarios &por Rol"
        '
        'mnuB14
        '
        Me.mnuB14.Index = 3
        Me.mnuB14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem9})
        Me.mnuB14.Text = "B14 - &Asignación Derechos"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "B141 - &Opciones del Sistema"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "B142 - &Procesos"
        '
        'mnuB15
        '
        Me.mnuB15.Index = 4
        Me.mnuB15.Text = "B15 - Consulta &Bitácoras"
        '
        'MenuItem376
        '
        Me.MenuItem376.Index = 2
        Me.MenuItem376.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem377, Me.MenuItem378, Me.MenuItem379})
        Me.MenuItem376.Text = "Ve&ntana"
        '
        'MenuItem377
        '
        Me.MenuItem377.Index = 0
        Me.MenuItem377.Text = "Cascada"
        '
        'MenuItem378
        '
        Me.MenuItem378.Index = 1
        Me.MenuItem378.Text = "Vertical"
        '
        'MenuItem379
        '
        Me.MenuItem379.Index = 2
        Me.MenuItem379.Text = "Horizontal"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem215})
        '
        'MenuItem215
        '
        Me.MenuItem215.Index = 0
        Me.MenuItem215.Text = ""
        '
        'mnuCaja
        '
        Me.mnuCaja.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem59, Me.MenuItem67, Me.MenuItem73, Me.MenuItem135, Me.MenuItem380})
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 0
        Me.MenuItem59.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem61, Me.MenuItem62, Me.MenuItem63})
        Me.MenuItem59.Text = "&Inicio"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 0
        Me.MenuItem61.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 1
        Me.MenuItem62.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 2
        Me.MenuItem63.Text = "A3 - &Salir"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 1
        Me.MenuItem67.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem136, Me.MenuItem141, Me.MenuItem69, Me.MenuItem170, Me.MenuItem265, Me.MenuItem631, Me.MenuItem632, Me.MenuItem633, Me.MenuItem671, Me.MenuItem267, Me.MenuItem683})
        Me.MenuItem67.Text = "Maestros"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 0
        Me.MenuItem136.Text = "Mantenimiento de Ca&jas"
        Me.MenuItem136.Visible = False
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 1
        Me.MenuItem141.Text = "H11 - Mantenimiento de &Cajeros"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 2
        Me.MenuItem69.Text = "H12 - &Items Facturables"
        '
        'MenuItem170
        '
        Me.MenuItem170.Index = 3
        Me.MenuItem170.Text = "H13 - &Movimientos de Caja"
        '
        'MenuItem265
        '
        Me.MenuItem265.Index = 4
        Me.MenuItem265.Text = "H14 - &Registro de faltantes y sobrantes de caja"
        '
        'MenuItem631
        '
        Me.MenuItem631.Index = 5
        Me.MenuItem631.Text = "H15 - Catalogo Tipos de Movimiento Caja"
        '
        'MenuItem632
        '
        Me.MenuItem632.Index = 6
        Me.MenuItem632.Text = "H16 - Catalogo Tipo de Documentos Caja"
        '
        'MenuItem633
        '
        Me.MenuItem633.Index = 7
        Me.MenuItem633.Text = "H17 - Mantenimiento Correlativos Documentos Caja"
        '
        'MenuItem671
        '
        Me.MenuItem671.Index = 8
        Me.MenuItem671.Text = "H18 - Mantenimiento de Cajas"
        '
        'MenuItem267
        '
        Me.MenuItem267.Index = 9
        Me.MenuItem267.Text = "H19 - Mantenimiento Rubros Caja"
        '
        'MenuItem683
        '
        Me.MenuItem683.Index = 10
        Me.MenuItem683.Text = "H1A - Mantenimiento Items Rubros Documentos"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 2
        Me.MenuItem73.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem74, Me.MenuItem143, Me.MenuItem144, Me.MenuItem90, Me.MenuItem70, Me.MenuItem429, Me.MenuItem623, Me.MenuItem634, Me.MenuItem635, Me.MenuItem684, Me.MenuItem636})
        Me.MenuItem73.Text = "Procesos"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 0
        Me.MenuItem74.Text = "H21 - &Apertura de Caja"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 1
        Me.MenuItem143.Text = "H22 - &Cierre de Caja"
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 2
        Me.MenuItem144.Text = "H23 - &Posteo de Libreta"
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 3
        Me.MenuItem90.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem538, Me.MenuItem542, Me.MenuItem543, Me.MenuItem544, Me.MenuItem630})
        Me.MenuItem90.Text = "H24 - Transferencias"
        '
        'MenuItem538
        '
        Me.MenuItem538.Index = 0
        Me.MenuItem538.Text = "H240 - Cuenta Contable a Cuenta(s) Contable(s)"
        '
        'MenuItem542
        '
        Me.MenuItem542.Index = 1
        Me.MenuItem542.Text = "H241 - Cuenta Auxiliar a Cuenta(s) Contable(s)"
        '
        'MenuItem543
        '
        Me.MenuItem543.Index = 2
        Me.MenuItem543.Text = "H242 - Cuenta Contable a Cuenta(s) Auxiliar(es)"
        '
        'MenuItem544
        '
        Me.MenuItem544.Index = 3
        Me.MenuItem544.Text = "H243 - Cuenta Auxiliar a Cuenta(s) Auxiliar(es)"
        '
        'MenuItem630
        '
        Me.MenuItem630.Index = 4
        Me.MenuItem630.Text = "H244 - Transferencias Automaticas"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 4
        Me.MenuItem70.Text = "H26 - Reversiones"
        '
        'MenuItem429
        '
        Me.MenuItem429.Index = 5
        Me.MenuItem429.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem434, Me.MenuItem430, Me.MenuItem431})
        Me.MenuItem429.Text = "H27 - Aplicaciones valor fecha "
        '
        'MenuItem434
        '
        Me.MenuItem434.Index = 0
        Me.MenuItem434.Text = "H270 - Aplicaciones valor fecha Préstamos"
        '
        'MenuItem430
        '
        Me.MenuItem430.Index = 1
        Me.MenuItem430.Text = "H271 - Aplicaciones valor fecha Aportaciones"
        '
        'MenuItem431
        '
        Me.MenuItem431.Index = 2
        Me.MenuItem431.Text = "H272 - Aplicaciones valor fecha Ahorros"
        '
        'MenuItem623
        '
        Me.MenuItem623.Index = 6
        Me.MenuItem623.Text = "H28 - Partidas Diarias Corte de Caja"
        '
        'MenuItem634
        '
        Me.MenuItem634.Index = 7
        Me.MenuItem634.Text = "H29 - Solicitudes Bóveda"
        '
        'MenuItem635
        '
        Me.MenuItem635.Index = 8
        Me.MenuItem635.Text = "H2A - Retiros de Ahorro por Medio de Cheque"
        '
        'MenuItem684
        '
        Me.MenuItem684.Index = 9
        Me.MenuItem684.Text = "H2B - Transferencia de cheques a boveda"
        '
        'MenuItem636
        '
        Me.MenuItem636.Index = 10
        Me.MenuItem636.Text = "H2D - Formulario UIF"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 3
        Me.MenuItem135.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem145, Me.MenuItem161, Me.MenuItem164, Me.MenuItem264, Me.MenuItem108, Me.MenuItem278, Me.MenuItem279, Me.MenuItem280, Me.MenuItem327, Me.MenuItem354, Me.MenuItem358, Me.MenuItem359, Me.MenuItem451, Me.MenuItem509, Me.MenuItem577, Me.MenuItem652})
        Me.MenuItem135.Text = "Reportes"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 0
        Me.MenuItem145.Text = "H31 - &Corte de Caja"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 1
        Me.MenuItem161.Text = "H32 - Reporte de C&heques por Movimientos de Caja"
        '
        'MenuItem164
        '
        Me.MenuItem164.Index = 2
        Me.MenuItem164.Text = "H33 - &Corte de Movimientos de Caja"
        '
        'MenuItem264
        '
        Me.MenuItem264.Index = 3
        Me.MenuItem264.Text = "H34 - Consulta de Transacciones de Caja"
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 4
        Me.MenuItem108.Text = "H35 - Resumen de Movimientos de Caja (agrupados por documento)"
        '
        'MenuItem278
        '
        Me.MenuItem278.Index = 5
        Me.MenuItem278.Text = "H36 - Resumen de Movimientos de Caja (agrupados por transacción)"
        '
        'MenuItem279
        '
        Me.MenuItem279.Index = 6
        Me.MenuItem279.Text = "H37 - Corte de Movimientos de Caja (Cuentas Contables)"
        '
        'MenuItem280
        '
        Me.MenuItem280.Index = 7
        Me.MenuItem280.Text = "H38 - Arqueo de Caja"
        '
        'MenuItem327
        '
        Me.MenuItem327.Index = 8
        Me.MenuItem327.Text = "H39 - Reversiones de Caja"
        '
        'MenuItem354
        '
        Me.MenuItem354.Index = 9
        Me.MenuItem354.Text = "H40 - Detalle de Apertura de Caja"
        '
        'MenuItem358
        '
        Me.MenuItem358.Index = 10
        Me.MenuItem358.Text = "H41 - Reporte de Movimientos de Caja"
        '
        'MenuItem359
        '
        Me.MenuItem359.Index = 11
        Me.MenuItem359.Text = "H42 - Reporte detallado de Facturas"
        '
        'MenuItem451
        '
        Me.MenuItem451.Index = 12
        Me.MenuItem451.Text = "H43 - Consolidado de Transferencias"
        '
        'MenuItem509
        '
        Me.MenuItem509.Index = 13
        Me.MenuItem509.Text = "H44 - Cheques Anulados por Movimientos en Caja"
        '
        'MenuItem577
        '
        Me.MenuItem577.Index = 14
        Me.MenuItem577.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem579, Me.MenuItem580, Me.MenuItem581, Me.MenuItem663, Me.MenuItem664, Me.MenuItem665, Me.MenuItem666})
        Me.MenuItem577.Text = "H45 - Cuadre diario"
        '
        'MenuItem579
        '
        Me.MenuItem579.Index = 0
        Me.MenuItem579.Text = "H451 - Tipo de Documento"
        '
        'MenuItem580
        '
        Me.MenuItem580.Index = 1
        Me.MenuItem580.Text = "H452 - Desembolso Préstamos"
        '
        'MenuItem581
        '
        Me.MenuItem581.Index = 2
        Me.MenuItem581.Text = "H453 - Por Rubro"
        '
        'MenuItem663
        '
        Me.MenuItem663.Index = 3
        Me.MenuItem663.Text = "H454 - Cuadre de Préstamos Cajeros"
        '
        'MenuItem664
        '
        Me.MenuItem664.Index = 4
        Me.MenuItem664.Text = "H455 - Cuadre de Ahorros Cajeros"
        '
        'MenuItem665
        '
        Me.MenuItem665.Index = 5
        Me.MenuItem665.Text = "H456 - Cuadre de Préstamos por Sucursal"
        '
        'MenuItem666
        '
        Me.MenuItem666.Index = 6
        Me.MenuItem666.Text = "H457 - Cuadre de Ahorros Por Sucursal"
        '
        'MenuItem652
        '
        Me.MenuItem652.Index = 15
        Me.MenuItem652.Text = "H46 - Detalle Transacciones Efectivo y Cheque"
        '
        'MenuItem380
        '
        Me.MenuItem380.Index = 4
        Me.MenuItem380.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem381, Me.MenuItem382, Me.MenuItem383})
        Me.MenuItem380.Text = "Ve&ntana"
        '
        'MenuItem381
        '
        Me.MenuItem381.Index = 0
        Me.MenuItem381.Text = "Cascada"
        '
        'MenuItem382
        '
        Me.MenuItem382.Index = 1
        Me.MenuItem382.Text = "Vertical"
        '
        'MenuItem383
        '
        Me.MenuItem383.Index = 2
        Me.MenuItem383.Text = "Horizontal"
        '
        'stbMain
        '
        Me.stbMain.Location = New System.Drawing.Point(0, 750)
        Me.stbMain.Name = "stbMain"
        Me.stbMain.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sbp1, Me.sbp2})
        Me.stbMain.ShowPanels = True
        Me.stbMain.Size = New System.Drawing.Size(1262, 25)
        Me.stbMain.TabIndex = 4
        Me.stbMain.Text = "StatusBar1"
        '
        'sbp1
        '
        Me.sbp1.Name = "sbp1"
        Me.sbp1.Width = 150
        '
        'sbp2
        '
        Me.sbp2.Name = "sbp2"
        Me.sbp2.Width = 300
        '
        'mnuCobranza
        '
        Me.mnuCobranza.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem114, Me.MenuItem115, Me.MenuItem129, Me.MenuItem134, Me.MenuItem384})
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 0
        Me.MenuItem114.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem116, Me.MenuItem117, Me.MenuItem118})
        Me.MenuItem114.Text = "&Inicio"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 0
        Me.MenuItem116.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 1
        Me.MenuItem117.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 2
        Me.MenuItem118.Text = "A3 - &Salir"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 1
        Me.MenuItem115.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem119, Me.MenuItem120, Me.MenuItem121, Me.MenuItem171})
        Me.MenuItem115.Text = "&Maestros"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 0
        Me.MenuItem119.Text = "G11 - &Tipos de Gestión"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 1
        Me.MenuItem120.Text = "G12 - Tipos de &Cobranza"
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 2
        Me.MenuItem121.Text = "G13 - Mantenimiento de &Gestores"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 3
        Me.MenuItem171.Text = "G14 - Despachos Jurídicos"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 2
        Me.MenuItem129.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem122, Me.MenuItem127, Me.MenuItem128, Me.MenuItem147, Me.MenuItem413, Me.MenuItem460, Me.MenuItem463})
        Me.MenuItem129.Text = "&Gestiones"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 0
        Me.MenuItem122.Text = "G21 - Administración de Gestión del C&rédito - Coordinador"
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 1
        Me.MenuItem127.Text = "G22 - Administración de Gestión del Crédito - Ges&tores"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 2
        Me.MenuItem128.Text = "G23 - Administración de Control de &Embargos"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 3
        Me.MenuItem147.Text = "G24 - &Documentos en Proceso de Recuperación"
        '
        'MenuItem413
        '
        Me.MenuItem413.Index = 4
        Me.MenuItem413.Text = "G25 - Transferencia de Gestor de Créditos"
        '
        'MenuItem460
        '
        Me.MenuItem460.Index = 5
        Me.MenuItem460.Text = "G26 - Consulta Movimientos (Doc. Proceso de Recuperación)"
        '
        'MenuItem463
        '
        Me.MenuItem463.Index = 6
        Me.MenuItem463.Text = "G27 - Aplicaciones Valor Fecha (Reversiones )"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 3
        Me.MenuItem134.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem131, Me.MenuItem133, Me.MenuItem181, Me.MenuItem186, Me.MenuItem419, Me.MenuItem442, Me.MenuItem444, Me.MenuItem446, Me.MenuItem450, Me.MenuItem312, Me.MenuItem455, Me.MenuItem512, Me.MenuItem335})
        Me.MenuItem134.Text = "&Reportes"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 0
        Me.MenuItem131.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem68, Me.MenuItem102, Me.MenuItem603, Me.MenuItem604, Me.MenuItem333, Me.MenuItem334})
        Me.MenuItem131.Text = "G31 -Gestión de Créditos"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 0
        Me.MenuItem68.Text = "G310 - Créditos sin &Pago por Gestión del Crédito"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 1
        Me.MenuItem102.Text = "G311 - Reporte de Acuerdos y Promesas diarias"
        '
        'MenuItem603
        '
        Me.MenuItem603.Index = 2
        Me.MenuItem603.Text = "G313 - Reporte de Aportaciones Pagadas"
        '
        'MenuItem604
        '
        Me.MenuItem604.Index = 3
        Me.MenuItem604.Text = "G314 - Detalle de Cartera Cobros"
        '
        'MenuItem333
        '
        Me.MenuItem333.Index = 4
        Me.MenuItem333.Text = "G315 - Gestiones por Préstamo"
        '
        'MenuItem334
        '
        Me.MenuItem334.Index = 5
        Me.MenuItem334.Text = "G316 - Resumen Gestiones por Gestor"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 1
        Me.MenuItem133.Text = "G32 - &Recuperación por Gestor"
        '
        'MenuItem181
        '
        Me.MenuItem181.Index = 2
        Me.MenuItem181.Text = "G33 - &Documentos por Cobrar"
        '
        'MenuItem186
        '
        Me.MenuItem186.Index = 3
        Me.MenuItem186.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem187, Me.MenuItem188, Me.MenuItem508, Me.MenuItem527, Me.MenuItem528, Me.MenuItem529, Me.MenuItem533, Me.MenuItem605})
        Me.MenuItem186.Text = "G34 - Reporte de Préstamos"
        '
        'MenuItem187
        '
        Me.MenuItem187.Index = 0
        Me.MenuItem187.Text = "G341 - Saneados"
        '
        'MenuItem188
        '
        Me.MenuItem188.Index = 1
        Me.MenuItem188.Text = "G342 - No Saneados"
        '
        'MenuItem508
        '
        Me.MenuItem508.Index = 2
        Me.MenuItem508.Text = "G343 - Movimientos diarios de Préstamos"
        '
        'MenuItem527
        '
        Me.MenuItem527.Index = 3
        Me.MenuItem527.Text = "G344 - Por Garantía"
        '
        'MenuItem528
        '
        Me.MenuItem528.Index = 4
        Me.MenuItem528.Text = "G345 - Por Línea de Crédito"
        '
        'MenuItem529
        '
        Me.MenuItem529.Index = 5
        Me.MenuItem529.Text = "G346 - Por Categorías"
        '
        'MenuItem533
        '
        Me.MenuItem533.Index = 6
        Me.MenuItem533.Text = "G347 - Diario de Cobro y Cargos"
        '
        'MenuItem605
        '
        Me.MenuItem605.Index = 7
        Me.MenuItem605.Text = "G348 - Consolidado de Recuperación por Sucursal"
        '
        'MenuItem419
        '
        Me.MenuItem419.Index = 4
        Me.MenuItem419.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem420, Me.MenuItem421, Me.MenuItem422, Me.MenuItem424})
        Me.MenuItem419.Text = "G35 - Rutas de Cobro"
        '
        'MenuItem420
        '
        Me.MenuItem420.Index = 0
        Me.MenuItem420.Text = "G350 - Control de Ruta General"
        '
        'MenuItem421
        '
        Me.MenuItem421.Index = 1
        Me.MenuItem421.Text = "G351 - Control de Ruta Cartera en Mora"
        '
        'MenuItem422
        '
        Me.MenuItem422.Index = 2
        Me.MenuItem422.Text = "G352 - Control de Ruta Cartera Normal"
        '
        'MenuItem424
        '
        Me.MenuItem424.Index = 3
        Me.MenuItem424.Text = "G353 - Detalle de Cuota Control de Ruta de Cobro"
        '
        'MenuItem442
        '
        Me.MenuItem442.Index = 5
        Me.MenuItem442.Text = "G36 - Cartera de Préstamos por Gestor"
        '
        'MenuItem444
        '
        Me.MenuItem444.Index = 6
        Me.MenuItem444.Text = "G37 - Cobro Mensual por Ejecutivo"
        '
        'MenuItem446
        '
        Me.MenuItem446.Index = 7
        Me.MenuItem446.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem448, Me.MenuItem449})
        Me.MenuItem446.Text = "G38 - Consolidado  Determinación de Reservas  x Crédito"
        '
        'MenuItem448
        '
        Me.MenuItem448.Index = 0
        Me.MenuItem448.Text = "G380 - Por Tipo de Crédito"
        '
        'MenuItem449
        '
        Me.MenuItem449.Index = 1
        Me.MenuItem449.Text = "G381 - Por Tipo de Garantía"
        '
        'MenuItem450
        '
        Me.MenuItem450.Index = 8
        Me.MenuItem450.Text = "G39 - Reporte de Asociados en Mora"
        '
        'MenuItem312
        '
        Me.MenuItem312.Index = 9
        Me.MenuItem312.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem452, Me.MenuItem453, Me.MenuItem454, Me.MenuItem540, Me.MenuItem548})
        Me.MenuItem312.Text = "G40 - Reportes de Mora"
        '
        'MenuItem452
        '
        Me.MenuItem452.Index = 0
        Me.MenuItem452.Text = "G400 - Mora x Colector"
        '
        'MenuItem453
        '
        Me.MenuItem453.Index = 1
        Me.MenuItem453.Text = "G401 - Mora x Garantía"
        '
        'MenuItem454
        '
        Me.MenuItem454.Index = 2
        Me.MenuItem454.Text = "G402 - Mora x Línea"
        '
        'MenuItem540
        '
        Me.MenuItem540.Index = 3
        Me.MenuItem540.Text = "G403 - A Detalle"
        '
        'MenuItem548
        '
        Me.MenuItem548.Index = 4
        Me.MenuItem548.Text = "G404 - DxC"
        '
        'MenuItem455
        '
        Me.MenuItem455.Index = 10
        Me.MenuItem455.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem475, Me.MenuItem476, Me.MenuItem477, Me.MenuItem478, Me.MenuItem80, Me.MenuItem81})
        Me.MenuItem455.Text = "G41 - Reportes de Reserva "
        '
        'MenuItem475
        '
        Me.MenuItem475.Index = 0
        Me.MenuItem475.Text = "G410 - Documentos por Cobrar"
        '
        'MenuItem476
        '
        Me.MenuItem476.Index = 1
        Me.MenuItem476.Text = "G411 - Créditos Gerenciales con o sin Mora"
        '
        'MenuItem477
        '
        Me.MenuItem477.Index = 2
        Me.MenuItem477.Text = "G412 - Préstamos por Tipo"
        '
        'MenuItem478
        '
        Me.MenuItem478.Index = 3
        Me.MenuItem478.Text = "G413 - Global de Reserva"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 4
        Me.MenuItem80.Text = "G414 - Cartera Documentos en Protesto con Reserva"
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 5
        Me.MenuItem81.Text = "G415 - Consolidado Documentos en Protesto con Reserva"
        '
        'MenuItem512
        '
        Me.MenuItem512.Index = 11
        Me.MenuItem512.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem513, Me.MenuItem514})
        Me.MenuItem512.Text = "G42 - Movimientos Diarios de Préstamos"
        '
        'MenuItem513
        '
        Me.MenuItem513.Index = 0
        Me.MenuItem513.Text = "G420 - Abonos a Préstamos"
        '
        'MenuItem514
        '
        Me.MenuItem514.Index = 1
        Me.MenuItem514.Text = "G421 - Cargos a Préstamos"
        '
        'MenuItem335
        '
        Me.MenuItem335.Index = 12
        Me.MenuItem335.Text = "G43 - Préstamos Sin Gestor"
        '
        'MenuItem384
        '
        Me.MenuItem384.Index = 4
        Me.MenuItem384.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem385, Me.MenuItem386, Me.MenuItem387})
        Me.MenuItem384.Text = "Ve&ntana"
        '
        'MenuItem385
        '
        Me.MenuItem385.Index = 0
        Me.MenuItem385.Text = "Cascada"
        '
        'MenuItem386
        '
        Me.MenuItem386.Index = 1
        Me.MenuItem386.Text = "Vertical"
        '
        'MenuItem387
        '
        Me.MenuItem387.Index = 2
        Me.MenuItem387.Text = "Horizontal"
        '
        'mnuPlanilla
        '
        Me.mnuPlanilla.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem194, Me.MenuItem195, Me.MenuItem217, Me.MenuItem232, Me.MenuItem388})
        '
        'MenuItem194
        '
        Me.MenuItem194.Index = 0
        Me.MenuItem194.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuInicioSesion, Me.mnuSalir, Me.MenuItem159})
        Me.MenuItem194.Text = "&Inicio"
        '
        'mnuInicioSesion
        '
        Me.mnuInicioSesion.Index = 0
        Me.mnuInicioSesion.Text = "A1 - Cerrar Sesión"
        '
        'mnuSalir
        '
        Me.mnuSalir.Index = 1
        Me.mnuSalir.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 2
        Me.MenuItem159.Text = "A3 - &Salir"
        '
        'MenuItem195
        '
        Me.MenuItem195.Index = 1
        Me.MenuItem195.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem196, Me.MenuItem197, Me.MenuItem198, Me.MenuItem201, Me.MenuItem202, Me.MenuItem207, Me.MenuItem210, Me.MenuItem211, Me.MenuItem212, Me.MenuItem213, Me.MenuItem586})
        Me.MenuItem195.Text = "M&antenimientos"
        '
        'MenuItem196
        '
        Me.MenuItem196.Index = 0
        Me.MenuItem196.Text = "K10 - &Áreas"
        '
        'MenuItem197
        '
        Me.MenuItem197.Index = 1
        Me.MenuItem197.Text = "K11 - &Departamentos o Secciones"
        '
        'MenuItem198
        '
        Me.MenuItem198.Index = 2
        Me.MenuItem198.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem199, Me.MenuItem200})
        Me.MenuItem198.Text = "K12 - &Instituciones"
        '
        'MenuItem199
        '
        Me.MenuItem199.Index = 0
        Me.MenuItem199.Text = "K121 - &Externas"
        '
        'MenuItem200
        '
        Me.MenuItem200.Index = 1
        Me.MenuItem200.Text = "K122 - Pensiones - AFP"
        '
        'MenuItem201
        '
        Me.MenuItem201.Index = 3
        Me.MenuItem201.Text = "K13 - Tipos de &Planilla"
        '
        'MenuItem202
        '
        Me.MenuItem202.Index = 4
        Me.MenuItem202.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem203, Me.MenuItem204, Me.MenuItem205, Me.MenuItem206, Me.MenuItem214, Me.MenuItem262})
        Me.MenuItem202.Text = "K14 - &Empleados"
        '
        'MenuItem203
        '
        Me.MenuItem203.Index = 0
        Me.MenuItem203.Text = "K141 - &Tipo de Personal"
        '
        'MenuItem204
        '
        Me.MenuItem204.Index = 1
        Me.MenuItem204.Text = "K142 - &Cargos de Empleados"
        '
        'MenuItem205
        '
        Me.MenuItem205.Index = 2
        Me.MenuItem205.Text = "K143 - Maestro de &Empleados"
        '
        'MenuItem206
        '
        Me.MenuItem206.Index = 3
        Me.MenuItem206.Text = "K144 - &Plazas de Empleados"
        '
        'MenuItem214
        '
        Me.MenuItem214.Index = 4
        Me.MenuItem214.Text = "K145 - Motivos &Retiro"
        '
        'MenuItem262
        '
        Me.MenuItem262.Index = 5
        Me.MenuItem262.Text = "K146 - Grados Académicos"
        '
        'MenuItem207
        '
        Me.MenuItem207.Index = 5
        Me.MenuItem207.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem208, Me.MenuItem209})
        Me.MenuItem207.Text = "K15 - Descuentos &Legales"
        '
        'MenuItem208
        '
        Me.MenuItem208.Index = 0
        Me.MenuItem208.Text = "K151 - &Tabla de Renta"
        '
        'MenuItem209
        '
        Me.MenuItem209.Index = 1
        Me.MenuItem209.Text = "K152 - Descuentos de &ISSS"
        '
        'MenuItem210
        '
        Me.MenuItem210.Index = 6
        Me.MenuItem210.Text = "K16 - Tipos de &Hora Extra"
        '
        'MenuItem211
        '
        Me.MenuItem211.Index = 7
        Me.MenuItem211.Text = "K17 - Tipos de In&greso"
        '
        'MenuItem212
        '
        Me.MenuItem212.Index = 8
        Me.MenuItem212.Text = "K18 - Tipos de De&scuento"
        '
        'MenuItem213
        '
        Me.MenuItem213.Index = 9
        Me.MenuItem213.Text = "K19 - &Motivos Ausentismo"
        '
        'MenuItem586
        '
        Me.MenuItem586.Index = 10
        Me.MenuItem586.Text = "K1A - &Vacaciones"
        '
        'MenuItem217
        '
        Me.MenuItem217.Index = 2
        Me.MenuItem217.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem218, Me.MenuItem219, Me.MenuItem220, Me.MenuItem221, Me.MenuItem222, Me.MenuItem225, Me.MenuItem226, Me.MenuItem126, Me.MenuItem130})
        Me.MenuItem217.Text = "&Movimientos"
        '
        'MenuItem218
        '
        Me.MenuItem218.Index = 0
        Me.MenuItem218.Text = "K21 - Ingreso de &Ausentismos - Incapacidades"
        '
        'MenuItem219
        '
        Me.MenuItem219.Index = 1
        Me.MenuItem219.Text = "K22 - Ingreso de &Vacaciones"
        '
        'MenuItem220
        '
        Me.MenuItem220.Index = 2
        Me.MenuItem220.Text = "K23 - Ingresos de &Horas Extra"
        '
        'MenuItem221
        '
        Me.MenuItem221.Index = 3
        Me.MenuItem221.Text = "K24 - Ingreso de &Descuentos"
        '
        'MenuItem222
        '
        Me.MenuItem222.Index = 4
        Me.MenuItem222.Text = "K25 - &Otros Ingresos"
        '
        'MenuItem225
        '
        Me.MenuItem225.Index = 5
        Me.MenuItem225.Text = "-"
        '
        'MenuItem226
        '
        Me.MenuItem226.Index = 6
        Me.MenuItem226.Text = "K26 - Generación de &Planillas"
        '
        'MenuItem126
        '
        Me.MenuItem126.Index = 7
        Me.MenuItem126.Text = "K27 - Ingreso de Dias Trabajados"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 8
        Me.MenuItem130.Text = "K28 - Modificar Descuentos de Ley"
        '
        'MenuItem232
        '
        Me.MenuItem232.Index = 3
        Me.MenuItem232.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem233, Me.MenuItem234, Me.MenuItem241, Me.MenuItem493, Me.MenuItem590, Me.MenuItem621})
        Me.MenuItem232.Text = "&Reportes"
        Me.MenuItem232.Visible = False
        '
        'MenuItem233
        '
        Me.MenuItem233.Index = 0
        Me.MenuItem233.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem481, Me.MenuItem486, Me.MenuItem487, Me.MenuItem237, Me.MenuItem491, Me.MenuItem236})
        Me.MenuItem233.Text = "K30 - Reportes datos de Empleados"
        '
        'MenuItem481
        '
        Me.MenuItem481.Index = 0
        Me.MenuItem481.Text = "K300 - Datos Personales de Empleados"
        '
        'MenuItem486
        '
        Me.MenuItem486.Index = 1
        Me.MenuItem486.Text = "K301 - Detalle de Documentos"
        '
        'MenuItem487
        '
        Me.MenuItem487.Index = 2
        Me.MenuItem487.Text = "K302 - Detalle de Nombres"
        '
        'MenuItem237
        '
        Me.MenuItem237.Index = 3
        Me.MenuItem237.Text = "K303 - Datos Empleados Cumpleañeros"
        '
        'MenuItem491
        '
        Me.MenuItem491.Index = 4
        Me.MenuItem491.Text = "K304 - Detalle Forma de Pago"
        '
        'MenuItem236
        '
        Me.MenuItem236.Index = 5
        Me.MenuItem236.Text = "K305 - Datos Empleados Activos"
        '
        'MenuItem234
        '
        Me.MenuItem234.Index = 1
        Me.MenuItem234.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem240, Me.MenuItem242, Me.MenuItem490, Me.MenuItem235})
        Me.MenuItem234.Text = "K31 - Reporte de Empleados Agrupados"
        '
        'MenuItem240
        '
        Me.MenuItem240.Index = 0
        Me.MenuItem240.Text = "K310 - Agrupados por Cargo"
        '
        'MenuItem242
        '
        Me.MenuItem242.Index = 1
        Me.MenuItem242.Text = "K311 - Agrupados por Departamento"
        '
        'MenuItem490
        '
        Me.MenuItem490.Index = 2
        Me.MenuItem490.Text = "K312 - Agrupados por Fecha de Ingreso"
        '
        'MenuItem235
        '
        Me.MenuItem235.Index = 3
        Me.MenuItem235.Text = "K313 - Agrupados por Género"
        '
        'MenuItem241
        '
        Me.MenuItem241.Index = 2
        Me.MenuItem241.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem239, Me.MenuItem243, Me.MenuItem492, Me.MenuItem238})
        Me.MenuItem241.Text = "K32 - Reporte de Movimientos"
        '
        'MenuItem239
        '
        Me.MenuItem239.Index = 0
        Me.MenuItem239.Text = "K320 - Tipos de Descuento"
        '
        'MenuItem243
        '
        Me.MenuItem243.Index = 1
        Me.MenuItem243.Text = "K321 - Motivos de Ausentismo"
        '
        'MenuItem492
        '
        Me.MenuItem492.Index = 2
        Me.MenuItem492.Text = "K322 - Vacaciones"
        '
        'MenuItem238
        '
        Me.MenuItem238.Index = 3
        Me.MenuItem238.Text = "K323 - Boleta de Pago"
        '
        'MenuItem493
        '
        Me.MenuItem493.Index = 3
        Me.MenuItem493.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem494, Me.MenuItem495, Me.MenuItem496})
        Me.MenuItem493.Text = "K33 - Constancias"
        '
        'MenuItem494
        '
        Me.MenuItem494.Index = 0
        Me.MenuItem494.Text = "K330 - Constancia de Salario"
        '
        'MenuItem495
        '
        Me.MenuItem495.Index = 1
        Me.MenuItem495.Text = "K331 - Constancia de Trabajo"
        '
        'MenuItem496
        '
        Me.MenuItem496.Index = 2
        Me.MenuItem496.Text = "K332 - Constancia de Referencia Laboral"
        '
        'MenuItem590
        '
        Me.MenuItem590.Index = 4
        Me.MenuItem590.Text = "K34 - Marcaciones Empleados"
        '
        'MenuItem621
        '
        Me.MenuItem621.Index = 5
        Me.MenuItem621.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem626, Me.MenuItem627, Me.MenuItem628})
        Me.MenuItem621.Text = "K35 - Comisiones"
        '
        'MenuItem626
        '
        Me.MenuItem626.Index = 0
        Me.MenuItem626.Text = "K351 - Comisiones Ahorros"
        '
        'MenuItem627
        '
        Me.MenuItem627.Index = 1
        Me.MenuItem627.Text = "K352 - Comisiones Préstamos"
        '
        'MenuItem628
        '
        Me.MenuItem628.Index = 2
        Me.MenuItem628.Text = "K353 - Comisioines Préstamos Gerenciales"
        '
        'MenuItem388
        '
        Me.MenuItem388.Index = 4
        Me.MenuItem388.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem389, Me.MenuItem390, Me.MenuItem391})
        Me.MenuItem388.Text = "Ve&ntana"
        '
        'MenuItem389
        '
        Me.MenuItem389.Index = 0
        Me.MenuItem389.Text = "Cascada"
        '
        'MenuItem390
        '
        Me.MenuItem390.Index = 1
        Me.MenuItem390.Text = "Vertical"
        '
        'MenuItem391
        '
        Me.MenuItem391.Index = 2
        Me.MenuItem391.Text = "Horizontal"
        '
        'mnuGarantias
        '
        Me.mnuGarantias.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem252, Me.MenuItem132, Me.MenuItem488, Me.MenuItem392})
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem76, Me.MenuItem77, Me.MenuItem78})
        Me.MenuItem10.Text = "&Inicio"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 0
        Me.MenuItem76.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 1
        Me.MenuItem77.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 2
        Me.MenuItem78.Text = "A3 - &Salir"
        '
        'MenuItem252
        '
        Me.MenuItem252.Index = 1
        Me.MenuItem252.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem255, Me.MenuItem320, Me.MenuItem415, Me.MenuItem510, Me.MenuItem525})
        Me.MenuItem252.Text = "Mantenimiento"
        '
        'MenuItem255
        '
        Me.MenuItem255.Index = 0
        Me.MenuItem255.Text = "M10 - Garantías"
        '
        'MenuItem320
        '
        Me.MenuItem320.Index = 1
        Me.MenuItem320.Text = "M11 - Secciones del Registro"
        '
        'MenuItem415
        '
        Me.MenuItem415.Index = 2
        Me.MenuItem415.Text = "M12 - Detalle del Préstamo"
        '
        'MenuItem510
        '
        Me.MenuItem510.Index = 3
        Me.MenuItem510.Text = "M13 - Garantías Prendarias"
        '
        'MenuItem525
        '
        Me.MenuItem525.Index = 4
        Me.MenuItem525.Text = "M14 - Garantías Hipotecarias"
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 2
        Me.MenuItem132.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem216})
        Me.MenuItem132.Text = "Movimientos"
        '
        'MenuItem216
        '
        Me.MenuItem216.Index = 0
        Me.MenuItem216.Text = "M30 - Movimientos Garantías"
        '
        'MenuItem488
        '
        Me.MenuItem488.Index = 3
        Me.MenuItem488.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem489, Me.MenuItem443, Me.MenuItem447, Me.MenuItem545, Me.MenuItem546, Me.MenuItem547, Me.MenuItem223, Me.MenuItem565})
        Me.MenuItem488.Text = "Reportes"
        '
        'MenuItem489
        '
        Me.MenuItem489.Index = 0
        Me.MenuItem489.Text = "M20 - Reportes de Créditos x Tipo de Garantía"
        '
        'MenuItem443
        '
        Me.MenuItem443.Index = 1
        Me.MenuItem443.Text = "M21 - Cartera Documentos en Protesto con Reserva"
        '
        'MenuItem447
        '
        Me.MenuItem447.Index = 2
        Me.MenuItem447.Text = "M22 - Reporte de Créditos Hipotecarios"
        '
        'MenuItem545
        '
        Me.MenuItem545.Index = 3
        Me.MenuItem545.Text = "M23 - Créditos sin garantías"
        '
        'MenuItem546
        '
        Me.MenuItem546.Index = 4
        Me.MenuItem546.Text = "M24 - Créditos por Tipo de Hipoteca"
        '
        'MenuItem547
        '
        Me.MenuItem547.Index = 5
        Me.MenuItem547.Text = "M25 - Garantías Prendarias"
        '
        'MenuItem223
        '
        Me.MenuItem223.Index = 6
        Me.MenuItem223.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem224, Me.MenuItem562, Me.MenuItem563, Me.MenuItem564})
        Me.MenuItem223.Text = "M26 - Garantías por Departamento"
        '
        'MenuItem224
        '
        Me.MenuItem224.Index = 0
        Me.MenuItem224.Text = "M261 - Departametos de Cobros"
        '
        'MenuItem562
        '
        Me.MenuItem562.Index = 1
        Me.MenuItem562.Text = "M262 - Departamento de Informatica"
        '
        'MenuItem563
        '
        Me.MenuItem563.Index = 2
        Me.MenuItem563.Text = "M263 - Departamento Juridico"
        '
        'MenuItem564
        '
        Me.MenuItem564.Index = 3
        Me.MenuItem564.Text = "M264 - Departamento de Mercadeo"
        '
        'MenuItem565
        '
        Me.MenuItem565.Index = 7
        Me.MenuItem565.Text = "M27 - Garantías Inscritas"
        '
        'MenuItem392
        '
        Me.MenuItem392.Index = 4
        Me.MenuItem392.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem393, Me.MenuItem394, Me.MenuItem395})
        Me.MenuItem392.Text = "Ve&ntana"
        '
        'MenuItem393
        '
        Me.MenuItem393.Index = 0
        Me.MenuItem393.Text = "Cascada"
        '
        'MenuItem394
        '
        Me.MenuItem394.Index = 1
        Me.MenuItem394.Text = "Vertical"
        '
        'MenuItem395
        '
        Me.MenuItem395.Index = 2
        Me.MenuItem395.Text = "Horizontal"
        '
        'mnuGerenciales
        '
        Me.mnuGerenciales.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem79, Me.MenuItem244, Me.MenuItem396})
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 0
        Me.MenuItem79.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem172, Me.MenuItem191, Me.MenuItem228})
        Me.MenuItem79.Text = "&Inicio"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 0
        Me.MenuItem172.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem191
        '
        Me.MenuItem191.Index = 1
        Me.MenuItem191.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem228
        '
        Me.MenuItem228.Index = 2
        Me.MenuItem228.Text = "A3 - &Salir"
        '
        'MenuItem244
        '
        Me.MenuItem244.Index = 1
        Me.MenuItem244.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem245, Me.MenuItem258, Me.MenuItem259, Me.MenuItem329, Me.MenuItem330, Me.MenuItem331, Me.MenuItem535, Me.MenuItem160, Me.MenuItem268, Me.MenuItem269, Me.MenuItem553, Me.MenuItem555})
        Me.MenuItem244.Text = "Reportes"
        '
        'MenuItem245
        '
        Me.MenuItem245.Index = 0
        Me.MenuItem245.Text = "N11 - &Acumulado de Captación de Depósitos a Plazo Fijo"
        '
        'MenuItem258
        '
        Me.MenuItem258.Index = 1
        Me.MenuItem258.Text = "N12 - Apertura de Préstamos"
        '
        'MenuItem259
        '
        Me.MenuItem259.Index = 2
        Me.MenuItem259.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem260, Me.MenuItem261})
        Me.MenuItem259.Text = "N13 - Membresía de Asociados"
        '
        'MenuItem260
        '
        Me.MenuItem260.Index = 0
        Me.MenuItem260.Text = "N131 - Ingreso Asociados"
        '
        'MenuItem261
        '
        Me.MenuItem261.Index = 1
        Me.MenuItem261.Text = "N132 - Renuncia Asociados"
        '
        'MenuItem329
        '
        Me.MenuItem329.Index = 3
        Me.MenuItem329.Text = "N14 - Consolidado Cartera de Depósitos a Plazo Fijo"
        '
        'MenuItem330
        '
        Me.MenuItem330.Index = 4
        Me.MenuItem330.Text = "N15 - Garantías DPF en Mora "
        '
        'MenuItem331
        '
        Me.MenuItem331.Index = 5
        Me.MenuItem331.Text = "N16 - Movimientos en Cuentas de Ahorro"
        '
        'MenuItem535
        '
        Me.MenuItem535.Index = 6
        Me.MenuItem535.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem536, Me.MenuItem537, Me.MenuItem539, Me.MenuItem541, Me.MenuItem550, Me.MenuItem554})
        Me.MenuItem535.Text = "N17 - Mercadeo"
        '
        'MenuItem536
        '
        Me.MenuItem536.Index = 0
        Me.MenuItem536.Text = "N170 - Reporte Informe Metas Mercadeo "
        '
        'MenuItem537
        '
        Me.MenuItem537.Index = 1
        Me.MenuItem537.Text = "N171 - Informe Metas por Producto Servicio"
        '
        'MenuItem539
        '
        Me.MenuItem539.Index = 2
        Me.MenuItem539.Text = "N172 - Gerencial Acumulado Metas"
        '
        'MenuItem541
        '
        Me.MenuItem541.Index = 3
        Me.MenuItem541.Text = "N173 - Colocación Montos Desembolsados"
        '
        'MenuItem550
        '
        Me.MenuItem550.Index = 4
        Me.MenuItem550.Text = "N174 - Membresía Colocación Captación"
        '
        'MenuItem554
        '
        Me.MenuItem554.Index = 5
        Me.MenuItem554.Text = "N175 - Consolidado Informe Resultados Mercadeo"
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 7
        Me.MenuItem160.Text = "N18 -  Reporte de Colocación de Préstamos Consolidado"
        '
        'MenuItem268
        '
        Me.MenuItem268.Index = 8
        Me.MenuItem268.Text = "N19 - Reporte Gerencial Consolidado Evaluación por año"
        '
        'MenuItem269
        '
        Me.MenuItem269.Index = 9
        Me.MenuItem269.Text = "N20 - Consolidado Resultados Históricos "
        '
        'MenuItem553
        '
        Me.MenuItem553.Index = 10
        Me.MenuItem553.Text = "N21 - &Vencimientos de Cuentas de Ahorros"
        '
        'MenuItem555
        '
        Me.MenuItem555.Index = 11
        Me.MenuItem555.Text = "N22 - Reporte Gerencial Resultados Comparados"
        '
        'MenuItem396
        '
        Me.MenuItem396.Index = 2
        Me.MenuItem396.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem397, Me.MenuItem398, Me.MenuItem399})
        Me.MenuItem396.Text = "Ve&ntana"
        '
        'MenuItem397
        '
        Me.MenuItem397.Index = 0
        Me.MenuItem397.Text = "Cascada"
        '
        'MenuItem398
        '
        Me.MenuItem398.Index = 1
        Me.MenuItem398.Text = "Vertical"
        '
        'MenuItem399
        '
        Me.MenuItem399.Index = 2
        Me.MenuItem399.Text = "Horizontal"
        '
        'mnuActivoFijo
        '
        Me.mnuActivoFijo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem227, Me.MenuItem246, Me.MenuItem156, Me.MenuItem459, Me.MenuItem400})
        '
        'MenuItem227
        '
        Me.MenuItem227.Index = 0
        Me.MenuItem227.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem229, Me.MenuItem230, Me.MenuItem231})
        Me.MenuItem227.Text = "&Inicio"
        '
        'MenuItem229
        '
        Me.MenuItem229.Index = 0
        Me.MenuItem229.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem230
        '
        Me.MenuItem230.Index = 1
        Me.MenuItem230.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem231
        '
        Me.MenuItem231.Index = 2
        Me.MenuItem231.Text = "A3 - &Salir"
        '
        'MenuItem246
        '
        Me.MenuItem246.Index = 1
        Me.MenuItem246.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem248, Me.MenuItem247, Me.MenuItem249, Me.MenuItem253, Me.MenuItem251, Me.MenuItem254, Me.MenuItem256, Me.MenuItem257, Me.MenuItem250})
        Me.MenuItem246.Text = "&Maestros"
        '
        'MenuItem248
        '
        Me.MenuItem248.Index = 0
        Me.MenuItem248.Text = "O11 - &Proveedores"
        '
        'MenuItem247
        '
        Me.MenuItem247.Index = 1
        Me.MenuItem247.Text = "O12 - &Clasificaciones"
        '
        'MenuItem249
        '
        Me.MenuItem249.Index = 2
        Me.MenuItem249.Text = "O13 - &Sub - Clasificaciones"
        '
        'MenuItem253
        '
        Me.MenuItem253.Index = 3
        Me.MenuItem253.Text = "O14 - Agrupaciones"
        '
        'MenuItem251
        '
        Me.MenuItem251.Index = 4
        Me.MenuItem251.Text = "O15 - Tipos Descarga"
        '
        'MenuItem254
        '
        Me.MenuItem254.Index = 5
        Me.MenuItem254.Text = "O16 - &Departamentos"
        '
        'MenuItem256
        '
        Me.MenuItem256.Index = 6
        Me.MenuItem256.Text = "O17 - Sub - Departamentos"
        '
        'MenuItem257
        '
        Me.MenuItem257.Index = 7
        Me.MenuItem257.Text = "O18 - Marcas"
        '
        'MenuItem250
        '
        Me.MenuItem250.Index = 8
        Me.MenuItem250.Text = "O19 - &Activo Fijo"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 2
        Me.MenuItem156.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem157})
        Me.MenuItem156.Text = "Procesos"
        '
        'MenuItem157
        '
        Me.MenuItem157.Index = 0
        Me.MenuItem157.Text = "O30 - &Depreciaciones"
        '
        'MenuItem459
        '
        Me.MenuItem459.Index = 3
        Me.MenuItem459.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem461, Me.MenuItem462, Me.MenuItem497, Me.MenuItem503, Me.MenuItem504, Me.MenuItem505, Me.MenuItem506, Me.MenuItem507})
        Me.MenuItem459.Text = "&Reportes"
        '
        'MenuItem461
        '
        Me.MenuItem461.Index = 0
        Me.MenuItem461.Text = "O20 - &Activo Fijo Global"
        '
        'MenuItem462
        '
        Me.MenuItem462.Index = 1
        Me.MenuItem462.Text = "O21 - Activo Fijo por &Departamento"
        '
        'MenuItem497
        '
        Me.MenuItem497.Index = 2
        Me.MenuItem497.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem498, Me.MenuItem499, Me.MenuItem500, Me.MenuItem501, Me.MenuItem502})
        Me.MenuItem497.Text = "O22 - Activo Fijo por Agrupación"
        '
        'MenuItem498
        '
        Me.MenuItem498.Index = 0
        Me.MenuItem498.Text = "O220 - Activo Fijo (Accesorios)"
        '
        'MenuItem499
        '
        Me.MenuItem499.Index = 1
        Me.MenuItem499.Text = "O221 - Activo Fijo Instalaciones"
        '
        'MenuItem500
        '
        Me.MenuItem500.Index = 2
        Me.MenuItem500.Text = "O222 - Activo Fijo (Mobiliario y Equipo)"
        '
        'MenuItem501
        '
        Me.MenuItem501.Index = 3
        Me.MenuItem501.Text = "O223 - Activo Fijo con Depreciación"
        '
        'MenuItem502
        '
        Me.MenuItem502.Index = 4
        Me.MenuItem502.Text = "O224 - Activo Fijo x Agrupación"
        '
        'MenuItem503
        '
        Me.MenuItem503.Index = 3
        Me.MenuItem503.Text = "O23 - Activo Fijo (Asignado a Empleado)"
        '
        'MenuItem504
        '
        Me.MenuItem504.Index = 4
        Me.MenuItem504.Text = "O24 - Activo Fijo Vigentes"
        '
        'MenuItem505
        '
        Me.MenuItem505.Index = 5
        Me.MenuItem505.Text = "O25 - Activo Fijo con Valor"
        '
        'MenuItem506
        '
        Me.MenuItem506.Index = 6
        Me.MenuItem506.Text = "O26 - Detalle Depreciaciones Activo Fijo"
        '
        'MenuItem507
        '
        Me.MenuItem507.Index = 7
        Me.MenuItem507.Text = "O27 - Activo Fijo x Sub-Clasificación"
        '
        'MenuItem400
        '
        Me.MenuItem400.Index = 4
        Me.MenuItem400.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem401, Me.MenuItem402, Me.MenuItem403})
        Me.MenuItem400.Text = "Ve&ntana"
        '
        'MenuItem401
        '
        Me.MenuItem401.Index = 0
        Me.MenuItem401.Text = "Cascada"
        '
        'MenuItem402
        '
        Me.MenuItem402.Index = 1
        Me.MenuItem402.Text = "Vertical"
        '
        'MenuItem403
        '
        Me.MenuItem403.Index = 2
        Me.MenuItem403.Text = "Horizontal"
        '
        'mnuGeneral
        '
        Me.mnuGeneral.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem270, Me.MenuItem274, Me.MenuItem336, Me.MenuItem404})
        '
        'MenuItem270
        '
        Me.MenuItem270.Index = 0
        Me.MenuItem270.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem271, Me.MenuItem272, Me.MenuItem273})
        Me.MenuItem270.Text = "&Inicio"
        '
        'MenuItem271
        '
        Me.MenuItem271.Index = 0
        Me.MenuItem271.Text = "A1 - Cerrar Sesión"
        '
        'MenuItem272
        '
        Me.MenuItem272.Index = 1
        Me.MenuItem272.Text = "A2 - Cargar Aplicación"
        '
        'MenuItem273
        '
        Me.MenuItem273.Index = 2
        Me.MenuItem273.Text = "A3 - &Salir"
        '
        'MenuItem274
        '
        Me.MenuItem274.Index = 1
        Me.MenuItem274.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem275, Me.MenuItem50, Me.MenuItem277, Me.MenuItem515, Me.MenuItem534, Me.MenuItem483, Me.MenuItem667})
        Me.MenuItem274.Text = "Mantenimiento"
        '
        'MenuItem275
        '
        Me.MenuItem275.Index = 0
        Me.MenuItem275.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem276})
        Me.MenuItem275.Text = "L10 - Parámetros de Ahorros"
        '
        'MenuItem276
        '
        Me.MenuItem276.Index = 0
        Me.MenuItem276.Text = "L100 - Parámetros por Tipo de Ahorro"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 1
        Me.MenuItem50.Text = "L11 - Parámetros Generales"
        '
        'MenuItem277
        '
        Me.MenuItem277.Index = 2
        Me.MenuItem277.Text = "L12 - Parámetros de Caja"
        '
        'MenuItem515
        '
        Me.MenuItem515.Index = 3
        Me.MenuItem515.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem516, Me.MenuItem517, Me.MenuItem518, Me.MenuItem519, Me.MenuItem520, Me.MenuItem521, Me.MenuItem522, Me.MenuItem523, Me.MenuItem153})
        Me.MenuItem515.Text = "L13 - Genéricos"
        '
        'MenuItem516
        '
        Me.MenuItem516.Index = 0
        Me.MenuItem516.Text = "L130 - &Nacionalidades"
        '
        'MenuItem517
        '
        Me.MenuItem517.Index = 1
        Me.MenuItem517.Text = "L131 - &Profesiones"
        '
        'MenuItem518
        '
        Me.MenuItem518.Index = 2
        Me.MenuItem518.Text = "L132 - C&ooperativas"
        '
        'MenuItem519
        '
        Me.MenuItem519.Index = 3
        Me.MenuItem519.Text = "L133 - &Municipios"
        '
        'MenuItem520
        '
        Me.MenuItem520.Index = 4
        Me.MenuItem520.Text = "L134 - &Ejecutivos de Mercadeo"
        '
        'MenuItem521
        '
        Me.MenuItem521.Index = 5
        Me.MenuItem521.Text = "L135 - &Cobradores"
        '
        'MenuItem522
        '
        Me.MenuItem522.Index = 6
        Me.MenuItem522.Text = "L136 - &Sucursales"
        '
        'MenuItem523
        '
        Me.MenuItem523.Index = 7
        Me.MenuItem523.Text = "L137 - &Parentescos"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 8
        Me.MenuItem153.Text = "L138 - &Departamentos"
        '
        'MenuItem534
        '
        Me.MenuItem534.Index = 4
        Me.MenuItem534.Text = "L14 - Planificación de Ejecutivos"
        '
        'MenuItem483
        '
        Me.MenuItem483.Index = 5
        Me.MenuItem483.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem484, Me.MenuItem485})
        Me.MenuItem483.Text = "L15 - Mantenimiento de Catalogos"
        '
        'MenuItem484
        '
        Me.MenuItem484.Index = 0
        Me.MenuItem484.Text = "L151 - Maestro de Catalogos"
        '
        'MenuItem485
        '
        Me.MenuItem485.Index = 1
        Me.MenuItem485.Text = "L152 - Detalle de Catalogo"
        '
        'MenuItem667
        '
        Me.MenuItem667.Index = 6
        Me.MenuItem667.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem668, Me.MenuItem669})
        Me.MenuItem667.Text = "L16 - Rutas Mercadeo"
        '
        'MenuItem668
        '
        Me.MenuItem668.Index = 0
        Me.MenuItem668.Text = "L161 - Ingresar Rutas"
        '
        'MenuItem669
        '
        Me.MenuItem669.Index = 1
        Me.MenuItem669.Text = "L162 - Reporte de Rutas"
        '
        'MenuItem336
        '
        Me.MenuItem336.Index = 2
        Me.MenuItem336.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem337})
        Me.MenuItem336.Text = "Procesos"
        '
        'MenuItem337
        '
        Me.MenuItem337.Index = 0
        Me.MenuItem337.Text = "L20 - Proceso de carga de Planilla de descuentos"
        '
        'MenuItem404
        '
        Me.MenuItem404.Index = 3
        Me.MenuItem404.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem405, Me.MenuItem406, Me.MenuItem407})
        Me.MenuItem404.Text = "Ve&ntana"
        '
        'MenuItem405
        '
        Me.MenuItem405.Index = 0
        Me.MenuItem405.Text = "Cascada"
        '
        'MenuItem406
        '
        Me.MenuItem406.Index = 1
        Me.MenuItem406.Text = "Vertical"
        '
        'MenuItem407
        '
        Me.MenuItem407.Index = 2
        Me.MenuItem407.Text = "Horizontal"
        '
        'MenuItem653
        '
        Me.MenuItem653.Index = 13
        Me.MenuItem653.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem654})
        Me.MenuItem653.Text = "C3E - Oficialia "
        '
        'MenuItem654
        '
        Me.MenuItem654.Index = 0
        Me.MenuItem654.Text = "C3E1 - Detalle de Transacciones Efectivo - Cheque"
        '
        'frmMAIN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1262, 775)
        Me.Controls.Add(Me.stbMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.mnuInicio
        Me.Name = "frmMAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sbp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        'Dim ofrmApp As New frmModulo
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuA2.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Me.Close()
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuA3.Click
        Me.Close()
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        Me.Close()
    End Sub

    Private Sub frmMAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui
    End Sub

    Private Sub frmMAIN_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MsgBox("¿Esta seguro que desea cerrar la Aplicación?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Atención") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Application.Exit()
        End If
    End Sub



    'Menu Niveles Contables
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click

    End Sub

    'Menu Niveles de Centros Costos
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Dim frmCatCostos As New frmMCatCostos
        frmCatCostos.MdiParent = Me
        frmCatCostos.WindowState = FormWindowState.Normal
        frmCatCostos.Show()
    End Sub
    'Menu Niveles de Centros Beneficios
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim frmCatBenef As New frmMCatBeneficios
        frmCatBenef.MdiParent = Me
        frmCatBenef.WindowState = FormWindowState.Normal
        frmCatBenef.Show()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim frmPar As frmMPartidas = New frmMPartidas
        frmPar.MdiParent = Me
        frmPar.WindowState = FormWindowState.Normal
        frmPar.Show()
    End Sub

    Private Sub mnuMReferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMReferencias.Click
        Dim ofrm As New frmMReferencia
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMBeneficiarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMBeneficiarios.Click
        Dim ofrm As New frmMBeneficiarios
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMAspectosCoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMAspectosCoop.Click
        Dim ofrm As New frmMAspCoopAsoc
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMSolRetiroVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMSolRetiroVol.Click
        Dim ofrm As New frmMSolicitudRetiro
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMProcRetiroVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMProcRetiroVol.Click
        Dim ofrm As New frmMProcesoRetiro
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMInhabilitacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMInhabilitacion.Click
        Dim ofrm As New frmMInhabilitacion
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMExclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMExclusion.Click
        Dim ofrm As New frmMExclusion
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMFallecimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMFallecimiento.Click
        Dim ofrm As New frmMFallecimiento
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        Me.Close()
    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        Me.Close()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        'Procesar Mes Saldos Contables
        Dim ofrm As New frmProcSaldosTotales ' frmProcSaldos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMantCandidatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMAsociados
        ofrm.MdiParent = Me
        ofrm.oTipo = 0
        ofrm.Show()
    End Sub

    Private Sub mnuMantAspirantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMAsociados
        ofrm.MdiParent = Me
        ofrm.oTipo = 1
        ofrm.Show()
    End Sub

    Private Sub mnuMantAsociados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMAsociados
        ofrm.MdiParent = Me
        ofrm.oTipo = 2
        ofrm.Show()
    End Sub

    Private Sub mnuMLibroAsoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMLibroAsoc.Click
        Dim ofrm As New frmMLibroAsociados
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMEstadoAdmision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMEstadoAdmision.Click
        Dim ofrm As New frmEstadoIngAsociado
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem85.Click
        Dim ofrm As New frmMActivaAsociado
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub mnuMaestroPrestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaestroPrestamos.Click
        Dim ofrm As New frmMPrestamos
        ofrm.MdiParent = Me
        ofrm.setModulo = frmMPrestamos.Modulo.Creditos
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem87.Click
        Dim ofrm As New frmMCrTiposCredito
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        Dim ofrm As New frmMCrTipoIngreso
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        Dim ofrm As New frmMCrTipoGasto
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem91.Click
        Dim ofrm As New frmMCrTipoGarantia
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        Dim ofrm As New frmMCreditos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
        Dim ofrm As New frmCRTablaAmort
        ofrm.dtpFecha.Value = Now
        ofrm.dtpFechaEmision.Value = Now
        ofrm.btnAsignar1.Visible = False
        ofrm.Show()
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        Dim ofrm As New frmMsPRProvision
        ofrm.Show()
    End Sub

    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem62_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem63_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        Me.Close()
    End Sub

    'SE COMENTARIO EL SIGUIENTE PROCEDIMIENTO SOBRE EL FRMSPLASH 
    'Private Sub frmMAIN_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    '    Static x As Integer
    '    x += 1
    '    If x = 1 Then
    '        Dim ox As New sifLib.frmSplash
    '    End If
    'End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        CierraForms(MenuItem2.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.MdiParent = Me
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim ofrm As New frmMPRReversion  'frmMsPRReversion
        ofrm.ShowDialog()
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Dim ofrm As New frmMBCBancos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Dim ofrm As New frmMBCCuentasBancos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        Dim ofrm As New frmMBCCheques
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        Dim ofrm As New frmMAhCuentasAhorro
        ofrm.MdiParent = Me
        'ofrm.WindowState = FormWindowState.Normal

        ofrm.Show()

    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        Me.Close()
    End Sub

    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        Dim ofrm As New frmMAhCuentasAportacion
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem71_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        Dim ofrm As New frmMsConsProv
        ofrm.Show()
    End Sub

    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem93.Click
        Dim ofrm As New frmProcTrasDiarioBco
        ofrm.Show()
    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        Dim ofrm As New frmRepPRDetallePrestamo
        ofrm.Titulo = "Detalle de Préstamo"
        ofrm.NumReporte = 1
        ofrm.Show()
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        Me.Close()
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        CierraForms(MenuItem46.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem99.Click
        Dim ofrm As New frmMsAhProvisiones
        ofrm.Show()
    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        Dim ofrm As New frmMsAhConProv
        ofrm.Show()
    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        Dim ofrm As New frmMAhFechasCap
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
        Dim ofrm As New frmMsCaLogin
        ofrm.Origen = "A"
        ofrm.Show()
    End Sub

    Private Sub MenuItem70_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMAhParametros
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem106.Click
        Dim ofrm As New frmMsAhListCtasProrrog
        ofrm.Show()
    End Sub

    Private Sub MenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem107.Click
        Dim ofrm As New frmMAhCuentasAhorroDPF
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem109.Click
        Dim ofrm As New frmMSConsultaMovimientosCuentas
        ofrm.TipoCuenta = 0
        ofrm.Show()
    End Sub

    Private Sub MenuItem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem110.Click
        Dim ofrm As New frmMAhTasasInteres
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem112.Click
        Dim ofrm As New frmMSConsultaMovimientosCuentas
        ofrm.TipoCuenta = 1
        ofrm.Show()
    End Sub

    Private Sub MenuItem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem113.Click
        Dim ofrm As New frmMClasifRiesgo
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem119.Click
        Dim ofrm As New frmMCBTipoGestion
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        CierraForms(MenuItem61.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem117.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem118.Click
        Me.Close()
    End Sub

    Private Sub MenuItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem120.Click
        Dim ofrm As New frmMCBTipoCobranza
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem121.Click
        Dim ofrm As New frmMCBGestores
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMsSaldosHistoricos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub MenuItem123_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem123.Click
        Dim ofrm As New frmMsCierreContable
        ofrm.Show()
    End Sub

    Private Sub MenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem125.Click
        Dim ofrm As New frmMsAsistInicioContable
        ofrm.Show()
    End Sub

    Private Sub MenuItem126_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMCBBienesEMbargados
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem128_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem128.Click
        Dim ofrm As New frmMBCEmbargos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem122_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem122.Click
        Dim ofrm As New frmMCBBitacoraGestores
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem127_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem127.Click
        Dim ofrm As New frmMCBGestionCredito
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmRepAhAperturaCtas
        ofrm.Show()
    End Sub

    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click
        Dim ofrm As New frmMCajeros
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem69_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        Dim ofrm As New frmMItemsFact
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem136.Click
        Dim ofrm As New frmMCAMaestroCajas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem143.Click
        Dim ofrm As New frmMsCaLogin
        ofrm.Origen = "C"
        ofrm.Show()
        If ofrm.Pass = True Then
            Dim ofrm1 As New frmMsCaCierreCaja
            ofrm1.CodCajero = ofrm.CodCajero
            ofrm1.Show()
            ofrm.Dispose()
        Else
            ofrm.Dispose()
        End If
    End Sub

    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click
        Dim ofrm As New frmReporteCorteCaja
        ofrm.Show()
    End Sub

    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        Dim ofrm As New frmReporteEstadoCuentaAhorroAportaciones
        ofrm.Tipo = "A"
        ofrm.Show()
    End Sub

    Private Sub MenuItem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem150.Click
        Dim ofrm As New frmRepAhVencimientos
        ofrm.Text = "Vencimientos Cuentas de Ahorros"
        ofrm.Tipo = "P"
        ofrm.Show()
    End Sub

    Private Sub MenuItem152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem152.Click
        Dim ofrm As New frmReporteEstadoCuentaAhorroAportaciones
        ofrm.Tipo = "P"
        ofrm.Show()
    End Sub

    Private Sub MenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem144.Click
        Dim ofrm As New frmMsCaPosteoLibretas
        ofrm.Show()
    End Sub

    Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        CierraForms(MenuItem31.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem159.Click
        Me.Close()
    End Sub

    Private Sub MenuItem196_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem196.Click
        Dim ofrm As New frmMPLAreas
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem197_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem197.Click
        Dim ofrm As New frmMPLDepartamentos
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem199_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem199.Click
        Dim ofrm As New frmMPLInstituciones
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem200.Click
        Dim ofrm As New frmMPLPensiones
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem201.Click
        Dim ofrm As New frmMPLTipoPlanilla
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem203.Click
        Dim ofrm As New frmMPLTipoPersonal
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem204_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem204.Click
        Dim ofrm As New frmMPLCargos
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem205_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem205.Click
        Dim ofrm As New frmMPLEmpleados
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem206_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem206.Click
        Dim ofrm As New frmMPLPlazas
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem208_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem208.Click
        Dim ofrm As New frmMPLDescuentosRenta
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem209_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem209.Click
        Dim ofrm As New frmMPLDescuentosISSS
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem210.Click
        Dim ofrm As New frmMPLTipoHoraExtra
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem211.Click
        Dim ofrm As New frmMPLTipoIngreso
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem212.Click
        Dim ofrm As New frmMPLTiposDescuentos
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem213_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem213.Click
        Dim ofrm As New frmMPLMotivoAusentismo
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem214_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem214.Click
        Dim ofrm As New frmMPLMotivoRetiro
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem218_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem218.Click
        Dim ofrm As New frmMPLAusentismo
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem219_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem219.Click
        Dim ofrm As New frmMPLVacaciones
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem220_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem220.Click
        Dim ofrm As New frmMPLHorasExtra
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem221.Click
        Dim ofrm As New frmMPLDescuentos
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem222_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem222.Click
        Dim ofrm As New frmMPLIngresos
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem226_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem226.Click
        Dim ofrm As New frmMPLPlanilla
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem161_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem161.Click
        Dim ofrm As New frmMsRepCACheques
        ofrm.pTipo = "D"
        ofrm.Show()
    End Sub

    Private Sub MenuItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem148.Click
        Dim ofrm As New frmMDirectivos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem162_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem162.Click
        Dim ofrm As New frmMASTiposCuota
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem164.Click
        Dim ofrm As New frmMsRepCACorte
        ofrm.Show()
    End Sub

    Private Sub MenuItem166_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem166.Click
        Dim ofrm As New frmRptCobroInactividad
        ofrm.vTipo = "B"
        ofrm.Show()
    End Sub

    Private Sub MenuItem167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem167.Click
        Dim ofrm As New frmMsAhCuentasInactivas
        ofrm.Show()
    End Sub

    Private Sub MenuItem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmListadoCarteraPrestamos
        ofrm.NumReporte = "0"
        ofrm.Show()
    End Sub

    Private Sub MenuItem170_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem170.Click
        Dim ofrm As New frmMMovCaja
        ofrm.TipoMov = 0
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub


    Private Sub MenuItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem133.Click
        Dim ofrm As New frmRptConcentracionGestion
        ofrm.Tipo = "R"
        ofrm.Show()
    End Sub

    Private Sub MenuItem173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem173.Click
        Dim ofrm As New frmMCategoriaRiesgo
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem174_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem174.Click
        Dim ofrm As New frmMDICOM
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem175_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem175.Click
        Dim ofrm As New frmConsultaDICOM
        ofrm.Show()
    End Sub

    Private Sub MenuItem178_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem178.Click
        Dim ofrm As New frmCPignoracion
        ofrm.Show()
    End Sub

    Private Sub MenuItem179_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem179.Click
        Dim ofrm As New frmRptCobroInactividad
        ofrm.vTipo = "A"
        ofrm.Show()
    End Sub

    Private Sub MenuItem181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem181.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "24"
        ofrm.Titulo = "Reporte de Documentos por Cobrar"
        ofrm.Show()
    End Sub

    Private Sub MenuItem185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem185.Click
        Dim ofrm As New frmRepCartaInformativa
        ofrm.Show()
    End Sub

    Private Sub MenuItem183_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Modificación 05/11/2012
        'Javier Escobar Martinez
        'Correccion por registros duplicados e importacion a Reporti  ng Services
        'Dim ofrm As New frmRepColocacionCredito
        'ofrm.NumReporte = 1
        'ofrm.show()
        Dim ofrm As New frmVisorRS
        OpcionRS = 24 'Colocación por Garantia
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem187.Click
        'Dim ofrm As New frmMsCBRepDocsXCobrar
        'ofrm.Tipo = "S"
        'ofrm.show()
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "28"
        ofrm.chkMora.Visible = True
        ofrm.chkMora.Text = "Liquidados"
        ofrm.Titulo = "Reporte de Préstamos Saneados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem188_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem188.Click
        'Dim ofrm As New frmMsCBRepDocsXCobrar
        'ofrm.Tipo = "P"
        'ofrm.show()
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "29"
        ofrm.Titulo = "Reporte de Préstamos No Saneados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem184_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmRptAperturaCuenta
        ofrm.Text = "Colocación de Créditos por Ejecutivo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem190_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem190.Click
        Dim ofrm As New frmProcesarDividendos
        ofrm.Show()
    End Sub

    Private Sub MenuItem192_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem192.Click
        Dim ofrm As New frmMsAutorizaPartida
        ofrm.Show()
    End Sub

    'Private Sub MenuItem193_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem193.Click
    '    'Dim ofrm As New frmMCrPagadurias
    '    'ofrm.MdiParent = Me
    '    'ofrm.Show()
    'End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuB14.Click
    End Sub

    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuB11.Click
        Dim ofrm As New frmMRol
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuB12.Click
        Dim ofrm As New frmMUsuarios
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem228_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuB13.Click
        Dim ofrm As New frmMUsuarioporRol
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuB15.Click
        Dim ofrm As New frmConsultaBitacora
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        CierraForms(MenuItem51.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub mnuA1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuA1.Click
        CierraForms(mnuA1.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        CierraForms(MenuItem36.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        CierraForms(MenuItem41.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem116.Click
        CierraForms(MenuItem116.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub mnuInicioSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInicioSesion.Click
        CierraForms(mnuInicioSesion.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub CierraForms(ByVal pText As String)
        If pText.Trim = "A1 - Cerrar Sesión" Then
            Dim oApp As New wrAdmin.wsLibAdmin
            oApp.CierraSesion(sUsuario, sPassword, sSucursal)
        End If
        Dim frm As Form
        For Each frm In ofrmMain.MdiChildren
            frm.Dispose()
        Next
        Me.Refresh()
    End Sub

    Private Sub MenuItem9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim ofrm As New frmMsProcesos
        ofrm.Show()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim ofrm As New frmMSGPrivilegios
        ofrm.Show()
    End Sub

    Private Sub MenuItem255_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem255.Click
        Dim ofrm As New frmMGarantias
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem76_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        CierraForms(MenuItem76.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem77_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem78_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        Me.Close()
    End Sub

    Private Sub MenuItem228_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem228.Click
        Me.Close()
    End Sub

    Private Sub MenuItem245_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem245.Click
        'Dim ofrm As New frmRepCaptacionDPF
        'ofrm.show()
    End Sub

    Private Sub MenuItem172_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem172.Click
        CierraForms(MenuItem172.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem231_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem231.Click
        Me.Close()
    End Sub

    Private Sub MenuItem191_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem191.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem230_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem230.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem229_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem229.Click
        CierraForms(MenuItem229.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem247_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem247.Click
        'Dim ofrm As New frmMAFClasificaciones
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem248_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem248.Click
        'Dim ofrm As New frmMAFProveedores
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem249_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem249.Click
        'Dim ofrm As New frmMAFSubClasificaciones
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem250_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem250.Click
        'Dim ofrm As New frmMAFActivos
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem253_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem253.Click
        'Dim ofrm As New frmMAFAgrupaciones
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem251_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem251.Click
        'Dim ofrm As New frmMAFTipoDescargas
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem257_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem257.Click
        'Dim ofrm As New frmMAFMarcas
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem256_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem256.Click
        'Dim ofrm As New frmMAFSubDepartamentos
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem254_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem254.Click
        'Dim ofrm As New frmMAFDepartamentos
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem258_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem258.Click
        'Dim ofrm As New frmRepPrestamosGer
        'ofrm.show()
    End Sub

    Private Sub MenuItem260_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem260.Click
        'Dim ofrm As New frmIngresoAsociados
        'ofrm.show()
    End Sub

    Private Sub MenuItem262_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem262.Click
        Dim ofrm As New frmMPLGradoAcademico
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem264_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem264.Click
        Dim ofrm As New frmMCaFactura
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem265_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem265.Click
        Dim ofrm As New frmMMovCaja
        ofrm.TipoMov = 1
        'ofrm.lblTitulo.Text = "Mantenimiento - Faltantes y Sobrantes de Caja"
        ofrm.Text = "Faltantes y Sobrantes de Caja"
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem266_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem266.Click
        Dim ofrm As New frmMCREmpValuadoras
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem176_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem176.Click
        Dim ofrm As New frmMCrValuos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem271_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem271.Click
        CierraForms(MenuItem271.Text)
        Dim ofrm As New frmInicioSesion
        ofrm.Show()
        If ofrm.Ingreso = True Then
            Me.MenuItem5.Enabled = True
            Me.stbMain.Panels(0).Text = "Usuario: " & ofrm.Usuario
            Me.stbMain.Panels(1).Text = "Hora de Ingreso al Sistema: " & DateTime.Now.TimeOfDay.ToString
        End If
    End Sub

    Private Sub MenuItem272_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem272.Click
        Dim ofrmApp As New frmModulo
        ofrmApp.MdiParent = Me
        ofrmApp.Show()
    End Sub

    Private Sub MenuItem273_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem273.Click
        Me.Close()
    End Sub

    Private Sub MenuItem276_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem276.Click
        Dim ofrm As New frmMAhParametros
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem70_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem70.Click
        Dim ofrm As New frmMCaReversiones
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem108.Click
        Dim ofrm As New frmRepMovCajaxDoc
        ofrm.Text = "Resumen de Movimientos de Caja (Documento)"
        ofrm.Tipo = "0"
        ofrm.Show()
    End Sub

    Private Sub MenuItem278_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem278.Click
        Dim ofrm As New frmRepMovCajaxDoc
        ofrm.Text = "Resumen de Movimientos de Caja (Transacciones)"
        ofrm.Tipo = "1"
        ofrm.Show()
    End Sub

    Private Sub MenuItem279_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem279.Click
        Dim ofrm As New frmRepMovCajaxDoc
        ofrm.Text = "Corte de Movimientos de Caja"
        ofrm.Tipo = "2"
        ofrm.Show()
    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        Dim ofrm As New frmMsGnParametros
        ofrm.Show()
    End Sub

    Private Sub MenuItem280_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem280.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 40 'Arqueo
        ' ofrm.MdiParent = Me
        ofrm.Show()
        'Dim ofrm As New frmRepMovCajaxDoc
        'ofrm.Text = "Arqueo de Efectivo"
        'ofrm.Tipo = "3"
        'ofrm.show()
    End Sub

    Private Sub MenuItem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem180.Click
        Dim ofrm As New frmMPRDescuentos
        'ofrm.TipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion
        ofrm.TipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem281_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem281.Click
        Dim ofrm As New frmMPRDescuentos
        'ofrm.TipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Honorario
        ofrm.TipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Honorario
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem282_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem282.Click
        Dim ofrm As New frmMPRDescuentos
        'ofrm.TipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion
        ofrm.TipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem147.Click
        Dim ofrm As New frmMCBDocumentosxRecuperar
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem139.Click
        Dim ofrm As New frmMGarantias
        ofrm.Text = "Mantenimiento Certificación Extractada"
        'ofrm.btInscripcio.Visible = False
        'ofrm.btnModificar.Visible = False
        'ofrm.btnCertExt.Location = New Point(3, 16)
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem286_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem286.Click
        'Balance de Comprobación
        Dim ofrm As New frmRepBalComprob

        ofrm.Show()
    End Sub

    Private Sub MenuItem287_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem287.Click
        Dim ofrm As New frmRepBalGral
        ofrm.Show()
    End Sub

    Private Sub MenuItem288_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem288.Click
        Dim ofrm As New Index 'frmVisorRep
        'ofrm.Reporte = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.CatalogoCuentas
        'ofrm.Reporte = sifLib.Contabilidad.clsContabs.ReportesContabilidad.CatalogoCuentas
        ofrm.Show()
    End Sub

    Private Sub MenuItem289_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem289.Click
        Dim ofrm As New frmRepPartidas
        ofrm.Show()
    End Sub

    Private Sub MenuItem290_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem290.Click
        'Dim ofrm As New frmRepEstResult
        Dim ofrm As New wfESTADO_RES
        ofrm.Show()
    End Sub

    Private Sub MenuItem291_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem291.Click
        Dim ofrm As New frmRepAuxMayor
        ofrm.Show()
    End Sub

    Private Sub MenuItem292_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem292.Click
        Dim ofrm As New frmRepDiarioMayor
        ofrm.Show()
    End Sub

    Private Sub MenuItem293_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem293.Click
        Dim ofrm As New frmRepBcoMovCheques
        ofrm.Show()
    End Sub

    Private Sub MenuItem294_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem294.Click
        Dim ofrm As New frmRepMovxCta
        ofrm.Show()
    End Sub

    Private Sub MenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem96.Click
        Dim frmPar As frmMPartidasAut = New frmMPartidasAut
        frmPar.MdiParent = Me
        frmPar.WindowState = FormWindowState.Normal
        frmPar.Show()
    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        Dim ofrm As New frmVisorRS 'Detalle de Transacciones de Asociados
        OpcionRS = 63
        ofrm.MdiParent = Me
        ofrm.Show()
        'Dim ofrm As New frmMsReporteIII
        'ofrm.NumReporte = "0"
        'ofrm.Titulo = "Saldos de Aportaciones"
        'ofrm.show()
    End Sub

    Private Sub MenuItem295_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem295.Click
        Dim ofrm As New frmVisorRS 'Detalle de Transacciones de Asociados
        OpcionRS = 62
        ofrm.MdiParent = Me
        ofrm.Show()
        'Dim ofrm As New frmMsReporteIII
        'ofrm.NumReporte = "2"
        'ofrm.Titulo = "Saldos Cuentas de Ahorro"
        'ofrm.show()
    End Sub

    Private Sub MenuItem296_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem296.Click
        Dim ofrm As New frmVisorRS 'Detalle de Transacciones de Asociados
        OpcionRS = 64
        ofrm.MdiParent = Me
        ofrm.Show()
        'Dim ofrm As New frmMsReporteIII
        'ofrm.NumReporte = "1"
        'ofrm.Titulo = "Saldos por Depósitos a Plazo Fijo"
        'ofrm.show()
    End Sub

    Private Sub MenuItem297_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem297.Click
        Dim frm As New frmVisorRS
        OpcionRS = 72
        frm.MdiParent = Me
        frm.Show()
        'Dim ofrm As New frmMsReporteIII
        'ofrm.NumReporte = "3"
        'ofrm.Titulo = "Saldo de Préstamos para Aseguradora"
        'ofrm.show()
    End Sub

    Private Sub MenuItem298_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem298.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "4"
        ofrm.Titulo = "Intereses por Asociados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem300_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem300.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "5"
        ofrm.Titulo = "Saldos por Asociados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem301_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem301.Click
        Dim ofrm As New frmMsReporteDUI
        ofrm.NumReporte = "0"
        ofrm.Titulo = "Cuentas de Asociados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem302_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem302.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "6"
        ofrm.Titulo = "Saldos de Préstamos Administrativos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem303_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem303.Click
        Dim ofrm As New frmMsAhPignoracion
        ofrm.Show()
    End Sub

    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem104.Click
        Dim ofrm As New frmMsActivaAportacion
        ofrm.Show()
    End Sub

    Private Sub MenuItem304_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem304.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "7"
        ofrm.Titulo = "Saldos de Préstamos Jurídicos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem305_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem305.Click
        Dim ofrm As New frmMsAhReversiones
        ofrm.TipoDeposito = "0" 'Ahorro
        ofrm.Show()
    End Sub

    Private Sub MenuItem306_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem306.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "7"
        ofrm.Titulo = "Saldos de Aportaciones canceladas por período"
        ofrm.Show()
    End Sub

    Private Sub MenuItem308_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem308.Click

        Dim ofrm As New frmVisorRS

        OpcionRS = 35 'Vencimiento DPF Jefaturas
        ofrm.MdiParent = Me
        ofrm.Show()
        'Dim ofrm As New frmMsReporteIII
        'ofrm.NumReporte = "9"
        'ofrm.Titulo = "Vencimientos DPF"
        'ofrm.show()
    End Sub

    Private Sub MenuItem310_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem310.Click
        'Reporte de Saldos por Tipos de Préstamos
        Dim ofrm As New frmRepPRSaldosxTipo
        ofrm.Show()
    End Sub

    Private Sub MenuItem311_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem311.Click
        'Reporte de Saldos por Líneas de Préstamos
        Dim ofrm As New frmRepPRSaldosxLinea
        ofrm.Show()
    End Sub

    Private Sub MenuItem315_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem315.Click
        Dim ofrm As New frmMsAsRepIng
        ofrm.Text = "Reporte de Retiros de Asociados"
        ofrm.Tipo = "T"
        ofrm.Show()
    End Sub

    Private Sub MenuItem316_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem316.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 73
        ofrm.MdiParent = Me
        ofrm.Show()
        'Dim ofrm As New frmMsAsRepIng
        'ofrm.Tipo = "R"
        'ofrm.show()
    End Sub

    Private Sub MenuItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem151.Click
        Dim frm As New frmVisorRS 'Detalle de cartera prprestamos
        OpcionRS = 87
        With frm
            .Show()
        End With
        'Dim ofrm As New frmMsAsRepIng
        'ofrm.StartPosition = FormStartPosition.CenterScreen
        'ofrm.Tipo = "I"
        'ofrm.lblNoActa.Visible = False
        'ofrm.txtNoActa.Visible = False
        'ofrm.chkTodos.Visible = False
        'ofrm.txtCodEjecMercadeo.Visible = False
        'ofrm.txtEjecMercadeo.Visible = False
        ' ofrm.Label7.Visible = False
        'ofrm.txtCodigo.Visible = False


    End Sub

    Private Sub MenuItem319_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem319.Click
        Dim ofrm As New frmRepA
        ofrm.Text = "Carta de Asociados"
        ofrm.Tipo = 1
        ofrm.Show()
    End Sub

    Private Sub MenuItem317_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem317.Click
        Dim ofrm As New frmRepA
        ofrm.Text = "Carta de Retirados"
        ofrm.Tipo = 0
        ofrm.Show()
    End Sub

    Private Sub MenuItem313_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem313.Click
        Dim frm As New frmVisorRS
        OpcionRS = 86
        frm.Show()

        'Dim ofrm As New frmMsAsRepIng
        'ofrm.Tipo = "N"
        'ofrm.Show()
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        Dim ofrm As New frmSolicitudRenunciaAsociado
        ofrm.Show()
    End Sub

    Private Sub MenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem84.Click
        'REPORTE DIARIO DE ASOCIADOS EN MORA
        Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
        ds = oAsoc.Reporte_Mora_Asociados(sUsuario, sPassword, sSucursal)
        Dim ofrm As New frmVisor(ds, 76, 0)
        ofrm.Show()
    End Sub

    Private Sub MenuItem171_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem171.Click
        Dim ofrm As New frmMCBDespachos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem320_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem320.Click
        Dim ofrm As New frmMGrSeccionRegistro
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem321_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem321.Click
        Dim ofrm As New frmMsProcesoInhabilitacion
        ofrm.Show()
    End Sub

    Private Sub MenuItem322_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem322.Click

        Dim ofrm As New FrmMsAhTransferenciasAutomaticas
        ofrm.Show()
    End Sub

    Private Sub MenuItem323_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem323.Click
        Dim ofrm As New frmMsTransferenciaAut
        ofrm.Tipo = 0 'Préstamos
        ofrm.Show()
    End Sub

    Private Sub MenuItem324_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem324.Click
    End Sub

    Private Sub MenuItem277_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem277.Click
        Dim ofrm As New frmMsCaParametros
        ofrm.Show()
    End Sub

    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem327_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem327.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "8"
        ofrm.Titulo = "Reporte de Reversiones en Caja"
        ofrm.Show()
    End Sub

    Private Sub MenuItem329_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem329.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "10"
        ofrm.Titulo = "Consolidado Cartera de Depósitos a Plazo Fijo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem330_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem330.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "11"
        ofrm.Titulo = "Garantías Depósitos a Plazo Fijo en Mora"
        ofrm.Show()
    End Sub

    Private Sub MenuItem331_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem331.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "12"
        ofrm.Titulo = "Movimientos en Cuentas de Ahorro"
        ofrm.Show()
    End Sub

    Private Sub MenuItem26_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim ofrm As New frmMPRDescuentos
        'ofrm.TipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango
        ofrm.TipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem124_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem124.Click
        Dim ofrm As New frmMPRDescuentos
        'ofrm.TipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango
        ofrm.TipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub



    Private Sub MenuItem337_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem337.Click
        Dim ofrm As New frmMPlanillaDescuentos
        ofrm.Show()
    End Sub

    Private Sub MenuItem326_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMComisionesEjecutivos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem142_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "13"
        ofrm.Titulo = "Exportación de datos DPF"
        ofrm.Show()
    End Sub

    Private Sub MenuItem338_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem338.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "14"
        ofrm.Titulo = "Reporte de datos DPF"
        ofrm.Show()
    End Sub

    Private Sub MenuItem339_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem339.Click
        Dim ofrm As New frmMsReporteDUI
        ofrm.NumReporte = "1"
        ofrm.Titulo = "Impresión de Certificado de Depósito"
        ofrm.Show()
    End Sub



    Private Sub MenuItem342_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem342.Click
        Dim frm As New frmVisorRS
        OpcionRS = 111
        With frm
            .ShowDialog()
        End With
    End Sub

    Private Sub MenuItem168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem168.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "10"
        ofrm.Titulo = "Vencimientos diarios DPF (cumplen mes)"
        ofrm.Show()
    End Sub

    Private Sub MenuItem325_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem325.Click
        Dim ofrm As New frmMsProcesoComisiones
        ofrm.Show()
    End Sub



    Private Sub MenuItem346_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem346.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "17"
        ofrm.Titulo = "Reporte de Provisión de Cuentas de Ahorro"
        ofrm.Show()
    End Sub

    Private Sub MenuItem347_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem347.Click
        Dim ofrm As New frmMsReporteII
        ofrm.NumReporte = "2"
        ofrm.Titulo = "Reporte de Cuentas de Ahorro no provisionadas"
        ofrm.Show()
    End Sub

    Private Sub MenuItem349_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem349.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "18"
        ofrm.Titulo = "Reporte de Provisión de Préstamos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem350_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem350.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "12"
        ofrm.Titulo = "Reporte de Préstamos no provisionados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem351_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem351.Click
        Dim ofrm As New frmRepPRDetallePrestamo
        ofrm.Titulo = "Orden de Descuento"
        ofrm.NumReporte = 2
        ofrm.Show()
    End Sub

    Private Sub MenuItem352_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmRepColocacionCredito
        ofrm.NumReporte = 2
        ofrm.Show()
    End Sub

    Private Sub MenuItem353_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmRepColocacionCredito
        ofrm.NumReporte = 3
        ofrm.Show()
    End Sub

    Private Sub MenuItem354_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem354.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "19"
        ofrm.Titulo = "Detalle de Apertura de Caja"
        ofrm.Show()
    End Sub

    Private Sub MenuItem355_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem355.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "20"
        ofrm.Titulo = "Saldos de Aportaciones canceladas"
        ofrm.Show()
    End Sub

    Private Sub MenuItem356_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem356.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "21"
        ofrm.Titulo = "Cuentas Pignoradas"
        ofrm.Show()
    End Sub

    Private Sub MenuItem357_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem357.Click
        Dim frm As New frmVisorRS 'Detalle de cartera Ahorros
        OpcionRS = 37
        With frm
            .Show()
        End With

        'Dim ofrm As New frmMsReporteI
        'ofrm.NumReporte = "22"
        'ofrm.Titulo = "Aplicaciones valor fecha"
        'ofrm.Show()
    End Sub

    Private Sub MenuItem358_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem358.Click
        Dim ofrm As New frmRepCaja
        ofrm.NumReporte = "0"
        ofrm.Titulo = "Reporte de Movimientos de Caja"
        ofrm.Show()
    End Sub

    Private Sub MenuItem359_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem359.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "24"
        ofrm.Titulo = "Reporte detallado de Facturas"
        ofrm.Show()
    End Sub

    Private Sub MenuItem361_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem361.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem362_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem362.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem363_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem363.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem409_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem409.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem410_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem410.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem411_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem411.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem365_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem365.Click
        Me.LayoutMdi(MdiLayout.Cascade)
        'Dim oPrest As New wrPrestamo.wsLibPrest
        'oPrest.Rutina()
    End Sub

    Private Sub MenuItem366_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem366.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem367_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem367.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem373_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem373.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem374_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem374.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem375_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem375.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem377_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem377.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem378_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem378.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem379_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem379.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem381_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem381.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem382_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem382.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem383_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem383.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem385_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem385.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem386_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem386.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem387_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem387.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem389_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem389.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem390_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem390.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem391_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem391.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem393_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem393.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem394_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem394.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem395_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem395.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem397_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem397.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem398_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem398.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem399_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem399.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem401_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem401.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem402_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem402.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem403_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem403.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem405_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem405.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem406_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem406.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuItem407_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem407.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem412_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem412.Click
        Dim ofrm As New frmMsReporteDUI
        ofrm.NumReporte = "0"
        ofrm.Titulo = "Cuentas de Asociados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem413_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem413.Click
        Dim ofrm As New frmTransferenciaGestor
        ofrm.Show()
    End Sub

    Private Sub MenuItem414_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem414.Click
        Dim ofrm As New frmMsProcesoRetiro, oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
        ofrm.btnGuardar1.Text = "&Guardar"
        ofrm.pCont = True
        ofrm.StartPosition = FormStartPosition.CenterScreen
        ofrm.txtArchivo.Enabled = False
        ofrm.btnArchivo.Enabled = False
        ofrm.txtNoActa.Enabled = False
        ofrm.dtpFecha.Enabled = False
        ofrm.txtNoSolRetiro.Enabled = False
        ofrm.txtObservaciones.Enabled = False
        ofrm.chkLiquidacion.Enabled = False
        ofrm.chkRetiroEfect.Enabled = False
        ofrm.Show()
    End Sub

    Private Sub MenuItem415_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem415.Click
        Dim ofrm As New frmMPrestamos
        ofrm.MdiParent = Me
        'ofrm.btnCalculadoraTA.Visible = False
        'ofrm.btnPig1.Visible = False
        'ofrm.btnImprimir.Visible = False
        ofrm.setModulo = frmMPrestamos.Modulo.Garantias
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem416_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem416.Click
        Dim ofrm As New frmCrTablaAmortEjec
        ofrm.Show()
    End Sub

    Private Sub MenuItem417_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem417.Click
        Try
            If MsgBox("¿Desea generar historial de categoría de riesgo?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Historial Categoría de Riesgo") = MsgBoxResult.Yes Then
                Dim oCred As New wrCredito.wsLibCred
                oCred.InsertarHistorialCategoria(sUsuario, sPassword, sSucursal)
                MsgBox("Historial generado con éxito.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem420_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem420.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "25"
        ofrm.Titulo = "Control de Ruta de Cobro General"
        ofrm.Show()
    End Sub

    Private Sub MenuItem421_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem421.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "26"
        ofrm.Titulo = "Control de Ruta de Cartera en Mora"
        ofrm.Show()
    End Sub

    Private Sub MenuItem422_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem422.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "27"
        ofrm.Titulo = "Control de Ruta de Cartera Normal"
        ofrm.Show()
    End Sub

    Private Sub MenuItem424_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem424.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "28"
        ofrm.Titulo = "Detalle de Cuota para Control de Ruta General"
        ofrm.Show()
    End Sub

    Private Sub MenuItem423_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem423.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "29"
        ofrm.Titulo = "Depósitos a Plazo Fijo anulados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem425_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem425.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "30"
        ofrm.Titulo = "Aplicaciones Valor Fecha"
        ofrm.Show()
    End Sub

    Private Sub MenuItem426_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem426.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "31"
        ofrm.Titulo = "Asociados Ahorrantes"
        ofrm.Show()
    End Sub

    Private Sub MenuItem427_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem427.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "32"
        ofrm.Titulo = "Asociados Inhabilitados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem428_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem428.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "33"
        ofrm.Titulo = "Asociados Excluídos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem430_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem430.Click
        Dim ofrm As New frmMsAhReversiones
        ofrm.TipoDeposito = "1" 'Aportación
        ofrm.Show()
    End Sub

    Private Sub MenuItem431_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem431.Click
        Dim ofrm As New frmMsAhReversiones
        ofrm.TipoDeposito = "0"  'Ahorro
        ofrm.Show()
    End Sub

    Private Sub MenuItem432_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem432.Click
        Dim ofrm As New frmMsAhReversiones
        ofrm.TipoDeposito = "1" 'Aportación
        ofrm.Show()
    End Sub

    Private Sub MenuItem433_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem433.Click
        Dim ofrm As New frmMsCrProyeccionSaldos
        ofrm.Show()
    End Sub

    Private Sub MenuItem434_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem434.Click
        Dim ofrm As New frmMsPRReversion
        ofrm.Show()
    End Sub

    Private Sub MenuItem435_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem435.Click
        Dim ofrm As New frmMsReporteII
        ofrm.NumReporte = "0"
        ofrm.Titulo = "Cancelaciones de Cuentas (Tipo de Transacción)"
        ofrm.Show()
    End Sub

    Private Sub MenuItem436_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem436.Click
        'Dim ofrm As New frmListadoCarteraPrestamos
        'ofrm.Text = "Reporte de Créditos cancelados en el mes"
        'ofrm.NumReporte = "1"
        'ofrm.show()
        '===================================
        'Modificación
        '28/02/2014
        'Javier Martinez

        Dim ofrm As New frmVisorRS
        OpcionRS = 43 'Creditos Cancelados
        ofrm.MdiParent = Me
        ofrm.Show()
        '===================================
    End Sub

    Private Sub MenuItem437_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem437.Click
        Dim ofrm As New frmMsRepFiadores
        ofrm.Show()
    End Sub

    Private Sub MenuItem438_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem438.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 100 'analisis fiador

        ofrm.dui = " "
        ofrm.Show()
    End Sub

    Private Sub MenuItem439_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem439.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "13"
        ofrm.Titulo = "Saldos de Préstamos Cartera en Protesto"
        ofrm.Show()
    End Sub

    Private Sub MenuItem440_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem440.Click

        Dim ofrm As New frmRepPREstadoCuenta
        ofrm.Tipo = "R"
        ofrm.Show()
    End Sub

    Private Sub MenuItem441_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem441.Click
        Dim ofrm As New frmRepPREstadoCuenta
        ofrm.Tipo = "N"
        ofrm.Show()

    End Sub

    Private Sub MenuItem442_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem442.Click
        Dim ofrm As New frmRptConcentracionGestion
        ofrm.Tipo = "P"
        ofrm.chkTodos.Visible = True
        ofrm.Text = "Cartera de Préstamos por Ejecutivo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem444_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem444.Click
        Dim ofrm As New frmRptConcentracionGestion
        ofrm.Text = "Reporte de Cobro Mensual por Ejecutivo"
        ofrm.chkTodos.Visible = True
        ofrm.Tipo = "M"
        ofrm.Show()
    End Sub

    Private Sub MenuItem445_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem445.Click
        Dim ofrm As New frmVisorRS 'Prestamos Aseguradora
        OpcionRS = 67
        ofrm.MdiParent = Me
        ofrm.Show()
        'Dim ofrm As New frmRepPrestamos_TiposCredito
        'ofrm.show()
    End Sub

    Private Sub MenuItem446_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem446.Click

    End Sub

    Private Sub MenuItem448_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem448.Click
        Dim ofrm As New frmRepDeterminacionReservas
        ofrm.Tipo = wrCredito.TipoAgrupacionCreditos.TipoCredito
        ofrm.Show()
    End Sub

    Private Sub MenuItem449_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem449.Click
        Dim ofrm As New frmRepDeterminacionReservas
        ofrm.Tipo = wrCredito.TipoAgrupacionCreditos.TipoGarantia
        ofrm.Show()
    End Sub

    Private Sub MenuItem261_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem261.Click
        Dim ofrm As New frmMsAsRepIng
        ofrm.Text = "Renuncia de Asociados"
        ofrm.Tipo = "G"
        ofrm.Show()
    End Sub

    Private Sub MenuItem418_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem418.Click
        Dim ofrm As New frmMsReporteII
        ofrm.NumReporte = "1"
        ofrm.Titulo = "Cancelaciones de Cuentas"
        ofrm.Show()
    End Sub

    Private Sub MenuItem328_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem328.Click
        Dim ofrm As New frmMsAsRepIng
        ofrm.Tipo = "A"
        ofrm.Show()
    End Sub

    Private Sub MenuItem450_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem450.Click
        Dim ofrm As New frmRptConcentracionGestion
        ofrm.Label3.Text = "Fecha:"
        ofrm.Label4.Visible = False
        ofrm.dtpR2.Visible = False
        ofrm.chkTodos.Visible = True
        ofrm.Tipo = "A"
        ofrm.Text = "Reporte de Asociados en mora"
        ofrm.Show()
    End Sub

    Private Sub MenuItem451_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem451.Click
        'Se creo nuevo reporte en reporting services. 13-08-2012
        'Javier Martinez
        Dim ofrm As New frmVisorRS
        OpcionRS = 15 'Reporte de Detalle de transferencias por sucursal.
        ofrm.MdiParent = Me
        ofrm.Show()
        'Dim ofrm As New frmRepTransferencias
        'ofrm.show()
    End Sub

    Private Sub MenuItem452_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem452.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "8"
        ofrm.Titulo = "Reporte de Mora por Colector"
        ofrm.Show()
    End Sub

    Private Sub MenuItem453_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem453.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "14"
        ofrm.Titulo = "Reporte de Mora por Garantía"
        ofrm.Show()
    End Sub

    Private Sub MenuItem454_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem454.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "15"
        ofrm.Titulo = "Reporte de Mora por Línea"
        ofrm.Show()
    End Sub

    Private Sub MenuItem456_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem456.Click
        Dim ofrm As New frmMCrLineasCredito
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem457_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem457.Click
        Dim ofrm As New frmMCrRangoLineasCredito
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem458_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem458.Click
        Dim ofrm As New frmVisor(Nothing, 131, 0)
        ofrm.Show()
    End Sub

    Private Sub MenuItem459_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub MenuItem460_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem460.Click
        Dim ofrm As New frmMsConsultaMov
        ofrm.Show()
    End Sub

    Private Sub MenuItem461_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem461.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = 30
        ofrm.Titulo = "Reporte de Activo Fijo Global"
        ofrm.lblFecha.Text = "Fecha:"
        ofrm.Show()
    End Sub

    Private Sub MenuItem462_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem462.Click
        'Dim ofrm As New frmMsReporteActivoFijo
        'ofrm.NumReporte = "0"
        'ofrm.Titulo = "Reporte de Activo Fijo por Departamento"
        'ofrm.show()
    End Sub

    Private Sub MenuItem463_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem463.Click
        Dim ofrm As New frmMsCBReversion
        ofrm.Show()
    End Sub



    Private Sub MenuItem465_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem465.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "18"
        ofrm.Titulo = "Vencimientos diarios DPF Proyectados (cumplen mes)"
        ofrm.Show()
    End Sub

    Private Sub MenuItem467_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem467.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "19"
        ofrm.Titulo = "Reporte de Préstamos por Garantía"
        ofrm.Show()
    End Sub

    Private Sub MenuItem468_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem468.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "20"
        ofrm.Titulo = "Reporte de Préstamos por Línea"
        ofrm.Show()
    End Sub

    Private Sub MenuItem470_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem470.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "21"
        ofrm.Titulo = "Reporte de Préstamos por Plazo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem469_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem469.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "22"
        ofrm.Titulo = "Reporte de Préstamos por Categorías"
        ofrm.Show()
    End Sub

    Private Sub MenuItem472_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem472.Click
        Dim ofrm As New frmMsReporteDUI
        ofrm.NumReporte = "5"
        ofrm.Titulo = "Liquidación de Asociado Retirado"
        ofrm.Show()
    End Sub



    Private Sub MenuItem475_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem475.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "17"
        ofrm.Titulo = "Reserva de Documentos por Cobrar"
        ofrm.Show()
    End Sub

    Private Sub MenuItem476_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem476.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.chkMora.Visible = True
        ofrm.NumReporte = "25"
        ofrm.Titulo = "Reporte de Reserva Gerencial Mora"
        ofrm.Show()
    End Sub

    Private Sub MenuItem479_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem479.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "2"
        ofrm.Titulo = "Movimientos Diarios de Cargos a Préstamos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem474_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem474.Click
        Dim ofrm As New frmVisorRS 'Detalle de Transacciones de Asociados
        OpcionRS = 61
        ofrm.MdiParent = Me
        ofrm.Show()
        'Dim ofrm As New frmMsReporteI
        'ofrm.NumReporte = "0"
        'ofrm.Titulo = "Movimientos Diarios de Abonos a Préstamos"
        'ofrm.show()
    End Sub

    Private Sub MenuItem309_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem309.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.chkMora.Visible = False
        ofrm.NumReporte = "26"
        ofrm.Titulo = "Reporte de Tasas Activas"
        ofrm.Show()
    End Sub

    Private Sub MenuItem480_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "1"
        ofrm.Opcion = wrAhorro.TiposAhorroReporteMovimientos.Vista
        ofrm.Titulo = "Movimientos Diarios de Ahorro a la Vista"
        ofrm.Show()
    End Sub

    Private Sub MenuItem482_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "1"
        ofrm.Opcion = wrAhorro.TiposAhorroReporteMovimientos.Programado
        ofrm.Titulo = "Movimientos Diarios de Ahorro Programado"
        ofrm.Show()
    End Sub

    Private Sub MenuItem483_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "1"
        ofrm.Opcion = wrAhorro.TiposAhorroReporteMovimientos.Restringido
        ofrm.Titulo = "Movimientos Diarios de Ahorro Restringido"
        ofrm.Show()
    End Sub

    Private Sub MenuItem484_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "1"
        ofrm.Opcion = wrAhorro.TiposAhorroReporteMovimientos.Aportacion
        ofrm.Titulo = "Movimientos Diarios de Aportaciones"
        ofrm.Show()
    End Sub

    Private Sub MenuItem485_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "1"
        ofrm.Opcion = wrAhorro.TiposAhorroReporteMovimientos.DPF
        ofrm.Titulo = "Movimientos Diarios de Depósitos a Plazo Fijo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.chkMora.Visible = False
        ofrm.NumReporte = "27"
        ofrm.Titulo = "Reporte de Tasas Pasivas"
        ofrm.Show()
    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        Dim ofrm As New frmListadoCreditoSinPagoXGestion
        ofrm.Show()
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem80.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "16"
        ofrm.Titulo = "Cartera de Documentos en Protesto con Reserva"
        ofrm.Show()
    End Sub

    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "9"
        ofrm.Titulo = "Consolidado de Documentos en Protesto con Reserva"
        ofrm.Show()
    End Sub

    Private Sub MenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem102.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "36"
        ofrm.Titulo = "Acuerdos y Promesas diarias"
        ofrm.Show()
    End Sub

    Private Sub MenuItem489_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem489.Click
        Dim ofrm As New frmRepColocacionCredito
        ofrm.NumReporte = 1
        ofrm.Show()
        'Dim ofrm As New frmMsReporteV
        'ofrm.NumReporte = "0"
        'ofrm.Titulo = "Reporte de Créditos por Garantía"
        'ofrm.show()

    End Sub

    Private Sub MenuItem443_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem443.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "16"
        ofrm.Titulo = "Cartera de Documentos en Protesto con Reserva"
        ofrm.Show()
    End Sub

    Private Sub MenuItem447_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem447.Click
        Dim ofrm As New frmRepPrestamos_TiposCredito
        ofrm.Show()
    End Sub

    Private Sub MenuItem242_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem242.Click
        Dim ofrm As New frmMPLRepDepto
        ofrm.NumReporte = "0"
        ofrm.Titulo = "Reporte de Empleados por Departamento"
        ofrm.Show()
    End Sub

    Private Sub MenuItem240_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem240.Click
        Dim ofrm As New frmMPLReporteI
        ofrm.NumReporte = "0"
        ofrm.Titulo = "Reporte de Empleados por Cargo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem490_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem490.Click
        Dim ofrm As New frmMPLReporteI
        ofrm.NumReporte = "1"
        ofrm.Titulo = "Reporte de Empleados por Fecha de Ingreso"
        ofrm.Show()
    End Sub

    Private Sub MenuItem235_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem235.Click
        Dim ofrm As New frmMPLReporteI
        ofrm.NumReporte = "2"
        ofrm.Titulo = "Reporte de Empleados por Género"
        ofrm.Show()
    End Sub

    Private Sub MenuItem486_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem486.Click
        Dim ofrm As New frmMPLReporteI
        ofrm.NumReporte = "3"
        ofrm.Titulo = "Reporte de Empleados con Documentos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem236_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem236.Click
        Dim ofrm As New frmMPLReporteI
        ofrm.NumReporte = "4"
        ofrm.Titulo = "Reporte de Empleados Activos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem487_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem487.Click
        Dim ofrm As New frmMPLReporteI
        ofrm.NumReporte = "5"
        ofrm.Titulo = "Reporte de Empleados (Nombres)"
        ofrm.Show()
    End Sub

    Private Sub MenuItem481_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem481.Click
        Dim ofrm As New frmMPLReporteI
        ofrm.NumReporte = "6"
        ofrm.Titulo = "Reporte datos personales de Empleados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem491_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem491.Click
        Dim ofrm As New frmMPLReporteI
        ofrm.NumReporte = "7"
        ofrm.Titulo = "Reporte Detalle de Forma Pago"
        ofrm.Show()
    End Sub

    Private Sub MenuItem237_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem237.Click
        Dim ofrm As New frmMPLReporteI
        ofrm.NumReporte = "8"
        ofrm.Label4.Text = "Fecha de Cumpleaños:"
        ofrm.Titulo = "Reporte Empleados Cumpleañeros"
        ofrm.Show()
    End Sub

    Private Sub MenuItem498_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem498.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "37"
        ofrm.Titulo = "Reporte Activo Fijo x Accesorios"
        ofrm.Show()
    End Sub

    Private Sub MenuItem501_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem501.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "39"
        ofrm.Titulo = "Reporte Activo con Depreciación"
        ofrm.Show()
    End Sub

    Private Sub MenuItem500_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem500.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "38"
        ofrm.Titulo = "Reporte Activo Fijo (Mobiliario y Equipo)"
        ofrm.Show()
    End Sub

    Private Sub MenuItem499_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem499.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "40"
        ofrm.Titulo = "Reporte Activo Fijo (Instalaciones)"
        ofrm.Show()
    End Sub

    Private Sub MenuItem507_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem507.Click
        'Dim ofrm As New frmMsAFReporteII
        'ofrm.NumReporte = "0"
        'ofrm.Titulo = "Reporte Activo Fijo x Sub-Clasificación"
        'ofrm.show()
    End Sub

    Private Sub MenuItem508_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem508.Click
        Dim ofrm As New frmRptConcentracionGestion
        ofrm.dtpR2.Visible = False
        ofrm.Label4.Visible = False
        ofrm.Label3.Text = "Fecha:"
        ofrm.chkTodos.Visible = True
        ofrm.Tipo = "MD"
        ofrm.Show()
    End Sub

    Private Sub MenuItem504_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem504.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "44"
        ofrm.Titulo = "Reporte Activo Fijo vigentes"
        ofrm.Show()
    End Sub

    Private Sub MenuItem505_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem505.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "43"
        ofrm.Titulo = "Reporte Activo Fijo con su valor"
        ofrm.Show()
    End Sub

    Private Sub MenuItem502_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem502.Click
        'Dim ofrm As New frmMsAFReporteI
        'ofrm.NumReporte = "0"
        'ofrm.Titulo = "Reporte Activo Fijo x Agrupación"
        'ofrm.show()
    End Sub

    Private Sub MenuItem510_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem510.Click
        Dim ofrm As New frmMGarantiasPrendarias
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    'Private Sub MenuItem511_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem511.Click
    '    Dim ofrm As New frmMGarantias
    '    ofrm.lblTitulo.Text = "Consulta Garantías"
    '    ofrm.btInscripcion.Visible = False
    '    ofrm.btnModificar.Visible = False
    '    ofrm.btnCertExt.Visible = False
    '    ofrm.btGarantias.Visible = True
    '    ofrm.btGarantias.Location = New Point(3, 16)
    '    ofrm.MdiParent = Me
    '    ofrm.Show()
    'End Sub

    Private Sub MenuItem513_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem513.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "41"
        ofrm.Titulo = "Movimientos Diarios de Abonos a Préstamos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem514_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem514.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "42"
        ofrm.Titulo = "Movimientos Diarios de Cargos a Préstamos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem516_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem516.Click
        Dim ofrm As New frmMNacionalidades
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem517_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem517.Click
        Dim ofrm As New frmMProfesiones
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem518_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem518.Click
        Dim ofrm As New frmMCooperativas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem519_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem519.Click
        Dim ofrm As New frmMMunicipios
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem520_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem520.Click
        Dim ofrm As New frmMEjecutivos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem521_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem521.Click
        Dim ofrm As New frmMCobradores
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem522_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem522.Click
        Dim ofrm As New frmMSucursales
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem523_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem523.Click
        Dim ofrm As New frmMParentesco
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem153.Click
        Dim ofrm As New frmMDepartamentos
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem154.Click
        Dim ofrm As New frmMsExportar
        ofrm.NumReporte = "0"
        ofrm.Titulo = "Exportación datos Asociados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "35"
        ofrm.Titulo = "Exportación de datos Ahorros"
        ofrm.Show()
    End Sub

    Private Sub MenuItem503_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem503.Click
        'Dim frm As New frmMsAFReporteIII
        'frm.NumReporte = 0
        'frm.Titulo = "Reporte de Activo Fijo Asignado a Empleado"
        'frm.show()
    End Sub

    Private Sub MenuItem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem157.Click
        'Dim frm As New frmMDepreciacion
        'frm.show()
    End Sub

    Private Sub MenuItem158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem158.Click
        Dim oPlan As New wrPrestamo.wsLibPrest, ds As New DataSet
        ds = oPlan.ListadoCreditos_Pignorados(sUsuario, sPassword, sSucursal)
        Dim ofrm As New frmVisor(ds, 170, 0)
        ofrm.Show()
    End Sub

    Private Sub MenuItem163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem163.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "45"
        ofrm.Titulo = "Asociados Fallecidos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem263_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem263.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "46"
        ofrm.Titulo = "Asociados Habilitados"
        ofrm.Show()
    End Sub



    Private Sub MenuItem525_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem525.Click
        Dim ofrm As New frmMGarantiasHipotecarias
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem511_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem511.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "48"
        ofrm.Titulo = "Reingreso de Asociados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem509_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem509.Click
        Dim ofrm As New frmMsRepCACheques
        ofrm.pTipo = "A"
        ofrm.Show()
    End Sub

    Private Sub MenuItem526_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem526.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "31"
        ofrm.Titulo = "Reporte de Dividendos por pagar"
        ofrm.Show()
    End Sub

    Private Sub MenuItem471_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem471.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "32"
        ofrm.Titulo = "Reporte de Préstamos por Rangos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem527_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem527.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "19"
        ofrm.Titulo = "Reporte de Préstamos por Garantía"
        ofrm.Show()
    End Sub

    Private Sub MenuItem528_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem528.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "20"
        ofrm.Titulo = "Reporte de Préstamos por Línea"
        ofrm.Show()
    End Sub

    Private Sub MenuItem529_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem529.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "22"
        ofrm.Titulo = "Reporte de Préstamos por Categorías"
        ofrm.Show()
    End Sub

    Private Sub MenuItem530_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem530.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "49"
        ofrm.Titulo = "Reporte de Préstamos Refinanciados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem531_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem531.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "50"
        ofrm.Titulo = "Reporte de Préstamos con Pagarés y Letras"
        ofrm.Show()
    End Sub

    Private Sub MenuItem532_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem532.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "58"
        ofrm.Titulo = "Reporte de Cartera DPF"
        ofrm.Show()
    End Sub

    Private Sub MenuItem533_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem533.Click
        Dim ofrm As New frmRptConcentracionGestion
        ofrm.dtpR2.Visible = False
        ofrm.Label4.Visible = False
        ofrm.Label3.Text = "Fecha:"
        ofrm.chkTodos.Visible = True
        ofrm.Tipo = "MDCB"
        ofrm.Show()
    End Sub

    Private Sub MenuItem534_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem534.Click
        'Dim ofrm As New frmMPlanificacion
        Dim ofrm As New frmMPlan_Eje_Mercadeo
        ofrm.WindowState = FormWindowState.Normal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem536_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem536.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "51"
        ofrm.Titulo = "Reporte Informe Metas Mercadeo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem537_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem537.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "52"
        ofrm.Titulo = "Informe de Metas por Producto/Servicio"
        ofrm.Show()
    End Sub

    Private Sub MenuItem539_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem539.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "53"
        ofrm.Titulo = "Gerencial Acumulado Metas"
        ofrm.Show()
    End Sub

    Private Sub MenuItem540_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem540.Click
        Dim ofrm As New frmRptConcentracionGestion
        ofrm.Tipo = "RMD"
        ofrm.chkTodos.Visible = True
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem541_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem541.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "54"
        ofrm.Titulo = "Colocación Montos Desembolsados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem538_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem538.Click

        Dim ofrm As New frmMCaTransferenciaContable
        ofrm.Show()

    End Sub

    Private Sub MenuItem542_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem542.Click

        Dim ofrm As New frmMCaTransfAuxCtaCont
        ofrm.Show()

    End Sub

    Private Sub MenuItem543_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem543.Click

        Dim ofrm As New frmMCaTransfCtaContAux
        ofrm.Show()

    End Sub

    Private Sub MenuItem544_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem544.Click

        Dim ofrm As New frmTransferenciaManualCtaAhorros
        ofrm.Show()

    End Sub

    Private Sub MenuItem267_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmMsReporteIV
        ofrm.NumReporte = "0"
        ofrm.Titulo = "Generación Factura Consolidada (Movimientos)"
        ofrm.Show()
    End Sub

    Private Sub MenuItem165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem165.Click
        Dim ofrmAut As New frmMsAutorizacion
        ofrmAut.TipoPermiso = "P"
        ofrmAut.NumPrograma = "CTC008"
        ofrmAut.Show()
        If ofrmAut.Autoriza = True Then
            Dim frm As New frmMsCierreMensual
            frm.Show()
            ofrmAut.Autoriza = False
            ofrmAut.Dispose()
        Else
            ofrmAut.Dispose()
        End If
    End Sub

    Private Sub MenuItem160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem160.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "55"
        ofrm.chk.Visible = True
        ofrm.chk.Text = "Exportar"
        ofrm.chk.Checked = False
        ofrm.Titulo = "Colocación de Préstamos Consolidado"
        ofrm.Show()
    End Sub

    Private Sub MenuItem268_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem268.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "56"
        ofrm.Titulo = "Gerencial Consolidado Evaluación por Año"
        ofrm.Show()
    End Sub

    Private Sub MenuItem269_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem269.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "57"
        ofrm.Titulo = "Gerencial Consolidado Resultados Históricos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem545_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem545.Click
        Dim ofrm As New wfRpt_Creditos_sin_Garantias
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem546_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem546.Click
        Dim ofrm As New wfRpt_Creditos_x_TipoHipoteca
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem547_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem547.Click
        Dim ofrm As New wfRpt_Garantias_Prendarias
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem548_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem548.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "33"
        ofrm.Titulo = "Reporte de Mora DXC"
        ofrm.Show()
    End Sub

    Private Sub MenuItem549_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem549.Click
        Dim ofrm As New frmMsProcesoExclusion
        ofrm.Show()
    End Sub

    Private Sub MenuItem550_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem550.Click
        Dim ofrm As New frmMsRepEjecutivo
        ofrm.chkTodos.Visible = True
        ofrm.Tipo = "0"
        ofrm.Text = "Reporte Membresía, Colocación, Captación"
        ofrm.Show()
    End Sub

    Private Sub MenuItem506_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem506.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.lblFecha.Text = "Fecha:"
        ofrm.NumReporte = "34"
        ofrm.Titulo = "Detalle de Depreciaciones"
        ofrm.Show()
    End Sub

    Private Sub MenuItem551_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem551.Click
        'Dim ofrm As New frmMHistCatRiesgo
        'ofrm.MdiParent = Me
        'ofrm.WindowState = FormWindowState.Normal
        'ofrm.Show()
        Dim ofrm As New frmVisorRS
        OpcionRS = 11 'Reporte de Historial de Categoria de riesgo.
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem552_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem552.Click
        Dim ofrm As New frmRepOrdenDescuento
        ofrm.Show()
    End Sub

    Private Sub MenuItem243_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem243.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "62"
        ofrm.Titulo = "Reporte Empleados Motivos de Ausentismo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem239_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem239.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "63"
        ofrm.Titulo = "Reporte Empleados por Tipo Descuento"
        ofrm.Show()
    End Sub

    Private Sub MenuItem492_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem492.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "64"
        ofrm.Titulo = "Reporte de Empleados Vacaciones"
        ofrm.Show()
    End Sub

    Private Sub MenuItem494_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem494.Click
        Dim ofrm As New frmMsPLConstSalario
        ofrm.Text = "    Constancia de Salario"
        ofrm.vNumReporte = "0"
        ofrm.Show()
    End Sub

    Private Sub MenuItem495_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem495.Click
        Dim ofrm As New frmMsPLConstSalario
        ofrm.Text = "    Constancia de Trabajo"
        ofrm.Label1.Visible = False
        ofrm.dtpFecha.Visible = False
        'ofrm.Size = New Size(536, 104)
        ' ofrm.btnGuardar.Location = New Point(304, 48)
        ' ofrm.btnCerrar.Location = New Point(432, 48)
        ofrm.vNumReporte = "1"
        ofrm.Show()
    End Sub

    Private Sub MenuItem496_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem496.Click
        Dim ofrm As New frmMsPLConstSalario
        ofrm.Text = "    Referencia Laboral"
        ofrm.Label1.Visible = False
        ofrm.dtpFecha.Visible = False
        ofrm.Size = New Size(536, 104)
        'ofrm.btnGuardar.Location = New Point(304, 48)
        'ofrm.btnCerrar.Location = New Point(432, 48)
        ofrm.vNumReporte = "2"
        ofrm.Show()
    End Sub

    Private Sub MenuItem238_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem238.Click
        Dim ofrm As New frmMPLBoletaPago
        ofrm.Show()
        'Dim ofrm As New frmMsPLRecibosPago
        'ofrm.show()
    End Sub

    Private Sub MenuItem553_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem553.Click
        Dim ofrm As New frmRepAhVencimientos
        ofrm.Text = "Vencimientos Cuentas de Ahorros"
        ofrm.Tipo = "P"
        ofrm.Show()
    End Sub

    Private Sub MenuItem554_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem554.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "65"
        ofrm.Titulo = "Consolidado Resultados Mercadeo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem555_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem555.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "67"
        ofrm.Titulo = "Resultados Comparados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem557_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem557.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "35"
        ofrm.lblFecha.Text = "Año:"
        ofrm.dtpFecha.Format = DateTimePickerFormat.Custom
        ofrm.dtpFecha.ShowUpDown = True
        ofrm.dtpFecha.CustomFormat = "yyyy"
        ofrm.Titulo = "Dividendos Cuentas Ahorros"
        ofrm.Show()
    End Sub

    Private Sub MenuItem561_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem561.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "36"
        ofrm.lblFecha.Text = "Año:"
        ofrm.dtpFecha.Format = DateTimePickerFormat.Custom
        ofrm.dtpFecha.ShowUpDown = True
        ofrm.dtpFecha.CustomFormat = "yyyy"
        ofrm.Titulo = "Dividendos Cuentas Ex Asociados"
        ofrm.Show()
    End Sub

    Private Sub MenuItem558_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem558.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "68"
        ofrm.Titulo = "Dividendos Cuentas Aportaciones"
        ofrm.Show()
    End Sub

    Private Sub MenuItem559_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem559.Click
        Dim ofrm As New frmMsReporteI
        ofrm.NumReporte = "69"
        ofrm.Titulo = "Dividendos Préstamos"
        ofrm.Show()
    End Sub

    Private Sub MenuItem560_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem560.Click
        Dim ofrm As New frmMsReporteIII
        ofrm.NumReporte = "39"
        ofrm.lblFecha.Text = "Año:"
        ofrm.dtpFecha.Format = DateTimePickerFormat.Custom
        ofrm.dtpFecha.ShowUpDown = True
        ofrm.dtpFecha.CustomFormat = "yyyy"
        ofrm.Titulo = "Dividendos Pagos en Efectivo"
        ofrm.Show()
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click

    End Sub

    Private Sub MenuItem126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem126.Click
        Dim ofrm As New wfDIASTRABAJADOS
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem130.Click
        Dim ofrm As New frmMPLModificacionPlanilla
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem216_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem216.Click
        Dim ofrm As New frmMsGarantias
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem224_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem224.Click
        Dim ofrm As New wfRPT_GARANTIAS_COBROS
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem562_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem562.Click
        Dim ofrm As New wfRPT_GARANTIAS_INFOR
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem563_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem563.Click
        Dim ofrm As New wfRPT_GARANTIAS_INFOR
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem564_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem564.Click
        Dim ofrm As New wfRPT_GARANTIAS_MERCADEO
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem565_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem565.Click
        Dim ofrm As New wfRpt_Garantias_Inscritas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem566_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem566.Click
        Dim ofrm As New frmRepReciboDiv
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem567_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem567.Click
        Dim ofrm As New frmPartidaCorteCaja
        ofrm.Origen = 1
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem568_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem568.Click
        Dim ofrm As New frmGeneraPartidaIntegracionII
        ofrm.Title = "Partida de Liquidación de Aspirantes"
        ofrm.Tipo = wrConta.PartidaIntegracion.LiquidacionAspirante
        ofrm.Show()
    End Sub
    Private Sub MenuItem569_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem569.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 3 'Libro de ventas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem570_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem570.Click

    End Sub
    Private Sub MenuItem571_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem571.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 5 'Reporte Disponibilidad 
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem572_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem572.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 6 'Reporte detalle de correos enviados
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem574_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem574.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 7 'Reporte de transacciones en aportaciones
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem576_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmVisorRS
        OpcionRS = 8 'Reporte de colocación de creditos por sucursal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem578_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem578.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 10 'Reporte de Gestiones por Asociado
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem579_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem579.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 13 'Reporte de Cuadre por tipo de documento.
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem580_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem580.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 12 'Reporte de Cuadre Desembolso de Creditos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem581_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem581.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 14 'Reporte de Cuadre por rubro
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem582_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem582.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 4 'Diferencias Contabilidad - Sistema ahorros , aportaciones, dpf
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem583_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem583.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 16 'Diferencias Contabilidad - Sistema Prestamos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem584_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem584.Click
        Dim ofrm As New frmMsCargaPlanillaPagosPrest
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem585_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem585.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 17 'detalle de pago de planillas de prestamos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem586_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem586.Click
        Dim ofrm As New frmMPLCalculoVacaciones
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem587_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem587.Click
        Dim ofrm As New frmMPrGastosTramitacion
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem588_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem588.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 18 'Saldos Prestamos por vencer
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem589_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem589.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 19 'Saldos Prestamos y Cuotas Vencidas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem590_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem590.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 20 'Marcaciones Empleados
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem591_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem591.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 22 'Marcaciones Empleados
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem592_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem592.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 21 'Marcaciones Empleados
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem595_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem595.Click
        Dim ofrm As New frmMsCargarPlanillaAhoAporDPF
        ofrm.Tipo = 1
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem594_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem594.Click
        Dim ofrm As New frmMsCargarPlanillaAhoAporDPF
        ofrm.Tipo = 3
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem596_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem596.Click
        Dim ofrm As New frmMsCargarPlanillaAhoAporDPF
        ofrm.Tipo = 2
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem598_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem598.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 23 'Marcaciones Empleados
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem599_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem599.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 25 'Saldos Préstamos con arreglo por mora.
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem600_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem600.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 26 'Apertura de cuentas por sucursal.
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem601_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem601.Click
        Dim ofrm As New frmInvMoraAport
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem602_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem602.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 27 'Saldos Préstamos con arreglo por mora.
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem605_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem605.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 29 'Recuperacion por Sucursal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem603_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem603.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 31 'Aportaciones Pagadas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem604_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem604.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 30 'Dias Gracia Prestamo
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem606_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmVisorRS
        OpcionRS = 32 'Comisiones por captación de Dpf Promocionales
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem607_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem607.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 33 'Saldos Carteras Activas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem608_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem608.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 34 'Saldos Carteras Pasivas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem615_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem615.Click
        Dim ofrm As New frmDifCarteraAhorros
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem616_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem616.Click
        Dim ofrm As New frmDifCarteraAportaciones
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem613_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem613.Click
        Dim ofrm As New frmDifCarteraPrestamos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub


    Private Sub MenuItem622_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem622.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 37 'Aplicaciones Valor Fecha
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem623_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem623.Click
        Dim Ofrm As New frmPartidaCorteCaja
        Ofrm.Origen = 0
        Ofrm.MdiParent = Me
        Ofrm.Show()
    End Sub

    Private Sub MenuItem624_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem624.Click
        Dim Ofrm As New frmArchivoBCR
        Ofrm.MdiParent = Me
        Ofrm.Show()
    End Sub

    Private Sub MenuItem625_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem625.Click
        Dim Ofrm As New frmAplicacionDivNoCobrados
        Ofrm.MdiParent = Me
        Ofrm.Show()
    End Sub


    Private Sub MenuItem631_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem631.Click
        Dim ofrm As New frmMCaTipoMovCaja
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem632_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem632.Click
        Dim ofrm As New frmMCaTiposDocumetos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub


    Private Sub MenuItem634_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem634.Click
        Dim Ofrm As New frmMB_SolicitudesBoveda 'Solicitudes Boveda
        Ofrm.MdiParent = Me
        Ofrm.Show()
    End Sub

    Private Sub MenuItem635_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem635.Click
        Dim Ofrm As New frmMsBCChequesRetAhorros
        Ofrm.MdiParent = Me
        Ofrm.Show()
    End Sub



    Private Sub MenuItem633_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem633.Click
        Dim Ofrm As New frmMCorrelativosDocumentosCaja
        Ofrm.MdiParent = Me
        Ofrm.Show()
    End Sub

    Private Sub MenuItem609_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem609.Click
        Dim frm As New frmMAhAutorizacionDPF
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem610_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem610.Click
        Dim frm As New frmMsAsociadosISR
        With frm
            .MdiParent = Me
            .Show()
        End With

    End Sub

    Private Sub MenuItem612_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem612.Click
        Dim frm As New frmMProveedores
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem637_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem637.Click
        Dim frm As New frmMCompras
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem638_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem638.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 41
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem639_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem639.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 3 'Libro de Compras
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem640_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem640.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 42 'Detalle Libro de ventas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem641_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem641.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 44 'Detalle Libro de ventas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem642_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem642.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 45 'Detalle Libro de ventas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem643_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem643.Click
        Dim frm As New frmMCrPagadurias
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem644_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem644.Click
        Dim frm As New frmMTipoEmpresa
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem645_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem645.Click
        Dim frm As New frmMGiroEmpresa
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem646_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem646.Click
        Dim frm As New frmMClasificacionPagaduria
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem647_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem647.Click
        Dim frm As New frmMCriteriosEvaluacionPagadurias
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem648_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem648.Click
        Dim frm As New frmMEvaluarPagaduria
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem649_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem649.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 46 'Detalle Libro de ventas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem650_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem650.Click
        Dim frm As New frmMTipoEvaluaciones
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem651_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem651.Click
        Dim frm As New frmMRestriccionesEvaluaciones
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub



    Private Sub MenuItem652_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem652.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 47 'Transacciones en efectivo
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub



    Private Sub MenuItem656_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem656.Click
        Dim ofrm As New frmVisorRS 'Control dpf solidarios
        OpcionRS = 51
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem657_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem657.Click
        Dim frm As New frmMAhActivarCuentaInactiva
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub



    Private Sub MenuItem659_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem659.Click
        Dim ofrm As New frmVisorRS 'impuesto desembolso prestamos
        OpcionRS = 52
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem660_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem660.Click
        Dim ofrm As New frmVisorRS 'impuesto control de la liquidez
        OpcionRS = 53
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub



    Private Sub MenuItem662_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem662.Click
        Dim ofrm As New frmVisorRS 'impuesto AHORROS >= 25000
        OpcionRS = 55
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem663_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem663.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 57 'Saldos Préstamos con arreglo por mora.
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem664_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem664.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 56 'Saldos Préstamos con arreglo por mora.
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem665_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem665.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 58 'Saldos Préstamos con arreglo por mora.
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem666_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem666.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 59 'Saldos Préstamos con arreglo por mora.
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Dim ofrm As New frmVisorRS 'Detalle de Transacciones de Asociados
        OpcionRS = 60
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem480_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem480.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 68 'Detalle de Transacciones de Asociados
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem482_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem482.Click
        Dim ofrm As New frmGeneraPartidaIntegracion
        ofrm.Title = "Partida de Pago Intereses Ahorros"
        ofrm.Tipo = wrConta.PartidaIntegracion.PagoInteresesAhorros
        ofrm.Show()
    End Sub

    Private Sub MenuItem484_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem484.Click
        Dim ofrm As New frmMMaestroCatalogos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem485_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem485.Click
        Dim ofrm As New frmMDbCatalogos
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub



    Private Sub MenuItem668_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem668.Click
        'Dim ofrm As New frmMRutasMercadeo
        'ofrm.MdiParent = Me
        'ofrm.Show()
    End Sub

    Private Sub MenuItem669_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem669.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 70 'Detalle de rutas
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub



    Private Sub MenuItem672_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmMCatServiciosCoopas
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub MenuItem673_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New frmMReservaCostaCoopas
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub MenuItem674_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem674.Click
        Dim frm As New frmMListaNegra
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem675_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem675.Click
        Dim frm As New frmVisorRS
        OpcionRS = 75
        With frm
            .Show()
        End With
    End Sub

    Private Sub mnuMAsociados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMAsociados.Click
        Dim ofrm As New frmMAsociados
        ofrm.MdiParent = Me
        ofrm.oTipo = 0
        ofrm.Show()
    End Sub

    Private Sub MenuItem676_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem676.Click
        Dim ofrm As New frmCBGestionMora
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem677_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem677.Click
        Dim ofrm As New frmArregloMora
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem671_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem671.Click
        Dim frm As New frmMCAMaestroCajas
        'frm.MdiParent = Me
        frm.Show()
    End Sub



    Private Sub MenuItem672_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem672.Click
        Dim frm As New frmVisorRS     ' DETALLE DE CARTERA
        OpcionRS = 81
        With frm
            .Show()
        End With
    End Sub

    Private Sub MenuItem678_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem678.Click
        Dim frm As New frmVisorRS  'CONSOLIDADO RECUPERACION
        OpcionRS = 83
        With frm
            .Show()
        End With
    End Sub

    Private Sub MenuItem679_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem679.Click
        Dim frm As New frmVisorRS 'TASA ACTIVA
        OpcionRS = 84
        With frm
            .Show()
        End With
    End Sub

    Private Sub MenuItem680_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem680.Click
        Dim frm As New frmVisorRS 'Detalle de cartera prprestamos
        OpcionRS = 85
        With frm
            .Show()
        End With
    End Sub

    Private Sub MenuItem681_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem681.Click
        Dim frm As New frmCambioDui
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MenuItem682_Click(sender As Object, e As EventArgs) Handles MenuItem682.Click
        Try
            Dim frm As New frmMAhTipoAhorro
            frm.MdiParent = Me
            frm.Show()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MenuItem267_Click_1(sender As Object, e As EventArgs) Handles MenuItem267.Click
        Dim frm As New frmRubros
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem683_Click(sender As Object, e As EventArgs) Handles MenuItem683.Click
        Dim frm As New frmItemRubroDocumento
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem684_Click(sender As Object, e As EventArgs) Handles MenuItem684.Click
        'Dim ofrm As New frmMsCaLogin
        'ofrm.Origen = "C"
        'ofrm.Show()

        Dim frm As New frmMChequesBoveda
        With frm
            .Show()
        End With
    End Sub

    Private Sub MenuItem95_Click(sender As Object, e As EventArgs) Handles MenuItem95.Click

    End Sub

    Private Sub MenuItem686_Click(sender As Object, e As EventArgs) Handles MenuItem686.Click
        Dim frm As New frmVisorRS 'Detalle de cartera Ahorros
        OpcionRS = 91
        With frm
            .Show()
        End With
    End Sub

    Private Sub MenuItem687_Click(sender As Object, e As EventArgs) Handles MenuItem687.Click
        Dim frm As New frmVisorRS 'Detalle de cartera APORTACIONES
        OpcionRS = 92
        With frm
            .Show()
        End With
    End Sub

    Private Sub MenuItem688_Click(sender As Object, e As EventArgs) Handles MenuItem688.Click
        Dim frm As New frmVisorRS 'Detalle de cartera APORTACIONES
        OpcionRS = 93
        With frm
            .Show()
        End With
    End Sub

    Private Sub MenuItem182_Click(sender As Object, e As EventArgs) Handles MenuItem182.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 8 'Reporte de colocación de creditos por sucursal
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
    Private Sub MenuItem343_Click(sender As Object, e As EventArgs) Handles MenuItem343.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 39 'estado de boveda
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem344_Click(sender As Object, e As EventArgs) Handles MenuItem344.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 101 'Reporte transacciones boveda
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem352_Click_1(sender As Object, e As EventArgs) Handles MenuItem352.Click
        Dim ofrm As New frmVisorRS
        OpcionRS = 98 'Reporte remesas a de boveda a banco
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem353_Click_1(sender As Object, e As EventArgs) Handles MenuItem353.Click
        Dim frm As New frmRemesaCheques
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem524_Click(sender As Object, e As EventArgs) Handles MenuItem524.Click
        Dim frmNivelContab As New frmMNivelContab
        frmNivelContab.MdiParent = Me
        frmNivelContab.WindowState = FormWindowState.Normal
        frmNivelContab.Show()
    End Sub

    Private Sub MenuItem575_Click(sender As Object, e As EventArgs) Handles MenuItem575.Click
        Dim frmNivelCostos As New frmMNivelCostos
        frmNivelCostos.MdiParent = Me
        frmNivelCostos.WindowState = FormWindowState.Normal
        frmNivelCostos.Show()
    End Sub

    Private Sub MenuItem576_Click_1(sender As Object, e As EventArgs) Handles MenuItem576.Click
        Dim frmNivelBenef As New frmMNivelBenef
        frmNivelBenef.MdiParent = Me
        frmNivelBenef.WindowState = FormWindowState.Normal
        frmNivelBenef.Show()
    End Sub

    Private Sub MenuItem16_Click_1(sender As Object, e As EventArgs) Handles MenuItem16.Click
        Dim frmCatContab As New frmMCatContab 'frmMantenimientoCatalogo '
        frmCatContab.MdiParent = Me
        frmCatContab.WindowState = FormWindowState.Normal
        frmCatContab.Show()
    End Sub

    Private Sub MenuItem13_Click(sender As Object, e As EventArgs) Handles MenuItem13.Click
        Dim Ofrm As New frmMBC_CatTransaccionesBoveda 'Mantenimiento Catalogo de Transacciones Boveda
        Ofrm.MdiParent = Me
        Ofrm.Show()
    End Sub

    Private Sub MenuItem14_Click(sender As Object, e As EventArgs) Handles MenuItem14.Click
        Dim ofrm As New frmMsBC_CatTransaccionesSucursales
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem326_Click_1(sender As Object, e As EventArgs) Handles MenuItem326.Click
        Dim Ofrm As New frmMBC_Boveda 'Mantenimiento Boveda
        Ofrm.MdiParent = Me
        Ofrm.Show()
    End Sub

    Private Sub MenuItem606_Click_1(sender As Object, e As EventArgs) Handles MenuItem606.Click
        Dim ofrm As New frmMBc_MovimientosBoveda
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem617_Click(sender As Object, e As EventArgs) Handles MenuItem617.Click
        Dim frm As New frmRemesaCheques
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem353_Click_2(sender As Object, e As EventArgs) Handles MenuItem353.Click
        Dim ofrm As New frmGeneraPartidaIntegracion
        ofrm.Tipo = wrConta.PartidaIntegracion.ProvisionAhorros
        ofrm.Title = "Partida de Provisión de Intereses Ahorros"
        ofrm.Show()
    End Sub

    Private Sub MenuItem618_Click(sender As Object, e As EventArgs) Handles MenuItem618.Click
        Dim ofrm As New frmMsReporteDUI
        ofrm.NumReporte = "2"
        ofrm.Titulo = "Partida de Renuncia de Asociado"
        ofrm.Show()
    End Sub

    Private Sub MenuItem619_Click(sender As Object, e As EventArgs) Handles MenuItem619.Click
        Dim ofrm As New frmGeneraPartidaIntegracionI
        ofrm.Title = "Partida de Intereses pagados DPF"
        ofrm.Tipo = wrConta.PartidaIntegracion.InteresesPagados
        ofrm.Show()
    End Sub

    Private Sub MenuItem138_Click(sender As Object, e As EventArgs) Handles MenuItem138.Click
        Dim ofrm As New frmMPartidasIntegracion
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuItem597_Click(sender As Object, e As EventArgs) Handles MenuItem597.Click

    End Sub

    Private Sub MenuItem332_Click(sender As Object, e As EventArgs) Handles MenuItem332.Click
        Dim frm As New frmVisorRS
        OpcionRS = 72
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem137_Click(sender As Object, e As EventArgs) Handles MenuItem137.Click
        Dim frm As New frmVisorRS
        OpcionRS = 67
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem333_Click(sender As Object, e As EventArgs) Handles MenuItem333.Click
        Dim frm As New frmVisorRS
        OpcionRS = 10
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem334_Click(sender As Object, e As EventArgs) Handles MenuItem334.Click
        Dim frm As New frmVisorRS
        OpcionRS = 103
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem335_Click(sender As Object, e As EventArgs) Handles MenuItem335.Click
        Dim frm As New frmVisorRS
        OpcionRS = 104
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem341_Click(sender As Object, e As EventArgs) Handles MenuItem341.Click
        Dim frm As New frmVisorRS
        OpcionRS = 105
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem464_Click(sender As Object, e As EventArgs) Handles MenuItem464.Click
        Dim frm As New frmVisorRS
        OpcionRS = 106
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem620_Click(sender As Object, e As EventArgs) Handles MenuItem620.Click
        Dim frm As New frmPartidaValorFecha

        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem626_Click(sender As Object, e As EventArgs) Handles MenuItem626.Click
        Dim frm As New frmVisorRS
        OpcionRS = 107
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem627_Click(sender As Object, e As EventArgs) Handles MenuItem627.Click
        Dim frm As New frmVisorRS
        OpcionRS = 108
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem628_Click(sender As Object, e As EventArgs) Handles MenuItem628.Click
        Dim frm As New frmVisorRS
        OpcionRS = 109
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem629_Click(sender As Object, e As EventArgs) Handles MenuItem629.Click
        Dim ofrm As New frmVisorRS 'Detalle de Transacciones de Asociados
        OpcionRS = 61
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem630_Click(sender As Object, e As EventArgs) Handles MenuItem630.Click
        Dim frm As New frmAsocTransferenciasAutomaticas
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem169_Click_1(sender As Object, e As EventArgs) Handles MenuItem169.Click
        Dim ofrm As New frmVisorRS 'Detalle de Transacciones de Asociados
        OpcionRS = 112
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub

    Private Sub MenuItem636_Click(sender As Object, e As EventArgs) Handles MenuItem636.Click
        Dim frm As New uifEfectivo
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuItem654_Click(sender As Object, e As EventArgs) Handles MenuItem654.Click
        Dim ofrm As New frmVisorRS 'Detalle de Transacciones de Asociados Efectivo - cheque
        OpcionRS = 113
        ofrm.MdiParent = Me
        ofrm.Show()
    End Sub
End Class