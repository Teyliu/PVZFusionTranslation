using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000355 RID: 853
[Token(Token = "0x2000355")]
public class CactusCaltrop : Caltrop
{
	// Token: 0x06000F9C RID: 3996 RVA: 0x0005A730 File Offset: 0x00058930
	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x41EBD0", Offset = "0x41D1D0", VA = "0x18041EBD0", Slot = "48")]
	protected override bool SearchUniqueZombie(Zombie zombie)
	{
		return base.SearchUniqueZombie(zombie) || zombie.theStatus == ZombieStatus.Flying;
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0005A75C File Offset: 0x0005895C
	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x41E8A0", Offset = "0x41CEA0", VA = "0x18041E8A0", Slot = "72")]
	protected override void AnimAttack()
	{
		int num = 0;
		base.KillCar();
		int num2 = 0;
		Collider2D[] cols = base.Cols;
		if (num < cols.Length)
		{
			if (base.TryGetComponent<Zombie>(num))
			{
				int thePlantRow = this.thePlantRow;
				if (this.SearchUniqueZombie(num))
				{
					base.OnAttack(num);
				}
			}
			num++;
		}
		if (num2 != 0)
		{
			uint num3;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num3), 0.5f, 1f);
		}
		Transform axis = this.axis;
		CreateBullet instance = CreateBullet.Instance;
		Transform axis2 = this.axis;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		Transform transform = bullet.transform;
		uint num4;
		num4 += (uint)30;
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x0005A818 File Offset: 0x00058A18
	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x41CBF0", Offset = "0x41B1F0", VA = "0x18041CBF0")]
	public CactusCaltrop()
	{
		this.range = 1f;
		base..ctor();
	}
}
