using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
[Serializable]
public abstract class FastShootEffect : PlantEffect
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000058 RID: 88
	[Token(Token = "0x17000012")]
	public abstract override EffectType EffectType
	{
		[Token(Token = "0x6000058")]
		[Address(Slot = "4")]
		get;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x0000321C File Offset: 0x0000141C
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x3F5870", Offset = "0x3F3E70", VA = "0x1803F5870")]
	public FastShootEffect(Plant plant, float during, float value)
	{
		this.first = true;
		base.OnStart();
		this.plant = plant;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
		}
		base.Value = value;
		this.during = during;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00003260 File Offset: 0x00001460
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x3F57B0", Offset = "0x3F3DB0", VA = "0x1803F57B0", Slot = "5")]
	public override void OnStart()
	{
		Plant plant = this.plant;
		float attackSpeedAdder = plant.attackSpeedAdder;
		float value = base.Value;
		plant.attackSpeedAdder = attackSpeedAdder;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003290 File Offset: 0x00001490
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x3F5800", Offset = "0x3F3E00", VA = "0x1803F5800", Slot = "6")]
	public override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		float num = this.during;
		this.totalDuration = deltaTime;
		float deltaTime2 = Time.deltaTime;
		this.during = num;
		this.OnRemove();
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000032CC File Offset: 0x000014CC
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x3F5740", Offset = "0x3F3D40", VA = "0x1803F5740", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Plant plant = this.plant;
		float attackSpeedAdder = plant.attackSpeedAdder;
		float value = base.Value;
		plant.attackSpeedAdder = attackSpeedAdder;
	}

	// Token: 0x04000035 RID: 53
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000035")]
	protected float during;
}
