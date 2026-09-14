using System;
using Cpp2IlInjected;

// Token: 0x020004FF RID: 1279
[Token(Token = "0x20004FF")]
public class CornCabbage : Cornpult
{
	// Token: 0x06001807 RID: 6151 RVA: 0x00083398 File Offset: 0x00081598
	[Token(Token = "0x6001807")]
	[Address(RVA = "0x51F6F0", Offset = "0x51DCF0", VA = "0x18051F6F0", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
		PotEffects.CabbagePotEffect(this, theColumn, theRow, 3f, (float)num);
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x000833C0 File Offset: 0x000815C0
	[Token(Token = "0x6001808")]
	[Address(RVA = "0x51F760", Offset = "0x51DD60", VA = "0x18051F760", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x000833D0 File Offset: 0x000815D0
	[Token(Token = "0x6001809")]
	[Address(RVA = "0x51F6E0", Offset = "0x51DCE0", VA = "0x18051F6E0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_bigKernal;
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x000833E0 File Offset: 0x000815E0
	[Token(Token = "0x600180A")]
	[Address(RVA = "0x51F6D0", Offset = "0x51DCD0", VA = "0x18051F6D0", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_bigButter;
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x000833F0 File Offset: 0x000815F0
	[Token(Token = "0x600180B")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public CornCabbage()
	{
	}
}
