using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
[Serializable]
public class PlantFragileEffect : PlantEffect
{
	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000070 RID: 112 RVA: 0x00003A84 File Offset: 0x00001C84
	[Token(Token = "0x1700001C")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x3B0400", Offset = "0x3AEA00", VA = "0x1803B0400", Slot = "4")]
		get
		{
			return EffectType.Fragile_plant;
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000071 RID: 113 RVA: 0x00003A94 File Offset: 0x00001C94
	// (set) Token: 0x06000072 RID: 114 RVA: 0x00003AA8 File Offset: 0x00001CA8
	[Token(Token = "0x1700001D")]
	public override float Value
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3B0410", Offset = "0x3AEA10", VA = "0x1803B0410", Slot = "10")]
		get
		{
			return this.extraDamageMultiplier;
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3B0420", Offset = "0x3AEA20", VA = "0x1803B0420", Slot = "11")]
		set
		{
			this.extraDamageMultiplier = value;
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00003ABC File Offset: 0x00001CBC
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3B0300", Offset = "0x3AE900", VA = "0x1803B0300")]
	public PlantFragileEffect(Plant plant, float duration, float damageMutiplier)
	{
		this.first = true;
		base.OnStart();
		this.plant = plant;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
		}
		this.extraDamageMultiplier = damageMutiplier;
		this.duration = duration;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00003B00 File Offset: 0x00001D00
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x3A9A00", Offset = "0x3A8000", VA = "0x1803A9A00", Slot = "6")]
	public override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		float num = this.duration;
		this.totalDuration = deltaTime;
		float deltaTime2 = Time.deltaTime;
		this.duration = num;
		base.OnRemove();
	}

	// Token: 0x04000038 RID: 56
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000038")]
	public float duration;

	// Token: 0x04000039 RID: 57
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000039")]
	public float extraDamageMultiplier;
}
