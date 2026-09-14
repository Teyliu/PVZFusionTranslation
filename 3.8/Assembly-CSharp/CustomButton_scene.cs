using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x0200080D RID: 2061
[Token(Token = "0x200080D")]
public class CustomButton_scene : TheButton
{
	// Token: 0x06002A02 RID: 10754 RVA: 0x000E5B48 File Offset: 0x000E3D48
	[Token(Token = "0x6002A02")]
	[Address(RVA = "0x6031B0", Offset = "0x6017B0", VA = "0x1806031B0")]
	public CustomButton_scene()
	{
	}

	// Token: 0x0400184B RID: 6219
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400184B")]
	public SceneType sceneType;

	// Token: 0x0400184C RID: 6220
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400184C")]
	public TextMeshProUGUI sceneText;
}
