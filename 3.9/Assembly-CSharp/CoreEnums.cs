using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;

// Token: 0x020009B0 RID: 2480
[Token(Token = "0x20009B0")]
public static class CoreEnums
{
	// Token: 0x06003324 RID: 13092 RVA: 0x0010C09C File Offset: 0x0010A29C
	[Token(Token = "0x6003324")]
	[Address(RVA = "0x749150", Offset = "0x747750", VA = "0x180749150")]
	static CoreEnums()
	{
		CoreEnums.InitBasicPlants();
	}

	// Token: 0x06003325 RID: 13093 RVA: 0x0010C0BC File Offset: 0x0010A2BC
	[Token(Token = "0x6003325")]
	[Address(RVA = "0x748F20", Offset = "0x747520", VA = "0x180748F20")]
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

	// Token: 0x06003326 RID: 13094 RVA: 0x0010C124 File Offset: 0x0010A324
	[Token(Token = "0x6003326")]
	[Address(RVA = "0x9FCFB0", Offset = "0x9FB5B0", VA = "0x1809FCFB0")]
	public static bool TryConvertTo<T>(this Enum cpp2il__autoParamName__idx_0, [Out] T result) where T : Enum
	{
		if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
		{
		}
		string text = cpp2il__autoParamName__idx_0.ToString();
		Type type;
		ulong num;
		if (!Enum.TryParse(type, text, true, num))
		{
		}
		return true;
	}

	// Token: 0x06003327 RID: 13095 RVA: 0x0010C164 File Offset: 0x0010A364
	[Token(Token = "0x6003327")]
	[Address(RVA = "0x9FCCA0", Offset = "0x9FB2A0", VA = "0x1809FCCA0")]
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

	// Token: 0x06003328 RID: 13096 RVA: 0x0010C1B0 File Offset: 0x0010A3B0
	[Token(Token = "0x6003328")]
	[Address(RVA = "0x748E70", Offset = "0x747470", VA = "0x180748E70")]
	public static MusicType GetMusicType(this SceneType sceneType)
	{
		if (sceneType <= SceneType.NightWinter)
		{
		}
		uint num;
		num += (uint)2;
		num += (uint)4;
		return MusicType.MainMenu;
	}

	// Token: 0x04001DE9 RID: 7657
	[Token(Token = "0x4001DE9")]
	public static HashSet<PlantType> baiscPlants = new HashSet();
}
