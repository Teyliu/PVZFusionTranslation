using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000197 RID: 407
[Token(Token = "0x2000197")]
public class Bullet_shadow_poison : Bullet_pierce
{
	// Token: 0x06000711 RID: 1809 RVA: 0x00023FB0 File Offset: 0x000221B0
	[Token(Token = "0x6000711")]
	[Address(RVA = "0x80BE90", Offset = "0x80A490", VA = "0x18080BE90", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		this.SetPenetrationTime();
		if (!Lawnf.TravelUltimate((UltiBuff)((uint)48)))
		{
			return;
		}
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00023FD8 File Offset: 0x000221D8
	[Token(Token = "0x6000712")]
	[Address(RVA = "0x807150", Offset = "0x805750", VA = "0x180807150", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2147483647L);
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00023FF8 File Offset: 0x000221F8
	[Token(Token = "0x6000713")]
	[Address(RVA = "0x80BE70", Offset = "0x80A470", VA = "0x18080BE70", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		base.MoveWay = (BulletMoveWay)((uint)5);
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00024010 File Offset: 0x00022210
	[Token(Token = "0x6000714")]
	[Address(RVA = "0x80BF00", Offset = "0x80A500", VA = "0x18080BF00", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		Vector2 velocity = this.rb.velocity;
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00024048 File Offset: 0x00022248
	[Token(Token = "0x6000715")]
	[Address(RVA = "0x80BB90", Offset = "0x80A190", VA = "0x18080BB90")]
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

	// Token: 0x06000716 RID: 1814 RVA: 0x000240B4 File Offset: 0x000222B4
	[Token(Token = "0x6000716")]
	[Address(RVA = "0x80BDF0", Offset = "0x80A3F0", VA = "0x18080BDF0", Slot = "15")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		this.AttackZombies();
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x000240D0 File Offset: 0x000222D0
	[Token(Token = "0x6000717")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_shadow_poison()
	{
	}

	// Token: 0x04000395 RID: 917
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000395")]
	public BlackHole holePrefab;

	// Token: 0x04000396 RID: 918
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000396")]
	private float range;
}
