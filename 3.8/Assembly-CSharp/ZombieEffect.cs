using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
[Serializable]
public abstract class ZombieEffect : BaseEffect
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000023 RID: 35 RVA: 0x000027BC File Offset: 0x000009BC
	[Token(Token = "0x17000007")]
	public virtual bool SoftControl
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3B3F20", Offset = "0x3B2520", VA = "0x1803B3F20", Slot = "12")]
		get;
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000024 RID: 36 RVA: 0x000027D0 File Offset: 0x000009D0
	[Token(Token = "0x17000008")]
	public virtual bool HardControl
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3B3F10", Offset = "0x3B2510", VA = "0x1803B3F10", Slot = "13")]
		get;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000027E4 File Offset: 0x000009E4
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x3B3C70", Offset = "0x3B2270", VA = "0x1803B3C70", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		this.rwkr = flag;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002804 File Offset: 0x00000A04
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x3B3C90", Offset = "0x3B2290", VA = "0x1803B3C90", Slot = "6")]
	public override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.totalDuration = deltaTime;
		if (this.rwkr && deltaTime > 5f && this.HardControl)
		{
			this.RwkrActive();
			bool flag = this.zombie.SetEffect((EffectType)((uint)8), 3f, 1f);
		}
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002858 File Offset: 0x00000A58
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x3B3D20", Offset = "0x3B2320", VA = "0x1803B3D20")]
	private void RwkrActive()
	{
		int num;
		do
		{
			List<KeyValuePair<EffectType, BaseEffect>> list = Enumerable.ToList<KeyValuePair<EffectType, BaseEffect>>(this.zombie.effects);
			num = 0;
			bool flag;
			if (flag && !flag)
			{
				while (!flag)
				{
				}
			}
		}
		while (num != 0);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002894 File Offset: 0x00000A94
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x3B3BF0", Offset = "0x3B21F0", VA = "0x1803B3BF0", Slot = "8")]
	public override void OnRemove()
	{
		Dictionary<EffectType, BaseEffect> effects = this.zombie.effects;
		EffectType effectType = base.EffectType;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000028BC File Offset: 0x00000ABC
	[Token(Token = "0x6000029")]
	[Address(RVA = "0xA5B850", Offset = "0xA59E50", VA = "0x180A5B850")]
	protected void InheritFields<T>(T originalEffect) where T : ZombieEffect
	{
		this.first = false;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000028D8 File Offset: 0x00000AD8
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x39F750", Offset = "0x39DD50", VA = "0x18039F750")]
	protected ZombieEffect()
	{
		this.first = true;
		base.OnStart();
	}

	// Token: 0x0400000C RID: 12
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000C")]
	public Zombie zombie;

	// Token: 0x0400000F RID: 15
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x400000F")]
	private bool rwkr;
}
