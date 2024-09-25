using System;

namespace Editor
{
    class Maths
    {

    }
    public struct Vector2
    {
        public float x;
        public float y;
        public Vector2(float a,float b)
        {
            x=a;
            y=b;
        }
        public static Vector2 operator *(Vector2 vector2,float scale)
        {
            return new Vector2(vector2.x*scale,vector2.y*scale);
        }
        public static Vector2 operator *(float scale,Vector2 vector2)
        {
            return new Vector2(vector2.x*scale,vector2.y*scale);
        }
        public static float operator *(Vector2 a,Vector2 b)
        {
            float c=a.x*b.x+a.y+b.y;
            return c;
        }
    }
    
    struct Vector3
    {
        public float A;
        public float B;
        public float C;
        public Vector3(float a,float b,float c)
        {
            A=a;
            B=b;
            C=c;
        }
    }
    struct VectorInt2
    {
        public int A;
        public int B;
        public VectorInt2(int a,int b)
        {
            A=a;
            B=b;
        }
    }
    struct VectorInt3
    {
        public int A;
        public int B;
        public int C;
        public VectorInt3(int a,int b,int c)
        {
            A=a;
            B=b;
            C=c;
        }
    }
}