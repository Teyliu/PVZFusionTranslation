using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x0200085B RID: 2139
[Token(Token = "0x200085B")]
public class InputKeyMenu : BaseMenu
{
	// Token: 0x06002BB3 RID: 11187 RVA: 0x000EFF88 File Offset: 0x000EE188
	[Token(Token = "0x6002BB3")]
	[Address(RVA = "0x66C1A0", Offset = "0x66A7A0", VA = "0x18066C1A0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TMP_InputField inputField = this._InputField;
		string text = InputKeyMenu.key;
		inputField.text = text;
	}

	// Token: 0x06002BB4 RID: 11188 RVA: 0x000EFFB8 File Offset: 0x000EE1B8
	[Token(Token = "0x6002BB4")]
	[Address(RVA = "0x66C220", Offset = "0x66A820", VA = "0x18066C220")]
	public void OnInputOver()
	{
		InputKeyMenu.key = this._InputField.m_Text;
		throw new NullReferenceException();
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x000EFFDC File Offset: 0x000EE1DC
	[Token(Token = "0x6002BB5")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public InputKeyMenu()
	{
	}

	// Token: 0x040019E0 RID: 6624
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019E0")]
	public TMP_InputField _InputField;

	// Token: 0x040019E1 RID: 6625
	[Token(Token = "0x40019E1")]
	public static string key = "";
}
