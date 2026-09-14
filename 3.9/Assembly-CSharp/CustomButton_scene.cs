using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x0200084B RID: 2123
[Token(Token = "0x200084B")]
public class CustomButton_scene : TheButton
{
	// Token: 0x06002B40 RID: 11072 RVA: 0x000EAE88 File Offset: 0x000E9088
	[Token(Token = "0x6002B40")]
	[Address(RVA = "0x6669C0", Offset = "0x664FC0", VA = "0x1806669C0")]
	public CustomButton_scene()
	{
	}

	// Token: 0x04001947 RID: 6471
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001947")]
	public SceneType sceneType;

	// Token: 0x04001948 RID: 6472
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001948")]
	public TextMeshProUGUI sceneText;
}
