using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200047B RID: 1147
[Token(Token = "0x200047B")]
public class ThreeSpike : Caltrop
{
	// Token: 0x06001520 RID: 5408 RVA: 0x00074AD8 File Offset: 0x00072CD8
	[Token(Token = "0x6001520")]
	[Address(RVA = "0x4D1910", Offset = "0x4CFF10", VA = "0x1804D1910", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x00074AEC File Offset: 0x00072CEC
	[Token(Token = "0x6001521")]
	[Address(RVA = "0x4D13A0", Offset = "0x4CF9A0", VA = "0x1804D13A0", Slot = "44")]
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

	// Token: 0x06001522 RID: 5410 RVA: 0x00074B84 File Offset: 0x00072D84
	[Token(Token = "0x6001522")]
	[Address(RVA = "0x4D0FA0", Offset = "0x4CF5A0", VA = "0x1804D0FA0")]
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

	// Token: 0x06001523 RID: 5411 RVA: 0x00074C0C File Offset: 0x00072E0C
	[Token(Token = "0x6001523")]
	[Address(RVA = "0x4D1830", Offset = "0x4CFE30", VA = "0x1804D1830")]
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

	// Token: 0x06001524 RID: 5412 RVA: 0x00074C48 File Offset: 0x00072E48
	[Token(Token = "0x6001524")]
	[Address(RVA = "0x4D1750", Offset = "0x4CFD50", VA = "0x1804D1750")]
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

	// Token: 0x06001525 RID: 5413 RVA: 0x00074C84 File Offset: 0x00072E84
	[Token(Token = "0x6001525")]
	[Address(RVA = "0x4D12A0", Offset = "0x4CF8A0", VA = "0x1804D12A0")]
	private void ExtraBullet()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet component = this.board.GetComponent<CreateBullet>();
		Bullet bullet;
		bullet.Damage = 5;
	}

	// Token: 0x06001526 RID: 5414 RVA: 0x00074CC4 File Offset: 0x00072EC4
	[Token(Token = "0x6001526")]
	[Address(RVA = "0x4D14F0", Offset = "0x4CFAF0", VA = "0x1804D14F0", Slot = "43")]
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

	// Token: 0x06001527 RID: 5415 RVA: 0x00074D3C File Offset: 0x00072F3C
	[Token(Token = "0x6001527")]
	[Address(RVA = "0x4D1990", Offset = "0x4CFF90", VA = "0x1804D1990")]
	public ThreeSpike()
	{
	}

	// Token: 0x04000D57 RID: 3415
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D57")]
	private float shootTime;

	// Token: 0x04000D58 RID: 3416
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000D58")]
	private readonly float shootMaxTime = 1.5f;
}
