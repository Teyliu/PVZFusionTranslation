using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000382 RID: 898
[Token(Token = "0x2000382")]
public class EmeraldUmbrella : SuperUmbrella
{
	// Token: 0x06001079 RID: 4217 RVA: 0x0005E690 File Offset: 0x0005C890
	[Token(Token = "0x6001079")]
	[Address(RVA = "0x432ED0", Offset = "0x4314D0", VA = "0x180432ED0", Slot = "73")]
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

	// Token: 0x0600107A RID: 4218 RVA: 0x0005E6F0 File Offset: 0x0005C8F0
	[Token(Token = "0x600107A")]
	[Address(RVA = "0x432C10", Offset = "0x431210", VA = "0x180432C10", Slot = "17")]
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

	// Token: 0x0600107B RID: 4219 RVA: 0x0005E734 File Offset: 0x0005C934
	[Token(Token = "0x600107B")]
	[Address(RVA = "0x4329F0", Offset = "0x430FF0", VA = "0x1804329F0")]
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

	// Token: 0x0600107C RID: 4220 RVA: 0x0005E788 File Offset: 0x0005C988
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x432BF0", Offset = "0x4311F0", VA = "0x180432BF0", Slot = "72")]
	protected override void ConvertZombie(Zombie zombie, float goldRatio, float silverRatio)
	{
		base.ConvertZombie(zombie, goldRatio, silverRatio);
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x0005E7A0 File Offset: 0x0005C9A0
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x4325F0", Offset = "0x430BF0", VA = "0x1804325F0")]
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
				float[] array;
				float num3 = array[0];
				bullet.Vx = num3;
				float num4 = array[1];
				bullet.Vy = num4;
				float num5 = array[1];
				bullet.detaVy = num5;
				int theZombieRow = zombie.theZombieRow;
				int num6 = 0;
				if (!Lawnf.TravelAdvanced((AdvBuff)((uint)15)))
				{
				}
				bullet.Damage = num6;
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
		int num7 = 0;
		bullet.Vy = 10f;
		bullet.Vx = (float)num7;
		Vector2 gravity = Physics2D.gravity;
		float num8;
		bullet.detaVy = num8;
		throw new NullReferenceException();
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x0005E8E8 File Offset: 0x0005CAE8
	[Token(Token = "0x600107E")]
	[Address(RVA = "0x432CB0", Offset = "0x4312B0", VA = "0x180432CB0")]
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

	// Token: 0x0600107F RID: 4223 RVA: 0x0005E96C File Offset: 0x0005CB6C
	[Token(Token = "0x600107F")]
	[Address(RVA = "0x433050", Offset = "0x431650", VA = "0x180433050")]
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

	// Token: 0x06001080 RID: 4224 RVA: 0x0005E9F8 File Offset: 0x0005CBF8
	[Token(Token = "0x6001080")]
	[Address(RVA = "0x432C80", Offset = "0x431280", VA = "0x180432C80", Slot = "32")]
	protected override int GetDamage(int damage)
	{
		int num = this.theLevel;
		num++;
		return base.GetDamage(damage);
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x0005EA18 File Offset: 0x0005CC18
	[Token(Token = "0x6001081")]
	[Address(RVA = "0x433210", Offset = "0x431810", VA = "0x180433210")]
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

	// Token: 0x06001082 RID: 4226 RVA: 0x0005EAA4 File Offset: 0x0005CCA4
	[Token(Token = "0x6001082")]
	[Address(RVA = "0x433500", Offset = "0x431B00", VA = "0x180433500")]
	public EmeraldUmbrella()
	{
	}
}
