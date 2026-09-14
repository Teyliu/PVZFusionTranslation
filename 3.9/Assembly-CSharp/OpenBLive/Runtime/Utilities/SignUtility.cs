using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2IlInjected;
using UnityEngine.Networking;

namespace OpenBLive.Runtime.Utilities
{
	// Token: 0x02000E3F RID: 3647
	[Token(Token = "0x2000E3F")]
	public static class SignUtility
	{
		// Token: 0x06004B3D RID: 19261 RVA: 0x00171EBC File Offset: 0x001700BC
		[Token(Token = "0x6004B3D")]
		[Address(RVA = "0x8D1590", Offset = "0x8CFB90", VA = "0x1808D1590")]
		private static Dictionary<string, string> OrderAndMd5(string jsonParam)
		{
			Dictionary<string, string> dictionary = new Dictionary();
			MD5 md = MD5.Create();
			byte[] bytes = Encoding.UTF8.GetBytes(jsonParam);
			byte[] array = md.ComputeHash(bytes);
			Func<string, byte, string> <>9__5_ = SignUtility.<>c.<>9__5_0;
			if (<>9__5_ == 0)
			{
				Func<string, byte, string> func;
				SignUtility.<>c.<>9__5_0 = func;
			}
			int num = 0;
			byte b = Enumerable.Aggregate<byte, string>(array, (byte)num, <>9__5_);
			DateTime utcNow = DateTime.UtcNow;
			string text;
			dictionary.Add("x-bili-timestamp", text);
			dictionary.Add("x-bili-signature-method", "HMAC-SHA256");
			Guid guid = Guid.NewGuid();
			string text2;
			dictionary.Add("x-bili-signature-nonce", text2);
			string text3 = SignUtility.accessKeyId;
			dictionary.Add("x-bili-accesskeyid", text3);
			dictionary.Add("x-bili-signature-version", "1.0");
			Func<KeyValuePair<string, string>, string> func2;
			if (SignUtility.<>c.<>9__4_0 == 0)
			{
				SignUtility.<>c.<>9__4_0 = func2;
			}
			IOrderedEnumerable<KeyValuePair<string, string>> orderedEnumerable = Enumerable.OrderBy<KeyValuePair<string, string>, string>(dictionary, func2);
			Func<KeyValuePair<string, string>, string> func3;
			if (SignUtility.<>c.<>9__4_1 == 0)
			{
				SignUtility.<>c.<>9__4_1 = func3;
			}
			Func<KeyValuePair<string, string>, string> func4;
			if (SignUtility.<>c.<>9__4_2 == 0)
			{
				SignUtility.<>c.<>9__4_2 = func4;
			}
			return Enumerable.ToDictionary<KeyValuePair<string, string>, string, string>(orderedEnumerable, func3, func4);
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x00171FCC File Offset: 0x001701CC
		[Token(Token = "0x6004B3E")]
		[Address(RVA = "0x8D1420", Offset = "0x8CFA20", VA = "0x1808D1420")]
		private static string Md5(this string source)
		{
			MD5 md = MD5.Create();
			byte[] bytes = Encoding.UTF8.GetBytes(source);
			byte[] array = md.ComputeHash(bytes);
			Func<string, byte, string> <>9__5_ = SignUtility.<>c.<>9__5_0;
			if (<>9__5_ == 0)
			{
				Func<string, byte, string> func;
				SignUtility.<>c.<>9__5_0 = func;
			}
			int num = 0;
			byte b = Enumerable.Aggregate<byte, string>(array, (byte)num, <>9__5_);
			throw new NullReferenceException();
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x00172024 File Offset: 0x00170224
		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0x8D0EA0", Offset = "0x8CF4A0", VA = "0x1808D0EA0")]
		private static string CalculateSignature(Dictionary<string, string> keyValuePairs)
		{
			string empty;
			int num;
			do
			{
				empty = string.Empty;
				num = 0;
				bool flag;
				if (flag && !string.IsNullOrEmpty(empty))
				{
					string text = string.Concat(new string[] { empty, "\n", null, ":", ":" });
				}
			}
			while (num != 0);
			string text2 = SignUtility.accessKeySecret;
			return SignUtility.HmacSHA256(empty, text2);
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x001720D0 File Offset: 0x001702D0
		[Token(Token = "0x6004B40")]
		[Address(RVA = "0x8D11D0", Offset = "0x8CF7D0", VA = "0x1808D11D0")]
		private static string HmacSHA256(string message, string secret)
		{
			int num;
			string text2;
			do
			{
				num = 0;
				UTF8Encoding utf8Encoding = new UTF8Encoding();
				byte[] bytes = utf8Encoding.GetBytes("");
				byte[] bytes2 = utf8Encoding.GetBytes(message);
				byte[] array = new HMACSHA256(bytes).ComputeHash(bytes2);
				StringBuilder stringBuilder = new StringBuilder();
				if (num < array.Length)
				{
					string text;
					StringBuilder stringBuilder2 = stringBuilder.Append(text);
					num++;
				}
				text2 = stringBuilder.ToString();
				if ("{il2cpp array field local9->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
			return text2;
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x00172168 File Offset: 0x00170368
		[Token(Token = "0x6004B41")]
		[Address(RVA = "0x8D1C00", Offset = "0x8D0200", VA = "0x1808D1C00")]
		public static void SetReqHeader(UnityWebRequest webRequest, string jsonParam, [Optional] string cookie)
		{
			ulong num;
			do
			{
				string text = SignUtility.CalculateSignature(SignUtility.OrderAndMd5(jsonParam));
				bool flag;
				if (flag)
				{
				}
			}
			while (num != (ulong)0L);
			Encoding utf = Encoding.UTF8;
			byte[] array;
			UploadHandlerRaw uploadHandlerRaw = new UploadHandlerRaw(array);
		}

		// Token: 0x04003538 RID: 13624
		[Token(Token = "0x4003538")]
		public static string accessKeySecret = "";

		// Token: 0x04003539 RID: 13625
		[Token(Token = "0x4003539")]
		public static string accessKeyId = "";

		// Token: 0x0400353A RID: 13626
		[Token(Token = "0x400353A")]
		public static string clientId = "";

		// Token: 0x0400353B RID: 13627
		[Token(Token = "0x400353B")]
		public static string secret = "";
	}
}
