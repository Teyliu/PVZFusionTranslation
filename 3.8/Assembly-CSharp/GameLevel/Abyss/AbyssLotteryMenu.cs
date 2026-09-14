using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Core;
using Cpp2IlInjected;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.Abyss
{
	// Token: 0x02000CEE RID: 3310
	[Token(Token = "0x2000CEE")]
	public class AbyssLotteryMenu : BaseMenu
	{
		// Token: 0x06004543 RID: 17731 RVA: 0x0015EC44 File Offset: 0x0015CE44
		[Token(Token = "0x6004543")]
		[Address(RVA = "0x826FB0", Offset = "0x8255B0", VA = "0x180826FB0", Slot = "6")]
		protected override void Awake()
		{
			base.Awake();
			int num = 0;
			this.targetScene = (SceneType)num;
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x0015EC60 File Offset: 0x0015CE60
		[Token(Token = "0x6004544")]
		[Address(RVA = "0x82AB40", Offset = "0x829140", VA = "0x18082AB40")]
		private void Start()
		{
			this.UpdateText();
			this.InitCards();
			this.BindingButtons();
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x0015EC80 File Offset: 0x0015CE80
		[Token(Token = "0x6004545")]
		[Address(RVA = "0x82A850", Offset = "0x828E50", VA = "0x18082A850")]
		public void Single()
		{
			int remainingCapacity = GameAPP.config.abyssData.RemainingCapacity;
			AbyssData data = AbyssManager.Data;
			Quality quality = this.quality;
			if (quality == Quality.Default || quality == Quality.Default || quality == Quality.Default || quality == Quality.silver)
			{
				UIResourcesLoader uimanager = GameAPP.UIManager;
				int num = 0;
				BaseMenu baseMenu;
				Transform transform = baseMenu.transform;
				this.CreateAnim(num, transform);
				this.CheckEnd(baseMenu);
				this.UpdateText();
				SaveInfo.Instance.SavePlayerData();
			}
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText("抽奖券不足", 3f, num2 != 0);
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x0015ED24 File Offset: 0x0015CF24
		[Token(Token = "0x6004546")]
		[Address(RVA = "0x82AB70", Offset = "0x829170", VA = "0x18082AB70")]
		public void Tengle()
		{
			int remainingCapacity = GameAPP.config.abyssData.RemainingCapacity;
			AbyssData data = AbyssManager.Data;
			Quality quality = this.quality;
			if (quality == Quality.Default || quality == Quality.Default || quality == Quality.Default || quality == Quality.silver)
			{
				UIResourcesLoader uimanager = GameAPP.UIManager;
				int num = 0;
				BaseMenu baseMenu;
				Transform transform = baseMenu.transform;
				this.CreateAnim(num, transform);
				int num2 = 0;
				Transform transform2 = baseMenu.transform;
				this.CreateAnim(num2, transform2);
				int num3 = 0;
				Transform transform3 = baseMenu.transform;
				this.CreateAnim(num3, transform3);
				int num4 = 0;
				Transform transform4 = baseMenu.transform;
				this.CreateAnim(num4, transform4);
				int num5 = 0;
				Transform transform5 = baseMenu.transform;
				this.CreateAnim(num5, transform5);
				int num6 = 0;
				Transform transform6 = baseMenu.transform;
				this.CreateAnim(num6, transform6);
				int num7 = 0;
				Transform transform7 = baseMenu.transform;
				this.CreateAnim(num7, transform7);
				int num8 = 0;
				Transform transform8 = baseMenu.transform;
				this.CreateAnim(num8, transform8);
				int num9 = 0;
				Transform transform9 = baseMenu.transform;
				this.CreateAnim(num9, transform9);
				int num10 = 0;
				Transform transform10 = baseMenu.transform;
				this.CreateAnim(num10, transform10);
				this.CheckEnd(baseMenu);
				this.UpdateText();
				SaveInfo.Instance.SavePlayerData();
				return;
			}
			InGameText instance = InGameText.Instance;
			int num11 = 0;
			instance.ShowText("抽奖券不足", 3f, num11 != 0);
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x0015EE90 File Offset: 0x0015D090
		[Token(Token = "0x6004547")]
		[Address(RVA = "0x82B770", Offset = "0x829D70", VA = "0x18082B770")]
		private void UpdateText()
		{
			TextMeshProUGUI textMeshProUGUI = this.ticketText;
			object[] array = new object[4];
			AbyssData abyssData = GameAPP.config.abyssData;
			int num;
			if (num != 0)
			{
			}
			array[0] = num;
			AbyssData abyssData2 = GameAPP.config.abyssData;
			int num2;
			if (num2 != 0)
			{
			}
			array[1] = num2;
			AbyssData abyssData3 = GameAPP.config.abyssData;
			int num3;
			if (num3 != 0)
			{
			}
			array[2] = num3;
			AbyssData abyssData4 = GameAPP.config.abyssData;
			int num4;
			if (num4 != 0)
			{
			}
			array[3] = num4;
			string text = string.Format("抽奖券：{0} / {1} / {2} / {3}", array);
			textMeshProUGUI.text = text;
			TextMeshProUGUI textMeshProUGUI2 = this.ticketText;
			string text2 = textMeshProUGUI2.text + " 关卡首胜会额外获得10张抽奖券，重复刷单个关卡也能产出抽奖券";
			textMeshProUGUI2.text = text2;
			Quality quality = this.quality;
			if (quality != Quality.Default)
			{
				if (quality != Quality.Default)
				{
					if (quality != Quality.Default)
					{
						if (quality != Quality.silver)
						{
							return;
						}
						TextMeshProUGUI textMeshProUGUI3 = this.singleText;
						int diamondTicket = AbyssManager.Data.diamondTicket;
						string text3 = string.Format("单抽 ({0})", diamondTicket);
						textMeshProUGUI3.text = text3;
						TextMeshProUGUI textMeshProUGUI4 = this.tengleText;
						AbyssData data = AbyssManager.Data;
						text3 += text3;
						string text4 = string.Format("十连 ({0})", text3);
					}
					TextMeshProUGUI textMeshProUGUI5 = this.singleText;
					int goldTicket = AbyssManager.Data.goldTicket;
					string text5 = string.Format("单抽 ({0})", goldTicket);
					textMeshProUGUI5.text = text5;
					TextMeshProUGUI textMeshProUGUI6 = this.tengleText;
					AbyssData data2 = AbyssManager.Data;
					text5 += text5;
					string text6 = string.Format("十连 ({0})", text5);
				}
				TextMeshProUGUI textMeshProUGUI7 = this.singleText;
				int silverTicket = AbyssManager.Data.silverTicket;
				string text7 = string.Format("单抽 ({0})", silverTicket);
				textMeshProUGUI7.text = text7;
				TextMeshProUGUI textMeshProUGUI8 = this.tengleText;
				AbyssData data3 = AbyssManager.Data;
				text7 += text7;
				string text8 = string.Format("十连 ({0})", text7);
			}
			TextMeshProUGUI textMeshProUGUI9 = this.singleText;
			int woodenTicket = AbyssManager.Data.woodenTicket;
			string text9 = string.Format("单抽 ({0})", woodenTicket);
			textMeshProUGUI9.text = text9;
			TextMeshProUGUI textMeshProUGUI10 = this.tengleText;
			AbyssData data4 = AbyssManager.Data;
			text9 += text9;
			string text10 = string.Format("十连 ({0})", text9);
			textMeshProUGUI10.text = text10;
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x0015F0D4 File Offset: 0x0015D2D4
		[Token(Token = "0x6004548")]
		[Address(RVA = "0x827380", Offset = "0x825980", VA = "0x180827380")]
		private void CheckEnd(BaseMenu menu)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x0015F0F4 File Offset: 0x0015D2F4
		[Token(Token = "0x6004549")]
		[Address(RVA = "0x827870", Offset = "0x825E70", VA = "0x180827870")]
		private void CreateAnim(Vector2 position, Transform parent)
		{
			AbyssLotteryAnim abyssLotteryAnim = this.animPrefab;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			PlantType randomCards = this.GetRandomCards();
			AbyssLotteryAnim abyssLotteryAnim2;
			abyssLotteryAnim2.thePlantType = randomCards;
			AbyssData abyssData = GameAPP.config.abyssData;
			PlantType thePlantType = abyssLotteryAnim2.thePlantType;
			abyssData.AddPlant(thePlantType);
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x0015F144 File Offset: 0x0015D344
		[Token(Token = "0x600454A")]
		[Address(RVA = "0x828A90", Offset = "0x827090", VA = "0x180828A90")]
		private PlantType GetRandomCards()
		{
			List<TheCard> list = this.cards;
			Func<TheCard, CardLevel> <>9__23_ = AbyssLotteryMenu.<>c.<>9__23_0;
			if (<>9__23_ == 0)
			{
				Func<TheCard, CardLevel> func;
				AbyssLotteryMenu.<>c.<>9__23_0 = func;
			}
			List<CardLevel> list2 = Enumerable.ToList<CardLevel>(Enumerable.Distinct<CardLevel>(Enumerable.Select<TheCard, CardLevel>(list, <>9__23_)));
			List<CardLevel> existingLevels = list2;
			List<CardLevel> existingLevels3 = existingLevels;
			Dictionary<CardLevel, int> cardWeights = this.CardWeights;
			Func<KeyValuePair<CardLevel, int>, bool> func2 = delegate(KeyValuePair<CardLevel, int> kv)
			{
				List<CardLevel> existingLevels2 = existingLevels;
				CardLevel key = kv.key;
				return existingLevels2.Contains(key);
			};
			IEnumerable<KeyValuePair<CardLevel, int>> enumerable = Enumerable.Where<KeyValuePair<CardLevel, int>>(cardWeights, func2);
			Func<KeyValuePair<CardLevel, int>, CardLevel> func3;
			if (AbyssLotteryMenu.<>c.<>9__23_2 == 0)
			{
				AbyssLotteryMenu.<>c.<>9__23_2 = func3;
			}
			Func<KeyValuePair<CardLevel, int>, int> func4;
			if (AbyssLotteryMenu.<>c.<>9__23_3 == 0)
			{
				AbyssLotteryMenu.<>c.<>9__23_3 = func4;
			}
			CardLevel randomKeyByWeight = DictionaryExtensions.GetRandomKeyByWeight<CardLevel>(Enumerable.ToDictionary<KeyValuePair<CardLevel, int>, CardLevel, int>(enumerable, func3, func4));
			CardLevel selectedLevel = randomKeyByWeight;
			Func<TheCard, bool> func5;
			return ListExtensions.GetRandom<TheCard>(Enumerable.ToList<TheCard>(Enumerable.Where<TheCard>(this.cards, func5))).thePlantType;
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x0015F218 File Offset: 0x0015D418
		[Token(Token = "0x600454B")]
		[Address(RVA = "0x826FD0", Offset = "0x8255D0", VA = "0x180826FD0")]
		private void BindingButtons()
		{
			Quality[] enumValues = global::Core.Lawnf.GetEnumValues<Quality>();
			int num = 0;
			if (num < enumValues.Length)
			{
				if (num == 1)
				{
				}
				int num2 = 0;
				int num3 = 0;
				string sceneColor = this.GetSceneColor((SceneType)num3);
				int num4 = 0;
				string text;
				this.CreateButton((SceneType)num4, (Quality)num2, sceneColor, text);
				num++;
			}
			this.CreateMixedPoolButtons();
			global::UnityEngine.Object.Destroy(this.sampleButton.gameObject);
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x0015F278 File Offset: 0x0015D478
		[Token(Token = "0x600454C")]
		[Address(RVA = "0x827E70", Offset = "0x826470", VA = "0x180827E70")]
		private void CreateMixedPoolButtons()
		{
			ulong num2;
			do
			{
				Dictionary<Quality, string> dictionary = new Dictionary();
				int num = 0;
				dictionary[num] = "AF441B";
				dictionary[(uint)1] = "798F99";
				dictionary[(uint)2] = "F7DF00";
				dictionary[(uint)3] = "00CEDA";
				bool flag;
				if (flag)
				{
					TheButton theButton = this.sampleButton;
					Transform parent = theButton.transform.parent;
					TheButton theButton2 = global::UnityEngine.Object.Instantiate<TheButton>(theButton, parent);
					UnityEvent theEvent = theButton2.theEvent;
					Quality capturedQuality;
					UnityAction unityAction = delegate
					{
						AbyssLotteryMenu <>4__this = this;
						Quality capturedQuality2 = capturedQuality;
						<>4__this.OnMixedPoolButtonClicked(capturedQuality2);
					};
					theEvent.AddListener(unityAction);
					Dictionary<Quality, string> qualityNames = Helper.qualityNames;
					TextMeshProUGUI componentInChildren = theButton2.GetComponentInChildren<TextMeshProUGUI>();
					string text2;
					string text = string.Concat(new string[] { "<color=#", "<color=#", ">", text2, "混池</color>" });
					componentInChildren.text = text;
					Dictionary<Quality, TheButton> dictionary2 = this.mixedPoolButtons;
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x0015F3EC File Offset: 0x0015D5EC
		[Token(Token = "0x600454D")]
		[Address(RVA = "0x829E30", Offset = "0x828430", VA = "0x180829E30")]
		private void OnMixedPoolButtonClicked(Quality quality)
		{
			Quality? quality2 = this.mixedPoolQuality;
			int num = 0;
			bool flag = quality2 == quality;
			if (quality2 == flag)
			{
				List<SceneType> list = this.mixedScenes;
				this.mixedPoolQuality = num;
				list._size = num;
				this.quality = quality;
				Dictionary<Quality, string> qualityNames = Helper.qualityNames;
				InGameText instance = InGameText.Instance;
				string text2;
				string text = text2 + "混池模式：点击场景进行选择（可多选），再次点击同一场景可取消";
				int num2 = 0;
				instance.ShowText(text, 10f, num2 != 0);
				this.UpdateMixedPoolButtonsState();
				this.ClearAllButtonCheckMarks();
				TextMeshProUGUI textMeshProUGUI = this.infoText;
				string text3 = text2 + "混池模式（已选0个场景）";
				textMeshProUGUI.text = text3;
				this.InitCards();
				return;
			}
			int num3 = 0;
			this.mixedPoolQuality = num3;
			this.mixedScenes._size = num;
			this.targetScene = (SceneType)num;
			this.ShowAllQualityButtons();
			this.ClearAllButtonCheckMarks();
			this.UpdateMixedPoolButtonsState();
			TextMeshProUGUI textMeshProUGUI2 = this.infoText;
			Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
			int num4 = 0;
			string text4 = sceneName[num4];
			string text5 = "当前奖池：" + text4;
			textMeshProUGUI2.text = text5;
			this.InitCards();
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x0015F504 File Offset: 0x0015D704
		[Token(Token = "0x600454E")]
		[Address(RVA = "0x8283E0", Offset = "0x8269E0", VA = "0x1808283E0")]
		private void EnterMixedPoolMode(Quality quality)
		{
			List<SceneType> list = this.mixedScenes;
			ulong num;
			this.mixedPoolQuality = num;
			list._size = (int)((ulong)0L);
			this.quality = quality;
			Dictionary<Quality, string> qualityNames = Helper.qualityNames;
			InGameText instance = InGameText.Instance;
			string text2;
			string text = text2 + "混池模式：点击场景进行选择（可多选），再次点击同一场景可取消";
			int num2 = 0;
			instance.ShowText(text, 10f, num2 != 0);
			this.UpdateMixedPoolButtonsState();
			this.ClearAllButtonCheckMarks();
			TextMeshProUGUI textMeshProUGUI = this.infoText;
			string text3 = text2 + "混池模式（已选0个场景）";
			textMeshProUGUI.text = text3;
			this.InitCards();
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x0015F59C File Offset: 0x0015D79C
		[Token(Token = "0x600454F")]
		[Address(RVA = "0x8285A0", Offset = "0x826BA0", VA = "0x1808285A0")]
		private void ExitMixedPoolMode()
		{
			int num = 0;
			this.mixedPoolQuality = num;
			this.mixedScenes._size = num;
			this.targetScene = (SceneType)num;
			this.ShowAllQualityButtons();
			this.ClearAllButtonCheckMarks();
			this.UpdateMixedPoolButtonsState();
			TextMeshProUGUI textMeshProUGUI = this.infoText;
			Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
			int num2 = 0;
			string text = sceneName[num2];
			string text2 = "当前奖池：" + text;
			textMeshProUGUI.text = text2;
			this.InitCards();
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x0015F614 File Offset: 0x0015D814
		[Token(Token = "0x6004550")]
		[Address(RVA = "0x82B2B0", Offset = "0x8298B0", VA = "0x18082B2B0")]
		private void UpdateMixedPoolButtonsState()
		{
			ulong num;
			do
			{
				Dictionary<Quality, TheButton> dictionary = this.mixedPoolButtons;
				bool flag;
				if (flag)
				{
					bool flag2;
					TextMeshProUGUI textMeshProUGUI;
					if (this.mixedPoolQuality == flag2)
					{
						Dictionary<Quality, string> qualityNames = Helper.qualityNames;
						string text2;
						string text3;
						string text = string.Concat(new string[] { "<color=#", text2, ">", text3, "混池</color>" });
						textMeshProUGUI.text = text;
					}
					Dictionary<Quality, string> qualityNames2 = Helper.qualityNames;
					string text5;
					string text6;
					string text4 = string.Concat(new string[] { "<color=#", text5, ">退出", text6, "混池</color>" });
					textMeshProUGUI.text = text4;
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x0015F768 File Offset: 0x0015D968
		[Token(Token = "0x6004551")]
		[Address(RVA = "0x82A6C0", Offset = "0x828CC0", VA = "0x18082A6C0")]
		private void ShowOnlyQualityButtons(Quality quality)
		{
			ulong num;
			do
			{
				Dictionary<ValueTuple<SceneType, Quality>, TheButton> dictionary = this.buttons;
				bool flag;
				if (flag)
				{
					GameObject gameObject;
					bool flag2;
					gameObject.SetActive(flag2);
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x0015F7A4 File Offset: 0x0015D9A4
		[Token(Token = "0x6004552")]
		[Address(RVA = "0x82A560", Offset = "0x828B60", VA = "0x18082A560")]
		private void ShowAllQualityButtons()
		{
			ulong num;
			do
			{
				Dictionary<ValueTuple<SceneType, Quality>, TheButton>.ValueCollection values = this.buttons.Values;
				bool flag;
				if (flag)
				{
					GameObject gameObject;
					gameObject.SetActive(true);
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x0015F7E4 File Offset: 0x0015D9E4
		[Token(Token = "0x6004553")]
		[Address(RVA = "0x827430", Offset = "0x825A30", VA = "0x180827430")]
		private void ClearAllButtonCheckMarks()
		{
			ulong num;
			do
			{
				Dictionary<ValueTuple<SceneType, Quality>, TheButton> dictionary = this.buttons;
				bool flag;
				if (flag)
				{
					string[] array = new string[9];
					array[0] = "<color=#";
					string text;
					array[1] = text;
					array[2] = ">";
					Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
					string text2;
					array[3] = text2;
					array[4] = "</color>·<color=#";
					string text3;
					array[5] = text3;
					array[6] = ">";
					Dictionary<Quality, string> qualityNames = Helper.qualityNames;
					string text4;
					array[7] = text4;
					array[8] = "</color>";
					string text5 = string.Concat(array);
					TextMeshProUGUI textMeshProUGUI;
					textMeshProUGUI.text = text5;
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x0015F8F8 File Offset: 0x0015DAF8
		[Token(Token = "0x6004554")]
		[Address(RVA = "0x829610", Offset = "0x827C10", VA = "0x180829610")]
		private string GetSceneColor(SceneType sceneType)
		{
			if (sceneType == SceneType.Day)
			{
				return "CCEBB6";
			}
			if (sceneType == SceneType.Day)
			{
				return "C9CFFF";
			}
			if (sceneType == SceneType.Day)
			{
				return "8EDEE7";
			}
			if (sceneType == SceneType.Day)
			{
				return "ADCCF1";
			}
			if (sceneType != SceneType.Night)
			{
				return "FFFFFF";
			}
			return "DDB38A";
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x0015F940 File Offset: 0x0015DB40
		[Token(Token = "0x6004555")]
		[Address(RVA = "0x8289E0", Offset = "0x826FE0", VA = "0x1808289E0")]
		private string GetQualityColor(Quality quality)
		{
			if (quality == Quality.Default)
			{
				return "AF441B";
			}
			if (quality == Quality.Default)
			{
				return "798F99";
			}
			if (quality == Quality.Default)
			{
				return "F7DF00";
			}
			if (quality != Quality.silver)
			{
				return "FFFFFF";
			}
			return "00CEDA";
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x0015F97C File Offset: 0x0015DB7C
		[Token(Token = "0x6004556")]
		[Address(RVA = "0x827A00", Offset = "0x826000", VA = "0x180827A00")]
		private void CreateButton(SceneType sceneType, Quality quality, string color1, string color2)
		{
			string color2 = 0;
			TheButton theButton = this.sampleButton;
			Transform parent = theButton.transform.parent;
			TheButton theButton2 = global::UnityEngine.Object.Instantiate<TheButton>(theButton, parent);
			TheButton button = theButton2;
			UnityEvent theEvent = button.theEvent;
			UnityAction unityAction = delegate
			{
				AbyssLotteryMenu <>4__this = this;
				string color5 = color2;
				TheButton button2 = button;
				Quality quality4 = quality;
				SceneType sceneType4 = sceneType;
				string color6 = color1;
				<>4__this.OnSceneButtonClicked(sceneType4, quality4, button2, color6, color5);
			};
			theEvent.AddListener(unityAction);
			TextMeshProUGUI componentInChildren = button.GetComponentInChildren<TextMeshProUGUI>();
			string[] array = new string[9];
			array[0] = "<color=#";
			string color3 = color1;
			array[1] = color3;
			array[2] = ">";
			Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
			SceneType sceneType2 = sceneType;
			string text;
			array[3] = text;
			array[4] = "</color>·<color=#";
			string color4 = color2;
			array[5] = color4;
			array[6] = ">";
			Dictionary<Quality, string> qualityNames = Helper.qualityNames;
			Quality quality2 = quality;
			string text2;
			array[7] = text2;
			array[8] = "</color>";
			string text3 = string.Concat(array);
			componentInChildren.text = text3;
			SceneType sceneType3 = sceneType;
			Quality quality3 = quality;
			Dictionary<ValueTuple<SceneType, Quality>, TheButton> dictionary = this.buttons;
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x0015FAE0 File Offset: 0x0015DCE0
		[Token(Token = "0x6004557")]
		[Address(RVA = "0x82A140", Offset = "0x828740", VA = "0x18082A140")]
		private void OnSceneButtonClicked(SceneType sceneType, Quality quality, TheButton button, string color1, string color2)
		{
			if (this.mixedPoolQuality == (ulong)0L)
			{
				this.targetScene = sceneType;
				TextMeshProUGUI textMeshProUGUI = this.infoText;
				this.quality = quality;
				string text = button.GetComponentInChildren<TextMeshProUGUI>().text;
				string text2 = "当前奖池：" + text;
			}
			List<SceneType> list = this.mixedScenes;
			List<SceneType> list2 = this.mixedScenes;
			bool flag;
			if (!flag)
			{
				int size = list2._size;
				int num = (int)(sceneType + 1);
				list2._size = num;
				InGameText instance = InGameText.Instance;
				Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
			}
			InGameText instance2 = InGameText.Instance;
			Dictionary<SceneType, string> sceneName2 = MapData_cs.SceneName;
			int num2 = 0;
			string text4;
			string text3 = "已移除：" + text4;
			int num3 = 0;
			instance2.ShowText(text3, (float)num2, num3 != 0);
			List<SceneType> list3 = this.mixedScenes;
			Dictionary<Quality, string> qualityNames = Helper.qualityNames;
			List<SceneType> list4 = this.mixedScenes;
			TextMeshProUGUI textMeshProUGUI2 = this.infoText;
			int size2 = list4._size;
			string text6;
			string text5 = string.Format("{0}混池模式（已选{1}个场景）", text6, text6);
			textMeshProUGUI2.text = text5;
			this.InitCards();
			this.UpdateText();
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x0015FBF4 File Offset: 0x0015DDF4
		[Token(Token = "0x6004558")]
		[Address(RVA = "0x82AFB0", Offset = "0x8295B0", VA = "0x18082AFB0")]
		private void UpdateButtonSelectedState(TheButton button, SceneType sceneType, bool isSelected, string color1, string color2)
		{
			TextMeshProUGUI componentInChildren = button.GetComponentInChildren<TextMeshProUGUI>();
			string text = "";
			if (isSelected)
			{
				text = "√";
			}
			string[] array = new string[10];
			array[0] = "<color=#";
			array[2] = ">";
			array[3] = text;
			Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
			string text2;
			array[4] = text2;
			array[5] = "</color>·<color=#";
			array[7] = ">";
			Dictionary<Quality, string> qualityNames = Helper.qualityNames;
			Quality quality = this.quality;
			string text3 = qualityNames[quality];
			array[8] = text3;
			array[9] = "</color>";
			string text4 = string.Concat(array);
			throw new NullReferenceException();
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x0015FCA8 File Offset: 0x0015DEA8
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x8286C0", Offset = "0x826CC0", VA = "0x1808286C0")]
		private int GetDiv(SceneType sceneType)
		{
			if (sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Night)
			{
			}
			return 0;
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x0015FCCC File Offset: 0x0015DECC
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x828F60", Offset = "0x827560", VA = "0x180828F60")]
		private List<PlantType> GetSceneCards(SceneType sceneType)
		{
			Queue<PlantType> queue;
			HashSet<int> hashSet;
			int num2;
			do
			{
				int num = 0;
				queue = new Queue();
				hashSet = new HashSet();
				if (this.mixedPoolQuality == (ulong)0L)
				{
					break;
				}
				List<SceneType> list = this.mixedScenes;
				num2 = 0;
				bool flag;
				if (flag)
				{
					if (num == 0 || num == 0 || num == 0 || num == 0 || num == 1)
					{
					}
					bool flag2 = hashSet.Add(num2);
				}
			}
			while (num2 != 0);
			int num3;
			if (sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Night)
			{
				num3 = 0;
			}
			bool flag3 = hashSet.Add(num3);
			AdvantureCardLayout[] enumValues = global::Core.Lawnf.GetEnumValues<AdvantureCardLayout>();
			if (num3 < enumValues.Length)
			{
				ulong num4;
				num4 += num4;
				if (hashSet.Contains(num4))
				{
					AdvantureCardLayout advantureCardLayout;
					PlantType plantType = advantureCardLayout.ConvertTo<PlantType>();
					HashSet<PlantType> whiteCardPlants = TypeData.WhiteCardPlants;
					bool flag4;
					if (!flag4)
					{
					}
				}
				num3++;
			}
			List<PlantType> list2 = this.GetList(queue);
			Quality quality = this.quality;
			if (quality != Quality.Default)
			{
				if (quality != Quality.Default)
				{
					if (quality != Quality.silver)
					{
						return list2;
					}
					if (AbyssLotteryMenu.<>c.<>9__39_2 != 0)
					{
						goto IL_012F;
					}
					AbyssLotteryMenu.<>c.<>9__39_2 = delegate(PlantType p)
					{
						CardLevel cardLevel;
						return cardLevel > CardLevel.Purple;
					};
				}
				if (AbyssLotteryMenu.<>c.<>9__39_1 != 0)
				{
					goto IL_012F;
				}
				AbyssLotteryMenu.<>c.<>9__39_1 = delegate(PlantType p)
				{
					CardLevel cardLevel2;
					return cardLevel2 > CardLevel.Blue;
				};
			}
			Predicate<PlantType> predicate;
			if (AbyssLotteryMenu.<>c.<>9__39_0 == 0)
			{
				predicate = delegate(PlantType p)
				{
					CardLevel cardLevel3;
					return cardLevel3 > CardLevel.Green;
				};
				AbyssLotteryMenu.<>c.<>9__39_0 = predicate;
			}
			IL_012F:
			int num5 = list2.RemoveAll(predicate);
			return list2;
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x0015FE2C File Offset: 0x0015E02C
		[Token(Token = "0x600455B")]
		[Address(RVA = "0x828700", Offset = "0x826D00", VA = "0x180828700")]
		private List<PlantType> GetList(Queue<PlantType> queue)
		{
			int num;
			HashSet<PlantType> hashSet;
			do
			{
				num = 0;
				hashSet = new HashSet(queue);
				Queue<PlantType> queue2 = new Queue(queue);
				int num2 = queue2.Dequeue();
				List<PlantType> list = Enumerable.ToList<PlantType>(hashSet);
				bool flag;
				if (flag)
				{
					bool flag2;
					while (!flag2)
					{
					}
					if (!hashSet.Add(num))
					{
						continue;
					}
					queue2.Enqueue(num);
				}
			}
			while (num != 0);
			return Enumerable.ToList<PlantType>(hashSet);
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x0015FEA4 File Offset: 0x0015E0A4
		[Token(Token = "0x600455C")]
		[Address(RVA = "0x8296E0", Offset = "0x827CE0", VA = "0x1808296E0")]
		private void InitCards()
		{
			for (;;)
			{
				int num = 0;
				List<TheCard> list = this.cards;
				bool flag;
				if (flag)
				{
					GameObject gameObject;
					global::UnityEngine.Object.Destroy(gameObject);
				}
				if (num == 0)
				{
					int num2 = 0;
					Func<PlantType, CardLevel> func;
					if (AbyssLotteryMenu.<>c.<>9__41_0 == 0)
					{
						AbyssLotteryMenu.<>c.<>9__41_0 = func;
					}
					List<PlantType> list2;
					IOrderedEnumerable<PlantType> orderedEnumerable = Enumerable.OrderBy<PlantType, CardLevel>(list2, func);
					Func<PlantType, PlantType> func2;
					if (AbyssLotteryMenu.<>c.<>9__41_1 == 0)
					{
						AbyssLotteryMenu.<>c.<>9__41_1 = func2;
					}
					IOrderedEnumerable<PlantType> orderedEnumerable2 = Enumerable.ThenBy<PlantType, PlantType>(orderedEnumerable, func2);
					if (num2 < typeof(IEnumerable<PlantType>).TypeHandle)
					{
						num2 += num2;
						num2++;
					}
					if (num2 >= num2)
					{
						goto IL_0087;
					}
					num2 += num2;
					if (num2 != 0)
					{
						num2++;
						goto IL_0087;
					}
					IL_00A7:
					TheCard theCard;
					theCard += theCard;
					theCard.m_CancellationTokenSource = theCard;
					UnityEvent<TheCard> clickEvent = theCard.clickEvent;
					UnityAction<TheCard> unityAction;
					if (AbyssLotteryMenu.<>c.<>9__41_2 == 0)
					{
						AbyssLotteryMenu.<>c.<>9__41_2 = unityAction;
					}
					clickEvent.AddListener(unityAction);
					if ("{il2cpp array field local28->}" != (ulong)0L)
					{
					}
					if (num2 == 0)
					{
						break;
					}
					continue;
					IL_0087:
					theCard.SetBg();
					IntPtr cachedPtr = theCard.m_CachedPtr;
					CancellationTokenSource cancellationTokenSource = theCard.m_CancellationTokenSource;
					theCard += theCard;
					goto IL_00A7;
				}
				goto IL_00F1;
			}
			return;
			IL_00F1:
			throw new IndexOutOfRangeException();
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x0015FFCC File Offset: 0x0015E1CC
		[Token(Token = "0x600455D")]
		[Address(RVA = "0x82BEE0", Offset = "0x82A4E0", VA = "0x18082BEE0")]
		public AbyssLotteryMenu()
		{
			List<TheCard> list = new List();
			this.cards = list;
			Dictionary<ValueTuple<SceneType, Quality>, TheButton> dictionary = new Dictionary();
			this.buttons = dictionary;
			List<SceneType> list2 = new List();
			this.mixedScenes = list2;
			Dictionary<Quality, TheButton> dictionary2 = new Dictionary();
			this.mixedPoolButtons = dictionary2;
			Dictionary<CardLevel, int> dictionary3 = new Dictionary();
			int num = 0;
			dictionary3[num] = 100;
			dictionary3[(uint)1] = 80;
			dictionary3[(uint)2] = 60;
			dictionary3[(uint)3] = 40;
			dictionary3[(uint)4] = 20;
			dictionary3[(uint)5] = 10;
			this.CardWeights = dictionary3;
			base..ctor();
		}

		// Token: 0x04003190 RID: 12688
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003190")]
		[Header("UI组件")]
		public TextMeshProUGUI singleText;

		// Token: 0x04003191 RID: 12689
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003191")]
		public TextMeshProUGUI tengleText;

		// Token: 0x04003192 RID: 12690
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003192")]
		public TextMeshProUGUI ticketText;

		// Token: 0x04003193 RID: 12691
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003193")]
		public TextMeshProUGUI infoText;

		// Token: 0x04003194 RID: 12692
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003194")]
		public RectTransform plantContainer;

		// Token: 0x04003195 RID: 12693
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003195")]
		[Header("预制体")]
		public TheCard cardPrefab;

		// Token: 0x04003196 RID: 12694
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003196")]
		public AbyssLotteryAnim animPrefab;

		// Token: 0x04003197 RID: 12695
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003197")]
		public TheButton sampleButton;

		// Token: 0x04003198 RID: 12696
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003198")]
		private SceneType targetScene;

		// Token: 0x04003199 RID: 12697
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4003199")]
		private Quality quality;

		// Token: 0x0400319A RID: 12698
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400319A")]
		private readonly List<TheCard> cards;

		// Token: 0x0400319B RID: 12699
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400319B")]
		[TupleElementNames(new string[] { "sceneType", "quality" })]
		private readonly Dictionary<ValueTuple<SceneType, Quality>, TheButton> buttons;

		// Token: 0x0400319C RID: 12700
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400319C")]
		private Quality? mixedPoolQuality;

		// Token: 0x0400319D RID: 12701
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400319D")]
		private readonly List<SceneType> mixedScenes;

		// Token: 0x0400319E RID: 12702
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400319E")]
		private readonly Dictionary<Quality, TheButton> mixedPoolButtons;

		// Token: 0x0400319F RID: 12703
		[Token(Token = "0x400319F")]
		private const string SELECTED_MARK = "√";

		// Token: 0x040031A0 RID: 12704
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40031A0")]
		private readonly Dictionary<CardLevel, int> CardWeights;
	}
}
