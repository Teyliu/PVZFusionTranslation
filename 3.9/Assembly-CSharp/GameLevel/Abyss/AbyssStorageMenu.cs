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
	// Token: 0x02000C5B RID: 3163
	[Token(Token = "0x2000C5B")]
	public class AbyssStorageMenu : BaseMenu
	{
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060041E4 RID: 16868 RVA: 0x0015A65C File Offset: 0x0015885C
		[Token(Token = "0x17000554")]
		private bool ReinforceMode
		{
			[Token(Token = "0x60041E4")]
			[Address(RVA = "0x87E640", Offset = "0x87CC40", VA = "0x18087E640")]
			get
			{
				return this.reinforceTitle.activeSelf;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x0015A67C File Offset: 0x0015887C
		[Token(Token = "0x17000555")]
		private List<TheCard> AvaliableCards
		{
			[Token(Token = "0x60041E5")]
			[Address(RVA = "0x87E590", Offset = "0x87CB90", VA = "0x18087E590")]
			get
			{
				List<TheCard> list = this.cards;
				Func<TheCard, bool> func = delegate(TheCard a)
				{
					PlantType plantType;
					return a.thePlantType == plantType;
				};
				return Enumerable.ToList<TheCard>(Enumerable.Where<TheCard>(list, func));
			}
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x0015A6B4 File Offset: 0x001588B4
		[Token(Token = "0x60041E6")]
		[Address(RVA = "0x87BFB0", Offset = "0x87A5B0", VA = "0x18087BFB0", Slot = "6")]
		protected override void Awake()
		{
			base.Awake();
			this.InitContainer();
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

		// Token: 0x060041E7 RID: 16871 RVA: 0x0015A764 File Offset: 0x00158964
		[Token(Token = "0x60041E7")]
		[Address(RVA = "0x87D870", Offset = "0x87BE70", VA = "0x18087D870")]
		private void Start()
		{
			TextMeshProUGUI textMeshProUGUI = this.ticketText;
			object[] array = new object[4];
			int num = GameAPP.config.abyssData.woodenTicket;
			if (num != 0)
			{
			}
			array[0] = num;
			int silverTicket = GameAPP.config.abyssData.silverTicket;
			num = silverTicket;
			if (silverTicket != 0)
			{
			}
			array[1] = num;
			int goldTicket = GameAPP.config.abyssData.goldTicket;
			num = goldTicket;
			if (goldTicket != 0)
			{
			}
			array[2] = num;
			int diamondTicket = GameAPP.config.abyssData.diamondTicket;
			num = diamondTicket;
			if (diamondTicket != 0)
			{
			}
			array[3] = num;
			string text = string.Format("抽奖券：{0} / {1} / {2} / {3}", array);
			textMeshProUGUI.text = text;
			TextMeshProUGUI textMeshProUGUI2 = this.tips;
			int arrivedLevel = GameAPP.config.abyssData.arrivedLevel;
			ulong num2;
			num2 += (ulong)1L;
			num2 += num2;
			string text2 = string.Format("完成第{0}关即可扩大仓库容量", num2);
			textMeshProUGUI2.text = text2;
			this.tips.transform.parent.SetAsLastSibling();
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x0015A870 File Offset: 0x00158A70
		[Token(Token = "0x60041E8")]
		[Address(RVA = "0x87E490", Offset = "0x87CA90", VA = "0x18087E490")]
		private void Update()
		{
			bool isOn = this.removeToggle.m_IsOn;
			this.removeMode = isOn;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x0015A898 File Offset: 0x00158A98
		[Token(Token = "0x60041E9")]
		[Address(RVA = "0x87D4B0", Offset = "0x87BAB0", VA = "0x18087D4B0")]
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

		// Token: 0x060041EA RID: 16874 RVA: 0x0015A934 File Offset: 0x00158B34
		[Token(Token = "0x60041EA")]
		[Address(RVA = "0x87DD30", Offset = "0x87C330", VA = "0x18087DD30")]
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

		// Token: 0x060041EB RID: 16875 RVA: 0x0015A98C File Offset: 0x00158B8C
		[Token(Token = "0x60041EB")]
		[Address(RVA = "0x87CC50", Offset = "0x87B250", VA = "0x18087CC50")]
		private ReinforceData GetReinforceData(PlantType plantType)
		{
			List<ReinforceData> reinforceDatas = GameAPP.config.abyssData.reinforceDatas;
			Func<ReinforceData, bool> func = delegate(ReinforceData p)
			{
				PlantType plantType3 = plantType;
				return p.thePlantType == plantType3;
			};
			ReinforceData reinforceData = Enumerable.FirstOrDefault<ReinforceData>(reinforceDatas, func);
			if (reinforceData == 0)
			{
				ReinforceData reinforceData2 = new ReinforceData();
				PlantType plantType2 = plantType;
				List<ReinforceData> reinforceDatas2 = AbyssManager.Data.reinforceDatas;
				int size = reinforceDatas2._size;
				return reinforceData2;
			}
			return reinforceData;
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x0015AA10 File Offset: 0x00158C10
		[Token(Token = "0x60041EC")]
		[Address(RVA = "0x87DEA0", Offset = "0x87C4A0", VA = "0x18087DEA0")]
		private void UpdateReinforceText(PlantType plantType)
		{
			TheCard theCard = this.reinforceCard;
			theCard.thePlantType = plantType;
			TheCard theCard2 = this.reinforceCard;
			this.toReinforce = theCard;
			ReinforceData reinforceData;
			int healthLevel = reinforceData.healthLevel;
			TextMeshProUGUI textMeshProUGUI = this.healthInfo;
			string text4;
			if (healthLevel < 20)
			{
				int num = healthLevel;
				string text = string.Format("强化等级：{0}/{1}\n", num, healthLevel);
				string text2 = string.Format("强化加成：{0:F0}%\n", text);
				string text3 = string.Format("下一级消耗：{0}", text2);
				text4 = text + text2 + text3;
			}
			string text5 = string.Format("强化等级：{0}/{1}（已满级）\n", text4, text4);
			float num3;
			float num2 = num3 * 0.15f;
			string text6 = string.Format("强化加成：{0:F0}%", text5);
			string text7 = text5 + text6;
			textMeshProUGUI.text = text7;
			TextMeshProUGUI textMeshProUGUI2 = this.speedInfo;
			int speedLevel = reinforceData.speedLevel;
			float num4;
			string text11;
			if (speedLevel < 20)
			{
				string text8 = string.Format("强化等级：{0}/{1}\n", speedLevel, speedLevel);
				num4 = num2 * 0.2f;
				string text9 = string.Format("强化加成：{0:F0}%\n", text8);
				string text10 = string.Format("下一级消耗：{0}", text9);
				text11 = text8 + text9 + text10;
			}
			string text12 = string.Format("强化等级：{0}/{1}（已满级）\n", text11, text11);
			float num5 = num4 * 0.2f;
			string text13 = string.Format("强化加成：{0:F0}%", text12);
			string text14 = text12 + text13;
			textMeshProUGUI2.text = text14;
			TextMeshProUGUI textMeshProUGUI3 = this.damageInfo;
			int damageLevel = reinforceData.damageLevel;
			string text18;
			if (damageLevel < 20)
			{
				string text15 = string.Format("强化等级：{0}/{1}\n", damageLevel, damageLevel);
				float num6 = num5 * 0.3f;
				string text16 = string.Format("强化加成：{0:F0}%\n", text15);
				string text17 = string.Format("下一级消耗：{0}", text16);
				text18 = text15 + text16 + text17;
			}
			string text19 = string.Format("强化等级：{0}/{1}（已满级）\n", text18, text18);
			string text20 = string.Format("强化加成：{0:F0}%", text19);
			string text21 = text19 + text20;
			textMeshProUGUI3.text = text21;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x0015ABF0 File Offset: 0x00158DF0
		[Token(Token = "0x60041ED")]
		[Address(RVA = "0x87C510", Offset = "0x87AB10", VA = "0x18087C510")]
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
					Action<TheCard> action;
					global::Core.Lawnf.Foreach<TheCard>(Enumerable.Take<TheCard>(this.AvaliableCards, num), action);
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

		// Token: 0x060041EE RID: 16878 RVA: 0x0015ACA0 File Offset: 0x00158EA0
		[Token(Token = "0x60041EE")]
		[Address(RVA = "0x87C8B0", Offset = "0x87AEB0", VA = "0x18087C8B0")]
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
					Action<TheCard> action;
					global::Core.Lawnf.Foreach<TheCard>(Enumerable.Take<TheCard>(this.AvaliableCards, num), action);
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

		// Token: 0x060041EF RID: 16879 RVA: 0x0015AD50 File Offset: 0x00158F50
		[Token(Token = "0x60041EF")]
		[Address(RVA = "0x87C170", Offset = "0x87A770", VA = "0x18087C170")]
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
					Action<TheCard> action;
					global::Core.Lawnf.Foreach<TheCard>(Enumerable.Take<TheCard>(this.AvaliableCards, num), action);
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

		// Token: 0x060041F0 RID: 16880 RVA: 0x0015AE00 File Offset: 0x00159000
		[Token(Token = "0x60041F0")]
		[Address(RVA = "0x87CE50", Offset = "0x87B450", VA = "0x18087CE50")]
		private void InitCards()
		{
			ulong num5;
			do
			{
				int num = 0;
				List<RectTransform> list = new List(this.containers);
				List<PlantType> currentPlants = GameAPP.config.abyssData.currentPlants;
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

		// Token: 0x060041F1 RID: 16881 RVA: 0x0015AEC8 File Offset: 0x001590C8
		[Token(Token = "0x60041F1")]
		[Address(RVA = "0x87D660", Offset = "0x87BC60", VA = "0x18087D660")]
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

		// Token: 0x060041F2 RID: 16882 RVA: 0x0015AF30 File Offset: 0x00159130
		[Token(Token = "0x60041F2")]
		[Address(RVA = "0x87D750", Offset = "0x87BD50", VA = "0x18087D750")]
		private void RemoveCard(TheCard card)
		{
			bool flag = this.cards.Remove(card);
			global::UnityEngine.Object.Destroy(card.gameObject);
			List<PlantType> currentPlants = GameAPP.config.abyssData.currentPlants;
			PlantType thePlantType = card.thePlantType;
			bool flag2 = currentPlants.Remove(thePlantType);
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x0015AF7C File Offset: 0x0015917C
		[Token(Token = "0x60041F3")]
		[Address(RVA = "0x87D280", Offset = "0x87B880", VA = "0x18087D280")]
		private void InitContainer()
		{
			int num = 0;
			GameConfig config = GameAPP.config;
			AbyssData abyssData = GameAPP.config.abyssData;
			ulong num2;
			num2 += num2;
			if ((ulong)num < num2)
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
				num++;
				list._size = transform;
				num++;
			}
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x0015AFFC File Offset: 0x001591FC
		[Token(Token = "0x60041F4")]
		[Address(RVA = "0x87E4C0", Offset = "0x87CAC0", VA = "0x18087E4C0")]
		public AbyssStorageMenu()
		{
			List<RectTransform> list = new List();
			this.containers = list;
			List<TheCard> list2 = new List();
			this.cards = list2;
			base..ctor();
		}

		// Token: 0x04003262 RID: 12898
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003262")]
		public TheCard cardPrefab;

		// Token: 0x04003263 RID: 12899
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003263")]
		public GameObject cardContainerPrefab;

		// Token: 0x04003264 RID: 12900
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003264")]
		public RectTransform scrollLayout;

		// Token: 0x04003265 RID: 12901
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003265")]
		public RectTransform content;

		// Token: 0x04003266 RID: 12902
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003266")]
		public TextMeshProUGUI ticketText;

		// Token: 0x04003267 RID: 12903
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003267")]
		public TextMeshProUGUI tips;

		// Token: 0x04003268 RID: 12904
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003268")]
		public List<RectTransform> containers;

		// Token: 0x04003269 RID: 12905
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003269")]
		public bool removeMode;

		// Token: 0x0400326A RID: 12906
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400326A")]
		public Toggle removeToggle;

		// Token: 0x0400326B RID: 12907
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400326B")]
		private readonly List<TheCard> cards;

		// Token: 0x0400326C RID: 12908
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400326C")]
		[Header("强化相关")]
		public TheButton switchReinforceButton;

		// Token: 0x0400326D RID: 12909
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400326D")]
		public GameObject reinforceTitle;

		// Token: 0x0400326E RID: 12910
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400326E")]
		public TheCard reinforceCard;

		// Token: 0x0400326F RID: 12911
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400326F")]
		public TheButton healthButton;

		// Token: 0x04003270 RID: 12912
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4003270")]
		public TextMeshProUGUI healthInfo;

		// Token: 0x04003271 RID: 12913
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4003271")]
		public TheButton speedButton;

		// Token: 0x04003272 RID: 12914
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4003272")]
		public TextMeshProUGUI speedInfo;

		// Token: 0x04003273 RID: 12915
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4003273")]
		public TheButton damageButton;

		// Token: 0x04003274 RID: 12916
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4003274")]
		public TextMeshProUGUI damageInfo;

		// Token: 0x04003275 RID: 12917
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4003275")]
		private PlantType? toReinforce;
	}
}
