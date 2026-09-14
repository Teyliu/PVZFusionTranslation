using System;
using Cpp2IlInjected;

// Token: 0x020004EB RID: 1259
[Token(Token = "0x20004EB")]
public class CabbagePuff : Thrower
{
	// Token: 0x060017C0 RID: 6080 RVA: 0x00081D64 File Offset: 0x0007FF64
	[Token(Token = "0x60017C0")]
	[Address(RVA = "0x50B740", Offset = "0x509D40", VA = "0x18050B740", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_small;
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x00081D78 File Offset: 0x0007FF78
	[Token(Token = "0x60017C1")]
	[Address(RVA = "0x50B750", Offset = "0x509D50", VA = "0x18050B750", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x00081D88 File Offset: 0x0007FF88
	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x50B780", Offset = "0x509D80", VA = "0x18050B780", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x00081D98 File Offset: 0x0007FF98
	[Token(Token = "0x60017C3")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public CabbagePuff()
	{
	}
}
