using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200055C RID: 1372
[Token(Token = "0x200055C")]
public class LanternStarFruit : StarFruit
{
	// Token: 0x06001985 RID: 6533 RVA: 0x0008A13C File Offset: 0x0008833C
	[Token(Token = "0x6001985")]
	[Address(RVA = "0x534AB0", Offset = "0x5330B0", VA = "0x180534AB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		ParticleSystem component = base.transform.Find("LanternShine").GetComponent<ParticleSystem>();
		this.lightShine = component;
		throw new NullReferenceException();
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x0008A174 File Offset: 0x00088374
	[Token(Token = "0x6001986")]
	[Address(RVA = "0x532A40", Offset = "0x531040", VA = "0x180532A40", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		ParticleSystem.MainModule main = this.lightShine.main;
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x0008A1A0 File Offset: 0x000883A0
	[Token(Token = "0x6001987")]
	[Address(RVA = "0x534ED0", Offset = "0x5334D0", VA = "0x180534ED0", Slot = "72")]
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

	// Token: 0x06001988 RID: 6536 RVA: 0x0008A1F4 File Offset: 0x000883F4
	[Token(Token = "0x6001988")]
	[Address(RVA = "0x534B50", Offset = "0x533150", VA = "0x180534B50", Slot = "44")]
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

	// Token: 0x06001989 RID: 6537 RVA: 0x0008A26C File Offset: 0x0008846C
	[Token(Token = "0x6001989")]
	[Address(RVA = "0x534CB0", Offset = "0x5332B0", VA = "0x180534CB0", Slot = "43")]
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

	// Token: 0x0600198A RID: 6538 RVA: 0x0008A2D8 File Offset: 0x000884D8
	[Token(Token = "0x600198A")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public LanternStarFruit()
	{
	}

	// Token: 0x04000EE1 RID: 3809
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EE1")]
	private ParticleSystem lightShine;
}
