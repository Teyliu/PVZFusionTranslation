using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000845 RID: 2117
[Token(Token = "0x2000845")]
public class BigGardenUI : BaseMenu
{
	// Token: 0x06002B28 RID: 11048 RVA: 0x000EA7F8 File Offset: 0x000E89F8
	[Token(Token = "0x6002B28")]
	[Address(RVA = "0x699170", Offset = "0x697770", VA = "0x180699170", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
	}

	// Token: 0x06002B29 RID: 11049 RVA: 0x000EA80C File Offset: 0x000E8A0C
	[Token(Token = "0x6002B29")]
	[Address(RVA = "0x699380", Offset = "0x697980", VA = "0x180699380")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.moneyText;
		int treasureMoney = TreasureData.treasureMoney;
		ulong num;
		num += num;
		string text = string.Format("{0}k", num);
		textMeshProUGUI.text = text;
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x000EA848 File Offset: 0x000E8A48
	[Token(Token = "0x6002B2A")]
	[Address(RVA = "0x699180", Offset = "0x697780", VA = "0x180699180")]
	public void QuitGarden()
	{
		BigGardenData gardenData = TreasureData.gardenData;
		Transform transform = this.garden.player.transform;
		gardenData.playerPosition = 0;
		gardenData.playerPosition.y = (float)0;
		SaveInfo instance = SaveInfo.Instance;
		instance.SavePlayerData();
		global::UnityEngine.Object.Destroy(InGameText.Instance.gameObject);
		CursorChange.SetDefaultCursor();
		UIMgr.EnterTreasureMenu();
	}

	// Token: 0x06002B2B RID: 11051 RVA: 0x000EA8C0 File Offset: 0x000E8AC0
	[Token(Token = "0x6002B2B")]
	[Address(RVA = "0x6994A0", Offset = "0x697AA0", VA = "0x1806994A0")]
	public BigGardenUI()
	{
		List<Transform> list = new List();
		this.seeds = list;
		base..ctor();
	}

	// Token: 0x04001928 RID: 6440
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001928")]
	public Garden garden;

	// Token: 0x04001929 RID: 6441
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001929")]
	public List<Transform> seeds;

	// Token: 0x0400192A RID: 6442
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400192A")]
	public TextMeshProUGUI moneyText;

	// Token: 0x0400192B RID: 6443
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400192B")]
	public GameObject inputs;
}
