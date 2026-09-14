using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E3 RID: 1507
[Token(Token = "0x20005E3")]
public class PrizeMgr : MonoBehaviour
{
	// Token: 0x06001C5F RID: 7263 RVA: 0x000975C4 File Offset: 0x000957C4
	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x509560", Offset = "0x507B60", VA = "0x180509560")]
	private void Start()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		float num = this.verticalSpeed;
		float num2 = this.horizontalSpeed;
		this.velocity = num2;
		this.velocity.y = num;
		Board instance = Board.Instance;
		Transform transform2 = base.transform;
		int num3 = 0;
		SpriteRenderer component = transform2.GetChild(num3).GetComponent<SpriteRenderer>();
		Sprite sprite = Resources.Load<Sprite>("Board/Award/SnowBossAword");
		component.sprite = sprite;
		Transform transform3 = base.transform;
		int num4 = 0;
		Transform child = transform3.GetChild(num4);
		AdvantureManager instance2 = AdvantureManager.Instance;
		int num5 = 0;
		if (instance2 != num5)
		{
			AdvantureManager instance3 = AdvantureManager.Instance;
			if (instance3.mission != (ulong)0L)
			{
				instance3.mission.end = true;
			}
		}
		EventManager.TriggerEvent((GameEvent)((uint)19));
	}

	// Token: 0x06001C60 RID: 7264 RVA: 0x00097694 File Offset: 0x00095894
	[Token(Token = "0x6001C60")]
	[Address(RVA = "0x5098B0", Offset = "0x507EB0", VA = "0x1805098B0", Slot = "4")]
	protected virtual void Update()
	{
		if (!this.isLand)
		{
			this.PostionUpdate();
		}
		if (Input.GetMouseButtonDown(0))
		{
			InGameUI instance = InGameUI.Instance;
			int num = 0;
			if ((instance != num && !InGameUI.Instance.Interactable) || !this.isClicked)
			{
			}
		}
	}

	// Token: 0x06001C61 RID: 7265 RVA: 0x000976E8 File Offset: 0x000958E8
	[Token(Token = "0x6001C61")]
	[Address(RVA = "0x508CE0", Offset = "0x5072E0", VA = "0x180508CE0")]
	private void PostionUpdate()
	{
		float y = this.velocity.y;
		float deltaTime = Time.deltaTime;
		this.velocity.y = y;
		Transform transform = base.transform;
		float deltaTime2 = Time.deltaTime;
		Transform transform2 = base.transform;
		Vector3 vector;
		if (this.startPosition.y <= vector.y)
		{
			Transform transform3 = base.transform;
			Vector3 vector2;
			if (Board.Instance.boardMinY <= vector2.y)
			{
				return;
			}
		}
		this.isLand = true;
		Transform transform4 = base.transform;
		Vector3 vector3;
		if (Board.Instance.boardMinY > vector3.y)
		{
			Transform transform5 = base.transform;
			Transform transform6 = base.transform;
			Board instance = Board.Instance;
		}
	}

	// Token: 0x06001C62 RID: 7266 RVA: 0x000977A0 File Offset: 0x000959A0
	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x507E00", Offset = "0x506400", VA = "0x180507E00", Slot = "5")]
	protected virtual void Click()
	{
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		int num = 0;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			int num2 = 0;
			Collider2D collider2D;
			if (collider2D != num2)
			{
				Collider2D collider2D2;
				GameObject gameObject = collider2D2.gameObject;
				GameObject gameObject2 = base.gameObject;
				if (gameObject == gameObject2)
				{
					this.Clicked();
				}
			}
			num++;
		}
	}

	// Token: 0x06001C63 RID: 7267 RVA: 0x00097814 File Offset: 0x00095A14
	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x508080", Offset = "0x506680", VA = "0x180508080")]
	public void Clicked()
	{
		global::UnityEngine.Object.Destroy(Mouse.Instance.theItemOnMouse);
		if (!this.fake)
		{
			if (GameAPP.theBoardType <= LevelType.StarAdvanture)
			{
				bool[] advLevelCompleted = GameAPP.advLevelCompleted;
				int theBoardLevel = GameAPP.theBoardLevel;
				int advantureLevel = GameAPP.advantureLevel;
				this.AdvantureSettings();
				bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
				int theBoardLevel2 = GameAPP.theBoardLevel;
				if (GameAPP.config.easyTravel)
				{
					LevelType theBoardType = GameAPP.theBoardType;
					int theBoardLevel3 = GameAPP.theBoardLevel;
					if (Lawnf.IsTravelLevel(theBoardType, theBoardLevel3))
					{
						goto IL_00FC;
					}
				}
				bool[] survivalLevelCompleted = GameAPP.survivalLevelCompleted;
				int theBoardLevel4 = GameAPP.theBoardLevel;
				HashSet<int> exploreLevelCompleted = GameAPP.exploreLevelCompleted;
				int theBoardLevel5 = GameAPP.theBoardLevel;
				bool flag = exploreLevelCompleted.Add(theBoardLevel5);
				HashSet<TravelAdvanture> travelLevelCompleted_runTime = GameAPP.config.travelLevelCompleted_runTime;
				int num = GameAPP.theBoardLevel;
				int newAdvArrivedLevel = GameAPP.newAdvArrivedLevel;
				num++;
				if (num <= newAdvArrivedLevel)
				{
					num = newAdvArrivedLevel;
				}
				GameAPP.newAdvArrivedLevel = num;
				int num2 = GameAPP.theBoardLevel;
				int towerLevel = GameAPP.towerLevel;
				num2++;
				if (num2 <= towerLevel)
				{
					num2 = towerLevel;
				}
				GameAPP.towerLevel = num2;
				AdvantureManager instance = AdvantureManager.Instance;
			}
			IL_00FC:
			HashSet<string> nameLevelCompleted = GameAPP.nameLevelCompleted;
			string theIZLevelName = GameAPP.theIZLevelName;
			bool flag2 = nameLevelCompleted.Add(theIZLevelName);
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			uint num4;
			ulong num5;
			base.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
		}
		this.isLand = true;
		GameAPP.music.Stop();
		GameAPP.prelude.audioSource.Stop();
		GameAPP.musicDrum.Stop();
		PrizeMgr.<MoveAndScaleObject>d__17 <MoveAndScaleObject>d__;
		<MoveAndScaleObject>d__.System.IDisposable.Dispose();
		<MoveAndScaleObject>d__.<>1__state = (int)((ulong)0L);
		<MoveAndScaleObject>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<MoveAndScaleObject>d__);
		Board instance2 = Board.Instance;
		TreasureData.LevelEnd();
		SaveInfo.Instance.SavePlayerData();
		Board.Instance.ClearTheBoard();
	}

	// Token: 0x06001C64 RID: 7268 RVA: 0x000979D8 File Offset: 0x00095BD8
	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x507960", Offset = "0x505F60", VA = "0x180507960")]
	private void AdvantureSettings()
	{
		int num;
		int num4;
		bool flag;
		int theBoardLevel;
		List<PlantType> list;
		bool flag2;
		do
		{
			num = 0;
			this.selectAdv = num != 0;
			int num2 = GameAPP.advantureZhouMu;
			num2++;
			GameAPP.advantureZhouMu = num2;
			int num3 = GameAPP.advantureLevel;
			num3++;
			GameAPP.advantureLevel = num3;
			num4 = 0;
			flag = "{il2cpp field on {'constant49' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x98}" <= (ulong)36L;
			theBoardLevel = GameAPP.theBoardLevel;
			GameAPP.randomPlantInZhouMu._size = num4;
			list = new List();
			HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
		}
		while ((flag2 && ((!flag && TypeMgr.IsWaterPlant((PlantType)num)) || (theBoardLevel > 36 && TypeMgr.IsCaltrop((PlantType)num)))) || num4 != 0);
		int num5 = 0;
		int num6 = list._size;
		int num7 = global::UnityEngine.Random.Range(0, num6);
		List<PlantType> randomPlantInZhouMu = GameAPP.randomPlantInZhouMu;
		num6 = num7;
		int num8 = list[num6];
		int size = randomPlantInZhouMu._size;
		num8 = num7;
		list.RemoveAt(num8);
		num5++;
	}

	// Token: 0x06001C65 RID: 7269 RVA: 0x00097AC8 File Offset: 0x00095CC8
	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x5088F0", Offset = "0x506EF0", VA = "0x1805088F0", Slot = "6")]
	public virtual void GoBack()
	{
		SaveInfo.Instance.SavePlayerData();
		Board.Instance.Die();
		if (!GameAPP.config.disableBoardStatistics)
		{
			GameAPP.UIManager.PopAll();
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Transform canvasUp = GameAPP.canvasUp;
			int num = 0;
			if (uimanager.Push((UIType)((uint)76), canvasUp, num != 0) != 0)
			{
			}
			DamageReporter damageReporter = Board.Instance.damageReporter;
			Action action = delegate
			{
				Board instance2 = Board.Instance;
				Board.BoardTag boardTag2 = instance2.boardTag;
				bool isScaredyDream2 = instance2.boardTag.isScaredyDream;
				bool isEndless2 = instance2.boardTag.isEndless;
				LevelType theBoardType2 = GameAPP.theBoardType;
				int theBoardLevel2 = GameAPP.theBoardLevel;
				bool isFreeCardSelect2 = instance2.boardTag.isFreeCardSelect;
				bool freeGloveZombie2 = instance2.boardTag.freeGloveZombie;
				bool plantingZombie2 = instance2.boardTag.plantingZombie;
				this.EnterNextMenu(theBoardType2, theBoardLevel2, boardTag2);
			};
			GameAPP.Instance.PlayMusic((MusicType)((uint)16));
			return;
		}
		Board instance = Board.Instance;
		Board.BoardTag boardTag = instance.boardTag;
		bool isScaredyDream = instance.boardTag.isScaredyDream;
		bool isEndless = instance.boardTag.isEndless;
		LevelType theBoardType = GameAPP.theBoardType;
		int theBoardLevel = GameAPP.theBoardLevel;
		bool isFreeCardSelect = instance.boardTag.isFreeCardSelect;
		bool freeGloveZombie = instance.boardTag.freeGloveZombie;
		bool plantingZombie = instance.boardTag.plantingZombie;
		this.EnterNextMenu(theBoardType, theBoardLevel, boardTag);
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x00097BC0 File Offset: 0x00095DC0
	[Token(Token = "0x6001C66")]
	[Address(RVA = "0x508770", Offset = "0x506D70", VA = "0x180508770")]
	private void EnterNextMenu(LevelType levelType, int levelNumber, Board.BoardTag boardTag)
	{
		if (typeof(GameAPP).TypeHandle == 0)
		{
			if (typeof(GameAPP).TypeHandle == 0)
			{
				if (levelType == LevelType.Advanture && (this.selectAdv ? LevelType.Challenge : LevelType.Advanture) == levelType)
				{
					int num = 0;
					int num2 = 0;
					int advantureLevel = GameAPP.advantureLevel;
					UIMgr.EnterGame((LevelType)num2, advantureLevel, -1, num);
				}
				if (levelType != LevelType.AbyssRealm)
				{
					UIMgr.BackToMenu();
				}
				UIMgr.EnterChallengeMenu();
				UIResourcesLoader uimanager = GameAPP.UIManager;
				int num3 = 0;
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)86), num3 != 0);
				UIMgr.EnterMainMenu();
				if (levelType != LevelType.TravelAdvanture)
				{
					return;
				}
				UIMgr.EnterTravelAdv();
			}
			UIMgr.EnterGarden();
		}
		UIMgr.EnterTreasureMenu();
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x00097C54 File Offset: 0x00095E54
	[Token(Token = "0x6001C67")]
	[Address(RVA = "0x508C70", Offset = "0x507270", VA = "0x180508C70")]
	protected IEnumerator MoveAndScaleObject()
	{
		PrizeMgr.<MoveAndScaleObject>d__17 <MoveAndScaleObject>d__;
		<MoveAndScaleObject>d__.System.IDisposable.Dispose();
		<MoveAndScaleObject>d__.<>1__state = (int)((ulong)0L);
		<MoveAndScaleObject>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x00097C78 File Offset: 0x00095E78
	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x508F00", Offset = "0x507500", VA = "0x180508F00")]
	private void RestartBoss2()
	{
		int num;
		do
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			Board.Instance.boss2 = true;
			CreateZombie instance = CreateZombie.Instance;
			num = 0;
			int num2 = 0;
			int num3 = 0;
			Zombie zombie = instance.SetZombie(num3, (ZombieType)((uint)46), (float)num2, num != 0);
			GameAPP.Instance.PlayMusic((MusicType)((uint)18));
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
		int num4 = 0;
		ConveyManager.Instance.cardCount = num4;
		int size = ConveyManager.Instance.cardsOnBelt._size;
		int num5 = size - 1;
		if (size > 0)
		{
			CardUI cardUI = ConveyManager.Instance.cardsOnBelt[num5];
			int num6 = 0;
			if (cardUI != num6)
			{
				ConveyManager.Instance.cardsOnBelt[num5].Die();
			}
			if (num5 > 0)
			{
			}
		}
		Board instance2 = Board.Instance;
		if (num4 < instance2.rowNum)
		{
			CreatePlant instance3 = CreatePlant.Instance;
			int num7 = 0;
			ulong num8;
			Plant plant = instance3.SetPlant(num4, num4, (PlantType)((uint)27), num4, num, num7 != 0, num8 != 0UL, num4);
			num4++;
		}
		num4++;
		Glove instance4 = Glove.Instance;
		int num9 = 0;
		if (instance4 != num9)
		{
			GameObject gameObject = Glove.Instance.gameObject;
			int num10 = 0;
			gameObject.SetActive(num10 != 0);
		}
		Hammer instance5 = Hammer.Instance;
		int num11 = 0;
		if (instance5 != num11)
		{
			GameObject gameObject2 = Hammer.Instance.gameObject;
			int num12 = 0;
			gameObject2.SetActive(num12 != 0);
		}
		Transform transform = Board.Instance.background.transform;
		int num13 = 0;
		Transform child = transform.GetChild(num13);
		int num14 = 0;
		GameObject gameObject3 = child.GetChild(num14).gameObject;
		int num15 = 0;
		gameObject3.SetActive(num15 != 0);
		Transform transform2 = Board.Instance.background.transform;
		int num16 = 0;
		transform2.GetChild(num16).GetChild(1).gameObject.SetActive(true);
		Board.Instance.over = false;
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x00097E68 File Offset: 0x00096068
	[Token(Token = "0x6001C69")]
	[Address(RVA = "0x508C00", Offset = "0x507200", VA = "0x180508C00")]
	protected IEnumerator LightOutT()
	{
		PrizeMgr.<LightOutT>d__19 <LightOutT>d__;
		<LightOutT>d__.System.IDisposable.Dispose();
		<LightOutT>d__.<>1__state = (int)((ulong)0L);
		<LightOutT>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001C6A RID: 7274 RVA: 0x00097E8C File Offset: 0x0009608C
	[Token(Token = "0x6001C6A")]
	[Address(RVA = "0x5099A0", Offset = "0x507FA0", VA = "0x1805099A0")]
	public PrizeMgr()
	{
	}

	// Token: 0x04000F15 RID: 3861
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F15")]
	protected readonly float horizontalSpeed = 1.5f;

	// Token: 0x04000F16 RID: 3862
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000F16")]
	protected readonly float verticalSpeed = 4f;

	// Token: 0x04000F17 RID: 3863
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F17")]
	protected readonly float gravity = 9.8f;

	// Token: 0x04000F18 RID: 3864
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000F18")]
	protected Vector2 velocity;

	// Token: 0x04000F19 RID: 3865
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000F19")]
	protected Vector2 startPosition;

	// Token: 0x04000F1A RID: 3866
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000F1A")]
	protected bool isLand;

	// Token: 0x04000F1B RID: 3867
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4000F1B")]
	protected bool isClicked;

	// Token: 0x04000F1C RID: 3868
	[FieldOffset(Offset = "0x3E")]
	[Token(Token = "0x4000F1C")]
	protected bool selectAdv = true;

	// Token: 0x04000F1D RID: 3869
	[FieldOffset(Offset = "0x3F")]
	[Token(Token = "0x4000F1D")]
	public bool fake;
}
