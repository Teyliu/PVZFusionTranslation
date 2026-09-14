using System;
using Cpp2IlInjected;

// Token: 0x02000352 RID: 850
[Token(Token = "0x2000352")]
public class CabbageNut : MelonNut
{
	// Token: 0x06000F8F RID: 3983 RVA: 0x0005A390 File Offset: 0x00058590
	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x41CE10", Offset = "0x41B410", VA = "0x18041CE10", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage;
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x0005A3A0 File Offset: 0x000585A0
	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x41DAB0", Offset = "0x41C0B0", VA = "0x18041DAB0", Slot = "70")]
	protected override void SaveDamage(int damage)
	{
		if (damage <= 100 || damage <= 500 || damage > 1000)
		{
		}
		int num = this.attributeCount;
		num += damage;
		this.attributeCount = num;
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.attributeCount = thePlantMaxHealth;
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x0005A3E4 File Offset: 0x000585E4
	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public CabbageNut()
	{
	}
}
