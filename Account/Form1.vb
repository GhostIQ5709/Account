Imports System.Runtime.InteropServices

Public Class Form1
    ' Import the SystemParametersInfo function from user32.dll
    <DllImport("user32.dll")>
    Private Shared Function SystemParametersInfo(uAction As Integer, uParam As Integer, lpvParam As String, fuWinIni As Integer) As Integer
    End Function

    ' Define constants for the wallpaper change
    Private Const SPI_SETDESKWALLPAPER As Integer = 20
    Private Const SPIF_UPDATEINIFILE As Integer = &H1
    Private Const SPIF_SENDCHANGE As Integer = &H2

    ' Load event to populate the ComboBox with wallpaper paths
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbWallpapers.Items.Add("C:\Users\USER\OneDrive\Desktop\All Folders\PCvibe\abstract_3d_art_85489_1920x1080.jpg")
        cmbWallpapers.Items.Add("C:\Users\USER\OneDrive\Desktop\All Folders\PCvibe\ball_glass_surface_background_69145_1920x1080.jpg")
        cmbWallpapers.Items.Add("C:\Users\USER\OneDrive\Desktop\All Folders\PCvibe\black_dark_fractal_149686_1920x1080.jpg")
        cmbWallpapers.Items.Add("C:\Users\USER\OneDrive\Desktop\All Folders\PCvibe\bmw_headlights_lights_137326_2560x1600.jpg")
        cmbWallpapers.Items.Add("C:\Users\USER\OneDrive\Desktop\All Folders\PCvibe\car_gray_wet_147750_1920x1200.jpg")
        cmbWallpapers.Items.Add("C:\Users\USER\OneDrive\Desktop\All Folders\PCvibe\squares_background_shadow_83510_1920x1080.jpg")
        cmbWallpapers.Items.Add("C:\Users\USER\OneDrive\Desktop\All Folders\PCvibe\spots_background_line_abstraction_66994_1920x1080.jpg")
        cmbWallpapers.Items.Add("C:\Users\USER\OneDrive\Desktop\All Folders\PCvibe\planets_space_wind_space_99820_1920x1080.jpg")
        cmbWallpapers.Items.Add("C:\Users\USER\OneDrive\Desktop\All Folders\PCvibe\liquid_light_shadow_colored_splash_28168_1920x1080.jpg")
    End Sub

    ' Button click event to change the wallpaper
    Private Sub btnChangeWallpaper_Click(sender As Object, e As EventArgs) Handles btnChangeWallpaper.Click
        If cmbWallpapers.SelectedItem IsNot Nothing Then
            Dim wallpaperPath As String = cmbWallpapers.SelectedItem.ToString()
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, wallpaperPath, SPIF_UPDATEINIFILE Or SPIF_SENDCHANGE)
            lblCurrentWallpaper.Text = "Current Wallpaper: " & wallpaperPath
        Else
            MessageBox.Show("Please select a wallpaper.")
        End If
    End Sub

    Private Sub cmbWallpapers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWallpapers.SelectedIndexChanged

    End Sub
End Class
