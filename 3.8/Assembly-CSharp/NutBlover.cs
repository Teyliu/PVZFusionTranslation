using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003ED RID: 1005
[Token(Token = "0x20003ED")]
public class NutBlover : Plant
{
	// Token: 0x0600128D RID: 4749 RVA: 0x00068A10 File Offset: 0x00066C10
	[Token(Token = "0x600128D")]
	[Address(RVA = "0x419FF0", Offset = "0x4185F0", VA = "0x180419FF0", Slot = "29")]
	protected override void ReplaceSprite()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x00068A3C File Offset: 0x00066C3C
	[Token(Token = "0x600128E")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x00068A4C File Offset: 0x00066C4C
	[Token(Token = "0x600128F")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x00068A5C File Offset: 0x00066C5C
	[Token(Token = "0x6001290")]
	[Address(RVA = "0x456C80", Offset = "0x455280", VA = "0x180456C80", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active && this.lastTakeDamgeTime > 10f)
		{
			int thePlantMaxHealth = this.thePlantMaxHealth;
		}
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x00068A90 File Offset: 0x00066C90
	[Token(Token = "0x6001291")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public NutBlover()
	{
	}
}
