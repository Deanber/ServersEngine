using System;

namespace Editor
{
    public struct Vector2
    {
        public float x;
        public float y;
        public float Length{get{return GetLength(this);}}
        public Vector2 normalize{get{return Normalize(this);}}

        public Vector2(float a=0,float b=0)
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
        public static Vector2 operator +(Vector2 a,Vector2 b)
        {
            return new Vector2(a.x+b.x,a.y+b.y);
        }
        public static Vector2 operator -(Vector2 a,Vector2 b)
        {
            return new Vector2(a.x-b.x,a.y-b.y);
        }
        public static Vector2 operator /(Vector2 a,float b)
        {
            return new Vector2(a.x/b,a.y/b);
        }
        public float GetLength(Vector2 a)
        {
            return (float)Math.Sqrt(a.x*a.x+a.y*a.y);
        }
        public Vector2 Normalize(Vector2 a)
        {
            float length=this.Length;
            if(length==0)
                throw new DivideByZeroException("不能归一化零向量");
            return new Vector2(a.x/length,a.y/length);
        }
    }
    
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;
        public float Length;
        public Vector3 normalize{get{return Normalize();}}
        public Vector3(float a=0,float b=0,float c=0)
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
        public static Vector3 operator +(Vector3 a,Vector3 b)
        {
            return new Vector3(a.x+b.x,a.y+b.y,a.z+b.z);
        }
        public static Vector3 operator -(Vector3 a,Vector3 b)
        {
            return new Vector3(a.x-b.x,a.y-b.y,a.z-b.z);
        }
        public static Vector3 operator /(Vector3 a,float b)
        {
            return new Vector3(a.x/b,a.y/b,a.z/b);
        }
        //长度
        public float GetLength()
        {
            return (float)Math.Sqrt(this.x*this.x+this.y*this.y+this.z*this.z);
        }
        //归一化
        public Vector3 Normalize()
        {
            float m=this.Length;
            if(m==0)
            {
                throw new DivideByZeroException("不能归一化该零向量");
            }
            return new Vector3(this.x/m,this.y/m,this.z/m);
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
        public static Vector3Int operator *(int a,Vector3Int b)
        {
            return new Vector3Int(b.x*a,b.y*a,b.z*a);
        }
        public static Vector3Int operator *(Vector3Int a,int b)
        {
            return new Vector3Int(a.x*b,a.y*b,a.z*b);
        }
        public static Vector3 operator *(float a,Vector3Int b)
        {
            return new Vector3(b.x*a,b.y*a,b.z*a);
        }
        public static Vector3 operator *(Vector3Int a,float b)
        {
            return new Vector3(a.x*b,a.y*b,a.z*b);
        }
    }
}