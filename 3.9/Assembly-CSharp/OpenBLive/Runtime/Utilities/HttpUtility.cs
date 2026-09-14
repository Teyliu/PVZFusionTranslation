using System;
using System.Collections.Specialized;
using System.Text;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Utilities
{
	// Token: 0x02000E3B RID: 3643
	[Token(Token = "0x2000E3B")]
	public static class HttpUtility
	{
		// Token: 0x06004B2D RID: 19245 RVA: 0x00171AD8 File Offset: 0x0016FCD8
		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x8CCB60", Offset = "0x8CB160", VA = "0x1808CCB60")]
		public static NameValueCollection ParseQueryString(string query)
		{
			Encoding utf = Encoding.UTF8;
			if (query == 0)
			{
				return null;
			}
			if (utf != 0)
			{
				if (query._stringLength != 0)
				{
					if (query._stringLength == 1)
					{
						int num = 0;
						char c = query[num];
					}
					int num2 = 0;
					char c2 = query[num2];
					string text = query.Substring(1);
					HttpUtility.HttpQsCollection httpQsCollection = new HttpUtility.HttpQsCollection();
					HttpUtility.ParseQueryString(text, utf, httpQsCollection);
				}
				HttpUtility.HttpQsCollection httpQsCollection2 = new HttpUtility.HttpQsCollection();
				return null;
			}
			return null;
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x00171B44 File Offset: 0x0016FD44
		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x8CC9D0", Offset = "0x8CAFD0", VA = "0x1808CC9D0")]
		private static NameValueCollection ParseQueryString(string query, Encoding encoding)
		{
			if (query == 0)
			{
				return null;
			}
			if (encoding != 0)
			{
				if (query._stringLength != 0)
				{
					if (query._stringLength == 1)
					{
						int num = 0;
						char c = query[num];
					}
					int num2 = 0;
					char c2 = query[num2];
					string text = query.Substring(1);
					HttpUtility.HttpQsCollection httpQsCollection = new HttpUtility.HttpQsCollection();
					HttpUtility.ParseQueryString(text, encoding, httpQsCollection);
				}
				HttpUtility.HttpQsCollection httpQsCollection2 = new HttpUtility.HttpQsCollection();
				return null;
			}
			return null;
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x00171BA8 File Offset: 0x0016FDA8
		[Token(Token = "0x6004B2F")]
		[Address(RVA = "0x8CCCF0", Offset = "0x8CB2F0", VA = "0x1808CCCF0")]
		private static void ParseQueryString(string query, Encoding encoding, NameValueCollection result)
		{
			if (query._stringLength != 0)
			{
				int stringLength = query._stringLength;
				int num = 0;
				uint num2;
				if (num < stringLength)
				{
					if (num2 == (uint)(-1))
					{
						char c = query[num];
					}
					char c2 = query[num];
					num++;
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					char c3 = query[num];
					num++;
				}
				if (num2 != (uint)(-1))
				{
					num2 -= (uint)num;
					string text = query.Substring(num, (int)num2);
				}
				int num4 = 0;
				int num5 = query._stringLength;
				num5 -= num;
				string text2 = query.Substring(num, num5);
				string text3;
				result.Add(num4, text3);
				uint num6;
				if (num6 != (uint)(-1))
				{
					while (num6 <= (uint)stringLength)
					{
					}
				}
			}
		}

		// Token: 0x02000E3C RID: 3644
		[Token(Token = "0x2000E3C")]
		private sealed class HttpQsCollection : NameValueCollection
		{
			// Token: 0x06004B30 RID: 19248 RVA: 0x00171C48 File Offset: 0x0016FE48
			[Token(Token = "0x6004B30")]
			[Address(RVA = "0x8CC810", Offset = "0x8CAE10", VA = "0x1808CC810", Slot = "3")]
			public override string ToString()
			{
				int count = base.Count;
				if (count != 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					string[] allKeys = base.AllKeys;
					if (count > 0)
					{
						int num = 0;
						int num2 = 0;
						int num3 = 0;
						string text;
						StringBuilder stringBuilder2 = stringBuilder.AppendFormat("{0}={1}&", num3, text);
						num++;
						num2++;
					}
					if (stringBuilder.Length > 0)
					{
						int num4 = stringBuilder.Length - 1;
						stringBuilder.Length = num4;
					}
				}
				return "";
			}

			// Token: 0x06004B31 RID: 19249 RVA: 0x00171CBC File Offset: 0x0016FEBC
			[Token(Token = "0x6004B31")]
			[Address(RVA = "0x8CC9C0", Offset = "0x8CAFC0", VA = "0x1808CC9C0")]
			public HttpQsCollection()
			{
			}
		}
	}
}
