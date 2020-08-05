Imports System.Data.SqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Private x As Int16

        Me.TextBox1.ReadOnly = True
        Me.TextBox2.ReadOnly = True
        If Me.TextBox1.Text = "ACTIVE" Then

            Me.TextBox1.BackColor = Color.Green

        ElseIf Me.TextBox1.Text = "INACTIVE" Then
            Me.TextBox1.BackColor = Color.Red
        End If



        '        qry2 = "select t.*
        'From (SELECT ID, MAX(TDS) AS latest_time
        '           FROM [BussImprovement].[dbo].[KDMTunnel_StatusHistory]
        '         GROUP
        '             BY ID) as m
        '			 inner 
        '			 join [BussImprovement].[dbo].[KDMTunnel_StatusHistory] as t
        '			 on t.ID = m.ID
        '			 and t.TDS = m.latest_time
        '                order by t.ID Asc"

        '        cmd2 = New SqlCommand(qry2, con)
        '        da2 = New SqlDataAdapter(cmd2)

        '        ds2 = New DataSet
        '        da2.Fill(ds2, "MyTunnels")

        ComboBox1.DataSource = ds.Tables("MyTunnels")
        Me.ComboBox1.DisplayMember = "lStatus"
        Me.ComboBox2.DisplayMember = "Reason"





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click





        ' qry2 = "Insert into dbo.KDMTunnel_StatusHistory (ID,TDS,LHD_Num,Operator_Name,lLevel,Tun_type,Tunnel,Orientation,DP,lStatus,Reason,Order_Tonnes,Actual_Tonnes,CROperator) VALUES ('" & LastCellA2.Value & "', '" & LastCellA2.Offset(, 1).Value & "' , '" & LastCellA2.Offset(, 2).Value & "', '" & LastCellA2.Offset(, 3).Value & "', '" & LastCellA2.Offset(, 4).Value & "', '" & LastCellA2.Offset(, 5).Value & "', '" & LastCellA2.Offset(, 6).Value & "', '" & LastCellA2.Offset(, 7).Value & "','" & LastCellA2.Offset(, 8).Value & "','" & LastCellA2.Offset(, 9).Value & "','" & LastCellA2.Offset(, 10).Value & "','" & LastCellA2.Offset(, 11).Value & "','" & LastCellA2.Offset(, 12).Value & "','" & LastCellA2.Offset(, 13).Value & "')"


        'Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class