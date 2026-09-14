using System;
using Cpp2IlInjected;

// Token: 0x02000420 RID: 1056
[Token(Token = "0x2000420")]
public class SniperPot : PeaPot
{
	// Token: 0x06001378 RID: 4984 RVA: 0x0006D458 File Offset: 0x0006B658
	[Token(Token = "0x6001378")]
	[Address(RVA = "0x466C50", Offset = "0x465250", VA = "0x180466C50", Slot = "69")]
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

	// Token: 0x06001379 RID: 4985 RVA: 0x0006D498 File Offset: 0x0006B698
	[Token(Token = "0x6001379")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SniperPot()
	{
	}
}
