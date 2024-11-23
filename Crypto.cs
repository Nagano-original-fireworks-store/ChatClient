using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ChatClient
{
    public class Crypto
    {
        public static byte[] HkdfExpand(byte[] salt, byte[] key, int length)
        {
            if (salt == null) throw new ArgumentNullException(nameof(salt));  // 检查 salt 是否为 null
            if (key == null) throw new ArgumentNullException(nameof(key));      // 检查 key 是否为 null

            using (HMACSHA256 hmac = new HMACSHA256(key))
            {
                byte[] prk = hmac.ComputeHash(salt);  // Extract step
                byte[] okm = new byte[length];
                byte[] t = new byte[32];  // 确保 t 已经初始化
                int offset = 0;

                // Expand step
                while (offset < length)
                {
                    hmac.Initialize();
                    hmac.TransformBlock(t, 0, t.Length, t, 0);
                    hmac.TransformFinalBlock(new byte[] { 0x01 }, 0, 1);
#pragma warning disable CS8600
                    t = hmac.Hash;  // 确保 t 被赋值为非 null 数组
#pragma warning restore CS8600
                    // 检查 t 和 okm 不为 null
                    if (t == null) throw new InvalidOperationException("HMAC Hash returned null.");
                    if (okm == null) throw new InvalidOperationException("Output key material (okm) is null.");

                    // 复制数据
                    Array.Copy(t, 0, okm, offset, Math.Min(t.Length, length - offset));
                    offset += t.Length;
                }

                return okm;
            }
        }



        public static byte[] AESEncrypt(byte[] key, byte[] plaintext)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));  // 确保 key 不为 null
            if (plaintext == null) throw new ArgumentNullException(nameof(plaintext));  // 确保 plaintext 不为 null

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.GenerateIV();  // 生成随机 IV
                aesAlg.Mode = CipherMode.CBC;  // 使用 CBC 模式

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ms.Write(aesAlg.IV, 0, aesAlg.IV.Length);  // 存储 IV
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(plaintext, 0, plaintext.Length);  // 写入明文
                        }
                        return ms.ToArray();
                    }
                }
            }
        }

    }
}
