using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000407 RID: 1031
[Token(Token = "0x2000407")]
public class NutBlover : Plant
{
	// Token: 0x06001300 RID: 4864 RVA: 0x0006A7BC File Offset: 0x000689BC
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x470EC0", Offset = "0x46F4C0", VA = "0x180470EC0", Slot = "28")]
	protected override void ReplaceSprite()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x0006A7E8 File Offset: 0x000689E8
	[Token(Token = "0x6001301")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x0006A7F8 File Offset: 0x000689F8
	[Token(Token = "0x6001302")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x0006A808 File Offset: 0x00068A08
	[Token(Token = "0x6001303")]
	[Address(RVA = "0x4AC110", Offset = "0x4AA710", VA = "0x1804AC110", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active && this.lastTakeDamgeTime > 10f)
		{
			int thePlantMaxHealth = this.thePlantMaxHealth;
		}
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x0006A83C File Offset: 0x00068A3C
	[Token(Token = "0x6001304")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public NutBlover()
	{
	}
}
