using System;
using Cpp2IlInjected;

// Token: 0x020003CD RID: 973
[Token(Token = "0x20003CD")]
public class LanternPumpkin : Pumpkin
{
	// Token: 0x060011C0 RID: 4544 RVA: 0x00064188 File Offset: 0x00062388
	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x447640", Offset = "0x445C40", VA = "0x180447640", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x000641A8 File Offset: 0x000623A8
	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x447430", Offset = "0x445A30", VA = "0x180447430", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x000641DC File Offset: 0x000623DC
	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x447570", Offset = "0x445B70", VA = "0x180447570", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x0006420C File Offset: 0x0006240C
	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x4474C0", Offset = "0x445AC0", VA = "0x1804474C0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x00064238 File Offset: 0x00062438
	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x446CB0", Offset = "0x4452B0", VA = "0x180446CB0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		ulong num3;
		base.Recover(15f, (DamageType)num, num2 != 0UL, num3 != 0UL);
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00064264 File Offset: 0x00062464
	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public LanternPumpkin()
	{
	}
}
