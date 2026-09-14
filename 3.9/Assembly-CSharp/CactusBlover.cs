using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000364 RID: 868
[Token(Token = "0x2000364")]
public class CactusBlover : Shooter
{
	// Token: 0x06000FE3 RID: 4067 RVA: 0x0005B534 File Offset: 0x00059734
	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0x475670", Offset = "0x473C70", VA = "0x180475670", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(87, 0.5f, 1f);
		this.BlowZombie();
		GameObject fog = this.board.fog;
		int num = 0;
		if (fog != num)
		{
			FogMgr.Instance.Blown();
			return;
		}
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x0005B588 File Offset: 0x00059788
	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0x475140", Offset = "0x473740", VA = "0x180475140")]
	private void BlowZombie()
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
				Blow blow = num.AddComponent<Blow>();
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x0005B5D0 File Offset: 0x000597D0
	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x475500", Offset = "0x473B00", VA = "0x180475500", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x0005B628 File Offset: 0x00059828
	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x4752C0", Offset = "0x4738C0", VA = "0x1804752C0", Slot = "43")]
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
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_2;
			}
		}
		int thePlantRow = this.thePlantRow;
		float vision = this.vision;
		Transform axis = this.axis;
		GameObject gameObject;
		return gameObject;
		Block_2:
		throw new NullReferenceException();
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x0005B69C File Offset: 0x0005989C
	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public CactusBlover()
	{
	}
}
