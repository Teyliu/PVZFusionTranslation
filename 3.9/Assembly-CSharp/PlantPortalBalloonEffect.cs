using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000021 RID: 33
[Token(Token = "0x2000021")]
[Serializable]
public class PlantPortalBalloonEffect : PlantEffect
{
	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600008F RID: 143 RVA: 0x00003E98 File Offset: 0x00002098
	[Token(Token = "0x17000024")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x3FC860", Offset = "0x3FAE60", VA = "0x1803FC860", Slot = "4")]
		get
		{
			return EffectType.PortalBalloon;
		}
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00003EA8 File Offset: 0x000020A8
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x3FC780", Offset = "0x3FAD80", VA = "0x1803FC780")]
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

	// Token: 0x06000091 RID: 145 RVA: 0x00003EE4 File Offset: 0x000020E4
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x3FC740", Offset = "0x3FAD40", VA = "0x1803FC740", Slot = "5")]
	public override void OnStart()
	{
		Plant plant = this.plant;
		int num = 0;
		int num2 = 0;
		plant.ModifyDamage((PlantDamageAdder)((uint)51), -0.9f, num2 != 0, num);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00003F14 File Offset: 0x00002114
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x3F5800", Offset = "0x3F3E00", VA = "0x1803F5800", Slot = "6")]
	public override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		float num = this.duration;
		this.totalDuration = deltaTime;
		float deltaTime2 = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00003F50 File Offset: 0x00002150
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x3FC6F0", Offset = "0x3FACF0", VA = "0x1803FC6F0", Slot = "8")]
	public override void OnRemove()
	{
		int num = 0;
		Plant plant = this.plant;
		int num2 = 0;
		int num3 = 0;
		plant.ModifyDamage((PlantDamageAdder)((uint)51), (float)num3, num2 != 0, num);
		base.OnRemove();
	}

	// Token: 0x04000043 RID: 67
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000043")]
	public float duration;
}
