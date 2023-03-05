using NetTopologySuite.Features;
using NetTopologySuite.Geometries;

public class GeographicDistributions
{
    public static Coordinate meanCenter(FeatureCollection featureCollection)
    {
        double sumOfX = 0;
        double sumOfY = 0;
        int featCount = 0;

        foreach (Feature feat in featureCollection)
        {
            if (feat.Geometry is Point)
            {
                Point? p = feat.Geometry as Point;
                if (p != null)
                {
                    featCount++;
                    sumOfX += p.X;
                    sumOfY += p.Y;
                }
            }
        }

        if(featCount != 0)
        {
            double meanX = sumOfX / featCount;
            double meanY = sumOfY / featCount;
            Coordinate meanCenter = new Coordinate(meanX, meanY);
            return meanCenter;
        }
        else
        {
            throw new ArgumentException("Cannot calculate mean of empty feature set");
        }

    }
}