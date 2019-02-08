﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2407
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsGerencial_AcumuladoMetas
    Inherits DataSet
    
    Private tableReporte As ReporteDataTable
    
    Private tableDatos As DatosDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Reporte")) Is Nothing) Then
                Me.Tables.Add(New ReporteDataTable(ds.Tables("Reporte")))
            End If
            If (Not (ds.Tables("Datos")) Is Nothing) Then
                Me.Tables.Add(New DatosDataTable(ds.Tables("Datos")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Reporte As ReporteDataTable
        Get
            Return Me.tableReporte
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Datos As DatosDataTable
        Get
            Return Me.tableDatos
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsGerencial_AcumuladoMetas = CType(MyBase.Clone,dsGerencial_AcumuladoMetas)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Reporte")) Is Nothing) Then
            Me.Tables.Add(New ReporteDataTable(ds.Tables("Reporte")))
        End If
        If (Not (ds.Tables("Datos")) Is Nothing) Then
            Me.Tables.Add(New DatosDataTable(ds.Tables("Datos")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableReporte = CType(Me.Tables("Reporte"),ReporteDataTable)
        If (Not (Me.tableReporte) Is Nothing) Then
            Me.tableReporte.InitVars
        End If
        Me.tableDatos = CType(Me.Tables("Datos"),DatosDataTable)
        If (Not (Me.tableDatos) Is Nothing) Then
            Me.tableDatos.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsGerencial_AcumuladoMetas"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsGerencial_AcumuladoMetas.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableReporte = New ReporteDataTable
        Me.Tables.Add(Me.tableReporte)
        Me.tableDatos = New DatosDataTable
        Me.Tables.Add(Me.tableDatos)
    End Sub
    
    Private Function ShouldSerializeReporte() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeDatos() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ReporteRowChangeEventHandler(ByVal sender As Object, ByVal e As ReporteRowChangeEvent)
    
    Public Delegate Sub DatosRowChangeEventHandler(ByVal sender As Object, ByVal e As DatosRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ReporteDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnFecha As DataColumn
        
        Private columnEmpresa As DataColumn
        
        Private columnTitulo As DataColumn
        
        Private columnDescripcion As DataColumn
        
        Private columnCodSucursal As DataColumn
        
        Private columnSucursal As DataColumn
        
        Friend Sub New()
            MyBase.New("Reporte")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property FechaColumn As DataColumn
            Get
                Return Me.columnFecha
            End Get
        End Property
        
        Friend ReadOnly Property EmpresaColumn As DataColumn
            Get
                Return Me.columnEmpresa
            End Get
        End Property
        
        Friend ReadOnly Property TituloColumn As DataColumn
            Get
                Return Me.columnTitulo
            End Get
        End Property
        
        Friend ReadOnly Property DescripcionColumn As DataColumn
            Get
                Return Me.columnDescripcion
            End Get
        End Property
        
        Friend ReadOnly Property CodSucursalColumn As DataColumn
            Get
                Return Me.columnCodSucursal
            End Get
        End Property
        
        Friend ReadOnly Property SucursalColumn As DataColumn
            Get
                Return Me.columnSucursal
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ReporteRow
            Get
                Return CType(Me.Rows(index),ReporteRow)
            End Get
        End Property
        
        Public Event ReporteRowChanged As ReporteRowChangeEventHandler
        
        Public Event ReporteRowChanging As ReporteRowChangeEventHandler
        
        Public Event ReporteRowDeleted As ReporteRowChangeEventHandler
        
        Public Event ReporteRowDeleting As ReporteRowChangeEventHandler
        
        Public Overloads Sub AddReporteRow(ByVal row As ReporteRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddReporteRow(ByVal Fecha As Date, ByVal Empresa As String, ByVal Titulo As String, ByVal Descripcion As String, ByVal CodSucursal As String, ByVal Sucursal As String) As ReporteRow
            Dim rowReporteRow As ReporteRow = CType(Me.NewRow,ReporteRow)
            rowReporteRow.ItemArray = New Object() {Fecha, Empresa, Titulo, Descripcion, CodSucursal, Sucursal}
            Me.Rows.Add(rowReporteRow)
            Return rowReporteRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ReporteDataTable = CType(MyBase.Clone,ReporteDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ReporteDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnFecha = Me.Columns("Fecha")
            Me.columnEmpresa = Me.Columns("Empresa")
            Me.columnTitulo = Me.Columns("Titulo")
            Me.columnDescripcion = Me.Columns("Descripcion")
            Me.columnCodSucursal = Me.Columns("CodSucursal")
            Me.columnSucursal = Me.Columns("Sucursal")
        End Sub
        
        Private Sub InitClass()
            Me.columnFecha = New DataColumn("Fecha", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFecha)
            Me.columnEmpresa = New DataColumn("Empresa", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEmpresa)
            Me.columnTitulo = New DataColumn("Titulo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTitulo)
            Me.columnDescripcion = New DataColumn("Descripcion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescripcion)
            Me.columnCodSucursal = New DataColumn("CodSucursal", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCodSucursal)
            Me.columnSucursal = New DataColumn("Sucursal", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSucursal)
        End Sub
        
        Public Function NewReporteRow() As ReporteRow
            Return CType(Me.NewRow,ReporteRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ReporteRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ReporteRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ReporteRowChangedEvent) Is Nothing) Then
                RaiseEvent ReporteRowChanged(Me, New ReporteRowChangeEvent(CType(e.Row,ReporteRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ReporteRowChangingEvent) Is Nothing) Then
                RaiseEvent ReporteRowChanging(Me, New ReporteRowChangeEvent(CType(e.Row,ReporteRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ReporteRowDeletedEvent) Is Nothing) Then
                RaiseEvent ReporteRowDeleted(Me, New ReporteRowChangeEvent(CType(e.Row,ReporteRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ReporteRowDeletingEvent) Is Nothing) Then
                RaiseEvent ReporteRowDeleting(Me, New ReporteRowChangeEvent(CType(e.Row,ReporteRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveReporteRow(ByVal row As ReporteRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ReporteRow
        Inherits DataRow
        
        Private tableReporte As ReporteDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableReporte = CType(Me.Table,ReporteDataTable)
        End Sub
        
        Public Property Fecha As Date
            Get
                Try 
                    Return CType(Me(Me.tableReporte.FechaColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReporte.FechaColumn) = value
            End Set
        End Property
        
        Public Property Empresa As String
            Get
                Try 
                    Return CType(Me(Me.tableReporte.EmpresaColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReporte.EmpresaColumn) = value
            End Set
        End Property
        
        Public Property Titulo As String
            Get
                Try 
                    Return CType(Me(Me.tableReporte.TituloColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReporte.TituloColumn) = value
            End Set
        End Property
        
        Public Property Descripcion As String
            Get
                Try 
                    Return CType(Me(Me.tableReporte.DescripcionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReporte.DescripcionColumn) = value
            End Set
        End Property
        
        Public Property CodSucursal As String
            Get
                Try 
                    Return CType(Me(Me.tableReporte.CodSucursalColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReporte.CodSucursalColumn) = value
            End Set
        End Property
        
        Public Property Sucursal As String
            Get
                Try 
                    Return CType(Me(Me.tableReporte.SucursalColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableReporte.SucursalColumn) = value
            End Set
        End Property
        
        Public Function IsFechaNull() As Boolean
            Return Me.IsNull(Me.tableReporte.FechaColumn)
        End Function
        
        Public Sub SetFechaNull()
            Me(Me.tableReporte.FechaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsEmpresaNull() As Boolean
            Return Me.IsNull(Me.tableReporte.EmpresaColumn)
        End Function
        
        Public Sub SetEmpresaNull()
            Me(Me.tableReporte.EmpresaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTituloNull() As Boolean
            Return Me.IsNull(Me.tableReporte.TituloColumn)
        End Function
        
        Public Sub SetTituloNull()
            Me(Me.tableReporte.TituloColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDescripcionNull() As Boolean
            Return Me.IsNull(Me.tableReporte.DescripcionColumn)
        End Function
        
        Public Sub SetDescripcionNull()
            Me(Me.tableReporte.DescripcionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCodSucursalNull() As Boolean
            Return Me.IsNull(Me.tableReporte.CodSucursalColumn)
        End Function
        
        Public Sub SetCodSucursalNull()
            Me(Me.tableReporte.CodSucursalColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSucursalNull() As Boolean
            Return Me.IsNull(Me.tableReporte.SucursalColumn)
        End Function
        
        Public Sub SetSucursalNull()
            Me(Me.tableReporte.SucursalColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ReporteRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ReporteRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ReporteRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ReporteRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class DatosDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnConceptoMetas As DataColumn
        
        Private columnPlaneado As DataColumn
        
        Private columnTotalRealizado As DataColumn
        
        Private columnPorcentaje As DataColumn
        
        Friend Sub New()
            MyBase.New("Datos")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property ConceptoMetasColumn As DataColumn
            Get
                Return Me.columnConceptoMetas
            End Get
        End Property
        
        Friend ReadOnly Property PlaneadoColumn As DataColumn
            Get
                Return Me.columnPlaneado
            End Get
        End Property
        
        Friend ReadOnly Property TotalRealizadoColumn As DataColumn
            Get
                Return Me.columnTotalRealizado
            End Get
        End Property
        
        Friend ReadOnly Property PorcentajeColumn As DataColumn
            Get
                Return Me.columnPorcentaje
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As DatosRow
            Get
                Return CType(Me.Rows(index),DatosRow)
            End Get
        End Property
        
        Public Event DatosRowChanged As DatosRowChangeEventHandler
        
        Public Event DatosRowChanging As DatosRowChangeEventHandler
        
        Public Event DatosRowDeleted As DatosRowChangeEventHandler
        
        Public Event DatosRowDeleting As DatosRowChangeEventHandler
        
        Public Overloads Sub AddDatosRow(ByVal row As DatosRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddDatosRow(ByVal ConceptoMetas As String, ByVal Planeado As Decimal, ByVal TotalRealizado As Decimal, ByVal Porcentaje As Decimal) As DatosRow
            Dim rowDatosRow As DatosRow = CType(Me.NewRow,DatosRow)
            rowDatosRow.ItemArray = New Object() {ConceptoMetas, Planeado, TotalRealizado, Porcentaje}
            Me.Rows.Add(rowDatosRow)
            Return rowDatosRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As DatosDataTable = CType(MyBase.Clone,DatosDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New DatosDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnConceptoMetas = Me.Columns("ConceptoMetas")
            Me.columnPlaneado = Me.Columns("Planeado")
            Me.columnTotalRealizado = Me.Columns("TotalRealizado")
            Me.columnPorcentaje = Me.Columns("Porcentaje")
        End Sub
        
        Private Sub InitClass()
            Me.columnConceptoMetas = New DataColumn("ConceptoMetas", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnConceptoMetas)
            Me.columnPlaneado = New DataColumn("Planeado", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPlaneado)
            Me.columnTotalRealizado = New DataColumn("TotalRealizado", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTotalRealizado)
            Me.columnPorcentaje = New DataColumn("Porcentaje", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPorcentaje)
        End Sub
        
        Public Function NewDatosRow() As DatosRow
            Return CType(Me.NewRow,DatosRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New DatosRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(DatosRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.DatosRowChangedEvent) Is Nothing) Then
                RaiseEvent DatosRowChanged(Me, New DatosRowChangeEvent(CType(e.Row,DatosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.DatosRowChangingEvent) Is Nothing) Then
                RaiseEvent DatosRowChanging(Me, New DatosRowChangeEvent(CType(e.Row,DatosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.DatosRowDeletedEvent) Is Nothing) Then
                RaiseEvent DatosRowDeleted(Me, New DatosRowChangeEvent(CType(e.Row,DatosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.DatosRowDeletingEvent) Is Nothing) Then
                RaiseEvent DatosRowDeleting(Me, New DatosRowChangeEvent(CType(e.Row,DatosRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveDatosRow(ByVal row As DatosRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class DatosRow
        Inherits DataRow
        
        Private tableDatos As DatosDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableDatos = CType(Me.Table,DatosDataTable)
        End Sub
        
        Public Property ConceptoMetas As String
            Get
                Try 
                    Return CType(Me(Me.tableDatos.ConceptoMetasColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDatos.ConceptoMetasColumn) = value
            End Set
        End Property
        
        Public Property Planeado As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableDatos.PlaneadoColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDatos.PlaneadoColumn) = value
            End Set
        End Property
        
        Public Property TotalRealizado As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableDatos.TotalRealizadoColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDatos.TotalRealizadoColumn) = value
            End Set
        End Property
        
        Public Property Porcentaje As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableDatos.PorcentajeColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableDatos.PorcentajeColumn) = value
            End Set
        End Property
        
        Public Function IsConceptoMetasNull() As Boolean
            Return Me.IsNull(Me.tableDatos.ConceptoMetasColumn)
        End Function
        
        Public Sub SetConceptoMetasNull()
            Me(Me.tableDatos.ConceptoMetasColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPlaneadoNull() As Boolean
            Return Me.IsNull(Me.tableDatos.PlaneadoColumn)
        End Function
        
        Public Sub SetPlaneadoNull()
            Me(Me.tableDatos.PlaneadoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTotalRealizadoNull() As Boolean
            Return Me.IsNull(Me.tableDatos.TotalRealizadoColumn)
        End Function
        
        Public Sub SetTotalRealizadoNull()
            Me(Me.tableDatos.TotalRealizadoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPorcentajeNull() As Boolean
            Return Me.IsNull(Me.tableDatos.PorcentajeColumn)
        End Function
        
        Public Sub SetPorcentajeNull()
            Me(Me.tableDatos.PorcentajeColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class DatosRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As DatosRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As DatosRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As DatosRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class