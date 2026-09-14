using System;
using Cpp2IlInjected;

// Token: 0x02000352 RID: 850
[Token(Token = "0x2000352")]
public class BedRockTallNut : WallNut
{
	// Token: 0x06000F9B RID: 3995 RVA: 0x0005A2C4 File Offset: 0x000584C4
	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "28")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x0005A2D4 File Offset: 0x000584D4
	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0005A2E4 File Offset: 0x000584E4
	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public BedRockTallNut()
	{
	}
}
