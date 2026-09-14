using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008BA RID: 2234
[Token(Token = "0x20008BA")]
public class StarAdvantureLevelButton : UIButton
{
	// Token: 0x06002D96 RID: 11670 RVA: 0x000F9134 File Offset: 0x000F7334
	[Token(Token = "0x6002D96")]
	[Address(RVA = "0x6FE930", Offset = "0x6FCF30", VA = "0x1806FE930")]
	private void Awake()
	{
		if (this.mainLine)
		{
			int num = this.level;
			if ((num > 25 && num > 61) || num <= 61)
			{
			}
			GameObject gameObject = base.gameObject;
			List<AdvantureLevel> levelCompleted = AdvantureConfig.data.levelCompleted;
			bool flag;
			gameObject.SetActive(flag);
		}
		GameObject gameObject2 = this.trophy;
		List<AdvantureLevel> levelCompleted2 = AdvantureConfig.data.levelCompleted;
		bool flag2;
		gameObject2.SetActive(flag2);
	}

	// Token: 0x06002D97 RID: 11671 RVA: 0x000F91A0 File Offset: 0x000F73A0
	[Token(Token = "0x6002D97")]
	[Address(RVA = "0x6FEA80", Offset = "0x6FD080", VA = "0x1806FEA80", Slot = "9")]
	protected override void OnMouseUpAsButton()
	{
		ulong num2;
		do
		{
			int num = 0;
			base.OnMouseUpAsButton();
			List<BaseMenu> list = GameAPP.UIManager.Peak();
			bool flag;
			if (flag)
			{
				TypeCode typeCode = num.GetTypeCode();
			}
		}
		while (num2 != (ulong)0L);
		Action action;
		BlackMask.Instance.Active(action);
	}

	// Token: 0x06002D98 RID: 11672 RVA: 0x000F91F0 File Offset: 0x000F73F0
	[Token(Token = "0x6002D98")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public StarAdvantureLevelButton()
	{
	}

	// Token: 0x04001B6F RID: 7023
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001B6F")]
	public int level;

	// Token: 0x04001B70 RID: 7024
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001B70")]
	public GameObject trophy;

	// Token: 0x04001B71 RID: 7025
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001B71")]
	public bool mainLine;
}
