using System;
using Cpp2IlInjected;

// Token: 0x0200002F RID: 47
[Token(Token = "0x200002F")]
public class Debuff_全民皆兵 : BaseDebuff
{
	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x000048C4 File Offset: 0x00002AC4
	[Token(Token = "0x1700002F")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x3A6C10", Offset = "0x3A5210", VA = "0x1803A6C10", Slot = "12")]
		get
		{
			return TravelDebuff.全民皆兵;
		}
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x3A6B40", Offset = "0x3A5140", VA = "0x1803A6B40", Slot = "13")]
	public override string GetDescription()
	{
		return "全民皆兵：非究极类僵尸获得2倍血量、伤害加成和1.5倍速度加成";
	}

	// Token: 0x060000CA RID: 202 RVA: 0x000048EC File Offset: 0x00002AEC
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x3A6B70", Offset = "0x3A5170", VA = "0x1803A6B70", Slot = "19")]
	public override void ReinforceZombie(Zombie zombie)
	{
		ZombieType theZombieType = zombie.theZombieType;
		int num = 0;
		bool flag;
		if (!flag)
		{
			Lawnf.SetZombieHealth(zombie, (float)num);
			int num2 = zombie.theAttackDamage;
			num2 += num2;
			zombie.theAttackDamage = num2;
			float num3 = zombie.theOriginSpeed * 1.5f;
			zombie.theOriginSpeed = num3;
		}
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00004944 File Offset: 0x00002B44
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_全民皆兵()
	{
	}
}
