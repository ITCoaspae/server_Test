﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2032
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
Public Class dsTablaAmortizaSimulada
    Inherits DataSet
    
    Private tableAmortiza As AmortizaDataTable
    
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
            If (Not (ds.Tables("Amortiza")) Is Nothing) Then
                Me.Tables.Add(New AmortizaDataTable(ds.Tables("Amortiza")))
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
    Public ReadOnly Property Amortiza As AmortizaDataTable
        Get
            Return Me.tableAmortiza
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsTablaAmortizaSimulada = CType(MyBase.Clone,dsTablaAmortizaSimulada)
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
        If (Not (ds.Tables("Amortiza")) Is Nothing) Then
            Me.Tables.Add(New AmortizaDataTable(ds.Tables("Amortiza")))
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
        Me.tableAmortiza = CType(Me.Tables("Amortiza"),AmortizaDataTable)
        If (Not (Me.tableAmortiza) Is Nothing) Then
            Me.tableAmortiza.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsTablaAmortizaSimulada"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/dsTablaAmortizaSimulada.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableAmortiza = New AmortizaDataTable
        Me.Tables.Add(Me.tableAmortiza)
    End Sub
    
    Private Function ShouldSerializeAmortiza() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub AmortizaRowChangeEventHandler(ByVal sender As Object, ByVal e As AmortizaRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AmortizaDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCuota_Num As DataColumn
        
        Private columnFechaPago As DataColumn
        
        Private columnCuota_Prestamo As DataColumn
        
        Private columnInteres As DataColumn
        
        Private columnCuota_Interes As DataColumn
        
        Private columnAbono_Capital As DataColumn
        
        Private columnSaldo As DataColumn
        
        Private columnSeguroDeuda As DataColumn
        
        Private columnSeguroDanios As DataColumn
        
        Private columnSeguroVida As DataColumn
        
        Private columnSeguroDesempleo As DataColumn
        
        Private columnAportacion As DataColumn
        
        Private columnAhorros As DataColumn
        
        Private columnComisionManejo As DataColumn
        
        Private columnCuota_Total As DataColumn
        
        Private columnSolo_Interes As DataColumn
        
        Private columnDias_Interes As DataColumn
        
        Friend Sub New()
            MyBase.New("Amortiza")
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
        
        Friend ReadOnly Property Cuota_NumColumn As DataColumn
            Get
                Return Me.columnCuota_Num
            End Get
        End Property
        
        Friend ReadOnly Property FechaPagoColumn As DataColumn
            Get
                Return Me.columnFechaPago
            End Get
        End Property
        
        Friend ReadOnly Property Cuota_PrestamoColumn As DataColumn
            Get
                Return Me.columnCuota_Prestamo
            End Get
        End Property
        
        Friend ReadOnly Property InteresColumn As DataColumn
            Get
                Return Me.columnInteres
            End Get
        End Property
        
        Friend ReadOnly Property Cuota_InteresColumn As DataColumn
            Get
                Return Me.columnCuota_Interes
            End Get
        End Property
        
        Friend ReadOnly Property Abono_CapitalColumn As DataColumn
            Get
                Return Me.columnAbono_Capital
            End Get
        End Property
        
        Friend ReadOnly Property SaldoColumn As DataColumn
            Get
                Return Me.columnSaldo
            End Get
        End Property
        
        Friend ReadOnly Property SeguroDeudaColumn As DataColumn
            Get
                Return Me.columnSeguroDeuda
            End Get
        End Property
        
        Friend ReadOnly Property SeguroDaniosColumn As DataColumn
            Get
                Return Me.columnSeguroDanios
            End Get
        End Property
        
        Friend ReadOnly Property SeguroVidaColumn As DataColumn
            Get
                Return Me.columnSeguroVida
            End Get
        End Property
        
        Friend ReadOnly Property SeguroDesempleoColumn As DataColumn
            Get
                Return Me.columnSeguroDesempleo
            End Get
        End Property
        
        Friend ReadOnly Property AportacionColumn As DataColumn
            Get
                Return Me.columnAportacion
            End Get
        End Property
        
        Friend ReadOnly Property AhorrosColumn As DataColumn
            Get
                Return Me.columnAhorros
            End Get
        End Property
        
        Friend ReadOnly Property ComisionManejoColumn As DataColumn
            Get
                Return Me.columnComisionManejo
            End Get
        End Property
        
        Friend ReadOnly Property Cuota_TotalColumn As DataColumn
            Get
                Return Me.columnCuota_Total
            End Get
        End Property
        
        Friend ReadOnly Property Solo_InteresColumn As DataColumn
            Get
                Return Me.columnSolo_Interes
            End Get
        End Property
        
        Friend ReadOnly Property Dias_InteresColumn As DataColumn
            Get
                Return Me.columnDias_Interes
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As AmortizaRow
            Get
                Return CType(Me.Rows(index),AmortizaRow)
            End Get
        End Property
        
        Public Event AmortizaRowChanged As AmortizaRowChangeEventHandler
        
        Public Event AmortizaRowChanging As AmortizaRowChangeEventHandler
        
        Public Event AmortizaRowDeleted As AmortizaRowChangeEventHandler
        
        Public Event AmortizaRowDeleting As AmortizaRowChangeEventHandler
        
        Public Overloads Sub AddAmortizaRow(ByVal row As AmortizaRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddAmortizaRow( _
                    ByVal Cuota_Num As Integer,  _
                    ByVal FechaPago As Date,  _
                    ByVal Cuota_Prestamo As Double,  _
                    ByVal Interes As Double,  _
                    ByVal Cuota_Interes As Double,  _
                    ByVal Abono_Capital As Double,  _
                    ByVal Saldo As Double,  _
                    ByVal SeguroDeuda As Double,  _
                    ByVal SeguroDanios As Double,  _
                    ByVal SeguroVida As Double,  _
                    ByVal SeguroDesempleo As Double,  _
                    ByVal Aportacion As Double,  _
                    ByVal Ahorros As Double,  _
                    ByVal ComisionManejo As Double,  _
                    ByVal Cuota_Total As Double,  _
                    ByVal Solo_Interes As Integer,  _
                    ByVal Dias_Interes As Integer) As AmortizaRow
            Dim rowAmortizaRow As AmortizaRow = CType(Me.NewRow,AmortizaRow)
            rowAmortizaRow.ItemArray = New Object() {Cuota_Num, FechaPago, Cuota_Prestamo, Interes, Cuota_Interes, Abono_Capital, Saldo, SeguroDeuda, SeguroDanios, SeguroVida, SeguroDesempleo, Aportacion, Ahorros, ComisionManejo, Cuota_Total, Solo_Interes, Dias_Interes}
            Me.Rows.Add(rowAmortizaRow)
            Return rowAmortizaRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As AmortizaDataTable = CType(MyBase.Clone,AmortizaDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New AmortizaDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCuota_Num = Me.Columns("Cuota_Num")
            Me.columnFechaPago = Me.Columns("FechaPago")
            Me.columnCuota_Prestamo = Me.Columns("Cuota_Prestamo")
            Me.columnInteres = Me.Columns("Interes")
            Me.columnCuota_Interes = Me.Columns("Cuota_Interes")
            Me.columnAbono_Capital = Me.Columns("Abono_Capital")
            Me.columnSaldo = Me.Columns("Saldo")
            Me.columnSeguroDeuda = Me.Columns("SeguroDeuda")
            Me.columnSeguroDanios = Me.Columns("SeguroDanios")
            Me.columnSeguroVida = Me.Columns("SeguroVida")
            Me.columnSeguroDesempleo = Me.Columns("SeguroDesempleo")
            Me.columnAportacion = Me.Columns("Aportacion")
            Me.columnAhorros = Me.Columns("Ahorros")
            Me.columnComisionManejo = Me.Columns("ComisionManejo")
            Me.columnCuota_Total = Me.Columns("Cuota_Total")
            Me.columnSolo_Interes = Me.Columns("Solo_Interes")
            Me.columnDias_Interes = Me.Columns("Dias_Interes")
        End Sub
        
        Private Sub InitClass()
            Me.columnCuota_Num = New DataColumn("Cuota_Num", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCuota_Num)
            Me.columnFechaPago = New DataColumn("FechaPago", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFechaPago)
            Me.columnCuota_Prestamo = New DataColumn("Cuota_Prestamo", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCuota_Prestamo)
            Me.columnInteres = New DataColumn("Interes", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnInteres)
            Me.columnCuota_Interes = New DataColumn("Cuota_Interes", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCuota_Interes)
            Me.columnAbono_Capital = New DataColumn("Abono_Capital", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAbono_Capital)
            Me.columnSaldo = New DataColumn("Saldo", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSaldo)
            Me.columnSeguroDeuda = New DataColumn("SeguroDeuda", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSeguroDeuda)
            Me.columnSeguroDanios = New DataColumn("SeguroDanios", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSeguroDanios)
            Me.columnSeguroVida = New DataColumn("SeguroVida", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSeguroVida)
            Me.columnSeguroDesempleo = New DataColumn("SeguroDesempleo", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSeguroDesempleo)
            Me.columnAportacion = New DataColumn("Aportacion", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAportacion)
            Me.columnAhorros = New DataColumn("Ahorros", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAhorros)
            Me.columnComisionManejo = New DataColumn("ComisionManejo", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnComisionManejo)
            Me.columnCuota_Total = New DataColumn("Cuota_Total", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCuota_Total)
            Me.columnSolo_Interes = New DataColumn("Solo_Interes", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSolo_Interes)
            Me.columnDias_Interes = New DataColumn("Dias_Interes", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDias_Interes)
        End Sub
        
        Public Function NewAmortizaRow() As AmortizaRow
            Return CType(Me.NewRow,AmortizaRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New AmortizaRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(AmortizaRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.AmortizaRowChangedEvent) Is Nothing) Then
                RaiseEvent AmortizaRowChanged(Me, New AmortizaRowChangeEvent(CType(e.Row,AmortizaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.AmortizaRowChangingEvent) Is Nothing) Then
                RaiseEvent AmortizaRowChanging(Me, New AmortizaRowChangeEvent(CType(e.Row,AmortizaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.AmortizaRowDeletedEvent) Is Nothing) Then
                RaiseEvent AmortizaRowDeleted(Me, New AmortizaRowChangeEvent(CType(e.Row,AmortizaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.AmortizaRowDeletingEvent) Is Nothing) Then
                RaiseEvent AmortizaRowDeleting(Me, New AmortizaRowChangeEvent(CType(e.Row,AmortizaRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveAmortizaRow(ByVal row As AmortizaRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AmortizaRow
        Inherits DataRow
        
        Private tableAmortiza As AmortizaDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableAmortiza = CType(Me.Table,AmortizaDataTable)
        End Sub
        
        Public Property Cuota_Num As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.Cuota_NumColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.Cuota_NumColumn) = value
            End Set
        End Property
        
        Public Property FechaPago As Date
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.FechaPagoColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.FechaPagoColumn) = value
            End Set
        End Property
        
        Public Property Cuota_Prestamo As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.Cuota_PrestamoColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.Cuota_PrestamoColumn) = value
            End Set
        End Property
        
        Public Property Interes As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.InteresColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.InteresColumn) = value
            End Set
        End Property
        
        Public Property Cuota_Interes As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.Cuota_InteresColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.Cuota_InteresColumn) = value
            End Set
        End Property
        
        Public Property Abono_Capital As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.Abono_CapitalColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.Abono_CapitalColumn) = value
            End Set
        End Property
        
        Public Property Saldo As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.SaldoColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.SaldoColumn) = value
            End Set
        End Property
        
        Public Property SeguroDeuda As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.SeguroDeudaColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.SeguroDeudaColumn) = value
            End Set
        End Property
        
        Public Property SeguroDanios As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.SeguroDaniosColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.SeguroDaniosColumn) = value
            End Set
        End Property
        
        Public Property SeguroVida As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.SeguroVidaColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.SeguroVidaColumn) = value
            End Set
        End Property
        
        Public Property SeguroDesempleo As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.SeguroDesempleoColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.SeguroDesempleoColumn) = value
            End Set
        End Property
        
        Public Property Aportacion As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.AportacionColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.AportacionColumn) = value
            End Set
        End Property
        
        Public Property Ahorros As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.AhorrosColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.AhorrosColumn) = value
            End Set
        End Property
        
        Public Property ComisionManejo As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.ComisionManejoColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.ComisionManejoColumn) = value
            End Set
        End Property
        
        Public Property Cuota_Total As Double
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.Cuota_TotalColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.Cuota_TotalColumn) = value
            End Set
        End Property
        
        Public Property Solo_Interes As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.Solo_InteresColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.Solo_InteresColumn) = value
            End Set
        End Property
        
        Public Property Dias_Interes As Integer
            Get
                Try 
                    Return CType(Me(Me.tableAmortiza.Dias_InteresColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAmortiza.Dias_InteresColumn) = value
            End Set
        End Property
        
        Public Function IsCuota_NumNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.Cuota_NumColumn)
        End Function
        
        Public Sub SetCuota_NumNull()
            Me(Me.tableAmortiza.Cuota_NumColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFechaPagoNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.FechaPagoColumn)
        End Function
        
        Public Sub SetFechaPagoNull()
            Me(Me.tableAmortiza.FechaPagoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCuota_PrestamoNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.Cuota_PrestamoColumn)
        End Function
        
        Public Sub SetCuota_PrestamoNull()
            Me(Me.tableAmortiza.Cuota_PrestamoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsInteresNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.InteresColumn)
        End Function
        
        Public Sub SetInteresNull()
            Me(Me.tableAmortiza.InteresColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCuota_InteresNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.Cuota_InteresColumn)
        End Function
        
        Public Sub SetCuota_InteresNull()
            Me(Me.tableAmortiza.Cuota_InteresColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAbono_CapitalNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.Abono_CapitalColumn)
        End Function
        
        Public Sub SetAbono_CapitalNull()
            Me(Me.tableAmortiza.Abono_CapitalColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSaldoNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.SaldoColumn)
        End Function
        
        Public Sub SetSaldoNull()
            Me(Me.tableAmortiza.SaldoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSeguroDeudaNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.SeguroDeudaColumn)
        End Function
        
        Public Sub SetSeguroDeudaNull()
            Me(Me.tableAmortiza.SeguroDeudaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSeguroDaniosNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.SeguroDaniosColumn)
        End Function
        
        Public Sub SetSeguroDaniosNull()
            Me(Me.tableAmortiza.SeguroDaniosColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSeguroVidaNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.SeguroVidaColumn)
        End Function
        
        Public Sub SetSeguroVidaNull()
            Me(Me.tableAmortiza.SeguroVidaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSeguroDesempleoNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.SeguroDesempleoColumn)
        End Function
        
        Public Sub SetSeguroDesempleoNull()
            Me(Me.tableAmortiza.SeguroDesempleoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAportacionNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.AportacionColumn)
        End Function
        
        Public Sub SetAportacionNull()
            Me(Me.tableAmortiza.AportacionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAhorrosNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.AhorrosColumn)
        End Function
        
        Public Sub SetAhorrosNull()
            Me(Me.tableAmortiza.AhorrosColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsComisionManejoNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.ComisionManejoColumn)
        End Function
        
        Public Sub SetComisionManejoNull()
            Me(Me.tableAmortiza.ComisionManejoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCuota_TotalNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.Cuota_TotalColumn)
        End Function
        
        Public Sub SetCuota_TotalNull()
            Me(Me.tableAmortiza.Cuota_TotalColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSolo_InteresNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.Solo_InteresColumn)
        End Function
        
        Public Sub SetSolo_InteresNull()
            Me(Me.tableAmortiza.Solo_InteresColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDias_InteresNull() As Boolean
            Return Me.IsNull(Me.tableAmortiza.Dias_InteresColumn)
        End Function
        
        Public Sub SetDias_InteresNull()
            Me(Me.tableAmortiza.Dias_InteresColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AmortizaRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As AmortizaRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As AmortizaRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As AmortizaRow
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
