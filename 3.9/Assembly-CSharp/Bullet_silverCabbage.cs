using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200019F RID: 415
[Token(Token = "0x200019F")]
public class Bullet_silverCabbage : Bullet_cabbage
{
	// Token: 0x06000734 RID: 1844 RVA: 0x0002490C File Offset: 0x00022B0C
	[Token(Token = "0x6000734")]
	[Address(RVA = "0x80D3B0", Offset = "0x80B9B0", VA = "0x18080D3B0", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		this.miusa = false;
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00024928 File Offset: 0x00022B28
	[Token(Token = "0x6000735")]
	[Address(RVA = "0x80D280", Offset = "0x80B880", VA = "0x18080D280", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		if (this.miusa)
		{
			int theFirstArmorHealth = zombie.theFirstArmorHealth;
		}
		PlantType fromType = this.fromType;
		Transform transform = base.transform;
		uint num;
		Transform transform2 = num.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x0002497C File Offset: 0x00022B7C
	[Token(Token = "0x6000736")]
	[Address(RVA = "0x80D170", Offset = "0x80B770", VA = "0x18080D170", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x000249B0 File Offset: 0x00022BB0
	[Token(Token = "0x6000737")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_silverCabbage()
	{
	}

	// Token: 0x0400039B RID: 923
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400039B")]
	public bool miusa;
}
