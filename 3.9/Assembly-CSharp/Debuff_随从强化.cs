using System;
using Cpp2IlInjected;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
public class Debuff_随从强化 : BaseDebuff
{
	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x000049EC File Offset: 0x00002BEC
	[Token(Token = "0x17000037")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3F3210", Offset = "0x3F1810", VA = "0x1803F3210", Slot = "12")]
		get
		{
			return TravelDebuff.随从强化;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x00004A00 File Offset: 0x00002C00
	[Token(Token = "0x17000038")]
	public override string Description
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x3F3220", Offset = "0x3F1820", VA = "0x1803F3220", Slot = "13")]
		get
		{
			return "随从强化：非领袖僵尸获得30%速度加成和30%血量加成";
		}
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00004A14 File Offset: 0x00002C14
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x3F3170", Offset = "0x3F1770", VA = "0x1803F3170", Slot = "19")]
	public override void ReinforceZombie(Zombie zombie)
	{
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		if (!flag)
		{
			float theOriginSpeed = zombie.theOriginSpeed;
			zombie.theOriginSpeed = theOriginSpeed;
			Lawnf.SetZombieHealth(zombie, 1.3f);
			return;
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00004A50 File Offset: 0x00002C50
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_随从强化()
	{
	}
}
