using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel.RogueShooting;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F0 RID: 496
[Token(Token = "0x20001F0")]
public class CardUI : MonoBehaviour
{
	// Token: 0x0600085C RID: 2140 RVA: 0x0002A88C File Offset: 0x00028A8C
	[Token(Token = "0x600085C")]
	[Address(RVA = "0x8555E0", Offset = "0x853BE0", VA = "0x1808555E0")]
	private void OnDestroy()
	{
		this.plantAction = (ulong)0L;
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0002A8A4 File Offset: 0x00028AA4
	[Token(Token = "0x600085D")]
	[Address(RVA = "0x854680", Offset = "0x852C80", VA = "0x180854680", Slot = "4")]
	protected virtual void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		int num = this.theSeedType;
		this.thePlantType = (PlantType)num;
		this.theZombieType = (ZombieType)num;
		this.maxUsedTimes = (int)((ulong)1L);
		if (this.thePlantType == PlantType.Wheat)
		{
			this.thePlantType = (PlantType)((ulong)240L);
			this.ChangeCardSprite();
		}
		if (!this.fromSystem)
		{
			int num2 = (int)this.thePlantType;
			PlantDataManager.PlantData plantData;
			int cost = plantData.cost;
			this.theSeedCost = cost;
			float cd = plantData.cd;
			this.fullCD = cd;
			Board board = this.board;
			RogueManager instance2 = RogueManager.Instance;
			if (instance2.leaderType == LeaderType.SuperMachineNut)
			{
				float num3 = this.fullCD * 0.8f;
				this.fullCD = num3;
			}
			if (instance2.leaderType != LeaderType.SuperMachineNut)
			{
				float num4 = this.fullCD;
				this.CD = num4;
			}
			TextMeshProUGUI component = base.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
			this.text = component;
			Board instance3 = Board.Instance;
			int num5 = 0;
			this.theSeedCost = num5;
			this.fullCD = (float)num5;
			return;
		}
		TextMeshProUGUI component2 = base.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
		this.text = component2;
		throw new NullReferenceException();
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x0002A9D4 File Offset: 0x00028BD4
	[Token(Token = "0x600085E")]
	[Address(RVA = "0x8560C0", Offset = "0x8546C0", VA = "0x1808560C0", Slot = "5")]
	protected virtual void Start()
	{
		int num3;
		int num4;
		do
		{
			int num = 0;
			uint num2;
			Slider component = base.transform.GetChild((int)num2).gameObject.GetComponent<Slider>();
			this.slider = component;
			AdvantureData advantureData = AdvantureConfig.data;
			num3 = this.theSeedCost;
			List<TalentType> talents = advantureData.talents;
			num4 = 0;
			bool flag;
			if (flag)
			{
				if (num <= 15)
				{
					goto IL_0066;
				}
				if (num == 16)
				{
				}
				if (num != 25)
				{
					while (num != 26)
					{
					}
					float num5 = this.fullCD;
					this.fullCD = num5;
					goto IL_0066;
				}
				goto IL_006F;
				IL_007F:
				while (num != 15)
				{
				}
				goto IL_0084;
				IL_006F:
				float num6 = this.fullCD;
				this.fullCD = num6;
				goto IL_007F;
				IL_0066:
				if (num == 3)
				{
				}
				if (num == 11)
				{
					goto IL_006F;
				}
				goto IL_007F;
			}
			IL_0084:;
		}
		while (num4 != 0);
		bool flag2;
		if (flag2)
		{
		}
		bool flag3;
		if (flag3)
		{
		}
		bool flag4;
		if (flag4)
		{
		}
		bool flag5;
		if (flag5)
		{
		}
		bool flag6;
		if (flag6)
		{
		}
		bool flag7;
		if (flag7)
		{
		}
		bool flag8;
		if (flag8)
		{
		}
		bool flag9;
		if (flag9)
		{
		}
		bool flag10;
		if (flag10)
		{
		}
		bool flag11;
		if (flag11)
		{
		}
		bool flag12;
		if (flag12)
		{
		}
		if (num3 > 0)
		{
			int num7 = this.theSeedCost;
		}
		this.theSeedCost = num3;
		bool flag13;
		if (flag13)
		{
		}
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x0002AB3C File Offset: 0x00028D3C
	[Token(Token = "0x600085F")]
	[Address(RVA = "0x855530", Offset = "0x853B30", VA = "0x180855530")]
	public void MushroomExtraCost(int value)
	{
		PlantType plantType = this.thePlantType;
		if ((plantType > PlantType.SeaShroom && plantType == PlantType.Magnetshroom) || (this.board.sceneType != SceneType.Snow && plantType == PlantType.SeaShroom))
		{
			int num = this.theSeedCost;
			num += value;
			this.theSeedCost = num;
			if (this.isExtra)
			{
			}
		}
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0002AB90 File Offset: 0x00028D90
	[Token(Token = "0x6000860")]
	[Address(RVA = "0x854BF0", Offset = "0x8531F0", VA = "0x180854BF0")]
	private void LevelLim()
	{
		GameObject gameObject;
		for (;;)
		{
			Board board = this.board;
			List<PlantType> allPlants = ShootingManager.Instance.AllPlants;
			PlantType plantType = this.thePlantType;
			if (allPlants.Contains(plantType) && !this.isExtra)
			{
				this.theSeedCost = (int)((ulong)0L);
				Board board2 = this.board;
				PlantType plantType2 = this.thePlantType;
				if (plantType2 > PlantType.SnowPresent)
				{
					if (plantType2 != PlantType.Imitater)
					{
						break;
					}
					goto IL_0079;
				}
				else if (gameObject == (ulong)9L || gameObject == (ulong)233L)
				{
					goto IL_0079;
				}
				IL_0080:
				int theBoardLevel = GameAPP.theBoardLevel;
				if (theBoardLevel <= 88)
				{
					goto IL_020A;
				}
				if (theBoardLevel > 119)
				{
					if (theBoardLevel > 130)
					{
						if (theBoardLevel == 159 && (typeof(GameAPP).TypeHandle <= (ulong)1L || typeof(GameAPP).TypeHandle == (ulong)5L || typeof(GameAPP).TypeHandle == (ulong)28L))
						{
							return;
						}
						if (theBoardLevel != 170)
						{
							goto IL_0430;
						}
						if (typeof(GameAPP).TypeHandle == (ulong)4294967293L)
						{
							return;
						}
					}
					if (theBoardLevel == 121)
					{
						if (typeof(GameAPP).TypeHandle > (ulong)7L)
						{
							if (typeof(GameAPP).TypeHandle == (ulong)12L)
							{
								return;
							}
							if (typeof(GameAPP).TypeHandle == (ulong)26L)
							{
								return;
							}
						}
						if (typeof(GameAPP).TypeHandle == (ulong)4294967291L)
						{
							return;
						}
					}
					if (theBoardLevel != 130)
					{
						goto IL_0430;
					}
					if (typeof(GameAPP).TypeHandle > (ulong)3L)
					{
						if (typeof(GameAPP).TypeHandle == (ulong)15L || typeof(GameAPP).TypeHandle == (ulong)25L)
						{
							return;
						}
						if (typeof(GameAPP).TypeHandle != (ulong)32L)
						{
							goto IL_0429;
						}
					}
					if (typeof(GameAPP).TypeHandle == 0 || typeof(GameAPP).TypeHandle == (ulong)3L)
					{
						return;
					}
				}
				if (theBoardLevel > 110)
				{
					if (theBoardLevel == 113 && typeof(GameAPP).TypeHandle <= (ulong)1L)
					{
						return;
					}
					if (theBoardLevel != 119)
					{
						goto IL_0430;
					}
				}
				uint num;
				if (theBoardLevel != 97)
				{
					if (typeof(GameAPP).TypeHandle <= (ulong)1L)
					{
						if (typeof(GameAPP).TypeHandle > (ulong)15L && (typeof(GameAPP).TypeHandle == (ulong)24L || typeof(GameAPP).TypeHandle == (ulong)27L))
						{
							goto IL_0429;
						}
						if (typeof(GameAPP).TypeHandle <= (ulong)256L && typeof(GameAPP).TypeHandle < (ulong)256L)
						{
							goto IL_020A;
						}
					}
				}
				else if ((num > (uint)233 && (num == (uint)250 || num == (uint)253)) || num == (uint)1 || num == (uint)8 || num == (uint)233)
				{
					goto IL_0429;
				}
				IL_0430:
				if (GameAPP.theBoardLevel == 1)
				{
					return;
				}
				continue;
				IL_020A:
				if (theBoardLevel > 50)
				{
					if (theBoardLevel > 73)
					{
						if ((theBoardLevel == 76 && (typeof(GameAPP).TypeHandle == (ulong)1L || typeof(GameAPP).TypeHandle == (ulong)3L)) || typeof(GameAPP).TypeHandle > (ulong)7L)
						{
							goto IL_0430;
						}
						if ((typeof(GameAPP).TypeHandle > (ulong)8L && (typeof(GameAPP).TypeHandle == (ulong)14L || typeof(GameAPP).TypeHandle == (ulong)17L)) || typeof(GameAPP).TypeHandle == (ulong)1L || typeof(GameAPP).TypeHandle == (ulong)8L)
						{
							return;
						}
						if (typeof(GameAPP).TypeHandle > (ulong)7L)
						{
							goto IL_0429;
						}
					}
					if (typeof(GameAPP).TypeHandle == (ulong)233L)
					{
					}
					if (typeof(GameAPP).TypeHandle == (ulong)245L)
					{
						goto IL_0430;
					}
					if (typeof(GameAPP).TypeHandle != (ulong)256L)
					{
						goto IL_0429;
					}
					if (typeof(GameAPP).TypeHandle > (ulong)1L)
					{
						goto IL_0430;
					}
					if (typeof(GameAPP).TypeHandle == (ulong)3L || typeof(GameAPP).TypeHandle == (ulong)6L || typeof(GameAPP).TypeHandle == (ulong)6L)
					{
						return;
					}
					if (typeof(GameAPP).TypeHandle == (ulong)6L)
					{
						goto IL_0429;
					}
					if (typeof(GameAPP).TypeHandle == (ulong)6L)
					{
						return;
					}
					if (typeof(GameAPP).TypeHandle == (ulong)6L)
					{
						goto IL_0429;
					}
					if (typeof(GameAPP).TypeHandle == (ulong)1L)
					{
						return;
					}
				}
				if (typeof(GameAPP).TypeHandle != (ulong)4294967293L || ((typeof(GameAPP).TypeHandle <= (ulong)233L || typeof(GameAPP).TypeHandle <= (ulong)11L) && num == (uint)(-7)))
				{
					if (num > (uint)15)
					{
						goto IL_0430;
					}
					if ((num > (uint)5 && (num == (uint)9 || num == (uint)18)) || num == (uint)0 || num == (uint)5)
					{
						return;
					}
				}
				IL_0429:
				GameObject gameObject2;
				global::UnityEngine.Object.Destroy(gameObject2);
				goto IL_0430;
				IL_0079:
				GameObject gameObject3;
				global::UnityEngine.Object.Destroy(gameObject3);
				goto IL_0080;
			}
			break;
		}
		gameObject = base.gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0002B044 File Offset: 0x00029244
	[Token(Token = "0x6000861")]
	[Address(RVA = "0x856870", Offset = "0x854E70", VA = "0x180856870", Slot = "6")]
	protected virtual void Update()
	{
		if (this.Durability == 0)
		{
			List<TreasureCardData> cardData = TreasureManager.Instance.cardData;
			TreasureCardData treasureCardData = this.data;
			bool flag = cardData.Remove(treasureCardData);
			CardSlotManager cardSlotManager = InGameUI.Instance._cardSlotManager;
			int num = 0;
			bool flag2 = cardSlotManager.RemoveCard(this, num != 0);
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		if (this.disabled)
		{
			this.isAvailable = false;
			uint num2;
			ulong num3;
			base.transform.GetChild((int)num2).gameObject.SetActive(num3 != 0UL);
			return;
		}
		this.CDUpdate();
		if (this.board.freeCD)
		{
			float num4 = this.fullCD;
			this.CD = num4;
			this.isAvailable = true;
		}
		bool flag3;
		if (this.thePlantType == PlantType.Imitater && flag3 && this.fullCD > 50f)
		{
			this.fullCD = 50f;
		}
		if (!this.useLimited)
		{
			string text;
			this.text.text = text;
			return;
		}
		int num5 = this.maxUsedTimes;
		int num6 = (int)this.thePlantType;
		bool flag4;
		if (flag4)
		{
			num5 += 2;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
		string text2;
		this.text.text = text2;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x0002B174 File Offset: 0x00029374
	[Token(Token = "0x6000862")]
	[Address(RVA = "0x8548B0", Offset = "0x852EB0", VA = "0x1808548B0", Slot = "7")]
	protected virtual void CDUpdate()
	{
		if (this.fullCD <= this.CD)
		{
			float num = this.fullCD;
			this.CD = num;
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)1001)))
		{
			float deltaTime = Time.deltaTime;
			this.CD = deltaTime;
		}
		if (this.board.theWave == 0 && AdvantureConfig.data.GetResult((AdvantureLevel)((uint)50), (MissionResult)((uint)1)))
		{
			float num2 = Time.deltaTime * 0.2f;
			this.CD = num2;
		}
		float deltaTime2 = Time.deltaTime;
		this.isAvailable = false;
		this.CD = deltaTime2;
		Board board = this.board;
		if (board.enermyCount == 0)
		{
			float num3 = this.fullCD;
			this.CD = num3;
		}
		if (board.enermyCount == 0)
		{
			Board board2 = this.board;
			int num4 = this.theSeedCost;
			if (!this.isPickUp)
			{
				this.isAvailable = true;
				GameObject gameObject = base.transform.GetChild(3).gameObject;
			}
		}
		this.isAvailable = false;
		GameObject gameObject2 = base.transform.GetChild(3).gameObject;
		gameObject2.SetActive(true);
		Slider slider = this.slider;
		if (gameObject2 == 0)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x0002B2A0 File Offset: 0x000294A0
	[Token(Token = "0x6000863")]
	[Address(RVA = "0x855DC0", Offset = "0x8543C0", VA = "0x180855DC0")]
	private void OnMouseEnter()
	{
		GameObject theItemOnMouse = Mouse.Instance.theItemOnMouse;
		int num = 0;
		if (theItemOnMouse == num)
		{
			CursorChange.SetClickCursor();
			return;
		}
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x0002B2D4 File Offset: 0x000294D4
	[Token(Token = "0x6000864")]
	[Address(RVA = "0x51B300", Offset = "0x519900", VA = "0x18051B300")]
	private void OnMouseExit()
	{
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x0002B2E8 File Offset: 0x000294E8
	[Token(Token = "0x6000865")]
	[Address(RVA = "0x855600", Offset = "0x853C00", VA = "0x180855600", Slot = "8")]
	protected virtual void OnMouseDown()
	{
		int num;
		do
		{
			num = 0;
			CursorChange.SetDefaultCursor();
			Plant plant = this.p_plant;
			int num2 = 0;
			if (!(plant == num2))
			{
				return;
			}
			CardUI cardUI = this.p_card;
			int num3 = 0;
			if (!(cardUI == num3))
			{
				return;
			}
			if ((this.preSelected ? 1 : 0) != num)
			{
				goto IL_022D;
			}
			uint num4;
			GameAPP.PlaySound((int)num4, 0.5f, 1f);
			SeedLibrary instance = SeedLibrary.Instance;
			int num5 = 0;
			if (!(instance != num5))
			{
				goto IL_019B;
			}
			SeedLibrary instance2 = SeedLibrary.Instance;
			if ((instance2.safeMode ? 1 : 0) == num)
			{
				goto IL_019B;
			}
			if ((this.isSelected ? 1 : 0) != num)
			{
				goto IL_01A4;
			}
			if ((this.safe ? 1 : 0) != num)
			{
				break;
			}
			Transform transform = instance2.safeBox.transform;
			int num6 = 0;
			IEnumerator enumerator = transform.GetChild(num6).GetEnumerator();
			if (enumerator != 0)
			{
				int num7;
				while (num7 != 0)
				{
				}
				Transform transform2 = base.transform;
				InGameUI instance3 = InGameUI.Instance;
				int num8 = 0;
				instance3.MoveCardToTarget(this, num8 != 0);
				List<TreasureCardData> cardData = TreasureManager.Instance.cardData;
				TreasureCardData treasureCardData = this.data;
				bool flag = cardData.Remove(treasureCardData);
				TreasureData.GetCard(this.data);
				this.safe = true;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		this.safe = false;
		Transform transform3 = base.transform;
		Transform transform4 = this.parent.transform;
		transform3.parentInternal = transform4;
		InGameUI instance4 = InGameUI.Instance;
		int num9 = 0;
		instance4.MoveCardToTarget(this, num9 != 0);
		List<TreasureCardData> cardData2 = TreasureManager.Instance.cardData;
		TreasureCardData treasureCardData2 = this.data;
		int num10 = cardData2._size + 1;
		cardData2._size = num10;
		List<TreasureCardData> treasureCards = TreasureData.treasureCards;
		TreasureCardData treasureCardData3 = this.data;
		bool flag2 = treasureCards.Remove(treasureCardData3);
		return;
		IL_019B:
		if ((this.isSelected ? 1 : 0) == num)
		{
			GameObject safeBox = SeedLibrary.Instance.safeBox;
			int num11 = 0;
			if (safeBox.activeSelf)
			{
				bool flag3 = TreasureData.treasureCards.Remove(num11);
			}
			InGameUI_IZ instance5 = InGameUI_IZ.Instance;
			int num12 = 0;
			if (!(instance5 != num12))
			{
				InGameUI instance6 = InGameUI.Instance;
				return;
			}
			InGameUI_IZ instance7 = InGameUI_IZ.Instance;
			return;
		}
		IL_01A4:
		this.isSelected = num != 0;
		InGameUI_IZ instance8 = InGameUI_IZ.Instance;
		int num13 = 0;
		if (!(instance8 != num13))
		{
			InGameUI instance9 = InGameUI.Instance;
			int num14 = 0;
			bool flag4 = instance9.RemoveCardFromBank(this, num14 != 0);
			return;
		}
		InGameUI_IZ instance10 = InGameUI_IZ.Instance;
		return;
		IL_022D:
		uint num15;
		GameAPP.PlaySound((int)num15, 0.5f, 1f);
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x0002B564 File Offset: 0x00029764
	[Token(Token = "0x6000866")]
	[Address(RVA = "0x855E50", Offset = "0x854450", VA = "0x180855E50", Slot = "9")]
	public virtual bool PickUp()
	{
		base.transform.GetChild(3).gameObject.SetActive(true);
		this.isPickUp = true;
		return true;
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x0002B598 File Offset: 0x00029798
	[Token(Token = "0x6000867")]
	[Address(RVA = "0x855EB0", Offset = "0x8544B0", VA = "0x180855EB0")]
	public void PutDown()
	{
		GameObject gameObject = base.transform.GetChild(3).gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.isPickUp = false;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0002B5D0 File Offset: 0x000297D0
	[Token(Token = "0x6000868")]
	[Address(RVA = "0x8560B0", Offset = "0x8546B0", VA = "0x1808560B0")]
	public void SetLevel(int index)
	{
		this.thePlantLevel = index;
		this.SetImage(index);
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x0002B5EC File Offset: 0x000297EC
	[Token(Token = "0x6000869")]
	[Address(RVA = "0x855F10", Offset = "0x854510", VA = "0x180855F10")]
	public void SetImage(int index)
	{
		List<Sprite> list = this.sprites;
		Image component = base.GetComponent<Image>();
		Sprite sprite = this.sprites[index];
		component.sprite = sprite;
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x0002B624 File Offset: 0x00029824
	[Token(Token = "0x600086A")]
	[Address(RVA = "0x855FD0", Offset = "0x8545D0", VA = "0x180855FD0")]
	public void SetImage(CardBgType cardBgType)
	{
		Dictionary<CardBgType, Sprite> cardBgTypes = GameAPP.resourcesManager.CardBgTypes;
		bool flag;
		if (flag)
		{
			Image component = base.GetComponent<Image>();
			this.cardBgType = cardBgType;
		}
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0002B658 File Offset: 0x00029858
	[Token(Token = "0x600086B")]
	[Address(RVA = "0x854B90", Offset = "0x853190", VA = "0x180854B90")]
	public void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x0002B670 File Offset: 0x00029870
	[Token(Token = "0x600086C")]
	[Address(RVA = "0x854B00", Offset = "0x853100", VA = "0x180854B00")]
	public void ChangeCardSprite()
	{
		Transform transform = base.transform;
		int num = 0;
		Image component = transform.GetChild(num).GetComponent<Image>();
		PlantType plantType = this.thePlantType;
		component.SetIcon(plantType, 400f, 0.18f);
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x0002B6B4 File Offset: 0x000298B4
	[Token(Token = "0x600086D")]
	[Address(RVA = "0x856BF0", Offset = "0x8551F0", VA = "0x180856BF0")]
	public void UseOnce()
	{
		if (this.Durability != -1)
		{
			int num = 0;
			TreasureDifficulty treasureDifficulty = TreasureData.difficulty;
			if (treasureDifficulty != TreasureDifficulty.Normal)
			{
				uint num2;
				treasureDifficulty -= (int)num2;
				if (treasureDifficulty != TreasureDifficulty.Normal)
				{
					treasureDifficulty -= (int)num2;
					if (treasureDifficulty != TreasureDifficulty.Normal)
					{
						treasureDifficulty -= (int)num2;
						if (treasureDifficulty == TreasureDifficulty.Normal || treasureDifficulty == (TreasureDifficulty)num2)
						{
						}
					}
				}
			}
			TreasureCardData treasureCardData = this.data;
			if (this.Durability < num)
			{
				TreasureCardData treasureCardData2 = this.data;
				this.Durability = num;
				treasureCardData2.durability = num;
			}
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x0002B720 File Offset: 0x00029920
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x856CD0", Offset = "0x8552D0", VA = "0x180856CD0")]
	public CardUI()
	{
		List<Sprite> list = new List();
		this.sprites = list;
		this.Durability = (int)((ulong)(-1L));
		base..ctor();
	}

	// Token: 0x040003D8 RID: 984
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003D8")]
	public int theSeedType;

	// Token: 0x040003D9 RID: 985
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40003D9")]
	public int theSeedCost = (int)((ulong)100L);

	// Token: 0x040003DA RID: 986
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003DA")]
	public bool isSelected;

	// Token: 0x040003DB RID: 987
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40003DB")]
	public int theNumberInCardSort;

	// Token: 0x040003DC RID: 988
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003DC")]
	public int thePlantLevel = (int)((ulong)4294967295L);

	// Token: 0x040003DD RID: 989
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003DD")]
	public GameObject parent;

	// Token: 0x040003DE RID: 990
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003DE")]
	public bool isAvailable = true;

	// Token: 0x040003DF RID: 991
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40003DF")]
	public float CD;

	// Token: 0x040003E0 RID: 992
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003E0")]
	public float fullCD = 7.5f;

	// Token: 0x040003E1 RID: 993
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40003E1")]
	public int usedTimes;

	// Token: 0x040003E2 RID: 994
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003E2")]
	public int maxUsedTimes;

	// Token: 0x040003E3 RID: 995
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40003E3")]
	public bool preSelected;

	// Token: 0x040003E4 RID: 996
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x40003E4")]
	public bool safe;

	// Token: 0x040003E5 RID: 997
	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x40003E5")]
	public bool fromSystem;

	// Token: 0x040003E6 RID: 998
	[FieldOffset(Offset = "0x57")]
	[Token(Token = "0x40003E6")]
	public bool isPickUp;

	// Token: 0x040003E7 RID: 999
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003E7")]
	public bool isExtra;

	// Token: 0x040003E8 RID: 1000
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x40003E8")]
	public bool disabled;

	// Token: 0x040003E9 RID: 1001
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x40003E9")]
	public bool onCardBank = true;

	// Token: 0x040003EA RID: 1002
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003EA")]
	protected Slider slider;

	// Token: 0x040003EB RID: 1003
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003EB")]
	public TextMeshProUGUI text;

	// Token: 0x040003EC RID: 1004
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003EC")]
	protected TextMeshProUGUI textBg;

	// Token: 0x040003ED RID: 1005
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40003ED")]
	public PlantType thePlantType;

	// Token: 0x040003EE RID: 1006
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40003EE")]
	public ZombieType theZombieType;

	// Token: 0x040003EF RID: 1007
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003EF")]
	public CardBgType cardBgType;

	// Token: 0x040003F0 RID: 1008
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003F0")]
	public List<Sprite> sprites;

	// Token: 0x040003F1 RID: 1009
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003F1")]
	public Action<Plant> plantAction;

	// Token: 0x040003F2 RID: 1010
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40003F2")]
	public Plant p_plant;

	// Token: 0x040003F3 RID: 1011
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40003F3")]
	public CardUI p_card;

	// Token: 0x040003F4 RID: 1012
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40003F4")]
	public Board board;

	// Token: 0x040003F5 RID: 1013
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40003F5")]
	public TreasureCardData data;

	// Token: 0x040003F6 RID: 1014
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40003F6")]
	public bool useLimited;

	// Token: 0x040003F7 RID: 1015
	[FieldOffset(Offset = "0xB9")]
	[Token(Token = "0x40003F7")]
	public bool mixAnim;

	// Token: 0x040003F8 RID: 1016
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40003F8")]
	public int Durability;

	// Token: 0x040003F9 RID: 1017
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40003F9")]
	public int MaxDurability;
}
