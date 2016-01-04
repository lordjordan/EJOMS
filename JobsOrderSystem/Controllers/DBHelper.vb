
Imports System.Data.SqlClient
Public Class DBHelper
    Implements IDisposable

    Property Connected As Boolean
    Property Connectionstring As String
    Private con As New SqlConnection
    Private cmd As New SqlCommand


    Public Sub New()
        Connected = False
    End Sub

    Public Sub New(ConnectionString As String)
        Connected = False
        Me.Connectionstring = ConnectionString
    End Sub

    Private Function BuildCommand(ByRef cmd As SqlCommand, params As Dictionary(Of String, Object)) As SqlClient.SqlCommand
        'Try
        con = New SqlClient.SqlConnection(Connectionstring)
        cmd.Connection = con
        AddParameters(cmd, params)
        con.Open()
        Connected = True
        'Catch ex As Exception
        '    Connected = False
        '    MsgBox("Unable to connect to the database", MsgBoxStyle.Critical)
        'End Try

        Return cmd


    End Function

    Private Sub AddParameters(ByRef cmd As SqlCommand, params As Dictionary(Of String, Object))
        If params Is Nothing Then Exit Sub
        For Each kvp As KeyValuePair(Of String, Object) In params
            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
        Next
    End Sub

    Public Function ExecuteReader(commandText As String, Optional params As Dictionary(Of String, Object) = Nothing) As SqlDataReader
        cmd.Parameters.Clear()
        cmd.CommandText = commandText
        Using cmd
            BuildCommand(cmd, params)
            Return cmd.ExecuteReader()
        End Using
        con.Close()

    End Function

    Public Function ExecuteNonQuery(commandText As String, Optional params As Dictionary(Of String, Object) = Nothing) As Long
        cmd.Parameters.Clear()
        cmd.CommandText = commandText
        Using cmd
            BuildCommand(cmd, params)
            Return cmd.ExecuteNonQuery
        End Using
    End Function

    Public Function ExecuteScalar(commandText As String, Optional params As Dictionary(Of String, Object) = Nothing) As Long
        cmd.CommandText = commandText
        Using cmd
            BuildCommand(cmd, params)
            Return cmd.ExecuteScalar
        End Using
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        con.Close()
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class