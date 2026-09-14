using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000865 RID: 2149
[Token(Token = "0x2000865")]
public class PauseMenu_Btn : MonoBehaviour
{
	// Token: 0x06002BEF RID: 11247 RVA: 0x000F1130 File Offset: 0x000EF330
	[Token(Token = "0x6002BEF")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
	private void Start()
	{
		RectTransform component = base.GetComponent<RectTransform>();
		this.rectTransform = component;
		Vector2 anchoredPosition = this.rectTransform.anchoredPosition;
		int num = 0;
		this.originPosition.z = (float)num;
	}

	// Token: 0x06002BF0 RID: 11248 RVA: 0x000F116C File Offset: 0x000EF36C
	[Token(Token = "0x6002BF0")]
	[Address(RVA = "0x525520", Offset = "0x523B20", VA = "0x180525520")]
	private void OnMouseEnter()
	{
		CursorChange.SetClickCursor();
	}

	// Token: 0x06002BF1 RID: 11249 RVA: 0x000F1180 File Offset: 0x000EF380
	[Token(Token = "0x6002BF1")]
	[Address(RVA = "0x66F300", Offset = "0x66D900", VA = "0x18066F300")]
	private void OnMouseExit()
	{
		RectTransform rectTransform = this.rectTransform;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002BF2 RID: 11250 RVA: 0x000F11A4 File Offset: 0x000EF3A4
	[Token(Token = "0x6002BF2")]
	[Address(RVA = "0x66F260", Offset = "0x66D860", VA = "0x18066F260")]
	private void OnMouseDown()
	{
		GameAPP.PlaySound(28, 0.5f, 1f);
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06002BF3 RID: 11251 RVA: 0x000F11D0 File Offset: 0x000EF3D0
	[Token(Token = "0x6002BF3")]
	[Address(RVA = "0x66F340", Offset = "0x66D940", VA = "0x18066F340")]
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
			int num2 = 0;
			instance2.ShowText("非普通神秘只能在主菜单进入", 3f, num2 != 0);
			return;
		}
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x000F1334 File Offset: 0x000EF534
	[Token(Token = "0x6002BF4")]
	[Address(RVA = "0x66FA50", Offset = "0x66E050", VA = "0x18066FA50")]
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

	// Token: 0x06002BF5 RID: 11253 RVA: 0x000F1384 File Offset: 0x000EF584
	[Token(Token = "0x6002BF5")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public PauseMenu_Btn()
	{
	}

	// Token: 0x04001A19 RID: 6681
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A19")]
	public int buttonNumber;

	// Token: 0x04001A1A RID: 6682
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A1A")]
	public GameObject thisMenu;

	// Token: 0x04001A1B RID: 6683
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A1B")]
	private Vector3 originPosition;

	// Token: 0x04001A1C RID: 6684
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A1C")]
	private RectTransform rectTransform;
}
