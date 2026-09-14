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
	// Token: 0x02000C53 RID: 3155
	[Token(Token = "0x2000C53")]
	public class AbyssLotteryMenu : BaseMenu
	{
		// Token: 0x060041AD RID: 16813 RVA: 0x00158BEC File Offset: 0x00156DEC
		[Token(Token = "0x60041AD")]
		[Address(RVA = "0x874600", Offset = "0x872C00", VA = "0x180874600", Slot = "6")]
		protected override void Awake()
		{
			base.Awake();
			int num = 0;
			this.targetScene = (SceneType)num;
		}

		// Token: 0x060041AE RID: 16814 RVA: 0x00158C08 File Offset: 0x00156E08
		[Token(Token = "0x60041AE")]
		[Address(RVA = "0x878210", Offset = "0x876810", VA = "0x180878210")]
		private void Start()
		{
			this.UpdateText();
			this.InitCards();
			this.BindingButtons();
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x00158C28 File Offset: 0x00156E28
		[Token(Token = "0x60041AF")]
		[Address(RVA = "0x877ED0", Offset = "0x8764D0", VA = "0x180877ED0")]
		public void Single()
		{
			AbyssData abyssData = GameAPP.config.abyssData;
			int storageSize = abyssData.StorageSize;
			List<PlantType> currentPlants = abyssData.currentPlants;
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
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x00158CC4 File Offset: 0x00156EC4
		[Token(Token = "0x60041B0")]
		[Address(RVA = "0x878240", Offset = "0x876840", VA = "0x180878240")]
		public void Tengle()
		{
			AbyssData abyssData = GameAPP.config.abyssData;
			int storageSize = abyssData.StorageSize;
			List<PlantType> currentPlants = abyssData.currentPlants;
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
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x00158E2C File Offset: 0x0015702C
		[Token(Token = "0x60041B1")]
		[Address(RVA = "0x878E90", Offset = "0x877490", VA = "0x180878E90")]
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

		// Token: 0x060041B2 RID: 16818 RVA: 0x00159070 File Offset: 0x00157270
		[Token(Token = "0x60041B2")]
		[Address(RVA = "0x8749D0", Offset = "0x872FD0", VA = "0x1808749D0")]
		private void CheckEnd(BaseMenu menu)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x00159090 File Offset: 0x00157290
		[Token(Token = "0x60041B3")]
		[Address(RVA = "0x874EC0", Offset = "0x8734C0", VA = "0x180874EC0")]
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

		// Token: 0x060041B4 RID: 16820 RVA: 0x001590E0 File Offset: 0x001572E0
		[Token(Token = "0x60041B4")]
		[Address(RVA = "0x8760F0", Offset = "0x8746F0", VA = "0x1808760F0")]
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
			List<TheCard> list3 = this.cards;
			Func<TheCard, bool> func5 = delegate(TheCard card)
			{
				int thePlantType = (int)card.thePlantType;
				CardLevel cardLevel;
				return cardLevel == selectedLevel;
			};
			return ListExtensions.GetRandom<TheCard>(Enumerable.ToList<TheCard>(Enumerable.Where<TheCard>(list3, func5))).thePlantType;
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x001591C8 File Offset: 0x001573C8
		[Token(Token = "0x60041B5")]
		[Address(RVA = "0x874620", Offset = "0x872C20", VA = "0x180874620")]
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

		// Token: 0x060041B6 RID: 16822 RVA: 0x00159228 File Offset: 0x00157428
		[Token(Token = "0x60041B6")]
		[Address(RVA = "0x8754C0", Offset = "0x873AC0", VA = "0x1808754C0")]
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
					AbyssLotteryMenu.<>c__DisplayClass25_0 CS$<>8__locals1;
					CS$<>8__locals1.<>4__this = this;
					TheButton theButton = this.sampleButton;
					Transform parent = theButton.transform.parent;
					TheButton theButton2 = global::UnityEngine.Object.Instantiate<TheButton>(theButton, parent);
					UnityEvent theEvent = theButton2.theEvent;
					UnityAction unityAction = delegate
					{
						AbyssLotteryMenu <>4__this = CS$<>8__locals1.<>4__this;
						Quality capturedQuality = CS$<>8__locals1.capturedQuality;
						<>4__this.OnMixedPoolButtonClicked(capturedQuality);
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

		// Token: 0x060041B7 RID: 16823 RVA: 0x00159398 File Offset: 0x00157598
		[Token(Token = "0x60041B7")]
		[Address(RVA = "0x877490", Offset = "0x875A90", VA = "0x180877490")]
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
				this.UpdateMixedPoolButtonsState();
				this.ClearAllButtonCheckMarks();
				TextMeshProUGUI textMeshProUGUI = this.infoText;
				string text3 = text2 + "混池模式（已选0个场景）";
				textMeshProUGUI.text = text3;
				this.InitCards();
				return;
			}
			int num2 = 0;
			this.mixedPoolQuality = num2;
			this.mixedScenes._size = num;
			this.targetScene = (SceneType)num;
			this.ShowAllQualityButtons();
			this.ClearAllButtonCheckMarks();
			this.UpdateMixedPoolButtonsState();
			TextMeshProUGUI textMeshProUGUI2 = this.infoText;
			Dictionary<SceneType, string> sceneName = MapData_cs.SceneName;
			int num3 = 0;
			string text4 = sceneName[num3];
			string text5 = "当前奖池：" + text4;
			textMeshProUGUI2.text = text5;
			this.InitCards();
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x0015949C File Offset: 0x0015769C
		[Token(Token = "0x60041B8")]
		[Address(RVA = "0x875A30", Offset = "0x874030", VA = "0x180875A30")]
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
			this.UpdateMixedPoolButtonsState();
			this.ClearAllButtonCheckMarks();
			TextMeshProUGUI textMeshProUGUI = this.infoText;
			string text3 = text2 + "混池模式（已选0个场景）";
			textMeshProUGUI.text = text3;
			this.InitCards();
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x00159520 File Offset: 0x00157720
		[Token(Token = "0x60041B9")]
		[Address(RVA = "0x875C00", Offset = "0x874200", VA = "0x180875C00")]
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

		// Token: 0x060041BA RID: 16826 RVA: 0x00159598 File Offset: 0x00157798
		[Token(Token = "0x60041BA")]
		[Address(RVA = "0x8789D0", Offset = "0x876FD0", VA = "0x1808789D0")]
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

		// Token: 0x060041BB RID: 16827 RVA: 0x001596EC File Offset: 0x001578EC
		[Token(Token = "0x60041BB")]
		[Address(RVA = "0x877D40", Offset = "0x876340", VA = "0x180877D40")]
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

		// Token: 0x060041BC RID: 16828 RVA: 0x00159728 File Offset: 0x00157928
		[Token(Token = "0x60041BC")]
		[Address(RVA = "0x877BE0", Offset = "0x8761E0", VA = "0x180877BE0")]
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

		// Token: 0x060041BD RID: 16829 RVA: 0x00159768 File Offset: 0x00157968
		[Token(Token = "0x60041BD")]
		[Address(RVA = "0x874A80", Offset = "0x873080", VA = "0x180874A80")]
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

		// Token: 0x060041BE RID: 16830 RVA: 0x0015987C File Offset: 0x00157A7C
		[Token(Token = "0x60041BE")]
		[Address(RVA = "0x876C70", Offset = "0x875270", VA = "0x180876C70")]
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

		// Token: 0x060041BF RID: 16831 RVA: 0x001598C4 File Offset: 0x00157AC4
		[Token(Token = "0x60041BF")]
		[Address(RVA = "0x876040", Offset = "0x874640", VA = "0x180876040")]
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

		// Token: 0x060041C0 RID: 16832 RVA: 0x00159900 File Offset: 0x00157B00
		[Token(Token = "0x60041C0")]
		[Address(RVA = "0x875050", Offset = "0x873650", VA = "0x180875050")]
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

		// Token: 0x060041C1 RID: 16833 RVA: 0x00159A64 File Offset: 0x00157C64
		[Token(Token = "0x60041C1")]
		[Address(RVA = "0x8777B0", Offset = "0x875DB0", VA = "0x1808777B0")]
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
			string text4;
			string text3 = "已移除：" + text4;
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

		// Token: 0x060041C2 RID: 16834 RVA: 0x00159B68 File Offset: 0x00157D68
		[Token(Token = "0x60041C2")]
		[Address(RVA = "0x8786D0", Offset = "0x876CD0", VA = "0x1808786D0")]
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

		// Token: 0x060041C3 RID: 16835 RVA: 0x00159C1C File Offset: 0x00157E1C
		[Token(Token = "0x60041C3")]
		[Address(RVA = "0x875D20", Offset = "0x874320", VA = "0x180875D20")]
		private int GetDiv(SceneType sceneType)
		{
			if (sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Night)
			{
			}
			return 0;
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x00159C40 File Offset: 0x00157E40
		[Token(Token = "0x60041C4")]
		[Address(RVA = "0x8765C0", Offset = "0x874BC0", VA = "0x1808765C0")]
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

		// Token: 0x060041C5 RID: 16837 RVA: 0x00159DA0 File Offset: 0x00157FA0
		[Token(Token = "0x60041C5")]
		[Address(RVA = "0x875D60", Offset = "0x874360", VA = "0x180875D60")]
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

		// Token: 0x060041C6 RID: 16838 RVA: 0x00159E18 File Offset: 0x00158018
		[Token(Token = "0x60041C6")]
		[Address(RVA = "0x876D40", Offset = "0x875340", VA = "0x180876D40")]
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

		// Token: 0x060041C7 RID: 16839 RVA: 0x00159F40 File Offset: 0x00158140
		[Token(Token = "0x60041C7")]
		[Address(RVA = "0x879600", Offset = "0x877C00", VA = "0x180879600")]
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

		// Token: 0x04003235 RID: 12853
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003235")]
		[Header("UI组件")]
		public TextMeshProUGUI singleText;

		// Token: 0x04003236 RID: 12854
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003236")]
		public TextMeshProUGUI tengleText;

		// Token: 0x04003237 RID: 12855
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003237")]
		public TextMeshProUGUI ticketText;

		// Token: 0x04003238 RID: 12856
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003238")]
		public TextMeshProUGUI infoText;

		// Token: 0x04003239 RID: 12857
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003239")]
		public RectTransform plantContainer;

		// Token: 0x0400323A RID: 12858
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400323A")]
		[Header("预制体")]
		public TheCard cardPrefab;

		// Token: 0x0400323B RID: 12859
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400323B")]
		public AbyssLotteryAnim animPrefab;

		// Token: 0x0400323C RID: 12860
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400323C")]
		public TheButton sampleButton;

		// Token: 0x0400323D RID: 12861
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400323D")]
		private SceneType targetScene;

		// Token: 0x0400323E RID: 12862
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x400323E")]
		private Quality quality;

		// Token: 0x0400323F RID: 12863
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400323F")]
		private readonly List<TheCard> cards;

		// Token: 0x04003240 RID: 12864
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4003240")]
		[TupleElementNames(new string[] { "sceneType", "quality" })]
		private readonly Dictionary<ValueTuple<SceneType, Quality>, TheButton> buttons;

		// Token: 0x04003241 RID: 12865
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4003241")]
		private Quality? mixedPoolQuality;

		// Token: 0x04003242 RID: 12866
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4003242")]
		private readonly List<SceneType> mixedScenes;

		// Token: 0x04003243 RID: 12867
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4003243")]
		private readonly Dictionary<Quality, TheButton> mixedPoolButtons;

		// Token: 0x04003244 RID: 12868
		[Token(Token = "0x4003244")]
		private const string SELECTED_MARK = "√";

		// Token: 0x04003245 RID: 12869
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4003245")]
		private readonly Dictionary<CardLevel, int> CardWeights;
	}
}
