Imports System.Windows

Namespace DXDocumentUIServiceSample
	Partial Public Class App
		Inherits Application

		Private Sub OnAppStartup_UpdateThemeName(ByVal sender As Object, ByVal e As StartupEventArgs)
			DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName()
		End Sub
	End Class
End Namespace
