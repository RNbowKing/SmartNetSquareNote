﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SettingsTabControl = New System.Windows.Forms.TabControl()
        Me.GeneralTabPage = New System.Windows.Forms.TabPage()
        Me.TextFontAndColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.ChangeTextFontButton = New System.Windows.Forms.Button()
        Me.RestoreTextStyleLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ChangeTextColorButton = New System.Windows.Forms.Button()
        Me.NoteColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.RestoreDefaultNoteColorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ChangeNoteColorButton = New System.Windows.Forms.Button()
        Me.UpdatesTabPage = New System.Windows.Forms.TabPage()
        Me.VersionNumberGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdatesSearchButton = New System.Windows.Forms.Button()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.AutoUpdateGroupBox = New System.Windows.Forms.GroupBox()
        Me.AutoUpdateCheckBox = New System.Windows.Forms.CheckBox()
        Me.AdvancedTabPage = New System.Windows.Forms.TabPage()
        Me.SettingsRestoreGroupBox = New System.Windows.Forms.GroupBox()
        Me.RestorePreviousSettingsButton = New System.Windows.Forms.Button()
        Me.RestartWarningLabel = New System.Windows.Forms.Label()
        Me.NoteColorDialog = New System.Windows.Forms.ColorDialog()
        Me.TextColorDialog = New System.Windows.Forms.ColorDialog()
        Me.TextFontDialog = New System.Windows.Forms.FontDialog()
        Me.SettingsTabControl.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.TextFontAndColorGroupBox.SuspendLayout()
        Me.NoteColorGroupBox.SuspendLayout()
        Me.UpdatesTabPage.SuspendLayout()
        Me.VersionNumberGroupBox.SuspendLayout()
        Me.AutoUpdateGroupBox.SuspendLayout()
        Me.AdvancedTabPage.SuspendLayout()
        Me.SettingsRestoreGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OKButton
        '
        resources.ApplyResources(Me.OKButton, "OKButton")
        Me.OKButton.Name = "OKButton"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SettingsTabControl
        '
        resources.ApplyResources(Me.SettingsTabControl, "SettingsTabControl")
        Me.SettingsTabControl.Controls.Add(Me.GeneralTabPage)
        Me.SettingsTabControl.Controls.Add(Me.UpdatesTabPage)
        Me.SettingsTabControl.Controls.Add(Me.AdvancedTabPage)
        Me.SettingsTabControl.Name = "SettingsTabControl"
        Me.SettingsTabControl.SelectedIndex = 0
        '
        'GeneralTabPage
        '
        resources.ApplyResources(Me.GeneralTabPage, "GeneralTabPage")
        Me.GeneralTabPage.Controls.Add(Me.TextFontAndColorGroupBox)
        Me.GeneralTabPage.Controls.Add(Me.NoteColorGroupBox)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.UseVisualStyleBackColor = True
        '
        'TextFontAndColorGroupBox
        '
        resources.ApplyResources(Me.TextFontAndColorGroupBox, "TextFontAndColorGroupBox")
        Me.TextFontAndColorGroupBox.Controls.Add(Me.ChangeTextFontButton)
        Me.TextFontAndColorGroupBox.Controls.Add(Me.RestoreTextStyleLinkLabel)
        Me.TextFontAndColorGroupBox.Controls.Add(Me.ChangeTextColorButton)
        Me.TextFontAndColorGroupBox.Name = "TextFontAndColorGroupBox"
        Me.TextFontAndColorGroupBox.TabStop = False
        '
        'ChangeTextFontButton
        '
        resources.ApplyResources(Me.ChangeTextFontButton, "ChangeTextFontButton")
        Me.ChangeTextFontButton.Name = "ChangeTextFontButton"
        Me.ChangeTextFontButton.UseVisualStyleBackColor = True
        '
        'RestoreTextStyleLinkLabel
        '
        resources.ApplyResources(Me.RestoreTextStyleLinkLabel, "RestoreTextStyleLinkLabel")
        Me.RestoreTextStyleLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreTextStyleLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreTextStyleLinkLabel.Name = "RestoreTextStyleLinkLabel"
        Me.RestoreTextStyleLinkLabel.TabStop = True
        Me.RestoreTextStyleLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'ChangeTextColorButton
        '
        resources.ApplyResources(Me.ChangeTextColorButton, "ChangeTextColorButton")
        Me.ChangeTextColorButton.Name = "ChangeTextColorButton"
        Me.ChangeTextColorButton.UseVisualStyleBackColor = True
        '
        'NoteColorGroupBox
        '
        resources.ApplyResources(Me.NoteColorGroupBox, "NoteColorGroupBox")
        Me.NoteColorGroupBox.Controls.Add(Me.RestoreDefaultNoteColorLinkLabel)
        Me.NoteColorGroupBox.Controls.Add(Me.ChangeNoteColorButton)
        Me.NoteColorGroupBox.Name = "NoteColorGroupBox"
        Me.NoteColorGroupBox.TabStop = False
        '
        'RestoreDefaultNoteColorLinkLabel
        '
        resources.ApplyResources(Me.RestoreDefaultNoteColorLinkLabel, "RestoreDefaultNoteColorLinkLabel")
        Me.RestoreDefaultNoteColorLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreDefaultNoteColorLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreDefaultNoteColorLinkLabel.Name = "RestoreDefaultNoteColorLinkLabel"
        Me.RestoreDefaultNoteColorLinkLabel.TabStop = True
        Me.RestoreDefaultNoteColorLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'ChangeNoteColorButton
        '
        resources.ApplyResources(Me.ChangeNoteColorButton, "ChangeNoteColorButton")
        Me.ChangeNoteColorButton.Name = "ChangeNoteColorButton"
        Me.ChangeNoteColorButton.UseVisualStyleBackColor = True
        '
        'UpdatesTabPage
        '
        resources.ApplyResources(Me.UpdatesTabPage, "UpdatesTabPage")
        Me.UpdatesTabPage.Controls.Add(Me.VersionNumberGroupBox)
        Me.UpdatesTabPage.Controls.Add(Me.AutoUpdateGroupBox)
        Me.UpdatesTabPage.Name = "UpdatesTabPage"
        Me.UpdatesTabPage.UseVisualStyleBackColor = True
        '
        'VersionNumberGroupBox
        '
        resources.ApplyResources(Me.VersionNumberGroupBox, "VersionNumberGroupBox")
        Me.VersionNumberGroupBox.Controls.Add(Me.UpdatesSearchButton)
        Me.VersionNumberGroupBox.Controls.Add(Me.VersionLabel)
        Me.VersionNumberGroupBox.Name = "VersionNumberGroupBox"
        Me.VersionNumberGroupBox.TabStop = False
        '
        'UpdatesSearchButton
        '
        resources.ApplyResources(Me.UpdatesSearchButton, "UpdatesSearchButton")
        Me.UpdatesSearchButton.Name = "UpdatesSearchButton"
        Me.UpdatesSearchButton.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        resources.ApplyResources(Me.VersionLabel, "VersionLabel")
        Me.VersionLabel.Name = "VersionLabel"
        '
        'AutoUpdateGroupBox
        '
        resources.ApplyResources(Me.AutoUpdateGroupBox, "AutoUpdateGroupBox")
        Me.AutoUpdateGroupBox.Controls.Add(Me.AutoUpdateCheckBox)
        Me.AutoUpdateGroupBox.Name = "AutoUpdateGroupBox"
        Me.AutoUpdateGroupBox.TabStop = False
        '
        'AutoUpdateCheckBox
        '
        resources.ApplyResources(Me.AutoUpdateCheckBox, "AutoUpdateCheckBox")
        Me.AutoUpdateCheckBox.Name = "AutoUpdateCheckBox"
        Me.AutoUpdateCheckBox.UseVisualStyleBackColor = True
        '
        'AdvancedTabPage
        '
        resources.ApplyResources(Me.AdvancedTabPage, "AdvancedTabPage")
        Me.AdvancedTabPage.Controls.Add(Me.SettingsRestoreGroupBox)
        Me.AdvancedTabPage.Name = "AdvancedTabPage"
        Me.AdvancedTabPage.UseVisualStyleBackColor = True
        '
        'SettingsRestoreGroupBox
        '
        resources.ApplyResources(Me.SettingsRestoreGroupBox, "SettingsRestoreGroupBox")
        Me.SettingsRestoreGroupBox.Controls.Add(Me.RestorePreviousSettingsButton)
        Me.SettingsRestoreGroupBox.Name = "SettingsRestoreGroupBox"
        Me.SettingsRestoreGroupBox.TabStop = False
        '
        'RestorePreviousSettingsButton
        '
        resources.ApplyResources(Me.RestorePreviousSettingsButton, "RestorePreviousSettingsButton")
        Me.RestorePreviousSettingsButton.Name = "RestorePreviousSettingsButton"
        Me.RestorePreviousSettingsButton.UseVisualStyleBackColor = True
        '
        'RestartWarningLabel
        '
        resources.ApplyResources(Me.RestartWarningLabel, "RestartWarningLabel")
        Me.RestartWarningLabel.Name = "RestartWarningLabel"
        '
        'SettingsForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RestartWarningLabel)
        Me.Controls.Add(Me.SettingsTabControl)
        Me.Controls.Add(Me.OKButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.SettingsTabControl.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.TextFontAndColorGroupBox.ResumeLayout(False)
        Me.TextFontAndColorGroupBox.PerformLayout()
        Me.NoteColorGroupBox.ResumeLayout(False)
        Me.NoteColorGroupBox.PerformLayout()
        Me.UpdatesTabPage.ResumeLayout(False)
        Me.VersionNumberGroupBox.ResumeLayout(False)
        Me.VersionNumberGroupBox.PerformLayout()
        Me.AutoUpdateGroupBox.ResumeLayout(False)
        Me.AutoUpdateGroupBox.PerformLayout()
        Me.AdvancedTabPage.ResumeLayout(False)
        Me.SettingsRestoreGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OKButton As Button
    Friend WithEvents SettingsTabControl As TabControl
    Friend WithEvents GeneralTabPage As TabPage
    Friend WithEvents UpdatesTabPage As TabPage
    Friend WithEvents AdvancedTabPage As TabPage
    Friend WithEvents AutoUpdateGroupBox As GroupBox
    Friend WithEvents AutoUpdateCheckBox As CheckBox
    Friend WithEvents VersionNumberGroupBox As GroupBox
    Friend WithEvents UpdatesSearchButton As Button
    Friend WithEvents VersionLabel As Label
    Friend WithEvents TextFontAndColorGroupBox As GroupBox
    Friend WithEvents NoteColorGroupBox As GroupBox
    Friend WithEvents RestartWarningLabel As Label
    Friend WithEvents SettingsRestoreGroupBox As GroupBox
    Friend WithEvents RestorePreviousSettingsButton As Button
    Friend WithEvents RestoreDefaultNoteColorLinkLabel As LinkLabel
    Friend WithEvents ChangeNoteColorButton As Button
    Friend WithEvents NoteColorDialog As ColorDialog
    Friend WithEvents TextColorDialog As ColorDialog
    Friend WithEvents TextFontDialog As FontDialog
    Friend WithEvents ChangeTextFontButton As Button
    Friend WithEvents RestoreTextStyleLinkLabel As LinkLabel
    Friend WithEvents ChangeTextColorButton As Button
End Class
