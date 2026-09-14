using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200087E RID: 2174
[Token(Token = "0x200087E")]
public class StarAdvantureLevelButton : UIButton
{
	// Token: 0x06002C64 RID: 11364 RVA: 0x000F44A0 File Offset: 0x000F26A0
	[Token(Token = "0x6002C64")]
	[Address(RVA = "0x685370", Offset = "0x683970", VA = "0x180685370")]
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

	// Token: 0x06002C65 RID: 11365 RVA: 0x000F450C File Offset: 0x000F270C
	[Token(Token = "0x6002C65")]
	[Address(RVA = "0x6854C0", Offset = "0x683AC0", VA = "0x1806854C0", Slot = "9")]
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

	// Token: 0x06002C66 RID: 11366 RVA: 0x000F455C File Offset: 0x000F275C
	[Token(Token = "0x6002C66")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public StarAdvantureLevelButton()
	{
	}

	// Token: 0x04001A81 RID: 6785
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001A81")]
	public int level;

	// Token: 0x04001A82 RID: 6786
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001A82")]
	public GameObject trophy;

	// Token: 0x04001A83 RID: 6787
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001A83")]
	public bool mainLine;
}
