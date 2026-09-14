using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C2 RID: 450
[Token(Token = "0x20001C2")]
public class Bullet_ultimateCactus : Bullet_iceDoom
{
	// Token: 0x060007BD RID: 1981 RVA: 0x00027C1C File Offset: 0x00025E1C
	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x6BEEE0", Offset = "0x6BD4E0", VA = "0x1806BEEE0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)1000000L);
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00027C38 File Offset: 0x00025E38
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x7E7E30", Offset = "0x7E6430", VA = "0x1807E7E30", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		if (zombie == 0)
		{
		}
		bool alive = zombie.Alive;
		this.TrySetMindControl(zombie, damage);
		Plant from = this.from;
		int num = 0;
		if (from != num)
		{
			if (!zombie.isMindControlled)
			{
				bool alive2 = zombie.Alive;
				if (alive == alive2)
				{
					goto IL_004F;
				}
			}
			this.from.KillZombie(zombie);
		}
		IL_004F:
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(70, 0.5f, 1f);
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00027CC0 File Offset: 0x00025EC0
	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x7E7D60", Offset = "0x7E6360", VA = "0x1807E7D60", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(70, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00027CFC File Offset: 0x00025EFC
	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x7E7FD0", Offset = "0x7E65D0", VA = "0x1807E7FD0")]
	private void SmallDoom(Zombie z)
	{
		Transform axis = z.axis;
		Vector3 vector;
		float z2 = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theBulletRow = this.theBulletRow;
				PlantType fromType = this.fromType;
			}
			num3++;
		}
		Transform axis2 = z.axis;
		Vector3 vector2;
		float z3 = vector2.z;
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00027D6C File Offset: 0x00025F6C
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x7E8200", Offset = "0x7E6800", VA = "0x1807E8200")]
	private void TrySetMindControl(Zombie zombie, int damage)
	{
		for (;;)
		{
			int currentFirstHealth = zombie.CurrentFirstHealth;
			if (zombie <= 0)
			{
			}
			float value = global::UnityEngine.Random.value;
			if (zombie <= 0)
			{
			}
			if (value < 0.75f)
			{
				break;
			}
			int num = 0;
			zombie.SetMindControl(num);
			this.SmallDoom(zombie);
			while (!zombie.isMindControlled)
			{
			}
			if (zombie.BoxType != BoxType.Water)
			{
				goto Block_2;
			}
		}
		PlantType fromType = this.fromType;
		bool flag;
		if (flag)
		{
		}
		int num2 = 0;
		uint num3;
		zombie.AddfreezeLevel((int)num3, num2);
		return;
		Block_2:
		Transform axis = zombie.axis;
		CreateZombie instance = CreateZombie.Instance;
		bool flag2;
		bool flag3;
		if (!flag2 || flag3)
		{
		}
		uint num4;
		zombie.Die((int)num4);
		throw new NullReferenceException();
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00027E04 File Offset: 0x00026004
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x7E0730", Offset = "0x7DED30", VA = "0x1807E0730")]
	public Bullet_ultimateCactus()
	{
	}
}
