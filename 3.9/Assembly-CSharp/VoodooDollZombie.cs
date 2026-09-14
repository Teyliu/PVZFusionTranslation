using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000746 RID: 1862
[Token(Token = "0x2000746")]
public class VoodooDollZombie : Zombie
{
	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06002563 RID: 9571 RVA: 0x000C20BC File Offset: 0x000C02BC
	// (set) Token: 0x06002564 RID: 9572 RVA: 0x000C20D0 File Offset: 0x000C02D0
	[Token(Token = "0x170001B5")]
	public ZombieType VoodooZombieType
	{
		[Token(Token = "0x6002563")]
		[Address(RVA = "0x60AE10", Offset = "0x609410", VA = "0x18060AE10")]
		get
		{
			return this._v;
		}
		[Token(Token = "0x6002564")]
		[Address(RVA = "0x60AE20", Offset = "0x609420", VA = "0x18060AE20")]
		set
		{
			ulong num2;
			do
			{
				this._v = value;
				GameObject gameObject = this.preview;
				int num = 0;
				if (gameObject != num)
				{
					global::UnityEngine.Object.Destroy(this.preview);
				}
				Transform transform = base.transform;
				Transform axis = this.axis;
				Vector3 vector;
				float z = vector.z;
				GameObject gameObject2;
				this.preview = gameObject2;
				List<GameObject> childs = global::Core.Lawnf.GetChilds(base.transform);
				bool flag;
				if (flag)
				{
					bool flag2;
					while (!flag2)
					{
					}
					string text;
					if (!(text != "Shadow"))
					{
						continue;
					}
					List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
				}
			}
			while (num2 != (ulong)0L);
		}
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x000C2170 File Offset: 0x000C0370
	[Token(Token = "0x6002565")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "48")]
	public override void UpdateColor(Zombie.ZombieColor zombieColor = Zombie.ZombieColor.Default)
	{
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x000C2180 File Offset: 0x000C0380
	[Token(Token = "0x6002566")]
	[Address(RVA = "0x60A9E0", Offset = "0x608FE0", VA = "0x18060A9E0", Slot = "16")]
	protected override void Start()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x000C21A0 File Offset: 0x000C03A0
	[Token(Token = "0x6002567")]
	[Address(RVA = "0x60AA90", Offset = "0x609090", VA = "0x18060AA90", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		ulong num;
		do
		{
			ZombieType theZombieType = this.theZombieType;
			if (this._v == theZombieType)
			{
				break;
			}
			ZombieType v = this._v;
			List<Zombie> certainZombies = global::Lawnf.GetCertainZombies(this.board, v);
			Func<Zombie, bool> <>9__8_ = VoodooDollZombie.<>c.<>9__8_0;
			if (<>9__8_ == 0)
			{
				VoodooDollZombie.<>c.<>9__8_0 = (Zombie z) => !z.isMindControlled;
			}
			List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(certainZombies, <>9__8_));
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		int num2 = 0;
		this.Die(num2);
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x000C2228 File Offset: 0x000C0428
	[Token(Token = "0x6002568")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x000C2238 File Offset: 0x000C0438
	[Token(Token = "0x6002569")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x000C2248 File Offset: 0x000C0448
	[Token(Token = "0x600256A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x000C2258 File Offset: 0x000C0458
	[Token(Token = "0x600256B")]
	[Address(RVA = "0x60A930", Offset = "0x608F30", VA = "0x18060A930", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x000C2298 File Offset: 0x000C0498
	[Token(Token = "0x600256C")]
	[Address(RVA = "0x5C4230", Offset = "0x5C2830", VA = "0x1805C4230", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(2);
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x000C22AC File Offset: 0x000C04AC
	[Token(Token = "0x600256D")]
	[Address(RVA = "0x60ADB0", Offset = "0x6093B0", VA = "0x18060ADB0")]
	public VoodooDollZombie()
	{
	}

	// Token: 0x0400128C RID: 4748
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400128C")]
	private ZombieType _v;

	// Token: 0x0400128D RID: 4749
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400128D")]
	private GameObject preview;

	// Token: 0x0400128E RID: 4750
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x400128E")]
	public float rate = 1f;
}
