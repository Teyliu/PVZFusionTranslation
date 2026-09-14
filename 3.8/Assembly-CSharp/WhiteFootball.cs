using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000713 RID: 1811
[Token(Token = "0x2000713")]
public class WhiteFootball : Zombie
{
	// Token: 0x06002464 RID: 9316 RVA: 0x000BD9A4 File Offset: 0x000BBBA4
	[Token(Token = "0x6002464")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002465 RID: 9317 RVA: 0x000BD9B4 File Offset: 0x000BBBB4
	[Token(Token = "0x6002465")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06002466 RID: 9318 RVA: 0x000BD9C4 File Offset: 0x000BBBC4
	[Token(Token = "0x6002466")]
	[Address(RVA = "0x571D40", Offset = "0x570340", VA = "0x180571D40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 15f;
	}

	// Token: 0x06002467 RID: 9319 RVA: 0x000BD9E4 File Offset: 0x000BBBE4
	[Token(Token = "0x6002467")]
	[Address(RVA = "0x591C20", Offset = "0x590220", VA = "0x180591C20", Slot = "23")]
	protected override void AttributeEvent()
	{
		base.Die(2);
		GameObject theFirstArmor = this.theFirstArmor;
		int num = 0;
		bool flag = theFirstArmor == num;
		bool isMindControlled = this.isMindControlled;
		if (!flag)
		{
			if (!isMindControlled)
			{
				Transform axis = this.axis;
				CreateZombie instance = CreateZombie.Instance;
				return;
			}
			Transform axis2 = this.axis;
			CreateZombie instance2 = CreateZombie.Instance;
			return;
		}
		else
		{
			if (!isMindControlled)
			{
				Transform axis3 = this.axis;
				int theZombieRow = this.theZombieRow;
				CreateZombie instance3 = CreateZombie.Instance;
				return;
			}
			Zombie zombie;
			if (zombie.read == 0)
			{
			}
			CreateZombie instance4 = CreateZombie.Instance;
			throw new NullReferenceException();
		}
	}

	// Token: 0x06002468 RID: 9320 RVA: 0x000BDA6C File Offset: 0x000BBC6C
	[Token(Token = "0x6002468")]
	[Address(RVA = "0x591EA0", Offset = "0x5904A0", VA = "0x180591EA0", Slot = "33")]
	protected override void LoseHeadEvent()
	{
		if (this.attributeCountDown > 12f)
		{
			base.Die(2);
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
		}
	}

	// Token: 0x06002469 RID: 9321 RVA: 0x000BDAB4 File Offset: 0x000BBCB4
	[Token(Token = "0x6002469")]
	[Address(RVA = "0x592010", Offset = "0x590610", VA = "0x180592010")]
	public WhiteFootball()
	{
	}
}
