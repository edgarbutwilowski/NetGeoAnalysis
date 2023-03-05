using NetTopologySuite;
using NetTopologySuite.Features;
using NetTopologySuite.Geometries;

GeometryFactory geomFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 32632);

Feature feat1 = new Feature();
feat1.Geometry = geomFactory.CreatePoint(new Coordinate(586392.523, 5660511.220));

Feature feat2 = new Feature();
feat2.Geometry = geomFactory.CreatePoint(new Coordinate(588172.009, 5660172.609));

FeatureCollection featColl = new FeatureCollection();
featColl.Add(feat1);
featColl.Add(feat2);

Coordinate meanCenter = GeographicDistributions.meanCenter(featColl);

Console.WriteLine("meanCenter: " + meanCenter.X + " "+ meanCenter.Y);
