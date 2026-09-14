using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006AC RID: 1708
[Token(Token = "0x20006AC")]
public class PaperZombie : ArmorZombie
{
	// Token: 0x06002150 RID: 8528 RVA: 0x000AFC3C File Offset: 0x000ADE3C
	[Token(Token = "0x6002150")]
	[Address(RVA = "0x562F10", Offset = "0x561510", VA = "0x180562F10", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.theStatus = (ZombieStatus)((ulong)4L);
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x000AFC58 File Offset: 0x000ADE58
	[Token(Token = "0x6002151")]
	[Address(RVA = "0x563D10", Offset = "0x562310", VA = "0x180563D10", Slot = "64")]
	protected override void SecondArmorBroken()
	{
		int num = this.theSecondArmorMaxHealth;
		num += num;
		GameObject theSecondArmor = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)1L);
		SpriteRenderer component = theSecondArmor.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[6];
		component.sprite = sprite;
		GameObject theSecondArmor2 = this.theSecondArmor;
		this.theSecondArmorBroken = (int)((ulong)2L);
		SpriteRenderer component2 = theSecondArmor2.GetComponent<SpriteRenderer>();
		Sprite sprite2 = GameAPP.spritePrefab[7];
		component2.sprite = sprite2;
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x000AFCD4 File Offset: 0x000ADED4
	[Token(Token = "0x6002152")]
	[Address(RVA = "0x563E90", Offset = "0x562490", VA = "0x180563E90", Slot = "34")]
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
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x000AFDBC File Offset: 0x000ADFBC
	[Token(Token = "0x6002153")]
	[Address(RVA = "0x563C70", Offset = "0x562270", VA = "0x180563C70", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[5];
		component.sprite = sprite;
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x000AFDEC File Offset: 0x000ADFEC
	[Token(Token = "0x6002154")]
	[Address(RVA = "0x563BE0", Offset = "0x5621E0", VA = "0x180563BE0", Slot = "74")]
	public virtual void AngrySound()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(45, 47), 0.5f, 1f);
		base.ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x000AFE1C File Offset: 0x000AE01C
	[Token(Token = "0x6002155")]
	[Address(RVA = "0x563220", Offset = "0x561820", VA = "0x180563220", Slot = "75")]
	protected virtual void Angry()
	{
		base.ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x000AFE34 File Offset: 0x000AE034
	[Token(Token = "0x6002156")]
	[Address(RVA = "0x55BE80", Offset = "0x55A480", VA = "0x18055BE80")]
	public PaperZombie()
	{
	}
}
