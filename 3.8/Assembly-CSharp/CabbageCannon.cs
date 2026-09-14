using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000351 RID: 849
[Token(Token = "0x2000351")]
public class CabbageCannon : Thrower
{
	// Token: 0x06000F89 RID: 3977 RVA: 0x0005A0D8 File Offset: 0x000582D8
	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x41CE10", Offset = "0x41B410", VA = "0x18041CE10", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage;
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x0005A0E8 File Offset: 0x000582E8
	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x41CE20", Offset = "0x41B420", VA = "0x18041CE20")]
	protected Vector2 GetPositon(Vector2 v)
	{
		float num = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		float num2 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		return default(Vector2);
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x0005A120 File Offset: 0x00058320
	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x41D8A0", Offset = "0x41BEA0", VA = "0x18041D8A0", Slot = "75")]
	protected override Zombie ThrowerSearchZombie()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				float vision = this.vision;
				if (!base.CheckRange(num) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x0005A18C File Offset: 0x0005838C
	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x41CC10", Offset = "0x41B210", VA = "0x18041CC10", Slot = "14")]
	protected override bool DetactiveEnermy()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				float vision = this.vision;
				if (!base.CheckRange(num) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x0005A1F8 File Offset: 0x000583F8
	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x41CE90", Offset = "0x41B490", VA = "0x18041CE90", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int num9;
		do
		{
			int num = 0;
			List<Zombie> list = new List();
			List<Zombie> zombieArray = this.board.zombieArray;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
			if (num2 != 0)
			{
				goto IL_013E;
			}
			int num4 = 0;
			int num5 = 0;
			Plant plant;
			if (plant != num5)
			{
				Transform axis2 = plant.axis;
				Vector3 vector;
				float z = vector.z;
				bool flag2;
				if (flag2)
				{
					float num6 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
					float num7 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
					CreateBullet instance = CreateBullet.Instance;
					int num8 = 0;
					Bullet bullet;
					bullet.fromType = (PlantType)num8;
				}
				if (num4 != 0)
				{
					goto IL_0162;
				}
				num9 = 0;
			}
			bool flag3;
			if (flag3)
			{
				float num6 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
				float num10 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
				CreateBullet instance2 = CreateBullet.Instance;
				int num11 = 0;
				Bullet bullet2;
				bullet2.Damage = num;
				bullet2.fromType = (PlantType)num11;
			}
		}
		while (num9 != 0);
		float num12 = global::UnityEngine.Random.Range(0.9f, 1.2f);
		uint num13;
		GameAPP.PlaySound((int)num13, 0.5f, num12);
		throw new NullReferenceException();
		IL_013E:
		throw new NullReferenceException();
		IL_0162:
		throw new NullReferenceException();
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x0005A37C File Offset: 0x0005857C
	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public CabbageCannon()
	{
	}
}
