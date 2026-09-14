using System;
using Cpp2IlInjected;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
public class Debuff_适应之力 : BaseDebuff
{
	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000478C File Offset: 0x0000298C
	[Token(Token = "0x1700002F")]
	public override string Description
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3F3140", Offset = "0x3F1740", VA = "0x1803F3140", Slot = "13")]
		get
		{
			return "适应之力：僵尸每次受伤，获得相当于伤害量1%的护甲，有上限";
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000B7 RID: 183 RVA: 0x000047A0 File Offset: 0x000029A0
	[Token(Token = "0x17000030")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x3F3130", Offset = "0x3F1730", VA = "0x1803F3130", Slot = "12")]
		get
		{
			return TravelDebuff.适应之力;
		}
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000047B4 File Offset: 0x000029B4
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x000047C4 File Offset: 0x000029C4
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x3F3010", Offset = "0x3F1610", VA = "0x1803F3010", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Debuff_适应之力.<>c.<>9__5_0 == 0)
		{
			Action<object> action;
			Debuff_适应之力.<>c.<>9__5_0 = action;
		}
	}

	// Token: 0x060000BA RID: 186 RVA: 0x000047E0 File Offset: 0x000029E0
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_适应之力()
	{
	}
}
