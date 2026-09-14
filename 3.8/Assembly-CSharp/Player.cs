using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000794 RID: 1940
[Token(Token = "0x2000794")]
public class Player : Entity
{
	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06002765 RID: 10085 RVA: 0x000D59E4 File Offset: 0x000D3BE4
	[Token(Token = "0x17000191")]
	public int Row
	{
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x607F10", Offset = "0x606510", VA = "0x180607F10")]
		get
		{
			Mouse instance = Mouse.Instance;
			Transform axis = this.axis;
			Transform axis2 = this.axis;
			int num;
			return num;
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06002766 RID: 10086 RVA: 0x000D5A10 File Offset: 0x000D3C10
	[Token(Token = "0x17000192")]
	public int Column
	{
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x607E90", Offset = "0x606490", VA = "0x180607E90")]
		get
		{
			Mouse instance = Mouse.Instance;
			Transform axis = this.axis;
			int num;
			return num;
		}
	}

	// Token: 0x06002767 RID: 10087 RVA: 0x000D5A34 File Offset: 0x000D3C34
	[Token(Token = "0x6002767")]
	[Address(RVA = "0x6072D0", Offset = "0x6058D0", VA = "0x1806072D0")]
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

	// Token: 0x06002768 RID: 10088 RVA: 0x000D5A94 File Offset: 0x000D3C94
	[Token(Token = "0x6002768")]
	[Address(RVA = "0x607C80", Offset = "0x606280", VA = "0x180607C80")]
	public void Upgrade()
	{
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("武器上限+1（最多4），所有武器等级上限+2，全体伤害+10%\n生命恢复+100/秒生命上限+5000，免费刷新次数+1", 7f, num != 0);
		float num2 = this.basicDamage;
		this.basicDamage = num2;
	}

	// Token: 0x06002769 RID: 10089 RVA: 0x000D5AD4 File Offset: 0x000D3CD4
	[Token(Token = "0x6002769")]
	[Address(RVA = "0x6076C0", Offset = "0x605CC0", VA = "0x1806076C0")]
	public bool TryGetWeapon(PlayerWeaponType playerWeaponType, [Out] PlayerWeapon playerWeapon)
	{
		new Player.<>c__DisplayClass32_0().playerWeaponType = playerWeaponType;
		Func<PlayerWeapon, bool> func;
		PlayerWeapon playerWeapon2 = Enumerable.FirstOrDefault<PlayerWeapon>(this.playerWeapons, func);
		bool flag;
		return flag;
	}

	// Token: 0x0600276A RID: 10090 RVA: 0x000D5B04 File Offset: 0x000D3D04
	[Token(Token = "0x600276A")]
	[Address(RVA = "0x6057A0", Offset = "0x603DA0", VA = "0x1806057A0")]
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

	// Token: 0x0600276B RID: 10091 RVA: 0x000D5B60 File Offset: 0x000D3D60
	[Token(Token = "0x600276B")]
	[Address(RVA = "0x6077E0", Offset = "0x605DE0", VA = "0x1806077E0")]
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

	// Token: 0x0600276C RID: 10092 RVA: 0x000D5C28 File Offset: 0x000D3E28
	[Token(Token = "0x600276C")]
	[Address(RVA = "0x605170", Offset = "0x603770", VA = "0x180605170")]
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

	// Token: 0x0600276D RID: 10093 RVA: 0x000D5D54 File Offset: 0x000D3F54
	[Token(Token = "0x600276D")]
	[Address(RVA = "0x6073C0", Offset = "0x6059C0", VA = "0x1806073C0")]
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

	// Token: 0x0600276E RID: 10094 RVA: 0x000D5E14 File Offset: 0x000D4014
	[Token(Token = "0x600276E")]
	[Address(RVA = "0x606830", Offset = "0x604E30", VA = "0x180606830")]
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

	// Token: 0x0600276F RID: 10095 RVA: 0x000D5FF8 File Offset: 0x000D41F8
	[Token(Token = "0x600276F")]
	[Address(RVA = "0x605040", Offset = "0x603640", VA = "0x180605040")]
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

	// Token: 0x06002770 RID: 10096 RVA: 0x000D6048 File Offset: 0x000D4248
	[Token(Token = "0x6002770")]
	[Address(RVA = "0x606F60", Offset = "0x605560", VA = "0x180606F60")]
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
				float num4 = (float)(num3 * (int)this.defence);
				if (num2 > num4)
				{
					UIMgr.EnterLoseMenu("你被僵尸撞死了");
					return;
				}
			}
		}
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x000D60A4 File Offset: 0x000D42A4
	[Token(Token = "0x6002771")]
	[Address(RVA = "0x6058F0", Offset = "0x603EF0", VA = "0x1806058F0")]
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
			int num4 = 0;
			instance2.ShowText("武器上限+1（最多4），所有武器等级上限+2，全体伤害+10%\n生命恢复+100/秒生命上限+5000，免费刷新次数+1", 7f, num4 != 0);
			float num5 = this.basicDamage;
			this.basicDamage = num5;
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
				long num6;
				plant.attackDamage = (int)num6;
				int size = CS$<>8__locals1.plants._size;
				plant.<Team>k__BackingField = plant;
				num2++;
				Board board2 = this.board;
			}
			DelayAction delayAction = GameAPP.delayAction;
			Action action = delegate
			{
				ulong num19;
				do
				{
					int num17 = 0;
					List<Plant> list2 = new List(CS$<>8__locals1.plants);
					bool flag4;
					if (flag4)
					{
						int num18 = 0;
						if (!(num17 != num18))
						{
							continue;
						}
					}
				}
				while (num19 != (ulong)0L);
			};
			delayAction.SetAction(action, 3f);
			Solar instance4 = Solar.Instance;
			int num7 = 0;
			if (instance4 == num7)
			{
				GameObject gameObject = GameAPP.itemPrefab[46];
				identityQuaternion = Quaternion.identityQuaternion;
			}
			Solar instance5 = Solar.Instance;
			instance5.SetDamage();
			bool flag2;
			if (flag2)
			{
				int num8 = 0;
				if (!(num != num8))
				{
					continue;
				}
			}
			if (num2 != 0)
			{
				goto IL_0276;
			}
			PlayerShootingManager instance6 = PlayerShootingManager.Instance;
			List<CardUI> cards = InGameUI.Instance.Cards;
			Func<CardUI, bool> func;
			if (Player.<>c.<>9__40_0 == 0)
			{
				Player.<>c.<>9__40_0 = func;
			}
			cardUI = Enumerable.FirstOrDefault<CardUI>(cards, func);
			if (cardUI != 0)
			{
			}
			cardUI.theSeedCost = cardUI;
			float num9 = identityQuaternion * 0.1f;
			PlayerShootingManager instance7 = PlayerShootingManager.Instance;
			int num10 = 0;
			instance7.Evolution(num10 != 0);
			bool flag3;
			if (flag3)
			{
				int num11 = 0;
				if (!(num != num11))
				{
					continue;
				}
			}
		}
		while (cardUI != 0);
		PlayerShootingManager instance8 = PlayerShootingManager.Instance;
		PlayerWeapon playerWeapon;
		int num12 = playerWeapon.damage;
		float num13 = identityQuaternion * -0.1f;
		PlayerWeapon playerWeapon2;
		num12 -= playerWeapon2;
		playerWeapon.damage = num12;
		PlayerWeapon playerWeapon3;
		int damage = playerWeapon3.damage;
		float num14 = num13 * 0.2f;
		PlayerWeapon playerWeapon4;
		playerWeapon4 += damage;
		playerWeapon3.damage = playerWeapon4;
		PlayerWeapon playerWeapon5;
		int num15 = playerWeapon5.damage;
		float num16 = num14 * -0.3f;
		PlayerWeapon playerWeapon6;
		num15 -= playerWeapon6;
		playerWeapon5.damage = num15;
		return;
		IL_0276:
		throw new NullReferenceException();
	}

	// Token: 0x06002772 RID: 10098 RVA: 0x000D6330 File Offset: 0x000D4530
	[Token(Token = "0x6002772")]
	[Address(RVA = "0x605860", Offset = "0x603E60", VA = "0x180605860")]
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

	// Token: 0x06002773 RID: 10099 RVA: 0x000D635C File Offset: 0x000D455C
	[Token(Token = "0x6002773")]
	[Address(RVA = "0x605760", Offset = "0x603D60", VA = "0x180605760")]
	private void Die()
	{
		UIMgr.EnterLoseMenu("你被僵尸撞死了");
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x000D6374 File Offset: 0x000D4574
	[Token(Token = "0x6002774")]
	[Address(RVA = "0x607630", Offset = "0x605C30", VA = "0x180607630", Slot = "12")]
	public override void TakeDamage(int value, IDamageMaker damageFrom, DamageType DamageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		IEffect effect = this.flash;
		SpriteSlider spriteSlider = this.healthSlider;
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x000D6398 File Offset: 0x000D4598
	[Token(Token = "0x6002775")]
	[Address(RVA = "0x607280", Offset = "0x605880", VA = "0x180607280")]
	private void Recover(int value)
	{
		int num = this.currentHealth;
		SpriteSlider spriteSlider = this.healthSlider;
		num += value;
		this.currentHealth = num;
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x000D63C8 File Offset: 0x000D45C8
	[Token(Token = "0x6002776")]
	[Address(RVA = "0x607D30", Offset = "0x606330", VA = "0x180607D30")]
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

	// Token: 0x040015C0 RID: 5568
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40015C0")]
	public List<PlayerWeapon> playerWeapons;

	// Token: 0x040015C1 RID: 5569
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40015C1")]
	public List<Transform> weaponTransforms;

	// Token: 0x040015C2 RID: 5570
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40015C2")]
	public Transform center;

	// Token: 0x040015C3 RID: 5571
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40015C3")]
	public Transform backShoot;

	// Token: 0x040015C4 RID: 5572
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40015C4")]
	public SpriteSlider healthSlider;

	// Token: 0x040015C5 RID: 5573
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40015C5")]
	public float moveSpeed;

	// Token: 0x040015C6 RID: 5574
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40015C6")]
	public float basicDamage;

	// Token: 0x040015C7 RID: 5575
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40015C7")]
	public float defence;

	// Token: 0x040015C8 RID: 5576
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40015C8")]
	public float fireDamage;

	// Token: 0x040015C9 RID: 5577
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40015C9")]
	public float moreDamageByColumn;

	// Token: 0x040015CA RID: 5578
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40015CA")]
	public float moreDamagePerColumn;

	// Token: 0x040015CB RID: 5579
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40015CB")]
	public float strikeRate;

	// Token: 0x040015CC RID: 5580
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40015CC")]
	public float strikeDamage;

	// Token: 0x040015CD RID: 5581
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40015CD")]
	public int currentHealth;

	// Token: 0x040015CE RID: 5582
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40015CE")]
	public int maxHealth;

	// Token: 0x040015CF RID: 5583
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40015CF")]
	public int level;

	// Token: 0x040015D0 RID: 5584
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40015D0")]
	public int refreshCount;

	// Token: 0x040015D1 RID: 5585
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40015D1")]
	public bool cameraFollow;

	// Token: 0x040015D2 RID: 5586
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Token(Token = "0x40015D2")]
	public bool moving;

	// Token: 0x040015D3 RID: 5587
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x40015D3")]
	public Towards towards;

	// Token: 0x040015D4 RID: 5588
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40015D4")]
	public Dictionary<PlayerBuff, int> BuffCountDic;

	// Token: 0x040015D5 RID: 5589
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40015D5")]
	private IEffect flash;

	// Token: 0x040015D6 RID: 5590
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40015D6")]
	private Transform mainCamera;

	// Token: 0x040015D7 RID: 5591
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40015D7")]
	private SortingGroup sortingGroup;

	// Token: 0x040015D8 RID: 5592
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40015D8")]
	private float timer_summonZombie;

	// Token: 0x040015D9 RID: 5593
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40015D9")]
	private float timer_invisiable;
}
