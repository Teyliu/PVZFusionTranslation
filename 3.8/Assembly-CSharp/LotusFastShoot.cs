using System;
using Cpp2IlInjected;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
public class LotusFastShoot : FastShootEffect
{
	// Token: 0x06000045 RID: 69 RVA: 0x00003004 File Offset: 0x00001204
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x3AF510", Offset = "0x3ADB10", VA = "0x1803AF510")]
	public LotusFastShoot(Plant plant, float during, float value)
	{
		int num = 0;
		base..ctor(plant, during, value);
		this.plant = plant;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
			base.InheritFields<LotusFastShoot>(num);
		}
		base.Value = value;
		this.during = during;
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000046 RID: 70 RVA: 0x0000304C File Offset: 0x0000124C
	[Token(Token = "0x1700000E")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3AF610", Offset = "0x3ADC10", VA = "0x1803AF610", Slot = "4")]
		get
		{
			return EffectType.LotusFastShoot;
		}
	}
}
