using System;
using Cpp2IlInjected;

// Token: 0x0200043F RID: 1087
[Token(Token = "0x200043F")]
public class SniperPot : PeaPot
{
	// Token: 0x06001402 RID: 5122 RVA: 0x0006F700 File Offset: 0x0006D900
	[Token(Token = "0x6001402")]
	[Address(RVA = "0x4BDC40", Offset = "0x4BC240", VA = "0x1804BDC40", Slot = "68")]
	protected override void OnPlantShoot(object obj)
	{
		if (obj != 0)
		{
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			int num = this.attributeCount;
			num++;
			this.attributeCount = num;
			if (num == 6)
			{
				this.attributeCount = (int)((ulong)0L);
			}
		}
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x0006F740 File Offset: 0x0006D940
	[Token(Token = "0x6001403")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SniperPot()
	{
	}
}
