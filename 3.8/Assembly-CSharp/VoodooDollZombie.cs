using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200070D RID: 1805
[Token(Token = "0x200070D")]
public class VoodooDollZombie : Zombie
{
	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06002443 RID: 9283 RVA: 0x000BD2E0 File Offset: 0x000BB4E0
	// (set) Token: 0x06002444 RID: 9284 RVA: 0x000BD2F4 File Offset: 0x000BB4F4
	[Token(Token = "0x1700016F")]
	public ZombieType VoodooZombieType
	{
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x590CF0", Offset = "0x58F2F0", VA = "0x180590CF0")]
		get
		{
			return this._v;
		}
		[Token(Token = "0x6002444")]
		[Address(RVA = "0x590D00", Offset = "0x58F300", VA = "0x180590D00")]
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

	// Token: 0x06002445 RID: 9285 RVA: 0x000BD394 File Offset: 0x000BB594
	[Token(Token = "0x6002445")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "46")]
	public override void UpdateColor(Zombie.ZombieColor zombieColor = Zombie.ZombieColor.Default)
	{
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x000BD3A4 File Offset: 0x000BB5A4
	[Token(Token = "0x6002446")]
	[Address(RVA = "0x5908C0", Offset = "0x58EEC0", VA = "0x1805908C0", Slot = "15")]
	protected override void Start()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002447 RID: 9287 RVA: 0x000BD3C4 File Offset: 0x000BB5C4
	[Token(Token = "0x6002447")]
	[Address(RVA = "0x590970", Offset = "0x58EF70", VA = "0x180590970", Slot = "12")]
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
				Func<Zombie, bool> func;
				VoodooDollZombie.<>c.<>9__8_0 = func;
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

	// Token: 0x06002448 RID: 9288 RVA: 0x000BD43C File Offset: 0x000BB63C
	[Token(Token = "0x6002448")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x000BD44C File Offset: 0x000BB64C
	[Token(Token = "0x6002449")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x000BD45C File Offset: 0x000BB65C
	[Token(Token = "0x600244A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x0600244B RID: 9291 RVA: 0x000BD46C File Offset: 0x000BB66C
	[Token(Token = "0x600244B")]
	[Address(RVA = "0x590810", Offset = "0x58EE10", VA = "0x180590810", Slot = "28")]
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

	// Token: 0x0600244C RID: 9292 RVA: 0x000BD4AC File Offset: 0x000BB6AC
	[Token(Token = "0x600244C")]
	[Address(RVA = "0x561440", Offset = "0x55FA40", VA = "0x180561440", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(2);
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x000BD4C0 File Offset: 0x000BB6C0
	[Token(Token = "0x600244D")]
	[Address(RVA = "0x590C90", Offset = "0x58F290", VA = "0x180590C90")]
	public VoodooDollZombie()
	{
	}

	// Token: 0x040011BA RID: 4538
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40011BA")]
	private ZombieType _v;

	// Token: 0x040011BB RID: 4539
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40011BB")]
	private GameObject preview;

	// Token: 0x040011BC RID: 4540
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40011BC")]
	public float rate = 1f;
}
