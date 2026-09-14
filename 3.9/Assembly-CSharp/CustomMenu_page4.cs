using System;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine.UI;

// Token: 0x02000A18 RID: 2584
[Token(Token = "0x2000A18")]
public class CustomMenu_page4 : CustomMenu_page
{
	// Token: 0x06003513 RID: 13587 RVA: 0x00119278 File Offset: 0x00117478
	[Token(Token = "0x6003513")]
	[Address(RVA = "0x77FDE0", Offset = "0x77E3E0", VA = "0x18077FDE0", Slot = "4")]
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

	// Token: 0x06003514 RID: 13588 RVA: 0x001192AC File Offset: 0x001174AC
	[Token(Token = "0x6003514")]
	[Address(RVA = "0x77FE60", Offset = "0x77E460", VA = "0x18077FE60", Slot = "6")]
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

	// Token: 0x06003515 RID: 13589 RVA: 0x00119308 File Offset: 0x00117508
	[Token(Token = "0x6003515")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public CustomMenu_page4()
	{
	}

	// Token: 0x04002677 RID: 9847
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002677")]
	public ToggleGroup toggleGroup;

	// Token: 0x04002678 RID: 9848
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002678")]
	public Toggle DefaultVictory;

	// Token: 0x04002679 RID: 9849
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002679")]
	public Toggle IZVictory;
}
