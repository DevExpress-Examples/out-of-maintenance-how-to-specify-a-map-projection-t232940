<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T232940)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/MapProjections/Form1.cs) (VB: [Form1.vb](./VB/MapProjections/Form1.vb))**
<!-- default file list end -->
# How to specify a map projection


<p>This example demonstrates how to specify a map projection that is used to display geographical data for a Map Control.<br />One of the following predefined map projections can be used:</p>
- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapBraunStereographicProjectiontopic">Braun stereographic projection</a>;<br />- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapEllipticalMercatorProjectiontopic">Elliptical Mercator projection</a>;<br />- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapEqualAreaProjectiontopic">Equal-area projection</a>;<br />- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapEquidistantProjectiontopic">Equidistant projection</a>;<br />- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapEquirectangularProjectiontopic">Equirectangular projection</a>;<br />- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapKavrayskiyProjectiontopic">Kavrayskiy projection</a>;<br />- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapLambertCylindricalEqualAreaProjectiontopic">Lambert Cylindrical Equal-area projection</a>;<br />- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapMillerProjectiontopic">Miller projection</a>;<br />- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapSinusoidalProjectiontopic">Sinusoidal projection</a>;<br />- <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapSphericalMercatorProjectiontopic">Spherical Mercator projection</a>.


<h3>Description</h3>

To configure a map projection, specify the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoMapCoordinateSystem_Projectiontopic">GeoMapCoordinateSystem.Projection</a>&nbsp;property of the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapGeoMapCoordinateSystemtopic">GeoMapCoordinateSystem</a>&nbsp;object, which&nbsp;should be assigned to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_CoordinateSystemtopic">MapControl.CoordinateSystem</a>&nbsp;property.

<br/>


