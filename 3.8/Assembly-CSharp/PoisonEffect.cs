using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
[Serializable]
public class PoisonEffect : ZombieEffect
{
	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000086 RID: 134 RVA: 0x00003FC4 File Offset: 0x000021C4
	[Token(Token = "0x17000022")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "4")]
		get
		{
			return EffectType.Poison;
		}
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00003FD4 File Offset: 0x000021D4
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x3B0910", Offset = "0x3AEF10", VA = "0x1803B0910")]
	public PoisonEffect(Zombie zombie, float duration)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
			this.timer = flag;
		}
		this.duration = duration;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00004018 File Offset: 0x00002218
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x3B07E0", Offset = "0x3AEDE0", VA = "0x1803B07E0", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		Zombie zombie = this.zombie;
		this.rwkr = flag;
		bool flag2 = zombie.RemoveBuff((EffectType)((uint)1));
		Zombie zombie2 = this.zombie;
		throw new NullReferenceException();
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00004054 File Offset: 0x00002254
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x3B0840", Offset = "0x3AEE40", VA = "0x1803B0840", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		if (!this.zombie.HasBuff((EffectType)((uint)3)))
		{
			float num = this.duration;
			float deltaTime = Time.deltaTime;
			this.duration = num;
		}
		this.OnRemove();
		float num2 = this.timer;
		float deltaTime2 = Time.deltaTime;
		this.timer = num2;
		Zombie zombie = this.zombie;
		this.timer = 1f;
		zombie.DamagedByPoison(1f);
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000040D8 File Offset: 0x000022D8
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x3B0790", Offset = "0x3AED90", VA = "0x1803B0790", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		this.zombie.poisonLevel = (int)((ulong)0L);
		Zombie zombie = this.zombie;
		throw new NullReferenceException();
	}

	// Token: 0x0400003E RID: 62
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003E")]
	public float duration;

	// Token: 0x0400003F RID: 63
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400003F")]
	private float timer;
}
