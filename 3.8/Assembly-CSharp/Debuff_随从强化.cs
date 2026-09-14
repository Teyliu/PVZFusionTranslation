using System;
using Cpp2IlInjected;

// Token: 0x0200002C RID: 44
[Token(Token = "0x200002C")]
public class Debuff_随从强化 : BaseDebuff
{
	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060000BA RID: 186 RVA: 0x0000475C File Offset: 0x0000295C
	[Token(Token = "0x1700002C")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3A7420", Offset = "0x3A5A20", VA = "0x1803A7420", Slot = "12")]
		get
		{
			return TravelDebuff.随从强化;
		}
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00004770 File Offset: 0x00002970
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x3A7350", Offset = "0x3A5950", VA = "0x1803A7350", Slot = "13")]
	public override string GetDescription()
	{
		return "随从强化：非领袖僵尸获得30%速度加成和30%血量加成";
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00004784 File Offset: 0x00002984
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x3A7380", Offset = "0x3A5980", VA = "0x1803A7380", Slot = "19")]
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

	// Token: 0x060000BD RID: 189 RVA: 0x000047C0 File Offset: 0x000029C0
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_随从强化()
	{
	}
}
