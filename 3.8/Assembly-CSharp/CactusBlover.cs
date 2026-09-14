using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000354 RID: 852
[Token(Token = "0x2000354")]
public class CactusBlover : Shooter
{
	// Token: 0x06000F97 RID: 3991 RVA: 0x0005A5B4 File Offset: 0x000587B4
	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x41E7B0", Offset = "0x41CDB0", VA = "0x18041E7B0", Slot = "15")]
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

	// Token: 0x06000F98 RID: 3992 RVA: 0x0005A608 File Offset: 0x00058808
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x41E280", Offset = "0x41C880", VA = "0x18041E280")]
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

	// Token: 0x06000F99 RID: 3993 RVA: 0x0005A650 File Offset: 0x00058850
	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x41E640", Offset = "0x41CC40", VA = "0x18041E640", Slot = "69")]
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

	// Token: 0x06000F9A RID: 3994 RVA: 0x0005A6A8 File Offset: 0x000588A8
	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x41E400", Offset = "0x41CA00", VA = "0x18041E400", Slot = "44")]
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

	// Token: 0x06000F9B RID: 3995 RVA: 0x0005A71C File Offset: 0x0005891C
	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public CactusBlover()
	{
	}
}
