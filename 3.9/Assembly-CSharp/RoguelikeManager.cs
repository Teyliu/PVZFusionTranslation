using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007B9 RID: 1977
[Token(Token = "0x20007B9")]
public class RoguelikeManager : MonoBehaviour
{
	// Token: 0x060027FD RID: 10237 RVA: 0x000D43EC File Offset: 0x000D25EC
	[Token(Token = "0x60027FD")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public RoguelikeManager()
	{
	}

	// Token: 0x0400157A RID: 5498
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400157A")]
	public int theMaxRound;

	// Token: 0x0400157B RID: 5499
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400157B")]
	public int theCurrentRound;

	// Token: 0x0400157C RID: 5500
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400157C")]
	public SceneType theCurrentSceneType;
}
