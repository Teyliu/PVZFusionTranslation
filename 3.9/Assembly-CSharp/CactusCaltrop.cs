using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000365 RID: 869
[Token(Token = "0x2000365")]
public class CactusCaltrop : Caltrop
{
	// Token: 0x06000FE8 RID: 4072 RVA: 0x0005B6B0 File Offset: 0x000598B0
	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0x475B10", Offset = "0x474110", VA = "0x180475B10", Slot = "47")]
	protected override bool SearchUniqueZombie(Zombie zombie)
	{
		return base.SearchUniqueZombie(zombie) || zombie.theStatus == ZombieStatus.Flying;
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x0005B6DC File Offset: 0x000598DC
	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x475760", Offset = "0x473D60", VA = "0x180475760", Slot = "71")]
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
		Bullet bullet;
		int size = bullet.hitFilters._size;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		Transform transform = bullet.transform;
		uint num4;
		num4 += (uint)30;
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x0005B7A8 File Offset: 0x000599A8
	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x473A90", Offset = "0x472090", VA = "0x180473A90")]
	public CactusCaltrop()
	{
		this.range = 1f;
		base..ctor();
	}
}
