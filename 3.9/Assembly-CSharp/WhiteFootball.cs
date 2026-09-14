using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200074C RID: 1868
[Token(Token = "0x200074C")]
public class WhiteFootball : Zombie
{
	// Token: 0x06002584 RID: 9604 RVA: 0x000C278C File Offset: 0x000C098C
	[Token(Token = "0x6002584")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x000C279C File Offset: 0x000C099C
	[Token(Token = "0x6002585")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x06002586 RID: 9606 RVA: 0x000C27AC File Offset: 0x000C09AC
	[Token(Token = "0x6002586")]
	[Address(RVA = "0x5D53A0", Offset = "0x5D39A0", VA = "0x1805D53A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 15f;
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x000C27CC File Offset: 0x000C09CC
	[Token(Token = "0x6002587")]
	[Address(RVA = "0x60BD40", Offset = "0x60A340", VA = "0x18060BD40", Slot = "24")]
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
			if (zombie.takeDmgMultiplier == 0f)
			{
			}
			CreateZombie instance4 = CreateZombie.Instance;
			throw new NullReferenceException();
		}
	}

	// Token: 0x06002588 RID: 9608 RVA: 0x000C2858 File Offset: 0x000C0A58
	[Token(Token = "0x6002588")]
	[Address(RVA = "0x60BFC0", Offset = "0x60A5C0", VA = "0x18060BFC0", Slot = "34")]
	protected override void LoseHeadEvent()
	{
		if (this.attributeCountDown > 12f)
		{
			base.Die(2);
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
		}
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x000C28A0 File Offset: 0x000C0AA0
	[Token(Token = "0x6002589")]
	[Address(RVA = "0x60C130", Offset = "0x60A730", VA = "0x18060C130")]
	public WhiteFootball()
	{
	}
}
