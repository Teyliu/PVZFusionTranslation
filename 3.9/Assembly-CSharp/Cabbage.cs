using System;
using Cpp2IlInjected;

// Token: 0x020004E7 RID: 1255
[Token(Token = "0x20004E7")]
public class Cabbage : Thrower
{
	// Token: 0x060017B2 RID: 6066 RVA: 0x00081B28 File Offset: 0x0007FD28
	[Token(Token = "0x60017B2")]
	[Address(RVA = "0x473CB0", Offset = "0x4722B0", VA = "0x180473CB0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage;
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x00081B38 File Offset: 0x0007FD38
	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x50B7B0", Offset = "0x509DB0", VA = "0x18050B7B0", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		Board board = this.board;
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x00081B54 File Offset: 0x0007FD54
	[Token(Token = "0x60017B4")]
	[Address(RVA = "0x50B800", Offset = "0x509E00", VA = "0x18050B800", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Board board = this.board;
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x00081B70 File Offset: 0x0007FD70
	[Token(Token = "0x60017B5")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public Cabbage()
	{
	}
}
