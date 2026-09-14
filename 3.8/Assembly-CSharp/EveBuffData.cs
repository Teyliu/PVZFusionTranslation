using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000996 RID: 2454
[Token(Token = "0x2000996")]
public static class EveBuffData
{
	// Token: 0x06003205 RID: 12805 RVA: 0x00107B5C File Offset: 0x00105D5C
	[Token(Token = "0x6003205")]
	[Address(RVA = "0x6E4D90", Offset = "0x6E3390", VA = "0x1806E4D90")]
	public static string GetDescription(EveBuff buff)
	{
		Dictionary<EveBuff, string> buffDescription = EveBuffData.BuffDescription;
		return "未命名";
	}

	// Token: 0x06003206 RID: 12806 RVA: 0x00107B7C File Offset: 0x00105D7C
	[Token(Token = "0x6003206")]
	[Address(RVA = "0x6E4CE0", Offset = "0x6E32E0", VA = "0x1806E4CE0")]
	public static string GetDescription(EveZombieBuff buff)
	{
		Dictionary<EveZombieBuff, string> zombieBuffDescription = EveBuffData.ZombieBuffDescription;
		return "未命名";
	}

	// Token: 0x06003207 RID: 12807 RVA: 0x00107B9C File Offset: 0x00105D9C
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6003207")]
	[Address(RVA = "0x6E4E40", Offset = "0x6E3440", VA = "0x1806E4E40")]
	static EveBuffData()
	{
		Dictionary<EveBuff, string> dictionary = new Dictionary();
		int num = 0;
		dictionary.Add(num, "本行的植物攻击力+50%");
		EveBuffData.BuffDescription = dictionary;
		Dictionary<EveZombieBuff, string> dictionary2 = new Dictionary();
		int num2 = 0;
		dictionary2.Add(num2, "关卡开始时僵尸获得100%速度加成和100%血量加成，该加成在120秒内会逐步衰减");
		EveBuffData.ZombieBuffDescription = dictionary2;
		throw new NullReferenceException();
	}

	// Token: 0x040023B6 RID: 9142
	[Token(Token = "0x40023B6")]
	private static readonly Dictionary<EveBuff, string> BuffDescription;

	// Token: 0x040023B7 RID: 9143
	[Token(Token = "0x40023B7")]
	private static readonly Dictionary<EveZombieBuff, string> ZombieBuffDescription;
}
