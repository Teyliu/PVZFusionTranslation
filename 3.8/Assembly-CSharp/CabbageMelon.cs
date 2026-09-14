using System;
using Cpp2IlInjected;

// Token: 0x020004C5 RID: 1221
[Token(Token = "0x20004C5")]
public class CabbageMelon : Cabbage
{
	// Token: 0x0600170E RID: 5902 RVA: 0x0007ED98 File Offset: 0x0007CF98
	[Token(Token = "0x600170E")]
	[Address(RVA = "0x49BD00", Offset = "0x49A300", VA = "0x18049BD00", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbageMelon;
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x0007EDA8 File Offset: 0x0007CFA8
	[Token(Token = "0x600170F")]
	[Address(RVA = "0x49BD10", Offset = "0x49A310", VA = "0x18049BD10", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		Board board = this.board;
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x0007EDCC File Offset: 0x0007CFCC
	[Token(Token = "0x6001710")]
	[Address(RVA = "0x49BD90", Offset = "0x49A390", VA = "0x18049BD90", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Board board = this.board;
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x0007EDE8 File Offset: 0x0007CFE8
	[Token(Token = "0x6001711")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public CabbageMelon()
	{
	}
}
