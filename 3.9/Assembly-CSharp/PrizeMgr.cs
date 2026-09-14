using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000618 RID: 1560
[Token(Token = "0x2000618")]
public class PrizeMgr : MonoBehaviour
{
	// Token: 0x06001D5E RID: 7518 RVA: 0x0009C12C File Offset: 0x0009A32C
	[Token(Token = "0x6001D5E")]
	[Address(RVA = "0x574C90", Offset = "0x573290", VA = "0x180574C90")]
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

	// Token: 0x06001D5F RID: 7519 RVA: 0x0009C1FC File Offset: 0x0009A3FC
	[Token(Token = "0x6001D5F")]
	[Address(RVA = "0x574FE0", Offset = "0x5735E0", VA = "0x180574FE0", Slot = "4")]
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

	// Token: 0x06001D60 RID: 7520 RVA: 0x0009C250 File Offset: 0x0009A450
	[Token(Token = "0x6001D60")]
	[Address(RVA = "0x574410", Offset = "0x572A10", VA = "0x180574410")]
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

	// Token: 0x06001D61 RID: 7521 RVA: 0x0009C308 File Offset: 0x0009A508
	[Token(Token = "0x6001D61")]
	[Address(RVA = "0x573530", Offset = "0x571B30", VA = "0x180573530", Slot = "5")]
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

	// Token: 0x06001D62 RID: 7522 RVA: 0x0009C37C File Offset: 0x0009A57C
	[Token(Token = "0x6001D62")]
	[Address(RVA = "0x5737B0", Offset = "0x571DB0", VA = "0x1805737B0")]
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

	// Token: 0x06001D63 RID: 7523 RVA: 0x0009C540 File Offset: 0x0009A740
	[Token(Token = "0x6001D63")]
	[Address(RVA = "0x573090", Offset = "0x571690", VA = "0x180573090")]
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

	// Token: 0x06001D64 RID: 7524 RVA: 0x0009C630 File Offset: 0x0009A830
	[Token(Token = "0x6001D64")]
	[Address(RVA = "0x574020", Offset = "0x572620", VA = "0x180574020", Slot = "6")]
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

	// Token: 0x06001D65 RID: 7525 RVA: 0x0009C728 File Offset: 0x0009A928
	[Token(Token = "0x6001D65")]
	[Address(RVA = "0x573EA0", Offset = "0x5724A0", VA = "0x180573EA0")]
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

	// Token: 0x06001D66 RID: 7526 RVA: 0x0009C7BC File Offset: 0x0009A9BC
	[Token(Token = "0x6001D66")]
	[Address(RVA = "0x5743A0", Offset = "0x5729A0", VA = "0x1805743A0")]
	protected IEnumerator MoveAndScaleObject()
	{
		PrizeMgr.<MoveAndScaleObject>d__17 <MoveAndScaleObject>d__;
		<MoveAndScaleObject>d__.System.IDisposable.Dispose();
		<MoveAndScaleObject>d__.<>1__state = (int)((ulong)0L);
		<MoveAndScaleObject>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x0009C7E0 File Offset: 0x0009A9E0
	[Token(Token = "0x6001D67")]
	[Address(RVA = "0x574630", Offset = "0x572C30", VA = "0x180574630")]
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

	// Token: 0x06001D68 RID: 7528 RVA: 0x0009C9D0 File Offset: 0x0009ABD0
	[Token(Token = "0x6001D68")]
	[Address(RVA = "0x574330", Offset = "0x572930", VA = "0x180574330")]
	protected IEnumerator LightOutT()
	{
		PrizeMgr.<LightOutT>d__19 <LightOutT>d__;
		<LightOutT>d__.System.IDisposable.Dispose();
		<LightOutT>d__.<>1__state = (int)((ulong)0L);
		<LightOutT>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x0009C9F4 File Offset: 0x0009ABF4
	[Token(Token = "0x6001D69")]
	[Address(RVA = "0x5750D0", Offset = "0x5736D0", VA = "0x1805750D0")]
	public PrizeMgr()
	{
	}

	// Token: 0x04000FDD RID: 4061
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FDD")]
	protected readonly float horizontalSpeed = 1.5f;

	// Token: 0x04000FDE RID: 4062
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000FDE")]
	protected readonly float verticalSpeed = 4f;

	// Token: 0x04000FDF RID: 4063
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FDF")]
	protected readonly float gravity = 9.8f;

	// Token: 0x04000FE0 RID: 4064
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000FE0")]
	protected Vector2 velocity;

	// Token: 0x04000FE1 RID: 4065
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000FE1")]
	protected Vector2 startPosition;

	// Token: 0x04000FE2 RID: 4066
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000FE2")]
	protected bool isLand;

	// Token: 0x04000FE3 RID: 4067
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4000FE3")]
	protected bool isClicked;

	// Token: 0x04000FE4 RID: 4068
	[FieldOffset(Offset = "0x3E")]
	[Token(Token = "0x4000FE4")]
	protected bool selectAdv = true;

	// Token: 0x04000FE5 RID: 4069
	[FieldOffset(Offset = "0x3F")]
	[Token(Token = "0x4000FE5")]
	public bool fake;
}
