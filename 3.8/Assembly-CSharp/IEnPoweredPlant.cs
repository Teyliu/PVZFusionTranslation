using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000DD RID: 221
[Token(Token = "0x20000DD")]
public interface IEnPoweredPlant
{
	// Token: 0x17000052 RID: 82
	// (get) Token: 0x0600042E RID: 1070
	// (set) Token: 0x0600042F RID: 1071
	[Token(Token = "0x17000052")]
	float StrikeRate
	{
		[Token(Token = "0x600042E")]
		[Address(Slot = "0")]
		get;
		[Token(Token = "0x600042F")]
		[Address(Slot = "1")]
		set;
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000430 RID: 1072
	// (set) Token: 0x06000431 RID: 1073
	[Token(Token = "0x17000053")]
	float StrikeDamage
	{
		[Token(Token = "0x6000430")]
		[Address(Slot = "2")]
		get;
		[Token(Token = "0x6000431")]
		[Address(Slot = "3")]
		set;
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000432 RID: 1074
	// (set) Token: 0x06000433 RID: 1075
	[Token(Token = "0x17000054")]
	float DamageMultiplier
	{
		[Token(Token = "0x6000432")]
		[Address(Slot = "4")]
		get;
		[Token(Token = "0x6000433")]
		[Address(Slot = "5")]
		set;
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000434 RID: 1076
	// (set) Token: 0x06000435 RID: 1077
	[Token(Token = "0x17000055")]
	List<Empowerment> Empowerments
	{
		[Token(Token = "0x6000434")]
		[Address(Slot = "6")]
		get;
		[Token(Token = "0x6000435")]
		[Address(Slot = "7")]
		set;
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00015688 File Offset: 0x00013888
	[Token(Token = "0x6000436")]
	[Address(RVA = "0x4B2F10", Offset = "0x4B1510", VA = "0x1804B2F10", Slot = "8")]
	void InitData(CustomizedPlant data)
	{
		int num = 0;
		num += num;
		num++;
		throw new NullReferenceException();
	}

	// Token: 0x06000437 RID: 1079
	[Token(Token = "0x6000437")]
	[Address(Slot = "9")]
	int GetLastDamage(float damage);
}
