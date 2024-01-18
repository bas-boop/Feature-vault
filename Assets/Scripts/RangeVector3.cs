using UnityEngine;

public sealed class RangeVector3 : RangeVector2
{
    public float MinZ { get; private set; }
    public float MaxZ { get; private set; }

    public RangeVector3(float minX, float maxX, float minY, float maxY, float minZ, float maxZ)
    {
        MinX = minX;
        MaxX = maxX;
        MinY = minY;
        MaxY = maxY;
        MinZ = minZ;
        MaxZ = maxZ;
    }
}

