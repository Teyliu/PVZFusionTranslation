using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
public class ImmuneEffect : ZombieEffect
{
	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000067 RID: 103 RVA: 0x000038C4 File Offset: 0x00001AC4
	[Token(Token = "0x17000019")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "4")]
		get
		{
			return EffectType.Immune;
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000038D4 File Offset: 0x00001AD4
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x3AAC90", Offset = "0x3A9290", VA = "0x1803AAC90")]
	public ImmuneEffect(Zombie zombie, float duration)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
		}
		this.duration = duration;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00003910 File Offset: 0x00001B10
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x3A6910", Offset = "0x3A4F10", VA = "0x1803A6910", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		base.OnRemove();
	}

	// Token: 0x04000037 RID: 55
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000037")]
	public float duration;
}
