using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000780 RID: 1920
[Token(Token = "0x2000780")]
public class RoguelikeManager : MonoBehaviour
{
	// Token: 0x060026CE RID: 9934 RVA: 0x000CF3C0 File Offset: 0x000CD5C0
	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public RoguelikeManager()
	{
	}

	// Token: 0x0400149E RID: 5278
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400149E")]
	public int theMaxRound;

	// Token: 0x0400149F RID: 5279
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400149F")]
	public int theCurrentRound;

	// Token: 0x040014A0 RID: 5280
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014A0")]
	public SceneType theCurrentSceneType;
}
