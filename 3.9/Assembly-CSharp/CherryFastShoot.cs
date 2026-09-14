using System;
using Cpp2IlInjected;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public class CherryFastShoot : FastShootEffect
{
	// Token: 0x0600005D RID: 93 RVA: 0x00003304 File Offset: 0x00001504
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x3F1E70", Offset = "0x3F0470", VA = "0x1803F1E70")]
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

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600005E RID: 94 RVA: 0x0000334C File Offset: 0x0000154C
	[Token(Token = "0x17000013")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x3F1F70", Offset = "0x3F0570", VA = "0x1803F1F70", Slot = "4")]
		get
		{
			return EffectType.CherryFastShoot;
		}
	}
}
