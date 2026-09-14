using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006B5 RID: 1717
[Token(Token = "0x20006B5")]
public class IceZombie : Zombie
{
	// Token: 0x060020EC RID: 8428 RVA: 0x000AE0C0 File Offset: 0x000AC2C0
	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x000AE0D0 File Offset: 0x000AC2D0
	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x5B3AF0", Offset = "0x5B20F0", VA = "0x1805B3AF0", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		global::UnityEngine.Object.Destroy(this.theFirstArmor);
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x000AE110 File Offset: 0x000AC310
	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x5B3A50", Offset = "0x5B2050", VA = "0x1805B3A50", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x000AE150 File Offset: 0x000AC350
	[Token(Token = "0x60020EF")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x000AE16C File Offset: 0x000AC36C
	[Token(Token = "0x60020F0")]
	[Address(RVA = "0x5B3BD0", Offset = "0x5B21D0", VA = "0x1805B3BD0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x000AE188 File Offset: 0x000AC388
	[Token(Token = "0x60020F1")]
	[Address(RVA = "0x5B3BF0", Offset = "0x5B21F0", VA = "0x1805B3BF0")]
	public IceZombie()
	{
	}
}
