using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C8 RID: 456
[Token(Token = "0x20001C8")]
public class Bullet_ultimateStar : Bullet_star
{
	// Token: 0x060007D4 RID: 2004 RVA: 0x00028524 File Offset: 0x00026724
	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x7E9C20", Offset = "0x7E8220", VA = "0x1807E9C20", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		Transform transform = base.transform;
		int num = 0;
		Transform transform2 = transform.GetChild(num).transform;
		this.star = transform2;
		Transform transform3 = base.transform;
		float trackSpeed = this.trackSpeed;
		int num2 = 0;
		float num3 = trackSpeed * 1.6f;
		this.accelerateTime = (float)num2;
		this.movingToCircle = true;
		this.angle = (float)num2;
		this.trackSpeed = num3;
		this.angularSpeed = -3f;
		if ((this.skin ? 1 : 0) != num2)
		{
			if (global::UnityEngine.Random.Range(0, 2) == 0)
			{
				Transform transform4 = transform3.transform;
				int num4 = 0;
				Transform child = transform4.GetChild(num4);
				int num5 = 0;
				child.GetChild(num5).gameObject.SetActive(true);
				int num6 = 0;
				Transform transform5;
				GameObject gameObject = transform5.GetChild(num6).GetChild(1).gameObject;
				int num7 = 0;
				gameObject.SetActive(num7 != 0);
				return;
			}
			Transform transform6 = base.transform;
			int num8 = 0;
			Transform child2 = transform6.GetChild(num8);
			int num9 = 0;
			GameObject gameObject2 = child2.GetChild(num9).gameObject;
			int num10 = 0;
			gameObject2.SetActive(num10 != 0);
			Transform transform7 = base.transform;
			int num11 = 0;
			transform7.GetChild(num11).GetChild(1).gameObject.SetActive(true);
		}
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00028664 File Offset: 0x00026864
	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x7EA490", Offset = "0x7E8A90", VA = "0x1807EA490", Slot = "11")]
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

	// Token: 0x060007D6 RID: 2006 RVA: 0x000286A4 File Offset: 0x000268A4
	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x7E9790", Offset = "0x7E7D90", VA = "0x1807E9790", Slot = "14")]
	protected override Zombie GetNearestZombie()
	{
		Zombie nearestFlyingZombie = base.GetNearestFlyingZombie();
		int num = 0;
		if (!(nearestFlyingZombie != num))
		{
			return base.GetNearestZombie();
		}
		return nearestFlyingZombie;
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x000286CC File Offset: 0x000268CC
	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x7EA360", Offset = "0x7E8960", VA = "0x1807EA360")]
	private bool TryGetAirProjectile([Out] AirProjectile airProjectile)
	{
		int size = this.targetProjectiles._size;
		int num = size - 1;
		if (size > 0)
		{
			AirProjectile airProjectile2 = this.targetProjectiles[num];
			int num2 = 0;
			if (!(airProjectile2 != num2))
			{
				this.targetProjectiles.RemoveAt(num);
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x0002871C File Offset: 0x0002691C
	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x7E9EF0", Offset = "0x7E84F0", VA = "0x1807E9EF0", Slot = "26")]
	public override void TrackUpdate()
	{
		Rigidbody2D rb = this.rb;
		int size = this.targetProjectiles._size;
		int num = size - 1;
		if (size > 0)
		{
			AirProjectile airProjectile = this.targetProjectiles[num];
			int num2 = 0;
			if (airProjectile != num2)
			{
				goto IL_00D2;
			}
			this.targetProjectiles.RemoveAt(num);
		}
		Zombie targetZombie = this.targetZombie;
		int num3 = 0;
		if (!(targetZombie == num3))
		{
			Zombie targetZombie2 = this.targetZombie;
			if (targetZombie2.theStatus != ZombieStatus.Dying && !targetZombie2.isMindControlled)
			{
				Collider2D col = targetZombie2.col;
				int num4 = 0;
				if (col != num4)
				{
					Collider2D col2 = this.targetZombie.col;
					if (col2.enabled)
					{
						Collider2D col3 = this.targetZombie.col;
						Bounds bounds = col2.bounds;
						Transform transform = base.transform;
						goto IL_00D2;
					}
				}
			}
		}
		Rigidbody2D rb2;
		Vector2 vector;
		rb2.velocity = vector;
		throw new NullReferenceException();
		IL_00D2:
		Transform transform2 = base.transform;
		Rigidbody2D rb3 = this.rb;
		int num5 = 0;
		rb3.velocity = num5;
		rb2 = this.rb;
		float num6;
		rb2.rotation = num6;
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x00028838 File Offset: 0x00026A38
	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x7E9A00", Offset = "0x7E8000", VA = "0x1807E9A00", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		if (typeof(ParticleManager).TypeHandle != 0 && num < typeof(IAirCrashable).TypeHandle)
		{
			num += num;
			if ("{il2cpp array field il2cppMethodInfo->}" == typeof(IAirCrashable).TypeHandle)
			{
				goto IL_0071;
			}
			num++;
		}
		Plant torchWood = this.torchWood;
		int num2 = 0;
		if (!(torchWood != num2))
		{
			int num3 = 0;
			int damage = this._damage;
			PlantType fromType = this.fromType;
			zombie.TakeDamage(damage, this, (DamageType)num3, fromType, num != 0);
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = base.transform;
			base.PlaySound(zombie);
		}
		IL_0071:
		ulong num4;
		base.FireZombie(zombie, num4 != 0UL);
		base.Die();
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x000288CC File Offset: 0x00026ACC
	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x7E9810", Offset = "0x7E7E10", VA = "0x1807E9810", Slot = "18")]
	public override void HitLand()
	{
		Plant torchWood = this.torchWood;
		int num = 0;
		if (!(torchWood != num))
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = base.transform;
			int num2 = 0;
			int theBulletRow = this.theBulletRow;
			int num3 = 0;
			ulong num4;
			Particle particle = instance.SetParticle((ParticleType)((uint)50), num2, theBulletRow, num4 != 0UL, (float)num3);
		}
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00028954 File Offset: 0x00026B54
	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x7DB980", Offset = "0x7D9F80", VA = "0x1807DB980")]
	public Bullet_ultimateStar()
	{
		this.movingToCircle = true;
		base..ctor();
	}

	// Token: 0x040003B2 RID: 946
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40003B2")]
	public bool skin;
}
