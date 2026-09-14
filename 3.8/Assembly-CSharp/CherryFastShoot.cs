using System;
using Cpp2IlInjected;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
public class CherryFastShoot : FastShootEffect
{
	// Token: 0x06000043 RID: 67 RVA: 0x00002FAC File Offset: 0x000011AC
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x3A5EE0", Offset = "0x3A44E0", VA = "0x1803A5EE0")]
	public CherryFastShoot(Plant plant, float during, float value)
	{
		int num = 0;
		base..ctor(plant, during, value);
		this.plant = plant;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
			base.InheritFields<CherryFastShoot>(num);
		}
		base.Value = value;
		this.during = during;
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000044 RID: 68 RVA: 0x00002FF4 File Offset: 0x000011F4
	[Token(Token = "0x1700000D")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3A5FE0", Offset = "0x3A45E0", VA = "0x1803A5FE0", Slot = "4")]
		get
		{
			return EffectType.CherryFastShoot;
		}
	}
}
