using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007BA RID: 1978
[Token(Token = "0x20007BA")]
public class ThanksMenu : BaseMenu
{
	// Token: 0x06002807 RID: 10247 RVA: 0x000D9BC0 File Offset: 0x000D7DC0
	[Token(Token = "0x6002807")]
	[Address(RVA = "0x631100", Offset = "0x62F700", VA = "0x180631100")]
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			UIMgr.EnterMainMenu();
			return;
		}
	}

	// Token: 0x06002808 RID: 10248 RVA: 0x000D9BEC File Offset: 0x000D7DEC
	[Token(Token = "0x6002808")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public ThanksMenu()
	{
	}
}
