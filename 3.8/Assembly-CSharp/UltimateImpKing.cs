using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006FD RID: 1789
[Token(Token = "0x20006FD")]
public class UltimateImpKing : BoatImp
{
	// Token: 0x06002397 RID: 9111 RVA: 0x000BA32C File Offset: 0x000B852C
	[Token(Token = "0x6002397")]
	[Address(RVA = "0x5881D0", Offset = "0x5867D0", VA = "0x1805881D0", Slot = "27")]
	public override void Die(int reason = 0)
	{
		this.isDoom = false;
		base.Die(reason);
	}

	// Token: 0x06002398 RID: 9112 RVA: 0x000BA348 File Offset: 0x000B8548
	[Token(Token = "0x6002398")]
	[Address(RVA = "0x5881E0", Offset = "0x5867E0", VA = "0x1805881E0", Slot = "31")]
	protected override void OnDodge()
	{
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)3003)))
		{
			base.Recover(500f);
			return;
		}
	}

	// Token: 0x06002399 RID: 9113 RVA: 0x000BA370 File Offset: 0x000B8570
	[Token(Token = "0x6002399")]
	[Address(RVA = "0x588220", Offset = "0x586820", VA = "0x180588220", Slot = "15")]
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

	// Token: 0x0600239A RID: 9114 RVA: 0x000BA3C4 File Offset: 0x000B85C4
	[Token(Token = "0x600239A")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600239B RID: 9115 RVA: 0x000BA3D4 File Offset: 0x000B85D4
	[Token(Token = "0x600239B")]
	[Address(RVA = "0x538170", Offset = "0x536770", VA = "0x180538170")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x0600239C RID: 9116 RVA: 0x000BA3F4 File Offset: 0x000B85F4
	[Token(Token = "0x600239C")]
	[Address(RVA = "0x3CAD30", Offset = "0x3C9330", VA = "0x1803CAD30", Slot = "75")]
	protected override int GetReason(int reason)
	{
		return reason;
	}

	// Token: 0x0600239D RID: 9117 RVA: 0x000BA404 File Offset: 0x000B8604
	[Token(Token = "0x600239D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x0600239E RID: 9118 RVA: 0x000BA414 File Offset: 0x000B8614
	[Token(Token = "0x600239E")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600239F RID: 9119 RVA: 0x000BA424 File Offset: 0x000B8624
	[Token(Token = "0x600239F")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "55")]
	public override void SetKelped(float time, bool land = false)
	{
	}

	// Token: 0x060023A0 RID: 9120 RVA: 0x000BA434 File Offset: 0x000B8634
	[Token(Token = "0x60023A0")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x060023A1 RID: 9121 RVA: 0x000BA450 File Offset: 0x000B8650
	[Token(Token = "0x60023A1")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060023A2 RID: 9122 RVA: 0x000BA460 File Offset: 0x000B8660
	[Token(Token = "0x60023A2")]
	[Address(RVA = "0x587C00", Offset = "0x586200", VA = "0x180587C00", Slot = "74")]
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

	// Token: 0x060023A3 RID: 9123 RVA: 0x000BA500 File Offset: 0x000B8700
	[Token(Token = "0x60023A3")]
	[Address(RVA = "0x588120", Offset = "0x586720", VA = "0x180588120", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060023A4 RID: 9124 RVA: 0x000BA524 File Offset: 0x000B8724
	[Token(Token = "0x60023A4")]
	[Address(RVA = "0x587EF0", Offset = "0x5864F0", VA = "0x180587EF0", Slot = "45")]
	public override void DestoryZombie()
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		int num;
		Zombie.<DecreaseTransparent>d__191 <DecreaseTransparent>d__ = new Zombie.<DecreaseTransparent>d__191(num);
		num = 0;
		<DecreaseTransparent>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<DecreaseTransparent>d__);
	}

	// Token: 0x060023A5 RID: 9125 RVA: 0x000BA59C File Offset: 0x000B879C
	[Token(Token = "0x60023A5")]
	[Address(RVA = "0x588440", Offset = "0x586A40", VA = "0x180588440")]
	public UltimateImpKing()
	{
	}
}
