using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E3 RID: 1763
[Token(Token = "0x20006E3")]
public class PaperZombie : ArmorZombie
{
	// Token: 0x06002267 RID: 8807 RVA: 0x000B48E4 File Offset: 0x000B2AE4
	[Token(Token = "0x6002267")]
	[Address(RVA = "0x5C7230", Offset = "0x5C5830", VA = "0x1805C7230", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.theStatus = (ZombieStatus)((ulong)4L);
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x000B4900 File Offset: 0x000B2B00
	[Token(Token = "0x6002268")]
	[Address(RVA = "0x5C75C0", Offset = "0x5C5BC0", VA = "0x1805C75C0", Slot = "66")]
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

	// Token: 0x06002269 RID: 8809 RVA: 0x000B497C File Offset: 0x000B2B7C
	[Token(Token = "0x6002269")]
	[Address(RVA = "0x5C7740", Offset = "0x5C5D40", VA = "0x1805C7740", Slot = "35")]
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

	// Token: 0x0600226A RID: 8810 RVA: 0x000B4A64 File Offset: 0x000B2C64
	[Token(Token = "0x600226A")]
	[Address(RVA = "0x5C7520", Offset = "0x5C5B20", VA = "0x1805C7520", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[5];
		component.sprite = sprite;
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x000B4A94 File Offset: 0x000B2C94
	[Token(Token = "0x600226B")]
	[Address(RVA = "0x5C7490", Offset = "0x5C5A90", VA = "0x1805C7490", Slot = "76")]
	public virtual void AngrySound()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(45, 47), 0.5f, 1f);
		base.ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x000B4AC4 File Offset: 0x000B2CC4
	[Token(Token = "0x600226C")]
	[Address(RVA = "0x5C5740", Offset = "0x5C3D40", VA = "0x1805C5740", Slot = "77")]
	protected virtual void Angry()
	{
		base.ChangeStatus((ZombieStatus)((uint)6));
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x000B4ADC File Offset: 0x000B2CDC
	[Token(Token = "0x600226D")]
	[Address(RVA = "0x59C5A0", Offset = "0x59ABA0", VA = "0x18059C5A0")]
	public PaperZombie()
	{
	}
}
