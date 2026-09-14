using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A0 RID: 416
[Token(Token = "0x20001A0")]
public class Bullet_silverCoin : Bullet
{
	// Token: 0x06000738 RID: 1848 RVA: 0x000249C4 File Offset: 0x00022BC4
	[Token(Token = "0x6000738")]
	[Address(RVA = "0x80D4E0", Offset = "0x80BAE0", VA = "0x18080D4E0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Board board = this.board;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		this.board.GetMoney(10f);
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)21)))
		{
			int num = 0;
			int damage = this._damage;
			PlantType fromType = this.fromType;
			ulong num2;
			zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		}
		int num3 = 0;
		base.FireZombie(zombie, num3 != 0);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00024A58 File Offset: 0x00022C58
	[Token(Token = "0x6000739")]
	[Address(RVA = "0x80D3D0", Offset = "0x80B9D0", VA = "0x18080D3D0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00024A8C File Offset: 0x00022C8C
	[Token(Token = "0x600073A")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_silverCoin()
	{
	}
}
