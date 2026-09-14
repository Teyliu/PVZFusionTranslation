using System;
using Cpp2IlInjected;

// Token: 0x02000342 RID: 834
[Token(Token = "0x2000342")]
public class BedRockTallNut : WallNut
{
	// Token: 0x06000F50 RID: 3920 RVA: 0x0005932C File Offset: 0x0005752C
	[Token(Token = "0x6000F50")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "29")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x0005933C File Offset: 0x0005753C
	[Token(Token = "0x6000F51")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x0005934C File Offset: 0x0005754C
	[Token(Token = "0x6000F52")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public BedRockTallNut()
	{
	}
}
