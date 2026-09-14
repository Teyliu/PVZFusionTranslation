using System;
using Cpp2IlInjected;

// Token: 0x020003CC RID: 972
[Token(Token = "0x20003CC")]
public class LanternPot : Pot
{
	// Token: 0x060011BC RID: 4540 RVA: 0x000640DC File Offset: 0x000622DC
	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x447360", Offset = "0x445960", VA = "0x180447360", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		instance.AdjustLightLevel(originalColumn, originalRow, -1, num);
		CreatePlant.Instance.AdjustLightLevel(originalColumn, num, 1, num);
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00064110 File Offset: 0x00062310
	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x4472B0", Offset = "0x4458B0", VA = "0x1804472B0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		instance.AdjustLightLevel(theColumn, theRow, 1, num);
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00064140 File Offset: 0x00062340
	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x447210", Offset = "0x445810", VA = "0x180447210", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int num = 0;
		int thePlantColumn = this.thePlantColumn;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, num);
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00064174 File Offset: 0x00062374
	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public LanternPot()
	{
	}
}
