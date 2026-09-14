using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000252 RID: 594
[Token(Token = "0x2000252")]
public class LoseMenuBtn : MonoBehaviour
{
	// Token: 0x06000A6D RID: 2669 RVA: 0x00039374 File Offset: 0x00037574
	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0x935730", Offset = "0x933D30", VA = "0x180935730")]
	private void Start()
	{
		RectTransform component = base.GetComponent<RectTransform>();
		this.rectTransform = component;
		Vector2 anchoredPosition = this.rectTransform.anchoredPosition;
		int num = 0;
		this.originPosition.z = (float)num;
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x000393B0 File Offset: 0x000375B0
	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x5906B0", Offset = "0x58ECB0", VA = "0x1805906B0")]
	private void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x000393C4 File Offset: 0x000375C4
	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0x935370", Offset = "0x933970", VA = "0x180935370")]
	private void OnMouseExit()
	{
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x000393E8 File Offset: 0x000375E8
	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x9352D0", Offset = "0x9338D0", VA = "0x1809352D0")]
	private void OnMouseDown()
	{
		GameAPP.PlaySound(28, 0.5f, 1f);
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00039414 File Offset: 0x00037614
	[Token(Token = "0x6000A71")]
	[Address(RVA = "0x9353B0", Offset = "0x9339B0", VA = "0x1809353B0")]
	private void OnMouseUp()
	{
		CursorChange.SetDefaultCursor();
		Zuma instance = Zuma.Instance;
		int num = 0;
		if (instance != num)
		{
			global::UnityEngine.Object.Destroy(Zuma.Instance.gameObject);
			while (this.type != LoseMenuBtn.LoseBtnType.Restart)
			{
			}
			throw new NullReferenceException();
		}
		LoseMenuBtn.LoseBtnType loseBtnType = this.type;
		if (loseBtnType != LoseMenuBtn.LoseBtnType.Quit)
		{
			if (loseBtnType != LoseMenuBtn.LoseBtnType.Quit)
			{
				if (loseBtnType == LoseMenuBtn.LoseBtnType.Restart)
				{
					Board instance2 = Board.Instance;
					uint num2;
					GameAPP.PlaySound((int)num2, 0.5f, 1f);
					InGameText instance3 = InGameText.Instance;
					return;
				}
			}
			else
			{
				Board.Instance.ClearTheBoard();
				Board.Instance.Die();
				GameAPP.board = 0;
				LevelType theBoardType = GameAPP.theBoardType;
				int theBoardLevel = GameAPP.theBoardLevel;
				int num3 = 0;
				uint num4;
				UIMgr.EnterGame(theBoardType, theBoardLevel, (int)num4, num3);
			}
			return;
		}
		Board.Instance.ClearTheBoard();
		Board.Instance.Die();
		GameAPP.board = 0;
		UIMgr.EnterMainMenu();
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x000394F0 File Offset: 0x000376F0
	[Token(Token = "0x6000A72")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public LoseMenuBtn()
	{
	}

	// Token: 0x040005DB RID: 1499
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005DB")]
	public LoseMenuBtn.LoseBtnType type;

	// Token: 0x040005DC RID: 1500
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40005DC")]
	private Vector3 originPosition;

	// Token: 0x040005DD RID: 1501
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005DD")]
	private RectTransform rectTransform;

	// Token: 0x02000253 RID: 595
	[Token(Token = "0x2000253")]
	public enum LoseBtnType
	{
		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		Quit,
		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		Restart,
		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		TryAgain
	}
}
