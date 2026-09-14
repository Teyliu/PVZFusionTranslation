using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000737 RID: 1847
[Token(Token = "0x2000737")]
public class CustomLevelEnter : UIBtn
{
	// Token: 0x0600259D RID: 9629 RVA: 0x000C649C File Offset: 0x000C469C
	[Token(Token = "0x600259D")]
	[Address(RVA = "0x5C04A0", Offset = "0x5BEAA0", VA = "0x1805C04A0")]
	private void Start()
	{
		HashSet<string> nameLevelCompleted = GameAPP.nameLevelCompleted;
		string text = this.levelName;
		if (nameLevelCompleted.Contains(text))
		{
			base.transform.GetChild(1).gameObject.SetActive(true);
			return;
		}
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x000C64E0 File Offset: 0x000C46E0
	[Token(Token = "0x600259E")]
	[Address(RVA = "0x5C0410", Offset = "0x5BEA10", VA = "0x1805C0410", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		GameAPP.UIManager.PopAll();
		string text = this.levelName;
		UIMgr.EnterIZGame(27, text, (SceneType)((uint)25));
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x000C6518 File Offset: 0x000C4718
	[Token(Token = "0x600259F")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public CustomLevelEnter()
	{
	}

	// Token: 0x040012F0 RID: 4848
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40012F0")]
	public string levelName;

	// Token: 0x040012F1 RID: 4849
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40012F1")]
	public Transform menu;
}
