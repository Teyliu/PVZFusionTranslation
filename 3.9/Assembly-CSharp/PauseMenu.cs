using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020008A0 RID: 2208
[Token(Token = "0x20008A0")]
public class PauseMenu : BaseMenu
{
	// Token: 0x06002D1B RID: 11547 RVA: 0x000F5C38 File Offset: 0x000F3E38
	[Token(Token = "0x6002D1B")]
	[Address(RVA = "0x6D3BA0", Offset = "0x6D21A0", VA = "0x1806D3BA0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		PauseMenu.Instance = this;
		GameObject gameObject = this.lookBuff;
		GameObject gameObject2 = this.lookBuff;
		int num = 0;
		gameObject2.SetActive(num != 0);
		Board instance = Board.Instance;
		int num2 = 0;
		if (instance != num2)
		{
			this.lookCrisis.SetActive(true);
			this.lookJigs.SetActive(true);
			GameObject gameObject3 = this.btnRestart;
			int num3 = 0;
			gameObject3.SetActive(num3 != 0);
		}
		this.save.SetActive(true);
	}

	// Token: 0x06002D1C RID: 11548 RVA: 0x000F5CBC File Offset: 0x000F3EBC
	[Token(Token = "0x6002D1C")]
	[Address(RVA = "0x6D4A70", Offset = "0x6D3070", VA = "0x1806D4A70")]
	private void Update()
	{
		if ((Input.GetKeyDownInt((KeyCode)((uint)27)) || Input.GetKeyDownInt((KeyCode)((uint)32))) && base.Interactable)
		{
			UIMgr.BackToGame();
			return;
		}
	}

	// Token: 0x06002D1D RID: 11549 RVA: 0x000F5CF0 File Offset: 0x000F3EF0
	[Token(Token = "0x6002D1D")]
	[Address(RVA = "0x6D4940", Offset = "0x6D2F40", VA = "0x1806D4940")]
	public void SwitchJigs()
	{
		JigsawManager instance = JigsawManager.Instance;
		int num = 0;
		if (!(instance == num))
		{
			JigsawManager.Instance.SwitchJigs();
			return;
		}
		JigsawManager jigsawManager = Board.Instance.AddComponent<JigsawManager>();
		JigsawManager instance2 = JigsawManager.Instance;
		int num2 = 0;
		instance2.enabled = num2 != 0;
	}

	// Token: 0x06002D1E RID: 11550 RVA: 0x000F5D3C File Offset: 0x000F3F3C
	[Token(Token = "0x6002D1E")]
	[Address(RVA = "0x6D48C0", Offset = "0x6D2EC0", VA = "0x1806D48C0")]
	public void LookTreasure()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)48), canvasUp, num != 0);
	}

	// Token: 0x06002D1F RID: 11551 RVA: 0x000F5D6C File Offset: 0x000F3F6C
	[Token(Token = "0x6002D1F")]
	[Address(RVA = "0x6D4750", Offset = "0x6D2D50", VA = "0x1806D4750")]
	public void LookBuff()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		if (uimanager.Push((UIType)((uint)82), canvasUp, num != 0) != 0)
		{
		}
		if (!Board.Instance.isEveStarted)
		{
		}
	}

	// Token: 0x06002D20 RID: 11552 RVA: 0x000F5DAC File Offset: 0x000F3FAC
	[Token(Token = "0x6002D20")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public PauseMenu()
	{
	}

	// Token: 0x04001AF9 RID: 6905
	[Token(Token = "0x4001AF9")]
	public static PauseMenu Instance;

	// Token: 0x04001AFA RID: 6906
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AFA")]
	public GameObject checkQuit;

	// Token: 0x04001AFB RID: 6907
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AFB")]
	public GameObject checkRestart;

	// Token: 0x04001AFC RID: 6908
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001AFC")]
	public GameObject btnLookAlmanac;

	// Token: 0x04001AFD RID: 6909
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001AFD")]
	public GameObject btnRestart;

	// Token: 0x04001AFE RID: 6910
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001AFE")]
	public GameObject btnQuit;

	// Token: 0x04001AFF RID: 6911
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001AFF")]
	public GameObject backToGame;

	// Token: 0x04001B00 RID: 6912
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001B00")]
	public GameObject travelBuff;

	// Token: 0x04001B01 RID: 6913
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001B01")]
	public GameObject lookBuff;

	// Token: 0x04001B02 RID: 6914
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001B02")]
	public GameObject save;

	// Token: 0x04001B03 RID: 6915
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001B03")]
	public GameObject lookCrisis;

	// Token: 0x04001B04 RID: 6916
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001B04")]
	public GameObject lookJigs;

	// Token: 0x04001B05 RID: 6917
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001B05")]
	public GameObject lookTreasure;

	// Token: 0x04001B06 RID: 6918
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001B06")]
	public bool isRecheck;
}
