using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200064D RID: 1613
[Token(Token = "0x200064D")]
public class DoorZombie : ArmorZombie
{
	// Token: 0x06001EA0 RID: 7840 RVA: 0x000A3A48 File Offset: 0x000A1C48
	[Token(Token = "0x6001EA0")]
	[Address(RVA = "0x53CF60", Offset = "0x53B560", VA = "0x18053CF60", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x000A3A5C File Offset: 0x000A1C5C
	[Token(Token = "0x6001EA1")]
	[Address(RVA = "0x53D010", Offset = "0x53B610", VA = "0x18053D010", Slot = "74")]
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

	// Token: 0x06001EA2 RID: 7842 RVA: 0x000A3AC8 File Offset: 0x000A1CC8
	[Token(Token = "0x6001EA2")]
	[Address(RVA = "0x53D140", Offset = "0x53B740", VA = "0x18053D140", Slot = "64")]
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

	// Token: 0x06001EA3 RID: 7843 RVA: 0x000A3B44 File Offset: 0x000A1D44
	[Token(Token = "0x6001EA3")]
	[Address(RVA = "0x53D2D0", Offset = "0x53B8D0", VA = "0x18053D2D0", Slot = "34")]
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

	// Token: 0x06001EA4 RID: 7844 RVA: 0x000A3C20 File Offset: 0x000A1E20
	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0x53CF90", Offset = "0x53B590", VA = "0x18053CF90")]
	public void DestoryHand()
	{
		global::UnityEngine.Object.Destroy(this.hand1);
		global::UnityEngine.Object.Destroy(this.hand2);
		global::UnityEngine.Object.Destroy(this.hand3);
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x000A3C50 File Offset: 0x000A1E50
	[Token(Token = "0x6001EA5")]
	[Address(RVA = "0x5302B0", Offset = "0x52E8B0", VA = "0x1805302B0")]
	public DoorZombie()
	{
	}

	// Token: 0x0400105C RID: 4188
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400105C")]
	private GameObject hand1;

	// Token: 0x0400105D RID: 4189
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400105D")]
	private GameObject hand2;

	// Token: 0x0400105E RID: 4190
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400105E")]
	private GameObject hand3;
}
