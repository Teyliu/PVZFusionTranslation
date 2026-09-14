using System;
using Cpp2IlInjected;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
public class Debuff_领袖强化 : BaseDebuff
{
	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060000B6 RID: 182 RVA: 0x000046E4 File Offset: 0x000028E4
	[Token(Token = "0x1700002B")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3A7750", Offset = "0x3A5D50", VA = "0x1803A7750", Slot = "12")]
		get
		{
			return TravelDebuff.领袖强化;
		}
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x000046F8 File Offset: 0x000028F8
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x3A7680", Offset = "0x3A5C80", VA = "0x1803A7680", Slot = "13")]
	public override string GetDescription()
	{
		return "领袖强化：领袖僵尸获得30%速度加成和30%血量加成";
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0000470C File Offset: 0x0000290C
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x3A76B0", Offset = "0x3A5CB0", VA = "0x1803A76B0", Slot = "19")]
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

	// Token: 0x060000B9 RID: 185 RVA: 0x00004748 File Offset: 0x00002948
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_领袖强化()
	{
	}
}
