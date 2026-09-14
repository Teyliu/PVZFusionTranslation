using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
[Serializable]
public abstract class PlantEffect : BaseEffect
{
	// Token: 0x0600003A RID: 58 RVA: 0x00002AA4 File Offset: 0x00000CA4
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x3FC050", Offset = "0x3FA650", VA = "0x1803FC050", Slot = "8")]
	public override void OnRemove()
	{
		Dictionary<EffectType, BaseEffect> effects = this.plant.effects;
		EffectType effectType = base.EffectType;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002ACC File Offset: 0x00000CCC
	[Token(Token = "0x600003B")]
	[Address(RVA = "0xAAB360", Offset = "0xAA9960", VA = "0x180AAB360")]
	protected void InheritFields<T>(T originalEffect) where T : PlantEffect
	{
		this.first = false;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002AE8 File Offset: 0x00000CE8
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x3EB780", Offset = "0x3E9D80", VA = "0x1803EB780")]
	protected PlantEffect()
	{
		this.first = true;
		base.OnStart();
	}

	// Token: 0x04000014 RID: 20
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000014")]
	public Plant plant;
}
