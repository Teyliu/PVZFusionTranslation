using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000735 RID: 1845
[Token(Token = "0x2000735")]
public class UltimateImpKing : BoatImp
{
	// Token: 0x060024B2 RID: 9394 RVA: 0x000BEF6C File Offset: 0x000BD16C
	[Token(Token = "0x60024B2")]
	[Address(RVA = "0x600FE0", Offset = "0x5FF5E0", VA = "0x180600FE0", Slot = "28")]
	public override void Die(int reason = 0)
	{
		this.isDoom = false;
		base.Die(reason);
	}

	// Token: 0x060024B3 RID: 9395 RVA: 0x000BEF88 File Offset: 0x000BD188
	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x600FF0", Offset = "0x5FF5F0", VA = "0x180600FF0", Slot = "32")]
	protected override void OnDodge()
	{
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)3003)))
		{
			base.Recover(500f);
			return;
		}
	}

	// Token: 0x060024B4 RID: 9396 RVA: 0x000BEFB0 File Offset: 0x000BD1B0
	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x601030", Offset = "0x5FF630", VA = "0x180601030", Slot = "16")]
	protected override void Start()
	{
		ulong num3;
		do
		{
			int num = 0;
			base.Start();
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		BoxType boxType;
		if (boxType != BoxType.Water)
		{
		}
	}

	// Token: 0x060024B5 RID: 9397 RVA: 0x000BF000 File Offset: 0x000BD200
	[Token(Token = "0x60024B5")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060024B6 RID: 9398 RVA: 0x000BF010 File Offset: 0x000BD210
	[Token(Token = "0x60024B6")]
	[Address(RVA = "0x58EE50", Offset = "0x58D450", VA = "0x18058EE50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x060024B7 RID: 9399 RVA: 0x000BF030 File Offset: 0x000BD230
	[Token(Token = "0x60024B7")]
	[Address(RVA = "0x417AE0", Offset = "0x4160E0", VA = "0x180417AE0", Slot = "77")]
	protected override int GetReason(int reason)
	{
		return reason;
	}

	// Token: 0x060024B8 RID: 9400 RVA: 0x000BF040 File Offset: 0x000BD240
	[Token(Token = "0x60024B8")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x060024B9 RID: 9401 RVA: 0x000BF050 File Offset: 0x000BD250
	[Token(Token = "0x60024B9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060024BA RID: 9402 RVA: 0x000BF060 File Offset: 0x000BD260
	[Token(Token = "0x60024BA")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "57")]
	public override void SetKelped(float time, bool land = false)
	{
	}

	// Token: 0x060024BB RID: 9403 RVA: 0x000BF070 File Offset: 0x000BD270
	[Token(Token = "0x60024BB")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x060024BC RID: 9404 RVA: 0x000BF084 File Offset: 0x000BD284
	[Token(Token = "0x60024BC")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060024BD RID: 9405 RVA: 0x000BF094 File Offset: 0x000BD294
	[Token(Token = "0x60024BD")]
	[Address(RVA = "0x600A70", Offset = "0x5FF070", VA = "0x180600A70", Slot = "76")]
	protected override void AnimPop()
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		int zombieRow = base.GetZombieRow();
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		Zombie zombie = instance.SetZombie(zombieRow, (ZombieType)((uint)235), 9.9f, num != 0);
		Transform transform = zombie.transform;
		Transform transform2 = zombie.transform;
		this.board.SetHealthInTravel(zombie);
		Transform axis = zombie.axis;
		Transform axis2 = this.axis;
		int theZombieRow = this.theZombieRow;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(110, 112), 0.5f, 1f);
	}

	// Token: 0x060024BE RID: 9406 RVA: 0x000BF134 File Offset: 0x000BD334
	[Token(Token = "0x60024BE")]
	[Address(RVA = "0x600F30", Offset = "0x5FF530", VA = "0x180600F30", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060024BF RID: 9407 RVA: 0x000BF158 File Offset: 0x000BD358
	[Token(Token = "0x60024BF")]
	[Address(RVA = "0x600D60", Offset = "0x5FF360", VA = "0x180600D60", Slot = "47")]
	public override void DestoryZombie()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		base.DestoryZombie();
	}

	// Token: 0x060024C0 RID: 9408 RVA: 0x000BF1B8 File Offset: 0x000BD3B8
	[Token(Token = "0x60024C0")]
	[Address(RVA = "0x601210", Offset = "0x5FF810", VA = "0x180601210")]
	public UltimateImpKing()
	{
	}
}
