using System;
using Cpp2IlInjected;

// Token: 0x020004DD RID: 1245
[Token(Token = "0x20004DD")]
public class DoomCabbage : Cabbage
{
	// Token: 0x0600176A RID: 5994 RVA: 0x000804EC File Offset: 0x0007E6EC
	[Token(Token = "0x600176A")]
	[Address(RVA = "0x4A07B0", Offset = "0x49EDB0", VA = "0x1804A07B0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_doom;
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x00080500 File Offset: 0x0007E700
	[Token(Token = "0x600176B")]
	[Address(RVA = "0x4A07C0", Offset = "0x49EDC0", VA = "0x1804A07C0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		Board board = this.board;
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x0008051C File Offset: 0x0007E71C
	[Token(Token = "0x600176C")]
	[Address(RVA = "0x4A0810", Offset = "0x49EE10", VA = "0x1804A0810", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Board board = this.board;
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x00080538 File Offset: 0x0007E738
	[Token(Token = "0x600176D")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public DoomCabbage()
	{
	}
}
