using System;
using Cpp2IlInjected;

// Token: 0x020004C6 RID: 1222
[Token(Token = "0x20004C6")]
public class CabbagePuff : Thrower
{
	// Token: 0x06001712 RID: 5906 RVA: 0x0007EDFC File Offset: 0x0007CFFC
	[Token(Token = "0x6001712")]
	[Address(RVA = "0x49BE00", Offset = "0x49A400", VA = "0x18049BE00", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_small;
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x0007EE10 File Offset: 0x0007D010
	[Token(Token = "0x6001713")]
	[Address(RVA = "0x49BE10", Offset = "0x49A410", VA = "0x18049BE10", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x0007EE20 File Offset: 0x0007D020
	[Token(Token = "0x6001714")]
	[Address(RVA = "0x49BE40", Offset = "0x49A440", VA = "0x18049BE40", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x0007EE30 File Offset: 0x0007D030
	[Token(Token = "0x6001715")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public CabbagePuff()
	{
	}
}
