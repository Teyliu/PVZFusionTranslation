using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000888 RID: 2184
[Token(Token = "0x2000888")]
public class TravelStoreBtn : UIBtn
{
	// Token: 0x06002C98 RID: 11416 RVA: 0x000F5F3C File Offset: 0x000F413C
	[Token(Token = "0x6002C98")]
	[Address(RVA = "0x688A00", Offset = "0x687000", VA = "0x180688A00")]
	private void Quit()
	{
		GameAPP.UIManager.Pop();
		if (Lawnf.TravelHell() && Board.Instance.theCurrentSurvivalRound < 15)
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Transform canvasUp = GameAPP.canvasUp;
			int num = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)26), canvasUp, num != 0);
			return;
		}
		Time.timeScale = GameAPP.config.gameSpeed;
		Board.Instance.TravelNextRound();
	}

	// Token: 0x06002C99 RID: 11417 RVA: 0x000F5FA8 File Offset: 0x000F41A8
	[Token(Token = "0x6002C99")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TravelStoreBtn()
	{
	}

	// Token: 0x04001ABC RID: 6844
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001ABC")]
	public int id;
}
