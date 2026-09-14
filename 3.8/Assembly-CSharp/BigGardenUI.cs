using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000807 RID: 2055
[Token(Token = "0x2000807")]
public class BigGardenUI : BaseMenu
{
	// Token: 0x060029EA RID: 10730 RVA: 0x000E5480 File Offset: 0x000E3680
	[Token(Token = "0x60029EA")]
	[Address(RVA = "0x634C10", Offset = "0x633210", VA = "0x180634C10", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
	}

	// Token: 0x060029EB RID: 10731 RVA: 0x000E5494 File Offset: 0x000E3694
	[Token(Token = "0x60029EB")]
	[Address(RVA = "0x634E10", Offset = "0x633410", VA = "0x180634E10")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.moneyText;
		int treasureMoney = TreasureData.treasureMoney;
		ulong num;
		num += num;
		string text = string.Format("{0}k", num);
		textMeshProUGUI.text = text;
	}

	// Token: 0x060029EC RID: 10732 RVA: 0x000E54D0 File Offset: 0x000E36D0
	[Token(Token = "0x60029EC")]
	[Address(RVA = "0x634C20", Offset = "0x633220", VA = "0x180634C20")]
	public void QuitGarden()
	{
		BigGardenData gardenData = TreasureData.gardenData;
		Transform transform = this.garden.player.transform;
		gardenData.playerPosition = 0;
		gardenData.playerPosition.y = (float)0;
		SaveInfo instance = SaveInfo.Instance;
		instance.SavePlayerData();
		InGameText instance2 = InGameText.Instance;
		int num = 0;
		string text;
		instance2.ShowText(text, 10f, num != 0);
		global::UnityEngine.Object.Destroy(instance2.gameObject);
		CursorChange.SetDefaultCursor();
		UIMgr.EnterTreasureMenu();
	}

	// Token: 0x060029ED RID: 10733 RVA: 0x000E555C File Offset: 0x000E375C
	[Token(Token = "0x60029ED")]
	[Address(RVA = "0x634F30", Offset = "0x633530", VA = "0x180634F30")]
	public BigGardenUI()
	{
		List<Transform> list = new List();
		this.seeds = list;
		base..ctor();
	}

	// Token: 0x0400182C RID: 6188
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400182C")]
	public Garden garden;

	// Token: 0x0400182D RID: 6189
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400182D")]
	public List<Transform> seeds;

	// Token: 0x0400182E RID: 6190
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400182E")]
	public TextMeshProUGUI moneyText;

	// Token: 0x0400182F RID: 6191
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400182F")]
	public GameObject inputs;
}
