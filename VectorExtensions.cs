using UnityEngine;

public static class VectorExtensions
{
    // Vector2のXだけを変更
    public static Vector2 WithVec2X(this Vector2 v, float x)
    {
        v.x = x;
        return v;
    }

    // Vector2のYだけを変更
    public static Vector2 WithVec2Y(this Vector2 v, float y)
    {
        v.y = y;
        return v;
    }

    // Vector3のXだけを変更
    public static Vector3 WithVec3X(this Vector3 v, float x)
    {
        v.x = x;
        return v;
    }

    // Vector3のYだけを変更
    public static Vector3 WithVec3Y(this Vector3 v, float y)
    {
        v.y = y;
        return v;
    }

    // Vector3のZだけを変更
    public static Vector3 WithVec3Z(this Vector3 v, float z)
    {
        v.z = z;
        return v;
    }
}
