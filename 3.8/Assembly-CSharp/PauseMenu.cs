using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000864 RID: 2148
[Token(Token = "0x2000864")]
public class PauseMenu : BaseMenu
{
	// Token: 0x06002BE9 RID: 11241 RVA: 0x000F0FA8 File Offset: 0x000EF1A8
	[Token(Token = "0x6002BE9")]
	[Address(RVA = "0x66F060", Offset = "0x66D660", VA = "0x18066F060", Slot = "6")]
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

	// Token: 0x06002BEA RID: 11242 RVA: 0x000F102C File Offset: 0x000EF22C
	[Token(Token = "0x6002BEA")]
	[Address(RVA = "0x66FF20", Offset = "0x66E520", VA = "0x18066FF20")]
	private void Update()
	{
		if ((Input.GetKeyDownInt((KeyCode)((uint)27)) || Input.GetKeyDownInt((KeyCode)((uint)32))) && base.Interactable)
		{
			UIMgr.BackToGame();
			return;
		}
	}

	// Token: 0x06002BEB RID: 11243 RVA: 0x000F1060 File Offset: 0x000EF260
	[Token(Token = "0x6002BEB")]
	[Address(RVA = "0x66FDF0", Offset = "0x66E3F0", VA = "0x18066FDF0")]
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

	// Token: 0x06002BEC RID: 11244 RVA: 0x000F10AC File Offset: 0x000EF2AC
	[Token(Token = "0x6002BEC")]
	[Address(RVA = "0x66FD70", Offset = "0x66E370", VA = "0x18066FD70")]
	public void LookTreasure()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)48), canvasUp, num != 0);
	}

	// Token: 0x06002BED RID: 11245 RVA: 0x000F10DC File Offset: 0x000EF2DC
	[Token(Token = "0x6002BED")]
	[Address(RVA = "0x66FC00", Offset = "0x66E200", VA = "0x18066FC00")]
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

	// Token: 0x06002BEE RID: 11246 RVA: 0x000F111C File Offset: 0x000EF31C
	[Token(Token = "0x6002BEE")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public PauseMenu()
	{
	}

	// Token: 0x04001A0B RID: 6667
	[Token(Token = "0x4001A0B")]
	public static PauseMenu Instance;

	// Token: 0x04001A0C RID: 6668
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A0C")]
	public GameObject checkQuit;

	// Token: 0x04001A0D RID: 6669
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A0D")]
	public GameObject checkRestart;

	// Token: 0x04001A0E RID: 6670
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A0E")]
	public GameObject btnLookAlmanac;

	// Token: 0x04001A0F RID: 6671
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A0F")]
	public GameObject btnRestart;

	// Token: 0x04001A10 RID: 6672
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A10")]
	public GameObject btnQuit;

	// Token: 0x04001A11 RID: 6673
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A11")]
	public GameObject backToGame;

	// Token: 0x04001A12 RID: 6674
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A12")]
	public GameObject travelBuff;

	// Token: 0x04001A13 RID: 6675
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001A13")]
	public GameObject lookBuff;

	// Token: 0x04001A14 RID: 6676
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001A14")]
	public GameObject save;

	// Token: 0x04001A15 RID: 6677
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001A15")]
	public GameObject lookCrisis;

	// Token: 0x04001A16 RID: 6678
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001A16")]
	public GameObject lookJigs;

	// Token: 0x04001A17 RID: 6679
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001A17")]
	public GameObject lookTreasure;

	// Token: 0x04001A18 RID: 6680
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001A18")]
	public bool isRecheck;
}
