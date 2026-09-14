using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008C4 RID: 2244
[Token(Token = "0x20008C4")]
public class TravelStoreBtn : UIBtn
{
	// Token: 0x06002DCA RID: 11722 RVA: 0x000FAAF0 File Offset: 0x000F8CF0
	[Token(Token = "0x6002DCA")]
	[Address(RVA = "0x702020", Offset = "0x700620", VA = "0x180702020")]
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

	// Token: 0x06002DCB RID: 11723 RVA: 0x000FAB5C File Offset: 0x000F8D5C
	[Token(Token = "0x6002DCB")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TravelStoreBtn()
	{
	}

	// Token: 0x04001BAA RID: 7082
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001BAA")]
	public int id;
}
