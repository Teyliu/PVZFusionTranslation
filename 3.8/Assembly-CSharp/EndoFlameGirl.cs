using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000384 RID: 900
[Token(Token = "0x2000384")]
public class EndoFlameGirl : Shooter
{
	// Token: 0x0600108F RID: 4239 RVA: 0x0005EE74 File Offset: 0x0005D074
	[Token(Token = "0x600108F")]
	[Address(RVA = "0x433DB0", Offset = "0x4323B0", VA = "0x180433DB0", Slot = "69")]
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
				Func<Plant, bool> func;
				Plant plant = Enumerable.FirstOrDefault<Plant>(this.board.boardEntity.plantHead, func);
				int num3 = 0;
				if (!(plant != num3))
				{
					continue;
				}
				num2++;
			}
			if (num2 != 0)
			{
				goto IL_00BB;
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
		IL_00BB:
		throw new NullReferenceException();
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x0005EF50 File Offset: 0x0005D150
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x433AF0", Offset = "0x4320F0", VA = "0x180433AF0", Slot = "45")]
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

	// Token: 0x06001091 RID: 4241 RVA: 0x0005EFB0 File Offset: 0x0005D1B0
	[Token(Token = "0x6001091")]
	[Address(RVA = "0x433C00", Offset = "0x432200", VA = "0x180433C00", Slot = "44")]
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

	// Token: 0x06001092 RID: 4242 RVA: 0x0005F004 File Offset: 0x0005D204
	[Token(Token = "0x6001092")]
	[Address(RVA = "0x4342B0", Offset = "0x4328B0", VA = "0x1804342B0")]
	public EndoFlameGirl()
	{
		List<Transform> list = new List();
		this.shoots = list;
		base..ctor();
	}

	// Token: 0x04000B84 RID: 2948
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B84")]
	public List<Transform> shoots;
}
