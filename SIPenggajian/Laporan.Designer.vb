﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LapPenggajian1 = New SIP.LapPenggajian()
        Me.LaporanUser1 = New SIP.LaporanUser()
        Me.Laporan_Jabatan1 = New SIP.Laporan_Jabatan()
        Me.LaporanPegawai1 = New SIP.LaporanPegawai()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.LapPenggajian1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(822, 408)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'LapPenggajian1
        '
        '
        'LaporanPegawai1
        '
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 408)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LaporanPegawai1 As SIP.LaporanPegawai
    Friend WithEvents Laporan_Jabatan1 As SIP.Laporan_Jabatan
    Friend WithEvents LapPenggajian1 As SIP.LapPenggajian
    Friend WithEvents LaporanUser1 As SIP.LaporanUser
End Class
