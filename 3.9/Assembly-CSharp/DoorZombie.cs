using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000683 RID: 1667
[Token(Token = "0x2000683")]
public class DoorZombie : ArmorZombie
{
	// Token: 0x06001FA2 RID: 8098 RVA: 0x000A8194 File Offset: 0x000A6394
	[Token(Token = "0x6001FA2")]
	[Address(RVA = "0x59F550", Offset = "0x59DB50", VA = "0x18059F550", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x000A81A8 File Offset: 0x000A63A8
	[Token(Token = "0x6001FA3")]
	[Address(RVA = "0x59F600", Offset = "0x59DC00", VA = "0x18059F600", Slot = "76")]
	protected virtual void GetHand()
	{
		GameObject gameObject = base.transform.Find("Zombie_outerarm_screendoor").gameObject;
		this.hand1 = gameObject;
		GameObject gameObject2 = base.transform.Find("Zombie_innerarm_screendoor_hand").gameObject;
		this.hand2 = gameObject2;
		GameObject gameObject3 = base.transform.Find("Zombie_innerarm_screendoor").gameObject;
		this.hand3 = gameObject3;
		throw new NullReferenceException();
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x000A8214 File Offset: 0x000A6414
	[Token(Token = "0x6001FA4")]
	[Address(RVA = "0x59F730", Offset = "0x59DD30", VA = "0x18059F730", Slot = "66")]
	protected override void SecondArmorBroken()
	{
		int num = this.theSecondArmorMaxHealth;
		num += num;
		GameObject theSecondArmor = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theSecondArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[18];
		component.sprite = sprite;
		GameObject theSecondArmor2 = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theSecondArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[19];
		component2.sprite = sprite2;
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x000A8290 File Offset: 0x000A6490
	[Token(Token = "0x6001FA5")]
	[Address(RVA = "0x59F8C0", Offset = "0x59DEC0", VA = "0x18059F8C0", Slot = "35")]
	protected override void SecondArmorFall()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				GameObject gameObject;
				ulong num2;
				gameObject.SetActive(num2 != 0UL);
				GameObject gameObject2;
				ParticleSystemRenderer component = gameObject2.GetComponent<ParticleSystemRenderer>();
				int theZombieRow = this.theZombieRow;
				string text2 = string.Format("zombie{0}", component);
				component.sortingLayerName = text2;
				GameObject gameObject3;
				ParticleSystemRenderer component2 = gameObject3.GetComponent<ParticleSystemRenderer>();
				int num3 = this.sortingGroup.sortingOrder + 1;
				component2.sortingOrder = num3;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x000A836C File Offset: 0x000A656C
	[Token(Token = "0x6001FA6")]
	[Address(RVA = "0x59F580", Offset = "0x59DB80", VA = "0x18059F580")]
	public void DestoryHand()
	{
		global::UnityEngine.Object.Destroy(this.hand1);
		global::UnityEngine.Object.Destroy(this.hand2);
		global::UnityEngine.Object.Destroy(this.hand3);
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x000A839C File Offset: 0x000A659C
	[Token(Token = "0x6001FA7")]
	[Address(RVA = "0x59C5A0", Offset = "0x59ABA0", VA = "0x18059C5A0")]
	public DoorZombie()
	{
	}

	// Token: 0x04001128 RID: 4392
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001128")]
	private GameObject hand1;

	// Token: 0x04001129 RID: 4393
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001129")]
	private GameObject hand2;

	// Token: 0x0400112A RID: 4394
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400112A")]
	private GameObject hand3;
}
