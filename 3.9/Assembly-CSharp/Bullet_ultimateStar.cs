using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D2 RID: 466
[Token(Token = "0x20001D2")]
public class Bullet_ultimateStar : Bullet_star
{
	// Token: 0x060007EB RID: 2027 RVA: 0x00028158 File Offset: 0x00026358
	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x8174A0", Offset = "0x815AA0", VA = "0x1808174A0", Slot = "9")]
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

	// Token: 0x060007EC RID: 2028 RVA: 0x00028298 File Offset: 0x00026498
	[Token(Token = "0x60007EC")]
	[Address(RVA = "0x817B80", Offset = "0x816180", VA = "0x180817B80", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		BlackHole blackHole = this.blackHole;
		int num = 0;
		if (blackHole == num && this.theExistTime > 0.3f)
		{
			base.MoveWay = (BulletMoveWay)((uint)3);
			return;
		}
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x000282D8 File Offset: 0x000264D8
	[Token(Token = "0x60007ED")]
	[Address(RVA = "0x817A50", Offset = "0x816050", VA = "0x180817A50")]
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

	// Token: 0x060007EE RID: 2030 RVA: 0x00028328 File Offset: 0x00026528
	[Token(Token = "0x60007EE")]
	[Address(RVA = "0x817770", Offset = "0x815D70", VA = "0x180817770", Slot = "23")]
	public override void TrackUpdate()
	{
		int size = this.targetProjectiles._size;
		int num = size - 1;
		if (size > 0)
		{
			AirProjectile airProjectile = this.targetProjectiles[num];
			int num2 = 0;
			if (airProjectile != num2)
			{
				Transform transform = base.transform;
				Rigidbody2D rb = this.rb;
				int num3 = 0;
				float trackSpeed = this.trackSpeed;
				rb.velocity = num3;
				float num4;
				this.rb.rotation = num4;
				throw new NullReferenceException();
			}
			this.targetProjectiles.RemoveAt(num);
		}
		base.TrackUpdate();
		Zombie targetZombie = this.targetZombie;
		int num5 = 0;
		if (targetZombie == num5)
		{
			float num6 = this.trackSpeed * 0.25f;
			this.velocity.y = 0f;
			this.velocity = num6;
		}
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x000283F0 File Offset: 0x000265F0
	[Token(Token = "0x60007EF")]
	[Address(RVA = "0x817280", Offset = "0x815880", VA = "0x180817280", Slot = "22")]
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

	// Token: 0x060007F0 RID: 2032 RVA: 0x00028484 File Offset: 0x00026684
	[Token(Token = "0x60007F0")]
	[Address(RVA = "0x817090", Offset = "0x815690", VA = "0x180817090", Slot = "17")]
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

	// Token: 0x060007F1 RID: 2033 RVA: 0x0002850C File Offset: 0x0002670C
	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x809340", Offset = "0x807940", VA = "0x180809340")]
	public Bullet_ultimateStar()
	{
		this.movingToCircle = true;
		base..ctor();
	}

	// Token: 0x040003BC RID: 956
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40003BC")]
	public bool skin;
}
