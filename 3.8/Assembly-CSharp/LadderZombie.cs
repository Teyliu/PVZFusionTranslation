using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000697 RID: 1687
[Token(Token = "0x2000697")]
public class LadderZombie : DoorZombie
{
	// Token: 0x060020AA RID: 8362 RVA: 0x000ACC74 File Offset: 0x000AAE74
	[Token(Token = "0x60020AA")]
	[Address(RVA = "0x55B410", Offset = "0x559A10", VA = "0x18055B410", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)18L);
	}

	// Token: 0x060020AB RID: 8363 RVA: 0x000ACC94 File Offset: 0x000AAE94
	[Token(Token = "0x60020AB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected override void GetHand()
	{
	}

	// Token: 0x060020AC RID: 8364 RVA: 0x000ACCA4 File Offset: 0x000AAEA4
	[Token(Token = "0x60020AC")]
	[Address(RVA = "0x55B430", Offset = "0x559A30", VA = "0x18055B430", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x000ACCE4 File Offset: 0x000AAEE4
	[Token(Token = "0x60020AD")]
	[Address(RVA = "0x55B880", Offset = "0x559E80", VA = "0x18055B880", Slot = "64")]
	protected override void SecondArmorBroken()
	{
		int num = this.theSecondArmorMaxHealth;
		num += num;
		SpriteRenderer component = this.theSecondArmor.GetComponent<SpriteRenderer>();
		int num2 = 0;
		component.enabled = num2 != 0;
		Transform transform = this.theSecondArmor.transform;
		int num3 = 0;
		ulong num4;
		transform.GetChild(num3).gameObject.SetActive(num4 != 0UL);
		uint num5;
		GameObject gameObject = this.theSecondArmor.transform.GetChild((int)num5).gameObject;
		int num6 = 0;
		gameObject.SetActive(num6 != 0);
		SpriteRenderer component2 = this.theSecondArmor.GetComponent<SpriteRenderer>();
		int num7 = 0;
		component2.enabled = num7 != 0;
		Transform transform2 = this.theSecondArmor.transform;
		int num8 = 0;
		GameObject gameObject2 = transform2.GetChild(num8).gameObject;
		int num9 = 0;
		gameObject2.SetActive(num9 != 0);
		uint num10;
		ulong num11;
		this.theSecondArmor.transform.GetChild((int)num10).gameObject.SetActive(num11 != 0UL);
	}

	// Token: 0x060020AE RID: 8366 RVA: 0x000ACDC4 File Offset: 0x000AAFC4
	[Token(Token = "0x60020AE")]
	[Address(RVA = "0x55BA90", Offset = "0x55A090", VA = "0x18055BA90", Slot = "34")]
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
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x000ACE9C File Offset: 0x000AB09C
	[Token(Token = "0x60020AF")]
	[Address(RVA = "0x55B710", Offset = "0x559D10", VA = "0x18055B710")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
			int num = 0;
			GridItem gridItem;
			bool flag2;
			if (gridItem == num && !flag2)
			{
				this.anim.SetTrigger("ladder");
				ulong num2;
				this.ladderTarget = num2;
			}
		}
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x000ACEE8 File Offset: 0x000AB0E8
	[Token(Token = "0x60020B0")]
	[Address(RVA = "0x55B580", Offset = "0x559B80", VA = "0x18055B580", Slot = "39")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
			int num = 0;
			GridItem gridItem;
			bool flag2;
			if (gridItem == num && !flag2)
			{
				this.anim.SetTrigger("ladder");
				ulong num2;
				this.ladderTarget = num2;
			}
		}
		base.OnTriggerEnter2D(collision);
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x000ACF38 File Offset: 0x000AB138
	[Token(Token = "0x60020B1")]
	[Address(RVA = "0x55B1A0", Offset = "0x5597A0", VA = "0x18055B1A0", Slot = "75")]
	protected virtual void AnimSetLadder()
	{
		Plant plant = this.ladderTarget;
		int num = 0;
		if (plant != num)
		{
			GridItem ladder = this.ladderTarget.Ladder;
			int num2 = 0;
			if (ladder == num2)
			{
				Plant plant2 = this.ladderTarget;
				int num3 = 0;
				int thePlantColumn = plant2.thePlantColumn;
				GameObject theSecondArmor = this.theSecondArmor;
				this.theStatus = (ZombieStatus)num3;
				global::UnityEngine.Object.Destroy(theSecondArmor);
				this.theSecondArmor = num3;
				Animator anim = this.anim;
				this.theSecondArmorHealth = num3;
				this.theSecondArmorType = (Zombie.SecondArmorType)num3;
				anim.SetTrigger("ladderOver");
				Mouse instance = Mouse.Instance;
				Plant plant3 = this.ladderTarget;
				if (instance.thePlantOnGlove == plant3)
				{
					global::UnityEngine.Object.Destroy(Mouse.Instance.theItemOnMouse);
					Mouse.Instance.theItemOnMouse = num3;
					Mouse.Instance.thePlantTypeOnMouse = (PlantType)((ulong)4294967295L);
					Mouse.Instance.thePlantOnGlove = num3;
				}
				return;
			}
		}
		this.anim.SetTrigger("back");
	}

	// Token: 0x060020B2 RID: 8370 RVA: 0x000AD040 File Offset: 0x000AB240
	[Token(Token = "0x60020B2")]
	[Address(RVA = "0x55B4D0", Offset = "0x559AD0", VA = "0x18055B4D0")]
	public void LoseLadder()
	{
		this.anim.SetTrigger("loseLadder");
		GameObject theSecondArmor = this.theSecondArmor;
		this.theStatus = (ZombieStatus)((ulong)0L);
		global::UnityEngine.Object.Destroy(theSecondArmor);
		this.theSecondArmor = (ulong)0L;
		this.theSecondArmorType = (Zombie.SecondArmorType)((ulong)0L);
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x000AD08C File Offset: 0x000AB28C
	[Token(Token = "0x60020B3")]
	[Address(RVA = "0x55BE80", Offset = "0x55A480", VA = "0x18055BE80")]
	public LadderZombie()
	{
	}

	// Token: 0x040010DA RID: 4314
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40010DA")]
	protected Plant ladderTarget;
}
