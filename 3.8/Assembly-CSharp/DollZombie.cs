using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000647 RID: 1607
[Token(Token = "0x2000647")]
public class DollZombie : ConeZombie
{
	// Token: 0x06001E7D RID: 7805 RVA: 0x000A2FA4 File Offset: 0x000A11A4
	[Token(Token = "0x6001E7D")]
	[Address(RVA = "0x53B240", Offset = "0x539840", VA = "0x18053B240", Slot = "62")]
	protected override void FirstArmorFall()
	{
		this.SummonZombie();
		base.FirstArmorFall();
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x000A2FC0 File Offset: 0x000A11C0
	[Token(Token = "0x6001E7E")]
	[Address(RVA = "0x53B5A0", Offset = "0x539BA0", VA = "0x18053B5A0")]
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
		if (zombie.read == num)
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

	// Token: 0x06001E7F RID: 7807 RVA: 0x000A3044 File Offset: 0x000A1244
	[Token(Token = "0x6001E7F")]
	[Address(RVA = "0x53AD90", Offset = "0x539390", VA = "0x18053AD90", Slot = "61")]
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

	// Token: 0x06001E80 RID: 7808 RVA: 0x000A3134 File Offset: 0x000A1334
	[Token(Token = "0x6001E80")]
	[Address(RVA = "0x53AC00", Offset = "0x539200", VA = "0x18053AC00")]
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

	// Token: 0x06001E81 RID: 7809 RVA: 0x000A31B0 File Offset: 0x000A13B0
	[Token(Token = "0x6001E81")]
	[Address(RVA = "0x53B280", Offset = "0x539880", VA = "0x18053B280")]
	private void GoldSpirte()
	{
		int num = this.theFirstArmorMaxHealth;
		num += num;
		GameObject theFirstArmor = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theFirstArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[46];
		component.sprite = sprite;
		sprite += sprite;
		GameObject theFirstArmor2 = this.theFirstArmor;
		this.theFirstArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theFirstArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[47];
		component2.sprite = sprite2;
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x000A3230 File Offset: 0x000A1430
	[Token(Token = "0x6001E82")]
	[Address(RVA = "0x53B410", Offset = "0x539A10", VA = "0x18053B410")]
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

	// Token: 0x06001E83 RID: 7811 RVA: 0x000A32AC File Offset: 0x000A14AC
	[Token(Token = "0x6001E83")]
	[Address(RVA = "0x5302B0", Offset = "0x52E8B0", VA = "0x1805302B0")]
	public DollZombie()
	{
	}
}
