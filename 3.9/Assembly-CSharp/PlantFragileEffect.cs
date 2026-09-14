using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
[Serializable]
public class PlantFragileEffect : PlantEffect
{
	// Token: 0x17000022 RID: 34
	// (get) Token: 0x0600008A RID: 138 RVA: 0x00003DE0 File Offset: 0x00001FE0
	[Token(Token = "0x17000022")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x3FC6C0", Offset = "0x3FACC0", VA = "0x1803FC6C0", Slot = "4")]
		get
		{
			return EffectType.Fragile_plant;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600008B RID: 139 RVA: 0x00003DF0 File Offset: 0x00001FF0
	// (set) Token: 0x0600008C RID: 140 RVA: 0x00003E04 File Offset: 0x00002004
	[Token(Token = "0x17000023")]
	public override float Value
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x3FC6D0", Offset = "0x3FACD0", VA = "0x1803FC6D0", Slot = "10")]
		get
		{
			return this.extraDamageMultiplier;
		}
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x3FC6E0", Offset = "0x3FACE0", VA = "0x1803FC6E0", Slot = "11")]
		set
		{
			this.extraDamageMultiplier = value;
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00003E18 File Offset: 0x00002018
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x3FC5C0", Offset = "0x3FABC0", VA = "0x1803FC5C0")]
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

	// Token: 0x0600008E RID: 142 RVA: 0x00003E5C File Offset: 0x0000205C
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x3F5800", Offset = "0x3F3E00", VA = "0x1803F5800", Slot = "6")]
	public override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		float num = this.duration;
		this.totalDuration = deltaTime;
		float deltaTime2 = Time.deltaTime;
		this.duration = num;
		base.OnRemove();
	}

	// Token: 0x04000041 RID: 65
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000041")]
	public float duration;

	// Token: 0x04000042 RID: 66
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000042")]
	public float extraDamageMultiplier;
}
