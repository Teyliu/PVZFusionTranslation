using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008A3 RID: 2211
[Token(Token = "0x20008A3")]
public class WarningMenu : BaseMenu
{
	// Token: 0x06002D0D RID: 11533 RVA: 0x000F8424 File Offset: 0x000F6624
	[Token(Token = "0x6002D0D")]
	[Address(RVA = "0x695D20", Offset = "0x694320", VA = "0x180695D20")]
	private void Start()
	{
		Time.timeScale = (float)0;
	}

	// Token: 0x06002D0E RID: 11534 RVA: 0x000F8440 File Offset: 0x000F6640
	[Token(Token = "0x6002D0E")]
	[Address(RVA = "0x6958B0", Offset = "0x693EB0", VA = "0x1806958B0")]
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
		int num8 = 0;
		instance6.ShowText("再次点击挑战模式进入游戏", 3f, num8 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06002D0F RID: 11535 RVA: 0x000F855C File Offset: 0x000F675C
	[Token(Token = "0x6002D0F")]
	[Address(RVA = "0x695810", Offset = "0x693E10", VA = "0x180695810")]
	public void Cancel()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		throw new NullReferenceException();
	}

	// Token: 0x06002D10 RID: 11536 RVA: 0x000F8580 File Offset: 0x000F6780
	[Token(Token = "0x6002D10")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public WarningMenu()
	{
	}

	// Token: 0x04001B2A RID: 6954
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B2A")]
	public GameObject tutor;

	// Token: 0x04001B2B RID: 6955
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B2B")]
	public GameObject challenge;
}
