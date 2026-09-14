using System;
using Cpp2IlInjected;

// Token: 0x020003E1 RID: 993
[Token(Token = "0x20003E1")]
public class LanternPumpkin : Pumpkin
{
	// Token: 0x0600121C RID: 4636 RVA: 0x000657A0 File Offset: 0x000639A0
	[Token(Token = "0x600121C")]
	[Address(RVA = "0x49BAD0", Offset = "0x49A0D0", VA = "0x18049BAD0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x000657C0 File Offset: 0x000639C0
	[Token(Token = "0x600121D")]
	[Address(RVA = "0x49B8C0", Offset = "0x499EC0", VA = "0x18049B8C0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x000657F4 File Offset: 0x000639F4
	[Token(Token = "0x600121E")]
	[Address(RVA = "0x49BA00", Offset = "0x49A000", VA = "0x18049BA00", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x00065824 File Offset: 0x00063A24
	[Token(Token = "0x600121F")]
	[Address(RVA = "0x49B950", Offset = "0x499F50", VA = "0x18049B950", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x00065850 File Offset: 0x00063A50
	[Token(Token = "0x6001220")]
	[Address(RVA = "0x49B140", Offset = "0x499740", VA = "0x18049B140", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		ulong num3;
		base.Recover(15f, (DamageType)num, num2 != 0UL, num3 != 0UL);
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x0006587C File Offset: 0x00063A7C
	[Token(Token = "0x6001221")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public LanternPumpkin()
	{
	}
}
