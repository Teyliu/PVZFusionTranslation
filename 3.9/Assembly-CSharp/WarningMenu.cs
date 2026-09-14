using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008DF RID: 2271
[Token(Token = "0x20008DF")]
public class WarningMenu : BaseMenu
{
	// Token: 0x06002E40 RID: 11840 RVA: 0x000FCFBC File Offset: 0x000FB1BC
	[Token(Token = "0x6002E40")]
	[Address(RVA = "0x70FD80", Offset = "0x70E380", VA = "0x18070FD80")]
	private void Start()
	{
		Time.timeScale = (float)0;
	}

	// Token: 0x06002E41 RID: 11841 RVA: 0x000FCFD8 File Offset: 0x000FB1D8
	[Token(Token = "0x6002E41")]
	[Address(RVA = "0x70F900", Offset = "0x70DF00", VA = "0x18070F900")]
	public void EnableChallengeMode()
	{
		while (this.challenge.activeSelf)
		{
			ulong num;
			InGameUI.Instance.ShowCardBank.SetActive(num != 0UL);
			TravelMgr.Instance.data.invest_challenge = true;
			TravelData data = TravelMgr.Instance.data;
			List<CardUI> childs = global::Core.Lawnf.GetChilds<CardUI>(InGameUI.Instance.transform);
			bool flag;
			if (flag)
			{
				uint num2;
				num2 -= (flag ? 1U : 0U);
				ulong num3;
				num3 += num3;
			}
			ulong num4;
			if (num4 == (ulong)0L)
			{
				TravelMgr instance = TravelMgr.Instance;
				TravelMgr instance2 = TravelMgr.Instance;
				TravelMgr instance3 = TravelMgr.Instance;
				TravelMgr instance4 = TravelMgr.Instance;
				Board instance5 = Board.Instance;
				int num5 = 0;
				instance5.GetPoint(7000f, num5 != 0);
				Time.timeScale = GameAPP.config.gameSpeed;
				return;
			}
		}
		GameObject gameObject = this.tutor;
		int num6 = 0;
		gameObject.SetActive(num6 != 0);
		ulong num7;
		this.challenge.SetActive(num7 != 0UL);
		InGameText instance6 = InGameText.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06002E42 RID: 11842 RVA: 0x000FD0E0 File Offset: 0x000FB2E0
	[Token(Token = "0x6002E42")]
	[Address(RVA = "0x70F860", Offset = "0x70DE60", VA = "0x18070F860")]
	public void Cancel()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		throw new NullReferenceException();
	}

	// Token: 0x06002E43 RID: 11843 RVA: 0x000FD104 File Offset: 0x000FB304
	[Token(Token = "0x6002E43")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public WarningMenu()
	{
	}

	// Token: 0x04001C1A RID: 7194
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001C1A")]
	public GameObject tutor;

	// Token: 0x04001C1B RID: 7195
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001C1B")]
	public GameObject challenge;
}
