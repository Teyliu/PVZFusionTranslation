using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200045B RID: 1115
[Token(Token = "0x200045B")]
public class ThreeSpike : Caltrop
{
	// Token: 0x06001490 RID: 5264 RVA: 0x0007277C File Offset: 0x0007097C
	[Token(Token = "0x6001490")]
	[Address(RVA = "0x47A050", Offset = "0x478650", VA = "0x18047A050", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x00072790 File Offset: 0x00070990
	[Token(Token = "0x6001491")]
	[Address(RVA = "0x479AE0", Offset = "0x4780E0", VA = "0x180479AE0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		float num = this.shootTime;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.shootTime = num;
		if (num2 > (int)num)
		{
			float num3 = this.shootMaxTime;
			this.shootTime = num3;
			float num4 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
			this.shootTime = num4;
			GameObject gameObject = this.SearchZombie();
			int num5 = 0;
			if (!(gameObject != num5))
			{
				Zombie zombie = base.SearchBoss();
				int num6 = 0;
				if (!(zombie != num6))
				{
					return;
				}
			}
			this.anim.SetTrigger("shoot");
		}
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00072828 File Offset: 0x00070A28
	[Token(Token = "0x6001492")]
	[Address(RVA = "0x4796E0", Offset = "0x477CE0", VA = "0x1804796E0")]
	private void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		int thePlantRow = this.thePlantRow;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.Damage = 5;
		if (!Lawnf.EveBalaced())
		{
			int rowNum = this.board.rowNum;
			return;
		}
		CreateBullet instance2 = CreateBullet.Instance;
		Bullet bullet2;
		bullet2.Damage = 5;
		CreateBullet instance3 = CreateBullet.Instance;
		Bullet bullet3;
		bullet3.Damage = 5;
		throw new NullReferenceException();
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x000728B0 File Offset: 0x00070AB0
	[Token(Token = "0x6001493")]
	[Address(RVA = "0x479F70", Offset = "0x478570", VA = "0x180479F70")]
	private void ShootUpper(float X, float Y, int row)
	{
		Board board = this.board;
		int thePlantColumn = this.thePlantColumn;
		if (board.GetBoxType(thePlantColumn, row) != BoxType.Water)
		{
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			bullet.Damage = 5;
		}
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x000728EC File Offset: 0x00070AEC
	[Token(Token = "0x6001494")]
	[Address(RVA = "0x479E90", Offset = "0x478490", VA = "0x180479E90")]
	private void ShootLower(float X, float Y, int row)
	{
		Board board = this.board;
		int thePlantColumn = this.thePlantColumn;
		if (board.GetBoxType(thePlantColumn, row) != BoxType.Water)
		{
			CreateBullet instance = CreateBullet.Instance;
			Bullet bullet;
			bullet.Damage = 5;
		}
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00072928 File Offset: 0x00070B28
	[Token(Token = "0x6001495")]
	[Address(RVA = "0x4799E0", Offset = "0x477FE0", VA = "0x1804799E0")]
	private void ExtraBullet()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet component = this.board.GetComponent<CreateBullet>();
		Bullet bullet;
		bullet.Damage = 5;
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00072968 File Offset: 0x00070B68
	[Token(Token = "0x6001496")]
	[Address(RVA = "0x479C30", Offset = "0x478230", VA = "0x180479C30", Slot = "44")]
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
				if (num != num2)
				{
					float vision = this.vision;
					Transform axis = this.axis;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
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

	// Token: 0x06001497 RID: 5271 RVA: 0x000729E0 File Offset: 0x00070BE0
	[Token(Token = "0x6001497")]
	[Address(RVA = "0x47A0D0", Offset = "0x4786D0", VA = "0x18047A0D0")]
	public ThreeSpike()
	{
	}

	// Token: 0x04000CCB RID: 3275
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CCB")]
	private float shootTime;

	// Token: 0x04000CCC RID: 3276
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000CCC")]
	private readonly float shootMaxTime = 1.5f;
}
