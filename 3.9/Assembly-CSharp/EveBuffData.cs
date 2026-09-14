using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009D2 RID: 2514
[Token(Token = "0x20009D2")]
public static class EveBuffData
{
	// Token: 0x06003339 RID: 13113 RVA: 0x0010C938 File Offset: 0x0010AB38
	[Token(Token = "0x6003339")]
	[Address(RVA = "0x74A240", Offset = "0x748840", VA = "0x18074A240")]
	public static string GetDescription(EveBuff buff)
	{
		Dictionary<EveBuff, string> buffDescription = EveBuffData.BuffDescription;
		return "未命名";
	}

	// Token: 0x0600333A RID: 13114 RVA: 0x0010C958 File Offset: 0x0010AB58
	[Token(Token = "0x600333A")]
	[Address(RVA = "0x74A190", Offset = "0x748790", VA = "0x18074A190")]
	public static string GetDescription(EveZombieBuff buff)
	{
		Dictionary<EveZombieBuff, string> zombieBuffDescription = EveBuffData.ZombieBuffDescription;
		return "未命名";
	}

	// Token: 0x0600333B RID: 13115 RVA: 0x0010C978 File Offset: 0x0010AB78
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600333B")]
	[Address(RVA = "0x74A2F0", Offset = "0x7488F0", VA = "0x18074A2F0")]
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

	// Token: 0x040024C4 RID: 9412
	[Token(Token = "0x40024C4")]
	private static readonly Dictionary<EveBuff, string> BuffDescription;

	// Token: 0x040024C5 RID: 9413
	[Token(Token = "0x40024C5")]
	private static readonly Dictionary<EveZombieBuff, string> ZombieBuffDescription;
}
