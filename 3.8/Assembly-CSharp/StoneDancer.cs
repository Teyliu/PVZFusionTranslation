using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CE RID: 1742
[Token(Token = "0x20006CE")]
public class StoneDancer : MoneyZombie
{
	// Token: 0x0600224D RID: 8781 RVA: 0x000B3FD4 File Offset: 0x000B21D4
	[Token(Token = "0x600224D")]
	[Address(RVA = "0x571D40", Offset = "0x570340", VA = "0x180571D40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 15f;
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x000B3FF4 File Offset: 0x000B21F4
	[Token(Token = "0x600224E")]
	[Address(RVA = "0x571BD0", Offset = "0x5701D0", VA = "0x180571BD0", Slot = "23")]
	protected override void AttributeEvent()
	{
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		Zombie zombie;
		if (zombie != num)
		{
			Zombie component = zombie.GetComponent<Zombie>();
			Corner targetCorner = this.targetCorner;
			component.targetCorner = targetCorner;
			int theHealth = this.theHealth;
			component.theMaxHealth = theHealth;
			int theHealth2 = this.theHealth;
			component.theHealth = theHealth2;
		}
		base.Die(2);
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x000B4068 File Offset: 0x000B2268
	[Token(Token = "0x600224F")]
	[Address(RVA = "0x571D60", Offset = "0x570360", VA = "0x180571D60", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x000B40A8 File Offset: 0x000B22A8
	[Token(Token = "0x6002250")]
	[Address(RVA = "0x571E10", Offset = "0x570410", VA = "0x180571E10")]
	public StoneDancer()
	{
	}
}
