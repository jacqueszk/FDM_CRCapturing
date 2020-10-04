Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized



        con.Open()


        qry = "select t.*
From (SELECT ID, MAX(TDS) AS latest_time
           FROM [BussImprovement].[dbo].[KDMTunnel_StatusHistory]
         GROUP
             BY ID) as m
			 inner 
			 join [BussImprovement].[dbo].[KDMTunnel_StatusHistory] as t
			 on t.ID = m.ID
			 and t.TDS = m.latest_time
                order by t.ID Asc"

        cmd = New SqlCommand(qry, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "MyTunnels")

        ListBox1.DataSource = ds.Tables("MyTunnels")
        ListBox1.DisplayMember = "ID"

        bs = New BindingSource
        bs.DataSource = ds.Tables("MyTunnels")

        TextBox1.DataBindings.Add("Text", bs, "lStatus")
        TextBox2.DataBindings.Add("Text", bs, "Reason")
        TextBox3.DataBindings.Add("Text", bs, "TDS")
        TextBox4.DataBindings.Add("Text", bs, "Delay")


        If TextBox4.Text = "Remediated" Then
            TextBox4.Text = ""

        End If


        If TextBox1.Text = "ACTIVE" And TextBox4.Text = "" Then

            TextBox1.BackColor = Color.Green

        ElseIf TextBox1.Text = "ACTIVE" And TextBox4.Text <> "" Then

            TextBox1.BackColor = Color.Orange

        ElseIf TextBox1.Text = "INACTIVE" Then
            TextBox1.BackColor = Color.Red

        End If

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox4.ReadOnly = True

        ListBox1.SelectedIndex = 0

        Exit Sub


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        If Not IsNothing(bs) Then

            bs.Position = ListBox1.SelectedIndex


            If TextBox4.Text = "Remediated" Then
                TextBox4.Text = ""

            End If


            If TextBox1.Text = "ACTIVE" And TextBox4.Text = "" Then

                TextBox1.BackColor = Color.Green

            ElseIf TextBox1.Text = "ACTIVE" And TextBox4.Text <> "" Then

                TextBox1.BackColor = Color.Orange

            ElseIf TextBox1.Text = "INACTIVE" Then
                TextBox1.BackColor = Color.Red

            End If

            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            TextBox4.ReadOnly = True


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Mid(TextBox3.Text, 15, 2) = DatePart(DateInterval.Minute, DateTime.Now) Then
            MsgBox("Data Loading from previous change, please wait 1 minute")
            Exit Sub
        End If

        Form2.TextBox1.Text = Me.TextBox1.Text
        Form2.TextBox2.Text = Me.TextBox2.Text
        Form2.TextBox3.Text = Me.ListBox1.SelectedIndex.ToString
        Form2.ComboBox4.Text = Me.TextBox4.Text
        Form2.Button3.Enabled = False


        If Me.TextBox4.Text <> "" Then
            Form2.CheckBox1.Checked = True
            Form2.CheckBox1.Enabled = False
            Form2.Button3.Enabled = True


        End If

        Me.Hide()
        Form2.Show()


    End Sub

    Private Sub Tunnel_Enter(sender As Object, e As EventArgs) Handles Tunnel.Enter

    End Sub
End Class
