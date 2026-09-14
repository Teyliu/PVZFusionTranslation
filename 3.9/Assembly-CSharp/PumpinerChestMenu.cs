using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000835 RID: 2101
[Token(Token = "0x2000835")]
public class PumpinerChestMenu : BaseMenu
{
	// Token: 0x06002AE8 RID: 10984 RVA: 0x000E8E68 File Offset: 0x000E7068
	[Token(Token = "0x6002AE8")]
	[Address(RVA = "0x6A8790", Offset = "0x6A6D90", VA = "0x1806A8790")]
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

	// Token: 0x06002AE9 RID: 10985 RVA: 0x000E8F20 File Offset: 0x000E7120
	[Token(Token = "0x6002AE9")]
	[Address(RVA = "0x6A8C20", Offset = "0x6A7220", VA = "0x1806A8C20")]
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

	// Token: 0x06002AEA RID: 10986 RVA: 0x000E9018 File Offset: 0x000E7218
	[Token(Token = "0x6002AEA")]
	[Address(RVA = "0x6A9060", Offset = "0x6A7660", VA = "0x1806A9060")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
		}
	}

	// Token: 0x06002AEB RID: 10987 RVA: 0x000E9030 File Offset: 0x000E7230
	[Token(Token = "0x6002AEB")]
	[Address(RVA = "0x6A8B70", Offset = "0x6A7170", VA = "0x1806A8B70", Slot = "8")]
	public override void OnExit()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002AEC RID: 10988 RVA: 0x000E9054 File Offset: 0x000E7254
	[Token(Token = "0x6002AEC")]
	[Address(RVA = "0x6A8C00", Offset = "0x6A7200", VA = "0x1806A8C00", Slot = "11")]
	public override void PopMenu()
	{
		this.poped = true;
		base.PopMenu();
	}

	// Token: 0x06002AED RID: 10989 RVA: 0x000E9070 File Offset: 0x000E7270
	[Token(Token = "0x6002AED")]
	[Address(RVA = "0x6A90A0", Offset = "0x6A76A0", VA = "0x1806A90A0")]
	public PumpinerChestMenu()
	{
		List<TheCard> list = new List();
		this.cards = list;
		base..ctor();
	}

	// Token: 0x040018E1 RID: 6369
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018E1")]
	public Pumpiner pumpiner;

	// Token: 0x040018E2 RID: 6370
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018E2")]
	public TheCard prefab;

	// Token: 0x040018E3 RID: 6371
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018E3")]
	public RectTransform container;

	// Token: 0x040018E4 RID: 6372
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40018E4")]
	public List<TheCard> cards;
}
