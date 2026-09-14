using System;
using Cpp2IlInjected;

// Token: 0x0200034E RID: 846
[Token(Token = "0x200034E")]
public class AdvancedFurnuce : PineFurnace
{
	// Token: 0x06000F81 RID: 3969 RVA: 0x00059A78 File Offset: 0x00057C78
	[Token(Token = "0x6000F81")]
	[Address(RVA = "0x46F7E0", Offset = "0x46DDE0", VA = "0x18046F7E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
		this.attributeCount = (int)((ulong)60L);
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00059AA0 File Offset: 0x00057CA0
	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x46F4B0", Offset = "0x46DAB0", VA = "0x18046F4B0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 3f;
		int size = this.board.griditemArray._size;
		int num = size - 1;
		if (size > 0)
		{
			GridItem gridItem = this.board.griditemArray[num];
			int num2 = 0;
			if (gridItem != num2 && gridItem != 0)
			{
				CreateItem instance = CreateItem.Instance;
			}
		}
		base.UpdateText();
		int num3 = 0;
		base.Die((Plant.DieReason)num3);
		CreatePlant instance2 = CreatePlant.Instance;
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00059B28 File Offset: 0x00057D28
	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x46F820", Offset = "0x46DE20", VA = "0x18046F820", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00059B48 File Offset: 0x00057D48
	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x46F960", Offset = "0x46DF60", VA = "0x18046F960")]
	public AdvancedFurnuce()
	{
	}
}
