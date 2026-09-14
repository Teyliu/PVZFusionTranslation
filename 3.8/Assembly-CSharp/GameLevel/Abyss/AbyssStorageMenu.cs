using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GameLevel.Abyss
{
	// Token: 0x02000CF6 RID: 3318
	[Token(Token = "0x2000CF6")]
	public class AbyssStorageMenu : BaseMenu
	{
		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x001606F0 File Offset: 0x0015E8F0
		[Token(Token = "0x170007CA")]
		private bool ReinforceMode
		{
			[Token(Token = "0x600457A")]
			[Address(RVA = "0x849E20", Offset = "0x848420", VA = "0x180849E20")]
			get
			{
				return this.reinforceTitle.activeSelf;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x00160710 File Offset: 0x0015E910
		[Token(Token = "0x170007CB")]
		private List<TheCard> AvaliableCards
		{
			[Token(Token = "0x600457B")]
			[Address(RVA = "0x849D70", Offset = "0x848370", VA = "0x180849D70")]
			get
			{
				Func<TheCard, bool> func;
				return Enumerable.ToList<TheCard>(Enumerable.Where<TheCard>(this.cards, func));
			}
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x00160738 File Offset: 0x0015E938
		[Token(Token = "0x600457C")]
		[Address(RVA = "0x847A30", Offset = "0x846030", VA = "0x180847A30", Slot = "6")]
		protected override void Awake()
		{
			base.Awake();
			int num = 0;
			int num2 = 0;
			int storageSize = AbyssManager.Data.StorageSize;
			if (num2 < storageSize)
			{
				GameObject gameObject = this.cardContainerPrefab;
				RectTransform rectTransform = this.content;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, rectTransform);
				List<RectTransform> list = this.containers;
				Transform transform = gameObject2.transform;
				if (transform != 0)
				{
				}
				int size = list._size;
				list._size = transform;
				num++;
				AbyssData data = AbyssManager.Data;
			}
			this.InitCards();
			UnityEvent theEvent_up = this.switchReinforceButton.theEvent_up;
			UnityAction unityAction = new UnityAction(this.SwitchReinforceMode);
			theEvent_up.AddListener(unityAction);
			UnityEvent theEvent_up2 = this.healthButton.theEvent_up;
			UnityAction unityAction2 = new UnityAction(this.DoHealth);
			theEvent_up2.AddListener(unityAction2);
			UnityEvent theEvent_up3 = this.speedButton.theEvent_up;
			UnityAction unityAction3 = new UnityAction(this.DoSpeed);
			theEvent_up3.AddListener(unityAction3);
			UnityEvent theEvent_up4 = this.damageButton.theEvent_up;
			UnityAction unityAction4 = new UnityAction(this.DoDamage);
			theEvent_up4.AddListener(unityAction4);
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x00160854 File Offset: 0x0015EA54
		[Token(Token = "0x600457D")]
		[Address(RVA = "0x8491E0", Offset = "0x8477E0", VA = "0x1808491E0")]
		private void Start()
		{
			TextMeshProUGUI textMeshProUGUI = this.ticketText;
			object[] array = new object[4];
			AbyssData data = AbyssManager.Data;
			int woodenTicket = data.woodenTicket;
			if (data != 0)
			{
			}
			array[0] = data;
			int num = AbyssManager.Data.silverTicket;
			if (num != 0)
			{
			}
			array[1] = num;
			int goldTicket = AbyssManager.Data.goldTicket;
			num = goldTicket;
			if (goldTicket != 0)
			{
			}
			array[2] = num;
			int diamondTicket = AbyssManager.Data.diamondTicket;
			num = diamondTicket;
			if (diamondTicket != 0)
			{
			}
			array[3] = num;
			string text = string.Format("抽奖券：{0} / {1} / {2} / {3}", array);
			textMeshProUGUI.text = text;
			TextMeshProUGUI textMeshProUGUI2 = this.tips;
			int arrivedLevel = AbyssManager.Data.arrivedLevel;
			ulong num2;
			num2 += (ulong)1L;
			num2 += num2;
			string text2 = string.Format("完成第{0}关即可扩大仓库容量", num2);
			textMeshProUGUI2.text = text2;
			this.tips.transform.parent.SetAsLastSibling();
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x0016095C File Offset: 0x0015EB5C
		[Token(Token = "0x600457E")]
		[Address(RVA = "0x849C70", Offset = "0x848270", VA = "0x180849C70")]
		private void Update()
		{
			bool isOn = this.removeToggle.m_IsOn;
			this.removeMode = isOn;
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x00160984 File Offset: 0x0015EB84
		[Token(Token = "0x600457F")]
		[Address(RVA = "0x848E70", Offset = "0x847470", VA = "0x180848E70")]
		public void InitReinforceButtons()
		{
			UnityEvent theEvent_up = this.switchReinforceButton.theEvent_up;
			UnityAction unityAction = new UnityAction(this.SwitchReinforceMode);
			theEvent_up.AddListener(unityAction);
			UnityEvent theEvent_up2 = this.healthButton.theEvent_up;
			UnityAction unityAction2 = new UnityAction(this.DoHealth);
			theEvent_up2.AddListener(unityAction2);
			UnityEvent theEvent_up3 = this.speedButton.theEvent_up;
			UnityAction unityAction3 = new UnityAction(this.DoSpeed);
			theEvent_up3.AddListener(unityAction3);
			UnityEvent theEvent_up4 = this.damageButton.theEvent_up;
			UnityAction unityAction4 = new UnityAction(this.DoDamage);
			theEvent_up4.AddListener(unityAction4);
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x00160A20 File Offset: 0x0015EC20
		[Token(Token = "0x6004580")]
		[Address(RVA = "0x849510", Offset = "0x847B10", VA = "0x180849510")]
		public void SwitchReinforceMode()
		{
			GameObject gameObject = this.reinforceTitle;
			bool activeSelf = gameObject.activeSelf;
			gameObject.SetActive(activeSelf);
			RectTransform rectTransform = this.scrollLayout;
			Vector2 sizeDelta = rectTransform.sizeDelta;
			bool activeSelf2 = this.reinforceTitle.activeSelf;
			Vector2 vector;
			rectTransform.sizeDelta = vector;
			int num = 0;
			this.UpdateReinforceText((PlantType)num);
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x00160A78 File Offset: 0x0015EC78
		[Token(Token = "0x6004581")]
		[Address(RVA = "0x848760", Offset = "0x846D60", VA = "0x180848760")]
		private ReinforceData GetReinforceData(PlantType plantType)
		{
			Func<ReinforceData, bool> func;
			ReinforceData reinforceData = Enumerable.FirstOrDefault<ReinforceData>(AbyssManager.Data.reinforceDatas, func);
			if (reinforceData == 0)
			{
				ReinforceData reinforceData2 = new ReinforceData();
				PlantType plantType2 = plantType;
				List<ReinforceData> reinforceDatas = AbyssManager.Data.reinforceDatas;
				int size = reinforceDatas._size;
				return reinforceData2;
			}
			return reinforceData;
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x00160AEC File Offset: 0x0015ECEC
		[Token(Token = "0x6004582")]
		[Address(RVA = "0x849680", Offset = "0x847C80", VA = "0x180849680")]
		private void UpdateReinforceText(PlantType plantType)
		{
			TheCard theCard = this.reinforceCard;
			theCard.thePlantType = plantType;
			TheCard theCard2 = this.reinforceCard;
			this.toReinforce = theCard;
			ReinforceData reinforceData;
			int healthLevel = reinforceData.healthLevel;
			TextMeshProUGUI textMeshProUGUI = this.healthInfo;
			int num;
			if (healthLevel < 20)
			{
				num = healthLevel;
				string text = string.Format("强化等级：{0}/{1}\n", num, healthLevel);
				string text2 = string.Format("强化加成：{0:F0}%\n", text);
				string text3 = string.Format("下一级消耗：{0}", text2);
				string text4 = text + text2 + text3;
			}
			num = healthLevel;
			string text5 = string.Format("强化等级：{0}/{1}（已满级）\n", num, healthLevel);
			string text6 = string.Format("强化加成：{0:F0}%", text5);
			string text7 = text5 + text6;
			textMeshProUGUI.text = text7;
			TextMeshProUGUI textMeshProUGUI2 = this.speedInfo;
			int speedLevel = reinforceData.speedLevel;
			float num2;
			string text11;
			if (speedLevel < 20)
			{
				string text8 = string.Format("强化等级：{0}/{1}\n", speedLevel, speedLevel);
				float num3;
				num2 = num3 * 0.2f;
				string text9 = string.Format("强化加成：{0:F0}%\n", text8);
				string text10 = string.Format("下一级消耗：{0}", text9);
				text11 = text8 + text9 + text10;
			}
			string text12 = string.Format("强化等级：{0}/{1}（已满级）\n", text11, text11);
			float num4 = num2 * 0.2f;
			string text13 = string.Format("强化加成：{0:F0}%", text12);
			string text14 = text12 + text13;
			textMeshProUGUI2.text = text14;
			TextMeshProUGUI textMeshProUGUI3 = this.damageInfo;
			int damageLevel = reinforceData.damageLevel;
			string text18;
			if (damageLevel < 20)
			{
				string text15 = string.Format("强化等级：{0}/{1}\n", damageLevel, damageLevel);
				float num5 = num4 * 0.3f;
				string text16 = string.Format("强化加成：{0:F0}%\n", text15);
				string text17 = string.Format("下一级消耗：{0}", text16);
				text18 = text15 + text16 + text17;
			}
			string text19 = string.Format("强化等级：{0}/{1}（已满级）\n", text18, text18);
			string text20 = string.Format("强化加成：{0:F0}%", text19);
			string text21 = text19 + text20;
			textMeshProUGUI3.text = text21;
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x00160CC4 File Offset: 0x0015EEC4
		[Token(Token = "0x6004583")]
		[Address(RVA = "0x8480A0", Offset = "0x8466A0", VA = "0x1808480A0")]
		private void DoHealth()
		{
			if (this.toReinforce != (ulong)0L)
			{
				ReinforceData reinforceData;
				if (reinforceData.healthLevel < 20)
				{
					List<TheCard> avaliableCards = this.AvaliableCards;
					InGameText instance = InGameText.Instance;
					int num = 0;
					instance.ShowText("强化成功", 3f, num != 0);
					int num2 = 0;
					Action<TheCard> action;
					global::Core.Lawnf.Foreach<TheCard>(Enumerable.Take<TheCard>(this.AvaliableCards, num2), action);
					SaveInfo.Instance.SavePlayerData();
					return;
				}
				GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
				InGameText instance2 = InGameText.Instance;
			}
			GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
			InGameText instance3 = InGameText.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00160DA4 File Offset: 0x0015EFA4
		[Token(Token = "0x6004584")]
		[Address(RVA = "0x848400", Offset = "0x846A00", VA = "0x180848400")]
		private void DoSpeed()
		{
			if (this.toReinforce != (ulong)0L)
			{
				ReinforceData reinforceData;
				if (reinforceData.speedLevel < 20)
				{
					List<TheCard> avaliableCards = this.AvaliableCards;
					InGameText instance = InGameText.Instance;
					int num = 0;
					instance.ShowText("强化成功", 3f, num != 0);
					int num2 = 0;
					Action<TheCard> action;
					global::Core.Lawnf.Foreach<TheCard>(Enumerable.Take<TheCard>(this.AvaliableCards, num2), action);
					SaveInfo.Instance.SavePlayerData();
					return;
				}
				GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
				InGameText instance2 = InGameText.Instance;
			}
			GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
			InGameText instance3 = InGameText.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x00160E84 File Offset: 0x0015F084
		[Token(Token = "0x6004585")]
		[Address(RVA = "0x847D40", Offset = "0x846340", VA = "0x180847D40")]
		private void DoDamage()
		{
			if (this.toReinforce != (ulong)0L)
			{
				ReinforceData reinforceData;
				if (reinforceData.damageLevel < 20)
				{
					List<TheCard> avaliableCards = this.AvaliableCards;
					InGameText instance = InGameText.Instance;
					int num = 0;
					instance.ShowText("强化成功", 3f, num != 0);
					int num2 = 0;
					Action<TheCard> action;
					global::Core.Lawnf.Foreach<TheCard>(Enumerable.Take<TheCard>(this.AvaliableCards, num2), action);
					SaveInfo.Instance.SavePlayerData();
					return;
				}
				GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
				InGameText instance2 = InGameText.Instance;
			}
			GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
			InGameText instance3 = InGameText.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x00160F64 File Offset: 0x0015F164
		[Token(Token = "0x6004586")]
		[Address(RVA = "0x848910", Offset = "0x846F10", VA = "0x180848910")]
		private void InitCards()
		{
			ulong num5;
			do
			{
				int num = 0;
				List<RectTransform> list = new List(this.containers);
				List<PlantType> currentPlants = AbyssManager.Data.currentPlants;
				bool flag;
				if (flag)
				{
					TheCard theCard = this.cardPrefab;
					RectTransform rectTransform = this.content;
					TheCard theCard2 = global::UnityEngine.Object.Instantiate<TheCard>(theCard, rectTransform);
					int num2 = 0;
					RectTransform rectTransform2 = list[num2];
					TheCard theCard3 = global::UnityEngine.Object.Instantiate<TheCard>(theCard, rectTransform2);
					int num3 = 0;
					list.RemoveAt(num3);
					theCard3.thePlantType = (PlantType)num;
					if (TreasureData.GetCardLevel((PlantType)num) <= CardLevel.Red)
					{
						int num4 = 0;
						theCard3.SetBg((CardBgType)num4);
					}
					UnityAction<TheCard> unityAction;
					theCard3.clickEvent.AddListener(unityAction);
					List<TheCard> list2 = this.cards;
				}
			}
			while (num5 != (ulong)0L);
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x00161028 File Offset: 0x0015F228
		[Token(Token = "0x6004587")]
		[Address(RVA = "0x849020", Offset = "0x847620", VA = "0x180849020")]
		private void OnCardClicked(TheCard card)
		{
			bool activeSelf = this.reinforceTitle.activeSelf;
			if (!activeSelf)
			{
				if (this.removeMode != activeSelf)
				{
					this.RemoveCard(card);
					SaveInfo.Instance.SavePlayerData();
					GameAPP.PlaySound((SoundType)((uint)23), 0.5f, 1f);
					CursorChange.SetDefaultCursor();
				}
				return;
			}
			PlantType thePlantType = card.thePlantType;
			this.UpdateReinforceText(thePlantType);
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x00161090 File Offset: 0x0015F290
		[Token(Token = "0x6004588")]
		[Address(RVA = "0x849110", Offset = "0x847710", VA = "0x180849110")]
		private void RemoveCard(TheCard card)
		{
			bool flag = this.cards.Remove(card);
			global::UnityEngine.Object.Destroy(card.gameObject);
			List<PlantType> currentPlants = AbyssManager.Data.currentPlants;
			PlantType thePlantType = card.thePlantType;
			bool flag2 = currentPlants.Remove(thePlantType);
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x001610D8 File Offset: 0x0015F2D8
		[Token(Token = "0x6004589")]
		[Address(RVA = "0x848CF0", Offset = "0x8472F0", VA = "0x180848CF0")]
		private void InitContainer()
		{
			int num = 0;
			int num2 = 0;
			int storageSize = AbyssManager.Data.StorageSize;
			if (num2 < storageSize)
			{
				GameObject gameObject = this.cardContainerPrefab;
				RectTransform rectTransform = this.content;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, rectTransform);
				List<RectTransform> list = this.containers;
				Transform transform = gameObject2.transform;
				if (transform != 0)
				{
				}
				int size = list._size;
				list._size = transform;
				num++;
				AbyssData data = AbyssManager.Data;
			}
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x00161158 File Offset: 0x0015F358
		[Token(Token = "0x600458A")]
		[Address(RVA = "0x849CA0", Offset = "0x8482A0", VA = "0x180849CA0")]
		public AbyssStorageMenu()
		{
			List<RectTransform> list = new List();
			this.containers = list;
			List<TheCard> list2 = new List();
			this.cards = list2;
			base..ctor();
		}

		// Token: 0x040031BD RID: 12733
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40031BD")]
		public TheCard cardPrefab;

		// Token: 0x040031BE RID: 12734
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40031BE")]
		public GameObject cardContainerPrefab;

		// Token: 0x040031BF RID: 12735
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40031BF")]
		public RectTransform scrollLayout;

		// Token: 0x040031C0 RID: 12736
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40031C0")]
		public RectTransform content;

		// Token: 0x040031C1 RID: 12737
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40031C1")]
		public TextMeshProUGUI ticketText;

		// Token: 0x040031C2 RID: 12738
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40031C2")]
		public TextMeshProUGUI tips;

		// Token: 0x040031C3 RID: 12739
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40031C3")]
		public List<RectTransform> containers;

		// Token: 0x040031C4 RID: 12740
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40031C4")]
		public bool removeMode;

		// Token: 0x040031C5 RID: 12741
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40031C5")]
		public Toggle removeToggle;

		// Token: 0x040031C6 RID: 12742
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40031C6")]
		private readonly List<TheCard> cards;

		// Token: 0x040031C7 RID: 12743
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40031C7")]
		[Header("强化相关")]
		public TheButton switchReinforceButton;

		// Token: 0x040031C8 RID: 12744
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40031C8")]
		public GameObject reinforceTitle;

		// Token: 0x040031C9 RID: 12745
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40031C9")]
		public TheCard reinforceCard;

		// Token: 0x040031CA RID: 12746
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40031CA")]
		public TheButton healthButton;

		// Token: 0x040031CB RID: 12747
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40031CB")]
		public TextMeshProUGUI healthInfo;

		// Token: 0x040031CC RID: 12748
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x40031CC")]
		public TheButton speedButton;

		// Token: 0x040031CD RID: 12749
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40031CD")]
		public TextMeshProUGUI speedInfo;

		// Token: 0x040031CE RID: 12750
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40031CE")]
		public TheButton damageButton;

		// Token: 0x040031CF RID: 12751
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40031CF")]
		public TextMeshProUGUI damageInfo;

		// Token: 0x040031D0 RID: 12752
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x40031D0")]
		private PlantType? toReinforce;
	}
}
