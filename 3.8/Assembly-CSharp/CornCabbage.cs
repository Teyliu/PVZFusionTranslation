using System;
using Cpp2IlInjected;

// Token: 0x020004D7 RID: 1239
[Token(Token = "0x20004D7")]
public class CornCabbage : Cornpult
{
	// Token: 0x06001750 RID: 5968 RVA: 0x000800C4 File Offset: 0x0007E2C4
	[Token(Token = "0x6001750")]
	[Address(RVA = "0x49F9A0", Offset = "0x49DFA0", VA = "0x18049F9A0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
		PotEffects.CabbagePotEffect(this, theColumn, theRow, 3f, (float)num);
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x000800EC File Offset: 0x0007E2EC
	[Token(Token = "0x6001751")]
	[Address(RVA = "0x49FA10", Offset = "0x49E010", VA = "0x18049FA10", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001752 RID: 5970 RVA: 0x000800FC File Offset: 0x0007E2FC
	[Token(Token = "0x6001752")]
	[Address(RVA = "0x49F990", Offset = "0x49DF90", VA = "0x18049F990", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_bigKernal;
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x0008010C File Offset: 0x0007E30C
	[Token(Token = "0x6001753")]
	[Address(RVA = "0x49F980", Offset = "0x49DF80", VA = "0x18049F980", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_bigButter;
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x0008011C File Offset: 0x0007E31C
	[Token(Token = "0x6001754")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public CornCabbage()
	{
	}
}
