using System;
using Cpp2IlInjected;

// Token: 0x020005A6 RID: 1446
[Token(Token = "0x20005A6")]
public class SunCabbage : Cabbage
{
	// Token: 0x06001ABA RID: 6842 RVA: 0x0008F594 File Offset: 0x0008D794
	[Token(Token = "0x6001ABA")]
	[Address(RVA = "0x541530", Offset = "0x53FB30", VA = "0x180541530", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_sunCabbage;
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x0008F5A4 File Offset: 0x0008D7A4
	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0x547620", Offset = "0x545C20", VA = "0x180547620", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x0008F5B4 File Offset: 0x0008D7B4
	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x547650", Offset = "0x545C50", VA = "0x180547650", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x0008F5C4 File Offset: 0x0008D7C4
	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public SunCabbage()
	{
	}
}
