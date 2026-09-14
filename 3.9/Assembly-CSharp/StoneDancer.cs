using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000706 RID: 1798
[Token(Token = "0x2000706")]
public class StoneDancer : MoneyZombie
{
	// Token: 0x06002367 RID: 9063 RVA: 0x000B8D68 File Offset: 0x000B6F68
	[Token(Token = "0x6002367")]
	[Address(RVA = "0x5D53A0", Offset = "0x5D39A0", VA = "0x1805D53A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 15f;
	}

	// Token: 0x06002368 RID: 9064 RVA: 0x000B8D88 File Offset: 0x000B6F88
	[Token(Token = "0x6002368")]
	[Address(RVA = "0x5D5220", Offset = "0x5D3820", VA = "0x1805D5220", Slot = "24")]
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
			long theHealth = this.theHealth;
			component.theMaxHealth = theHealth;
			long theHealth2 = this.theHealth;
			component.theHealth = theHealth2;
		}
		base.Die(2);
	}

	// Token: 0x06002369 RID: 9065 RVA: 0x000B8DFC File Offset: 0x000B6FFC
	[Token(Token = "0x6002369")]
	[Address(RVA = "0x5D53C0", Offset = "0x5D39C0", VA = "0x1805D53C0", Slot = "29")]
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

	// Token: 0x0600236A RID: 9066 RVA: 0x000B8E3C File Offset: 0x000B703C
	[Token(Token = "0x600236A")]
	[Address(RVA = "0x5D5470", Offset = "0x5D3A70", VA = "0x1805D5470")]
	public StoneDancer()
	{
	}
}
