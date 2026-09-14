using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000838 RID: 2104
[Token(Token = "0x2000838")]
public class RogueSelectMenu : BaseMenu
{
	// Token: 0x06002AF6 RID: 10998 RVA: 0x000E92C8 File Offset: 0x000E74C8
	[Token(Token = "0x6002AF6")]
	[Address(RVA = "0x6A9840", Offset = "0x6A7E40", VA = "0x1806A9840", Slot = "6")]
	protected override void Awake()
	{
		this.ShowCards();
		base.Awake();
	}

	// Token: 0x06002AF7 RID: 10999 RVA: 0x000E92E4 File Offset: 0x000E74E4
	[Token(Token = "0x6002AF7")]
	[Address(RVA = "0x6AA2F0", Offset = "0x6A88F0", VA = "0x1806AA2F0")]
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

	// Token: 0x06002AF8 RID: 11000 RVA: 0x000E9418 File Offset: 0x000E7618
	[Token(Token = "0x6002AF8")]
	[Address(RVA = "0x6AA010", Offset = "0x6A8610", VA = "0x1806AA010")]
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
	}

	// Token: 0x06002AF9 RID: 11001 RVA: 0x000E94E4 File Offset: 0x000E76E4
	[Token(Token = "0x6002AF9")]
	[Address(RVA = "0x6A9860", Offset = "0x6A7E60", VA = "0x1806A9860")]
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

	// Token: 0x06002AFA RID: 11002 RVA: 0x000E9680 File Offset: 0x000E7880
	[Token(Token = "0x6002AFA")]
	[Address(RVA = "0x6AA830", Offset = "0x6A8E30", VA = "0x1806AA830")]
	public RogueSelectMenu()
	{
		List<RogueSelectCard> list = new List();
		this.selectedWeakUltis = list;
		List<RogueSelectCard> list2 = new List();
		this.selectedStrongUltis = list2;
		base..ctor();
	}

	// Token: 0x040018EB RID: 6379
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018EB")]
	public List<RogueSelectCard> selectedWeakUltis;

	// Token: 0x040018EC RID: 6380
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018EC")]
	public List<RogueSelectCard> selectedStrongUltis;

	// Token: 0x040018ED RID: 6381
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018ED")]
	public bool randomStrongUlti;

	// Token: 0x040018EE RID: 6382
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40018EE")]
	public Transform weakHead;

	// Token: 0x040018EF RID: 6383
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40018EF")]
	public Transform strongHead;

	// Token: 0x040018F0 RID: 6384
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40018F0")]
	public GameObject cardPrefab;
}
