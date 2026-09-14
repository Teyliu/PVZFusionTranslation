using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
[Serializable]
public abstract class ZombieEffect : BaseEffect
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600003D RID: 61 RVA: 0x00002B04 File Offset: 0x00000D04
	[Token(Token = "0x1700000D")]
	public virtual bool SoftControl
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x400CB0", Offset = "0x3FF2B0", VA = "0x180400CB0", Slot = "12")]
		get;
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600003E RID: 62 RVA: 0x00002B18 File Offset: 0x00000D18
	[Token(Token = "0x1700000E")]
	public virtual bool HardControl
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x400CA0", Offset = "0x3FF2A0", VA = "0x180400CA0", Slot = "13")]
		get;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002B2C File Offset: 0x00000D2C
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x400A00", Offset = "0x3FF000", VA = "0x180400A00", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		this.rwkr = flag;
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002B4C File Offset: 0x00000D4C
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x400A20", Offset = "0x3FF020", VA = "0x180400A20", Slot = "6")]
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

	// Token: 0x06000041 RID: 65 RVA: 0x00002BA0 File Offset: 0x00000DA0
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x400AB0", Offset = "0x3FF0B0", VA = "0x180400AB0")]
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

	// Token: 0x06000042 RID: 66 RVA: 0x00002BDC File Offset: 0x00000DDC
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x400980", Offset = "0x3FEF80", VA = "0x180400980", Slot = "8")]
	public override void OnRemove()
	{
		Dictionary<EffectType, BaseEffect> effects = this.zombie.effects;
		EffectType effectType = base.EffectType;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002C04 File Offset: 0x00000E04
	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB2AB90", Offset = "0xB29190", VA = "0x180B2AB90")]
	protected void InheritFields<T>(T originalEffect) where T : ZombieEffect
	{
		this.first = false;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002C20 File Offset: 0x00000E20
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x3EB780", Offset = "0x3E9D80", VA = "0x1803EB780")]
	protected ZombieEffect()
	{
		this.first = true;
		base.OnStart();
	}

	// Token: 0x04000015 RID: 21
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000015")]
	public Zombie zombie;

	// Token: 0x04000018 RID: 24
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000018")]
	private bool rwkr;
}
