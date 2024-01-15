Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace MapProjections

    Public Partial Class Form1
        Inherits Form

        Const filepath As String = "..\..\Data\Countries.shp"

        Private mapProjections As List(Of ProjectionBase) = New List(Of ProjectionBase)() From {New BraunStereographicProjection(), New EllipticalMercatorProjection(), New EqualAreaProjection(), New EquidistantProjection(), New EquirectangularProjection(), New KavrayskiyProjection(), New LambertCylindricalEqualAreaProjection(), New MillerProjection(), New SinusoidalProjection(), New SphericalMercatorProjection(), New Etrs89LambertAzimuthalEqualAreaProjection()}

        Private ReadOnly Property CoordinateSystem As GeoMapCoordinateSystem
            Get
                Return TryCast(mapControl.CoordinateSystem, GeoMapCoordinateSystem)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            lbProjection.DataSource = mapProjections
            lbProjection.SetSelected(0, True)
            Dim baseUri As Uri = New Uri(Reflection.Assembly.GetEntryAssembly().Location)
            Dim uri As Uri = New Uri(baseUri, MapProjections.Form1.filepath)
            mapControl.Layers.Add(New VectorItemsLayer() With {.Data = New ShapefileDataAdapter() With {.FileUri = uri}})
        End Sub

        Private Sub lbProjection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            CoordinateSystem.Projection = TryCast(lbProjection.SelectedValue, ProjectionBase)
        End Sub
    End Class
End Namespace
