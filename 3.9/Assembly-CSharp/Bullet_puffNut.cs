using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000190 RID: 400
[Token(Token = "0x2000190")]
public class Bullet_puffNut : Bullet_pierce
{
	// Token: 0x060006F7 RID: 1783 RVA: 0x0002393C File Offset: 0x00021B3C
	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x6E9CA0", Offset = "0x6E82A0", VA = "0x1806E9CA0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)1000000L);
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00023958 File Offset: 0x00021B58
	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x80A4C0", Offset = "0x808AC0", VA = "0x18080A4C0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		long currentFirstHealth = zombie.CurrentFirstHealth;
		PlantType fromType = this.fromType;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		int num = this._damage;
		int num2 = currentFirstHealth.ToInt();
		num -= num2;
		this._damage = num;
		base.Die();
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x000239B8 File Offset: 0x00021BB8
	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x80A3E0", Offset = "0x8089E0", VA = "0x18080A3E0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x000239E4 File Offset: 0x00021BE4
	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_puffNut()
	{
	}
}
