using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000395 RID: 917
[Token(Token = "0x2000395")]
public class EmeraldUmbrella : SuperUmbrella
{
	// Token: 0x060010CE RID: 4302 RVA: 0x0005F9D8 File Offset: 0x0005DBD8
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x485C80", Offset = "0x484280", VA = "0x180485C80", Slot = "74")]
	protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag && collision == this)
		{
			int thePlantRow = this.thePlantRow;
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			this.anim.SetTrigger("block2");
			this.blocking = true;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		}
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x0005FA38 File Offset: 0x0005DC38
	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x4859C0", Offset = "0x483FC0", VA = "0x1804859C0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)14));
		if (flag && !flag)
		{
			Animator anim = this.anim;
			float speed = anim.speed;
			if (anim != 0)
			{
				this.ConvertUpdate();
			}
		}
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x0005FA7C File Offset: 0x0005DC7C
	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x4857A0", Offset = "0x483DA0", VA = "0x1804857A0")]
	private void ConvertUpdate()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && base.SearchUniqueZombie(num) && !flag2)
			{
				bool flag3 = base.SuperSkill();
			}
			num++;
		}
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x0005FAD0 File Offset: 0x0005DCD0
	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x4859A0", Offset = "0x483FA0", VA = "0x1804859A0", Slot = "73")]
	protected override void ConvertZombie(Zombie zombie, float goldRatio, float silverRatio)
	{
		base.ConvertZombie(zombie, goldRatio, silverRatio);
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x0005FAE8 File Offset: 0x0005DCE8
	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x485430", Offset = "0x483A30", VA = "0x180485430")]
	private void AdjustBulletSpeed(Bullet bullet)
	{
		Zombie zombie = this.UmbrellaSearchZombie();
		int num = 0;
		if (zombie != num)
		{
			Collider2D col = zombie.col;
			int num2 = 0;
			if (col != num2)
			{
				Transform transform = bullet.transform;
				Vector3 vector;
				float z = vector.z;
				Vector2 velocity = zombie.Velocity;
				Vector2 colliderPosition = zombie.ColliderPosition;
				int theZombieRow = zombie.theZombieRow;
				int num3 = 0;
				if (!Lawnf.TravelAdvanced((AdvBuff)((uint)15)))
				{
				}
				bullet.Damage = num3;
				bullet.umbrellaed = true;
				bullet.theBulletRow = theZombieRow;
				if (bullet.theBulletType == BulletType.Bullet_sunCabbage)
				{
					CreateItem instance = CreateItem.Instance;
					Transform transform2 = bullet.transform;
					Vector3 vector2;
					float z2 = vector2.z;
				}
				Board board = this.board;
				int maxMoney = board.maxMoney;
				if (board.theMoney < maxMoney)
				{
					CreateItem instance2 = CreateItem.Instance;
					Transform transform3 = bullet.transform;
					Vector3 vector3;
					float z3 = vector3.z;
				}
				return;
			}
		}
		int num4 = 0;
		bullet.velocity.y = 10f;
		bullet.velocity = num4;
		Vector2 gravity = Physics2D.gravity;
		float num5;
		bullet.acceleration.y = num5;
		throw new NullReferenceException();
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x0005FC04 File Offset: 0x0005DE04
	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x485A60", Offset = "0x484060", VA = "0x180485A60")]
	private Plant GetEmeraldUmbrella()
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
				goto IL_0064;
			}
			GridSystem gridSystem = board.gridSystem;
			int thePlantRow = this.thePlantRow;
			List<Plant> plants = gridSystem.GetGrid(num2, thePlantRow).plants;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !(num != this))
				{
					continue;
				}
			}
		}
		while (num4 != (ulong)0L);
		num2++;
		IL_0064:
		throw new NullReferenceException();
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x0005FC88 File Offset: 0x0005DE88
	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x485E00", Offset = "0x484400", VA = "0x180485E00")]
	private void ReinforceBullet(Bullet bullet, int theRow)
	{
		int num = 0;
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)15)))
		{
		}
		bullet.Damage = num;
		bullet.umbrellaed = true;
		bullet.theBulletRow = theRow;
		if (bullet.theBulletType == BulletType.Bullet_sunCabbage)
		{
			CreateItem instance = CreateItem.Instance;
			Transform transform = bullet.transform;
			Vector3 vector;
			float z = vector.z;
		}
		Board board = this.board;
		int maxMoney = board.maxMoney;
		if (board.theMoney < maxMoney)
		{
			CreateItem instance2 = CreateItem.Instance;
			Transform transform2 = bullet.transform;
			Vector3 vector2;
			float z2 = vector2.z;
		}
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x0005FD14 File Offset: 0x0005DF14
	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x485A30", Offset = "0x484030", VA = "0x180485A30", Slot = "31")]
	protected override int GetDamage(int damage)
	{
		int num = this.theLevel;
		num++;
		return base.GetDamage(damage);
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x0005FD34 File Offset: 0x0005DF34
	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x485FC0", Offset = "0x4845C0", VA = "0x180485FC0")]
	protected Zombie UmbrellaSearchZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			Plant umbrellaPot = base.UmbrellaPot;
			int num3 = 0;
			bool flag = umbrellaPot == num3;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag2;
			if (flag2)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
				float vision = this.vision;
				if (!Thrower.ThrowSearchZombie(num))
				{
					continue;
				}
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x0005FDC0 File Offset: 0x0005DFC0
	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x471840", Offset = "0x46FE40", VA = "0x180471840")]
	public EmeraldUmbrella()
	{
	}
}
