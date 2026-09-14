using System;
using Cpp2IlInjected;

// Token: 0x02000031 RID: 49
[Token(Token = "0x2000031")]
public class Debuff_空军强化 : BaseDebuff
{
	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x00004A64 File Offset: 0x00002C64
	[Token(Token = "0x17000039")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x3F2FD0", Offset = "0x3F15D0", VA = "0x1803F2FD0", Slot = "12")]
		get
		{
			return TravelDebuff.空军强化;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004A78 File Offset: 0x00002C78
	[Token(Token = "0x1700003A")]
	public override string Description
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x3F2FE0", Offset = "0x3F15E0", VA = "0x1803F2FE0", Slot = "13")]
		get
		{
			return "空军强化：飞行僵尸获得100%血量加成";
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00004A8C File Offset: 0x00002C8C
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x3F2F50", Offset = "0x3F1550", VA = "0x1803F2F50", Slot = "19")]
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

	// Token: 0x060000D8 RID: 216 RVA: 0x00004AB8 File Offset: 0x00002CB8
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_空军强化()
	{
	}
}
