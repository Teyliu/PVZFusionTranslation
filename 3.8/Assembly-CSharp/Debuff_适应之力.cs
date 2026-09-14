using System;
using Cpp2IlInjected;

// Token: 0x02000024 RID: 36
[Token(Token = "0x2000024")]
public class Debuff_适应之力 : BaseDebuff
{
	// Token: 0x0600009B RID: 155 RVA: 0x00004404 File Offset: 0x00002604
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x3A7080", Offset = "0x3A5680", VA = "0x1803A7080", Slot = "13")]
	public override string GetDescription()
	{
		return "适应之力：僵尸每次受伤，获得相当于伤害量1%的护甲，有上限";
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600009C RID: 156 RVA: 0x00004418 File Offset: 0x00002618
	[Token(Token = "0x17000027")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x3A71D0", Offset = "0x3A57D0", VA = "0x1803A71D0", Slot = "12")]
		get
		{
			return TravelDebuff.适应之力;
		}
	}

	// Token: 0x0600009D RID: 157 RVA: 0x0000442C File Offset: 0x0000262C
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000443C File Offset: 0x0000263C
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x3A70B0", Offset = "0x3A56B0", VA = "0x1803A70B0", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		if (Debuff_适应之力.<>c.<>9__4_0 == 0)
		{
			Action<object> action;
			Debuff_适应之力.<>c.<>9__4_0 = action;
		}
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00004458 File Offset: 0x00002658
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_适应之力()
	{
	}
}
