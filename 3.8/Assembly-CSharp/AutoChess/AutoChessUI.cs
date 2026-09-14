using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AutoChess
{
	// Token: 0x02000AAB RID: 2731
	[Token(Token = "0x2000AAB")]
	public class AutoChessUI : MonoBehaviour
	{
		// Token: 0x06003840 RID: 14400 RVA: 0x00129DB0 File Offset: 0x00127FB0
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x7657A0", Offset = "0x763DA0", VA = "0x1807657A0")]
		private void Awake()
		{
			AutoChessUI.Instance = this;
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			this.RegisterEventListeners();
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00129DE0 File Offset: 0x00127FE0
		[Token(Token = "0x6003841")]
		[Address(RVA = "0x765940", Offset = "0x763F40", VA = "0x180765940")]
		private void OnDestroy()
		{
			this.UnregisterEventListeners();
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00129DF4 File Offset: 0x00127FF4
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x765890", Offset = "0x763E90", VA = "0x180765890")]
		private void InitializeUI()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00129E18 File Offset: 0x00128018
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x765950", Offset = "0x763F50", VA = "0x180765950")]
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

		// Token: 0x06003844 RID: 14404 RVA: 0x00129F64 File Offset: 0x00128164
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x765FA0", Offset = "0x7645A0", VA = "0x180765FA0")]
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

		// Token: 0x06003845 RID: 14405 RVA: 0x0012A0A8 File Offset: 0x001282A8
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x7665B0", Offset = "0x764BB0", VA = "0x1807665B0")]
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

		// Token: 0x06003846 RID: 14406 RVA: 0x0012A19C File Offset: 0x0012839C
		[Token(Token = "0x6003846")]
		[Address(RVA = "0x766D00", Offset = "0x765300", VA = "0x180766D00")]
		private void UpdateLevelUI(int level)
		{
			TextMeshProUGUI text = this.levelCard.text;
			int currentLevel = EconomyManager.<Instance>k__BackingField.currentLevel;
			string text2 = string.Format("{0}", currentLevel);
			text.text = text2;
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x0012A1DC File Offset: 0x001283DC
		[Token(Token = "0x6003847")]
		[Address(RVA = "0x766A70", Offset = "0x765070", VA = "0x180766A70")]
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

		// Token: 0x06003848 RID: 14408 RVA: 0x0012A250 File Offset: 0x00128450
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x766C30", Offset = "0x765230", VA = "0x180766C30")]
		private void UpdateHealthUI(int currentHealth, int maxHealth)
		{
			TextMeshProUGUI text = this.healthCard.text;
			int currentHealth2 = EconomyManager.<Instance>k__BackingField.currentHealth;
			string text2 = string.Format("{0}", currentHealth2);
			text.text = text2;
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x0012A290 File Offset: 0x00128490
		[Token(Token = "0x6003849")]
		[Address(RVA = "0x7670B0", Offset = "0x7656B0", VA = "0x1807670B0")]
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

		// Token: 0x0600384A RID: 14410 RVA: 0x0012A378 File Offset: 0x00128578
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x766DD0", Offset = "0x7653D0", VA = "0x180766DD0")]
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

		// Token: 0x0600384B RID: 14411 RVA: 0x0012A404 File Offset: 0x00128604
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x7675D0", Offset = "0x765BD0", VA = "0x1807675D0")]
		public AutoChessUI()
		{
			List<GameObject> list = new List();
			this.synergySlots = list;
			base..ctor();
		}

		// Token: 0x04002A49 RID: 10825
		[Token(Token = "0x4002A49")]
		public static AutoChessUI Instance;

		// Token: 0x04002A4A RID: 10826
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002A4A")]
		[Header("信息显示")]
		public CardUI levelCard;

		// Token: 0x04002A4B RID: 10827
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A4B")]
		public CardUI experienceCard;

		// Token: 0x04002A4C RID: 10828
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002A4C")]
		public CardUI healthCard;

		// Token: 0x04002A4D RID: 10829
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002A4D")]
		[Header("羁绊面板")]
		public Transform synergyPanel;

		// Token: 0x04002A4E RID: 10830
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002A4E")]
		public GameObject synergySlotPrefab;

		// Token: 0x04002A4F RID: 10831
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002A4F")]
		private readonly List<GameObject> synergySlots;
	}
}
