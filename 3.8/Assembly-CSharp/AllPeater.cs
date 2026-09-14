using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BD RID: 1213
[Token(Token = "0x20004BD")]
public class AllPeater : Shooter
{
	// Token: 0x060016E7 RID: 5863 RVA: 0x0007E04C File Offset: 0x0007C24C
	[Token(Token = "0x60016E7")]
	[Address(RVA = "0x498B50", Offset = "0x497150", VA = "0x180498B50", Slot = "10")]
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

	// Token: 0x060016E8 RID: 5864 RVA: 0x0007E0DC File Offset: 0x0007C2DC
	[Token(Token = "0x60016E8")]
	[Address(RVA = "0x498C40", Offset = "0x497240", VA = "0x180498C40")]
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

	// Token: 0x060016E9 RID: 5865 RVA: 0x0007E150 File Offset: 0x0007C350
	[Token(Token = "0x60016E9")]
	[Address(RVA = "0x499410", Offset = "0x497A10", VA = "0x180499410", Slot = "69")]
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

	// Token: 0x060016EA RID: 5866 RVA: 0x0007E1FC File Offset: 0x0007C3FC
	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x498EC0", Offset = "0x4974C0", VA = "0x180498EC0", Slot = "45")]
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

	// Token: 0x060016EB RID: 5867 RVA: 0x0007E280 File Offset: 0x0007C480
	[Token(Token = "0x60016EB")]
	[Address(RVA = "0x498FF0", Offset = "0x4975F0", VA = "0x180498FF0", Slot = "44")]
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

	// Token: 0x060016EC RID: 5868 RVA: 0x0007E358 File Offset: 0x0007C558
	[Token(Token = "0x60016EC")]
	[Address(RVA = "0x499B60", Offset = "0x498160", VA = "0x180499B60")]
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

	// Token: 0x060016ED RID: 5869 RVA: 0x0007E3D4 File Offset: 0x0007C5D4
	[Token(Token = "0x60016ED")]
	[Address(RVA = "0x498D20", Offset = "0x497320", VA = "0x180498D20")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && Lawnf.InLandStatus(zombie.theStatus))
		{
			Transform axis = zombie.axis;
			Transform axis2 = this.axis;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x0007E410 File Offset: 0x0007C610
	[Token(Token = "0x60016EE")]
	[Address(RVA = "0x499900", Offset = "0x497F00", VA = "0x180499900")]
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

	// Token: 0x060016EF RID: 5871 RVA: 0x0007E4C0 File Offset: 0x0007C6C0
	[Token(Token = "0x60016EF")]
	[Address(RVA = "0x499730", Offset = "0x497D30", VA = "0x180499730")]
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

	// Token: 0x060016F0 RID: 5872 RVA: 0x0007E534 File Offset: 0x0007C734
	[Token(Token = "0x60016F0")]
	[Address(RVA = "0x499D00", Offset = "0x498300", VA = "0x180499D00")]
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

	// Token: 0x060016F1 RID: 5873 RVA: 0x0007E578 File Offset: 0x0007C778
	[Token(Token = "0x60016F1")]
	[Address(RVA = "0x499650", Offset = "0x497C50", VA = "0x180499650")]
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

	// Token: 0x060016F2 RID: 5874 RVA: 0x0007E5BC File Offset: 0x0007C7BC
	[Token(Token = "0x60016F2")]
	[Address(RVA = "0x498DB0", Offset = "0x4973B0", VA = "0x180498DB0")]
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

	// Token: 0x060016F3 RID: 5875 RVA: 0x0007E610 File Offset: 0x0007C810
	[Token(Token = "0x60016F3")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public AllPeater()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
