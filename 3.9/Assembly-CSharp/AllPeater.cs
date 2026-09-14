using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E2 RID: 1250
[Token(Token = "0x20004E2")]
public class AllPeater : Shooter
{
	// Token: 0x06001795 RID: 6037 RVA: 0x00080F94 File Offset: 0x0007F194
	[Token(Token = "0x6001795")]
	[Address(RVA = "0x507E60", Offset = "0x506460", VA = "0x180507E60", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)39L);
		if (Lawnf.EveBalaced() && this.theStatus == PlantStatus.GoldMagnet_attrack)
		{
			Animator anim = this.anim;
			this.theStatus = (PlantStatus)((ulong)39L);
			anim.SetTrigger("idle1");
			return;
		}
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x00081024 File Offset: 0x0007F224
	[Token(Token = "0x6001796")]
	[Address(RVA = "0x507F50", Offset = "0x506550", VA = "0x180507F50")]
	public void ChangeType()
	{
		if (this.theStatus == PlantStatus.GoldMagnet_attrack)
		{
			Animator anim = this.anim;
			this.theStatus = (PlantStatus)((ulong)39L);
			anim.SetTrigger("idle1");
			return;
		}
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x00081098 File Offset: 0x0007F298
	[Token(Token = "0x6001797")]
	[Address(RVA = "0x508720", Offset = "0x506D20", VA = "0x180508720", Slot = "68")]
	protected override Bullet Shoot1()
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		if (this.theStatus == PlantStatus.GoldMagnet_attrack)
		{
			Board board = this.board;
			int num3 = 0;
			int num4 = 0;
			if (board.rowNum == 5)
			{
			}
			if (num4 < board.rowNum)
			{
				Transform shoot = this.shoot;
				CreateBullet instance = CreateBullet.Instance;
				Transform shoot2 = this.shoot;
				BulletType bulletType = base.GetBulletType();
				Bullet bullet;
				bullet.Damage = 0;
				PlantType thePlantType = this.thePlantType;
				num3++;
				bullet.fromType = thePlantType;
				Board board2 = this.board;
				this.ShootType2();
				this.ShootType1();
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x00081144 File Offset: 0x0007F344
	[Token(Token = "0x6001798")]
	[Address(RVA = "0x5081D0", Offset = "0x5067D0", VA = "0x1805081D0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		bool flag = base.Shootable();
		if (flag)
		{
			PlantStatus theStatus = this.theStatus;
			if (!flag)
			{
				this.anim.SetTrigger("shoot1");
				return;
			}
			if (!flag)
			{
				this.anim.SetTrigger("shoot2");
				return;
			}
			if (theStatus == PlantStatus.GoldMagnet_attrack)
			{
				this.anim.SetTrigger("shoot3");
				return;
			}
		}
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x000811C8 File Offset: 0x0007F3C8
	[Token(Token = "0x6001799")]
	[Address(RVA = "0x508300", Offset = "0x506900", VA = "0x180508300", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			if (this.theStatus != PlantStatus.GoldMagnet_attrack)
			{
				goto IL_0093;
			}
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
				Transform axis = this.axis;
				if (!base.SearchUniqueZombie(num))
				{
					continue;
				}
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_00B1;
			}
			List<Zombie> zombieArray2 = this.board.zombieArray;
			bool flag2;
			if (!flag2)
			{
				goto IL_0093;
			}
			int num4 = 0;
			if (num != num4)
			{
				float vision2 = this.vision;
				Transform axis2 = this.axis;
				if (base.SearchUniqueZombie(num))
				{
					break;
				}
			}
		}
		GameObject gameObject;
		return gameObject;
		IL_0093:
		throw new NullReferenceException();
		IL_00B1:
		throw new NullReferenceException();
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x000812A0 File Offset: 0x0007F4A0
	[Token(Token = "0x600179A")]
	[Address(RVA = "0x508E70", Offset = "0x507470", VA = "0x180508E70")]
	private void ShootType3()
	{
		Board board = this.board;
		int num = 0;
		int num2 = 0;
		if (board.rowNum == 5)
		{
		}
		if (num2 < board.rowNum)
		{
			Transform shoot = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot2 = this.shoot;
			BulletType bulletType = base.GetBulletType();
			Bullet bullet;
			bullet.Damage = 0;
			PlantType thePlantType = this.thePlantType;
			num++;
			bullet.fromType = thePlantType;
			Board board2 = this.board;
		}
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x0008131C File Offset: 0x0007F51C
	[Token(Token = "0x600179B")]
	[Address(RVA = "0x508030", Offset = "0x506630", VA = "0x180508030")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && Lawnf.InLandStatus(zombie.theStatus))
		{
			Transform axis = zombie.axis;
			Transform axis2 = this.axis;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x00081358 File Offset: 0x0007F558
	[Token(Token = "0x600179C")]
	[Address(RVA = "0x508C10", Offset = "0x507210", VA = "0x180508C10")]
	private void ShootType2()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = base.GetBulletType();
		CreateBullet instance2 = CreateBullet.Instance;
		BulletType bulletType2 = base.GetBulletType();
		CreateBullet instance3 = CreateBullet.Instance;
		BulletType bulletType3 = base.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		int attackDamage3 = this.attackDamage;
		Bullet bullet3;
		bullet3.Damage = attackDamage3;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		PlantType thePlantType2 = this.thePlantType;
		bullet2.fromType = thePlantType2;
		PlantType thePlantType3 = this.thePlantType;
		bullet3.fromType = thePlantType3;
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x00081408 File Offset: 0x0007F608
	[Token(Token = "0x600179D")]
	[Address(RVA = "0x508A40", Offset = "0x507040", VA = "0x180508A40")]
	protected void ShootType1()
	{
		Transform shoot = this.shoot;
		int thePlantRow = this.thePlantRow;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = base.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int rowNum = this.board.rowNum;
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x0008147C File Offset: 0x0007F67C
	[Token(Token = "0x600179E")]
	[Address(RVA = "0x509010", Offset = "0x507610", VA = "0x180509010")]
	private void ShootUpper(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = base.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x000814C0 File Offset: 0x0007F6C0
	[Token(Token = "0x600179F")]
	[Address(RVA = "0x508960", Offset = "0x506F60", VA = "0x180508960")]
	private void ShootLower(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = base.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x00081504 File Offset: 0x0007F704
	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x5080C0", Offset = "0x5066C0", VA = "0x1805080C0")]
	private void ExtraBullet()
	{
		Transform transform = this.shoot.transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = base.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x00081558 File Offset: 0x0007F758
	[Token(Token = "0x60017A1")]
	[Address(RVA = "0x5090F0", Offset = "0x5076F0", VA = "0x1805090F0")]
	public AllPeater()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
