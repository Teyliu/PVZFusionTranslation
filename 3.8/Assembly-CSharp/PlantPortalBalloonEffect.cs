using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
[Serializable]
public class PlantPortalBalloonEffect : PlantEffect
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000075 RID: 117 RVA: 0x00003B3C File Offset: 0x00001D3C
	[Token(Token = "0x1700001E")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x3B05A0", Offset = "0x3AEBA0", VA = "0x1803B05A0", Slot = "4")]
		get
		{
			return EffectType.PortalBalloon;
		}
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003B4C File Offset: 0x00001D4C
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x3B04C0", Offset = "0x3AEAC0", VA = "0x1803B04C0")]
	public PlantPortalBalloonEffect(Plant plant, float duration)
	{
		this.first = true;
		base.OnStart();
		this.plant = plant;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
		}
		this.duration = duration;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00003B88 File Offset: 0x00001D88
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x3B0480", Offset = "0x3AEA80", VA = "0x1803B0480", Slot = "5")]
	public override void OnStart()
	{
		Plant plant = this.plant;
		int num = 0;
		int num2 = 0;
		plant.ModifyDamage((PlantDamageAdder)((uint)51), -0.9f, num2 != 0, num);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00003BB8 File Offset: 0x00001DB8
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x3A9A00", Offset = "0x3A8000", VA = "0x1803A9A00", Slot = "6")]
	public override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		float num = this.duration;
		this.totalDuration = deltaTime;
		float deltaTime2 = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00003BF4 File Offset: 0x00001DF4
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x3B0430", Offset = "0x3AEA30", VA = "0x1803B0430", Slot = "8")]
	public override void OnRemove()
	{
		int num = 0;
		Plant plant = this.plant;
		int num2 = 0;
		int num3 = 0;
		plant.ModifyDamage((PlantDamageAdder)((uint)51), (float)num3, num2 != 0, num);
		base.OnRemove();
	}

	// Token: 0x0400003A RID: 58
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400003A")]
	public float duration;
}
