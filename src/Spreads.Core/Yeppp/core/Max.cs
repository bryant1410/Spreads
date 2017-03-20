// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Runtime.InteropServices;

namespace Spreads.Yeppp
{
    /// <summary>Basic arithmetic operations</summary>
    public partial class Core
    {
        /// <summary>Computes the maximum of signed 8-bit integer array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe sbyte Max_V8s_S8s(sbyte[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (sbyte* v = &vArray[vOffset])
            {
                return Max_V8s_S8s(v, length);
            }
        }

        /// <summary>Computes the maximum of unsigned 8-bit integer array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe byte Max_V8u_S8u(byte[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (byte* v = &vArray[vOffset])
            {
                return Max_V8u_S8u(v, length);
            }
        }

        /// <summary>Computes the maximum of signed 16-bit integer array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe short Max_V16s_S16s(short[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (short* v = &vArray[vOffset])
            {
                return Max_V16s_S16s(v, length);
            }
        }

        /// <summary>Computes the maximum of unsigned 16-bit integer array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe ushort Max_V16u_S16u(ushort[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ushort* v = &vArray[vOffset])
            {
                return Max_V16u_S16u(v, length);
            }
        }

        /// <summary>Computes the maximum of signed 32-bit integer array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe int Max_V32s_S32s(int[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (int* v = &vArray[vOffset])
            {
                return Max_V32s_S32s(v, length);
            }
        }

        /// <summary>Computes the maximum of unsigned 32-bit integer array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe uint Max_V32u_S32u(uint[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (uint* v = &vArray[vOffset])
            {
                return Max_V32u_S32u(v, length);
            }
        }

        /// <summary>Computes the maximum of signed 64-bit integer array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe long Max_V64s_S64s(long[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (long* v = &vArray[vOffset])
            {
                return Max_V64s_S64s(v, length);
            }
        }

        /// <summary>Computes the maximum of unsigned 64-bit integer array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe ulong Max_V64u_S64u(ulong[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ulong* v = &vArray[vOffset])
            {
                return Max_V64u_S64u(v, length);
            }
        }

        /// <summary>Computes the maximum of single precision (32-bit) floating-point array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe float Max_V32f_S32f(float[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (float* v = &vArray[vOffset])
            {
                return Max_V32f_S32f(v, length);
            }
        }

        /// <summary>Computes the maximum of double precision (64-bit) floating-point array elements.</summary>
        /// <exception cref="System.NullReferenceException">If vArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If vArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If vOffset is negative, vOffset + length exceeds the length of vArray, or length is negative.</exception>
        public static unsafe double Max_V64f_S64f(double[] vArray, int vOffset, int length)
        {
            if (vOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (vOffset + length > vArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (double* v = &vArray[vOffset])
            {
                return Max_V64f_S64f(v, length);
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 8-bit integer arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V8sV8s_V8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, sbyte[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (sbyte* x = &xArray[xOffset])
            {
                fixed (sbyte* y = &yArray[yOffset])
                {
                    fixed (sbyte* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V8sV8s_V8s(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 8-bit integer arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V8uV8u_V8u(byte[] xArray, int xOffset, byte[] yArray, int yOffset, byte[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (byte* x = &xArray[xOffset])
            {
                fixed (byte* y = &yArray[yOffset])
                {
                    fixed (byte* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V8uV8u_V8u(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 16-bit integer arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray, yArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V16sV16s_V16s(short[] xArray, int xOffset, short[] yArray, int yOffset, short[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (short* x = &xArray[xOffset])
            {
                fixed (short* y = &yArray[yOffset])
                {
                    fixed (short* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V16sV16s_V16s(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 16-bit integer arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray, yArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V16uV16u_V16u(ushort[] xArray, int xOffset, ushort[] yArray, int yOffset, ushort[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ushort* x = &xArray[xOffset])
            {
                fixed (ushort* y = &yArray[yOffset])
                {
                    fixed (ushort* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V16uV16u_V16u(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 32-bit integer arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray, yArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V32sV32s_V32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (int* x = &xArray[xOffset])
            {
                fixed (int* y = &yArray[yOffset])
                {
                    fixed (int* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V32sV32s_V32s(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 32-bit integer arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray, yArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V32uV32u_V32u(uint[] xArray, int xOffset, uint[] yArray, int yOffset, uint[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (uint* x = &xArray[xOffset])
            {
                fixed (uint* y = &yArray[yOffset])
                {
                    fixed (uint* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V32uV32u_V32u(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 64-bit integer arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray, yArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V64sV32s_V64s(long[] xArray, int xOffset, int[] yArray, int yOffset, long[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (long* x = &xArray[xOffset])
            {
                fixed (int* y = &yArray[yOffset])
                {
                    fixed (long* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V64sV32s_V64s(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 64-bit integer arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray, yArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V64uV32u_V64u(ulong[] xArray, int xOffset, uint[] yArray, int yOffset, ulong[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ulong* x = &xArray[xOffset])
            {
                fixed (uint* y = &yArray[yOffset])
                {
                    fixed (ulong* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V64uV32u_V64u(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two single precision (32-bit) floating-point arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray, yArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V32fV32f_V32f(float[] xArray, int xOffset, float[] yArray, int yOffset, float[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (float* x = &xArray[xOffset])
            {
                fixed (float* y = &yArray[yOffset])
                {
                    fixed (float* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V32fV32f_V32f(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two double precision (64-bit) floating-point arrays.</summary>
        /// <exception cref="System.NullReferenceException">If xArray, yArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray, yArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V64fV64f_V64f(double[] xArray, int xOffset, double[] yArray, int yOffset, double[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (double* x = &xArray[xOffset])
            {
                fixed (double* y = &yArray[yOffset])
                {
                    fixed (double* maximum = &maximumArray[maximumOffset])
                    {
                        Max_V64fV64f_V64f(x, y, maximum, length);
                    }
                }
            }
        }

        /// <summary>Computes pairwise maxima of signed 8-bit integer array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V8sS8s_V8s(sbyte[] xArray, int xOffset, sbyte y, sbyte[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (sbyte* x = &xArray[xOffset])
            {
                fixed (sbyte* maximum = &maximumArray[maximumOffset])
                {
                    Max_V8sS8s_V8s(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of unsigned 8-bit integer array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V8uS8u_V8u(byte[] xArray, int xOffset, byte y, byte[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (byte* x = &xArray[xOffset])
            {
                fixed (byte* maximum = &maximumArray[maximumOffset])
                {
                    Max_V8uS8u_V8u(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of signed 16-bit integer array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V16sS16s_V16s(short[] xArray, int xOffset, short y, short[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (short* x = &xArray[xOffset])
            {
                fixed (short* maximum = &maximumArray[maximumOffset])
                {
                    Max_V16sS16s_V16s(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of unsigned 16-bit integer array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V16uS16u_V16u(ushort[] xArray, int xOffset, ushort y, ushort[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ushort* x = &xArray[xOffset])
            {
                fixed (ushort* maximum = &maximumArray[maximumOffset])
                {
                    Max_V16uS16u_V16u(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of signed 32-bit integer array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V32sS32s_V32s(int[] xArray, int xOffset, int y, int[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (int* x = &xArray[xOffset])
            {
                fixed (int* maximum = &maximumArray[maximumOffset])
                {
                    Max_V32sS32s_V32s(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of unsigned 32-bit integer array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V32uS32u_V32u(uint[] xArray, int xOffset, uint y, uint[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (uint* x = &xArray[xOffset])
            {
                fixed (uint* maximum = &maximumArray[maximumOffset])
                {
                    Max_V32uS32u_V32u(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of signed 64-bit integer array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V64sS32s_V64s(long[] xArray, int xOffset, int y, long[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (long* x = &xArray[xOffset])
            {
                fixed (long* maximum = &maximumArray[maximumOffset])
                {
                    Max_V64sS32s_V64s(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of unsigned 64-bit integer array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V64uS32u_V64u(ulong[] xArray, int xOffset, uint y, ulong[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ulong* x = &xArray[xOffset])
            {
                fixed (ulong* maximum = &maximumArray[maximumOffset])
                {
                    Max_V64uS32u_V64u(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of single precision (32-bit) floating-point array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V32fS32f_V32f(float[] xArray, int xOffset, float y, float[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (float* x = &xArray[xOffset])
            {
                fixed (float* maximum = &maximumArray[maximumOffset])
                {
                    Max_V32fS32f_V32f(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of double precision (64-bit) floating-point array elements and a constant.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or maximumArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or maximumArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, maximumOffset is negative, maximumOffset + length exceeds the length of maximumArray, or length is negative.</exception>
        public static unsafe void Max_V64fS64f_V64f(double[] xArray, int xOffset, double y, double[] maximumArray, int maximumOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (maximumOffset + length > maximumArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (double* x = &xArray[xOffset])
            {
                fixed (double* maximum = &maximumArray[maximumOffset])
                {
                    Max_V64fS64f_V64f(x, y, maximum, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV8sV8s_IV8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (sbyte* x = &xArray[xOffset])
            {
                fixed (sbyte* y = &yArray[yOffset])
                {
                    Max_IV8sV8s_IV8s(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 8-bit integer arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV8uV8u_IV8u(byte[] xArray, int xOffset, byte[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (byte* x = &xArray[xOffset])
            {
                fixed (byte* y = &yArray[yOffset])
                {
                    Max_IV8uV8u_IV8u(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV16sV16s_IV16s(short[] xArray, int xOffset, short[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (short* x = &xArray[xOffset])
            {
                fixed (short* y = &yArray[yOffset])
                {
                    Max_IV16sV16s_IV16s(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 16-bit integer arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV16uV16u_IV16u(ushort[] xArray, int xOffset, ushort[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ushort* x = &xArray[xOffset])
            {
                fixed (ushort* y = &yArray[yOffset])
                {
                    Max_IV16uV16u_IV16u(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV32sV32s_IV32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (int* x = &xArray[xOffset])
            {
                fixed (int* y = &yArray[yOffset])
                {
                    Max_IV32sV32s_IV32s(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 32-bit integer arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV32uV32u_IV32u(uint[] xArray, int xOffset, uint[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (uint* x = &xArray[xOffset])
            {
                fixed (uint* y = &yArray[yOffset])
                {
                    Max_IV32uV32u_IV32u(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV64sV32s_IV64s(long[] xArray, int xOffset, int[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (long* x = &xArray[xOffset])
            {
                fixed (int* y = &yArray[yOffset])
                {
                    Max_IV64sV32s_IV64s(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 64-bit integer arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV64uV32u_IV64u(ulong[] xArray, int xOffset, uint[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ulong* x = &xArray[xOffset])
            {
                fixed (uint* y = &yArray[yOffset])
                {
                    Max_IV64uV32u_IV64u(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV32fV32f_IV32f(float[] xArray, int xOffset, float[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (float* x = &xArray[xOffset])
            {
                fixed (float* y = &yArray[yOffset])
                {
                    Max_IV32fV32f_IV32f(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
        public static unsafe void Max_IV64fV64f_IV64f(double[] xArray, int xOffset, double[] yArray, int yOffset, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (yOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (yOffset + length > yArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (double* x = &xArray[xOffset])
            {
                fixed (double* y = &yArray[yOffset])
                {
                    Max_IV64fV64f_IV64f(x, y, length);
                }
            }
        }

        /// <summary>Computes pairwise maxima of signed 8-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV8sS8s_IV8s(sbyte[] xArray, int xOffset, sbyte y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (sbyte* x = &xArray[xOffset])
            {
                Max_IV8sS8s_IV8s(x, y, length);
            }
        }

        /// <summary>Computes pairwise maxima of unsigned 8-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV8uS8u_IV8u(byte[] xArray, int xOffset, byte y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (byte* x = &xArray[xOffset])
            {
                Max_IV8uS8u_IV8u(x, y, length);
            }
        }

        /// <summary>Computes pairwise maxima of signed 16-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV16sS16s_IV16s(short[] xArray, int xOffset, short y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (short* x = &xArray[xOffset])
            {
                Max_IV16sS16s_IV16s(x, y, length);
            }
        }

        /// <summary>Computes pairwise maxima of unsigned 16-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV16uS16u_IV16u(ushort[] xArray, int xOffset, ushort y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ushort* x = &xArray[xOffset])
            {
                Max_IV16uS16u_IV16u(x, y, length);
            }
        }

        /// <summary>Computes pairwise maxima of signed 32-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV32sS32s_IV32s(int[] xArray, int xOffset, int y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (int* x = &xArray[xOffset])
            {
                Max_IV32sS32s_IV32s(x, y, length);
            }
        }

        /// <summary>Computes pairwise maxima of unsigned 32-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV32uS32u_IV32u(uint[] xArray, int xOffset, uint y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (uint* x = &xArray[xOffset])
            {
                Max_IV32uS32u_IV32u(x, y, length);
            }
        }

        /// <summary>Computes pairwise maxima of signed 64-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV64sS32s_IV64s(long[] xArray, int xOffset, int y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (long* x = &xArray[xOffset])
            {
                Max_IV64sS32s_IV64s(x, y, length);
            }
        }

        /// <summary>Computes pairwise maxima of unsigned 64-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV64uS32u_IV64u(ulong[] xArray, int xOffset, uint y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (ulong* x = &xArray[xOffset])
            {
                Max_IV64uS32u_IV64u(x, y, length);
            }
        }

        /// <summary>Computes pairwise maxima of single precision (32-bit) floating-point array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV32fS32f_IV32f(float[] xArray, int xOffset, float y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (float* x = &xArray[xOffset])
            {
                Max_IV32fS32f_IV32f(x, y, length);
            }
        }

        /// <summary>Computes pairwise maxima of double precision (64-bit) floating-point array elements and a constant and writes the result to the same array.</summary>
        /// <exception cref="System.NullReferenceException">If xArray is null.</exception>
        /// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        /// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
        public static unsafe void Max_IV64fS64f_IV64f(double[] xArray, int xOffset, double y, int length)
        {
            if (xOffset < 0)
                throw new System.IndexOutOfRangeException();

            if (xOffset + length > xArray.Length)
                throw new System.IndexOutOfRangeException();

            if (length < 0)
                throw new System.ArgumentException();

            fixed (double* x = &xArray[xOffset])
            {
                Max_IV64fS64f_IV64f(x, y, length);
            }
        }

        /// <summary>Computes the maximum of signed 8-bit integer array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe sbyte Max_V8s_S8s(sbyte* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            sbyte maximum;
            Status status = yepCore_Max_V8s_S8s(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes the maximum of unsigned 8-bit integer array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe byte Max_V8u_S8u(byte* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            byte maximum;
            Status status = yepCore_Max_V8u_S8u(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes the maximum of signed 16-bit integer array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe short Max_V16s_S16s(short* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            short maximum;
            Status status = yepCore_Max_V16s_S16s(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes the maximum of unsigned 16-bit integer array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe ushort Max_V16u_S16u(ushort* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            ushort maximum;
            Status status = yepCore_Max_V16u_S16u(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes the maximum of signed 32-bit integer array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe int Max_V32s_S32s(int* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            int maximum;
            Status status = yepCore_Max_V32s_S32s(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes the maximum of unsigned 32-bit integer array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe uint Max_V32u_S32u(uint* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            uint maximum;
            Status status = yepCore_Max_V32u_S32u(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes the maximum of signed 64-bit integer array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe long Max_V64s_S64s(long* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            long maximum;
            Status status = yepCore_Max_V64s_S64s(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes the maximum of unsigned 64-bit integer array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe ulong Max_V64u_S64u(ulong* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            ulong maximum;
            Status status = yepCore_Max_V64u_S64u(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes the maximum of single precision (32-bit) floating-point array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe float Max_V32f_S32f(float* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            float maximum;
            Status status = yepCore_Max_V32f_S32f(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes the maximum of double precision (64-bit) floating-point array elements.</summary>
        /// <param name="v">Pointer to the array of elements whose maximum will be computed.</param>
        /// <param name="length">Length of the array specified by v. Must be non-zero.</param>
        /// <exception cref="System.NullReferenceException">If v is null.</exception>
        /// <exception cref="System.DataMisalignedException">If v is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative or length is zero.</exception>
        public static unsafe double Max_V64f_S64f(double* v, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            double maximum;
            Status status = yepCore_Max_V64f_S64f(v, out maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
            return maximum;
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 8-bit integer arrays.</summary>
        /// <param name="x">Pointer to the first array of signed 8-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of signed 8-bit integer elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V8sV8s_V8s(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 8-bit integer arrays.</summary>
        /// <param name="x">Pointer to the first array of unsigned 8-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of unsigned 8-bit integer elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V8uV8u_V8u(byte* x, byte* y, byte* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V8uV8u_V8u(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 16-bit integer arrays.</summary>
        /// <param name="x">Pointer to the first array of signed 16-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of signed 16-bit integer elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x, y or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V16sV16s_V16s(short* x, short* y, short* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V16sV16s_V16s(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 16-bit integer arrays.</summary>
        /// <param name="x">Pointer to the first array of unsigned 16-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of unsigned 16-bit integer elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x, y or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V16uV16u_V16u(ushort* x, ushort* y, ushort* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V16uV16u_V16u(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 32-bit integer arrays.</summary>
        /// <param name="x">Pointer to the first array of signed 32-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of signed 32-bit integer elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x, y or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V32sV32s_V32s(int* x, int* y, int* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V32sV32s_V32s(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 32-bit integer arrays.</summary>
        /// <param name="x">Pointer to the first array of unsigned 32-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of unsigned 32-bit integer elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x, y or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V32uV32u_V32u(uint* x, uint* y, uint* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V32uV32u_V32u(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 64-bit integer arrays.</summary>
        /// <param name="x">Pointer to the first array of signed 64-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of signed 32-bit integer elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x, y or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V64sV32s_V64s(long* x, int* y, long* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V64sV32s_V64s(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 64-bit integer arrays.</summary>
        /// <param name="x">Pointer to the first array of unsigned 64-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of unsigned 32-bit integer elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x, y or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V64uV32u_V64u(ulong* x, uint* y, ulong* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V64uV32u_V64u(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two single precision (32-bit) floating-point arrays.</summary>
        /// <param name="x">Pointer to the first array of single precision (32-bit) floating-point elements.</param>
        /// <param name="y">Pointer to the second array of single precision (32-bit) floating-point elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x, y or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V32fV32f_V32f(float* x, float* y, float* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V32fV32f_V32f(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two double precision (64-bit) floating-point arrays.</summary>
        /// <param name="x">Pointer to the first array of double precision (64-bit) floating-point elements.</param>
        /// <param name="y">Pointer to the second array of double precision (64-bit) floating-point elements.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x, y or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x, y or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V64fV64f_V64f(double* x, double* y, double* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V64fV64f_V64f(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of signed 8-bit integer array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of signed 8-bit integer elements.</param>
        /// <param name="y">The signed 8-bit integer constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V8sS8s_V8s(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of unsigned 8-bit integer array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of unsigned 8-bit integer elements.</param>
        /// <param name="y">The unsigned 8-bit integer constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V8uS8u_V8u(byte* x, byte y, byte* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V8uS8u_V8u(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of signed 16-bit integer array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of signed 16-bit integer elements.</param>
        /// <param name="y">The signed 16-bit integer constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V16sS16s_V16s(short* x, short y, short* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V16sS16s_V16s(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of unsigned 16-bit integer array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of unsigned 16-bit integer elements.</param>
        /// <param name="y">The unsigned 16-bit integer constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V16uS16u_V16u(ushort* x, ushort y, ushort* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V16uS16u_V16u(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of signed 32-bit integer array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of signed 32-bit integer elements.</param>
        /// <param name="y">The signed 32-bit integer constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V32sS32s_V32s(int* x, int y, int* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V32sS32s_V32s(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of unsigned 32-bit integer array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of unsigned 32-bit integer elements.</param>
        /// <param name="y">The unsigned 32-bit integer constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V32uS32u_V32u(uint* x, uint y, uint* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V32uS32u_V32u(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of signed 64-bit integer array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of signed 64-bit integer elements.</param>
        /// <param name="y">The signed 32-bit integer constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V64sS32s_V64s(long* x, int y, long* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V64sS32s_V64s(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of unsigned 64-bit integer array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of unsigned 64-bit integer elements.</param>
        /// <param name="y">The unsigned 32-bit integer constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V64uS32u_V64u(ulong* x, uint y, ulong* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V64uS32u_V64u(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of single precision (32-bit) floating-point array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of single precision (32-bit) floating-point elements.</param>
        /// <param name="y">The single precision (32-bit) floating-point constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V32fS32f_V32f(float* x, float y, float* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V32fS32f_V32f(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of double precision (64-bit) floating-point array elements and a constant.</summary>
        /// <param name="x">Pointer to the first array of double precision (64-bit) floating-point elements.</param>
        /// <param name="y">The double precision (64-bit) floating-point constant.</param>
        /// <param name="maximum">Pointer to the array of pairwise maximum elements.</param>
        /// <param name="length">Length of the arrays specified by x, y, and maximum.</param>
        /// <exception cref="System.NullReferenceException">If x or maximum is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or maximum is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_V64fS64f_V64f(double* x, double y, double* maximum, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_V64fS64f_V64f(x, y, maximum, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of signed 8-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of signed 8-bit integer elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV8sV8s_IV8s(sbyte* x, sbyte* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV8sV8s_IV8s(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 8-bit integer arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of unsigned 8-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of unsigned 8-bit integer elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV8uV8u_IV8u(byte* x, byte* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV8uV8u_IV8u(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of signed 16-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of signed 16-bit integer elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV16sV16s_IV16s(short* x, short* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV16sV16s_IV16s(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 16-bit integer arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of unsigned 16-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of unsigned 16-bit integer elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV16uV16u_IV16u(ushort* x, ushort* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV16uV16u_IV16u(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of signed 32-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of signed 32-bit integer elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV32sV32s_IV32s(int* x, int* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV32sV32s_IV32s(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 32-bit integer arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of unsigned 32-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of unsigned 32-bit integer elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV32uV32u_IV32u(uint* x, uint* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV32uV32u_IV32u(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of signed 64-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of signed 32-bit integer elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV64sV32s_IV64s(long* x, int* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV64sV32s_IV64s(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two unsigned 64-bit integer arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of unsigned 64-bit integer elements.</param>
        /// <param name="y">Pointer to the second array of unsigned 32-bit integer elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV64uV32u_IV64u(ulong* x, uint* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV64uV32u_IV64u(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of single precision (32-bit) floating-point elements.</param>
        /// <param name="y">Pointer to the second array of single precision (32-bit) floating-point elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV32fV32f_IV32f(float* x, float* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV32fV32f_IV32f(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
        /// <param name="x">Pointer to the first array of double precision (64-bit) floating-point elements.</param>
        /// <param name="y">Pointer to the second array of double precision (64-bit) floating-point elements.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x or y is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV64fV64f_IV64f(double* x, double* y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV64fV64f_IV64f(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of signed 8-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of signed 8-bit integer elements.</param>
        /// <param name="y">The signed 8-bit integer constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV8sS8s_IV8s(sbyte* x, sbyte y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV8sS8s_IV8s(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of unsigned 8-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of unsigned 8-bit integer elements.</param>
        /// <param name="y">The unsigned 8-bit integer constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV8uS8u_IV8u(byte* x, byte y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV8uS8u_IV8u(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of signed 16-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of signed 16-bit integer elements.</param>
        /// <param name="y">The signed 16-bit integer constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV16sS16s_IV16s(short* x, short y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV16sS16s_IV16s(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of unsigned 16-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of unsigned 16-bit integer elements.</param>
        /// <param name="y">The unsigned 16-bit integer constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV16uS16u_IV16u(ushort* x, ushort y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV16uS16u_IV16u(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of signed 32-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of signed 32-bit integer elements.</param>
        /// <param name="y">The signed 32-bit integer constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV32sS32s_IV32s(int* x, int y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV32sS32s_IV32s(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of unsigned 32-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of unsigned 32-bit integer elements.</param>
        /// <param name="y">The unsigned 32-bit integer constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV32uS32u_IV32u(uint* x, uint y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV32uS32u_IV32u(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of signed 64-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of signed 64-bit integer elements.</param>
        /// <param name="y">The signed 32-bit integer constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV64sS32s_IV64s(long* x, int y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV64sS32s_IV64s(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of unsigned 64-bit integer array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of unsigned 64-bit integer elements.</param>
        /// <param name="y">The unsigned 32-bit integer constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV64uS32u_IV64u(ulong* x, uint y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV64uS32u_IV64u(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of single precision (32-bit) floating-point array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of single precision (32-bit) floating-point elements.</param>
        /// <param name="y">The single precision (32-bit) floating-point constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV32fS32f_IV32f(float* x, float y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV32fS32f_IV32f(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        /// <summary>Computes pairwise maxima of double precision (64-bit) floating-point array elements and a constant and writes the result to the same array.</summary>
        /// <param name="x">Pointer to the array of double precision (64-bit) floating-point elements.</param>
        /// <param name="y">The double precision (64-bit) floating-point constant.</param>
        /// <param name="length">Length of the arrays specified by x and y.</param>
        /// <exception cref="System.NullReferenceException">If x is null.</exception>
        /// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
        /// <exception cref="System.ArgumentException">If length is negative.</exception>
        public static unsafe void Max_IV64fS64f_IV64f(double* x, double y, int length)
        {
            if (length < 0)
                throw new System.ArgumentException();

            Status status = yepCore_Max_IV64fS64f_IV64f(x, y, new System.UIntPtr(unchecked((uint)length)));
            if (status != Status.Ok)
                throw Library.GetException(status);
        }

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V8s_S8s")]
        internal static unsafe extern Status yepCore_Max_V8s_S8s(sbyte* v, out sbyte maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V8u_S8u")]
        internal static unsafe extern Status yepCore_Max_V8u_S8u(byte* v, out byte maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V16s_S16s")]
        internal static unsafe extern Status yepCore_Max_V16s_S16s(short* v, out short maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V16u_S16u")]
        internal static unsafe extern Status yepCore_Max_V16u_S16u(ushort* v, out ushort maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V32s_S32s")]
        internal static unsafe extern Status yepCore_Max_V32s_S32s(int* v, out int maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V32u_S32u")]
        internal static unsafe extern Status yepCore_Max_V32u_S32u(uint* v, out uint maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V64s_S64s")]
        internal static unsafe extern Status yepCore_Max_V64s_S64s(long* v, out long maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V64u_S64u")]
        internal static unsafe extern Status yepCore_Max_V64u_S64u(ulong* v, out ulong maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V32f_S32f")]
        internal static unsafe extern Status yepCore_Max_V32f_S32f(float* v, out float maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V64f_S64f")]
        internal static unsafe extern Status yepCore_Max_V64f_S64f(double* v, out double maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V8sV8s_V8s")]
        internal static unsafe extern Status yepCore_Max_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V8uV8u_V8u")]
        internal static unsafe extern Status yepCore_Max_V8uV8u_V8u(byte* x, byte* y, byte* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V16sV16s_V16s")]
        internal static unsafe extern Status yepCore_Max_V16sV16s_V16s(short* x, short* y, short* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V16uV16u_V16u")]
        internal static unsafe extern Status yepCore_Max_V16uV16u_V16u(ushort* x, ushort* y, ushort* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V32sV32s_V32s")]
        internal static unsafe extern Status yepCore_Max_V32sV32s_V32s(int* x, int* y, int* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V32uV32u_V32u")]
        internal static unsafe extern Status yepCore_Max_V32uV32u_V32u(uint* x, uint* y, uint* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V64sV32s_V64s")]
        internal static unsafe extern Status yepCore_Max_V64sV32s_V64s(long* x, int* y, long* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V64uV32u_V64u")]
        internal static unsafe extern Status yepCore_Max_V64uV32u_V64u(ulong* x, uint* y, ulong* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V32fV32f_V32f")]
        internal static unsafe extern Status yepCore_Max_V32fV32f_V32f(float* x, float* y, float* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V64fV64f_V64f")]
        internal static unsafe extern Status yepCore_Max_V64fV64f_V64f(double* x, double* y, double* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V8sS8s_V8s")]
        internal static unsafe extern Status yepCore_Max_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V8uS8u_V8u")]
        internal static unsafe extern Status yepCore_Max_V8uS8u_V8u(byte* x, byte y, byte* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V16sS16s_V16s")]
        internal static unsafe extern Status yepCore_Max_V16sS16s_V16s(short* x, short y, short* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V16uS16u_V16u")]
        internal static unsafe extern Status yepCore_Max_V16uS16u_V16u(ushort* x, ushort y, ushort* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V32sS32s_V32s")]
        internal static unsafe extern Status yepCore_Max_V32sS32s_V32s(int* x, int y, int* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V32uS32u_V32u")]
        internal static unsafe extern Status yepCore_Max_V32uS32u_V32u(uint* x, uint y, uint* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V64sS32s_V64s")]
        internal static unsafe extern Status yepCore_Max_V64sS32s_V64s(long* x, int y, long* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V64uS32u_V64u")]
        internal static unsafe extern Status yepCore_Max_V64uS32u_V64u(ulong* x, uint y, ulong* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V32fS32f_V32f")]
        internal static unsafe extern Status yepCore_Max_V32fS32f_V32f(float* x, float y, float* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_V64fS64f_V64f")]
        internal static unsafe extern Status yepCore_Max_V64fS64f_V64f(double* x, double y, double* maximum, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV8sV8s_IV8s")]
        internal static unsafe extern Status yepCore_Max_IV8sV8s_IV8s(sbyte* x, sbyte* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV8uV8u_IV8u")]
        internal static unsafe extern Status yepCore_Max_IV8uV8u_IV8u(byte* x, byte* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV16sV16s_IV16s")]
        internal static unsafe extern Status yepCore_Max_IV16sV16s_IV16s(short* x, short* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV16uV16u_IV16u")]
        internal static unsafe extern Status yepCore_Max_IV16uV16u_IV16u(ushort* x, ushort* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV32sV32s_IV32s")]
        internal static unsafe extern Status yepCore_Max_IV32sV32s_IV32s(int* x, int* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV32uV32u_IV32u")]
        internal static unsafe extern Status yepCore_Max_IV32uV32u_IV32u(uint* x, uint* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV64sV32s_IV64s")]
        internal static unsafe extern Status yepCore_Max_IV64sV32s_IV64s(long* x, int* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV64uV32u_IV64u")]
        internal static unsafe extern Status yepCore_Max_IV64uV32u_IV64u(ulong* x, uint* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV32fV32f_IV32f")]
        internal static unsafe extern Status yepCore_Max_IV32fV32f_IV32f(float* x, float* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV64fV64f_IV64f")]
        internal static unsafe extern Status yepCore_Max_IV64fV64f_IV64f(double* x, double* y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV8sS8s_IV8s")]
        internal static unsafe extern Status yepCore_Max_IV8sS8s_IV8s(sbyte* x, sbyte y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV8uS8u_IV8u")]
        internal static unsafe extern Status yepCore_Max_IV8uS8u_IV8u(byte* x, byte y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV16sS16s_IV16s")]
        internal static unsafe extern Status yepCore_Max_IV16sS16s_IV16s(short* x, short y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV16uS16u_IV16u")]
        internal static unsafe extern Status yepCore_Max_IV16uS16u_IV16u(ushort* x, ushort y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV32sS32s_IV32s")]
        internal static unsafe extern Status yepCore_Max_IV32sS32s_IV32s(int* x, int y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV32uS32u_IV32u")]
        internal static unsafe extern Status yepCore_Max_IV32uS32u_IV32u(uint* x, uint y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV64sS32s_IV64s")]
        internal static unsafe extern Status yepCore_Max_IV64sS32s_IV64s(long* x, int y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV64uS32u_IV64u")]
        internal static unsafe extern Status yepCore_Max_IV64uS32u_IV64u(ulong* x, uint y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV32fS32f_IV32f")]
        internal static unsafe extern Status yepCore_Max_IV32fS32f_IV32f(float* x, float y, System.UIntPtr length);

        [DllImport("yeppp", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, EntryPoint = "yepCore_Max_IV64fS64f_IV64f")]
        internal static unsafe extern Status yepCore_Max_IV64fS64f_IV64f(double* x, double y, System.UIntPtr length);
    }
}