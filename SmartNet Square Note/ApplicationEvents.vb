﻿Imports System.Net
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' Les événements suivants sont disponibles pour MyApplication :
    ' Startup : déclenché au démarrage de l'application avant la création du formulaire de démarrage.
    ' Shutdown : déclenché après la fermeture de tous les formulaires de l'application. Cet événement n'est pas déclenché si l'application se termine de façon anormale.
    ' UnhandledException : déclenché si l'application rencontre une exception non gérée.
    ' StartupNextInstance : déclenché lors du lancement d'une application à instance unique et si cette application est déjà active. 
    ' NetworkAvailabilityChanged : déclenché lorsque la connexion réseau est connectée ou déconnectée.
    Partial Friend Class MyApplication
        Dim ApplicationNotifyIcon As New NotifyIcon
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            ApplicationNotifyIcon.Icon = NoteForm.NotifyIcon.Icon
            ApplicationNotifyIcon.Text = "SmartNet Square Note"
            'ApplicationNotifyIcon.ContextMenuStrip = NoteForm.ContextMenuStrip1
            ApplicationNotifyIcon.Visible = True

            Dim UpdateNotifyIcon As New NotifyIcon
            UpdateNotifyIcon.Icon = My.Resources.SmartNet_Apps_Updater
            UpdateNotifyIcon.Text = "Mise à jour pour SmartNet Square Note"
            UpdateNotifyIcon.BalloonTipTitle = "SmartNet Apps Updater"
            UpdateNotifyIcon.BalloonTipText = "Une mise à jour est disponible pour SmartNet Square Note."
            UpdateNotifyIcon.BalloonTipIcon = ToolTipIcon.Info

            '            Try
            '                Dim MiniNTVersionChecker As New WebClient
            '                Dim NTActualVersion As Version = Environment.OSVersion.Version
            '                Dim MiniNTVersion As Version = New Version(MiniNTVersionChecker.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/squarenote/windows/MinimumNTVersion.txt"))
            '                Dim MAJ As New WebClient
            '                Dim VersionActuelle As Version = My.Application.Info.Version
            '                Dim DerniereVersion As Version = New Version(MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/squarenote/windows/version.txt"))
            '                Dim SupportStatus As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/squarenote/windows/support-status.txt")
            '                If VersionActuelle > DerniereVersion Then
            '                    MsgBox("Vous utilisez une version de SmartNet Square Note qui n'a pas encore été publiée. Merci de ne pas signaler d'erreurs ou de beugs tant que cette version n'aura pas été publiée.", MsgBoxStyle.Exclamation, "Version non publiée")
            '                End If
            '                If My.Settings.AutoUpdates = True Then
            '                    If NTActualVersion < MiniNTVersion Then
            '                        MsgBox("Votre système d'exploitation n'est plus pris en charge par SmartNet Apps. Visitez le site SmartNet Apps pour en savoir plus à ce sujet. La recherche automatique de mises à jour à été désactivée.", MsgBoxStyle.Exclamation, "Avertissement")
            '                        My.Settings.AutoUpdates = False
            '                        My.Settings.Save()
            '                        My.Settings.UpdateAvailable = False
            '                        NoteForm.NouvelleVersionDisponibleToolStripMenuItem.Visible = False
            '                        NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = False
            '                        GoTo StopVersionChecking
            '                    End If
            '                    If SupportStatus = "on" Then
            '                        If VersionActuelle < DerniereVersion Then
            '                            FormUpdater.Show()
            '                            My.Settings.UpdateAvailable = True
            '                            NoteForm.NouvelleVersionDisponibleToolStripMenuItem.Visible = True
            '                            NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = True
            '                            NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Text = "Télécharger la version " + DerniereVersion.ToString
            '                        Else
            '                            My.Settings.UpdateAvailable = False
            '                            NoteForm.NouvelleVersionDisponibleToolStripMenuItem.Visible = False
            '                            NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = False
            '                            GoTo StopVersionChecking
            '                        End If
            '                    Else
            '                        My.Settings.UpdateAvailable = False
            '                        NoteForm.NouvelleVersionDisponibleToolStripMenuItem.Visible = False
            '                        NoteForm.TéléchargerLaMiseÀJourToolStripMenuItem.Visible = False
            '                        MsgBox("Le support et le développement de ce produit ont été interrompus. Visitez le site SmartNet Apps pour en savoir plus.", MsgBoxStyle.Critical, "Service interrompu")
            '                        GoTo StopVersionChecking
            '                    End If
            '                End If
            'StopVersionChecking:
            '            Catch ex As Exception
            '                MsgBox("La connexion à SmartNet Apps Updater a échoué : " + ex.Message, MsgBoxStyle.Critical, "SmartNet Apps Updater")
            '            End Try
            Dim agent As New UpdateAgent
            If agent.IsUpdateAvailable(False) Then
                UpdateNotifyIcon.Visible = True
                UpdateNotifyIcon.ShowBalloonTip(8000)
            End If
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            ApplicationNotifyIcon.Visible = False
        End Sub
    End Class
End Namespace
