using System;
using System.Text;
using Cpp2IlInjected;

// Token: 0x02000977 RID: 2423
[Token(Token = "0x2000977")]
public class DoubleArrIO
{
	// Token: 0x060031FA RID: 12794 RVA: 0x001075B0 File Offset: 0x001057B0
	[Token(Token = "0x60031FA")]
	[Address(RVA = "0x949480", Offset = "0x947A80", VA = "0x180949480")]
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

	// Token: 0x060031FB RID: 12795 RVA: 0x00107674 File Offset: 0x00105874
	[Token(Token = "0x60031FB")]
	[Address(RVA = "0x9496C0", Offset = "0x947CC0", VA = "0x1809496C0")]
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

	// Token: 0x060031FC RID: 12796 RVA: 0x0010773C File Offset: 0x0010593C
	[Token(Token = "0x60031FC")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public DoubleArrIO()
	{
	}
}
