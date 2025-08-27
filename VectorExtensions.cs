using UnityEngine;

public static class VectorExtensions
{
    // Vector2��X������ύX
    public static Vector2 WithVec2X(this Vector2 v, float x)
    {
        v.x = x;
        return v;
    }

    // Vector2��Y������ύX
    public static Vector2 WithVec2Y(this Vector2 v, float y)
    {
        v.y = y;
        return v;
    }

    // Vector3��X������ύX
    public static Vector3 WithVec3X(this Vector3 v, float x)
    {
        v.x = x;
        return v;
    }

    // Vector3��Y������ύX
    public static Vector3 WithVec3Y(this Vector3 v, float y)
    {
        v.y = y;
        return v;
    }

    // Vector3��Z������ύX
    public static Vector3 WithVec3Z(this Vector3 v, float z)
    {
        v.z = z;
        return v;
    }
}
