using System;
using Cpp2IlInjected;

// Token: 0x02000033 RID: 51
[Token(Token = "0x2000033")]
public class Debuff_全民皆兵 : BaseDebuff
{
	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060000DF RID: 223 RVA: 0x00004B54 File Offset: 0x00002D54
	[Token(Token = "0x1700003D")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x3F2B70", Offset = "0x3F1170", VA = "0x1803F2B70", Slot = "12")]
		get
		{
			return TravelDebuff.全民皆兵;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004B68 File Offset: 0x00002D68
	[Token(Token = "0x1700003E")]
	public override string Description
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3F2B80", Offset = "0x3F1180", VA = "0x1803F2B80", Slot = "13")]
		get
		{
			return "全民皆兵：非究极类僵尸获得2倍血量、伤害加成和1.5倍速度加成";
		}
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00004B7C File Offset: 0x00002D7C
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x3F2AD0", Offset = "0x3F10D0", VA = "0x1803F2AD0", Slot = "19")]
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

	// Token: 0x060000E2 RID: 226 RVA: 0x00004BD4 File Offset: 0x00002DD4
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_全民皆兵()
	{
	}
}
