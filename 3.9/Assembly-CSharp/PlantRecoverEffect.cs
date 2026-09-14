using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
public class PlantRecoverEffect : PlantEffect
{
	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000061 RID: 97 RVA: 0x000033B4 File Offset: 0x000015B4
	[Token(Token = "0x17000015")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x3FCA40", Offset = "0x3FB040", VA = "0x1803FCA40", Slot = "4")]
		get
		{
			return EffectType.Recover;
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000033C4 File Offset: 0x000015C4
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x3FC960", Offset = "0x3FAF60", VA = "0x1803FC960")]
	public PlantRecoverEffect(Plant plant, float during)
	{
		this.first = true;
		base.OnStart();
		this.plant = plant;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
			ulong num;
			this.timer = (float)num;
		}
		this.during = during;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003408 File Offset: 0x00001608
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x3FC870", Offset = "0x3FAE70", VA = "0x1803FC870", Slot = "5")]
	public override void OnStart()
	{
		this.timer = 1f;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003420 File Offset: 0x00001620
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x3FC880", Offset = "0x3FAE80", VA = "0x1803FC880", Slot = "6")]
	public override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		float num = this.timer;
		this.totalDuration = deltaTime;
		float deltaTime2 = Time.deltaTime;
		this.timer = num;
		Plant plant = this.plant;
		this.timer = 1f;
		int num2 = 0;
		float num3;
		ulong num4;
		plant.Recover(num3, (DamageType)num2, true, num4 != 0UL);
		float num5 = this.during;
		float deltaTime3 = Time.deltaTime;
		this.during = num5;
		base.OnRemove();
	}

	// Token: 0x04000036 RID: 54
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000036")]
	public float during;

	// Token: 0x04000037 RID: 55
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000037")]
	private float timer;
}
