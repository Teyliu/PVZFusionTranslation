using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000361 RID: 865
[Token(Token = "0x2000361")]
public class CabbageCannon : Thrower
{
	// Token: 0x06000FD5 RID: 4053 RVA: 0x0005B058 File Offset: 0x00059258
	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x473CB0", Offset = "0x4722B0", VA = "0x180473CB0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage;
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x0005B068 File Offset: 0x00059268
	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x473CC0", Offset = "0x4722C0", VA = "0x180473CC0")]
	protected Vector2 GetPositon(Vector2 v)
	{
		float num = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		float num2 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		return default(Vector2);
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x0005B0A0 File Offset: 0x000592A0
	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x474740", Offset = "0x472D40", VA = "0x180474740", Slot = "74")]
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

	// Token: 0x06000FD8 RID: 4056 RVA: 0x0005B10C File Offset: 0x0005930C
	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x473AB0", Offset = "0x4720B0", VA = "0x180473AB0", Slot = "14")]
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

	// Token: 0x06000FD9 RID: 4057 RVA: 0x0005B178 File Offset: 0x00059378
	[Token(Token = "0x6000FD9")]
	[Address(RVA = "0x473D30", Offset = "0x472330", VA = "0x180473D30", Slot = "68")]
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

	// Token: 0x06000FDA RID: 4058 RVA: 0x0005B2FC File Offset: 0x000594FC
	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public CabbageCannon()
	{
	}
}
