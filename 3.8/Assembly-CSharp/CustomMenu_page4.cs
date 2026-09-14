using System;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine.UI;

// Token: 0x020009DC RID: 2524
[Token(Token = "0x20009DC")]
public class CustomMenu_page4 : CustomMenu_page
{
	// Token: 0x060033DF RID: 13279 RVA: 0x00114314 File Offset: 0x00112514
	[Token(Token = "0x60033DF")]
	[Address(RVA = "0x71A870", Offset = "0x718E70", VA = "0x18071A870", Slot = "4")]
	public override void LoadOriginalSettings()
	{
		VictoryType victoryType = CustomMenu._levelData.victoryType;
		if (victoryType == VictoryType.DefaultVictory)
		{
			this.DefaultVictory.isOn = true;
			return;
		}
		while (victoryType != VictoryType.IZVictory)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060033E0 RID: 13280 RVA: 0x00114348 File Offset: 0x00112548
	[Token(Token = "0x60033E0")]
	[Address(RVA = "0x71A8F0", Offset = "0x718EF0", VA = "0x18071A8F0", Slot = "6")]
	public override void OnExport()
	{
		Toggle firstActiveToggle = this.toggleGroup.GetFirstActiveToggle();
		Toggle defaultVictory = this.DefaultVictory;
		if (!(firstActiveToggle == defaultVictory))
		{
			Toggle izvictory = this.IZVictory;
			if (firstActiveToggle == izvictory)
			{
				CustomMenu._levelData.victoryType = (VictoryType)((ulong)1L);
			}
			return;
		}
		CustomMenu._levelData.victoryType = (VictoryType)((ulong)0L);
	}

	// Token: 0x060033E1 RID: 13281 RVA: 0x001143A4 File Offset: 0x001125A4
	[Token(Token = "0x60033E1")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public CustomMenu_page4()
	{
	}

	// Token: 0x04002565 RID: 9573
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002565")]
	public ToggleGroup toggleGroup;

	// Token: 0x04002566 RID: 9574
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002566")]
	public Toggle DefaultVictory;

	// Token: 0x04002567 RID: 9575
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002567")]
	public Toggle IZVictory;
}
