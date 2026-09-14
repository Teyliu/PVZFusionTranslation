using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000199 RID: 409
[Token(Token = "0x2000199")]
public class Bullet_silverCoin : Bullet
{
	// Token: 0x0600072B RID: 1835 RVA: 0x0002508C File Offset: 0x0002328C
	[Token(Token = "0x600072B")]
	[Address(RVA = "0x7DFDA0", Offset = "0x7DE3A0", VA = "0x1807DFDA0", Slot = "25")]
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

	// Token: 0x0600072C RID: 1836 RVA: 0x00025120 File Offset: 0x00023320
	[Token(Token = "0x600072C")]
	[Address(RVA = "0x7DFC90", Offset = "0x7DE290", VA = "0x1807DFC90", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00025154 File Offset: 0x00023354
	[Token(Token = "0x600072D")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_silverCoin()
	{
	}
}
