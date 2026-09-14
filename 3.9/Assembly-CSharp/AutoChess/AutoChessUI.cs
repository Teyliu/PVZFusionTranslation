using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AutoChess
{
	// Token: 0x02000AEB RID: 2795
	[Token(Token = "0x2000AEB")]
	public class AutoChessUI : MonoBehaviour
	{
		// Token: 0x06003984 RID: 14724 RVA: 0x0012EFE0 File Offset: 0x0012D1E0
		[Token(Token = "0x6003984")]
		[Address(RVA = "0x7CC5E0", Offset = "0x7CABE0", VA = "0x1807CC5E0")]
		private void Awake()
		{
			AutoChessUI.Instance = this;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			this.RegisterEventListeners();
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x0012F010 File Offset: 0x0012D210
		[Token(Token = "0x6003985")]
		[Address(RVA = "0x7CC780", Offset = "0x7CAD80", VA = "0x1807CC780")]
		private void OnDestroy()
		{
			this.UnregisterEventListeners();
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x0012F024 File Offset: 0x0012D224
		[Token(Token = "0x6003986")]
		[Address(RVA = "0x7CC6D0", Offset = "0x7CACD0", VA = "0x1807CC6D0")]
		private void InitializeUI()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x0012F048 File Offset: 0x0012D248
		[Token(Token = "0x6003987")]
		[Address(RVA = "0x7CC790", Offset = "0x7CAD90", VA = "0x1807CC790")]
		private void RegisterEventListeners()
		{
			EconomyManager <Instance>k__BackingField = EconomyManager.<Instance>k__BackingField;
			int num = 0;
			if (<Instance>k__BackingField != num)
			{
				Action<int> onLevelChanged = EconomyManager.<Instance>k__BackingField.OnLevelChanged;
				Action<int> action;
				Delegate @delegate = Delegate.Combine(onLevelChanged, action);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLevelChanged)
					{
					}
					Action<int, int> onExpChanged = EconomyManager.<Instance>k__BackingField.OnExpChanged;
					Action<int, int> action2;
					Delegate delegate2 = Delegate.Combine(onExpChanged, action2);
					if (delegate2 == 0 || delegate2 != 0)
					{
						while (delegate2 != onExpChanged)
						{
						}
						Action<int, int> onHealthChanged = EconomyManager.<Instance>k__BackingField.OnHealthChanged;
						Action<int, int> action3;
						Delegate delegate3 = Delegate.Combine(onHealthChanged, action3);
						if (delegate3 == 0 || delegate3 != 0)
						{
							while (delegate3 != onHealthChanged)
							{
							}
							goto IL_008F;
						}
					}
				}
				throw new InvalidCastException();
			}
			IL_008F:
			SynergyManager <Instance>k__BackingField2 = SynergyManager.<Instance>k__BackingField;
			int num2 = 0;
			if (<Instance>k__BackingField2 != num2)
			{
				SynergyManager <Instance>k__BackingField3 = SynergyManager.<Instance>k__BackingField;
				Action action4 = new Action(this.UpdateSynergyUI);
				Action onAllSynergiesRefreshed = <Instance>k__BackingField3.OnAllSynergiesRefreshed;
				Delegate delegate4 = Delegate.Combine(onAllSynergiesRefreshed, action4);
				if (delegate4 != 0 && delegate4 == 0)
				{
					throw new InvalidCastException();
				}
				while (delegate4 != onAllSynergiesRefreshed)
				{
				}
			}
			ShopManager <Instance>k__BackingField4 = ShopManager.<Instance>k__BackingField;
			int num3 = 0;
			if (<Instance>k__BackingField4 != num3)
			{
				Action<List<PlantData>> onShopRefreshed = ShopManager.<Instance>k__BackingField.OnShopRefreshed;
				Action<List<PlantData>> action5;
				Delegate delegate5 = Delegate.Combine(onShopRefreshed, action5);
				if (delegate5 != 0 && delegate5 == 0)
				{
					throw new InvalidCastException();
				}
				while (delegate5 != onShopRefreshed)
				{
				}
			}
			Debug.Log("[AutoChessUI] 事件监听注册完成");
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x0012F194 File Offset: 0x0012D394
		[Token(Token = "0x6003988")]
		[Address(RVA = "0x7CCDE0", Offset = "0x7CB3E0", VA = "0x1807CCDE0")]
		private void UnregisterEventListeners()
		{
			EconomyManager <Instance>k__BackingField = EconomyManager.<Instance>k__BackingField;
			int num = 0;
			if (<Instance>k__BackingField != num)
			{
				Action<int> onLevelChanged = EconomyManager.<Instance>k__BackingField.OnLevelChanged;
				Action<int> action;
				Delegate @delegate = Delegate.Remove(onLevelChanged, action);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLevelChanged)
					{
					}
					Action<int, int> onExpChanged = EconomyManager.<Instance>k__BackingField.OnExpChanged;
					Action<int, int> action2;
					Delegate delegate2 = Delegate.Remove(onExpChanged, action2);
					if (delegate2 == 0 || delegate2 != 0)
					{
						while (delegate2 != onExpChanged)
						{
						}
						Action<int, int> onHealthChanged = EconomyManager.<Instance>k__BackingField.OnHealthChanged;
						Action<int, int> action3;
						Delegate delegate3 = Delegate.Remove(onHealthChanged, action3);
						if (delegate3 == 0 || delegate3 != 0)
						{
							while (delegate3 != onHealthChanged)
							{
							}
							goto IL_008F;
						}
					}
				}
				throw new InvalidCastException();
			}
			IL_008F:
			SynergyManager <Instance>k__BackingField2 = SynergyManager.<Instance>k__BackingField;
			int num2 = 0;
			if (<Instance>k__BackingField2 != num2)
			{
				SynergyManager <Instance>k__BackingField3 = SynergyManager.<Instance>k__BackingField;
				Action action4 = new Action(this.UpdateSynergyUI);
				Action onAllSynergiesRefreshed = <Instance>k__BackingField3.OnAllSynergiesRefreshed;
				Delegate delegate4 = Delegate.Remove(onAllSynergiesRefreshed, action4);
				if (delegate4 != 0 && delegate4 == 0)
				{
					throw new InvalidCastException();
				}
				while (delegate4 != onAllSynergiesRefreshed)
				{
				}
			}
			ShopManager <Instance>k__BackingField4 = ShopManager.<Instance>k__BackingField;
			int num3 = 0;
			if (<Instance>k__BackingField4 != num3)
			{
				Action<List<PlantData>> onShopRefreshed = ShopManager.<Instance>k__BackingField.OnShopRefreshed;
				Action<List<PlantData>> action5;
				Delegate delegate5 = Delegate.Remove(onShopRefreshed, action5);
				if (delegate5 != 0 && delegate5 == 0)
				{
					throw new InvalidCastException();
				}
				while (delegate5 != onShopRefreshed)
				{
				}
			}
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x0012F2D8 File Offset: 0x0012D4D8
		[Token(Token = "0x6003989")]
		[Address(RVA = "0x7CD3F0", Offset = "0x7CB9F0", VA = "0x1807CD3F0")]
		private void UpdateAllUI()
		{
			TextMeshProUGUI text = this.levelCard.text;
			int currentLevel = EconomyManager.<Instance>k__BackingField.currentLevel;
			string text2 = string.Format("{0}", currentLevel);
			text.text = text2;
			if ((ulong)1L == 0UL)
			{
			}
			if (EconomyManager.<Instance>k__BackingField.currentLevel == 10)
			{
				this.experienceCard.text.text = "Max";
			}
			TextMeshProUGUI text3 = this.experienceCard.text;
			int currentExp = EconomyManager.<Instance>k__BackingField.currentExp;
			int expToNextLevel = EconomyManager.<Instance>k__BackingField.ExpToNextLevel;
			string text4 = string.Format("{0}/{1}", currentExp, expToNextLevel);
			text3.text = text4;
			TextMeshProUGUI text5 = this.healthCard.text;
			int currentHealth = EconomyManager.<Instance>k__BackingField.currentHealth;
			string text6 = string.Format("{0}", currentHealth);
			text5.text = text6;
			this.UpdateSynergyUI();
			List<PlantData> list = new List(ShopManager.<Instance>k__BackingField.currentShopPlants);
			this.UpdateShopUI(list);
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x0012F3CC File Offset: 0x0012D5CC
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x7CDB40", Offset = "0x7CC140", VA = "0x1807CDB40")]
		private void UpdateLevelUI(int level)
		{
			TextMeshProUGUI text = this.levelCard.text;
			int currentLevel = EconomyManager.<Instance>k__BackingField.currentLevel;
			string text2 = string.Format("{0}", currentLevel);
			text.text = text2;
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x0012F40C File Offset: 0x0012D60C
		[Token(Token = "0x600398B")]
		[Address(RVA = "0x7CD8B0", Offset = "0x7CBEB0", VA = "0x1807CD8B0")]
		private void UpdateExpUI(int currentExp, int requiredExp)
		{
			if (EconomyManager.<Instance>k__BackingField.currentLevel == 10)
			{
				this.experienceCard.text.text = "Max";
			}
			TextMeshProUGUI text = this.experienceCard.text;
			if ((ulong)1L == 0UL)
			{
			}
			int currentExp2 = EconomyManager.<Instance>k__BackingField.currentExp;
			int expToNextLevel = EconomyManager.<Instance>k__BackingField.ExpToNextLevel;
			string text2 = string.Format("{0}/{1}", currentExp2, requiredExp);
			text.text = text2;
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x0012F480 File Offset: 0x0012D680
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x7CDA70", Offset = "0x7CC070", VA = "0x1807CDA70")]
		private void UpdateHealthUI(int currentHealth, int maxHealth)
		{
			TextMeshProUGUI text = this.healthCard.text;
			int currentHealth2 = EconomyManager.<Instance>k__BackingField.currentHealth;
			string text2 = string.Format("{0}", currentHealth2);
			text.text = text2;
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x0012F4C0 File Offset: 0x0012D6C0
		[Token(Token = "0x600398D")]
		[Address(RVA = "0x7CDEF0", Offset = "0x7CC4F0", VA = "0x1807CDEF0")]
		private void UpdateSynergyUI()
		{
			int num6;
			do
			{
				int num = 0;
				Transform transform = this.synergyPanel;
				int num2 = 0;
				if (transform == num2)
				{
					break;
				}
				GameObject gameObject = this.synergySlotPrefab;
				int num3 = 0;
				if (gameObject == num3)
				{
					break;
				}
				List<GameObject> list = this.synergySlots;
				int num4 = 0;
				bool flag;
				if (flag)
				{
					int num5 = 0;
					if (!(num != num5))
					{
						continue;
					}
					global::UnityEngine.Object.Destroy(num);
				}
				if (num4 != 0)
				{
					goto IL_00A4;
				}
				num6 = 0;
				List<ValueTuple<string, int, int, string>> activeSynergiesInfo = SynergyManager.<Instance>k__BackingField.GetActiveSynergiesInfo();
				bool flag2;
				if (flag2)
				{
					GameObject gameObject2;
					Text[] componentsInChildren = gameObject2.GetComponentsInChildren<Text>();
					string text;
					componentsInChildren[0].text = text;
					componentsInChildren[1].text = num;
				}
			}
			while (num6 != 0);
			return;
			IL_00A4:
			throw new IndexOutOfRangeException();
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x0012F5A8 File Offset: 0x0012D7A8
		[Token(Token = "0x600398E")]
		[Address(RVA = "0x7CDC10", Offset = "0x7CC210", VA = "0x1807CDC10")]
		private void UpdateShopUI(List<PlantData> plants)
		{
			int num2;
			do
			{
				int num = 0;
				List<CardUI> cards = InGameUI.Instance.Cards;
				num2 = 0;
				bool flag;
				if (flag)
				{
					if (num != 0)
					{
						while (num != 0)
						{
						}
					}
					bool flag2 = InGameUI.Instance.RemoveCardFromBank(num, true);
				}
			}
			while (num2 != 0);
			int num3 = 0;
			InitBoard instance = InitBoard.Instance;
			PlantData plantData;
			PlantType plantType = plantData.PlantType;
			int cost = plantData.Cost;
			CardUI cardUI;
			cardUI.theSeedCost = cost;
			int num4 = plantData.Cost - 1;
			cardUI.SetImage(num4);
			num3++;
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x0012F634 File Offset: 0x0012D834
		[Token(Token = "0x600398F")]
		[Address(RVA = "0x7CE410", Offset = "0x7CCA10", VA = "0x1807CE410")]
		public AutoChessUI()
		{
			List<GameObject> list = new List();
			this.synergySlots = list;
			base..ctor();
		}

		// Token: 0x04002BBC RID: 11196
		[Token(Token = "0x4002BBC")]
		public static AutoChessUI Instance;

		// Token: 0x04002BBD RID: 11197
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BBD")]
		[Header("信息显示")]
		public CardUI levelCard;

		// Token: 0x04002BBE RID: 11198
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002BBE")]
		public CardUI experienceCard;

		// Token: 0x04002BBF RID: 11199
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002BBF")]
		public CardUI healthCard;

		// Token: 0x04002BC0 RID: 11200
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002BC0")]
		[Header("羁绊面板")]
		public Transform synergyPanel;

		// Token: 0x04002BC1 RID: 11201
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002BC1")]
		public GameObject synergySlotPrefab;

		// Token: 0x04002BC2 RID: 11202
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002BC2")]
		private readonly List<GameObject> synergySlots;
	}
}
