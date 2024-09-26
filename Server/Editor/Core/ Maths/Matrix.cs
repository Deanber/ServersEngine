using System.Dynamic;

namespace Editor
{
    public struct Matrix3x3
    {
        public float M11, M12, M13;
        public float M21, M22, M23;
        public float M31, M32, M33;
        float[,] array { get { return MatrixArray(this); } }
        public float[,] MatrixArray(Matrix3x3 a)
        {
            return new float[3, 3]{
                {a.M11,a.M12,a.M13},
                {a.M21,a.M22,a.M23},
                {a.M31,a.M32,a.M33}
            };
        }
        public Matrix3x3 GetMatrix(float[,] ary)
        {
            return new Matrix3x3
            {
                M11 = ary[0, 0],
                M12 = ary[0, 1],
                M13 = ary[0, 2],
                M21 = ary[1, 0],
                M22 = ary[1, 1],
                M23 = ary[1, 2],
                M31 = ary[2, 0],
                M32 = ary[2, 1],
                M33 = ary[2, 2]
            };
        }
        public Matrix3x3 Identity { get { return new Matrix3x3(1, 0, 0, 0, 1, 0, 0, 0, 1); } }
        //初始化
        public Matrix3x3
        (float m11 = 0, float m12 = 0, float m13 = 0,
         float m21 = 0, float m22 = 0, float m23 = 0,
         float m31 = 0, float m32 = 0, float m33 = 0)
        {
            M11 = m11; M12 = m12; M13 = m13;
            M21 = m21; M22 = m22; M23 = m23;
            M31 = m31; M32 = m32; M33 = m33;
        }
        //加法运算
        public static Matrix3x3 operator +(Matrix3x3 a, Matrix3x3 b)
        {
            float[,] array1 = a.array;
            float[,] array2 = b.array;
            return new Matrix3x3
            {
                M11 = a.M11 + b.M11,
                M12 = a.M12 + b.M12,
                M13 = a.M13 + b.M13,
                M21 = a.M21 + b.M21,
                M22 = a.M22 + b.M22,
                M23 = a.M23 + b.M23,
                M31 = a.M31 + b.M31,
                M32 = a.M32 + b.M32,
                M33 = a.M33 + b.M33
            };

        }
        //减法运算
        public static Matrix3x3 operator -(Matrix3x3 a, Matrix3x3 b)
        {
            return new Matrix3x3
            {
                M11 = a.M11 - b.M11,
                M12 = a.M12 - b.M12,
                M13 = a.M13 - b.M13,
                M21 = a.M21 - b.M21,
                M22 = a.M22 - b.M22,
                M23 = a.M23 - b.M23,
                M31 = a.M31 - b.M31,
                M32 = a.M32 - b.M32,
                M33 = a.M33 - b.M33
            };
        }
        //乘法运算
        public static Matrix3x3 operator *(Matrix3x3 a, Matrix3x3 b)
        {
            float[,] EndMatrix = new float[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            Matrix3x3 m3 = new Matrix3x3();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int m = 0; m < 3; m++)
                    {
                        EndMatrix[i, j] += a.array[i, m] * b.array[m, j];
                    }
                }
            }
            return m3.GetMatrix(EndMatrix);
        }
    }
}