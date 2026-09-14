using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000974 RID: 2420
[Token(Token = "0x2000974")]
public static class CoreEnums
{
	// Token: 0x060031F1 RID: 12785 RVA: 0x00107318 File Offset: 0x00105518
	[Token(Token = "0x60031F1")]
	[Address(RVA = "0x6E3D90", Offset = "0x6E2390", VA = "0x1806E3D90")]
	static CoreEnums()
	{
		CoreEnums.InitBasicPlants();
	}

	// Token: 0x060031F2 RID: 12786 RVA: 0x00107338 File Offset: 0x00105538
	[Token(Token = "0x60031F2")]
	[Address(RVA = "0x6E3B60", Offset = "0x6E2160", VA = "0x1806E3B60")]
	private static void InitBasicPlants()
	{
		int num = 0;
		AdvantureCardLayout[] enumValues = global::Core.Lawnf.GetEnumValues<AdvantureCardLayout>();
		if (num < enumValues.Length)
		{
			AdvantureCardLayout[] enumValues2 = global::Core.Lawnf.GetEnumValues<AdvantureCardLayout>();
			ulong num2;
			num2 += num2;
			AdvantureCardLayout advantureCardLayout;
			if (num < 7 && advantureCardLayout.TryConvertTo((PlantType)num))
			{
				bool flag = CoreEnums.baiscPlants.Add(num);
			}
			num++;
			uint num3;
			num3 += (uint)4;
		}
		HashSet<PlantType> hashSet = CoreEnums.baiscPlants;
		HashSet<PlantType> hashSet2 = CoreEnums.baiscPlants;
	}

	// Token: 0x060031F3 RID: 12787 RVA: 0x001073A0 File Offset: 0x001055A0
	[Token(Token = "0x60031F3")]
	[Address(RVA = "0x93E3C0", Offset = "0x93C9C0", VA = "0x18093E3C0")]
	public static bool TryConvertTo<T>(this Enum A_0, [Out] T result) where T : Enum
	{
		if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
		{
		}
		string text = A_0.ToString();
		ulong num;
		string text2;
		if (!Enum.TryParse(typeof(Type), text, true, num))
		{
			Type type;
			text2 = string.Format("无法将{0}转换为{1}", A_0, type);
			Debug.LogWarning(text2);
		}
		int stringLength = text2._stringLength;
		return true;
	}

	// Token: 0x060031F4 RID: 12788 RVA: 0x00107410 File Offset: 0x00105610
	[Token(Token = "0x60031F4")]
	[Address(RVA = "0x93E030", Offset = "0x93C630", VA = "0x18093E030")]
	public static T ConvertTo<T>(this Enum A_0) where T : Enum
	{
		if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
		{
		}
		string text = A_0.ToString();
		Type type;
		ulong num;
		if (!Enum.TryParse(type, text, true, num))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x04001CF9 RID: 7417
	[Token(Token = "0x4001CF9")]
	public static HashSet<PlantType> baiscPlants = new HashSet();
}
