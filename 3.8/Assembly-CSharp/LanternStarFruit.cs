using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200052F RID: 1327
[Token(Token = "0x200052F")]
public class LanternStarFruit : StarFruit
{
	// Token: 0x060018B5 RID: 6325 RVA: 0x00086478 File Offset: 0x00084678
	[Token(Token = "0x60018B5")]
	[Address(RVA = "0x4D41D0", Offset = "0x4D27D0", VA = "0x1804D41D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		ParticleSystem component = base.transform.Find("LanternShine").GetComponent<ParticleSystem>();
		this.lightShine = component;
		throw new NullReferenceException();
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x000864B0 File Offset: 0x000846B0
	[Token(Token = "0x60018B6")]
	[Address(RVA = "0x4D2160", Offset = "0x4D0760", VA = "0x1804D2160", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		ParticleSystem.MainModule main = this.lightShine.main;
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x000864DC File Offset: 0x000846DC
	[Token(Token = "0x60018B7")]
	[Address(RVA = "0x4D45F0", Offset = "0x4D2BF0", VA = "0x1804D45F0", Slot = "73")]
	protected override void SetBullet(Transform _transform, BulletMoveWay theMovingWay)
	{
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.theStatus = (BulletStatus)((ulong)4L);
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00086530 File Offset: 0x00084730
	[Token(Token = "0x60018B8")]
	[Address(RVA = "0x4D4270", Offset = "0x4D2870", VA = "0x1804D4270", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		Board board = this.board;
		GameObject gameObject = this.SearchZombie();
		int num2 = 0;
		if (!(gameObject != num2))
		{
			Zombie zombie = base.SearchBoss();
			int num3 = 0;
			if (!(zombie != num3))
			{
				return;
			}
		}
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x000865A8 File Offset: 0x000847A8
	[Token(Token = "0x60018B9")]
	[Address(RVA = "0x4D43D0", Offset = "0x4D29D0", VA = "0x1804D43D0", Slot = "44")]
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
					int thePlantRow = this.thePlantRow;
					float vision = this.vision;
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
		return base.SearchZombie();
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x00086614 File Offset: 0x00084814
	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public LanternStarFruit()
	{
	}

	// Token: 0x04000E26 RID: 3622
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E26")]
	private ParticleSystem lightShine;
}
