using System;
using Cpp2IlInjected;

// Token: 0x0200002F RID: 47
[Token(Token = "0x200002F")]
public class Debuff_领袖强化 : BaseDebuff
{
	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000CD RID: 205 RVA: 0x00004974 File Offset: 0x00002B74
	[Token(Token = "0x17000035")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x3F3540", Offset = "0x3F1B40", VA = "0x1803F3540", Slot = "12")]
		get
		{
			return TravelDebuff.领袖强化;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000CE RID: 206 RVA: 0x00004988 File Offset: 0x00002B88
	[Token(Token = "0x17000036")]
	public override string Description
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3F3550", Offset = "0x3F1B50", VA = "0x1803F3550", Slot = "13")]
		get
		{
			return "领袖强化：领袖僵尸获得30%速度加成和30%血量加成";
		}
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0000499C File Offset: 0x00002B9C
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x3F34A0", Offset = "0x3F1AA0", VA = "0x1803F34A0", Slot = "19")]
	public override void ReinforceZombie(Zombie zombie)
	{
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		if (flag)
		{
			float theOriginSpeed = zombie.theOriginSpeed;
			zombie.theOriginSpeed = theOriginSpeed;
			Lawnf.SetZombieHealth(zombie, 1.3f);
			return;
		}
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x000049D8 File Offset: 0x00002BD8
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_领袖强化()
	{
	}
}
