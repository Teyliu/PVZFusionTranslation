using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007F3 RID: 2035
[Token(Token = "0x20007F3")]
public class ThanksMenu : BaseMenu
{
	// Token: 0x06002936 RID: 10550 RVA: 0x000DEB7C File Offset: 0x000DCD7C
	[Token(Token = "0x6002936")]
	[Address(RVA = "0x694ED0", Offset = "0x6934D0", VA = "0x180694ED0")]
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			UIMgr.EnterMainMenu();
			return;
		}
	}

	// Token: 0x06002937 RID: 10551 RVA: 0x000DEBA8 File Offset: 0x000DCDA8
	[Token(Token = "0x6002937")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public ThanksMenu()
	{
	}
}
