Imports System.Data.SqlClient


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.KDMTunnel_StatusHistoryTableAdapter.Fill(Me.BussImprovementDataSet.KDMTunnel_StatusHistory)
        Me.WindowState = FormWindowState.Maximized
        x = 0


        con.Open()


        qry = "select t.*, 
case 
when t.Delay = 'Remediated'  then
concat(t.[ID],' | ',t.[lStatus],' | ',t.[Reason]) 
when t.Delay = ''  then
concat(t.[ID],' | ',t.[lStatus],' | ',t.[Reason]) 
ELSE
concat(t.[ID],' | ',t.[lStatus],' | ',t.[Reason],' | ','DELAYED') 
end as ListBox
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

        ' ListBox1.DrawMode = DrawMode.OwnerDrawFixed



        ListBox1.DataSource = ds.Tables("MyTunnels")
        ListBox1.DisplayMember = "ListBox"
        ListBox1.ValueMember = "ListBox"

        Dim fsize As Integer
        fsize = 8
        ListBox1.Font = New Font(ListBox1.Font.Name, fsize, ListBox1.Font.Style, ListBox1.Font.Unit)



        qry6 = "select t.*
From (SELECT ID, MAX(TDS) AS latest_time
           FROM [BussImprovement].[dbo].[KDMTunnel_StatusHistory]
         GROUP
             BY ID) as m
			 inner 
			 join [BussImprovement].[dbo].[KDMTunnel_StatusHistory] as t
			 on t.ID = m.ID
			 and t.TDS = m.latest_time
                where t.[Delay] like 'IDLE'
                order by t.ID Asc"

        cmd6 = New SqlCommand(qry6, con)
        da6 = New SqlDataAdapter(cmd6)
        ds6 = New DataSet
        da6.Fill(ds6, "MyTunnels6")


        ListBox2.DataSource = ds6.Tables("MyTunnels6")
        ListBox2.DisplayMember = "ID"
        ListBox2.ValueMember = "ID"
        ListBox2.Enabled = False


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

        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox10.ReadOnly = True




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



        Form2.TextBox1.Text = Me.TextBox1.Text
        Form2.TextBox2.Text = Me.TextBox2.Text
        Form2.TextBox3.Text = Me.ListBox1.SelectedIndex.ToString
        Form2.ComboBox4.Text = Me.TextBox4.Text
        Form2.Button3.Enabled = False


        If Me.TextBox4.Text <> "" And Me.TextBox4.Text <> "IDLE" Then
            Form2.CheckBox1.Checked = True
            Form2.CheckBox1.Enabled = False
            Form2.Button3.Enabled = True
            Form2.ComboBox4.Text = Me.TextBox4.Text

        ElseIf Me.TextBox4.Text = "IDLE" Then
            Form2.CheckBox1.Checked = True
            Form2.CheckBox1.Enabled = False
            Form2.Button3.Enabled = True
            Form2.ComboBox4.Text = Me.TextBox4.Text
            x = 1
            Form2.DateTimePicker2.Value = Me.TextBox3.Text
        End If

        Me.Hide()
        Form2.Show()


    End Sub

    Private Sub Tunnel_Enter(sender As Object, e As EventArgs) Handles Tunnel.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
