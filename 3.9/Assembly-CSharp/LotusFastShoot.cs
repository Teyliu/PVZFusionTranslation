using System;
using Cpp2IlInjected;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000016")]
public class LotusFastShoot : FastShootEffect
{
	// Token: 0x0600005F RID: 95 RVA: 0x0000335C File Offset: 0x0000155C
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x3FB380", Offset = "0x3F9980", VA = "0x1803FB380")]
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

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000060 RID: 96 RVA: 0x000033A4 File Offset: 0x000015A4
	[Token(Token = "0x17000014")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x3FB480", Offset = "0x3F9A80", VA = "0x1803FB480", Slot = "4")]
		get
		{
			return EffectType.LotusFastShoot;
		}
	}
}
