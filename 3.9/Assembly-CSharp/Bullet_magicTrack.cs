using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016C RID: 364
[Token(Token = "0x200016C")]
public class Bullet_magicTrack : Bullet
{
	// Token: 0x0600067D RID: 1661 RVA: 0x000218B8 File Offset: 0x0001FAB8
	[Token(Token = "0x600067D")]
	[Address(RVA = "0x6F4C90", Offset = "0x6F3290", VA = "0x1806F4C90", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		GameAPP.PlaySound(80, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00021900 File Offset: 0x0001FB00
	[Token(Token = "0x600067E")]
	[Address(RVA = "0x6F4C10", Offset = "0x6F3210", VA = "0x1806F4C10", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x0002192C File Offset: 0x0001FB2C
	[Token(Token = "0x600067F")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_magicTrack()
	{
	}
}
