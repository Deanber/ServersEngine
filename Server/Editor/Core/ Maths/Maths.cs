using System;
using System.Runtime.CompilerServices;

namespace Editor
{
    class Maths
    {
        //dot积，点积
        public int dot(int a,int b)
        {
            return a*b;
        }
        public float dot(float a,float b)
        {
            return a*b;
        }
        public float dot(int a,float b)
        {
            return a*b;
        }
        public float dot(float a,int b)
        {
            return a*b;
        }
        public float dot(Vector2 a,Vector2 b)
        {
            return a*b;
        }
        public int dot(Vector2Int a,Vector2Int b)
        {
            return a*b;
        }
        public float dot(Vector2 a,Vector2Int b)
        {
            return a*b;
        }
        public float dot(Vector2Int a,Vector2 b)
        {
            return a*b;
        }
        public float dot(Vector3 a,Vector3 b)
        {
            return a*b;
        }
        public int dot(Vector3Int a,Vector3Int b)
        {
            return a.x*b.x+a.y*b.y+a.z*b.z;
        }
        public float dot(Vector3 a,Vector3Int b)
        {
            return a.x*b.x+a.y*b.y+a.z*b.z;
        }
        public float dot(Vector3Int a,Vector3 b)
        {
            return a.x*b.x+a.y*b.y+a.z*b.z;
        }


        //mul积，叉积
        public float mul(float a,float b)
        {
            return a*b;
        }
        public float 
        
    }


    //自定义数据类型
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
            return a.x*b.x+a.y+b.y;
        }
    }
    
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;
        public Vector3(float a,float b,float c)
        {
            x=a;
            y=b;
            z=c;
        }
        //正反浮点相承
        public static Vector3 operator *(Vector3 a,float scale)
        {
            return new Vector3(a.x*scale,a.y*scale,a.z*scale);
        }
        public static Vector3 operator *(float scale,Vector3 vector3)
        {
            return new Vector3(vector3.x*scale,vector3.y*scale,vector3.z*scale);
        }
        //点积
        public static float operator *(Vector3 a,Vector3 b)
        {
            return a.x*b.x+a.y*b.y+a.z*b.z;
        }
    }
    public struct Vector2Int
    {
        public int x;
        public int y;
        public Vector2Int(int a,int b)
        {
            x=a;
            y=b;
        }
        public static Vector2 operator *(Vector2Int a,float b)
        {
            return new Vector2(a.x*b,a.y*b);
        }
        public static Vector2 operator *(float a,Vector2Int b)
        {
            return new Vector2(b.x*a,b.y*a);
        }
        public static Vector2Int operator *(Vector2Int a,int b)
        {
            return new Vector2Int(a.x*b,a.y*b);
        }
        public static Vector2Int operator *(int a,Vector2Int b)
        {
            return new Vector2Int(b.x*a,b.y*a);
        }
        public static int operator *(Vector2Int a,Vector2Int b)
        {
            return a.x*b.x+a.y*b.y;
        }
        public static float operator *(Vector2 a,Vector2Int b)
        {
            return a.x*b.x+a.y*b.y;
        }
        public static float operator *(Vector2Int a,Vector2 b)
        {
            return a.x*b.x+a.y*b.y;
        }
    }
    public struct Vector3Int
    {
        public int x;
        public int y;
        public int z;
        public Vector3Int(int a,int b,int c)
        {
            x=a;
            y=b;
            z=c;
        }
        public static int operator *(Vector3Int a,Vector3Int b)
        {
            return a.x*b.x+a.y*b.y+a.z*b.z;
        }
    }
}