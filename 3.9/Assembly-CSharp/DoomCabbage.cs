using System;
using Cpp2IlInjected;

// Token: 0x02000505 RID: 1285
[Token(Token = "0x2000505")]
public class DoomCabbage : Cabbage
{
	// Token: 0x06001821 RID: 6177 RVA: 0x0008376C File Offset: 0x0008196C
	[Token(Token = "0x6001821")]
	[Address(RVA = "0x520460", Offset = "0x51EA60", VA = "0x180520460", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_doom;
	}

	// Token: 0x06001822 RID: 6178 RVA: 0x00083780 File Offset: 0x00081980
	[Token(Token = "0x6001822")]
	[Address(RVA = "0x520470", Offset = "0x51EA70", VA = "0x180520470", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		Board board = this.board;
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x0008379C File Offset: 0x0008199C
	[Token(Token = "0x6001823")]
	[Address(RVA = "0x5204C0", Offset = "0x51EAC0", VA = "0x1805204C0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Board board = this.board;
	}

	// Token: 0x06001824 RID: 6180 RVA: 0x000837B8 File Offset: 0x000819B8
	[Token(Token = "0x6001824")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public DoomCabbage()
	{
	}
}
