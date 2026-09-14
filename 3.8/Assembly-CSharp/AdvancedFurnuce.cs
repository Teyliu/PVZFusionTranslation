using System;
using Cpp2IlInjected;

// Token: 0x0200033E RID: 830
[Token(Token = "0x200033E")]
public class AdvancedFurnuce : PineFurnace
{
	// Token: 0x06000F36 RID: 3894 RVA: 0x00058AC4 File Offset: 0x00056CC4
	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x418910", Offset = "0x416F10", VA = "0x180418910", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
		this.attributeCount = (int)((ulong)60L);
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x00058AEC File Offset: 0x00056CEC
	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x4186A0", Offset = "0x416CA0", VA = "0x1804186A0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 3f;
		int size = this.board.griditemArray._size;
		int num = size - 1;
		if (size > 0)
		{
			GridItem gridItem = this.board.griditemArray[num];
			int num2 = 0;
			if (!(gridItem != num2) || gridItem != 0)
			{
			}
		}
		base.UpdateText();
		int num3 = 0;
		base.Die((Plant.DieReason)num3);
		CreatePlant instance = CreatePlant.Instance;
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x00058B68 File Offset: 0x00056D68
	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x418950", Offset = "0x416F50", VA = "0x180418950", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x00058B88 File Offset: 0x00056D88
	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x418A90", Offset = "0x417090", VA = "0x180418A90")]
	public AdvancedFurnuce()
	{
	}
}
