using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x02000897 RID: 2199
[Token(Token = "0x2000897")]
public class InputKeyMenu : BaseMenu
{
	// Token: 0x06002CE5 RID: 11493 RVA: 0x000F4BE0 File Offset: 0x000F2DE0
	[Token(Token = "0x6002CE5")]
	[Address(RVA = "0x6D0CB0", Offset = "0x6CF2B0", VA = "0x1806D0CB0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TMP_InputField inputField = this._InputField;
		string text = InputKeyMenu.key;
		inputField.text = text;
	}

	// Token: 0x06002CE6 RID: 11494 RVA: 0x000F4C10 File Offset: 0x000F2E10
	[Token(Token = "0x6002CE6")]
	[Address(RVA = "0x6D0D30", Offset = "0x6CF330", VA = "0x1806D0D30")]
	public void OnInputOver()
	{
		InputKeyMenu.key = this._InputField.m_Text;
		throw new NullReferenceException();
	}

	// Token: 0x06002CE7 RID: 11495 RVA: 0x000F4C34 File Offset: 0x000F2E34
	[Token(Token = "0x6002CE7")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public InputKeyMenu()
	{
	}

	// Token: 0x04001ACE RID: 6862
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001ACE")]
	public TMP_InputField _InputField;

	// Token: 0x04001ACF RID: 6863
	[Token(Token = "0x4001ACF")]
	public static string key = "";
}
