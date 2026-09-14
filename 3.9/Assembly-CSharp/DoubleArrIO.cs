using System;
using System.Text;
using Cpp2IlInjected;

// Token: 0x020009B3 RID: 2483
[Token(Token = "0x20009B3")]
public class DoubleArrIO
{
	// Token: 0x0600332E RID: 13102 RVA: 0x0010C330 File Offset: 0x0010A530
	[Token(Token = "0x600332E")]
	[Address(RVA = "0xA0B9B0", Offset = "0xA09FB0", VA = "0x180A0B9B0")]
	public static string ArrToString<T>(T[,] arr) where T : Enum
	{
		if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
		{
		}
		T t = arr[27];
		if (arr != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder3;
			int num;
			StringBuilder stringBuilder2 = stringBuilder3.Append(",").Append(num).Append("|");
			if (arr > 0)
			{
				int num2 = 0;
				int num3 = 0;
				int num5;
				StringBuilder stringBuilder4;
				if (num > 0)
				{
					int num4 = 0;
					num5 = num - 1;
					if (num3 < num5)
					{
						stringBuilder4 = stringBuilder.Append(",");
					}
					num3++;
					num4++;
				}
				if (num5 < stringBuilder4)
				{
					StringBuilder stringBuilder5 = stringBuilder.Append("|");
				}
				num5++;
				num2++;
			}
			string text = stringBuilder.ToString();
		}
		return "null";
	}

	// Token: 0x0600332F RID: 13103 RVA: 0x0010C3F4 File Offset: 0x0010A5F4
	[Token(Token = "0x600332F")]
	[Address(RVA = "0xA0BBF0", Offset = "0xA0A1F0", VA = "0x180A0BBF0")]
	public static T[,] StringToArr<T>(string str) where T : Enum
	{
		string[] array;
		int num6;
		for (;;)
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			if (string.Equals(str, "null"))
			{
				goto IL_00AC;
			}
			int num = 0;
			uint num2;
			array = str.Split((char)num2, (StringSplitOptions)num);
			string text = array[0];
			int num3 = 0;
			uint num4;
			string[] array2 = text.Split((char)num4, (StringSplitOptions)num3);
			if (array2.Length == 2)
			{
				int num5 = int.Parse(array2[0]);
				num6 = int.Parse(array2[1]);
				if (array.Length == num5)
				{
					break;
				}
			}
		}
		uint num7;
		if (num7 < (uint)array.Length)
		{
			string[] array3;
			if (array3.Length != num6)
			{
				return null;
			}
			int num8 = 0;
			if (num6 > 0)
			{
				num8++;
				num8++;
			}
			num7 += (uint)1;
		}
		IL_00AC:
		throw new InvalidCastException();
	}

	// Token: 0x06003330 RID: 13104 RVA: 0x0010C4BC File Offset: 0x0010A6BC
	[Token(Token = "0x6003330")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public DoubleArrIO()
	{
	}
}
