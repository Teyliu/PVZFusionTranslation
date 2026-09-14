using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
[Serializable]
public abstract class FastShootEffect : PlantEffect
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600003E RID: 62
	[Token(Token = "0x1700000C")]
	public abstract override EffectType EffectType
	{
		[Token(Token = "0x600003E")]
		[Address(Slot = "4")]
		get;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002EC4 File Offset: 0x000010C4
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x3A9A70", Offset = "0x3A8070", VA = "0x1803A9A70")]
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

	// Token: 0x06000040 RID: 64 RVA: 0x00002F08 File Offset: 0x00001108
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x3A99B0", Offset = "0x3A7FB0", VA = "0x1803A99B0", Slot = "5")]
	public override void OnStart()
	{
		Plant plant = this.plant;
		float attackSpeedAdder = plant.attackSpeedAdder;
		float value = base.Value;
		plant.attackSpeedAdder = attackSpeedAdder;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002F38 File Offset: 0x00001138
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x3A9A00", Offset = "0x3A8000", VA = "0x1803A9A00", Slot = "6")]
	public override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		float num = this.during;
		this.totalDuration = deltaTime;
		float deltaTime2 = Time.deltaTime;
		this.during = num;
		this.OnRemove();
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002F74 File Offset: 0x00001174
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x3A9940", Offset = "0x3A7F40", VA = "0x1803A9940", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Plant plant = this.plant;
		float attackSpeedAdder = plant.attackSpeedAdder;
		float value = base.Value;
		plant.attackSpeedAdder = attackSpeedAdder;
	}

	// Token: 0x0400002C RID: 44
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002C")]
	protected float during;
}
