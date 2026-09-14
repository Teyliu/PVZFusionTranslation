using System;
using Cpp2IlInjected;

// Token: 0x020004EA RID: 1258
[Token(Token = "0x20004EA")]
public class CabbageMelon : Cabbage
{
	// Token: 0x060017BC RID: 6076 RVA: 0x00081D00 File Offset: 0x0007FF00
	[Token(Token = "0x60017BC")]
	[Address(RVA = "0x50B640", Offset = "0x509C40", VA = "0x18050B640", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbageMelon;
	}

	// Token: 0x060017BD RID: 6077 RVA: 0x00081D10 File Offset: 0x0007FF10
	[Token(Token = "0x60017BD")]
	[Address(RVA = "0x50B650", Offset = "0x509C50", VA = "0x18050B650", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		Board board = this.board;
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x060017BE RID: 6078 RVA: 0x00081D34 File Offset: 0x0007FF34
	[Token(Token = "0x60017BE")]
	[Address(RVA = "0x50B6D0", Offset = "0x509CD0", VA = "0x18050B6D0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Board board = this.board;
	}

	// Token: 0x060017BF RID: 6079 RVA: 0x00081D50 File Offset: 0x0007FF50
	[Token(Token = "0x60017BF")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public CabbageMelon()
	{
	}
}
