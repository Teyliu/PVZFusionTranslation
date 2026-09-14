using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007FD RID: 2045
[Token(Token = "0x20007FD")]
public class RogueSelectMenu : BaseMenu
{
	// Token: 0x060029C0 RID: 10688 RVA: 0x000E4210 File Offset: 0x000E2410
	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x6450D0", Offset = "0x6436D0", VA = "0x1806450D0", Slot = "6")]
	protected override void Awake()
	{
		this.ShowCards();
		base.Awake();
	}

	// Token: 0x060029C1 RID: 10689 RVA: 0x000E422C File Offset: 0x000E242C
	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x645B60", Offset = "0x644160", VA = "0x180645B60")]
	private void ShowCards()
	{
		ulong num5;
		do
		{
			int num = 0;
			int num2 = 0;
			List<PlantType> allUltimatePlantTypes = TravelHelper.GetAllUltimatePlantTypes(false, num2 != 0);
			bool flag;
			if (flag)
			{
				GameObject gameObject = this.cardPrefab;
				Transform transform = this.weakHead;
				RogueSelectCard component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<RogueSelectCard>();
				component.thePlantType = (PlantType)num;
				component.weakUlti = true;
				component.menu = this;
				if (!TravelMgr.Instance.data.unlockedWeaks.Contains(num))
				{
					continue;
				}
				component.get = true;
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_010D;
			}
			GameObject gameObject2;
			RogueSelectCard component2 = gameObject2.GetComponent<RogueSelectCard>();
			component2.menu = 0;
			component2.random = true;
			int num4 = 0;
			List<PlantType> allUltimatePlantTypes2 = TravelHelper.GetAllUltimatePlantTypes(true, num4 != 0);
			bool flag2;
			if (flag2)
			{
				while (num == 913)
				{
				}
				GameObject gameObject3;
				RogueSelectCard component3 = gameObject3.GetComponent<RogueSelectCard>();
				component3.thePlantType = (PlantType)num;
				component3.menu = 0;
				string text;
				object obj = Enum.Parse(typeof(TravelUnlocks), text);
				bool flag3;
				while (!flag3)
				{
				}
				component3.get = true;
			}
		}
		while (num5 != (ulong)0L);
		return;
		IL_010D:
		throw new InvalidCastException();
	}

	// Token: 0x060029C2 RID: 10690 RVA: 0x000E4360 File Offset: 0x000E2560
	[Token(Token = "0x60029C2")]
	[Address(RVA = "0x6458A0", Offset = "0x643EA0", VA = "0x1806458A0")]
	public void SelectPlant(RogueSelectCard card)
	{
		if (!card.get)
		{
			if (!card.weakUlti)
			{
				if (!card.random)
				{
					if (!this.randomStrongUlti)
					{
						bool flag = this.selectedStrongUltis.Contains(card);
						List<RogueSelectCard> list = this.selectedStrongUltis;
						if (flag)
						{
							return;
						}
					}
					GameAPP.PlaySound(26, 0.5f, 1f);
					InGameText instance = InGameText.Instance;
					int num = 0;
					instance.ShowText("不能在多选了", 3f, num != 0);
					return;
				}
				List<RogueSelectCard> list2 = this.selectedStrongUltis;
				bool flag2 = this.randomStrongUlti;
				bool flag3 = !flag2;
				this.randomStrongUlti = flag3;
				if (flag2)
				{
					return;
				}
			}
			else
			{
				bool flag4 = this.selectedWeakUltis.Contains(card);
				List<RogueSelectCard> list3 = this.selectedWeakUltis;
				if (flag4)
				{
					return;
				}
			}
			return;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance2 = InGameText.Instance;
		int num2 = 0;
		instance2.ShowText("你已拥有该植物", 3f, num2 != 0);
	}

	// Token: 0x060029C3 RID: 10691 RVA: 0x000E4458 File Offset: 0x000E2658
	[Token(Token = "0x60029C3")]
	[Address(RVA = "0x6450F0", Offset = "0x6436F0", VA = "0x1806450F0")]
	public void Confirm()
	{
		int num = 0;
		List<PlantType> list = new List();
		List<RogueSelectCard> list2 = this.selectedWeakUltis;
		bool flag;
		if (flag)
		{
			int size = list._size;
			list._size = num;
		}
		ulong num2;
		if (num2 == (ulong)0L)
		{
			bool flag2;
			if (flag2)
			{
				int size2 = list._size;
				list._size = (flag2 ? 1 : 0);
			}
			TravelMgr.Instance.data.unlockedWeaks.AddRange(list);
			bool flag3;
			if (flag3)
			{
				TravelMgr instance = TravelMgr.Instance;
			}
			ulong num3;
			if (num3 == (ulong)0L)
			{
				Array values = Enum.GetValues(typeof(TravelUnlocks));
				if (values == 0 || values != 0)
				{
					List<TravelUnlocks> list3 = Enumerable.ToList<TravelUnlocks>(values);
					Predicate<TravelUnlocks> predicate;
					if (RogueSelectMenu.<>c.<>9__9_0 == 0)
					{
						predicate = delegate(TravelUnlocks buff)
						{
							bool flag4;
							return flag4;
						};
						RogueSelectMenu.<>c.<>9__9_0 = predicate;
					}
					int num4 = list3.RemoveAll(predicate);
					int num5 = 0;
					uint num6;
					uint num7;
					if (global::UnityEngine.Random.Range((int)num6, (int)num7) > 0)
					{
						int num8 = list3._size;
						int num9 = global::UnityEngine.Random.Range(0, num8);
						num8 = num9;
						TravelUnlocks travelUnlocks = list3[num8];
						TravelMgr instance2 = TravelMgr.Instance;
						num8 = num9;
						list3.RemoveAt(num8);
						num5++;
						uint num11;
						uint num12;
						int num10 = global::UnityEngine.Random.Range((int)num11, (int)num12);
					}
					CursorChange.SetDefaultCursor();
					if (RogueManager.Instance.campType == CampType.Water && Board.Instance.theCurrentSurvivalRound == 2)
					{
						UIResourcesLoader uimanager = GameAPP.UIManager;
						return;
					}
					Time.timeScale = GameAPP.config.gameSpeed;
					Board.Instance.TravelNextRound();
					return;
				}
			}
		}
		throw new InvalidCastException();
	}

	// Token: 0x060029C4 RID: 10692 RVA: 0x000E45F4 File Offset: 0x000E27F4
	[Token(Token = "0x60029C4")]
	[Address(RVA = "0x6460A0", Offset = "0x6446A0", VA = "0x1806460A0")]
	public RogueSelectMenu()
	{
		List<RogueSelectCard> list = new List();
		this.selectedWeakUltis = list;
		List<RogueSelectCard> list2 = new List();
		this.selectedStrongUltis = list2;
		base..ctor();
	}

	// Token: 0x04001800 RID: 6144
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001800")]
	public List<RogueSelectCard> selectedWeakUltis;

	// Token: 0x04001801 RID: 6145
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001801")]
	public List<RogueSelectCard> selectedStrongUltis;

	// Token: 0x04001802 RID: 6146
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001802")]
	public bool randomStrongUlti;

	// Token: 0x04001803 RID: 6147
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001803")]
	public Transform weakHead;

	// Token: 0x04001804 RID: 6148
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001804")]
	public Transform strongHead;

	// Token: 0x04001805 RID: 6149
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001805")]
	public GameObject cardPrefab;
}
