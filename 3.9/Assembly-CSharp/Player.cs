using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020007CD RID: 1997
[Token(Token = "0x20007CD")]
public class Player : Entity
{
	// Token: 0x170001DB RID: 475
	// (get) Token: 0x06002894 RID: 10388 RVA: 0x000DA9CC File Offset: 0x000D8BCC
	[Token(Token = "0x170001DB")]
	public int Row
	{
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x66B760", Offset = "0x669D60", VA = "0x18066B760")]
		get
		{
			Mouse instance = Mouse.Instance;
			Transform axis = this.axis;
			Transform axis2 = this.axis;
			int num;
			return num;
		}
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x06002895 RID: 10389 RVA: 0x000DA9F8 File Offset: 0x000D8BF8
	[Token(Token = "0x170001DC")]
	public int Column
	{
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x66B6E0", Offset = "0x669CE0", VA = "0x18066B6E0")]
		get
		{
			Mouse instance = Mouse.Instance;
			Transform axis = this.axis;
			int num;
			return num;
		}
	}

	// Token: 0x06002896 RID: 10390 RVA: 0x000DAA1C File Offset: 0x000D8C1C
	[Token(Token = "0x6002896")]
	[Address(RVA = "0x66AB10", Offset = "0x669110", VA = "0x18066AB10")]
	private void Start()
	{
		SortingGroup component = base.GetComponent<SortingGroup>();
		this.sortingGroup = component;
		FlashEffect flashEffect = new FlashEffect(this.spriteRenderers);
		this.flash = flashEffect;
		Transform transform = Camera.main.transform;
		this.mainCamera = transform;
		int num = 0;
		this.moreDamagePerColumn = (float)num;
		this.strikeDamage = 0.5f;
	}

	// Token: 0x06002897 RID: 10391 RVA: 0x000DAA7C File Offset: 0x000D8C7C
	[Token(Token = "0x6002897")]
	[Address(RVA = "0x66B4C0", Offset = "0x669AC0", VA = "0x18066B4C0")]
	public void Upgrade()
	{
		InGameText instance = InGameText.Instance;
		float num = this.basicDamage;
		this.basicDamage = num;
	}

	// Token: 0x06002898 RID: 10392 RVA: 0x000DAAA8 File Offset: 0x000D8CA8
	[Token(Token = "0x6002898")]
	[Address(RVA = "0x66AF00", Offset = "0x669500", VA = "0x18066AF00")]
	public bool TryGetWeapon(PlayerWeaponType playerWeaponType, [Out] PlayerWeapon playerWeapon)
	{
		List<PlayerWeapon> list = this.playerWeapons;
		Func<PlayerWeapon, bool> func = delegate(PlayerWeapon weapon)
		{
			PlayerWeaponType playerWeaponType2 = playerWeaponType;
			return weapon.theWeaponType == playerWeaponType2;
		};
		PlayerWeapon playerWeapon2 = Enumerable.FirstOrDefault<PlayerWeapon>(list, func);
		bool flag;
		return flag;
	}

	// Token: 0x06002899 RID: 10393 RVA: 0x000DAAEC File Offset: 0x000D8CEC
	[Token(Token = "0x6002899")]
	[Address(RVA = "0x668FB0", Offset = "0x6675B0", VA = "0x180668FB0")]
	private void FixedUpdate()
	{
		IEffect effect = this.flash;
		int num = this.maxHealth;
		if (this.currentHealth < num)
		{
			int num2 = 0;
			int num3 = this.level;
			float fixedDeltaTime = Time.fixedDeltaTime;
			int num4 = this.currentHealth;
			SpriteSlider spriteSlider = this.healthSlider;
			num4 += num2;
			this.currentHealth = num4;
		}
	}

	// Token: 0x0600289A RID: 10394 RVA: 0x000DAB48 File Offset: 0x000D8D48
	[Token(Token = "0x600289A")]
	[Address(RVA = "0x66B020", Offset = "0x669620", VA = "0x18066B020")]
	private void Update()
	{
		int num;
		do
		{
			List<PlayerWeapon> list = this.playerWeapons;
			num = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
		int num2 = 0;
		Vector3 vector;
		int rowFromY = global::Lawnf.GetRowFromY(vector.y);
		string text = string.Format("bullet{0}", rowFromY);
		float deltaTime = Time.deltaTime;
		int num3 = 0;
		int num4;
		if (num4 > 0)
		{
			CreateZombie instance = CreateZombie.Instance;
			float num5 = global::UnityEngine.Random.Range(-1f, 1f);
			ulong num6;
			Zombie component = instance.SetZombieWithMindControl(num2, (ZombieType)((uint)100), num5, num6 != 0UL).GetComponent<Zombie>();
			float theOriginSpeed = component.theOriginSpeed;
			component.theOriginSpeed = theOriginSpeed;
			num2++;
			num2++;
		}
		if (deltaTime > (float)num3)
		{
			float deltaTime2 = Time.deltaTime;
		}
	}

	// Token: 0x0600289B RID: 10395 RVA: 0x000DAC10 File Offset: 0x000D8E10
	[Token(Token = "0x600289B")]
	[Address(RVA = "0x668980", Offset = "0x666F80", VA = "0x180668980")]
	private void CheckPresent()
	{
		int num;
		int num2;
		List<PlayerBuff> list;
		do
		{
			num = 0;
			num2 = 0;
			int size = PlayerShootingManager.Instance.presents._size;
			if (size <= 0)
			{
				return;
			}
			Present present = PlayerShootingManager.Instance.presents[size];
			int num3 = 0;
			if (!(present != num3))
			{
				PlayerShootingManager.Instance.presents.RemoveAt(size);
			}
			Transform axis = present.axis;
			Vector3 vector;
			float z = vector.z;
			Transform axis2 = this.axis;
			Vector3 vector2;
			float z2 = vector2.z;
			int num4 = 0;
			present.Die((Plant.DieReason)num4);
			PlayerShootingManager.Instance.presents.RemoveAt(size);
			list = new List();
			Array values = Enum.GetValues(typeof(PlayerBuff));
			if (values != 0 && values == 0)
			{
				goto IL_0118;
			}
			List<PlayerBuff> list2 = Enumerable.ToList<PlayerBuff>(values);
			bool flag;
			if (!flag)
			{
				goto IL_00D2;
			}
		}
		while (!PlayerShootingData.PlayerDescription.TryGetValue(num2, num));
		int buffCount = this.GetBuffCount((PlayerBuff)num2);
		IL_00D2:
		ulong num5;
		if (num5 != (ulong)0L)
		{
			goto IL_0118;
		}
		int num6 = list._size;
		num6 = buffCount;
		PlayerBuff playerBuff = list[num6];
		GameAPP.PlaySound(125, 0.5f, 1f);
		return;
		IL_0118:
		throw new InvalidCastException();
	}

	// Token: 0x0600289C RID: 10396 RVA: 0x000DAD3C File Offset: 0x000D8F3C
	[Token(Token = "0x600289C")]
	[Address(RVA = "0x66AC00", Offset = "0x669200", VA = "0x18066AC00")]
	private void SummonZombieUpdate()
	{
		float num = this.timer_summonZombie;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer_summonZombie = num;
		if (num2 > (int)num)
		{
			int num3 = 0;
			this.timer_summonZombie = 10f;
			if (this.GetBuffCount((PlayerBuff)((uint)1)) > 0)
			{
				Board board = this.board;
				if (num3 < board.rowNum)
				{
					Transform axis = this.axis;
					CreateZombie instance = CreateZombie.Instance;
					float num4 = global::UnityEngine.Random.Range(-1f, 1f);
					ulong num5;
					Zombie component = instance.SetZombieWithMindControl(num3, (ZombieType)((uint)100), num4, num5 != 0UL).GetComponent<Zombie>();
					float theOriginSpeed = component.theOriginSpeed;
					num3++;
					component.theOriginSpeed = theOriginSpeed;
				}
				num3++;
				int buffCount = this.GetBuffCount((PlayerBuff)((uint)1));
			}
		}
	}

	// Token: 0x0600289D RID: 10397 RVA: 0x000DADFC File Offset: 0x000D8FFC
	[Token(Token = "0x600289D")]
	[Address(RVA = "0x66A060", Offset = "0x668660", VA = "0x18066A060")]
	private void MoveUpdate()
	{
		this.moving = false;
		if (global::Lawnf.GetKey((KeyCode)((uint)119)))
		{
			Transform transform = base.transform;
			int num = 0;
			Vector3 vector;
			float num2 = vector.y;
			if (global::Lawnf.GetBoxYFromRow(num, 5) > num2)
			{
				Transform transform2 = base.transform;
				num2 = Time.deltaTime;
				this.moving = true;
				this.towards = (Towards)((ulong)2L);
			}
		}
		if (global::Lawnf.GetKey((KeyCode)((uint)97)))
		{
			Transform transform3 = base.transform;
			float boxXFromColumn = global::Lawnf.GetBoxXFromColumn(0);
			Transform transform4 = base.transform;
			float deltaTime = Time.deltaTime;
			this.moving = true;
			this.towards = (Towards)((ulong)0L);
		}
		if (global::Lawnf.GetKey((KeyCode)((uint)115)))
		{
			Transform transform5 = base.transform;
			Board board = this.board;
			Vector3 vector2;
			float num3 = vector2.y;
			float boxYFromRow = global::Lawnf.GetBoxYFromRow(board.rowNum, 5);
			if (num3 > boxYFromRow)
			{
				Transform transform6 = base.transform;
				num3 = Time.deltaTime;
				this.moving = true;
				this.towards = (Towards)((ulong)3L);
			}
		}
		if (global::Lawnf.GetKey((KeyCode)((uint)100)))
		{
			Transform transform7 = base.transform;
			float boxXFromColumn2 = global::Lawnf.GetBoxXFromColumn(this.board.columnNum);
			Transform transform8 = base.transform;
			float deltaTime2 = Time.deltaTime;
			this.moving = true;
			this.towards = (Towards)((ulong)1L);
		}
		if (Input.GetKeyUpInt((KeyCode)((uint)32)))
		{
			bool flag = !this.cameraFollow;
			this.cameraFollow = flag;
		}
		if (this.cameraFollow)
		{
			Transform transform9 = this.mainCamera;
			Transform transform10 = base.transform;
			float deltaTime3 = Time.deltaTime;
			if (0 > (int)deltaTime3 || deltaTime3 > 1f)
			{
			}
			Transform transform11 = this.mainCamera.transform;
		}
		Camera.main.orthographicSize = 10f;
		Camera main = Camera.main;
		int num4 = 0;
		main.transform.position = num4;
		Transform axis = this.axis;
		Mouse instance = Mouse.Instance;
		this.moreDamageByColumn = 10f;
	}

	// Token: 0x0600289E RID: 10398 RVA: 0x000DAFE0 File Offset: 0x000D91E0
	[Token(Token = "0x600289E")]
	[Address(RVA = "0x668850", Offset = "0x666E50", VA = "0x180668850")]
	private void CameraUpdate()
	{
		Transform transform = this.mainCamera;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		float deltaTime = Time.deltaTime;
		if (0 > (int)deltaTime || deltaTime > 1f)
		{
		}
		Transform transform3 = this.mainCamera.transform;
	}

	// Token: 0x0600289F RID: 10399 RVA: 0x000DB030 File Offset: 0x000D9230
	[Token(Token = "0x600289F")]
	[Address(RVA = "0x66A790", Offset = "0x668D90", VA = "0x18066A790")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Zombie>(num))
		{
			int row = this.Row;
			if (num == row && global::Lawnf.InLandStatus((ZombieStatus)num))
			{
				float num2 = this.timer_invisiable;
				int num3 = 0;
				if (num2 > (float)num3)
				{
					return;
				}
				int num4 = 0;
				float num5 = (float)(num3 * (int)this.defence);
				if (num4 > (int)num5)
				{
					UIMgr.EnterLoseMenu("你被僵尸撞死了");
					return;
				}
			}
		}
	}

	// Token: 0x060028A0 RID: 10400 RVA: 0x000DB090 File Offset: 0x000D9290
	[Token(Token = "0x60028A0")]
	[Address(RVA = "0x669100", Offset = "0x667700", VA = "0x180669100")]
	private void GetBuff(PlayerBuff playerBuff)
	{
		Quaternion identityQuaternion;
		CardUI cardUI;
		do
		{
			int num = 0;
			Dictionary<PlayerBuff, ValueTuple<string, int>> playerDescription = PlayerShootingData.PlayerDescription;
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			Dictionary<PlayerBuff, int> buffCountDic = this.BuffCountDic;
			Dictionary<PlayerBuff, int> buffCountDic2 = this.BuffCountDic;
			bool flag;
			if (!flag)
			{
			}
			if (playerBuff > PlayerBuff.WeaponUpgrade4)
			{
				return;
			}
			float num3 = this.defence;
			this.defence = num3;
			InGameText instance2 = InGameText.Instance;
			float num4 = this.basicDamage;
			this.basicDamage = num4;
			Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(GameAPP.itemPrefab[47]).transform;
			Transform transform2 = this.board.transform;
			transform.parentInternal = transform2;
			List<Plant> list = new List();
			Player.<>c__DisplayClass40_0 CS$<>8__locals1;
			CS$<>8__locals1.plants = list;
			Board board = this.board;
			if (num2 < board.rowNum)
			{
				CreatePlant instance3 = CreatePlant.Instance;
				Plant plant;
				long num5;
				plant.attackDamage = (int)num5;
				int size = CS$<>8__locals1.plants._size;
				plant.<Team>k__BackingField = plant;
				num2++;
				Board board2 = this.board;
			}
			DelayAction delayAction = GameAPP.delayAction;
			Action action = delegate
			{
				ulong num18;
				do
				{
					int num16 = 0;
					List<Plant> list2 = new List(CS$<>8__locals1.plants);
					bool flag4;
					if (flag4)
					{
						int num17 = 0;
						if (!(num16 != num17))
						{
							continue;
						}
					}
				}
				while (num18 != (ulong)0L);
			};
			delayAction.SetAction(action, 3f);
			Solar instance4 = Solar.Instance;
			int num6 = 0;
			if (instance4 == num6)
			{
				GameObject gameObject = GameAPP.itemPrefab[46];
				identityQuaternion = Quaternion.identityQuaternion;
			}
			Solar instance5 = Solar.Instance;
			instance5.SetDamage();
			bool flag2;
			if (flag2)
			{
				int num7 = 0;
				if (!(num != num7))
				{
					continue;
				}
			}
			if (num2 != 0)
			{
				goto IL_0272;
			}
			PlayerShootingManager instance6 = PlayerShootingManager.Instance;
			List<CardUI> cards = InGameUI.Instance.Cards;
			Func<CardUI, bool> func;
			if (Player.<>c.<>9__40_0 == 0)
			{
				func = delegate(CardUI c)
				{
					bool flag5;
					return c != 0 && flag5;
				};
				Player.<>c.<>9__40_0 = func;
			}
			cardUI = Enumerable.FirstOrDefault<CardUI>(cards, func);
			if (cardUI != 0)
			{
			}
			cardUI.theSeedCost = cardUI;
			float num8 = identityQuaternion * 0.1f;
			PlayerShootingManager instance7 = PlayerShootingManager.Instance;
			int num9 = 0;
			instance7.Evolution(num9 != 0);
			bool flag3;
			if (flag3)
			{
				int num10 = 0;
				if (!(num != num10))
				{
					continue;
				}
			}
		}
		while (cardUI != 0);
		PlayerShootingManager instance8 = PlayerShootingManager.Instance;
		PlayerWeapon playerWeapon;
		int num11 = playerWeapon.damage;
		float num12 = identityQuaternion * -0.1f;
		PlayerWeapon playerWeapon2;
		num11 -= playerWeapon2;
		playerWeapon.damage = num11;
		PlayerWeapon playerWeapon3;
		int damage = playerWeapon3.damage;
		float num13 = num12 * 0.2f;
		PlayerWeapon playerWeapon4;
		playerWeapon4 += damage;
		playerWeapon3.damage = playerWeapon4;
		PlayerWeapon playerWeapon5;
		int num14 = playerWeapon5.damage;
		float num15 = num13 * -0.3f;
		PlayerWeapon playerWeapon6;
		num14 -= playerWeapon6;
		playerWeapon5.damage = num14;
		return;
		IL_0272:
		throw new NullReferenceException();
	}

	// Token: 0x060028A1 RID: 10401 RVA: 0x000DB318 File Offset: 0x000D9518
	[Token(Token = "0x60028A1")]
	[Address(RVA = "0x669070", Offset = "0x667670", VA = "0x180669070")]
	public int GetBuffCount(PlayerBuff playerBuff)
	{
		Dictionary<PlayerBuff, int> buffCountDic = this.BuffCountDic;
		bool flag;
		if (!flag)
		{
			return 0;
		}
		Dictionary<PlayerBuff, int> buffCountDic2 = this.BuffCountDic;
		int num;
		return num;
	}

	// Token: 0x060028A2 RID: 10402 RVA: 0x000DB344 File Offset: 0x000D9544
	[Token(Token = "0x60028A2")]
	[Address(RVA = "0x668F70", Offset = "0x667570", VA = "0x180668F70")]
	private void Die()
	{
		UIMgr.EnterLoseMenu("你被僵尸撞死了");
	}

	// Token: 0x060028A3 RID: 10403 RVA: 0x000DB35C File Offset: 0x000D955C
	[Token(Token = "0x60028A3")]
	[Address(RVA = "0x66AE70", Offset = "0x669470", VA = "0x18066AE70", Slot = "12")]
	public override void TakeDamage(int value, IDamageMaker damageFrom, DamageType DamageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		IEffect effect = this.flash;
		SpriteSlider spriteSlider = this.healthSlider;
	}

	// Token: 0x060028A4 RID: 10404 RVA: 0x000DB380 File Offset: 0x000D9580
	[Token(Token = "0x60028A4")]
	[Address(RVA = "0x66AAC0", Offset = "0x6690C0", VA = "0x18066AAC0")]
	private void Recover(int value)
	{
		int num = this.currentHealth;
		SpriteSlider spriteSlider = this.healthSlider;
		num += value;
		this.currentHealth = num;
	}

	// Token: 0x060028A5 RID: 10405 RVA: 0x000DB3B0 File Offset: 0x000D95B0
	[Token(Token = "0x60028A5")]
	[Address(RVA = "0x66B580", Offset = "0x669B80", VA = "0x18066B580")]
	public Player()
	{
		List<PlayerWeapon> list = new List();
		this.playerWeapons = list;
		List<Transform> list2 = new List();
		this.weaponTransforms = list2;
		this.moveSpeed = 10f;
		this.basicDamage = 1f;
		this.defence = 1f;
		this.fireDamage = 1f;
		this.currentHealth = (int)((ulong)50000L);
		this.maxHealth = (int)((ulong)50000L);
		this.level = (int)((ulong)1L);
		this.refreshCount = (int)((ulong)1L);
		Dictionary<PlayerBuff, int> dictionary = new Dictionary();
		this.BuffCountDic = dictionary;
		base..ctor();
	}

	// Token: 0x0400169C RID: 5788
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400169C")]
	public List<PlayerWeapon> playerWeapons;

	// Token: 0x0400169D RID: 5789
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400169D")]
	public List<Transform> weaponTransforms;

	// Token: 0x0400169E RID: 5790
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400169E")]
	public Transform center;

	// Token: 0x0400169F RID: 5791
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400169F")]
	public Transform backShoot;

	// Token: 0x040016A0 RID: 5792
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016A0")]
	public SpriteSlider healthSlider;

	// Token: 0x040016A1 RID: 5793
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40016A1")]
	public float moveSpeed;

	// Token: 0x040016A2 RID: 5794
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40016A2")]
	public float basicDamage;

	// Token: 0x040016A3 RID: 5795
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40016A3")]
	public float defence;

	// Token: 0x040016A4 RID: 5796
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40016A4")]
	public float fireDamage;

	// Token: 0x040016A5 RID: 5797
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40016A5")]
	public float moreDamageByColumn;

	// Token: 0x040016A6 RID: 5798
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40016A6")]
	public float moreDamagePerColumn;

	// Token: 0x040016A7 RID: 5799
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40016A7")]
	public float strikeRate;

	// Token: 0x040016A8 RID: 5800
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40016A8")]
	public float strikeDamage;

	// Token: 0x040016A9 RID: 5801
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40016A9")]
	public int currentHealth;

	// Token: 0x040016AA RID: 5802
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40016AA")]
	public int maxHealth;

	// Token: 0x040016AB RID: 5803
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40016AB")]
	public int level;

	// Token: 0x040016AC RID: 5804
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40016AC")]
	public int refreshCount;

	// Token: 0x040016AD RID: 5805
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40016AD")]
	public bool cameraFollow;

	// Token: 0x040016AE RID: 5806
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Token(Token = "0x40016AE")]
	public bool moving;

	// Token: 0x040016AF RID: 5807
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x40016AF")]
	public Towards towards;

	// Token: 0x040016B0 RID: 5808
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40016B0")]
	public Dictionary<PlayerBuff, int> BuffCountDic;

	// Token: 0x040016B1 RID: 5809
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40016B1")]
	private IEffect flash;

	// Token: 0x040016B2 RID: 5810
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40016B2")]
	private Transform mainCamera;

	// Token: 0x040016B3 RID: 5811
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40016B3")]
	private SortingGroup sortingGroup;

	// Token: 0x040016B4 RID: 5812
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40016B4")]
	private float timer_summonZombie;

	// Token: 0x040016B5 RID: 5813
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40016B5")]
	private float timer_invisiable;
}
