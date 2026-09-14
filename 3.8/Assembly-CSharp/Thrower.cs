using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005CB RID: 1483
[Token(Token = "0x20005CB")]
public class Thrower : Shooter
{
	// Token: 0x06001BAC RID: 7084 RVA: 0x000940F8 File Offset: 0x000922F8
	[Token(Token = "0x6001BAC")]
	[Address(RVA = "0x50AB20", Offset = "0x509120", VA = "0x18050AB20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x0009410C File Offset: 0x0009230C
	[Token(Token = "0x6001BAD")]
	[Address(RVA = "0x50B520", Offset = "0x509B20", VA = "0x18050B520", Slot = "73")]
	protected virtual void SetShoot()
	{
		Transform shoot = this.shoot;
		int num = 0;
		if (shoot == num)
		{
			Transform transform = base.transform.Find("Shoot");
			this.shoot = transform;
		}
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x0009414C File Offset: 0x0009234C
	[Token(Token = "0x6001BAE")]
	[Address(RVA = "0x50AB50", Offset = "0x509150", VA = "0x18050AB50", Slot = "74")]
	protected virtual bool CheckRange(Zombie zombie)
	{
		Transform axis = zombie.axis;
		Transform axis2 = this.axis;
		throw new NullReferenceException();
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x00094170 File Offset: 0x00092370
	[Token(Token = "0x6001BAF")]
	[Address(RVA = "0x50C180", Offset = "0x50A780", VA = "0x18050C180", Slot = "75")]
	protected virtual Zombie ThrowerSearchZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				float vision = this.vision;
				if (!this.CheckRange(num) || !Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
		bool flag2;
		if (flag2)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x000941F8 File Offset: 0x000923F8
	[Token(Token = "0x6001BB0")]
	[Address(RVA = "0x50ABB0", Offset = "0x5091B0", VA = "0x18050ABB0", Slot = "14")]
	protected override bool DetactiveEnermy()
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
				if (num != num2)
				{
					int thePlantRow = this.thePlantRow;
					float vision = this.vision;
					if (this.CheckRange(num) && Thrower.ThrowSearchZombie(num))
					{
						break;
					}
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_4;
			}
		}
		return true;
		Block_4:
		throw new NullReferenceException();
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x0009426C File Offset: 0x0009246C
	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x50B460", Offset = "0x509A60", VA = "0x18050B460", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (this.DetactiveEnermy())
		{
			this.anim.SetTrigger("shoot");
			return;
		}
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x000942BC File Offset: 0x000924BC
	[Token(Token = "0x6001BB2")]
	[Address(RVA = "0x50C0D0", Offset = "0x50A6D0", VA = "0x18050C0D0")]
	public static bool ThrowSearchZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && !zombie.beforeDying)
		{
			Collider2D col = zombie.col;
			int num = 0;
			if (!(col == num) && zombie.col.enabled)
			{
				return Lawnf.ThrowLandStatus(zombie.theStatus);
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x00094314 File Offset: 0x00092514
	[Token(Token = "0x6001BB3")]
	[Address(RVA = "0x50BEC0", Offset = "0x50A4C0", VA = "0x18050BEC0", Slot = "76")]
	protected virtual Bullet ShootZombie(Zombie zombie)
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int num = this.attackDamage;
		num += num;
		Bullet bullet;
		bullet.Damage = num;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		this.UniqueEffect(bullet);
		return bullet;
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x0009438C File Offset: 0x0009258C
	[Token(Token = "0x6001BB4")]
	[Address(RVA = "0x50ADF0", Offset = "0x5093F0", VA = "0x18050ADF0")]
	protected Plant FindUmbrella(Vector2 startPosition)
	{
		int num2;
		ulong num4;
		do
		{
			int num = 0;
			num2 = this.thePlantColumn;
			Board board = this.board;
			if (num2 >= board.columnNum)
			{
				goto IL_005A;
			}
			GridSystem gridSystem = board.gridSystem;
			int thePlantRow = this.thePlantRow;
			List<Plant> plants = gridSystem.GetGrid(num2, thePlantRow).plants;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
			}
		}
		while (num4 != (ulong)0L);
		num2++;
		IL_005A:
		throw new NullReferenceException();
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x00094408 File Offset: 0x00092608
	[Token(Token = "0x6001BB5")]
	[Address(RVA = "0x50B5D0", Offset = "0x509BD0", VA = "0x18050B5D0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Zombie zombie = this.ThrowerSearchZombie();
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int num = 0;
		Plant plant;
		if (!(plant != num))
		{
			int num2 = 0;
			if (zombie != num2)
			{
				Collider2D col = zombie.col;
				int num3 = 0;
				if (col != num3)
				{
				}
			}
			Board board = this.board;
			GridSystem gridSystem = board.gridSystem;
			int columnNum = board.columnNum;
			int thePlantRow = this.thePlantRow;
			Vector2 position = gridSystem.GetGrid(columnNum, thePlantRow).Position;
			float num4 = this.flightTime;
		}
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bool melonSputter = this.melonSputter;
		bullet.melonSputter = melonSputter;
		if (base.PumpkinType == PlantType.MelonPumpkin)
		{
			this.MelonShoot();
		}
		this.UniqueEffect(bullet);
		return bullet;
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x000944FC File Offset: 0x000926FC
	[Token(Token = "0x6001BB6")]
	[Address(RVA = "0x50B040", Offset = "0x509640", VA = "0x18050B040")]
	protected void MelonShoot()
	{
		Func<Zombie, bool> func;
		Func<Zombie, float> func2;
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderBy<Zombie, float>(Enumerable.Where<Zombie>(Lawnf.GetAllZombies(false), func), func2));
		int num = 0;
		if (zombie != num)
		{
			Transform shoot = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot2 = this.shoot;
			int attackDamage = base.Pumpkin.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
			Transform shoot3 = this.shoot;
			int num2 = 0;
			Plant plant;
			bool flag = plant != num2;
			Transform shoot4 = this.shoot;
			if (!flag)
			{
			}
			bool melonSputter = this.melonSputter;
			bullet.melonSputter = melonSputter;
			PlantType thePlantType = this.thePlantType;
			bullet.fromType = thePlantType;
		}
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x000945AC File Offset: 0x000927AC
	[Token(Token = "0x6001BB7")]
	[Address(RVA = "0x50BA50", Offset = "0x50A050", VA = "0x18050BA50", Slot = "70")]
	protected override Bullet Shoot2()
	{
		Zombie zombie = this.ThrowerSearchZombie();
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType2();
		int num = 0;
		Plant plant;
		if (!(plant != num))
		{
			int num2 = 0;
			if (zombie != num2)
			{
				Collider2D col = zombie.col;
				int num3 = 0;
				if (col != num3)
				{
				}
			}
			Board board = this.board;
			GridSystem gridSystem = board.gridSystem;
			int columnNum = board.columnNum;
			int thePlantRow = this.thePlantRow;
			Vector2 position = gridSystem.GetGrid(columnNum, thePlantRow).Position;
			float num4 = this.flightTime;
		}
		int num5 = this.attackDamage;
		num5 += 20;
		Bullet bullet;
		bullet.Damage = num5;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound((int)thePlantType, 0.5f, 1f);
		if (base.PumpkinType == PlantType.MelonPumpkin)
		{
			this.MelonShoot();
		}
		this.UniqueEffect2(bullet);
		return bullet;
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x000946A8 File Offset: 0x000928A8
	[Token(Token = "0x6001BB8")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "77")]
	protected virtual void UniqueEffect2(Bullet bullet)
	{
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x000946B8 File Offset: 0x000928B8
	[Token(Token = "0x6001BB9")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "78")]
	protected virtual void UniqueEffect(Bullet bullet)
	{
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x000946C8 File Offset: 0x000928C8
	[Token(Token = "0x6001BBA")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x000946E0 File Offset: 0x000928E0
	[Token(Token = "0x6001BBB")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "79")]
	protected virtual BulletType GetBulletType2()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x000946F8 File Offset: 0x000928F8
	[Token(Token = "0x6001BBC")]
	[Address(RVA = "0x50C580", Offset = "0x50AB80", VA = "0x18050C580")]
	public Thrower()
	{
	}

	// Token: 0x04000EEB RID: 3819
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EEB")]
	public float flightTime = 1.5f;
}
