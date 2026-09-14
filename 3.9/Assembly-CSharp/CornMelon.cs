using System;
using Cpp2IlInjected;

// Token: 0x02000501 RID: 1281
[Token(Token = "0x2000501")]
public class CornMelon : Cornpult
{
	// Token: 0x06001811 RID: 6161 RVA: 0x0008355C File Offset: 0x0008175C
	[Token(Token = "0x6001811")]
	[Address(RVA = "0x51FE30", Offset = "0x51E430", VA = "0x18051FE30", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cornMelon;
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x0008356C File Offset: 0x0008176C
	[Token(Token = "0x6001812")]
	[Address(RVA = "0x51FE20", Offset = "0x51E420", VA = "0x18051FE20", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_butterMelon;
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x0008357C File Offset: 0x0008177C
	[Token(Token = "0x6001813")]
	[Address(RVA = "0x51FE40", Offset = "0x51E440", VA = "0x18051FE40", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x0008359C File Offset: 0x0008179C
	[Token(Token = "0x6001814")]
	[Address(RVA = "0x51FEA0", Offset = "0x51E4A0", VA = "0x18051FEA0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001815 RID: 6165 RVA: 0x000835AC File Offset: 0x000817AC
	[Token(Token = "0x6001815")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public CornMelon()
	{
	}
}
