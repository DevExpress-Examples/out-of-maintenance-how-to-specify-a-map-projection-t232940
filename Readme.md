<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576801/15.1.3%2B)
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

To configure a map projection, specify the [GeoMapCoordinateSystem.Projection](xref:DevExpress.XtraMap.GeoMapCoordinateSystem.Projection) property of the [GeoMapCoordinateSystem](xref:DevExpress.XtraMap.GeoMapCoordinateSystem) object, which should be assigned to the [MapControl.CoordinateSystem](xref:DevExpress.XtraMap.MapControl.CoordinateSystem).

One of the following predefined map projections can be used:
- [Braun stereographic projection](xref:DevExpress.XtraMap.BraunStereographicProjection)
- [Elliptical Mercator projection](xref:DevExpress.XtraMap.EllipticalMercatorProjection)
- [Equal-area projection](xref:DevExpress.XtraMap.EqualAreaProjection)
- [Equidistant projection](xref:DevExpress.XtraMap.EquidistantProjection)
- [Equirectangular projection](xref:DevExpress.XtraMap.EquirectangularProjection)
- [Kavrayskiy projection](xref:DevExpress.XtraMap.KavrayskiyProjection)
- [Lambert Cylindrical Equal-area projection](xref:DevExpress.XtraMap.LambertCylindricalEqualAreaProjection)
- [Miller projection](xref:DevExpress.XtraMap.MillerProjection)
- [Sinusoidal projection](xref:DevExpress.XtraMap.SinusoidalProjection)
- [Spherical Mercator projection](xref:DevExpress.XtraMap.SphericalMercatorProjection)
- [ Lambert Azimuthal Equal-Area Projection](xref:DevExpress.XtraMap.Etrs89LambertAzimuthalEqualAreaProjection)

## Documentation 

- [How to: Specify a Map Projection](xref:113973)
- [Geographical Projections](xref:15079)









