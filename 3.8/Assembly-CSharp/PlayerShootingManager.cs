using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x020000DE RID: 222
[Token(Token = "0x20000DE")]
public class PlayerShootingManager : MonoBehaviour
{
	// Token: 0x06000438 RID: 1080 RVA: 0x000156A8 File Offset: 0x000138A8
	[Token(Token = "0x6000438")]
	[Address(RVA = "0x4C4F00", Offset = "0x4C3500", VA = "0x1804C4F00")]
	public PlayerShootingMenu ShowBuff(bool first = false)
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)39), canvasUp, num != 0);
		Time.timeScale = (float)0;
		throw new NullReferenceException();
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x000156E0 File Offset: 0x000138E0
	[Token(Token = "0x6000439")]
	[Address(RVA = "0x4C4000", Offset = "0x4C2600", VA = "0x1804C4000")]
	public void Evolution(bool zombie = true)
	{
		if (zombie)
		{
			BoardConfig config = this.board.config;
			float zombieHealthMultiplier = config.zombieHealthMultiplier;
			config.zombieHealthMultiplier = zombieHealthMultiplier;
		}
		List<PlayerWeapon> list = new List(this.player.playerWeapons);
		int num = list._size;
		int num2 = global::UnityEngine.Random.Range(0, num);
		num = num2;
		PlayerWeapon playerWeapon = list[num];
		num = num2;
		list.RemoveAt(num);
		while (playerWeapon.evolution != 0)
		{
		}
		playerWeapon.OnEvoluted();
		Dictionary<PlayerWeaponType, string> evolutionDescription = PlayerShootingData.EvolutionDescription;
		bool flag;
		if (flag)
		{
			InGameText instance = InGameText.Instance;
		}
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x000157B0 File Offset: 0x000139B0
	[Token(Token = "0x600043A")]
	[Address(RVA = "0x4C3FA0", Offset = "0x4C25A0", VA = "0x1804C3FA0")]
	private void Awake()
	{
		PlayerShootingManager.Instance = this;
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x000157C4 File Offset: 0x000139C4
	[Token(Token = "0x600043B")]
	[Address(RVA = "0x4C5000", Offset = "0x4C3600", VA = "0x1804C5000")]
	private void Start()
	{
		GameObject gameObject = Resources.Load<GameObject>("PlayerPrefabs/Player");
		Transform transform = this.board.transform;
		Player component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<Player>();
		Transform transform2 = component.transform;
		Board board = this.board;
		component.board = board;
		this.player = component;
		Board board2 = this.board;
		board2.theMoney = (int)((ulong)0L);
		Camera.main.orthographicSize = 6f;
		InGameUI.Instance.MoneyBank.SetActive(true);
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00015854 File Offset: 0x00013A54
	[Token(Token = "0x600043C")]
	[Address(RVA = "0x4C51D0", Offset = "0x4C37D0", VA = "0x1804C51D0")]
	private void Update()
	{
		int num = 0;
		if ((this.first ? 1 : 0) == num)
		{
			this.first = true;
			UIResourcesLoader uimanager = GameAPP.UIManager;
			Time.timeScale = (float)0;
		}
		int theWave = this.board.theWave;
		if (this.moneyWave != theWave)
		{
			int theWave2 = this.board.theWave;
			this.moneyWave = theWave2;
		}
		int theWave3 = this.board.theWave;
		ulong num2;
		num2 += num2;
		if ((ulong)theWave3 == num2)
		{
			Board board = this.board;
			int theWave4 = board.theWave;
			if (this.lastWave != theWave4)
			{
				this.lastWave = theWave4;
				Vector2Int randomBox = global::Lawnf.GetRandomBox(board);
				uint num3;
				if (num3 > (uint)0)
				{
					Vector2Int randomBox2 = global::Lawnf.GetRandomBox(this.board);
				}
				CreatePlant instance = CreatePlant.Instance;
				Plant plant;
				Present component = plant.GetComponent<Present>();
				Collider2D[] components = component.GetComponents<Collider2D>();
				if (num < components.Length)
				{
					num++;
				}
				List<Present> list = this.presents;
				int size = list._size;
				Collider2D collider2D = components[20];
				list._size = components;
				component.buff = true;
				InGameText instance2 = InGameText.Instance;
				int num4 = 0;
				instance2.ShowText("随机道具箱已刷新", 5f, num4 != 0);
			}
		}
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x00015988 File Offset: 0x00013B88
	[Token(Token = "0x600043D")]
	[Address(RVA = "0x4C4510", Offset = "0x4C2B10", VA = "0x1804C4510")]
	public static ZombieType GetZombieType(int wave, ZombieType theZombieType)
	{
		if (theZombieType <= ZombieType.JacksonZombie)
		{
		}
		uint num;
		if (num > (uint)10 || num > (uint)10 || num > (uint)10 || num <= (uint)10)
		{
		}
		if (num != (uint)16)
		{
			if (num == (uint)35)
			{
				goto IL_003D;
			}
			if (num <= (uint)10)
			{
			}
			if (num == (uint)16)
			{
			}
		}
		while (num != (uint)35)
		{
		}
		IL_003D:
		if (num <= (uint)10)
		{
		}
		uint num2;
		if (num != (uint)16)
		{
			if (num2 > (uint)10 || num2 > (uint)10 || num2 <= (uint)10)
			{
			}
			while (num2 != (uint)16)
			{
			}
		}
		if (num2 <= (uint)10)
		{
		}
		while (num2 != (uint)16)
		{
		}
		while (num2 > (uint)10)
		{
		}
		if (num2 <= (uint)10)
		{
		}
		if (num2 == (uint)16)
		{
			if (num2 > (uint)10 || num2 <= (uint)10)
			{
			}
			if (num2 == (uint)16)
			{
				if (num2 > (uint)10 || num2 <= (uint)10)
				{
				}
				if (num2 == (uint)16)
				{
					if (num2 <= (uint)10)
					{
					}
					while (num2 == (uint)16)
					{
					}
				}
			}
		}
		uint num3;
		while (num3 > (uint)10)
		{
		}
		while (num3 > (uint)10)
		{
		}
		if (num3 <= (uint)10)
		{
		}
		if (num3 != (uint)16)
		{
		}
		uint num4;
		if (num4 <= (uint)10)
		{
		}
		if (num4 != (uint)16)
		{
		}
		uint num5;
		if (num5 <= (uint)10)
		{
		}
		if (num5 == (uint)16)
		{
		}
		return ZombieType.NormalZombie;
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x00015A9C File Offset: 0x00013C9C
	[Token(Token = "0x600043E")]
	[Address(RVA = "0x4C4250", Offset = "0x4C2850", VA = "0x1804C4250")]
	public void GetBuff(PlayerWeaponBuff playerBuff, PlayerWeaponType playerWeaponType)
	{
		if (playerBuff != PlayerWeaponBuff.GetNewWeapon)
		{
			Dictionary<PlayerWeaponBuff, ValueTuple<PlayerWeaponType, Action<PlayerWeapon>>> buffActions = PlayerShootingData.buffActions;
			bool flag;
			if (flag)
			{
				Player player = this.player;
				bool flag2;
				if (flag2)
				{
					bool flag3;
					if (!flag3)
					{
						return;
					}
					int num2;
					int num = num2 + 1;
					return;
				}
			}
		}
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x00015AE0 File Offset: 0x00013CE0
	[Token(Token = "0x600043F")]
	[Address(RVA = "0x4C4DB0", Offset = "0x4C33B0", VA = "0x1804C4DB0")]
	private void InitPlayer()
	{
		GameObject gameObject = Resources.Load<GameObject>("PlayerPrefabs/Player");
		Transform transform = this.board.transform;
		Player component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<Player>();
		Transform transform2 = component.transform;
		Board board = this.board;
		component.board = board;
		this.player = component;
		throw new NullReferenceException();
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00015B38 File Offset: 0x00013D38
	[Token(Token = "0x6000440")]
	[Address(RVA = "0x4C4460", Offset = "0x4C2A60", VA = "0x1804C4460")]
	public string GetDescription(PlayerWeaponBuff playerBuff)
	{
		Dictionary<PlayerWeaponBuff, string> buffData = PlayerShootingData.BuffData;
		return "";
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00015B58 File Offset: 0x00013D58
	[Token(Token = "0x6000441")]
	[Address(RVA = "0x4C5690", Offset = "0x4C3C90", VA = "0x1804C5690")]
	public PlayerShootingManager()
	{
		List<Present> list = new List();
		this.presents = list;
		base..ctor();
	}

	// Token: 0x04000254 RID: 596
	[Token(Token = "0x4000254")]
	public static PlayerShootingManager Instance;

	// Token: 0x04000255 RID: 597
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000255")]
	public Board board;

	// Token: 0x04000256 RID: 598
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000256")]
	public Player player;

	// Token: 0x04000257 RID: 599
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000257")]
	public int moneyProduction;

	// Token: 0x04000258 RID: 600
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000258")]
	private bool first;

	// Token: 0x04000259 RID: 601
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000259")]
	private int lastWave;

	// Token: 0x0400025A RID: 602
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400025A")]
	private int moneyWave;

	// Token: 0x0400025B RID: 603
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400025B")]
	public List<Present> presents;
}
