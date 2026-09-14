using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
[Serializable]
public abstract class PlantEffect : BaseEffect
{
	// Token: 0x06000020 RID: 32 RVA: 0x0000275C File Offset: 0x0000095C
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3AFD90", Offset = "0x3AE390", VA = "0x1803AFD90", Slot = "8")]
	public override void OnRemove()
	{
		Dictionary<EffectType, BaseEffect> effects = this.plant.effects;
		EffectType effectType = base.EffectType;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002784 File Offset: 0x00000984
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x9F9B20", Offset = "0x9F8120", VA = "0x1809F9B20")]
	protected void InheritFields<T>(T originalEffect) where T : PlantEffect
	{
		this.first = false;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000027A0 File Offset: 0x000009A0
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x39F750", Offset = "0x39DD50", VA = "0x18039F750")]
	protected PlantEffect()
	{
		this.first = true;
		base.OnStart();
	}

	// Token: 0x0400000B RID: 11
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000B")]
	public Plant plant;
}
