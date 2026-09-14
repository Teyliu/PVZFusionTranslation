using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020007FA RID: 2042
[Token(Token = "0x20007FA")]
public class PumpinerChestMenu : BaseMenu
{
	// Token: 0x060029B2 RID: 10674 RVA: 0x000E3D9C File Offset: 0x000E1F9C
	[Token(Token = "0x60029B2")]
	[Address(RVA = "0x644030", Offset = "0x642630", VA = "0x180644030")]
	public void InitPlants()
	{
		int num;
		do
		{
			num = 0;
			Dictionary<PlantType, int> pumpinerPlants = this.pumpiner.PumpinerPlants;
			bool flag;
			if (flag)
			{
				TheCard theCard = this.prefab;
				RectTransform rectTransform = this.container;
				TheCard theCard2 = global::UnityEngine.Object.Instantiate<TheCard>(theCard, rectTransform);
				int size = this.cards._size;
				theCard2.clickEvent = theCard2;
				string text;
				theCard2.costText.text = text;
				UnityAction<TheCard> unityAction;
				theCard2.clickEvent.AddListener(unityAction);
				int thePlantType = (int)theCard2.thePlantType;
				CardLevel cardLevel;
				while (cardLevel > CardLevel.Red)
				{
				}
				int num2 = 0;
				theCard2.SetBg((CardBgType)num2);
			}
		}
		while (num != 0);
	}

	// Token: 0x060029B3 RID: 10675 RVA: 0x000E3E54 File Offset: 0x000E2054
	[Token(Token = "0x60029B3")]
	[Address(RVA = "0x6444C0", Offset = "0x642AC0", VA = "0x1806444C0")]
	private void RemoveOnePlant(TheCard card)
	{
		Pumpiner pumpiner = this.pumpiner;
		PlantType thePlantType = card.thePlantType;
		Dictionary<PlantType, int> pumpinerPlants = pumpiner.PumpinerPlants;
		bool flag;
		if (flag)
		{
			Pumpiner pumpiner2 = this.pumpiner;
			Dictionary<PlantType, int> pumpinerPlants2 = pumpiner2.PumpinerPlants;
			List<PlantType> contains = this.pumpiner.contains;
			Pumpiner pumpiner3 = this.pumpiner;
			TextMeshProUGUI costText = card.costText;
			Dictionary<PlantType, int> pumpinerPlants3 = pumpiner3.PumpinerPlants;
			string text;
			costText.text = text;
			Dictionary<PlantType, int> pumpinerPlants4 = pumpiner2.PumpinerPlants;
			List<PlantType> contains2 = this.pumpiner.contains;
			bool flag2 = this.cards.Remove(card);
			global::UnityEngine.Object.Destroy(card.gameObject);
			CursorChange.SetDefaultCursor();
			if (this.pumpiner != 0)
			{
			}
			GameAPP.PlaySound((SoundType)((uint)23), 0.5f, 1f);
			Transform axis = this.pumpiner.axis;
			Vector3 vector;
			float z = vector.z;
			bool flag3;
			DroppedCard droppedCard;
			if (flag3)
			{
				droppedCard.usedTimes = (int)((ulong)2L);
			}
			droppedCard.fromPumpiner = true;
		}
	}

	// Token: 0x060029B4 RID: 10676 RVA: 0x000E3F4C File Offset: 0x000E214C
	[Token(Token = "0x60029B4")]
	[Address(RVA = "0x644900", Offset = "0x642F00", VA = "0x180644900")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
		}
	}

	// Token: 0x060029B5 RID: 10677 RVA: 0x000E3F64 File Offset: 0x000E2164
	[Token(Token = "0x60029B5")]
	[Address(RVA = "0x644410", Offset = "0x642A10", VA = "0x180644410", Slot = "8")]
	public override void OnExit()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x060029B6 RID: 10678 RVA: 0x000E3F88 File Offset: 0x000E2188
	[Token(Token = "0x60029B6")]
	[Address(RVA = "0x6444A0", Offset = "0x642AA0", VA = "0x1806444A0", Slot = "11")]
	public override void PopMenu()
	{
		this.poped = true;
		base.PopMenu();
	}

	// Token: 0x060029B7 RID: 10679 RVA: 0x000E3FA4 File Offset: 0x000E21A4
	[Token(Token = "0x60029B7")]
	[Address(RVA = "0x644940", Offset = "0x642F40", VA = "0x180644940")]
	public PumpinerChestMenu()
	{
		List<TheCard> list = new List();
		this.cards = list;
		base..ctor();
	}

	// Token: 0x040017F6 RID: 6134
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017F6")]
	public Pumpiner pumpiner;

	// Token: 0x040017F7 RID: 6135
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017F7")]
	public TheCard prefab;

	// Token: 0x040017F8 RID: 6136
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017F8")]
	public RectTransform container;

	// Token: 0x040017F9 RID: 6137
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40017F9")]
	public List<TheCard> cards;
}
