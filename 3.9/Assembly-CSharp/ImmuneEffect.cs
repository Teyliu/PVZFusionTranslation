using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
public class ImmuneEffect : ZombieEffect
{
	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000081 RID: 129 RVA: 0x00003C20 File Offset: 0x00001E20
	[Token(Token = "0x1700001F")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "4")]
		get
		{
			return EffectType.Immune;
		}
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00003C30 File Offset: 0x00001E30
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x3F6A90", Offset = "0x3F5090", VA = "0x1803F6A90")]
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

	// Token: 0x06000083 RID: 131 RVA: 0x00003C6C File Offset: 0x00001E6C
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x3F28A0", Offset = "0x3F0EA0", VA = "0x1803F28A0", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		base.OnRemove();
	}

	// Token: 0x04000040 RID: 64
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000040")]
	public float duration;
}
