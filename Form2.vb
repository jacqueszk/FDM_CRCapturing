Imports System.Data.SqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.TextBox1.ReadOnly = True
        Me.TextBox2.ReadOnly = True
        If Me.TextBox1.Text = "ACTIVE" Then

            Me.TextBox1.BackColor = Color.Green

        ElseIf Me.TextBox1.Text = "INACTIVE" Then
            Me.TextBox1.BackColor = Color.Red
        End If


        If TextBox3.Text = "0" Then
            TextBox3.Text = "56L W T1"
        ElseIf TextBox3.Text = "1" Then
            TextBox3.Text = "56L W T2"
        ElseIf TextBox3.Text = "2" Then
            TextBox3.Text = "56L W T3"
        ElseIf TextBox3.Text = "3" Then
            TextBox3.Text = "56L W T4"
        ElseIf TextBox3.Text = "4" Then
            TextBox3.Text = "58L E T1"
        ElseIf TextBox3.Text = "5" Then
            TextBox3.Text = "58L E T4"
        ElseIf TextBox3.Text = "6" Then
            TextBox3.Text = "58L R T5"
        ElseIf TextBox3.Text = "7" Then
            TextBox3.Text = "58L R T6"
        ElseIf TextBox3.Text = "8" Then
            TextBox3.Text = "58L R T7"
        ElseIf TextBox3.Text = "9" Then
            TextBox3.Text = "58L R T8"
        ElseIf TextBox3.Text = "10" Then
            TextBox3.Text = "58L R T9"
        ElseIf TextBox3.Text = "11" Then
            TextBox3.Text = "60L E T0"
        ElseIf TextBox3.Text = "12" Then
            TextBox3.Text = "60L E T1"
        ElseIf TextBox3.Text = "13" Then
            TextBox3.Text = "60L E T2"
        ElseIf TextBox3.Text = "14" Then
            TextBox3.Text = "60L E T3"
        ElseIf TextBox3.Text = "15" Then
            TextBox3.Text = "60L E T4"
        ElseIf TextBox3.Text = "16" Then
            TextBox3.Text = "60L E T5"
        ElseIf TextBox3.Text = "17" Then
            TextBox3.Text = "60L E T6"
        ElseIf TextBox3.Text = "18" Then
            TextBox3.Text = "60L E T7"
        ElseIf TextBox3.Text = "19" Then
            TextBox3.Text = "60L E T1B"
        ElseIf TextBox3.Text = "20" Then
            TextBox3.Text = "60L_W_T11"
        ElseIf TextBox3.Text = "21" Then
            TextBox3.Text = "60L_W_T12"
        ElseIf TextBox3.Text = "22" Then
            TextBox3.Text = "60L_W_T13"
        ElseIf TextBox3.Text = "23" Then
            TextBox3.Text = "60L_W_T14"
        End If


        qry2 = "select * from [BussImprovement].[dbo].[KDM_Dim_TStatus]"

        cmd2 = New SqlCommand(qry2, con)
        da2 = New SqlDataAdapter(cmd2)
        ds2 = New DataSet
        da2.Fill(ds2, "MyTunnels2")

        ComboBox1.DataSource = ds2.Tables("MyTunnels2")
        Me.ComboBox1.DisplayMember = "Tunnel Status"


        qry3 = "select * from [BussImprovement].[dbo].[KDM_Dim_TReason]"

        cmd3 = New SqlCommand(qry3, con)
        da3 = New SqlDataAdapter(cmd3)
        ds3 = New DataSet
        da3.Fill(ds3, "MyTunnels3")

        ComboBox2.DataSource = ds3.Tables("MyTunnels3")
        Me.ComboBox2.DisplayMember = "Reason"

        Me.ComboBox1.Text = ""
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""

        qry5 = "select * from [BussImprovement].[dbo].[KDM_Dim_CR_Operators]"

        cmd5 = New SqlCommand(qry5, con)
        da5 = New SqlDataAdapter(cmd5)
        ds5 = New DataSet
        da5.Fill(ds5, "MyTunnels5")

        ComboBox3.DataSource = ds5.Tables("MyTunnels5")
        Me.ComboBox3.DisplayMember = "CROperators"

        Me.ComboBox1.Text = ""
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.ComboBox1.Text = "" Then

            MsgBox("No changes made")
            Exit Sub

        ElseIf Me.ComboBox2.Text = TextBox2.Text Then

            MsgBox("No changes made")
            Exit Sub

        ElseIf Me.ComboBox2.Text = "" Then
            MsgBox("Choose reason")
            Exit Sub

        ElseIf Me.ComboBox3.Text = "" Then
            MsgBox("Choose Control Room Operator")
            Exit Sub

        Else
            qry4 = "Insert into dbo.KDMTunnel_StatusHistory([ID],[TDS],[LHD_Num],[Operator_Name],[lLevel],[Tun_type],[Tunnel],[Orientation],[DP],[lStatus],[Reason],[Order_Tonnes],[Actual_Tonnes],[CROperator]) VALUES ('" & Me.TextBox3.Text & "','" & Me.DateTimePicker2.Value & "','NULL','NULL','NULL','NULL','NULL','NULL','NULL','" & Me.ComboBox1.Text & "','" & Me.ComboBox2.Text & "','NULL','NULL','" & Me.ComboBox3.Text & "')"
            cmd4 = New SqlCommand(qry4, con)
            'da4 = New SqlDataAdapter(cmd4)
            cmd4.ExecuteNonQuery()

        End If
        MsgBox("Updated")

        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.ComboBox2.Text = ""
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""

        Me.Hide()
        ' Form1.Refresh()
        Application.Restart()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "ACTIVE" Then
            ComboBox2.Text = "NULL"
            ComboBox2.Enabled = False
        ElseIf ComboBox1.Text = "INACTIVE" Then
            ComboBox2.Enabled = True

        End If



    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged




    End Sub
End Class