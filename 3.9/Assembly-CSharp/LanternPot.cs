using System;
using Cpp2IlInjected;

// Token: 0x020003E0 RID: 992
[Token(Token = "0x20003E0")]
public class LanternPot : Pot
{
	// Token: 0x06001218 RID: 4632 RVA: 0x000656F4 File Offset: 0x000638F4
	[Token(Token = "0x6001218")]
	[Address(RVA = "0x49B7F0", Offset = "0x499DF0", VA = "0x18049B7F0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		instance.AdjustLightLevel(originalColumn, originalRow, -1, num);
		CreatePlant.Instance.AdjustLightLevel(originalColumn, num, 1, num);
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00065728 File Offset: 0x00063928
	[Token(Token = "0x6001219")]
	[Address(RVA = "0x49B740", Offset = "0x499D40", VA = "0x18049B740", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		CreatePlant instance = CreatePlant.Instance;
		int num = 0;
		instance.AdjustLightLevel(theColumn, theRow, 1, num);
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00065758 File Offset: 0x00063958
	[Token(Token = "0x600121A")]
	[Address(RVA = "0x49B6A0", Offset = "0x499CA0", VA = "0x18049B6A0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int num = 0;
		int thePlantColumn = this.thePlantColumn;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, num);
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x0006578C File Offset: 0x0006398C
	[Token(Token = "0x600121B")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public LanternPot()
	{
	}
}
