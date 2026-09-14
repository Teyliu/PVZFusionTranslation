using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class PlantRecoverEffect : PlantEffect
{
	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000047 RID: 71 RVA: 0x0000305C File Offset: 0x0000125C
	[Token(Token = "0x1700000F")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3B0780", Offset = "0x3AED80", VA = "0x1803B0780", Slot = "4")]
		get
		{
			return EffectType.Recover;
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0000306C File Offset: 0x0000126C
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x3B06A0", Offset = "0x3AECA0", VA = "0x1803B06A0")]
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

	// Token: 0x06000049 RID: 73 RVA: 0x000030B0 File Offset: 0x000012B0
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x3B05B0", Offset = "0x3AEBB0", VA = "0x1803B05B0", Slot = "5")]
	public override void OnStart()
	{
		this.timer = 1f;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000030C8 File Offset: 0x000012C8
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x3B05C0", Offset = "0x3AEBC0", VA = "0x1803B05C0", Slot = "6")]
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

	// Token: 0x0400002D RID: 45
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002D")]
	public float during;

	// Token: 0x0400002E RID: 46
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400002E")]
	private float timer;
}
