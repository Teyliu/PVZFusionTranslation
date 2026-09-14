using System;
using Cpp2IlInjected;

// Token: 0x020004D9 RID: 1241
[Token(Token = "0x20004D9")]
public class CornMelon : Cornpult
{
	// Token: 0x0600175A RID: 5978 RVA: 0x000802DC File Offset: 0x0007E4DC
	[Token(Token = "0x600175A")]
	[Address(RVA = "0x4A0180", Offset = "0x49E780", VA = "0x1804A0180", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cornMelon;
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x000802EC File Offset: 0x0007E4EC
	[Token(Token = "0x600175B")]
	[Address(RVA = "0x4A0170", Offset = "0x49E770", VA = "0x1804A0170", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butterMelon;
	}

	// Token: 0x0600175C RID: 5980 RVA: 0x000802FC File Offset: 0x0007E4FC
	[Token(Token = "0x600175C")]
	[Address(RVA = "0x4A0190", Offset = "0x49E790", VA = "0x1804A0190", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x0008031C File Offset: 0x0007E51C
	[Token(Token = "0x600175D")]
	[Address(RVA = "0x4A01F0", Offset = "0x49E7F0", VA = "0x1804A01F0", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x0008032C File Offset: 0x0007E52C
	[Token(Token = "0x600175E")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public CornMelon()
	{
	}
}
