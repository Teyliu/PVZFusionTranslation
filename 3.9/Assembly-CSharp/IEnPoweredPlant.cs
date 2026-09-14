using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000E2 RID: 226
[Token(Token = "0x20000E2")]
public interface IEnPoweredPlant
{
	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000449 RID: 1097
	// (set) Token: 0x0600044A RID: 1098
	[Token(Token = "0x1700008F")]
	float StrikeRate
	{
		[Token(Token = "0x6000449")]
		[Address(Slot = "0")]
		get;
		[Token(Token = "0x600044A")]
		[Address(Slot = "1")]
		set;
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x0600044B RID: 1099
	// (set) Token: 0x0600044C RID: 1100
	[Token(Token = "0x17000090")]
	float StrikeDamage
	{
		[Token(Token = "0x600044B")]
		[Address(Slot = "2")]
		get;
		[Token(Token = "0x600044C")]
		[Address(Slot = "3")]
		set;
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x0600044D RID: 1101
	// (set) Token: 0x0600044E RID: 1102
	[Token(Token = "0x17000091")]
	float DamageMultiplier
	{
		[Token(Token = "0x600044D")]
		[Address(Slot = "4")]
		get;
		[Token(Token = "0x600044E")]
		[Address(Slot = "5")]
		set;
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x0600044F RID: 1103
	// (set) Token: 0x06000450 RID: 1104
	[Token(Token = "0x17000092")]
	List<Empowerment> Empowerments
	{
		[Token(Token = "0x600044F")]
		[Address(Slot = "6")]
		get;
		[Token(Token = "0x6000450")]
		[Address(Slot = "7")]
		set;
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00015B20 File Offset: 0x00013D20
	[Token(Token = "0x6000451")]
	[Address(RVA = "0x4F25D0", Offset = "0x4F0BD0", VA = "0x1804F25D0", Slot = "8")]
	void InitData(CustomizedPlant data)
	{
		int num = 0;
		num += num;
		num++;
		throw new NullReferenceException();
	}

	// Token: 0x06000452 RID: 1106
	[Token(Token = "0x6000452")]
	[Address(Slot = "9")]
	int GetLastDamage(float damage);
}
