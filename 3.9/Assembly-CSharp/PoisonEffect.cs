using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000024 RID: 36
[Token(Token = "0x2000024")]
[Serializable]
public class PoisonEffect : ZombieEffect
{
	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004320 File Offset: 0x00002520
	[Token(Token = "0x17000028")]
	public override EffectType EffectType
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "4")]
		get
		{
			return EffectType.Poison;
		}
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00004330 File Offset: 0x00002530
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x3FCBD0", Offset = "0x3FB1D0", VA = "0x1803FCBD0")]
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

	// Token: 0x060000A2 RID: 162 RVA: 0x00004374 File Offset: 0x00002574
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x3FCAA0", Offset = "0x3FB0A0", VA = "0x1803FCAA0", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		Zombie zombie = this.zombie;
		this.rwkr = flag;
		bool flag2 = zombie.RemoveBuff((EffectType)((uint)1));
		Zombie zombie2 = this.zombie;
		throw new NullReferenceException();
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x000043B0 File Offset: 0x000025B0
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x3FCB00", Offset = "0x3FB100", VA = "0x1803FCB00", Slot = "6")]
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

	// Token: 0x060000A4 RID: 164 RVA: 0x00004434 File Offset: 0x00002634
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x3FCA50", Offset = "0x3FB050", VA = "0x1803FCA50", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		this.zombie.poisonLevel = (int)((ulong)0L);
		Zombie zombie = this.zombie;
		throw new NullReferenceException();
	}

	// Token: 0x04000047 RID: 71
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000047")]
	public float duration;

	// Token: 0x04000048 RID: 72
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000048")]
	private float timer;
}
