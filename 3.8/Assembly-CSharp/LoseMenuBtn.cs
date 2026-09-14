using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200024C RID: 588
[Token(Token = "0x200024C")]
public class LoseMenuBtn : MonoBehaviour
{
	// Token: 0x06000A52 RID: 2642 RVA: 0x00039550 File Offset: 0x00037750
	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x8A5740", Offset = "0x8A3D40", VA = "0x1808A5740")]
	private void Start()
	{
		RectTransform component = base.GetComponent<RectTransform>();
		this.rectTransform = component;
		Vector2 anchoredPosition = this.rectTransform.anchoredPosition;
		int num = 0;
		this.originPosition.z = (float)num;
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x0003958C File Offset: 0x0003778C
	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x525520", Offset = "0x523B20", VA = "0x180525520")]
	private void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x000395A0 File Offset: 0x000377A0
	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x8A5390", Offset = "0x8A3990", VA = "0x1808A5390")]
	private void OnMouseExit()
	{
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x000395C4 File Offset: 0x000377C4
	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x8A52F0", Offset = "0x8A38F0", VA = "0x1808A52F0")]
	private void OnMouseDown()
	{
		GameAPP.PlaySound(28, 0.5f, 1f);
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x000395F0 File Offset: 0x000377F0
	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x8A53D0", Offset = "0x8A39D0", VA = "0x1808A53D0")]
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
					int num3 = 0;
					instance3.ShowText("非普通神秘只能在主菜单进入", 3f, num3 != 0);
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
				int num4 = 0;
				uint num5;
				UIMgr.EnterGame(theBoardType, theBoardLevel, (int)num5, num4);
			}
			return;
		}
		Board.Instance.ClearTheBoard();
		Board.Instance.Die();
		GameAPP.board = 0;
		UIMgr.EnterMainMenu();
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x000396E8 File Offset: 0x000378E8
	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public LoseMenuBtn()
	{
	}

	// Token: 0x040005D0 RID: 1488
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005D0")]
	public LoseMenuBtn.LoseBtnType type;

	// Token: 0x040005D1 RID: 1489
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40005D1")]
	private Vector3 originPosition;

	// Token: 0x040005D2 RID: 1490
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005D2")]
	private RectTransform rectTransform;

	// Token: 0x0200024D RID: 589
	[Token(Token = "0x200024D")]
	public enum LoseBtnType
	{
		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		Quit,
		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		Restart,
		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		TryAgain
	}
}
