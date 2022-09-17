' Developer Express Code Central Example:
' How to customize header and content elements of the DockPanel in the DockManager (creating a custom theme)
' 
' It's necessary to respecify templates corresponding to the defined resource
' keys. The DockPanel Header and Content are placed in the
' DockPaneElementsThemeKey. The resource keys for the Header and the Content and
' Header and Content keys respectively. These are the keys you should
' respecify:
' 
' <DataTemplate x:Key="{dxt:DockPaneElementsThemeKey
' ResourceKey=Header}">
' <DataTemplate x:Key="{dxt:DockPaneElementsThemeKey
' ResourceKey=ContentHostTemplate}">
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1918
Imports System.Windows

Namespace CustomTheme

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class
End Namespace
