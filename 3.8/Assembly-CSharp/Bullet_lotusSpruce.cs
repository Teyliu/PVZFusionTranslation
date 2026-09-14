using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000163 RID: 355
[Token(Token = "0x2000163")]
public class Bullet_lotusSpruce : Bullet
{
	// Token: 0x06000667 RID: 1639 RVA: 0x00021CB0 File Offset: 0x0001FEB0
	[Token(Token = "0x6000667")]
	[Address(RVA = "0x6C8F20", Offset = "0x6C7520", VA = "0x1806C8F20", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		base.PlaySound(zombie);
		this.AttackZombies();
		base.Die();
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00021CD0 File Offset: 0x0001FED0
	[Token(Token = "0x6000668")]
	[Address(RVA = "0x6C8F00", Offset = "0x6C7500", VA = "0x1806C8F00", Slot = "18")]
	public override void HitLand()
	{
		this.AttackZombies();
		base.Die();
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00021CEC File Offset: 0x0001FEEC
	[Token(Token = "0x6000669")]
	[Address(RVA = "0x6C8C00", Offset = "0x6C7200", VA = "0x1806C8C00")]
	private void AttackZombies()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				PlantType fromType = this.fromType;
			}
			num3++;
		}
		ParticleManager instance = ParticleManager.Instance;
		Transform transform2 = base.transform;
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00021D5C File Offset: 0x0001FF5C
	[Token(Token = "0x600066A")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_lotusSpruce()
	{
	}
}
