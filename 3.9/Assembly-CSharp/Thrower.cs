using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000600 RID: 1536
[Token(Token = "0x2000600")]
public class Thrower : Shooter
{
	// Token: 0x06001CAB RID: 7339 RVA: 0x00098CEC File Offset: 0x00096EEC
	[Token(Token = "0x6001CAB")]
	[Address(RVA = "0x55BD70", Offset = "0x55A370", VA = "0x18055BD70", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
	}

	// Token: 0x06001CAC RID: 7340 RVA: 0x00098D00 File Offset: 0x00096F00
	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0x55C770", Offset = "0x55AD70", VA = "0x18055C770", Slot = "72")]
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

	// Token: 0x06001CAD RID: 7341 RVA: 0x00098D40 File Offset: 0x00096F40
	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0x55BDA0", Offset = "0x55A3A0", VA = "0x18055BDA0", Slot = "73")]
	protected virtual bool CheckRange(Zombie zombie)
	{
		Transform axis = zombie.axis;
		Transform axis2 = this.axis;
		throw new NullReferenceException();
	}

	// Token: 0x06001CAE RID: 7342 RVA: 0x00098D64 File Offset: 0x00096F64
	[Token(Token = "0x6001CAE")]
	[Address(RVA = "0x55D3D0", Offset = "0x55B9D0", VA = "0x18055D3D0", Slot = "74")]
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

	// Token: 0x06001CAF RID: 7343 RVA: 0x00098DEC File Offset: 0x00096FEC
	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0x55BE00", Offset = "0x55A400", VA = "0x18055BE00", Slot = "14")]
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

	// Token: 0x06001CB0 RID: 7344 RVA: 0x00098E60 File Offset: 0x00097060
	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0x55C6B0", Offset = "0x55ACB0", VA = "0x18055C6B0", Slot = "44")]
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

	// Token: 0x06001CB1 RID: 7345 RVA: 0x00098EB0 File Offset: 0x000970B0
	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x55D320", Offset = "0x55B920", VA = "0x18055D320")]
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

	// Token: 0x06001CB2 RID: 7346 RVA: 0x00098F08 File Offset: 0x00097108
	[Token(Token = "0x6001CB2")]
	[Address(RVA = "0x55D110", Offset = "0x55B710", VA = "0x18055D110", Slot = "75")]
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

	// Token: 0x06001CB3 RID: 7347 RVA: 0x00098F80 File Offset: 0x00097180
	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0x55C040", Offset = "0x55A640", VA = "0x18055C040")]
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

	// Token: 0x06001CB4 RID: 7348 RVA: 0x00098FFC File Offset: 0x000971FC
	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0x55C820", Offset = "0x55AE20", VA = "0x18055C820", Slot = "68")]
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

	// Token: 0x06001CB5 RID: 7349 RVA: 0x000990F0 File Offset: 0x000972F0
	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0x55C290", Offset = "0x55A890", VA = "0x18055C290")]
	protected void MelonShoot()
	{
		List<Zombie> allZombies = Lawnf.GetAllZombies(false);
		Func<Zombie, bool> func = delegate(Zombie z)
		{
			int thePlantRow = this.thePlantRow;
			if (z.theZombieRow == thePlantRow && !z.isMindControlled)
			{
				Transform axis = z.axis;
				Transform axis2 = this.axis;
				return Lawnf.InLandStatus(z.theStatus);
			}
			throw new NullReferenceException();
		};
		Func<Zombie, float> func2;
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderBy<Zombie, float>(Enumerable.Where<Zombie>(allZombies, func), func2));
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

	// Token: 0x06001CB6 RID: 7350 RVA: 0x000991B0 File Offset: 0x000973B0
	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0x55CCA0", Offset = "0x55B2A0", VA = "0x18055CCA0", Slot = "69")]
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

	// Token: 0x06001CB7 RID: 7351 RVA: 0x000992AC File Offset: 0x000974AC
	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected virtual void UniqueEffect2(Bullet bullet)
	{
	}

	// Token: 0x06001CB8 RID: 7352 RVA: 0x000992BC File Offset: 0x000974BC
	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "77")]
	protected virtual void UniqueEffect(Bullet bullet)
	{
	}

	// Token: 0x06001CB9 RID: 7353 RVA: 0x000992CC File Offset: 0x000974CC
	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001CBA RID: 7354 RVA: 0x000992E4 File Offset: 0x000974E4
	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "78")]
	protected virtual BulletType GetBulletType2()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001CBB RID: 7355 RVA: 0x000992FC File Offset: 0x000974FC
	[Token(Token = "0x6001CBB")]
	[Address(RVA = "0x55D7D0", Offset = "0x55BDD0", VA = "0x18055D7D0")]
	public Thrower()
	{
	}

	// Token: 0x04000FB3 RID: 4019
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000FB3")]
	public float flightTime = 1.5f;
}
