using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C8 RID: 456
[Token(Token = "0x20001C8")]
public class Bullet_superStar : Bullet_star
{
	// Token: 0x060007C2 RID: 1986 RVA: 0x000273C0 File Offset: 0x000255C0
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x814FF0", Offset = "0x8135F0", VA = "0x180814FF0", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		BlackHole blackHole = this.blackHole;
		int num = 0;
		if (blackHole == num && this.theExistTime > 0.3f)
		{
			base.MoveWay = (BulletMoveWay)((uint)3);
			bool flag = this.hitFilters.Remove((uint)4);
			int size = this.hitFilters._size;
			return;
		}
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00027428 File Offset: 0x00025628
	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x814F50", Offset = "0x813550", VA = "0x180814F50", Slot = "23")]
	public override void TrackUpdate()
	{
		base.TrackUpdate();
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie == num)
		{
			this.velocity.y = 0f;
			float num2;
			this.velocity = num2;
		}
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00027468 File Offset: 0x00025668
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x8129C0", Offset = "0x810FC0", VA = "0x1808129C0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x000274B4 File Offset: 0x000256B4
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x814E70", Offset = "0x813470", VA = "0x180814E70", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x000274E0 File Offset: 0x000256E0
	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x809340", Offset = "0x807940", VA = "0x180809340")]
	public Bullet_superStar()
	{
		this.movingToCircle = true;
		base..ctor();
	}
}
