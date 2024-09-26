
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
        public float dot(Vector3 a,Vector3 b)
        {
            return a*b;
        }
        public int dot(Vector3Int a,Vector3Int b)
        {
            return a.x*b.x+a.y*b.y+a.z*b.z;
        }


        //mul积，叉积
        public float mul(float a,float b)
        {
            return a*b;
        }
        public float mul(int a,int b)
        {
            return a*b;
        }
        public Vector3 mul(Vector2 a,Vector2 b)
        {
            return new Vector3(0,0,a.x*b.y-b.x*a.y);
        }
        public Vector3 mul(Vector3 a,Vector3 b)
        {
            return new Vector3(a.y*b.z-a.z*b.y,a.z*b.x-a.x*b.z,a.x*b.y-a.y*b.x);
        }
        
    }
}