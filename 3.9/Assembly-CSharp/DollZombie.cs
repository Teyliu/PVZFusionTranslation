using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200067D RID: 1661
[Token(Token = "0x200067D")]
public class DollZombie : ConeZombie
{
	// Token: 0x06001F7F RID: 8063 RVA: 0x000A76F8 File Offset: 0x000A58F8
	[Token(Token = "0x6001F7F")]
	[Address(RVA = "0x59D830", Offset = "0x59BE30", VA = "0x18059D830", Slot = "64")]
	protected override void FirstArmorFall()
	{
		this.SummonZombie();
		base.FirstArmorFall();
	}

	// Token: 0x06001F80 RID: 8064 RVA: 0x000A7714 File Offset: 0x000A5914
	[Token(Token = "0x6001F80")]
	[Address(RVA = "0x59DB90", Offset = "0x59C190", VA = "0x18059DB90")]
	private void SummonZombie()
	{
		int num = 0;
		Transform axis = this.axis;
		int theZombieType = (int)this.theZombieType;
		if (axis == 0 || axis == 0 || theZombieType == 1)
		{
		}
		Transform axis2 = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		Zombie zombie;
		if (zombie.takeDmgMultiplier == (float)num)
		{
		}
		Transform axis3 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		Corner targetCorner = this.targetCorner;
		Zombie zombie2;
		zombie2.targetCorner = targetCorner;
		Transform axis4 = this.axis;
		ParticleManager instance3 = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x000A7798 File Offset: 0x000A5998
	[Token(Token = "0x6001F81")]
	[Address(RVA = "0x59D380", Offset = "0x59B980", VA = "0x18059D380", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		if (this.theZombieType == ZombieType.FlagZombie)
		{
			int num = this.theFirstArmorMaxHealth;
			num += num;
			GameObject theFirstArmor = this.theFirstArmor;
			this.theFirstArmorBroken = (int)((ulong)1L);
			SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
			Sprite sprite = GameAPP.spritePrefab[48];
			component.sprite = sprite;
			GameObject theFirstArmor2 = this.theFirstArmor;
			this.theFirstArmorBroken = (int)((ulong)2L);
			SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
			Sprite sprite2 = GameAPP.spritePrefab[49];
			component2.sprite = sprite2;
		}
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x000A7888 File Offset: 0x000A5A88
	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x59D1F0", Offset = "0x59B7F0", VA = "0x18059D1F0")]
	private void DiamondSpirte()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[44];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[45];
		component2.sprite = sprite2;
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x000A7904 File Offset: 0x000A5B04
	[Token(Token = "0x6001F83")]
	[Address(RVA = "0x59D870", Offset = "0x59BE70", VA = "0x18059D870")]
	private void GoldSpirte()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[46];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[47];
		component2.sprite = sprite2;
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x000A7980 File Offset: 0x000A5B80
	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x59DA00", Offset = "0x59C000", VA = "0x18059DA00")]
	private void SilverSpirte()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[48];
		component.sprite = sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[49];
		component2.sprite = sprite2;
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x000A79FC File Offset: 0x000A5BFC
	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x59C5A0", Offset = "0x59ABA0", VA = "0x18059C5A0")]
	public DollZombie()
	{
	}
}
