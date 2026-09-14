using System;
using Cpp2IlInjected;

// Token: 0x020004C2 RID: 1218
[Token(Token = "0x20004C2")]
public class Cabbage : Thrower
{
	// Token: 0x06001704 RID: 5892 RVA: 0x0007EBC8 File Offset: 0x0007CDC8
	[Token(Token = "0x6001704")]
	[Address(RVA = "0x41CE10", Offset = "0x41B410", VA = "0x18041CE10", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage;
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x0007EBD8 File Offset: 0x0007CDD8
	[Token(Token = "0x6001705")]
	[Address(RVA = "0x49BE70", Offset = "0x49A470", VA = "0x18049BE70", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		Board board = this.board;
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x0007EBF4 File Offset: 0x0007CDF4
	[Token(Token = "0x6001706")]
	[Address(RVA = "0x49BEC0", Offset = "0x49A4C0", VA = "0x18049BEC0", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Board board = this.board;
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x0007EC10 File Offset: 0x0007CE10
	[Token(Token = "0x6001707")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public Cabbage()
	{
	}
}
