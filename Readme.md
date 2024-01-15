<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T232940)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->

# How to specify a map projection

This example demonstrates how to specify a map projection that is used to display geographical data for a Map Control. 
## Files to Look at

* **[Form1.cs](./CS/MapProjections/Form1.cs) (VB: [Form1.vb](./VB/MapProjections/Form1.vb))**
<!-- default file list end -->

## Example Overview

To configure a map projection, specify the [GeoMapCoordinateSystem.Projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.GeoMapCoordinateSystem.Projection) property of the [GeoMapCoordinateSystem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.GeoMapCoordinateSystem) object, which should be assigned to the [MapControl.CoordinateSystem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapControl.CoordinateSystem).

One of the following predefined map projections can be used:
- [Braun stereographic projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.BraunStereographicProjection)
- [Elliptical Mercator projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.EllipticalMercatorProjection)
- [Equal-area projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.EqualAreaProjection)
- [Equidistant projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.EquidistantProjection)
- [Equirectangular projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.EquirectangularProjection)
- [Kavrayskiy projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.KavrayskiyProjection)
- [Lambert Cylindrical Equal-area projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.LambertCylindricalEqualAreaProjection)
- [Miller projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MillerProjection)
- [Sinusoidal projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.SinusoidalProjection)
- [Spherical Mercator projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.SphericalMercatorProjection)
- [ Lambert Azimuthal Equal-Area Projection](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.Etrs89LambertAzimuthalEqualAreaProjection)

## Documentation 

- [How to: Specify a Map Projection](https://docs.devexpress.com/WindowsForms/113973/controls-and-libraries/map-control/examples/vector-data/customize-data-appearance/how-to-specify-a-map-projection)
- [Geographical Projections](https://docs.devexpress.com/WindowsForms/15079/controls-and-libraries/map-control/coordinate-systems/geographical-projections)









