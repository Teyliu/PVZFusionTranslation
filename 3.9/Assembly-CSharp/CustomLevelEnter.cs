using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000770 RID: 1904
[Token(Token = "0x2000770")]
public class CustomLevelEnter : UIBtn
{
	// Token: 0x060026C2 RID: 9922 RVA: 0x000CB380 File Offset: 0x000C9580
	[Token(Token = "0x60026C2")]
	[Address(RVA = "0x621020", Offset = "0x61F620", VA = "0x180621020")]
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

	// Token: 0x060026C3 RID: 9923 RVA: 0x000CB3C4 File Offset: 0x000C95C4
	[Token(Token = "0x60026C3")]
	[Address(RVA = "0x620F90", Offset = "0x61F590", VA = "0x180620F90", Slot = "7")]
	protected override void OnMouseUpAsButton()
	{
		base.OnMouseUpAsButton();
		GameAPP.UIManager.PopAll();
		string text = this.levelName;
		UIMgr.EnterIZGame(27, text, (SceneType)((uint)25));
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x000CB3FC File Offset: 0x000C95FC
	[Token(Token = "0x60026C4")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public CustomLevelEnter()
	{
	}

	// Token: 0x040013C6 RID: 5062
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40013C6")]
	public string levelName;

	// Token: 0x040013C7 RID: 5063
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40013C7")]
	public Transform menu;
}
