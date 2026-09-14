using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CE RID: 1742
[Token(Token = "0x20006CE")]
public class LadderZombie : DoorZombie
{
	// Token: 0x060021C1 RID: 8641 RVA: 0x000B18BC File Offset: 0x000AFABC
	[Token(Token = "0x60021C1")]
	[Address(RVA = "0x5BE160", Offset = "0x5BC760", VA = "0x1805BE160", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)18L);
	}

	// Token: 0x060021C2 RID: 8642 RVA: 0x000B18DC File Offset: 0x000AFADC
	[Token(Token = "0x60021C2")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected override void GetHand()
	{
	}

	// Token: 0x060021C3 RID: 8643 RVA: 0x000B18EC File Offset: 0x000AFAEC
	[Token(Token = "0x60021C3")]
	[Address(RVA = "0x5BE180", Offset = "0x5BC780", VA = "0x1805BE180", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x000B192C File Offset: 0x000AFB2C
	[Token(Token = "0x60021C4")]
	[Address(RVA = "0x5BE5D0", Offset = "0x5BCBD0", VA = "0x1805BE5D0", Slot = "66")]
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

	// Token: 0x060021C5 RID: 8645 RVA: 0x000B1A0C File Offset: 0x000AFC0C
	[Token(Token = "0x60021C5")]
	[Address(RVA = "0x5BE7E0", Offset = "0x5BCDE0", VA = "0x1805BE7E0", Slot = "35")]
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

	// Token: 0x060021C6 RID: 8646 RVA: 0x000B1AE4 File Offset: 0x000AFCE4
	[Token(Token = "0x60021C6")]
	[Address(RVA = "0x5BE460", Offset = "0x5BCA60", VA = "0x1805BE460")]
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

	// Token: 0x060021C7 RID: 8647 RVA: 0x000B1B30 File Offset: 0x000AFD30
	[Token(Token = "0x60021C7")]
	[Address(RVA = "0x5BE2D0", Offset = "0x5BC8D0", VA = "0x1805BE2D0", Slot = "41")]
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

	// Token: 0x060021C8 RID: 8648 RVA: 0x000B1B80 File Offset: 0x000AFD80
	[Token(Token = "0x60021C8")]
	[Address(RVA = "0x5BDEF0", Offset = "0x5BC4F0", VA = "0x1805BDEF0", Slot = "77")]
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

	// Token: 0x060021C9 RID: 8649 RVA: 0x000B1C88 File Offset: 0x000AFE88
	[Token(Token = "0x60021C9")]
	[Address(RVA = "0x5BE220", Offset = "0x5BC820", VA = "0x1805BE220")]
	public void LoseLadder()
	{
		this.anim.SetTrigger("loseLadder");
		GameObject theSecondArmor = this.theSecondArmor;
		this.theStatus = (ZombieStatus)((ulong)0L);
		global::UnityEngine.Object.Destroy(theSecondArmor);
		this.theSecondArmor = (ulong)0L;
		this.theSecondArmorType = (Zombie.SecondArmorType)((ulong)0L);
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x000B1CD4 File Offset: 0x000AFED4
	[Token(Token = "0x60021CA")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public LadderZombie()
	{
	}

	// Token: 0x040011A7 RID: 4519
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x40011A7")]
	protected Plant ladderTarget;
}
