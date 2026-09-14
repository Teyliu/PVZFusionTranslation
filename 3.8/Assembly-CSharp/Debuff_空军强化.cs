using System;
using Cpp2IlInjected;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
public class Debuff_空军强化 : BaseDebuff
{
	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000BE RID: 190 RVA: 0x000047D4 File Offset: 0x000029D4
	[Token(Token = "0x1700002D")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x3A7070", Offset = "0x3A5670", VA = "0x1803A7070", Slot = "12")]
		get
		{
			return TravelDebuff.空军强化;
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x000047E8 File Offset: 0x000029E8
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x3A6FC0", Offset = "0x3A55C0", VA = "0x1803A6FC0", Slot = "13")]
	public override string GetDescription()
	{
		return "空军强化：飞行僵尸获得100%血量加成";
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x000047FC File Offset: 0x000029FC
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x3A6FF0", Offset = "0x3A55F0", VA = "0x1803A6FF0", Slot = "19")]
	public override void ReinforceZombie(Zombie zombie)
	{
		ZombieType theZombieType = zombie.theZombieType;
		int num = 0;
		bool flag;
		if (flag)
		{
			Lawnf.SetZombieHealth(zombie, (float)num);
			return;
		}
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00004828 File Offset: 0x00002A28
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_空军强化()
	{
	}
}
