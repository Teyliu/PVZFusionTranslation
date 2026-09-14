using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BF RID: 447
[Token(Token = "0x20001BF")]
public class Bullet_superStar : Bullet_star
{
	// Token: 0x060007B0 RID: 1968 RVA: 0x00027904 File Offset: 0x00025B04
	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x7E79C0", Offset = "0x7E5FC0", VA = "0x1807E79C0", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		BlackHole blackHole = this.blackHole;
		int num = 0;
		if (blackHole == num && this.theExistTime > 0.3f)
		{
			base.MoveWay = (BulletMoveWay)((uint)6);
			return;
		}
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00027944 File Offset: 0x00025B44
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x7E76F0", Offset = "0x7E5CF0", VA = "0x1807E76F0", Slot = "26")]
	public override void TrackUpdate()
	{
		Rigidbody2D rb = this.rb;
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (!(targetZombie == num))
		{
			Zombie targetZombie2 = this.targetZombie;
			if (targetZombie2.theStatus != ZombieStatus.Dying && !targetZombie2.isMindControlled)
			{
				Collider2D col = targetZombie2.col;
				int num2 = 0;
				if (col != num2 && this.targetZombie.col.enabled)
				{
					Collider2D col2 = this.targetZombie.col;
					Transform transform = base.transform;
					Rigidbody2D rb2 = this.rb;
					int num3 = 0;
					float trackSpeed = this.trackSpeed;
					rb2.velocity = num3;
					float num4;
					this.rb.rotation = num4;
					return;
				}
			}
			Zombie nearestZombie = base.GetNearestZombie();
			this.targetZombie = nearestZombie;
		}
		Zombie nearestZombie2 = base.GetNearestZombie();
		this.targetZombie = nearestZombie2;
		Rigidbody2D rb3 = this.rb;
		throw new NullReferenceException();
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00027A20 File Offset: 0x00025C20
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x7E5640", Offset = "0x7E3C40", VA = "0x1807E5640", Slot = "25")]
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

	// Token: 0x060007B3 RID: 1971 RVA: 0x00027A6C File Offset: 0x00025C6C
	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x7E75C0", Offset = "0x7E5BC0", VA = "0x1807E75C0", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00027A98 File Offset: 0x00025C98
	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x7E76A0", Offset = "0x7E5CA0", VA = "0x1807E76A0", Slot = "15")]
	protected override bool NearestZombieCondition(Zombie zombie)
	{
		int theBulletRow = this.theBulletRow;
		if (zombie.theZombieRow != theBulletRow)
		{
		}
		return base.NearestZombieCondition(zombie);
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00027AC8 File Offset: 0x00025CC8
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x7DB980", Offset = "0x7D9F80", VA = "0x1807DB980")]
	public Bullet_superStar()
	{
		this.movingToCircle = true;
		base..ctor();
	}
}
