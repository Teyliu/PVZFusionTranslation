using System;
using Cpp2IlInjected;

// Token: 0x02000362 RID: 866
[Token(Token = "0x2000362")]
public class CabbageNut : MelonNut
{
	// Token: 0x06000FDB RID: 4059 RVA: 0x0005B310 File Offset: 0x00059510
	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0x473CB0", Offset = "0x4722B0", VA = "0x180473CB0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage;
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x0005B320 File Offset: 0x00059520
	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0x474950", Offset = "0x472F50", VA = "0x180474950", Slot = "69")]
	protected override void SaveDamage(int damage)
	{
		if (damage <= 100 || damage <= 500 || damage > 1000)
		{
		}
		Board board = this.board;
		this.attributeCount = damage;
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.attributeCount = thePlantMaxHealth;
		throw new NullReferenceException();
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x0005B364 File Offset: 0x00059564
	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public CabbageNut()
	{
	}
}
