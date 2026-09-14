using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x020000E3 RID: 227
[Token(Token = "0x20000E3")]
public class PlayerShootingManager : MonoBehaviour
{
	// Token: 0x06000453 RID: 1107 RVA: 0x00015B40 File Offset: 0x00013D40
	[Token(Token = "0x6000453")]
	[Address(RVA = "0x504D00", Offset = "0x503300", VA = "0x180504D00")]
	public PlayerShootingMenu ShowBuff(bool first = false)
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)39), canvasUp, num != 0);
		Time.timeScale = (float)0;
		throw new NullReferenceException();
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00015B78 File Offset: 0x00013D78
	[Token(Token = "0x6000454")]
	[Address(RVA = "0x503DE0", Offset = "0x5023E0", VA = "0x180503DE0")]
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

	// Token: 0x06000455 RID: 1109 RVA: 0x00015C34 File Offset: 0x00013E34
	[Token(Token = "0x6000455")]
	[Address(RVA = "0x503D80", Offset = "0x502380", VA = "0x180503D80")]
	private void Awake()
	{
		PlayerShootingManager.Instance = this;
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00015C48 File Offset: 0x00013E48
	[Token(Token = "0x6000456")]
	[Address(RVA = "0x504E00", Offset = "0x503400", VA = "0x180504E00")]
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

	// Token: 0x06000457 RID: 1111 RVA: 0x00015CD8 File Offset: 0x00013ED8
	[Token(Token = "0x6000457")]
	[Address(RVA = "0x504FD0", Offset = "0x5035D0", VA = "0x180504FD0")]
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
			}
		}
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00015DF4 File Offset: 0x00013FF4
	[Token(Token = "0x6000458")]
	[Address(RVA = "0x504310", Offset = "0x502910", VA = "0x180504310")]
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
		int num6 = 0;
		uint num7;
		num6 += (int)num7;
		num6 += (int)num7;
		num6 += (int)num7;
		num6 += (int)num7;
		num7 += (uint)num6;
		return ZombieType.NormalZombie;
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00015F2C File Offset: 0x0001412C
	[Token(Token = "0x6000459")]
	[Address(RVA = "0x504050", Offset = "0x502650", VA = "0x180504050")]
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

	// Token: 0x0600045A RID: 1114 RVA: 0x00015F70 File Offset: 0x00014170
	[Token(Token = "0x600045A")]
	[Address(RVA = "0x504BB0", Offset = "0x5031B0", VA = "0x180504BB0")]
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

	// Token: 0x0600045B RID: 1115 RVA: 0x00015FC8 File Offset: 0x000141C8
	[Token(Token = "0x600045B")]
	[Address(RVA = "0x504260", Offset = "0x502860", VA = "0x180504260")]
	public string GetDescription(PlayerWeaponBuff playerBuff)
	{
		Dictionary<PlayerWeaponBuff, string> buffData = PlayerShootingData.BuffData;
		return "";
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00015FE8 File Offset: 0x000141E8
	[Token(Token = "0x600045C")]
	[Address(RVA = "0x5054A0", Offset = "0x503AA0", VA = "0x1805054A0")]
	public PlayerShootingManager()
	{
		List<Present> list = new List();
		this.presents = list;
		base..ctor();
	}

	// Token: 0x04000262 RID: 610
	[Token(Token = "0x4000262")]
	public static PlayerShootingManager Instance;

	// Token: 0x04000263 RID: 611
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000263")]
	public Board board;

	// Token: 0x04000264 RID: 612
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000264")]
	public Player player;

	// Token: 0x04000265 RID: 613
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000265")]
	public int moneyProduction;

	// Token: 0x04000266 RID: 614
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000266")]
	private bool first;

	// Token: 0x04000267 RID: 615
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000267")]
	private int lastWave;

	// Token: 0x04000268 RID: 616
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000268")]
	private int moneyWave;

	// Token: 0x04000269 RID: 617
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000269")]
	public List<Present> presents;
}
