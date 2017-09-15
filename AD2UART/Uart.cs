using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD2UART
{
    public static class Uart
    {
        /// <summary> 
        /// 字符串转16进制字节数组 
        /// </summary> 
        /// <param name="hexString"></param> 
        /// <returns></returns> 
        private static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// <summary> 
        /// 字节数组转16进制字符串 
        /// </summary> 
        /// <param name="bytes"></param> 
        /// <returns></returns> 
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    if(i > 0)
                    {
                        returnStr += " ";
                    }
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }

        /// <summary>
        /// 计算校验和
        /// </summary>
        /// <param name="bytes">检验数组</param>
        /// <param name="start">校验起始位置</param>
        /// <param name="length">校验长度</param>
        /// <returns>校验和</returns>
        public static byte byteCheakSum(byte[] bytes, int start = 0, int length = 0)
        {
            UInt32 sum = 1;
            if(length == 0)
            {
                length = bytes.Length - start;
            }
            for (int i = start; i < length + start; i++) 
            {
                sum += Convert.ToUInt32(bytes[i]);
            }
            return Convert.ToByte(sum & 0xFF);
        }

        /// <summary>
        /// 计算检验和（异或）
        /// </summary>
        /// <param name="bytes">检验数组</param>
        /// <param name="start">校验起始位置</param>
        /// <param name="length">校验长度</param>
        /// <returns>校验和</returns>
        public static byte byteCheckSum_xor(byte[] bytes, int start = 0, int length = 0)
        {
            byte sum = 0;
            if (length == 0)
            {
                length = bytes.Length - start;
            }
            for (int i = start + 1; i < length + start; i++) 
            {
                sum ^= bytes[i];
            }
            return sum;
        }

        /// <summary>
        /// 检测二进制某一位
        /// </summary>
        /// <param name="Num">二进制数</param>
        /// <param name="Bin">需要检查的位置</param>
        /// <returns></returns>
        public static bool isBinTest(byte Num, int Bin)
        {
            if(((Num >> Bin)&1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
