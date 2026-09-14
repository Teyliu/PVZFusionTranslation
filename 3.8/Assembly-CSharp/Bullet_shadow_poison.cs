using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000190 RID: 400
[Token(Token = "0x2000190")]
public class Bullet_shadow_poison : Bullet_pierce
{
	// Token: 0x06000704 RID: 1796 RVA: 0x00024670 File Offset: 0x00022870
	[Token(Token = "0x6000704")]
	[Address(RVA = "0x7DE720", Offset = "0x7DCD20", VA = "0x1807DE720", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		this.SetPenetrationTime();
		if (!Lawnf.TravelUltimate((UltiBuff)((uint)48)))
		{
			return;
		}
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00024698 File Offset: 0x00022898
	[Token(Token = "0x6000705")]
	[Address(RVA = "0x7D98C0", Offset = "0x7D7EC0", VA = "0x1807D98C0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2147483647L);
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x000246B8 File Offset: 0x000228B8
	[Token(Token = "0x6000706")]
	[Address(RVA = "0x7DE700", Offset = "0x7DCD00", VA = "0x1807DE700", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		base.MoveWay = (BulletMoveWay)((uint)2);
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x000246D0 File Offset: 0x000228D0
	[Token(Token = "0x6000707")]
	[Address(RVA = "0x7DE790", Offset = "0x7DCD90", VA = "0x1807DE790", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		Vector2 velocity = this.rb.velocity;
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00024708 File Offset: 0x00022908
	[Token(Token = "0x6000708")]
	[Address(RVA = "0x7DE420", Offset = "0x7DCA20", VA = "0x1807DE420")]
	private void AttackZombies()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				PlantType fromType = this.fromType;
				num++;
			}
			num++;
		}
		if (num > 0)
		{
			uint num3;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num3), 0.5f, 1f);
		}
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00024774 File Offset: 0x00022974
	[Token(Token = "0x6000709")]
	[Address(RVA = "0x7DE680", Offset = "0x7DCC80", VA = "0x1807DE680", Slot = "16")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.AttackZombies();
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00024790 File Offset: 0x00022990
	[Token(Token = "0x600070A")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_shadow_poison()
	{
	}

	// Token: 0x0400038C RID: 908
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400038C")]
	public BlackHole holePrefab;

	// Token: 0x0400038D RID: 909
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400038D")]
	private float range;
}
