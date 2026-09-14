using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000397 RID: 919
[Token(Token = "0x2000397")]
public class EndoFlameGirl : Shooter
{
	// Token: 0x060010E4 RID: 4324 RVA: 0x00060190 File Offset: 0x0005E390
	[Token(Token = "0x60010E4")]
	[Address(RVA = "0x487660", Offset = "0x485C60", VA = "0x180487660", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int num4;
		Bullet bullet;
		do
		{
			int num = 0;
			int num2 = 0;
			List<PlantType> allPlantTypes = Lawnf.GetAllPlantTypes();
			bool flag;
			if (flag)
			{
				EndoFlameGirl.<>c__DisplayClass1_0 CS$<>8__locals1;
				CS$<>8__locals1.item = (PlantType)num;
				if (!Lawnf.IsUltiPlant((PlantType)num))
				{
					continue;
				}
				List<Plant> plantHead = this.board.boardEntity.plantHead;
				Func<Plant, bool> func = delegate(Plant p)
				{
					PlantType item = CS$<>8__locals1.item;
					return p.thePlantType == item;
				};
				Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, func);
				int num3 = 0;
				if (!(plant != num3))
				{
					continue;
				}
				num2++;
			}
			if (num2 != 0)
			{
				goto IL_00CE;
			}
			num4 = 0;
			bool flag2;
			if (flag2)
			{
				CreateBullet instance = CreateBullet.Instance;
				bullet.Damage = num;
				bullet.theStatus = (BulletStatus)((ulong)3L);
				bullet.fromType = bullet;
			}
		}
		while (num4 != 0);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		return bullet;
		IL_00CE:
		throw new NullReferenceException();
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00060280 File Offset: 0x0005E480
	[Token(Token = "0x60010E5")]
	[Address(RVA = "0x4873A0", Offset = "0x4859A0", VA = "0x1804873A0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (base.Shootable())
		{
			this.anim.SetTrigger("shoot");
			GameAPP.PlaySound(16, 0.5f, 1f);
			return;
		}
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x000602E0 File Offset: 0x0005E4E0
	[Token(Token = "0x60010E6")]
	[Address(RVA = "0x4874B0", Offset = "0x485AB0", VA = "0x1804874B0", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2 && base.SearchUniqueZombie(num))
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00060334 File Offset: 0x0005E534
	[Token(Token = "0x60010E7")]
	[Address(RVA = "0x487B60", Offset = "0x486160", VA = "0x180487B60")]
	public EndoFlameGirl()
	{
		List<Transform> list = new List();
		this.shoots = list;
		base..ctor();
	}

	// Token: 0x04000BDB RID: 3035
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BDB")]
	public List<Transform> shoots;
}
