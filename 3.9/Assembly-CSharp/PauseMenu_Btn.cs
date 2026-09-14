using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008A1 RID: 2209
[Token(Token = "0x20008A1")]
public class PauseMenu_Btn : MonoBehaviour
{
	// Token: 0x06002D21 RID: 11553 RVA: 0x000F5DC0 File Offset: 0x000F3FC0
	[Token(Token = "0x6002D21")]
	[Address(RVA = "0x6D46C0", Offset = "0x6D2CC0", VA = "0x1806D46C0")]
	private void Start()
	{
		RectTransform component = base.GetComponent<RectTransform>();
		this.rectTransform = component;
		Vector2 anchoredPosition = this.rectTransform.anchoredPosition;
		int num = 0;
		this.originPosition.z = (float)num;
	}

	// Token: 0x06002D22 RID: 11554 RVA: 0x000F5DFC File Offset: 0x000F3FFC
	[Token(Token = "0x6002D22")]
	[Address(RVA = "0x5906B0", Offset = "0x58ECB0", VA = "0x1805906B0")]
	private void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002D23 RID: 11555 RVA: 0x000F5E10 File Offset: 0x000F4010
	[Token(Token = "0x6002D23")]
	[Address(RVA = "0x6D3E40", Offset = "0x6D2440", VA = "0x1806D3E40")]
	private void OnMouseExit()
	{
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002D24 RID: 11556 RVA: 0x000F5E34 File Offset: 0x000F4034
	[Token(Token = "0x6002D24")]
	[Address(RVA = "0x6D3DA0", Offset = "0x6D23A0", VA = "0x1806D3DA0")]
	private void OnMouseDown()
	{
		GameAPP.PlaySound(28, 0.5f, 1f);
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06002D25 RID: 11557 RVA: 0x000F5E60 File Offset: 0x000F4060
	[Token(Token = "0x6002D25")]
	[Address(RVA = "0x6D3E80", Offset = "0x6D2480", VA = "0x1806D3E80")]
	private void OnMouseUp()
	{
		CursorChange.SetDefaultCursor();
		RectTransform rectTransform = this.rectTransform;
		if (this.buttonNumber <= 11)
		{
			Board instance = Board.Instance;
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			InGameText instance2 = InGameText.Instance;
			return;
		}
	}

	// Token: 0x06002D26 RID: 11558 RVA: 0x000F5FAC File Offset: 0x000F41AC
	[Token(Token = "0x6002D26")]
	[Address(RVA = "0x6D45A0", Offset = "0x6D2BA0", VA = "0x1806D45A0")]
	private void Restart()
	{
		Board.Instance.ClearTheBoard();
		GameAPP.UIManager.PopAll();
		Board.Instance.Die();
		int theBoardLevel = GameAPP.theBoardLevel;
		LevelType theBoardType = GameAPP.theBoardType;
		string theIZLevelName = GameAPP.theIZLevelName;
		uint num;
		UIMgr.EnterGame(theBoardType, theBoardLevel, (int)num, theIZLevelName);
	}

	// Token: 0x06002D27 RID: 11559 RVA: 0x000F5FFC File Offset: 0x000F41FC
	[Token(Token = "0x6002D27")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public PauseMenu_Btn()
	{
	}

	// Token: 0x04001B07 RID: 6919
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B07")]
	public int buttonNumber;

	// Token: 0x04001B08 RID: 6920
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B08")]
	public GameObject thisMenu;

	// Token: 0x04001B09 RID: 6921
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001B09")]
	private Vector3 originPosition;

	// Token: 0x04001B0A RID: 6922
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B0A")]
	private RectTransform rectTransform;
}
