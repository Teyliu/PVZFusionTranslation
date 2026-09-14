using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000716 RID: 1814
[Token(Token = "0x2000716")]
public class Zombie : Entity
{
	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06002470 RID: 9328 RVA: 0x000BDB6C File Offset: 0x000BBD6C
	[Token(Token = "0x17000171")]
	public int CurrentFirstHealth
	{
		[Token(Token = "0x6002470")]
		[Address(RVA = "0x5A35A0", Offset = "0x5A1BA0", VA = "0x1805A35A0")]
		get
		{
			return this.theFirstArmorHealth;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06002471 RID: 9329 RVA: 0x000BDB80 File Offset: 0x000BBD80
	[Token(Token = "0x17000172")]
	public int CurrentAllHealth
	{
		[Token(Token = "0x6002471")]
		[Address(RVA = "0x5A3580", Offset = "0x5A1B80", VA = "0x1805A3580")]
		get
		{
			return this.theSecondArmorHealth;
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06002472 RID: 9330 RVA: 0x000BDB94 File Offset: 0x000BBD94
	[Token(Token = "0x17000173")]
	public int TotalAllHealth
	{
		[Token(Token = "0x6002472")]
		[Address(RVA = "0x5A3650", Offset = "0x5A1C50", VA = "0x1805A3650")]
		get
		{
			return this.theSecondArmorMaxHealth;
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06002473 RID: 9331 RVA: 0x000BDBA8 File Offset: 0x000BBDA8
	[Token(Token = "0x17000174")]
	public float TotalFirstHealth
	{
		[Token(Token = "0x6002473")]
		[Address(RVA = "0x5A3670", Offset = "0x5A1C70", VA = "0x1805A3670")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06002474 RID: 9332 RVA: 0x000BDBBC File Offset: 0x000BBDBC
	[Token(Token = "0x17000175")]
	public float DamageMultiplier
	{
		[Token(Token = "0x6002474")]
		[Address(RVA = "0x5A35B0", Offset = "0x5A1BB0", VA = "0x1805A35B0")]
		get
		{
			TravelData data = TravelMgr.Instance.data;
			throw new NullReferenceException();
		}
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06002475 RID: 9333 RVA: 0x000BDBE4 File Offset: 0x000BBDE4
	[Token(Token = "0x17000176")]
	public bool Alive
	{
		[Token(Token = "0x6002475")]
		[Address(RVA = "0x5A3310", Offset = "0x5A1910", VA = "0x1805A3310")]
		get
		{
			return !this.beforeDying && this.theStatus != ZombieStatus.Dying && this.theHealth > 0;
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06002476 RID: 9334 RVA: 0x000BDC10 File Offset: 0x000BBE10
	[Token(Token = "0x17000177")]
	public int Column
	{
		[Token(Token = "0x6002476")]
		[Address(RVA = "0x5A3550", Offset = "0x5A1B50", VA = "0x1805A3550")]
		get
		{
			Transform axis = this.axis;
			int num;
			return num;
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06002477 RID: 9335 RVA: 0x000BDC30 File Offset: 0x000BBE30
	[Token(Token = "0x17000178")]
	public BoxType BoxType
	{
		[Token(Token = "0x6002477")]
		[Address(RVA = "0x5A3330", Offset = "0x5A1930", VA = "0x1805A3330")]
		get
		{
			Transform axis = this.axis;
			Board board = this.board;
			int num = this.theZombieRow;
			int num2;
			return board.GetBoxType(num2, num);
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06002478 RID: 9336 RVA: 0x000BDC70 File Offset: 0x000BBE70
	[Token(Token = "0x17000179")]
	public Vector2 Velocity
	{
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x5A3690", Offset = "0x5A1C90", VA = "0x1805A3690")]
		get
		{
			Corner corner = this.targetCorner;
			int num = 0;
			if (!(corner == num))
			{
				if (this.targetCorner.theRow > this.theZombieRow)
				{
					Rigidbody2D rigidbody2D = this.rb;
					Vector2 velocity = rigidbody2D.velocity;
					int num2 = 0;
					if (num2 != 0)
					{
						Animator anim = this.anim;
						if (num2 != 0)
						{
							goto IL_0089;
						}
						Animator anim2 = this.anim;
					}
					Vector2 velocity2 = this.rb.velocity;
					Vector2 velocity3 = this.rb.velocity;
					int num3 = 0;
					if (num3 == 0)
					{
						goto IL_0091;
					}
					Animator anim3 = this.anim;
					if (num3 != 0)
					{
					}
				}
				IL_0089:
				Animator anim4 = this.anim;
				IL_0091:
				return this.rb.velocity;
			}
			Vector2 velocity4 = this.rb.velocity;
			int num4 = 0;
			if (num4 != 0)
			{
				Animator anim5 = this.anim;
				if (num4 != 0)
				{
				}
				Animator anim6 = this.anim;
				float deltaTime = Time.deltaTime;
			}
			Vector2 velocity5 = this.rb.velocity;
			throw new NullReferenceException();
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06002479 RID: 9337 RVA: 0x000BDD70 File Offset: 0x000BBF70
	[Token(Token = "0x1700017A")]
	public Vector2 ColliderPosition
	{
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x5A3470", Offset = "0x5A1A70", VA = "0x1805A3470")]
		get
		{
			Collider2D collider2D = this.col;
			int num = 0;
			if (!(collider2D == num))
			{
				Collider2D collider2D2 = this.col;
			}
			Transform axis = this.axis;
			throw new NullReferenceException();
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x0600247A RID: 9338 RVA: 0x000BDDB0 File Offset: 0x000BBFB0
	[Token(Token = "0x1700017B")]
	public Vector2 ColliderCenter
	{
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x5A3390", Offset = "0x5A1990", VA = "0x1805A3390")]
		get
		{
			Collider2D collider2D = this.col;
			int num = 0;
			if (!(collider2D == num))
			{
				Collider2D collider2D2 = this.col;
			}
			Transform axis = this.axis;
			throw new NullReferenceException();
		}
	}

	// Token: 0x0600247B RID: 9339 RVA: 0x000BDDF0 File Offset: 0x000BBFF0
	[Token(Token = "0x600247B")]
	[Address(RVA = "0x5935B0", Offset = "0x591BB0", VA = "0x1805935B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Collider2D component2 = base.GetComponent<Collider2D>();
		this.col = component2;
		SpriteRenderer spriteRenderer = this.headGarlic;
		int num = 0;
		if (spriteRenderer != num)
		{
			Sprite sprite = this.headGarlic.sprite;
			this.headOriginalSprite = sprite;
		}
		Board instance = Board.Instance;
		int num2 = 0;
		if (instance != num2)
		{
			float zombieMaxX = Board.Instance.zombieMaxX;
			this.deadRight = zombieMaxX;
			float zombieMinX = Board.Instance.zombieMinX;
			this.deadLeft = zombieMinX;
		}
		GameObject gameObject = this.FindZombieHead();
		this.butterHead = gameObject;
	}

	// Token: 0x0600247C RID: 9340 RVA: 0x000BDE9C File Offset: 0x000BC09C
	[Token(Token = "0x600247C")]
	[Address(RVA = "0x5A0680", Offset = "0x59EC80", VA = "0x1805A0680", Slot = "15")]
	protected virtual void Start()
	{
		AnimatorControllerParameter[] parameters = this.anim.parameters;
		Func<AnimatorControllerParameter, bool> <>9__132_ = Zombie.<>c.<>9__132_0;
		if (<>9__132_ == 0)
		{
			Func<AnimatorControllerParameter, bool> func;
			Zombie.<>c.<>9__132_0 = func;
		}
		bool flag = Enumerable.Any<AnimatorControllerParameter>(parameters, <>9__132_);
		this.hasIsAttackingParam = flag;
		HashSet<EveZombieBuff> hashSet = new HashSet(this.board.eveZombieBuffs);
		this.eveBuffs = hashSet;
		Board board = this.board;
		hashSet += hashSet;
		this.theAttackDamage = hashSet;
		Board board2 = this.board;
		if (GameAPP.config.difficulty == 4 || GameAPP.config.difficulty == 5)
		{
			float num = this.theOriginSpeed;
			this.theOriginSpeed = num;
		}
		this.UpdateHealthText();
		this.FindJaw();
		Func<Zombie, bool> func2;
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(this.board.zombieHead, func2);
		int num2 = 0;
		if (!(zombie != num2))
		{
			List<Zombie> zombieHead = this.board.zombieHead;
		}
		Zombie zombie2 = zombie.next;
		int num3 = 0;
		if (zombie2 != num3)
		{
			zombie.next.pre = this;
			Zombie zombie3 = zombie.next;
			this.next = zombie3;
		}
		this.pre = zombie;
		zombie.next = this;
		Dictionary<ZombieType, List<Zombie>> zombieHeads = this.board.zombieHeads;
		bool flag2;
		if (!flag2)
		{
			List<Zombie> list = new List();
			Dictionary<ZombieType, List<Zombie>> zombieHeads2 = this.board.zombieHeads;
			ZombieType zombieType = this.theZombieType;
			zombieHeads2[zombieType] = list;
		}
		if (!this.isMindControlled)
		{
			this.InitArmor();
		}
	}

	// Token: 0x0600247D RID: 9341 RVA: 0x000BE00C File Offset: 0x000BC20C
	[Token(Token = "0x600247D")]
	[Address(RVA = "0x5A2370", Offset = "0x5A0970", VA = "0x1805A2370", Slot = "16")]
	protected virtual void Update()
	{
		ulong num7;
		do
		{
			int num = 0;
			this.MoveUpdate();
			int num2 = 0;
			float num3 = this.attributeCountDown;
			if (num3 > (float)num2)
			{
				float deltaTime = Time.deltaTime;
				this.attributeCountDown = num3;
				this.attributeCountDown = 0f;
				this.AttributeEvent();
			}
			float num4 = this.dogeTime;
			if (num4 > (float)num2)
			{
				float deltaTime2 = Time.deltaTime;
				this.dogeTime = num4;
				this.dogeTime = 0f;
			}
			this.ZombieUpdate();
			int num5 = 0;
			this.Die(num5);
			List<ZombieTimer> list = Enumerable.ToList<ZombieTimer>(this.timers.Keys);
			bool flag;
			if (flag)
			{
				if (this.timers[num] <= num2)
				{
					continue;
				}
				num4 = this.timers[num];
				float deltaTime3 = Time.deltaTime;
				float num6 = this.timers[num];
				Dictionary<ZombieTimer, float> dictionary = this.timers;
			}
		}
		while (num7 != (ulong)0L);
		float deltaTime4 = Time.deltaTime;
		float deltaTime5 = Time.deltaTime;
	}

	// Token: 0x0600247E RID: 9342 RVA: 0x000BE124 File Offset: 0x000BC324
	[Token(Token = "0x600247E")]
	[Address(RVA = "0x599EF0", Offset = "0x5984F0", VA = "0x180599EF0", Slot = "17")]
	protected virtual void FixedUpdate()
	{
		ulong num8;
		do
		{
			int num = 0;
			if ((this.beforeDying ? 1 : 0) != num)
			{
				int num2 = this.theHealth;
				this.theHealth = num2;
				int num3 = 0;
				this.Die(num3);
				this.UpdateHealthText();
			}
			if (this.theStatus != ZombieStatus.Dying)
			{
				float num4 = this.flashTime;
				int num5 = 0;
				if (num4 > (float)num5)
				{
					if (num4 > 0.2f)
					{
						goto IL_0065;
					}
					float num6;
					if (num4 > (float)num5)
					{
						num6 = num4 * 15f;
						this.SetBrightness(num6);
						goto IL_0065;
					}
					IL_0077:
					this.flashTime = num4;
					if (num4 == (float)num5)
					{
						this.SetBrightness(1f);
						goto IL_0090;
					}
					goto IL_0090;
					IL_0065:
					float num7 = num6 * -30f;
					this.SetBrightness(num7);
					goto IL_0077;
				}
			}
			IL_0090:
			this.OnFixedUpdate();
			Dictionary<EffectType, BaseEffect> effects = this.effects;
			bool flag;
			if (flag)
			{
			}
		}
		while (num8 != (ulong)0L);
	}

	// Token: 0x0600247F RID: 9343 RVA: 0x000BE1E8 File Offset: 0x000BC3E8
	[Token(Token = "0x600247F")]
	[Address(RVA = "0x59C5E0", Offset = "0x59ABE0", VA = "0x18059C5E0")]
	public void ModifyArmor(ArmorBonus bonusType, float value, bool add = false, float lim = 0f)
	{
		Dictionary<ArmorBonus, float> dictionary = this.armorBonus;
		if (add)
		{
		}
		Dictionary<ArmorBonus, float> dictionary2 = this.armorBonus;
		this.theArmor = (float)0;
		this.theArmor = 0f;
	}

	// Token: 0x06002480 RID: 9344 RVA: 0x000BE224 File Offset: 0x000BC424
	[Token(Token = "0x6002480")]
	[Address(RVA = "0x59C6E0", Offset = "0x59ACE0", VA = "0x18059C6E0")]
	public void ModifyFragile(ZombieFragile type, float value)
	{
		Dictionary<ZombieFragile, float> dictionary = this.fragiles;
		ulong num2;
		float num = (float)(num2 * (ulong)1E-06f);
		float epsilon = Mathf.Epsilon;
		if (num <= value)
		{
			Dictionary<ZombieFragile, float> dictionary2 = this.fragiles;
			Dictionary<ZombieFragile, float> dictionary3 = this.fragiles;
			Func<KeyValuePair<ZombieFragile, float>, float> <>9__136_ = Zombie.<>c.<>9__136_0;
			if (<>9__136_ == 0)
			{
				Func<KeyValuePair<ZombieFragile, float>, float> func;
				Zombie.<>c.<>9__136_0 = func;
			}
			float num3 = Enumerable.Sum<KeyValuePair<ZombieFragile, float>>(dictionary3, <>9__136_);
			this.fragileValue = num3;
		}
	}

	// Token: 0x06002481 RID: 9345 RVA: 0x000BE288 File Offset: 0x000BC488
	[Token(Token = "0x6002481")]
	[Address(RVA = "0x5A2790", Offset = "0x5A0D90", VA = "0x1805A2790")]
	private void WhenLeaderDie()
	{
		int num4;
		do
		{
			Zombie zombie = this.pre;
			int num = 0;
			if (!(zombie == num))
			{
				break;
			}
			Zombie zombie2 = this.next;
			int num2 = 0;
			if (!(zombie2 == num2) || this.isMindControlled)
			{
				break;
			}
			if (this.theZombieType == ZombieType.UltimateGargantuar)
			{
				List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
				int num3 = 0;
				bool flag;
				if (flag)
				{
				}
				if (num3 != 0)
				{
					goto IL_00CB;
				}
			}
			num4 = 0;
			HashSet<TravelDebuff> leaderArmor = TravelHelper.LeaderArmor;
			bool flag2;
			if (flag2)
			{
				Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
				Type typeFromHandle = typeof(ArmorBonus);
				string text2;
				string text = "Leader_" + text2;
				object obj = Enum.Parse(typeFromHandle, text);
				List<Zombie> allZombies2 = global::Lawnf.GetAllZombies(false);
				bool flag3;
				if (flag3)
				{
				}
				if (num4 != 0)
				{
					goto IL_00D1;
				}
			}
		}
		while (num4 != 0);
		return;
		IL_00CB:
		throw new NullReferenceException();
		IL_00D1:
		throw new NullReferenceException();
	}

	// Token: 0x06002482 RID: 9346 RVA: 0x000BE380 File Offset: 0x000BC580
	[Token(Token = "0x6002482")]
	[Address(RVA = "0x59B7E0", Offset = "0x599DE0", VA = "0x18059B7E0")]
	private void InitArmor()
	{
		int num3;
		do
		{
			int num = 0;
			if (this.theZombieType == ZombieType.UltimateGargantuar)
			{
				List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
				int num2 = 0;
				bool flag;
				if (flag)
				{
				}
				if (num2 != 0)
				{
					goto IL_00CA;
				}
			}
			bool flag2 = this.CheckExist((ZombieType)((uint)212));
			num3 = 0;
			int num4 = 0;
			if (flag2)
			{
				int num5 = 0;
				this.ModifyArmor((ArmorBonus)((uint)1), 500f, num5 != 0, (float)num4);
			}
			HashSet<TravelDebuff> leaderArmor = TravelHelper.LeaderArmor;
			bool flag3;
			if (flag3)
			{
				if (!global::Lawnf.TravelDebuff((TravelDebuff)num))
				{
					continue;
				}
				Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
				Type typeFromHandle = typeof(ArmorBonus);
				string text2;
				string text = "Leader_" + text2;
				object obj = Enum.Parse(typeFromHandle, text);
				List<Zombie> allZombies2 = global::Lawnf.GetAllZombies(false);
				bool flag4;
				if (flag4)
				{
				}
				if (num3 != 0)
				{
					goto IL_00D0;
				}
				bool flag5;
				while (!flag5)
				{
				}
			}
		}
		while (num3 != 0);
		return;
		IL_00CA:
		throw new NullReferenceException();
		IL_00D0:
		throw new NullReferenceException();
	}

	// Token: 0x06002483 RID: 9347 RVA: 0x000BE478 File Offset: 0x000BC678
	[Token(Token = "0x6002483")]
	[Address(RVA = "0x594B30", Offset = "0x593130", VA = "0x180594B30")]
	protected bool CheckExist(ZombieType zombieType)
	{
		Dictionary<ZombieType, int> enermyCountDic = this.board.enermyCountDic;
		bool flag;
		if (!flag)
		{
			return flag;
		}
		bool flag2;
		return flag2;
	}

	// Token: 0x06002484 RID: 9348 RVA: 0x000BE4A0 File Offset: 0x000BC6A0
	[Token(Token = "0x6002484")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "18")]
	protected virtual void ZombieUpdate()
	{
	}

	// Token: 0x06002485 RID: 9349 RVA: 0x000BE4B0 File Offset: 0x000BC6B0
	[Token(Token = "0x6002485")]
	[Address(RVA = "0x59D0E0", Offset = "0x59B6E0", VA = "0x18059D0E0", Slot = "19")]
	protected virtual void OverRangeDie()
	{
		Transform axis = this.axis;
		Transform axis2 = this.axis;
		float num = this.deadLeft;
	}

	// Token: 0x06002486 RID: 9350 RVA: 0x000BE4DC File Offset: 0x000BC6DC
	[Token(Token = "0x6002486")]
	[Address(RVA = "0x59C910", Offset = "0x59AF10", VA = "0x18059C910", Slot = "20")]
	protected virtual void MoveUpdate()
	{
		ulong num3;
		do
		{
			if (this.theStatus != ZombieStatus.Dying && !this.isBlowed && !base.HasBuff((EffectType)((uint)5)))
			{
				this.PositionUpdate();
			}
			if (!base.HasBuff((EffectType)((uint)5)))
			{
				float num = this.freezeSpeed * this.theOriginSpeed * this.coldSpeed * this.kelpSpeed * this.butterSpeed * this.garlicSpeed * this.uniqueSpeed * this.holeSpeed;
				this.theSpeed = num;
			}
			this.theSpeed = 0f;
			Rigidbody2D rigidbody2D = this.rb;
			Animator anim = this.anim;
			float num2 = this.theSpeed;
			anim.SetFloat("Speed", num2);
			List<KeyValuePair<EffectType, BaseEffect>> list = Enumerable.ToList<KeyValuePair<EffectType, BaseEffect>>(this.effects);
			bool flag;
			if (flag)
			{
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06002487 RID: 9351 RVA: 0x000BE5AC File Offset: 0x000BC7AC
	[Token(Token = "0x6002487")]
	[Address(RVA = "0x5A2250", Offset = "0x5A0850", VA = "0x1805A2250")]
	private void UpdateSpeed()
	{
		if (!base.HasBuff((EffectType)((uint)5)))
		{
			float num = this.freezeSpeed * this.theOriginSpeed * this.coldSpeed * this.kelpSpeed * this.butterSpeed * this.garlicSpeed * this.uniqueSpeed * this.holeSpeed;
			this.theSpeed = num;
		}
		Rigidbody2D rigidbody2D = this.rb;
		this.theSpeed = 0f;
		Animator anim = this.anim;
		float num2 = this.theSpeed;
		anim.SetFloat("Speed", num2);
	}

	// Token: 0x06002488 RID: 9352 RVA: 0x000BE638 File Offset: 0x000BC838
	[Token(Token = "0x6002488")]
	[Address(RVA = "0x59D7E0", Offset = "0x59BDE0", VA = "0x18059D7E0", Slot = "21")]
	protected virtual void PositionUpdate()
	{
		float deltaTime = this.ladderTime;
		int num = 0;
		int num2 = 0;
		if (deltaTime <= (float)num2)
		{
			Corner corner = this.targetCorner;
			int num3 = 0;
			if (!(corner != num3))
			{
				if (!base.HasBuff((EffectType)((uint)12)))
				{
					Transform transform = base.transform;
					Transform transform2 = base.transform;
					Animator anim = this.anim;
					Transform axis = this.axis;
					Mouse instance = Mouse.Instance;
					Board board = this.board;
					Transform axis2 = this.axis;
					Transform axis3 = this.axis;
					float deltaTime2 = Time.deltaTime;
					if (num != 0)
					{
					}
				}
				return;
			}
			Corner corner2 = this.targetCorner;
			int num4 = this.theZombieRow;
			if (corner2.theRow != num4)
			{
				Rigidbody2D rigidbody2D = this.rb;
				Vector2 velocity = rigidbody2D.velocity;
				Transform transform3 = base.transform;
				Vector2 velocity2 = this.rb.velocity;
				float deltaTime3 = Time.deltaTime;
				Animator anim2 = this.anim;
				Transform axis4 = this.axis;
				Mouse instance2 = Mouse.Instance;
				Transform axis5 = this.axis;
				Transform axis6 = this.axis;
				Corner corner3 = this.targetCorner;
				Transform axis7 = this.axis;
				Vector3 vector;
				float y = vector.y;
				if (num != 0)
				{
					Corner corner4 = this.targetCorner;
					int num5;
					if (num5 == corner4.theRow)
					{
						goto IL_0158;
					}
					this.theZombieRow = num5;
				}
				Transform axis8 = this.axis;
				int theRow = this.targetCorner.theRow;
				this.theZombieRow = theRow;
			}
			this.targetCorner = num;
			IL_0158:
			SortingGroup sortingGroup = this.sortingGroup;
			int num6;
			string text = string.Format("zombie{0}", num6);
			sortingGroup.sortingLayerName = text;
		}
		float deltaTime4 = Time.deltaTime;
		this.ladderTime = deltaTime;
		this.ladderTime = (float)num;
		int num7 = 0;
		Transform transform4 = base.transform;
		deltaTime = Time.deltaTime;
		float deltaTime5 = Time.deltaTime;
		transform4.Translate(num7);
		throw new NullReferenceException();
	}

	// Token: 0x06002489 RID: 9353 RVA: 0x000BE804 File Offset: 0x000BCA04
	[Token(Token = "0x6002489")]
	[Address(RVA = "0x59C540", Offset = "0x59AB40", VA = "0x18059C540")]
	protected void LadderPositionUpdate()
	{
		float deltaTime = this.ladderTime;
		float deltaTime2 = Time.deltaTime;
		this.ladderTime = deltaTime;
		this.ladderTime = 0f;
		Transform transform = base.transform;
		deltaTime = Time.deltaTime;
		float deltaTime3 = Time.deltaTime;
	}

	// Token: 0x0600248A RID: 9354 RVA: 0x000BE858 File Offset: 0x000BCA58
	[Token(Token = "0x600248A")]
	[Address(RVA = "0x593510", Offset = "0x591B10", VA = "0x180593510")]
	private void AttributeUpdate()
	{
		float num = this.attributeCountDown;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.attributeCountDown = num;
			this.attributeCountDown = 0f;
			this.AttributeEvent();
		}
		float num3 = this.dogeTime;
		if (num3 > (float)num2)
		{
			float deltaTime2 = Time.deltaTime;
			this.dogeTime = num3;
			this.dogeTime = 0f;
		}
	}

	// Token: 0x0600248B RID: 9355 RVA: 0x000BE8BC File Offset: 0x000BCABC
	[Token(Token = "0x600248B")]
	[Address(RVA = "0x59CB90", Offset = "0x59B190", VA = "0x18059CB90", Slot = "22")]
	protected virtual void OnFixedUpdate()
	{
		this.OverRangeDie();
		if (this.beforeDying || this.theStatus == ZombieStatus.Dying || this.theHealth > 0)
		{
		}
		this.theAttackTarget = (ulong)0L;
		this.isAttacking = false;
	}

	// Token: 0x0600248C RID: 9356 RVA: 0x000BE8FC File Offset: 0x000BCAFC
	[Token(Token = "0x600248C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "23")]
	protected virtual void AttributeEvent()
	{
	}

	// Token: 0x0600248D RID: 9357 RVA: 0x000BE90C File Offset: 0x000BCB0C
	[Token(Token = "0x600248D")]
	[Address(RVA = "0x595100", Offset = "0x593700", VA = "0x180595100")]
	public void DamagedByPoison(float damageMultiplier = 1f)
	{
		if (AdvantureConfig.data.GetResult(AdvantureLevel.Roof4, (MissionResult)((uint)1)))
		{
		}
	}

	// Token: 0x0600248E RID: 9358 RVA: 0x000BE934 File Offset: 0x000BCB34
	[Token(Token = "0x600248E")]
	[Address(RVA = "0x594740", Offset = "0x592D40", VA = "0x180594740", Slot = "24")]
	public virtual void ChangeRow(int theTargetRow)
	{
		int rowNum = this.board.rowNum;
		if (theTargetRow > rowNum)
		{
			Board board = this.board;
		}
		if (theTargetRow != this.theZombieRow)
		{
			this.theZombieRow = theTargetRow;
			SortingGroup sortingGroup = this.sortingGroup;
			string text = string.Format("zombie{0}", rowNum);
			sortingGroup.sortingLayerName = text;
		}
	}

	// Token: 0x0600248F RID: 9359 RVA: 0x000BE988 File Offset: 0x000BCB88
	[Token(Token = "0x600248F")]
	[Address(RVA = "0x594820", Offset = "0x592E20", VA = "0x180594820", Slot = "25")]
	public virtual void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
		if (GameAPP.config.difficulty < 4 && this.theHealth > damage)
		{
			return;
		}
		if (this.read == 0)
		{
		}
		if (GameAPP.config.difficulty == 4)
		{
		}
		if (GameAPP.config.difficulty == 5)
		{
			float num2;
			float num = num2 * 0.4f;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002490 RID: 9360 RVA: 0x000BE9EC File Offset: 0x000BCBEC
	[Token(Token = "0x6002490")]
	[Address(RVA = "0x59E9B0", Offset = "0x59CFB0", VA = "0x18059E9B0")]
	private void SetCarred()
	{
		Transform axis = this.axis;
		int num = 0;
		bool flag = axis != num;
		if (flag && !this.inWater && !this.isSmall)
		{
			ZombieType zombieType = this.theZombieType;
			if (zombieType <= ZombieType.RedZombieLoonNut)
			{
				goto IL_0086;
			}
			if (zombieType > ZombieType.ObsidianImpZombie)
			{
				if (zombieType > ZombieType.SnowMonsterRider)
				{
					if (flag)
					{
						goto IL_0057;
					}
					if (flag > true)
					{
						goto IL_00A2;
					}
				}
				if (flag <= true)
				{
				}
				if (zombieType != ZombieType.SnowMonsterRider)
				{
					goto IL_00A2;
				}
			}
		}
		IL_0057:
		uint num2;
		if (num2 > (uint)201)
		{
			while (num2 == (uint)210)
			{
			}
			while (num2 == (uint)213)
			{
			}
		}
		while (num2 == (uint)112)
		{
		}
		while (num2 == (uint)201)
		{
		}
		IL_0086:
		if (num2 > (uint)31)
		{
			if (num2 > (uint)45)
			{
			}
			while (num2 == (uint)45)
			{
			}
		}
		if (num2 <= (uint)45)
		{
		}
		IL_00A2:
		uint num3;
		if (this.theStatus > ZombieStatus.Pol_jump)
		{
			while (num3 == (uint)(-3))
			{
			}
			if (num3 > (uint)1)
			{
				goto IL_00BF;
			}
		}
		while (num3 == (uint)(-3))
		{
		}
		IL_00BF:
		while (this.beforeDying)
		{
		}
		if ((num2 > (uint)124 && (num2 == (uint)233 || num2 != (uint)241)) || num3 <= (uint)1 || num3 <= (uint)3)
		{
		}
		GameObject gameObject = Resources.Load<GameObject>("Zombies/Charred/Gargantuar/Gargantuar_charred");
		Transform transform = base.transform;
		Board board = this.board;
		Transform transform2 = board.transform;
		Board board2 = this.board;
		GameObject gameObject2;
		Transform transform3 = gameObject2.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform4 = gameObject2.transform.Find("Shadow").gameObject.transform;
		Transform axis2 = this.axis;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform transform5 = gameObject2.transform;
		SortingGroup sortingGroup = gameObject2.AddComponent<SortingGroup>();
		int sortingLayerID = this.sortingGroup.sortingLayerID;
		sortingGroup.sortingLayerID = sortingLayerID;
		throw new NullReferenceException();
	}

	// Token: 0x06002491 RID: 9361 RVA: 0x000BEB8C File Offset: 0x000BCD8C
	[Token(Token = "0x6002491")]
	[Address(RVA = "0x598C20", Offset = "0x597220", VA = "0x180598C20")]
	private bool ExistAnim()
	{
		if (this.isSmall)
		{
			goto IL_002D;
		}
		ZombieType zombieType = this.theZombieType;
		if (zombieType <= ZombieType.RedZombieLoonNut)
		{
			goto IL_0033;
		}
		if (zombieType > ZombieType.ObsidianImpZombie)
		{
			if (zombieType > ZombieType.SnowMonsterRider)
			{
			}
			if (zombieType == ZombieType.SnowMonsterRider)
			{
				goto IL_002D;
			}
			goto IL_0044;
		}
		IL_002F:
		int i;
		while (i <= 1)
		{
		}
		IL_0033:
		while (i <= 1)
		{
		}
		if (i <= 9)
		{
		}
		if (i <= 7)
		{
			while (i <= 3)
			{
			}
			goto IL_0044;
		}
		goto IL_0044;
		IL_002D:
		i = 0;
		goto IL_002F;
		IL_0044:
		int j;
		if (this.theStatus > ZombieStatus.Pol_jump)
		{
			uint num;
			while (num == (uint)(-3))
			{
			}
			if (num > (uint)1)
			{
				goto IL_005F;
			}
			j = 0;
		}
		while (j == -3)
		{
		}
		IL_005F:
		while (j <= -3)
		{
		}
		while (j <= -3)
		{
		}
		while (j <= -3)
		{
		}
		return false;
	}

	// Token: 0x06002492 RID: 9362 RVA: 0x000BEC08 File Offset: 0x000BCE08
	[Token(Token = "0x6002492")]
	[Address(RVA = "0x59FAF0", Offset = "0x59E0F0", VA = "0x18059FAF0", Slot = "26")]
	public virtual void SetMindControl(int controlLevel = 0)
	{
		int num = 0;
		if ((this.isMindControlled ? 1 : 0) == num && this.theStatus != ZombieStatus.Dying)
		{
			GameObject gameObject = base.gameObject;
			int num2 = LayerMask.NameToLayer("Plant");
			gameObject.layer = num2;
			bool flag = base.RemoveBuff((EffectType)((uint)1));
			bool flag2 = base.RemoveBuff((EffectType)((uint)3));
			Board board = this.board;
			this.theArmor = (float)num;
			this.towards = (Towards)((ulong)1L);
			Dictionary<ZombieType, int> enermyCountDic = board.enermyCountDic;
			ZombieType zombieType = this.theZombieType;
			if (enermyCountDic.TryGetValue(zombieType, num))
			{
				Dictionary<ZombieType, int> enermyCountDic2 = this.board.enermyCountDic;
				ZombieType zombieType2 = this.theZombieType;
			}
			Board board2 = this.board;
			BoardStatistics boardStatistics = this.board.boardStatistics;
			Board board3 = this.board;
			if (board3.enermyCount < num)
			{
				board3.enermyCount = num;
			}
			this.DropItem();
			GameAPP.PlaySound(62, 0.5f, 1f);
			GameAPP.PlaySound(63, 0.5f, 1f);
			Transform axis = this.axis;
			GameObject[] particlePrefab = GameAPP.particlePrefab;
			GameObject gameObject2 = particlePrefab[20];
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			this.isMindControlled = true;
			this.<Team>k__BackingField = (Team)num;
			Transform transform2 = base.transform;
			Transform transform3 = this.healthText.transform;
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
			transform3.rotation = identityQuaternion2;
			Transform transform4 = base.transform;
			int num3 = 0;
			int num4 = 0;
			transform4.Translate((float)num4, (float)num3, -1f);
			int num5 = 0;
			this.UpdateColor((Zombie.ZombieColor)num5);
			this.theAttackTarget = num;
			this.isAttacking = num != 0;
			if ((this.hasIsAttackingParam ? 1 : 0) != num)
			{
				Animator anim = this.anim;
				int num6 = 0;
				anim.SetBool("isAttacking", num6 != 0);
			}
			AdvantureMission.TryAddCount((AdvantureLevel)((uint)15));
		}
	}

	// Token: 0x06002493 RID: 9363 RVA: 0x000BEDCC File Offset: 0x000BCFCC
	[Token(Token = "0x6002493")]
	[Address(RVA = "0x595380", Offset = "0x593980", VA = "0x180595380", Slot = "27")]
	public virtual void Die(int reason = 0)
	{
		int num;
		int num5;
		uint num10;
		do
		{
			num = 0;
			int num2 = 0;
			if (this.theStatus == ZombieStatus.Dying)
			{
				goto IL_0300;
			}
			this.dieReason = reason;
			this.theStatus = (ZombieStatus)((ulong)1L);
			if ((this.isMindControlled ? 1 : 0) == num2)
			{
				Board board = this.board;
				BoardStatistics boardStatistics = this.board.boardStatistics;
				Dictionary<ZombieType, int> zombiesKilledByType = this.board.boardStatistics.zombiesKilledByType;
				ZombieType zombieType = this.theZombieType;
				bool flag = zombiesKilledByType.ContainsKey(zombieType);
				Board board2 = this.board;
				if (!flag)
				{
					Dictionary<ZombieType, int> zombiesKilledByType2 = board2.boardStatistics.zombiesKilledByType;
				}
				Dictionary<ZombieType, int> zombiesKilledByType3 = board2.boardStatistics.zombiesKilledByType;
				ZombieType zombieType2 = this.theZombieType;
				Board board3 = this.board;
				if (board3.enermyCount < num)
				{
					board3.enermyCount = num;
				}
				Dictionary<ZombieType, int> enermyCountDic = this.board.enermyCountDic;
				ZombieType zombieType3 = this.theZombieType;
				int num3;
				if (enermyCountDic.TryGetValue(zombieType3, num3))
				{
					Dictionary<ZombieType, int> enermyCountDic2 = this.board.enermyCountDic;
					ZombieType zombieType4 = this.theZombieType;
				}
			}
			if ((this.garlicDoom ? 1 : 0) != num)
			{
				uint num4;
				GameAPP.PlaySound((int)num4, 0.5f, 1f);
				this.garlicDoom = num != 0;
				Transform axis = this.axis;
				Vector3 vector;
				float z = vector.z;
				ParticleManager instance = ParticleManager.Instance;
			}
			if ((this.isDoom ? 1 : 0) != num)
			{
				this.isDoom = num != 0;
				BoardAction boardAction = this.board.boardAction;
				Mouse instance2 = Mouse.Instance;
				Transform axis2 = this.axis;
				num5 = 0;
			}
			if (Mouse.Instance.theZombieOnGlove == this)
			{
				global::UnityEngine.Object.Destroy(Mouse.Instance.theItemOnMouse);
				Mouse instance3 = Mouse.Instance;
				int num6 = 0;
				instance3.ClearItemOnMouse(num6 != 0);
			}
			this.garlicSpeed = 1f;
			Board board4 = this.board;
			if ((this.isMindControlled ? 1 : 0) == num)
			{
				FruitNinjaManager.Instance.ZombieDeath(this);
			}
			int num7 = this.fireFlyedCount;
			int num8 = num7 - 1;
			this.fireFlyedCount = num8;
			if (num7 > 0)
			{
				CreateItem instance4 = CreateItem.Instance;
				Transform axis3 = this.axis;
				Vector3 vector2;
				float z2 = vector2.z;
				int num9 = this.fireFlyedCount - 1;
				this.fireFlyedCount = num9;
			}
			this.DieEvent((int)num10);
			HashSet<EveZombieBuff> hashSet = this.eveBuffs;
			bool flag2;
			if (!flag2)
			{
				break;
			}
			bool flag3 = this.isMindControlled;
			List<Zombie> zombiesByRow = global::Lawnf.GetZombiesByRow(this.theZombieRow, flag3);
			bool flag4;
			if (flag4)
			{
			}
		}
		while (num != 0);
		bool flag5;
		if (flag5)
		{
		}
		bool flag6;
		if (!flag6 || !global::Lawnf.EveBalaced())
		{
		}
		bool flag7;
		if (flag7)
		{
		}
		bool flag8;
		if (flag8)
		{
			uint num12;
			int num11 = global::UnityEngine.Random.Range(0, (int)num12);
			if (num11 == 1 && num10 != (uint)num11)
			{
				CreateZombie instance5 = CreateZombie.Instance;
				int num13 = 0;
				Zombie zombie;
				if (zombie != num13)
				{
					zombie.revived = true;
				}
			}
		}
		uint num14;
		if (global::UnityEngine.Random.Range(0, (int)num14) == 50)
		{
		}
		uint num15;
		Transform transform;
		if (num15 != (uint)0)
		{
			if (num15 != (uint)0 && num15 != (uint)1)
			{
				return;
			}
			uint num16;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num16), 0.5f, 1f);
			Vector3 vector3;
			float z3 = vector3.z;
			GameObject gameObject = GameAPP.particlePrefab[11];
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num5, identityQuaternion, transform);
		}
		global::UnityEngine.Object.Destroy(transform);
		if (transform.TryGetComponent<SpriteRenderer>(num))
		{
		}
		IL_0300:
		if (reason != this.dieReason)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06002494 RID: 9364 RVA: 0x000BF0F4 File Offset: 0x000BD2F4
	[Token(Token = "0x6002494")]
	[Address(RVA = "0x59E200", Offset = "0x59C800", VA = "0x18059E200")]
	private void RemoveFromLink()
	{
		Zombie zombie = this.pre;
		int num = 0;
		if (zombie == num)
		{
			Zombie zombie2 = this.next;
			int num2 = 0;
			if (zombie2 == num2)
			{
				bool flag = this.board.zombieHead.Remove(this);
			}
		}
		Zombie zombie3 = this.pre;
		int num3 = 0;
		if (zombie3 != num3)
		{
			Zombie zombie4 = this.next;
			int num4 = 0;
			if (zombie4 == num4)
			{
				this.pre.next = (ulong)0L;
			}
		}
		Zombie zombie5 = this.pre;
		int num5 = 0;
		if (zombie5 == num5)
		{
			Zombie zombie6 = this.next;
			int num6 = 0;
			if (zombie6 != num6)
			{
				bool flag2 = this.board.zombieHead.Remove(this);
				this.next.pre = (ulong)0L;
				List<Zombie> zombieHead = this.board.zombieHead;
			}
		}
		Zombie zombie7 = this.pre;
		int num7 = 0;
		if (zombie7 != num7)
		{
			Zombie zombie8 = this.next;
			int num8 = 0;
			if (zombie8 != num8)
			{
				Zombie zombie9 = this.pre;
				Zombie zombie10 = this.next;
				zombie9.next = zombie10;
				Zombie zombie11 = this.next;
				Zombie zombie12 = this.pre;
				zombie11.pre = zombie12;
			}
		}
		Dictionary<ZombieType, List<Zombie>> zombieHeads = this.board.zombieHeads;
		bool flag3;
		if (flag3)
		{
		}
	}

	// Token: 0x06002495 RID: 9365 RVA: 0x000BF250 File Offset: 0x000BD450
	[Token(Token = "0x6002495")]
	[Address(RVA = "0x5988C0", Offset = "0x596EC0", VA = "0x1805988C0")]
	private void EmberExplode()
	{
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			LayerMask layerMask;
			int mask = layerMask.m_Mask;
			bool flag;
			if (layerMask != 0 && flag)
			{
				if (flag)
				{
					num++;
				}
				bool flag2;
				if (flag2)
				{
				}
			}
			num++;
		}
		uint num3;
		GameAPP.PlaySound((int)num3, 0.2f, 1f);
	}

	// Token: 0x06002496 RID: 9366 RVA: 0x000BF2C8 File Offset: 0x000BD4C8
	[Token(Token = "0x6002496")]
	[Address(RVA = "0x59BF10", Offset = "0x59A510", VA = "0x18059BF10")]
	public void JalaedExplode(bool jala = true, int damage = 100, bool ob = false)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
		LayerMask zombieLayer = this.zombieLayer;
		int num = 0;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag2;
			if (flag2)
			{
				int num3 = 0;
				bool flag3;
				if (flag3 && !this.isMindControlled)
				{
					if (18446744073709551604UL <= (ulong)12L)
					{
					}
					if (num3 == 44 || jala)
					{
					}
				}
			}
			num2++;
		}
		uint num4;
		GameAPP.PlaySound((int)num4, 0.2f, 1f);
		if (!ob)
		{
			return;
		}
		ParticleManager instance = ParticleManager.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06002497 RID: 9367 RVA: 0x000BF360 File Offset: 0x000BD560
	[Token(Token = "0x6002497")]
	[Address(RVA = "0x596840", Offset = "0x594E40", VA = "0x180596840")]
	private void DropGardenPlant()
	{
		this.board.droppedGardenPlant = true;
		GameObject[] itemPrefab = GameAPP.itemPrefab;
		Transform axis = this.axis;
		GameObject gameObject = itemPrefab[28];
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		Transform transform2 = gameObject2.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform transform3 = gameObject2.transform;
		float boardMaxX = this.board.boardMaxX;
		Transform transform4 = gameObject2.transform;
		Vector3 vector3;
		if (this.board.boardMinY > vector3.y)
		{
		}
		Transform transform5 = gameObject2.transform;
	}

	// Token: 0x06002498 RID: 9368 RVA: 0x000BF404 File Offset: 0x000BD604
	[Token(Token = "0x6002498")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "28")]
	protected virtual void DieEvent(int reason = 0)
	{
	}

	// Token: 0x06002499 RID: 9369 RVA: 0x000BF414 File Offset: 0x000BD614
	[Token(Token = "0x6002499")]
	[Address(RVA = "0x593BB0", Offset = "0x5921B0", VA = "0x180593BB0", Slot = "29")]
	protected virtual void BodyTakeDamage(int theDamage)
	{
		do
		{
			int num = this.theHealth;
			num -= theDamage;
			this.theHealth = num;
			if (!this.loseHand)
			{
				int num2 = this.theMaxHealth;
				num2 += num2;
				GameObject gameObject = this.theSecondArmor;
				int num3 = 0;
				if (gameObject == num3)
				{
					this.loseHand = true;
					uint num4;
					GameAPP.PlaySound((int)num4, 0.5f, 1f);
					GameObject gameObject2 = base.gameObject;
					this.FindAndDestoryZombieHand(gameObject2);
					GameObject gameObject3 = base.gameObject;
					this.FindAndReplaceArmUpperSprite(gameObject3);
					int num5 = 0;
					int num6 = 0;
					int childCount = base.transform.childCount;
					if (num6 < childCount)
					{
						if (string.Equals(base.transform.GetChild(num5).name, "LoseArm"))
						{
							Transform child = base.transform.GetChild(num5);
							this.AnimLoseActive(child);
						}
						num5++;
						Transform transform = base.transform;
					}
				}
			}
			if (this.beforeDying)
			{
				return;
			}
			this.beforeDying = true;
			this.LoseHeadEvent();
			uint num7;
			GameAPP.PlaySound((int)num7, 0.5f, 1f);
			GameObject gameObject4 = base.gameObject;
			this.FindAndDestoryZombieHead(gameObject4);
			int num8 = 0;
			int num9 = 0;
			int childCount2 = base.transform.childCount;
			if (num9 >= childCount2)
			{
				break;
			}
			if (string.Equals(base.transform.GetChild(num8).name, "LoseHead"))
			{
				Transform child2 = base.transform.GetChild(num8);
				this.AnimLoseActive(child2);
			}
			num8++;
		}
		while (base.transform != 0);
		GameObject gameObject5 = this.theSecondArmor;
		int num10 = 0;
		if (gameObject5 != num10)
		{
			this.SecondArmorFall();
			this.theSecondArmorHealth = (int)((ulong)0L);
			this.theSecondArmorType = (Zombie.SecondArmorType)((ulong)0L);
			this.theSecondArmor = (ulong)0L;
		}
	}

	// Token: 0x0600249A RID: 9370 RVA: 0x000BF5D4 File Offset: 0x000BD7D4
	[Token(Token = "0x600249A")]
	[Address(RVA = "0x59BE50", Offset = "0x59A450", VA = "0x18059BE50", Slot = "30")]
	protected virtual bool Instead(int damage)
	{
		List<Zombie> certainZombies = global::Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)219));
		return true;
	}

	// Token: 0x0600249B RID: 9371 RVA: 0x000BF600 File Offset: 0x000BD800
	[Token(Token = "0x600249B")]
	[Address(RVA = "0x5A0BD0", Offset = "0x59F1D0", VA = "0x1805A0BD0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		this.flashTime = 0.2f;
		if (theDamage != 0)
		{
			int num = 0;
			bool flag;
			bool flag2;
			if ((this.isMindControlled ? 1 : 0) == num && !this.Instead(theDamage) && (!flag || this.takeDamageTimes > 50) && flag2)
			{
				if (this.lastMaxDamage == num)
				{
					CancellationToken cancellationTokenOnDestroy = this.GetCancellationTokenOnDestroy();
					Action action = delegate
					{
						this.lastMaxDamage = (int)((ulong)0L);
					};
					int num2 = 0;
					int num3 = 0;
					ulong num4;
					TimePeriod.StartPeriod(0.2f, cancellationTokenOnDestroy, num3, num2, action, num != 0, (int)num4);
				}
				int num5 = this.lastMaxDamage;
				if (theDamage <= num5)
				{
					return;
				}
				this.lastMaxDamage = theDamage;
			}
			int num6;
			if (num6 != 0)
			{
				this.OnTakeDamage();
				int num7 = num6;
				this.lastTakeDamageDuring = (float)num;
				if ((this.isMindControlled ? 1 : 0) == num)
				{
					bool flag3;
					if (!flag3)
					{
						DamageReporter damageReporter = this.board.damageReporter;
						if (num7 != 14)
						{
							DamageReporter damageReporter2 = this.board.damageReporter;
							AdvantureData data = AdvantureConfig.data;
							bool flag4;
							bool flag5;
							if (flag4 || flag5)
							{
								float num8 = this * 0.3f;
								DamageReporter damageReporter3 = this.board.damageReporter;
							}
							AdvantureData data2 = AdvantureConfig.data;
							bool flag6;
							if (!flag6)
							{
								goto IL_013B;
							}
							int num9 = this.theSecondArmorMaxHealth;
							int num10 = this.theSecondArmorHealth;
							uint num11;
							num9 -= (int)num11;
							if (num10 < num9)
							{
								DamageReporter damageReporter4 = this.board.damageReporter;
								goto IL_013B;
							}
							goto IL_013B;
						}
					}
					Board board = this.board;
					throw new NullReferenceException();
				}
				IL_013B:
				if (this.theHealth < num)
				{
					this.theHealth = num;
				}
				this.UpdateHealthText();
			}
		}
	}

	// Token: 0x0600249C RID: 9372 RVA: 0x000BF770 File Offset: 0x000BD970
	[Token(Token = "0x600249C")]
	[Address(RVA = "0x592900", Offset = "0x590F00", VA = "0x180592900")]
	public void ApplyDamage(DamageType theDamageType, int dmg)
	{
		for (;;)
		{
			BoardStatistics boardStatistics = this.board.boardStatistics;
			int num = theDamageType - DamageType.NormalAll;
			int num2 = 0;
			if (num <= 13)
			{
				break;
			}
			GameObject gameObject = this.theSecondArmor;
			while (num2 != 0)
			{
			}
			int num3 = 0;
			if (gameObject != num3)
			{
				int num4 = this.SecondArmorTakeDamage(dmg);
			}
			GameObject gameObject2 = this.theFirstArmor;
			int num5 = 0;
			if (gameObject2 != num5)
			{
				while (dmg == 0)
				{
				}
				if (this.theFirstArmorHealth < dmg)
				{
					goto Block_8;
				}
			}
		}
		int num6 = theDamageType - DamageType.NormalAll;
		GameObject gameObject3 = this.theSecondArmor;
		int num7 = 0;
		if (gameObject3 != num7)
		{
			int num8 = this.SecondArmorTakeDamage(dmg);
		}
		GameObject gameObject4 = this.theFirstArmor;
		int num9 = 0;
		if (gameObject4 != num9)
		{
			int num10 = this.FirstArmorTakeDamage(dmg);
		}
		if (dmg != 0)
		{
			this.BodyTakeDamage(dmg);
		}
		ulong num11;
		if (num11 != (ulong)0L)
		{
			this.SetCarred();
		}
		return;
		Block_8:
		uint num12;
		this.Die((int)num12);
		GameObject gameObject5 = this.theFirstArmor;
		int num13 = 0;
		if (gameObject5 != num13)
		{
			int num14 = this.FirstArmorTakeDamage(dmg);
		}
		while (dmg == 0)
		{
		}
		GameObject gameObject6 = this.theSecondArmor;
		int num15 = 0;
		if (gameObject6 != num15)
		{
			int num16 = this.SecondArmorTakeDamage(dmg);
		}
		GameObject gameObject7 = this.theFirstArmor;
		int num17 = 0;
		if (gameObject7 != num17)
		{
			int num18 = this.FirstArmorTakeDamage(dmg);
		}
		this.BodyTakeDamage(dmg);
		throw new NullReferenceException();
	}

	// Token: 0x0600249D RID: 9373 RVA: 0x000BF8EC File Offset: 0x000BDAEC
	[Token(Token = "0x600249D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "31")]
	protected virtual void OnDodge()
	{
	}

	// Token: 0x0600249E RID: 9374 RVA: 0x000BF8FC File Offset: 0x000BDAFC
	[Token(Token = "0x600249E")]
	[Address(RVA = "0x59A940", Offset = "0x598F40", VA = "0x18059A940", Slot = "32")]
	public virtual int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		while (theDamage > 0)
		{
			int difficulty = GameAPP.config.difficulty;
			TravelMgr instance = TravelMgr.Instance;
			if (!this.isMindControlled)
			{
				bool flag;
				if (flag && flag)
				{
					this.OnDodge();
				}
				if (theDamage > 100)
				{
					this.hugeDamage = 1f;
				}
				float num2;
				float num = num2 * this.takeDmgMultiplier;
				float travelAdder = this.GetTravelAdder(instance);
				int num3 = 0;
				if (this.fragile)
				{
				}
				if (SingleBuffManager.CheckBuff(SingleBuffManager.BuffType.Damage))
				{
				}
				bool flag2;
				if (flag2)
				{
					bool flag3;
					if (!flag3 || this.ultiEmbered)
					{
					}
					bool flag4;
					if (flag4)
					{
					}
					TravelData data = instance.data;
				}
				Board board = this.board;
				if (RogueManager.Instance.leaderType == LeaderType.SnowGatlingPuff)
				{
					Board board2 = this.board;
				}
				if (theDamageType == DamageType.Squash)
				{
					AdvantureData data2 = AdvantureConfig.data;
					bool flag5;
					if (flag5)
					{
					}
				}
				if (instance.LuckyStrike > (float)num3)
				{
					float num4 = global::UnityEngine.Random.Range((float)0, 1f);
					if (instance.LuckyStrike > num4)
					{
					}
				}
				float damageAmplification = instance.DamageAmplification;
				TravelData data3 = instance.data;
				float num8;
				if (!fix)
				{
					Board board3 = this.board;
					float num6;
					float num5 = num6 * board3.zombieDefenseMultiplier;
					num5 = this.DamageMultiplier;
					if (difficulty == 4)
					{
						continue;
					}
					float num7;
					if (difficulty == 5)
					{
						num7 = num5 * 0.4f * 0.7f;
					}
					if (!global::Lawnf.TravelCurse() && !TravelMgr.Instance.data.invest_challenge)
					{
						HashSet<EveZombieBuff> hashSet = this.eveBuffs;
						bool flag6;
						if (!flag6)
						{
							goto IL_0179;
						}
					}
					num8 = num7 * 0.5f;
				}
				IL_0179:
				bool flag7;
				if (!flag7 || num8 <= 1800f)
				{
					goto IL_01B1;
				}
			}
			int num9 = 0;
			if (instance != num9)
			{
				List<AdvBuff> advBuffs = instance.data.advBuffs;
				bool flag8;
				if (flag8)
				{
				}
			}
			float damageMultiplier = this.DamageMultiplier;
			IL_01B1:
			bool flag9;
			if (!flag9)
			{
				break;
			}
			Plant controledPlant = this.board.controledPlant;
			int num10 = 0;
			if (controledPlant != num10)
			{
				Plant controledPlant2 = this.board.controledPlant;
				break;
			}
			break;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600249F RID: 9375 RVA: 0x000BFAF0 File Offset: 0x000BDCF0
	[Token(Token = "0x600249F")]
	[Address(RVA = "0x59CC10", Offset = "0x59B210", VA = "0x18059CC10")]
	private void OnTakeDamage()
	{
		if (this.fireFlyedCount > 0)
		{
			if (this.fireFlyedCount == 0)
			{
				global::UnityEngine.Object.Destroy(this.fireFly);
			}
			Transform axis = this.axis;
			CreateItem instance = CreateItem.Instance;
			Vector3 vector;
			float z = vector.z;
		}
		HashSet<EveZombieBuff> eveZombieBuffs = this.board.eveZombieBuffs;
		bool flag;
		uint num;
		if (flag && global::UnityEngine.Random.Range(0, (int)num) == 1)
		{
			int num2 = this.theZombieRow;
			List<Plant> plantsByRow = global::Lawnf.GetPlantsByRow(this.board, num2);
			Func<Plant, int> func;
			if (Zombie.<>c.<>9__167_0 == 0)
			{
				Zombie.<>c.<>9__167_0 = func;
			}
			Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderByDescending<Plant, int>(plantsByRow, func));
			int num3 = 0;
			if (plant != num3)
			{
				uint num4;
				plant.RealTakeDamage((int)num4);
			}
		}
		if (this.takeDamageTimes > 10)
		{
			HashSet<EveZombieBuff> hashSet = this.eveBuffs;
			bool flag2;
			if (flag2)
			{
				HashSet<EveZombieBuff> hashSet2 = this.eveBuffs;
				float num5 = this.theOriginSpeed;
				this.theOriginSpeed = num5;
			}
		}
	}

	// Token: 0x060024A0 RID: 9376 RVA: 0x000BFBD4 File Offset: 0x000BDDD4
	[Token(Token = "0x60024A0")]
	[Address(RVA = "0x59B5C0", Offset = "0x599BC0", VA = "0x18059B5C0")]
	private float GetTravelAdder(TravelMgr travelMgr)
	{
		if (travelMgr.data.advBuffs.Contains((uint)1009))
		{
		}
		if (travelMgr.data.advBuffs.Contains((uint)2007))
		{
		}
		if (travelMgr.data.advBuffs.Contains((uint)2006))
		{
			float num = this.lastTakeDamageDuring;
		}
		bool flag = travelMgr.data.advBuffs.Contains((uint)6005);
		if (!flag || !flag)
		{
		}
		if (travelMgr.data.advBuffs.Contains((uint)5003))
		{
		}
		if (travelMgr.data.advBuffs.Contains((uint)5000))
		{
			int num2 = (int)this.theZombieType;
			bool flag2;
			if (flag2)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060024A1 RID: 9377 RVA: 0x000BFC9C File Offset: 0x000BDE9C
	[Token(Token = "0x60024A1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "33")]
	protected virtual void LoseHeadEvent()
	{
	}

	// Token: 0x060024A2 RID: 9378 RVA: 0x000BFCAC File Offset: 0x000BDEAC
	[Token(Token = "0x60024A2")]
	[Address(RVA = "0x59E5F0", Offset = "0x59CBF0", VA = "0x18059E5F0", Slot = "34")]
	protected virtual void SecondArmorFall()
	{
		Transform transform = base.transform.Find("SAF");
		int num = 0;
		if (transform != num)
		{
			GameObject gameObject = transform.gameObject;
			gameObject.SetActive(true);
			ParticleSystemRenderer component = gameObject.GetComponent<ParticleSystemRenderer>();
			int num2 = this.theZombieRow;
			string text = string.Format("zombie{0}", component);
			component.sortingLayerName = text;
			ParticleSystemRenderer component2 = gameObject.GetComponent<ParticleSystemRenderer>();
			int num3 = this.sortingGroup.sortingOrder + 1;
			component2.sortingOrder = num3;
			ParticleSystem.MainModule main = gameObject.GetComponent<ParticleSystem>().main;
			List<Transform> plane = this.board.plane;
			int num4 = this.theZombieRow;
			Transform transform2 = plane[num4];
			Board board = this.board;
			Transform transform3 = gameObject.transform;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x060024A3 RID: 9379 RVA: 0x000BFD7C File Offset: 0x000BDF7C
	[Token(Token = "0x60024A3")]
	[Address(RVA = "0x598EA0", Offset = "0x5974A0", VA = "0x180598EA0")]
	private void FindAndDestoryZombieHand(GameObject obj)
	{
		int num;
		do
		{
			num = 0;
			if (obj.CompareTag("ZombieHand"))
			{
				break;
			}
			IEnumerator enumerator = obj.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				GameObject gameObject;
				this.FindAndDestoryZombieHand(gameObject);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		global::UnityEngine.Object.Destroy(obj);
	}

	// Token: 0x060024A4 RID: 9380 RVA: 0x000BFDF0 File Offset: 0x000BDFF0
	[Token(Token = "0x60024A4")]
	[Address(RVA = "0x599110", Offset = "0x597710", VA = "0x180599110")]
	protected void FindAndDestoryZombieHead(GameObject obj)
	{
		int num;
		do
		{
			num = 0;
			if (obj.CompareTag("ZombieHead") || obj.CompareTag("ZombieJaw"))
			{
				break;
			}
			IEnumerator enumerator = obj.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				GameObject gameObject;
				this.FindAndDestoryZombieHead(gameObject);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		global::UnityEngine.Object.Destroy(obj);
	}

	// Token: 0x060024A5 RID: 9381 RVA: 0x000BFE70 File Offset: 0x000BE070
	[Token(Token = "0x60024A5")]
	[Address(RVA = "0x592580", Offset = "0x590B80", VA = "0x180592580", Slot = "35")]
	protected virtual void AnimLoseActive(Transform obj)
	{
		obj.gameObject.SetActive(true);
		Board board = this.board;
		Transform axis = this.axis;
		ParticleSystem.MainModule main = obj.gameObject.GetComponent<ParticleSystem>().main;
		Board board2 = this.board;
		ParticleSystem.MainModule main2 = obj.gameObject.GetComponent<ParticleSystem>().main;
		List<Transform> plane = this.board.plane;
		int num = this.theZombieRow;
		Transform transform = plane[num];
		ParticleSystemRenderer component = obj.gameObject.GetComponent<ParticleSystemRenderer>();
		int num2 = this.theZombieRow;
		string text = string.Format("zombie{0}", component);
		component.sortingLayerName = text;
		int num3 = this.sortingGroup.sortingOrder + 1;
		component.sortingOrder = num3;
		ZombieHead zombieHead = obj.AddComponent<ZombieHead>();
		Transform transform2 = obj.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform3 = obj.transform;
		Transform transform4 = this.board.transform;
		transform3.parentInternal = transform4;
		Transform transform5 = obj.transform;
		Board board3 = this.board;
		Transform transform6 = obj.transform;
		Vector3 vector2;
		float z2 = vector2.z;
	}

	// Token: 0x060024A6 RID: 9382 RVA: 0x000BFF88 File Offset: 0x000BE188
	[Token(Token = "0x60024A6")]
	[Address(RVA = "0x5993B0", Offset = "0x5979B0", VA = "0x1805993B0")]
	private void FindAndReplaceArmUpperSprite(GameObject obj)
	{
		int num;
		do
		{
			num = 0;
			if (obj.CompareTag("ZombieArmUpper"))
			{
				break;
			}
			IEnumerator enumerator = obj.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				GameObject gameObject;
				this.FindAndReplaceArmUpperSprite(gameObject);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		this.ChangeArmSpirte(obj);
	}

	// Token: 0x060024A7 RID: 9383 RVA: 0x000BFFFC File Offset: 0x000BE1FC
	[Token(Token = "0x60024A7")]
	[Address(RVA = "0x594650", Offset = "0x592C50", VA = "0x180594650", Slot = "36")]
	protected virtual void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[0];
		component.sprite = sprite;
		Transform transform = arm.transform;
	}

	// Token: 0x060024A8 RID: 9384 RVA: 0x000C0034 File Offset: 0x000BE234
	[Token(Token = "0x60024A8")]
	[Address(RVA = "0x599620", Offset = "0x597C20", VA = "0x180599620")]
	private void FindJaw()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<GameObject> childs = global::Core.Lawnf.GetChilds(base.transform);
			bool flag;
			if (flag)
			{
				string text;
				if (!string.Equals(text, "Zombie_jaw"))
				{
					bool flag2;
					while (!flag2)
					{
					}
				}
				this.zombieJaw = num;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060024A9 RID: 9385 RVA: 0x000C0080 File Offset: 0x000BE280
	[Token(Token = "0x60024A9")]
	[Address(RVA = "0x59A1B0", Offset = "0x5987B0", VA = "0x18059A1B0")]
	protected void FlashUpdate()
	{
		if (this.theStatus != ZombieStatus.Dying)
		{
			float num = this.flashTime;
			int num2 = 0;
			if (num > (float)num2)
			{
				if (num > 0.2f || num > (float)num2)
				{
					float num3 = num * -30f;
					this.SetBrightness(num3);
				}
				float num4 = this.flashTime;
				this.flashTime = num4;
				if (num == (float)num2)
				{
					this.SetBrightness(1f);
				}
			}
		}
	}

	// Token: 0x060024AA RID: 9386 RVA: 0x000C00DC File Offset: 0x000BE2DC
	[Token(Token = "0x60024AA")]
	[Address(RVA = "0x59E950", Offset = "0x59CF50", VA = "0x18059E950")]
	protected void SetBrightness(float b)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x060024AB RID: 9387 RVA: 0x000C00F8 File Offset: 0x000BE2F8
	[Token(Token = "0x60024AB")]
	[Address(RVA = "0x59D160", Offset = "0x59B760", VA = "0x18059D160", Slot = "37")]
	protected virtual void PlayEatSound2()
	{
		if (!this.beforeDying && this.theStatus != ZombieStatus.Dying && this.theHealth > 0)
		{
			IDamageable damageable = this.theAttackTarget;
			if (this.CanAttack(damageable))
			{
				uint num;
				uint num2;
				GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
				IDamageable damageable2 = this.theAttackTarget;
				int num3 = 0;
				if (num3 < (int)num2)
				{
					num3 += num3;
					num3++;
				}
				if (this.theAttackTarget != 0)
				{
				}
			}
		}
	}

	// Token: 0x060024AC RID: 9388 RVA: 0x000C0174 File Offset: 0x000BE374
	[Token(Token = "0x60024AC")]
	[Address(RVA = "0x593140", Offset = "0x591740", VA = "0x180593140", Slot = "38")]
	protected virtual void AttackUpdate()
	{
		Func<IDamageable, bool> func;
		IEnumerable<IDamageable> enumerable = Enumerable.Where<IDamageable>(this.contacts, func);
		if (Enumerable.Count<IDamageable>(enumerable) != 0)
		{
			Func<IDamageable, int> <>9__180_ = Zombie.<>c.<>9__180_1;
			if (<>9__180_ == 0)
			{
				Func<IDamageable, int> func2;
				Zombie.<>c.<>9__180_1 = func2;
			}
			IDamageable damageable = Enumerable.FirstOrDefault<IDamageable>(Enumerable.OrderBy<IDamageable, int>(enumerable, <>9__180_));
			this.theAttackTarget = damageable;
			this.isAttacking = damageable != null;
			if (this.hasIsAttackingParam)
			{
				ulong num;
				this.anim.SetBool("isAttacking", num != 0UL);
			}
			return;
		}
		this.CancelAttack();
		throw new NullReferenceException();
	}

	// Token: 0x060024AD RID: 9389 RVA: 0x000C01F0 File Offset: 0x000BE3F0
	[Token(Token = "0x60024AD")]
	[Address(RVA = "0x594160", Offset = "0x592760", VA = "0x180594160", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		if (target != 0)
		{
			int num = 0;
			bool flag;
			if (!flag)
			{
				int num2 = 0;
				if (num2 < num)
				{
					num2 += num2;
					num2++;
				}
				Board board = this.board;
				BoxType boxType;
				if (boxType != BoxType.Grass)
				{
					int num3 = this.theZombieRow;
					bool flag2;
					if (!flag2)
					{
						Func<Plant, bool> func;
						if (Zombie.<>c.<>9__181_0 == 0)
						{
							Zombie.<>c.<>9__181_0 = func;
						}
						List<Plant> list;
						Plant plant = Enumerable.FirstOrDefault<Plant>(list, func);
						bool flag3 = plant;
						SortingGroup sortingGroup = plant.sortingGroup;
						if (sortingGroup > (ulong)10L)
						{
							if (sortingGroup != (ulong)12L && flag3 > true && sortingGroup != (ulong)44L)
							{
								goto IL_00A8;
							}
						}
					}
				}
			}
		}
		IL_0083:
		while (typeof(Zombie).TypeHandle == (ulong)1L)
		{
		}
		while (typeof(Zombie).TypeHandle == (ulong)10L)
		{
		}
		int num4 = this.theZombieRow;
		int num5 = this.theZombieRow;
		goto IL_00A8;
		goto IL_0083;
		IL_00A8:
		throw new NullReferenceException();
	}

	// Token: 0x060024AE RID: 9390 RVA: 0x000C02AC File Offset: 0x000BE4AC
	[Token(Token = "0x60024AE")]
	[Address(RVA = "0x59CF60", Offset = "0x59B560", VA = "0x18059CF60", Slot = "39")]
	protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			List<IDamageable> list = this.contacts;
		}
	}

	// Token: 0x060024AF RID: 9391 RVA: 0x000C02CC File Offset: 0x000BE4CC
	[Token(Token = "0x60024AF")]
	[Address(RVA = "0x59D010", Offset = "0x59B610", VA = "0x18059D010", Slot = "40")]
	protected virtual void OnTriggerExit2D(Collider2D collision)
	{
		int num = 0;
		if ((this.beforeDying ? 1 : 0) == num && this.theStatus != ZombieStatus.Dying && this.theHealth > num)
		{
			if (collision.TryGetComponent<IDamageable>(num))
			{
				bool flag = this.contacts.Remove(num);
				return;
			}
		}
		else
		{
			this.theAttackTarget = num;
			this.isAttacking = false;
		}
	}

	// Token: 0x060024B0 RID: 9392 RVA: 0x000C0324 File Offset: 0x000BE524
	[Token(Token = "0x60024B0")]
	[Address(RVA = "0x59B2D0", Offset = "0x5998D0", VA = "0x18059B2D0", Slot = "41")]
	protected virtual bool GetLadder(Plant plant)
	{
		if (this.theStatus != ZombieStatus.Flying)
		{
			GridItem ladder = plant.Ladder;
			int num = 0;
			bool flag = ladder != num;
			if (flag)
			{
				float num2 = this.ladderTime;
				int num3 = 0;
				if (!flag && (ladder != 0 || ladder != 0))
				{
					this.lastLadder = num3;
					this.lastLadder.y = num2;
					this.ladderTime = 1f;
				}
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x000C0394 File Offset: 0x000BE594
	[Token(Token = "0x60024B1")]
	[Address(RVA = "0x5945D0", Offset = "0x592BD0", VA = "0x1805945D0", Slot = "42")]
	protected virtual void CancelAttack()
	{
		this.theAttackTarget = (ulong)0L;
		this.isAttacking = false;
		if (this.hasIsAttackingParam)
		{
			Animator anim = this.anim;
			int num = 0;
			anim.SetBool("isAttacking", num != 0);
			return;
		}
	}

	// Token: 0x060024B2 RID: 9394 RVA: 0x000C03D8 File Offset: 0x000BE5D8
	[Token(Token = "0x60024B2")]
	[Address(RVA = "0x59D340", Offset = "0x59B940", VA = "0x18059D340", Slot = "43")]
	public virtual void PlayEatSound()
	{
		if (!this.beforeDying && this.theStatus != ZombieStatus.Dying && this.theHealth > 0)
		{
			IDamageable damageable = this.theAttackTarget;
			if (this.CanAttack(damageable) && damageable != 0)
			{
				bool flag;
				if (!flag)
				{
				}
				Debug.LogWarning("plant为空单target不为空");
				return;
			}
		}
	}

	// Token: 0x060024B3 RID: 9395 RVA: 0x000C0480 File Offset: 0x000BE680
	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x592CD0", Offset = "0x5912D0", VA = "0x180592CD0")]
	private void AttackBrain(Brain brain)
	{
		int num = brain.theHealth;
		brain.theHealth = num;
		uint num2;
		uint num3;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num2, (int)num3), 0.3f, 1f);
		brain.FlashOnce();
	}

	// Token: 0x060024B4 RID: 9396 RVA: 0x000C04C0 File Offset: 0x000BE6C0
	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x5933A0", Offset = "0x5919A0", VA = "0x1805933A0")]
	private void AttackZombie(Zombie zombie)
	{
		if (this.isMindControlled)
		{
			if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)1016)))
			{
			}
			if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)6006)))
			{
			}
		}
		if (!base.HasBuff((EffectType)((uint)11)) || global::Lawnf.TravelAdvanced((AdvBuff)((uint)41)))
		{
		}
	}

	// Token: 0x060024B5 RID: 9397 RVA: 0x000C0510 File Offset: 0x000BE710
	[Token(Token = "0x60024B5")]
	[Address(RVA = "0x59D770", Offset = "0x59BD70", VA = "0x18059D770", Slot = "44")]
	public virtual void PlayFallSound()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(5, 7), 0.5f, 1f);
	}

	// Token: 0x060024B6 RID: 9398 RVA: 0x000C0534 File Offset: 0x000BE734
	[Token(Token = "0x60024B6")]
	[Address(RVA = "0x595300", Offset = "0x593900", VA = "0x180595300", Slot = "45")]
	public virtual void DestoryZombie()
	{
		int num;
		Zombie.<DecreaseTransparent>d__191 <DecreaseTransparent>d__ = new Zombie.<DecreaseTransparent>d__191(num);
		num = 0;
		<DecreaseTransparent>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<DecreaseTransparent>d__);
	}

	// Token: 0x060024B7 RID: 9399 RVA: 0x000C0560 File Offset: 0x000BE760
	[Token(Token = "0x60024B7")]
	[Address(RVA = "0x595290", Offset = "0x593890", VA = "0x180595290")]
	private IEnumerator DecreaseTransparent()
	{
		int num;
		Zombie.<DecreaseTransparent>d__191 <DecreaseTransparent>d__ = new Zombie.<DecreaseTransparent>d__191(num);
		num = 0;
		<DecreaseTransparent>d__.<>4__this = this;
		throw new NullReferenceException();
	}

	// Token: 0x060024B8 RID: 9400 RVA: 0x000C0584 File Offset: 0x000BE784
	[Token(Token = "0x60024B8")]
	[Address(RVA = "0x594810", Offset = "0x592E10", VA = "0x180594810")]
	public void ChangeStatus(ZombieStatus targetStatus)
	{
		if (this.theStatus != ZombieStatus.Dying)
		{
			this.theStatus = targetStatus;
		}
	}

	// Token: 0x060024B9 RID: 9401 RVA: 0x000C05A4 File Offset: 0x000BE7A4
	[Token(Token = "0x60024B9")]
	[Address(RVA = "0x596B70", Offset = "0x595170", VA = "0x180596B70")]
	protected void DropItem()
	{
		if (this.board.boardGame == BoardGame.WheatProtection)
		{
			this.DropWheat();
		}
		Board board = this.board;
		this.DropCard();
		Board board2 = this.board;
		uint num;
		if (global::UnityEngine.Random.Range(0, (int)num) == 0)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
		}
		Board board3 = this.board;
		int num2 = 0;
		uint num3;
		if (global::UnityEngine.Random.Range(0, (int)num3) == 5000)
		{
			Transform axis2 = this.axis;
			Vector3 vector2;
			float z2 = vector2.z;
			GameObject gameObject = GameAPP.itemPrefab[9];
			Board board4 = this.board;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2;
			DroppedCard component = gameObject2.GetComponent<DroppedCard>();
			component.thePlantType = (PlantType)((ulong)234L);
			component.movingWay = num2;
			component.theSeedCost = num2;
		}
		Board board5 = this.board;
		float y;
		if (board5 == 0)
		{
			Transform axis3 = this.axis;
			CreateItem instance = CreateItem.Instance;
			Vector3 vector3;
			y = vector3.y;
			float z3 = vector3.z;
			num2++;
		}
		if (this.awardLevel > num2)
		{
			this.DropKilledAward();
		}
		Board board6 = this.board;
		if ((this.droppedSun ? 1 : 0) == num2)
		{
			this.ShootingDropSun();
		}
		if ((this.isGold ? 1 : 0) != num2)
		{
			Board board7 = this.board;
			ulong num4;
			num4 += num4;
			Board board8 = this.board;
			if (y > 1.5f)
			{
			}
			float num5;
			board8.currentRoundPoint = num5;
			ulong num6;
			this.board.GetPoint(num5, num6 != 0UL);
			Board board9 = this.board;
			ulong num7;
			PlayerShootingManager.Instance.Evolution(num7 != 0UL);
		}
	}

	// Token: 0x060024BA RID: 9402 RVA: 0x000C0724 File Offset: 0x000BE924
	[Token(Token = "0x60024BA")]
	[Address(RVA = "0x5970F0", Offset = "0x5956F0", VA = "0x1805970F0")]
	private void DropKilledAward()
	{
		GameAPP.PlaySound(66, 0.5f, 1f);
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.awardLevel;
		if (num2 == 1)
		{
			Transform axis2 = this.axis;
			CreateItem instance = CreateItem.Instance;
			Vector3 vector2;
			float z2 = vector2.z;
			num++;
			Transform axis3 = this.axis;
			CreateItem instance2 = CreateItem.Instance;
			Vector3 vector3;
			float z3 = vector3.z;
			num++;
			Transform axis4 = this.axis;
			return;
		}
		while (num2 != 2)
		{
		}
		Transform axis5 = this.axis;
		CreateItem instance3 = CreateItem.Instance;
		Vector3 vector4;
		float z4 = vector4.z;
		num++;
		Transform axis6 = this.axis;
		CreateItem instance4 = CreateItem.Instance;
		Vector3 vector5;
		float z5 = vector5.z;
		num++;
		this.board.GetPoint(1500f, true);
		throw new NullReferenceException();
	}

	// Token: 0x060024BB RID: 9403 RVA: 0x000C07F4 File Offset: 0x000BE9F4
	[Token(Token = "0x60024BB")]
	[Address(RVA = "0x5A01E0", Offset = "0x59E7E0", VA = "0x1805A01E0")]
	private void ShootingDropSun()
	{
		this.droppedSun = true;
		Transform axis = this.axis;
		CreateItem instance = CreateItem.Instance;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		uint num4;
		Vector3 vector;
		ulong num5;
		GameObject gameObject = instance.SetCoin(num3, num2, (int)num4, num, vector, num5 != 0UL);
		Transform axis2 = this.axis;
		CreateItem instance2 = CreateItem.Instance;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		uint num9;
		Vector3 vector2;
		ulong num10;
		GameObject gameObject2 = instance2.SetCoin(num8, num7, (int)num9, num6, vector2, num10 != 0UL);
		Transform axis3 = this.axis;
		CreateItem instance3 = CreateItem.Instance;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		uint num14;
		Vector3 vector3;
		ulong num15;
		GameObject gameObject3 = instance3.SetCoin(num13, num12, (int)num14, num11, vector3, num15 != 0UL);
		Board board = this.board;
		Transform axis4 = this.axis;
		CreateItem instance4 = CreateItem.Instance;
		int num16 = 0;
		int num17 = 0;
		uint num18;
		Vector3 vector4;
		ulong num19;
		GameObject gameObject4 = instance4.SetCoin(num17, num16, (int)num18, num11, vector4, num19 != 0UL);
	}

	// Token: 0x060024BC RID: 9404 RVA: 0x000C08C4 File Offset: 0x000BEAC4
	[Token(Token = "0x60024BC")]
	[Address(RVA = "0x597430", Offset = "0x595A30", VA = "0x180597430")]
	private void DropWheat()
	{
		uint num;
		if (this.board.theCurrentPlantCount > 10)
		{
			num += num;
		}
		if (global::UnityEngine.Random.Range(0, (int)num) == 0)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject = GameAPP.itemPrefab[9];
			Board board = this.board;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2;
			DroppedCard component = gameObject2.GetComponent<DroppedCard>();
			int num2 = 0;
			uint num3;
			component.thePlantType = (PlantType)num3;
			component.movingWay = num2;
			component.theSeedCost = num2;
		}
	}

	// Token: 0x060024BD RID: 9405 RVA: 0x000C0950 File Offset: 0x000BEB50
	[Token(Token = "0x60024BD")]
	[Address(RVA = "0x5960D0", Offset = "0x5946D0", VA = "0x1805960D0")]
	private void DropCardInRandomTravel()
	{
		if (global::UnityEngine.Random.Range(0, 10000) == 5000)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject = GameAPP.itemPrefab[9];
			Board board = this.board;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2;
			DroppedCard component = gameObject2.GetComponent<DroppedCard>();
			int num = 0;
			component.movingWay = num;
			component.theSeedCost = num;
			component.thePlantType = (PlantType)((ulong)234L);
		}
	}

	// Token: 0x060024BE RID: 9406 RVA: 0x000C09D0 File Offset: 0x000BEBD0
	[Token(Token = "0x60024BE")]
	[Address(RVA = "0x5962E0", Offset = "0x5948E0", VA = "0x1805962E0")]
	private void DropCard()
	{
		int avaliableCardCount = InGameUI.Instance.avaliableCardCount;
		int theCurrentPlantCount = this.board.theCurrentPlantCount;
		uint num;
		if (global::UnityEngine.Random.Range(0, (int)num) == 0)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject = GameAPP.itemPrefab[9];
			Board board = this.board;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2;
			DroppedCard component = gameObject2.GetComponent<DroppedCard>();
			Board board2 = this.board;
			int random = (int)ListExtensions.GetRandom<PlantType>(Enumerable.ToList<PlantType>(CoreEnums.baiscPlants));
			bool flag;
			while (flag)
			{
			}
			List<PlantType> allPlantTypes = global::Lawnf.GetAllPlantTypes();
			Predicate<PlantType> predicate;
			if (Zombie.<>c.<>9__198_0 == 0)
			{
				predicate = delegate(PlantType p)
				{
					bool flag2;
					bool flag3;
					return flag2 || p == PlantType.PresentZombie || flag3;
				};
				Zombie.<>c.<>9__198_0 = predicate;
			}
			int num2 = allPlantTypes.RemoveAll(predicate);
			int num3 = allPlantTypes._size;
			num3 = global::UnityEngine.Random.Range(0, num3);
			int num4 = allPlantTypes[num3];
			if (num4 > 1067)
			{
				if (num4 == 1070)
				{
				}
				uint num5;
				if (num5 == (uint)1120)
				{
				}
				uint num6;
				if (num6 != (uint)1247)
				{
					goto IL_0109;
				}
			}
			uint num7;
			if (num7 == (uint)1027)
			{
			}
			uint num8;
			if (num8 == (uint)1060)
			{
			}
			IL_0109:
			int num9 = 0;
			uint num10;
			component.thePlantType = (PlantType)num10;
			component.movingWay = num9;
			component.theSeedCost = num9;
		}
	}

	// Token: 0x060024BF RID: 9407 RVA: 0x000C0B0C File Offset: 0x000BED0C
	[Token(Token = "0x60024BF")]
	[Address(RVA = "0x592420", Offset = "0x590A20", VA = "0x180592420")]
	public void AdjustPosition(Vector3 position)
	{
		Transform axis = this.axis;
		int num = 0;
		if (axis != num)
		{
			Transform axis2 = this.axis;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x060024C0 RID: 9408 RVA: 0x000C0B4C File Offset: 0x000BED4C
	[Token(Token = "0x60024C0")]
	[Address(RVA = "0x5A1120", Offset = "0x59F720", VA = "0x1805A1120", Slot = "46")]
	public virtual void UpdateColor(Zombie.ZombieColor zombieColor = Zombie.ZombieColor.Default)
	{
		int num = 0;
		if (zombieColor == Zombie.ZombieColor.Default)
		{
			this.colorsBuffers._size = num;
			bool flag;
			if (flag)
			{
				List<Color> list = this.colorsBuffers;
				int size = list._size;
				Color color;
				list._size = color;
				color += color;
			}
			bool flag2;
			if (flag2)
			{
				List<Color> list2 = this.colorsBuffers;
				int size2 = list2._size;
				Color color2;
				list2._size = color2;
				color2 += color2;
			}
			int num2 = 0;
			bool flag3;
			if (base.HasBuff((EffectType)num2) || flag3)
			{
				List<Color> list3 = this.colorsBuffers;
				int size3 = list3._size;
				Color color3;
				list3._size = color3;
				color3 += color3;
			}
			bool flag4;
			if (flag4)
			{
				List<Color> list4 = this.colorsBuffers;
				int size4 = list4._size;
				Color color4;
				list4._size = color4;
				color4 += color4;
			}
			if ((this.isGold ? 1 : 0) != num)
			{
				List<Color> list5 = this.colorsBuffers;
				int size5 = list5._size;
				Color color5;
				list5._size = color5;
				color5 += color5;
			}
			if ((this.isDoom ? 1 : 0) != num || (this.garlicDoom ? 1 : 0) != num)
			{
				List<Color> list6 = this.colorsBuffers;
				int size6 = list6._size;
				Color color6;
				list6._size = color6;
				color6 += color6;
			}
			if ((this.isMindControlled ? 1 : 0) != num)
			{
				List<Color> list7 = this.colorsBuffers;
				int size7 = list7._size;
				Color color7;
				list7._size = color7;
				color7 += color7;
			}
			List<Color> list8 = this.colorsBuffers;
			if (list8 != 0 && list8._size > 0)
			{
				num++;
			}
		}
		Color color8 = this.currentColor;
		if (num == 0)
		{
			List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
			SpriteRenderer spriteRenderer = this.spriteRenderers[num];
			int num3 = 0;
			if (spriteRenderer != num3)
			{
				this.spriteRenderers[num].color = num;
			}
			List<SpriteRenderer> spriteRenderers2 = this.spriteRenderers;
			num++;
		}
	}

	// Token: 0x060024C1 RID: 9409 RVA: 0x000C0D0C File Offset: 0x000BEF0C
	[Token(Token = "0x60024C1")]
	[Address(RVA = "0x59B3D0", Offset = "0x5999D0", VA = "0x18059B3D0")]
	private Color GetMixColor(List<Color> colors)
	{
		int num = 0;
		num++;
		return default(Color);
	}

	// Token: 0x060024C2 RID: 9410 RVA: 0x000C0D28 File Offset: 0x000BEF28
	[Token(Token = "0x60024C2")]
	[Address(RVA = "0x59A880", Offset = "0x598E80", VA = "0x18059A880")]
	private Color GetColor(Zombie.ZombieColor colorType)
	{
		Dictionary<Zombie.ZombieColor, Color> colorDictionary = Zombie.ColorDictionary;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060024C3 RID: 9411 RVA: 0x000C0D50 File Offset: 0x000BEF50
	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x59E550", Offset = "0x59CB50", VA = "0x18059E550")]
	public void Scared()
	{
		float num = this.theOriginSpeed;
		this.theOriginSpeed = num;
		this.towards = (Towards)((ulong)1L);
		Transform transform = base.transform;
	}

	// Token: 0x060024C4 RID: 9412 RVA: 0x000C0D84 File Offset: 0x000BEF84
	[Token(Token = "0x60024C4")]
	[Address(RVA = "0x59C370", Offset = "0x59A970", VA = "0x18059C370")]
	protected void KillDebuff()
	{
		int num = 0;
		this.takeDamageTimes = num;
		this.lastTakeDamageDuring = (float)num;
		bool flag = base.RemoveBuff((EffectType)((uint)4));
		bool flag2 = base.RemoveBuff((EffectType)((uint)3));
		bool flag3 = base.RemoveBuff((EffectType)((uint)1));
		bool flag4 = base.RemoveBuff((EffectType)((uint)2));
		int num2 = 0;
		bool flag5 = base.RemoveBuff((EffectType)num2);
		bool flag6 = base.RemoveBuff((EffectType)((uint)10));
	}

	// Token: 0x060024C5 RID: 9413 RVA: 0x000C0DE0 File Offset: 0x000BEFE0
	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x5A1110", Offset = "0x59F710", VA = "0x1805A1110", Slot = "47")]
	public virtual void Unfreezing()
	{
		bool flag = base.RemoveBuff((EffectType)((uint)2));
	}

	// Token: 0x060024C6 RID: 9414 RVA: 0x000C0DF8 File Offset: 0x000BEFF8
	[Token(Token = "0x60024C6")]
	[Address(RVA = "0x5923C0", Offset = "0x5909C0", VA = "0x1805923C0")]
	public void AddfreezeLevel(int level, int force = 0)
	{
		this.freezeLevel = level;
		if (level != this.freezeMaxLevel)
		{
			this.freezeLevel = (int)((ulong)0L);
			if (this.freezeMaxLevel < 1000)
			{
			}
		}
	}

	// Token: 0x060024C7 RID: 9415 RVA: 0x000C0E2C File Offset: 0x000BF02C
	[Token(Token = "0x60024C7")]
	[Address(RVA = "0x5A00D0", Offset = "0x59E6D0", VA = "0x1805A00D0", Slot = "48")]
	public virtual void SetPortaled(float timer = 1.5f)
	{
		int num = (int)this.theZombieType;
		bool flag;
		if (!flag)
		{
			return;
		}
		bool flag2;
		if (!flag2)
		{
		}
	}

	// Token: 0x060024C8 RID: 9416 RVA: 0x000C0E4C File Offset: 0x000BF04C
	[Token(Token = "0x60024C8")]
	[Address(RVA = "0x59F7C0", Offset = "0x59DDC0", VA = "0x18059F7C0")]
	public void SetGold()
	{
		this.isGold = true;
	}

	// Token: 0x060024C9 RID: 9417 RVA: 0x000C0E60 File Offset: 0x000BF060
	[Token(Token = "0x60024C9")]
	[Address(RVA = "0x59F7E0", Offset = "0x59DDE0", VA = "0x18059F7E0", Slot = "49")]
	public virtual void SetJalaed()
	{
		if (this.SetEffect((EffectType)((uint)1), 1f, 1f))
		{
			bool flag = base.RemoveBuff((EffectType)((uint)2));
			bool flag2 = base.RemoveBuff((EffectType)((uint)10));
			int num = 0;
			bool flag3 = base.RemoveBuff((EffectType)num);
			bool flag4 = base.RemoveBuff((EffectType)((uint)4));
			return;
		}
	}

	// Token: 0x060024CA RID: 9418 RVA: 0x000C0EAC File Offset: 0x000BF0AC
	[Token(Token = "0x60024CA")]
	[Address(RVA = "0x59F380", Offset = "0x59D980", VA = "0x18059F380", Slot = "50")]
	public virtual void SetEmbered(bool ulti = false)
	{
		if (this.SetEffect((EffectType)((uint)3), 1f, 1f) && ulti)
		{
			this.ultiEmbered = true;
		}
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x000C0EDC File Offset: 0x000BF0DC
	[Token(Token = "0x60024CB")]
	[Address(RVA = "0x59F3D0", Offset = "0x59D9D0", VA = "0x18059F3D0", Slot = "51")]
	public virtual void SetFreeze(float time, int theFreezeLevel = 0)
	{
		while (this.theStatus != ZombieStatus.Dying)
		{
			Board board = this.board;
			bool flag;
			if (flag)
			{
				int num = this.theZombieRow;
				Transform axis = this.axis;
			}
			ulong num2;
			if (num2 == (ulong)0L)
			{
				if (num2 == (ulong)3L)
				{
					throw new NullReferenceException();
				}
				if (flag <= true)
				{
				}
				bool flag2;
				if (flag2)
				{
				}
				AdvantureData data = AdvantureConfig.data;
				bool flag3;
				if (flag3)
				{
				}
				bool flag4;
				if (flag4)
				{
					break;
				}
				break;
			}
		}
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x000C0F58 File Offset: 0x000BF158
	[Token(Token = "0x60024CC")]
	[Address(RVA = "0x5A0000", Offset = "0x59E600", VA = "0x1805A0000", Slot = "52")]
	public virtual void SetPoison(float time = 10f)
	{
		bool flag;
		if (flag)
		{
			if (this.ultiEmbered)
			{
			}
			int num;
			if (num == 0 || num == 0 || num == 1)
			{
			}
		}
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x000C0F80 File Offset: 0x000BF180
	[Token(Token = "0x60024CD")]
	[Address(RVA = "0x592200", Offset = "0x590800", VA = "0x180592200", Slot = "53")]
	public virtual void AddPoisonLevel()
	{
		if (!global::Lawnf.TravelUltimate((UltiBuff)((uint)13)))
		{
			bool flag = this.SetEffect((EffectType)((uint)4), 5f, 1f);
			return;
		}
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x000C0FAC File Offset: 0x000BF1AC
	[Token(Token = "0x60024CE")]
	[Address(RVA = "0x59EFC0", Offset = "0x59D5C0", VA = "0x18059EFC0", Slot = "54")]
	public virtual void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
		ulong num2;
		do
		{
			Board board = this.board;
			bool flag;
			if (flag)
			{
				int num = this.theZombieRow;
				Transform axis = this.axis;
			}
		}
		while (num2 != (ulong)0L);
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
	}

	// Token: 0x060024CF RID: 9423 RVA: 0x000C1008 File Offset: 0x000BF208
	[Token(Token = "0x60024CF")]
	[Address(RVA = "0x59F860", Offset = "0x59DE60", VA = "0x18059F860", Slot = "55")]
	public virtual void SetKelped(float time, bool land = false)
	{
		bool flag;
		if (flag)
		{
			if (land)
			{
			}
			if (this.kelpTimes > 5)
			{
			}
			if (!land)
			{
				Transform axis = this.axis;
				CreatePlant instance = CreatePlant.Instance;
			}
		}
	}

	// Token: 0x060024D0 RID: 9424 RVA: 0x000C1048 File Offset: 0x000BF248
	[Token(Token = "0x60024D0")]
	[Address(RVA = "0x5A2740", Offset = "0x5A0D40", VA = "0x1805A2740")]
	public void Warm()
	{
		bool flag = base.RemoveBuff((EffectType)((uint)2));
		bool flag2 = base.RemoveBuff((EffectType)((uint)10));
		int num = 0;
		bool flag3 = base.RemoveBuff((EffectType)num);
		bool flag4 = base.RemoveBuff((EffectType)((uint)4));
	}

	// Token: 0x060024D1 RID: 9425 RVA: 0x000C107C File Offset: 0x000BF27C
	[Token(Token = "0x60024D1")]
	[Address(RVA = "0x593FA0", Offset = "0x5925A0", VA = "0x180593FA0", Slot = "56")]
	public virtual void Buttered(float time = 4f, bool sprite = true)
	{
		if (!this.beforeDying)
		{
			ZombieType zombieType = this.theZombieType;
			if (zombieType > ZombieType.ZombieBoss2 && zombieType > ZombieType.UltimateJacksonDriver)
			{
				if (zombieType == ZombieType.CherrySubmarine || typeof(AdvantureConfig).TypeHandle <= (ulong)4L)
				{
					return;
				}
			}
			else
			{
				while (typeof(AdvantureConfig).TypeHandle == 0)
				{
				}
				if (typeof(AdvantureConfig).TypeHandle != 0)
				{
					while (typeof(AdvantureConfig).TypeHandle == 0)
					{
					}
					if (typeof(AdvantureConfig).TypeHandle != 0)
					{
						while (typeof(AdvantureConfig).TypeHandle == (ulong)1L)
						{
						}
						while (typeof(AdvantureConfig).TypeHandle == (ulong)4294967293L)
						{
						}
					}
				}
			}
			if (typeof(AdvantureConfig).TypeHandle <= (ulong)15L)
			{
			}
			AdvantureData data = AdvantureConfig.data;
			if (sprite)
			{
			}
			bool flag;
			while (!flag)
			{
			}
			return;
		}
	}

	// Token: 0x060024D2 RID: 9426 RVA: 0x000C1118 File Offset: 0x000BF318
	[Token(Token = "0x60024D2")]
	[Address(RVA = "0x594A50", Offset = "0x593050", VA = "0x180594A50")]
	private bool CheckButtered()
	{
		ZombieType zombieType = this.theZombieType;
		if (zombieType > ZombieType.ZombieBoss2)
		{
			if (zombieType > ZombieType.UltimateJacksonDriver)
			{
				if (zombieType != ZombieType.CherrySubmarine)
				{
				}
			}
			while (zombieType == ZombieType.SuperSubmarine)
			{
			}
		}
		while (this == 0)
		{
		}
		if (this != 0)
		{
			while (this == 0)
			{
			}
			if (this != 0)
			{
				while (this == (ulong)1L)
				{
				}
			}
		}
		ZombieStatus zombieStatus = this.theStatus;
		while (zombieStatus == ZombieStatus.Pol_jump)
		{
		}
		while (zombieStatus == ZombieStatus.Bungi_awake)
		{
		}
		if (zombieStatus > ZombieStatus.Bungi_awake)
		{
			ulong num;
			num += this;
		}
		Dictionary<ZombieType, int> enermyCountDic = this.board.enermyCountDic;
		bool flag;
		if (!flag)
		{
			return flag;
		}
		bool flag2;
		return flag2;
	}

	// Token: 0x060024D3 RID: 9427 RVA: 0x000C119C File Offset: 0x000BF39C
	[Token(Token = "0x60024D3")]
	[Address(RVA = "0x5A1100", Offset = "0x59F700", VA = "0x1805A1100", Slot = "57")]
	protected virtual void UnButtered()
	{
		bool flag = base.RemoveBuff((EffectType)((uint)6));
	}

	// Token: 0x060024D4 RID: 9428 RVA: 0x000C11B4 File Offset: 0x000BF3B4
	[Token(Token = "0x60024D4")]
	[Address(RVA = "0x598670", Offset = "0x596C70", VA = "0x180598670", Slot = "58")]
	public virtual void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
		float num = this.garlicSpeed;
		if (!this.beforeDying)
		{
			int num2 = (int)this.theZombieType;
			bool flag;
			if (!flag && this.isChangingRow == flag)
			{
				ZombieStatus zombieStatus = this.theStatus;
				if (zombieStatus != ZombieStatus.Dying && zombieStatus != ZombieStatus.Polo_jump)
				{
					int num3 = 0;
					this.eatGarlic = true;
					this.garlicSpeed = (float)num3;
					int num4 = 0;
					if (plant != num4)
					{
						bool result = AdvantureConfig.data.GetResult((AdvantureLevel)((uint)52), (MissionResult)((uint)2));
						plant.FlashOnce();
						GameAPP.PlaySound(global::UnityEngine.Random.Range(8, 10), 0.3f, 1f);
						if (plant.PotType == PlantType.GarlicPot)
						{
							throw new NullReferenceException();
						}
					}
					int num5 = 0;
					IEnumerator enumerator = this.DeLayGarliced(time, withSound, num5 != 0);
					Coroutine coroutine = base.StartCoroutine(enumerator);
				}
			}
		}
	}

	// Token: 0x060024D5 RID: 9429 RVA: 0x000C1280 File Offset: 0x000BF480
	[Token(Token = "0x60024D5")]
	[Address(RVA = "0x5951E0", Offset = "0x5937E0", VA = "0x1805951E0")]
	private IEnumerator DeLayGarliced(float during, bool playSound, bool certainRow)
	{
		int num;
		Zombie.<DeLayGarliced>d__221 <DeLayGarliced>d__ = new Zombie.<DeLayGarliced>d__221(num);
		num = 0;
		<DeLayGarliced>d__.<>4__this = this;
		<DeLayGarliced>d__.during = during;
		<DeLayGarliced>d__.playSound = playSound;
		<DeLayGarliced>d__.certainRow = certainRow;
		throw new NullReferenceException();
	}

	// Token: 0x060024D6 RID: 9430 RVA: 0x000C12BC File Offset: 0x000BF4BC
	[Token(Token = "0x60024D6")]
	[Address(RVA = "0x59A250", Offset = "0x598850", VA = "0x18059A250", Slot = "59")]
	public virtual void Garliced(bool playSound = false, bool certainRow = false)
	{
		this.garlicSpeed = 1f;
		if (!this.eatGarlic && !this.isChangingRow)
		{
			int num = (int)this.theZombieType;
			bool flag;
			if (!flag && this.theStatus > ZombieStatus.Dying)
			{
				SpriteRenderer spriteRenderer = this.headGarlic;
				int num2 = 0;
				if (spriteRenderer != num2)
				{
					SpriteRenderer spriteRenderer2 = this.headGarlic;
					Sprite sprite = GameAPP.spritePrefab[66];
					spriteRenderer2.sprite = sprite;
					SpriteRenderer spriteRenderer3 = this.jawGarlic;
					int num3 = 0;
					spriteRenderer3.enabled = num3 != 0;
				}
				this.CancelAttack();
				if (playSound)
				{
				}
				int avaliableRow = this.theZombieRow;
				if (certainRow)
				{
					int certainRow2 = this.GetCertainRow(avaliableRow);
				}
				avaliableRow = this.GetAvaliableRow(avaliableRow);
				this.ChangeRow(avaliableRow);
				base.Invoke("RecoverGarliced", 1.5f);
			}
		}
	}

	// Token: 0x060024D7 RID: 9431 RVA: 0x000C1398 File Offset: 0x000BF598
	[Token(Token = "0x60024D7")]
	[Address(RVA = "0x59E070", Offset = "0x59C670", VA = "0x18059E070")]
	private void RecoverGarliced()
	{
		SpriteRenderer spriteRenderer = this.headGarlic;
		int num = 0;
		if (spriteRenderer != num)
		{
			SpriteRenderer spriteRenderer2 = this.headGarlic;
			Sprite sprite = this.headOriginalSprite;
			spriteRenderer2.sprite = sprite;
			this.jawGarlic.enabled = true;
		}
	}

	// Token: 0x060024D8 RID: 9432 RVA: 0x000C13E0 File Offset: 0x000BF5E0
	[Token(Token = "0x60024D8")]
	[Address(RVA = "0x5997F0", Offset = "0x597DF0", VA = "0x1805997F0")]
	private GameObject FindZombieHead()
	{
		for (;;)
		{
			int num = 0;
			List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					bool flag2;
					while (!flag2)
					{
					}
					string text;
					if (text.Contains("ead"))
					{
						break;
					}
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x060024D9 RID: 9433 RVA: 0x000C1440 File Offset: 0x000BF640
	[Token(Token = "0x60024D9")]
	[Address(RVA = "0x59FA50", Offset = "0x59E050", VA = "0x18059FA50")]
	protected void SetMaskLayer()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x060024DA RID: 9434 RVA: 0x000C1474 File Offset: 0x000BF674
	[Token(Token = "0x60024DA")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "60")]
	public virtual GameObject DropArmor()
	{
		return null;
	}

	// Token: 0x060024DB RID: 9435 RVA: 0x000C1484 File Offset: 0x000BF684
	[Token(Token = "0x60024DB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "61")]
	protected virtual void FirstArmorBroken()
	{
	}

	// Token: 0x060024DC RID: 9436 RVA: 0x000C1494 File Offset: 0x000BF694
	[Token(Token = "0x60024DC")]
	[Address(RVA = "0x599B90", Offset = "0x598190", VA = "0x180599B90", Slot = "62")]
	protected virtual void FirstArmorFall()
	{
		Transform transform = base.transform.Find("FAF");
		int num = 0;
		if (transform != num)
		{
			GameObject gameObject = transform.gameObject;
			gameObject.SetActive(true);
			ParticleSystemRenderer component = gameObject.GetComponent<ParticleSystemRenderer>();
			int num2 = this.theZombieRow;
			string text = string.Format("zombie{0}", component);
			component.sortingLayerName = text;
			ParticleSystemRenderer component2 = gameObject.GetComponent<ParticleSystemRenderer>();
			int num3 = this.sortingGroup.sortingOrder + 1;
			component2.sortingOrder = num3;
			ParticleSystem.MainModule main = gameObject.GetComponent<ParticleSystem>().main;
			List<Transform> plane = this.board.plane;
			int num4 = this.theZombieRow;
			Transform transform2 = plane[num4];
			Board board = this.board;
			Transform transform3 = gameObject.transform;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x060024DD RID: 9437 RVA: 0x000C1564 File Offset: 0x000BF764
	[Token(Token = "0x60024DD")]
	[Address(RVA = "0x599E20", Offset = "0x598420", VA = "0x180599E20", Slot = "63")]
	protected virtual int FirstArmorTakeDamage(int theDamage)
	{
		int num = this.theFirstArmorHealth;
		global::UnityEngine.Object.Destroy(this.theFirstArmor);
		this.FirstArmorFall();
		int num2 = 0;
		this.theFirstArmorHealth = num2;
		this.theFirstArmorType = (Zombie.FirstArmorType)num2;
		this.theFirstArmor = num2;
		return theDamage;
	}

	// Token: 0x060024DE RID: 9438 RVA: 0x000C15A8 File Offset: 0x000BF7A8
	[Token(Token = "0x60024DE")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "64")]
	protected virtual void SecondArmorBroken()
	{
	}

	// Token: 0x060024DF RID: 9439 RVA: 0x000C15B8 File Offset: 0x000BF7B8
	[Token(Token = "0x60024DF")]
	[Address(RVA = "0x59E880", Offset = "0x59CE80", VA = "0x18059E880", Slot = "65")]
	protected virtual int SecondArmorTakeDamage(int theDamage)
	{
		int num = this.theSecondArmorHealth;
		global::UnityEngine.Object.Destroy(this.theSecondArmor);
		this.SecondArmorFall();
		int num2 = 0;
		this.theSecondArmorHealth = num2;
		this.theSecondArmorType = (Zombie.SecondArmorType)num2;
		this.theSecondArmor = num2;
		return theDamage;
	}

	// Token: 0x060024E0 RID: 9440 RVA: 0x000C15FC File Offset: 0x000BF7FC
	[Token(Token = "0x60024E0")]
	[Address(RVA = "0x594BC0", Offset = "0x5931C0", VA = "0x180594BC0", Slot = "66")]
	protected virtual Plant CrashEntity(Collider2D collision, bool inWater = false, float knockBack = 1f)
	{
		int num = 0;
		bool flag;
		if ((this.isMindControlled ? 1 : 0) == num && flag)
		{
			bool flag2;
			if (flag2)
			{
				goto IL_00F5;
			}
			int num2 = this.theZombieRow;
			bool flag3;
			if (!flag3)
			{
				if (flag3)
				{
					GameAPP.PlaySound(77, 0.5f, 1f);
					this.KillByCaltrop();
					Transform transform = base.transform;
					int num3 = 0;
					int num4 = 0;
					transform.Translate(knockBack, (float)num4, (float)num3);
				}
				if (flag3)
				{
					ZombieType zombieType = this.theZombieType;
					if (zombieType > ZombieType.CherryCatapultZombie)
					{
						if (zombieType > ZombieType.DrownpultZombie)
						{
							while (flag3 <= true)
							{
							}
							while (flag3 <= true)
							{
							}
							while (flag3 <= true)
							{
							}
						}
						while (zombieType == ZombieType.JacksonDriver)
						{
						}
					}
					if (zombieType <= ZombieType.CatapultZombie)
					{
					}
					while (zombieType == ZombieType.CherryCatapultZombie)
					{
					}
				}
				if (inWater)
				{
					GameAPP.PlaySound(75, 0.5f, 1f);
				}
				int num5 = global::UnityEngine.Random.Range(8, 10);
			}
			Transform transform2 = base.transform;
			int num6 = 0;
			int num7 = 0;
			transform2.Translate(knockBack, (float)num7, (float)num6);
		}
		bool flag4;
		if (flag4)
		{
			int num8 = this.theZombieRow;
			bool flag5 = this.isMindControlled;
		}
		IL_00F5:
		throw new NullReferenceException();
	}

	// Token: 0x060024E1 RID: 9441 RVA: 0x000C1708 File Offset: 0x000BF908
	[Token(Token = "0x60024E1")]
	[Address(RVA = "0x59A480", Offset = "0x598A80", VA = "0x18059A480")]
	protected int GetAvaliableRow(int originalRow)
	{
		Board board2;
		int num3;
		for (;;)
		{
			Board board = this.board;
			Transform axis = this.axis;
			int num = this.theZombieRow;
			int num2;
			BoxType boxType = board.GetBoxType(num2, num);
			board2 = this.board;
			num3 = (int)boxType;
			if (originalRow != 0)
			{
				int rowNum = board2.rowNum;
				Transform axis2 = this.axis;
				if (originalRow != rowNum)
				{
					break;
				}
				int num4 = originalRow - 1;
				int num5;
				BoxType boxType2 = board2.GetBoxType(num5, num4);
				if (num3 != 1)
				{
					continue;
				}
				while (boxType2 != (BoxType)num3)
				{
				}
				if (originalRow - 1 == 1)
				{
					continue;
				}
			}
			Transform axis3 = this.axis;
			int num6;
			uint num7;
			BoxType boxType3 = board2.GetBoxType(num6, (int)num7);
			if (num3 == (int)num7 && (boxType3 == (BoxType)num7 || 0U != num7))
			{
				goto IL_0108;
			}
		}
		int num8 = originalRow - 1;
		int num9;
		BoxType boxType4 = board2.GetBoxType(num9, num8);
		Transform axis4 = this.axis;
		int num10 = (int)boxType4;
		Board board3 = this.board;
		int num11 = originalRow + 1;
		int num12;
		BoxType boxType5 = board3.GetBoxType(num12, num11);
		if (num3 == 1)
		{
			if (num10 == num3 && boxType5 == (BoxType)num3)
			{
				goto IL_00A2;
			}
			if (boxType5 != BoxType.Water)
			{
				return originalRow;
			}
		}
		if (num10 == 1)
		{
			goto IL_00AC;
		}
		while (boxType5 == BoxType.Water)
		{
		}
		IL_00A2:
		uint num14;
		int num13 = global::UnityEngine.Random.Range(0, (int)num14);
		IL_00AC:
		if (boxType5 != BoxType.Water)
		{
		}
		return originalRow;
		IL_0108:
		throw new NullReferenceException();
	}

	// Token: 0x060024E2 RID: 9442 RVA: 0x000C1824 File Offset: 0x000BFA24
	[Token(Token = "0x60024E2")]
	[Address(RVA = "0x59A6A0", Offset = "0x598CA0", VA = "0x18059A6A0")]
	protected int GetCertainRow(int originalRow)
	{
		BoxType boxType = this.board.roadType[originalRow];
		Board board = this.board;
		if (originalRow == 0)
		{
			BoxType boxType2 = board.roadType[0];
			if (boxType == BoxType.Water)
			{
				if (boxType2 != boxType)
				{
					return 0;
				}
			}
			else
			{
				while (boxType2 == BoxType.Water)
				{
				}
			}
			throw new NullReferenceException();
		}
		int rowNum = board.rowNum;
		BoxType[] roadType = board.roadType;
		if (originalRow != rowNum)
		{
			int num = originalRow - 1;
			Board board2 = this.board;
			BoxType boxType3 = roadType[num];
			BoxType[] roadType2 = board2.roadType;
			int num2 = originalRow + 1;
			BoxType boxType4 = roadType2[num2];
			int num3;
			if (boxType == BoxType.Water)
			{
				if (boxType3 == boxType)
				{
					if (boxType4 != boxType)
					{
						return originalRow;
					}
				}
				else
				{
					if (boxType4 == BoxType.Water)
					{
						return originalRow;
					}
					goto IL_00E3;
				}
			}
			else if (boxType3 != BoxType.Water)
			{
				if (boxType4 == BoxType.Water)
				{
					goto IL_00D8;
				}
			}
			else
			{
				if (num3 != 1)
				{
					goto IL_00E3;
				}
				goto IL_00E3;
			}
			Board board3 = this.board;
			int num4 = board3.rowNum;
			int num5 = this.theZombieRow;
			if (num4 != 1)
			{
				num4 -= board3;
				num3 = this.board.rowNum;
				num3 -= board3;
				num3 = originalRow;
				return num3;
			}
			uint num6;
			num3 -= (int)num6;
			IL_00D8:
			num3 = originalRow;
			return num3;
			IL_00E3:
			num3 = originalRow;
			return num3;
		}
		int num7 = originalRow - 1;
		BoxType boxType5 = roadType[num7];
		int num8;
		if (boxType == BoxType.Water)
		{
			while (boxType5 != boxType)
			{
			}
			num8 = originalRow - 1;
			return num8;
		}
		while (num8 == 1)
		{
		}
		return originalRow - 1;
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x000C1968 File Offset: 0x000BFB68
	[Token(Token = "0x60024E3")]
	[Address(RVA = "0x592E50", Offset = "0x591450", VA = "0x180592E50", Slot = "67")]
	protected virtual void AttackPlant(Plant plant)
	{
		if (!this.EatEffect(plant))
		{
			int thePlantType = (int)plant.thePlantType;
			bool flag;
			if (!flag)
			{
				GameAPP.PlaySound(global::UnityEngine.Random.Range(8, 10), 0.3f, 1f);
			}
			GameAPP.PlaySound(10, 0.3f, 1f);
			GameObject gameObject = GameAPP.particlePrefab[5];
			if (plant.thePlantType == PlantType.CherryNut)
			{
				GameObject[] particlePrefab = GameAPP.particlePrefab;
			}
			GameObject gameObject2 = this.zombieJaw;
			int num = 0;
			if (gameObject2 != num)
			{
				Transform transform = this.zombieJaw.transform;
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform2 = this.board.transform;
			}
			this.AttackEffect(plant);
		}
	}

	// Token: 0x060024E4 RID: 9444 RVA: 0x000C1A24 File Offset: 0x000BFC24
	[Token(Token = "0x60024E4")]
	[Address(RVA = "0x592D70", Offset = "0x591370", VA = "0x180592D70", Slot = "68")]
	protected virtual void AttackEffect(Plant plant)
	{
		plant.FlashOnce();
		if (!plant.invincible || plant.disableCount > 0)
		{
			GameAPP.PlaySound(11, 0.5f, 1f);
		}
	}

	// Token: 0x060024E5 RID: 9445 RVA: 0x000C1A64 File Offset: 0x000BFC64
	[Token(Token = "0x60024E5")]
	[Address(RVA = "0x5976C0", Offset = "0x595CC0", VA = "0x1805976C0")]
	private bool EatEffect(Plant plant)
	{
		if (!plant.garlic)
		{
			PlantType thePlantType = plant.thePlantType;
			if (thePlantType > PlantType.SuperUmbrella)
			{
				if (thePlantType > PlantType.GarlicNut)
				{
					if (thePlantType > PlantType.CherryHypno)
					{
						if (thePlantType > PlantType.DoomGarlic)
						{
							if (thePlantType == PlantType.HypnoPot)
							{
								int num = 0;
								this.SetMindControl(num);
								int num2 = 0;
								plant.Die((Plant.DieReason)num2);
								CreatePlant instance = CreatePlant.Instance;
							}
							if (typeof(ParticleManager).TypeHandle <= (ulong)3L || thePlantType == PlantType.GarlicTorch)
							{
								goto IL_05C8;
							}
							bool flag = plant.OnEat(this);
						}
						if (thePlantType == PlantType.HypnoChomper)
						{
							int num3 = 0;
							this.SetMindControl(num3);
							int num4 = 0;
							plant.Die((Plant.DieReason)num4);
							CreatePlant instance2 = CreatePlant.Instance;
						}
						while (thePlantType != PlantType.DoomGarlic)
						{
						}
						ulong num5;
						this.EatGarlic(plant, 1f, num5 != 0UL);
						int num6 = 0;
						this.garlicDoom = true;
						this.SetEmbered(num6 != 0);
						this.SetPoison(10f);
					}
					if (thePlantType > PlantType.SeaHypno)
					{
						if (thePlantType == PlantType.KelpNut)
						{
							int num7 = 0;
							this.SetKelped(5f, num7 != 0);
						}
						if (typeof(ParticleManager).TypeHandle <= (ulong)6L)
						{
						}
						while (thePlantType != PlantType.CherryHypno)
						{
						}
						int num8 = 0;
						plant.Die((Plant.DieReason)num8);
						ZombieType zombieType = this.theZombieType;
						if (zombieType != ZombieType.UltimateFootballDrown && zombieType != ZombieType.UltimateFootballZombie && zombieType != ZombieType.UltimateHorse2)
						{
							uint num9;
							this.Die((int)num9);
						}
						if (this.BoxType != BoxType.Water)
						{
							Transform axis = this.axis;
							CreateZombie instance3 = CreateZombie.Instance;
						}
						Transform axis2 = this.axis;
						CreateZombie instance4 = CreateZombie.Instance;
					}
					if (thePlantType == PlantType.HypnoMelon)
					{
						int num10 = 0;
						this.SetMindControl(num10);
						int num11 = 0;
						plant.Die((Plant.DieReason)num11);
						CreatePlant instance5 = CreatePlant.Instance;
					}
					if (thePlantType == PlantType.SeaHypno)
					{
						goto IL_0410;
					}
				}
				if (thePlantType > PlantType.PortalNut)
				{
					if (thePlantType > PlantType.FireNut)
					{
						if (thePlantType == PlantType.CactusNut)
						{
							goto IL_0374;
						}
						if (thePlantType == PlantType.CornNut)
						{
						}
						while (thePlantType != PlantType.GarlicNut)
						{
						}
						this.SetPoison(10f);
					}
					if (thePlantType == PlantType.HypnoGarlic)
					{
						ulong num12;
						this.EatGarlic(plant, 1f, num12 != 0UL);
						int num13 = 0;
						this.SetMindControl(num13);
						int num14 = 0;
						plant.Die((Plant.DieReason)num14);
						CreatePlant instance6 = CreatePlant.Instance;
					}
					if (thePlantType == PlantType.FireNut)
					{
						goto IL_0440;
					}
				}
				if (thePlantType > PlantType.GarlicFume)
				{
					if (thePlantType == PlantType.IceNut)
					{
						goto IL_046D;
					}
					if (thePlantType == PlantType.HypnoPumpkin)
					{
						goto IL_031D;
					}
					while (thePlantType != PlantType.PortalNut)
					{
					}
					uint num15;
					if (thePlantType != PlantType.PortalNut || global::UnityEngine.Random.Range(0, (int)num15) != 0)
					{
						goto IL_05B5;
					}
					plant.AttributeCountdown = 10f;
					Transform axis3 = this.axis;
					ParticleManager instance7 = ParticleManager.Instance;
					Board board = this.board;
					Mouse instance8 = Mouse.Instance;
					float boardMaxX = board.boardMaxX;
					int num16 = this.theZombieRow;
					float landY = instance8.GetLandY(boardMaxX, num16);
				}
				if (thePlantType == PlantType.HypnoMagnet)
				{
					int num17 = 0;
					this.SetMindControl(num17);
					int num18 = 0;
					plant.Die((Plant.DieReason)num18);
					CreatePlant instance9 = CreatePlant.Instance;
				}
			}
			if (thePlantType <= PlantType.TallIceNut)
			{
				goto IL_041E;
			}
			if (thePlantType <= PlantType.CactusPumpkin)
			{
				goto IL_034D;
			}
			if (thePlantType <= PlantType.GarlicMelon)
			{
				goto IL_0337;
			}
			if (thePlantType == PlantType.GarlicUmbrella || thePlantType == PlantType.GarlicPot || thePlantType == PlantType.GarlicPot || thePlantType == PlantType.GarlicPot)
			{
				goto IL_05C8;
			}
			if (thePlantType != PlantType.GarlicPot)
			{
			}
			IL_031D:
			uint num19;
			if (global::UnityEngine.Random.Range(0, (int)num19) != 12)
			{
				goto IL_05B5;
			}
			int num20 = 0;
			this.SetMindControl(num20);
			IL_0337:
			if (num20 == 1110)
			{
				goto IL_0374;
			}
			if (18446744073709550499UL <= (ulong)2L)
			{
				goto IL_05C8;
			}
			IL_034D:
			if (num20 > 1045 && num20 != 1048)
			{
				if (num20 == 1073)
				{
					goto IL_0440;
				}
				while (num20 != 1088)
				{
				}
			}
			IL_0374:
			int num23;
			if (thePlantType == PlantType.IceHypno)
			{
				Board board2 = this.board;
				Transform axis4 = plant.axis;
				BoardAction boardAction = board2.boardAction;
				int num21 = 0;
				plant.Die((Plant.DieReason)num21);
				ZombieType zombieType2 = this.theZombieType;
				if (zombieType2 != ZombieType.UltimateFootballDrown && zombieType2 != ZombieType.UltimateFootballZombie && zombieType2 != ZombieType.UltimateHorse2)
				{
					uint num22;
					this.Die((int)num22);
				}
				if (this.BoxType != BoxType.Water)
				{
					Transform axis5 = this.axis;
					CreateZombie instance10 = CreateZombie.Instance;
				}
				Transform axis6 = this.axis;
				num23 = this.theZombieRow;
				CreateZombie instance11 = CreateZombie.Instance;
			}
			while (num23 != 1045)
			{
			}
			this.isDoom = true;
			IL_0410:
			int num24 = 0;
			this.SetMindControl(num24);
			int num25 = 0;
			IL_041E:
			if (num25 <= 924)
			{
				goto IL_0572;
			}
			if (num25 <= 967)
			{
				goto IL_0560;
			}
			if (18446744073709550648UL > (ulong)1L)
			{
				goto IL_044E;
			}
			IL_0440:
			PlantType thePlantType2 = plant.thePlantType;
			this.SetJalaed();
			IL_044E:
			if (this == 0)
			{
				goto IL_0525;
			}
			if (this == 0)
			{
				goto IL_0508;
			}
			if (this == 0)
			{
				goto IL_04EB;
			}
			while (this == 0)
			{
			}
			if (this == (ulong)1L)
			{
				goto IL_04CE;
			}
			IL_046D:
			int num26 = 0;
			int num27 = 0;
			this.SetCold(10f, num27, num26 != 0);
			int num28 = this.freezeLevel;
			num28 += 10;
			this.freezeLevel = num28;
			if (num28 == this.freezeMaxLevel)
			{
				goto IL_05B5;
			}
			int num29 = 0;
			this.freezeLevel = num29;
			if (this.freezeMaxLevel < 1000)
			{
			}
			int num30 = 0;
			this.SetFreeze(4f, num30);
			IL_04CE:
			int num31 = 0;
			this.SetMindControl(num31);
			int num32 = 0;
			plant.Die((Plant.DieReason)num32);
			CreatePlant instance12 = CreatePlant.Instance;
			IL_04EB:
			int num33 = 0;
			this.SetMindControl(num33);
			int num34 = 0;
			plant.Die((Plant.DieReason)num34);
			CreatePlant instance13 = CreatePlant.Instance;
			IL_0508:
			int num35 = 0;
			this.SetMindControl(num35);
			int num36 = 0;
			plant.Die((Plant.DieReason)num36);
			CreatePlant instance14 = CreatePlant.Instance;
			IL_0525:
			int num37 = 0;
			this.SetMindControl(num37);
			int num38 = 0;
			plant.Die((Plant.DieReason)num38);
			ZombieType zombieType3 = this.theZombieType;
			while (zombieType3 == ZombieType.UltimateFootballDrown)
			{
			}
			while (zombieType3 == ZombieType.UltimateFootballZombie)
			{
			}
			this.BeSmall(0.7f);
			IL_0560:
			if (num38 == 952)
			{
				goto IL_05C8;
			}
			while (num38 == 967)
			{
			}
			IL_0572:
			if (num38 <= 29)
			{
				goto IL_05C8;
			}
			if (18446744073709551385UL <= (ulong)1L)
			{
				if (plant.attributeCount <= 0)
				{
					goto IL_05B5;
				}
				num38 += 2;
				this.FireFlyed(num38);
			}
			if (num38 != 900)
			{
				while (18446744073709550705UL > (ulong)13L)
				{
				}
				PlantType thePlantType3 = plant.thePlantType;
			}
			IL_05B5:
			int num39 = 0;
			this.SetMindControl(num39);
			HypnoEmperor component = plant.GetComponent<HypnoEmperor>();
		}
		IL_05C8:
		ulong num40;
		this.EatGarlic(plant, 1f, num40 != 0UL);
		throw new NullReferenceException();
	}

	// Token: 0x060024E6 RID: 9446 RVA: 0x000C2050 File Offset: 0x000C0250
	[Token(Token = "0x60024E6")]
	[Address(RVA = "0x5937A0", Offset = "0x591DA0", VA = "0x1805937A0", Slot = "69")]
	public virtual void BeSmall(float scale = 0.7f)
	{
		int num;
		do
		{
			num = 0;
			if ((this.isSmall ? 1 : 0) != num)
			{
				break;
			}
			int num2 = (int)this.theZombieType;
			bool flag;
			if (flag)
			{
				break;
			}
			this.isSmall = true;
			global::Lawnf.SetZombieHealth(this, scale);
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			Transform transform = base.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				bool flag2;
				while (!flag2)
				{
				}
				Vector3 vector3;
				float z3 = vector3.z;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060024E7 RID: 9447 RVA: 0x000C2110 File Offset: 0x000C0310
	[Token(Token = "0x60024E7")]
	[Address(RVA = "0x59C400", Offset = "0x59AA00", VA = "0x18059C400", Slot = "70")]
	public virtual void RealKnockBack(float x)
	{
		Transform axis = this.axis;
		float num = this.deadRight;
		Transform axis2 = this.axis;
		float num2 = this.deadRight;
		if (x > num2)
		{
		}
		Transform transform = base.transform;
		Transform axis3 = this.axis;
	}

	// Token: 0x060024E8 RID: 9448 RVA: 0x000C2158 File Offset: 0x000C0358
	[Token(Token = "0x60024E8")]
	[Address(RVA = "0x59C400", Offset = "0x59AA00", VA = "0x18059C400", Slot = "71")]
	public virtual void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
		Transform axis = this.axis;
		float num = this.deadRight;
		Transform axis2 = this.axis;
		float num2 = this.deadRight;
		if (x > num2)
		{
		}
		Transform transform = base.transform;
		Transform axis3 = this.axis;
	}

	// Token: 0x060024E9 RID: 9449 RVA: 0x000C21A0 File Offset: 0x000C03A0
	[Token(Token = "0x60024E9")]
	[Address(RVA = "0x59BDA0", Offset = "0x59A3A0", VA = "0x18059BDA0")]
	public void InitHealth()
	{
		GameObject health = this.GetHealth("health", 100);
		TextMeshPro component = health.GetComponent<TextMeshPro>();
		this.healthText = component;
		bool showZombieHealth = this.board.showZombieHealth;
		health.SetActive(showZombieHealth);
	}

	// Token: 0x060024EA RID: 9450 RVA: 0x000C21E4 File Offset: 0x000C03E4
	[Token(Token = "0x60024EA")]
	[Address(RVA = "0x59AFF0", Offset = "0x5995F0", VA = "0x18059AFF0")]
	private GameObject GetHealth(string name, int order)
	{
		GameObject gameObject = new GameObject(name);
		Transform transform = gameObject.transform;
		Transform transform2 = base.transform;
		transform.parent = transform2;
		TextMeshPro textMeshPro = gameObject.AddComponent<TextMeshPro>();
		TMP_FontAsset font = GameAPP.font;
		textMeshPro.font = font;
		int num = (int)this.theZombieType;
		bool flag;
		if (!flag)
		{
		}
		textMeshPro.fontSize = 4f;
		Transform transform3 = textMeshPro.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		SortingGroup sortingGroup = textMeshPro.AddComponent<SortingGroup>();
		sortingGroup.sortingOrder = order;
		int num2 = SortingLayer.NameToID("up1");
		sortingGroup.sortingLayerID = num2;
		ulong num3;
		sortingGroup.sortAtRoot = num3 != 0UL;
		RectTransform component = textMeshPro.GetComponent<RectTransform>();
		return gameObject;
	}

	// Token: 0x060024EB RID: 9451 RVA: 0x000C2294 File Offset: 0x000C0494
	[Token(Token = "0x60024EB")]
	[Address(RVA = "0x5A1870", Offset = "0x59FE70", VA = "0x1805A1870", Slot = "72")]
	public virtual void UpdateHealthText()
	{
		TextMeshPro textMeshPro = this.healthText;
		int num = 0;
		if (textMeshPro != num && this.healthText.gameObject.activeSelf)
		{
			if (this.theHealth <= 0)
			{
				TextMeshPro textMeshPro2 = this.healthText;
				throw new NullReferenceException();
			}
			GameObject gameObject = this.theFirstArmor;
			int num2 = 0;
			if (gameObject != num2)
			{
				GameObject gameObject2 = this.theSecondArmor;
				int num3 = 0;
				if (gameObject2 != num3)
				{
					TextMeshPro textMeshPro3 = this.healthText;
					object[] array = new object[6];
					if (array != 0)
					{
					}
					array[0] = array;
					int num4 = this.theMaxHealth;
					if (num4 != 0)
					{
					}
					array[1] = num4;
					int num5 = this.theFirstArmorHealth;
					num4 = num5;
					if (num5 != 0)
					{
					}
					array[2] = num4;
					int num6 = this.theFirstArmorMaxHealth;
					num4 = num6;
					if (num6 != 0)
					{
					}
					array[3] = num4;
					int num7 = this.theSecondArmorHealth;
					num4 = num7;
					if (num7 != 0)
					{
					}
					array[4] = num4;
					int num8 = this.theSecondArmorMaxHealth;
					num4 = num8;
					if (num8 != 0)
					{
					}
					array[5] = num4;
					string text = string.Format("HP：{0}/{1}\n一类：{2}/{3}\n二类：{4}/{5}", array);
				}
			}
			GameObject gameObject3 = this.theFirstArmor;
			int num9 = 0;
			if (gameObject3 != num9)
			{
				GameObject gameObject4 = this.theSecondArmor;
				int num10 = 0;
				if (gameObject4 == num10)
				{
					TextMeshPro textMeshPro4 = this.healthText;
					object[] array2 = new object[4];
					if (array2 != 0)
					{
					}
					array2[0] = array2;
					int num11 = this.theMaxHealth;
					if (num11 != 0)
					{
					}
					array2[1] = num11;
					int num12 = this.theFirstArmorHealth;
					num11 = num12;
					if (num12 != 0)
					{
					}
					array2[2] = num11;
					int num13 = this.theFirstArmorMaxHealth;
					num11 = num13;
					if (num13 != 0)
					{
					}
					array2[3] = num11;
					string text2 = string.Format("HP：{0}/{1}\n一类：{2}/{3}", array2);
				}
			}
			GameObject gameObject5 = this.theFirstArmor;
			int num14 = 0;
			if (gameObject5 == num14)
			{
				GameObject gameObject6 = this.theSecondArmor;
				int num15 = 0;
				if (gameObject6 != num15)
				{
					TextMeshPro textMeshPro5 = this.healthText;
					object[] array3 = new object[4];
					if (array3 != 0)
					{
					}
					array3[0] = array3;
					int num16 = this.theMaxHealth;
					if (num16 != 0)
					{
					}
					array3[1] = num16;
					int num17 = this.theSecondArmorHealth;
					num16 = num17;
					if (num17 != 0)
					{
					}
					array3[2] = num16;
					int num18 = this.theSecondArmorMaxHealth;
					num16 = num18;
					if (num18 != 0)
					{
					}
					array3[3] = num16;
					string text3 = string.Format("HP：{0}/{1}\n二类：{2}/{3}", array3);
				}
			}
			TextMeshPro textMeshPro6 = this.healthText;
			int num19;
			int num20;
			string text4 = string.Format("HP：{0}/{1}\n", num19, num20);
			textMeshPro6.text = text4;
			if (this.level > 1)
			{
				int num21 = this.level;
				TextMeshPro textMeshPro7 = this.healthText;
				string text5 = string.Format("{0}阶\n", num21);
				string text6 = this.healthText.text;
				string text7 = text5 + text6;
				textMeshPro7.text = text7;
			}
		}
	}

	// Token: 0x060024EC RID: 9452 RVA: 0x000C258C File Offset: 0x000C078C
	[Token(Token = "0x60024EC")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "73")]
	public virtual void KillByCaltrop()
	{
	}

	// Token: 0x060024ED RID: 9453 RVA: 0x000C259C File Offset: 0x000C079C
	[Token(Token = "0x60024ED")]
	[Address(RVA = "0x59E110", Offset = "0x59C710", VA = "0x18059E110")]
	public void Recover(float value)
	{
		GameObject gameObject = this.theFirstArmor;
		int num = 0;
		if (!(gameObject != num))
		{
			int num2 = this.theHealth;
			this.theHealth = num2;
			if (num2 <= this.theMaxHealth)
			{
				return;
			}
			int num3 = this.theMaxHealth;
			this.theHealth = num3;
		}
		int num4 = this.theFirstArmorHealth;
		this.theFirstArmorHealth = num4;
		if (num4 > this.theFirstArmorMaxHealth)
		{
			int num5 = this.theFirstArmorMaxHealth;
			this.theFirstArmorHealth = num5;
		}
		this.FirstArmorBroken();
	}

	// Token: 0x060024EE RID: 9454 RVA: 0x000C2614 File Offset: 0x000C0814
	[Token(Token = "0x60024EE")]
	[Address(RVA = "0x5922D0", Offset = "0x5908D0", VA = "0x1805922D0")]
	public void AddTimer(ZombieTimer zombieTimer, float value)
	{
		Dictionary<ZombieTimer, float> dictionary = this.timers;
		Dictionary<ZombieTimer, float> dictionary2 = this.timers;
		bool flag;
		if (!flag)
		{
			return;
		}
	}

	// Token: 0x060024EF RID: 9455 RVA: 0x000C263C File Offset: 0x000C083C
	[Token(Token = "0x60024EF")]
	[Address(RVA = "0x59B530", Offset = "0x599B30", VA = "0x18059B530")]
	public float GetTimer(ZombieTimer zombieTimer)
	{
		Dictionary<ZombieTimer, float> dictionary = this.timers;
		bool flag;
		if (!flag)
		{
		}
		Dictionary<ZombieTimer, float> dictionary2 = this.timers;
		float num;
		return num;
	}

	// Token: 0x060024F0 RID: 9456 RVA: 0x000C266C File Offset: 0x000C086C
	[Token(Token = "0x60024F0")]
	[Address(RVA = "0x5999D0", Offset = "0x597FD0", VA = "0x1805999D0")]
	public void FireFlyed(int count)
	{
		GameObject gameObject = this.fireFly;
		int num = 0;
		if (gameObject == num)
		{
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Plants/_TowerPlant/Sunshroom/More/FireFlys"));
			this.fireFly = gameObject2;
			Transform transform = this.fireFly.transform;
			Transform transform2 = base.transform;
			transform.parentInternal = transform2;
			Transform transform3 = this.fireFly.transform;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
		}
		int num2 = this.fireFlyedCount;
		num2 += count;
		this.fireFlyedCount = num2;
		if (num2 > 20)
		{
			this.fireFlyedCount = (int)((ulong)20L);
		}
	}

	// Token: 0x060024F1 RID: 9457 RVA: 0x000C270C File Offset: 0x000C090C
	[Token(Token = "0x60024F1")]
	[Address(RVA = "0x598E30", Offset = "0x597430", VA = "0x180598E30")]
	protected IEnumerator FadeDeath()
	{
		int num;
		Zombie.<FadeDeath>d__249 <FadeDeath>d__ = new Zombie.<FadeDeath>d__249(num);
		num = 0;
		<FadeDeath>d__.<>4__this = this;
		throw new NullReferenceException();
	}

	// Token: 0x060024F2 RID: 9458 RVA: 0x000C2730 File Offset: 0x000C0930
	[Token(Token = "0x60024F2")]
	[Address(RVA = "0x5A2F20", Offset = "0x5A1520", VA = "0x1805A2F20")]
	public Zombie()
	{
		List<GameObject> list = new List();
		this.theUniqueItems = list;
		List<Transform> list2 = new List();
		this.changeSprites = list2;
		this.theHealth = (int)((ulong)270L);
		this.theMaxHealth = (int)((ulong)270L);
		this.theAttackDamage = (int)((ulong)50L);
		this.level = (int)((ulong)1L);
		this.freezeMaxLevel = (int)((ulong)100L);
		this.takeDmgMultiplier = 1f;
		this.fragileValue = 1f;
		this.theSpeed = 1f;
		this.theOriginSpeed = 1f;
		this.freezeSpeed = 1f;
		this.coldSpeed = 1f;
		this.butterSpeed = 1f;
		this.kelpSpeed = 1f;
		this.garlicSpeed = 1f;
		this.uniqueSpeed = 1f;
		this.holeSpeed = 1f;
		this.doomWithPit = true;
		bool[] array = new bool[7];
		this.controlledLevel = array;
		HashSet<EveZombieBuff> hashSet = new HashSet();
		this.eveBuffs = hashSet;
		Dictionary<ZombieTimer, float> dictionary = new Dictionary();
		this.timers = dictionary;
		Dictionary<ArmorBonus, float> dictionary2 = new Dictionary();
		this.armorBonus = dictionary2;
		HashSet<string> hashSet2 = new HashSet();
		this.used = hashSet2;
		Dictionary<ZombieFragile, float> dictionary3 = new Dictionary();
		this.fragiles = dictionary3;
		this.hugeDamage = 1f;
		this.dy = 10f;
		List<IDamageable> list3 = new List();
		this.contacts = list3;
		this.dieReason = (int)((ulong)4294967295L);
		this.lastLadder = (ulong)3212836864L;
		this.lastLadder.y = -1f;
		List<Color> list4 = new List();
		this.colorsBuffers = list4;
		base..ctor();
	}

	// Token: 0x060024F3 RID: 9459 RVA: 0x000C28D0 File Offset: 0x000C0AD0
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60024F3")]
	[Address(RVA = "0x5A2D20", Offset = "0x5A1320", VA = "0x1805A2D20")]
	static Zombie()
	{
		throw new NullReferenceException();
	}

	// Token: 0x040011CA RID: 4554
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40011CA")]
	public ZombieType theZombieType;

	// Token: 0x040011CB RID: 4555
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40011CB")]
	public Zombie.FirstArmorType theFirstArmorType;

	// Token: 0x040011CC RID: 4556
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40011CC")]
	public Zombie.SecondArmorType theSecondArmorType;

	// Token: 0x040011CD RID: 4557
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40011CD")]
	public Zombie.UniqueItemType theUniqueItemType;

	// Token: 0x040011CE RID: 4558
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40011CE")]
	public ZombieStatus theStatus;

	// Token: 0x040011CF RID: 4559
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40011CF")]
	public Towards towards;

	// Token: 0x040011D0 RID: 4560
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40011D0")]
	public GameObject theFirstArmor;

	// Token: 0x040011D1 RID: 4561
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40011D1")]
	public GameObject theSecondArmor;

	// Token: 0x040011D2 RID: 4562
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40011D2")]
	public List<GameObject> theUniqueItems;

	// Token: 0x040011D3 RID: 4563
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40011D3")]
	public List<Transform> changeSprites;

	// Token: 0x040011D4 RID: 4564
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40011D4")]
	public Transform shoot;

	// Token: 0x040011D5 RID: 4565
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40011D5")]
	public int theHealth;

	// Token: 0x040011D6 RID: 4566
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40011D6")]
	public int theMaxHealth;

	// Token: 0x040011D7 RID: 4567
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40011D7")]
	public int theFirstArmorHealth;

	// Token: 0x040011D8 RID: 4568
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40011D8")]
	public int theFirstArmorMaxHealth;

	// Token: 0x040011D9 RID: 4569
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40011D9")]
	public int theSecondArmorHealth;

	// Token: 0x040011DA RID: 4570
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40011DA")]
	public int theSecondArmorMaxHealth;

	// Token: 0x040011DB RID: 4571
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40011DB")]
	public int theAttackDamage;

	// Token: 0x040011DC RID: 4572
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x40011DC")]
	public int level;

	// Token: 0x040011DD RID: 4573
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40011DD")]
	public int freezeMaxLevel;

	// Token: 0x040011DE RID: 4574
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40011DE")]
	public int theZombieRow;

	// Token: 0x040011DF RID: 4575
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40011DF")]
	public int freezeLevel;

	// Token: 0x040011E0 RID: 4576
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40011E0")]
	public int poisonLevel;

	// Token: 0x040011E1 RID: 4577
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40011E1")]
	public int attributeCount;

	// Token: 0x040011E2 RID: 4578
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40011E2")]
	public int awardLevel;

	// Token: 0x040011E3 RID: 4579
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40011E3")]
	public int kelpTimes;

	// Token: 0x040011E4 RID: 4580
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x40011E4")]
	public float theArmor;

	// Token: 0x040011E5 RID: 4581
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40011E5")]
	public float takeDmgMultiplier;

	// Token: 0x040011E6 RID: 4582
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40011E6")]
	public float fragileValue;

	// Token: 0x040011E7 RID: 4583
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40011E7")]
	public int read;

	// Token: 0x040011E8 RID: 4584
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40011E8")]
	[Header("速度")]
	public float theSpeed;

	// Token: 0x040011E9 RID: 4585
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40011E9")]
	public float theOriginSpeed;

	// Token: 0x040011EA RID: 4586
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x40011EA")]
	public float freezeSpeed;

	// Token: 0x040011EB RID: 4587
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40011EB")]
	public float coldSpeed;

	// Token: 0x040011EC RID: 4588
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x40011EC")]
	public float butterSpeed;

	// Token: 0x040011ED RID: 4589
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40011ED")]
	public float kelpSpeed;

	// Token: 0x040011EE RID: 4590
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x40011EE")]
	public float garlicSpeed;

	// Token: 0x040011EF RID: 4591
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40011EF")]
	public float uniqueSpeed;

	// Token: 0x040011F0 RID: 4592
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x40011F0")]
	public float holeSpeed;

	// Token: 0x040011F1 RID: 4593
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40011F1")]
	[Header("倒计时")]
	public float dogeTime;

	// Token: 0x040011F2 RID: 4594
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x40011F2")]
	public float attributeCountDown;

	// Token: 0x040011F3 RID: 4595
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40011F3")]
	public float existTime;

	// Token: 0x040011F4 RID: 4596
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40011F4")]
	public float ladderTime;

	// Token: 0x040011F5 RID: 4597
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40011F5")]
	public bool inWater;

	// Token: 0x040011F6 RID: 4598
	[FieldOffset(Offset = "0x119")]
	[Token(Token = "0x40011F6")]
	public bool isMindControlled;

	// Token: 0x040011F7 RID: 4599
	[FieldOffset(Offset = "0x11A")]
	[Token(Token = "0x40011F7")]
	public bool isChangingRow;

	// Token: 0x040011F8 RID: 4600
	[FieldOffset(Offset = "0x11B")]
	[Token(Token = "0x40011F8")]
	public bool isAttacking;

	// Token: 0x040011F9 RID: 4601
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40011F9")]
	public bool ultiEmbered;

	// Token: 0x040011FA RID: 4602
	[FieldOffset(Offset = "0x11D")]
	[Token(Token = "0x40011FA")]
	public bool isDoom;

	// Token: 0x040011FB RID: 4603
	[FieldOffset(Offset = "0x11E")]
	[Token(Token = "0x40011FB")]
	public bool garlicDoom;

	// Token: 0x040011FC RID: 4604
	[FieldOffset(Offset = "0x11F")]
	[Token(Token = "0x40011FC")]
	public bool isSmall;

	// Token: 0x040011FD RID: 4605
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40011FD")]
	public bool doomWithPit;

	// Token: 0x040011FE RID: 4606
	[FieldOffset(Offset = "0x121")]
	[Token(Token = "0x40011FE")]
	public bool beforeDying;

	// Token: 0x040011FF RID: 4607
	[FieldOffset(Offset = "0x122")]
	[Token(Token = "0x40011FF")]
	public bool isSplited;

	// Token: 0x04001200 RID: 4608
	[FieldOffset(Offset = "0x123")]
	[Token(Token = "0x4001200")]
	public bool isGold;

	// Token: 0x04001201 RID: 4609
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4001201")]
	public bool isBlowed;

	// Token: 0x04001202 RID: 4610
	[FieldOffset(Offset = "0x125")]
	[Token(Token = "0x4001202")]
	public bool isPreview;

	// Token: 0x04001203 RID: 4611
	[FieldOffset(Offset = "0x126")]
	[Token(Token = "0x4001203")]
	public bool fragile;

	// Token: 0x04001204 RID: 4612
	[FieldOffset(Offset = "0x127")]
	[Token(Token = "0x4001204")]
	public bool revived;

	// Token: 0x04001205 RID: 4613
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001205")]
	public bool[] controlledLevel;

	// Token: 0x04001206 RID: 4614
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001206")]
	public IDamageable theAttackTarget;

	// Token: 0x04001207 RID: 4615
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001207")]
	public Rigidbody2D rb;

	// Token: 0x04001208 RID: 4616
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4001208")]
	public Collider2D col;

	// Token: 0x04001209 RID: 4617
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4001209")]
	public SortingGroup sortingGroup;

	// Token: 0x0400120A RID: 4618
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400120A")]
	public WaterSpray waterSpray;

	// Token: 0x0400120B RID: 4619
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400120B")]
	public SpriteRenderer headGarlic;

	// Token: 0x0400120C RID: 4620
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400120C")]
	public SpriteRenderer jawGarlic;

	// Token: 0x0400120D RID: 4621
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400120D")]
	public TextMeshPro healthText;

	// Token: 0x0400120E RID: 4622
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400120E")]
	public TimeBomb timeBomb;

	// Token: 0x0400120F RID: 4623
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400120F")]
	public Tentacle tentacle;

	// Token: 0x04001210 RID: 4624
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4001210")]
	public Zombie pre;

	// Token: 0x04001211 RID: 4625
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4001211")]
	public Zombie next;

	// Token: 0x04001212 RID: 4626
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4001212")]
	public Corner targetCorner;

	// Token: 0x04001213 RID: 4627
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4001213")]
	public Action defaultAction;

	// Token: 0x04001214 RID: 4628
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4001214")]
	public HashSet<EveZombieBuff> eveBuffs;

	// Token: 0x04001215 RID: 4629
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4001215")]
	public Dictionary<ZombieTimer, float> timers;

	// Token: 0x04001216 RID: 4630
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4001216")]
	public Dictionary<ArmorBonus, float> armorBonus;

	// Token: 0x04001217 RID: 4631
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4001217")]
	public HashSet<string> used;

	// Token: 0x04001218 RID: 4632
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4001218")]
	public Dictionary<ZombieFragile, float> fragiles;

	// Token: 0x04001219 RID: 4633
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4001219")]
	protected int theFirstArmorBroken;

	// Token: 0x0400121A RID: 4634
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x400121A")]
	protected int theSecondArmorBroken;

	// Token: 0x0400121B RID: 4635
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400121B")]
	protected int takeDamageTimes;

	// Token: 0x0400121C RID: 4636
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x400121C")]
	protected int lastMaxDamage;

	// Token: 0x0400121D RID: 4637
	[Token(Token = "0x400121D")]
	public const int butterLayer = 140;

	// Token: 0x0400121E RID: 4638
	[Token(Token = "0x400121E")]
	public const int kelpLayer = 139;

	// Token: 0x0400121F RID: 4639
	[Token(Token = "0x400121F")]
	public const int iceLayer = 138;

	// Token: 0x04001220 RID: 4640
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4001220")]
	protected float hugeDamage;

	// Token: 0x04001221 RID: 4641
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4001221")]
	protected float vx;

	// Token: 0x04001222 RID: 4642
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4001222")]
	protected float vy;

	// Token: 0x04001223 RID: 4643
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x4001223")]
	protected float flashTime;

	// Token: 0x04001224 RID: 4644
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4001224")]
	protected float lastTakeDamageDuring;

	// Token: 0x04001225 RID: 4645
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4001225")]
	protected float deadRight;

	// Token: 0x04001226 RID: 4646
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4001226")]
	protected float deadLeft;

	// Token: 0x04001227 RID: 4647
	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4001227")]
	protected readonly float dy;

	// Token: 0x04001228 RID: 4648
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4001228")]
	protected bool loseHand;

	// Token: 0x04001229 RID: 4649
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4001229")]
	protected readonly List<IDamageable> contacts;

	// Token: 0x0400122A RID: 4650
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400122A")]
	private int dieReason;

	// Token: 0x0400122B RID: 4651
	[FieldOffset(Offset = "0x20C")]
	[Token(Token = "0x400122B")]
	private int fireFlyedCount;

	// Token: 0x0400122C RID: 4652
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400122C")]
	private bool droppedSun;

	// Token: 0x0400122D RID: 4653
	[FieldOffset(Offset = "0x211")]
	[Token(Token = "0x400122D")]
	private bool eatGarlic;

	// Token: 0x0400122E RID: 4654
	[FieldOffset(Offset = "0x212")]
	[Token(Token = "0x400122E")]
	private bool hasIsAttackingParam;

	// Token: 0x0400122F RID: 4655
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400122F")]
	private Sprite headOriginalSprite;

	// Token: 0x04001230 RID: 4656
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4001230")]
	private GameObject fireFly;

	// Token: 0x04001231 RID: 4657
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4001231")]
	public GameObject butterHead;

	// Token: 0x04001232 RID: 4658
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4001232")]
	private GameObject zombieJaw;

	// Token: 0x04001233 RID: 4659
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4001233")]
	private Color currentColor;

	// Token: 0x04001234 RID: 4660
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4001234")]
	private Vector2 lastLadder;

	// Token: 0x04001235 RID: 4661
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4001235")]
	private readonly List<Color> colorsBuffers;

	// Token: 0x04001236 RID: 4662
	[Token(Token = "0x4001236")]
	private static readonly Dictionary<Zombie.ZombieColor, Color> ColorDictionary = new Dictionary();

	// Token: 0x02000717 RID: 1815
	[Token(Token = "0x2000717")]
	public enum KnockBackReason
	{
		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		ByUmbrella,
		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		Normal,
		// Token: 0x0400123A RID: 4666
		[Token(Token = "0x400123A")]
		ByJalapeno,
		// Token: 0x0400123B RID: 4667
		[Token(Token = "0x400123B")]
		ByTangleKelp
	}

	// Token: 0x02000718 RID: 1816
	[Token(Token = "0x2000718")]
	public enum FirstArmorType
	{
		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400123D")]
		Nothing,
		// Token: 0x0400123E RID: 4670
		[Token(Token = "0x400123E")]
		Cone,
		// Token: 0x0400123F RID: 4671
		[Token(Token = "0x400123F")]
		Bucket,
		// Token: 0x04001240 RID: 4672
		[Token(Token = "0x4001240")]
		Doll,
		// Token: 0x04001241 RID: 4673
		[Token(Token = "0x4001241")]
		FootballHelmet,
		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		WallNut,
		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		TallNut,
		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		TallNutFootball,
		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		BucketNut,
		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		Balloon,
		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		IronBalloon
	}

	// Token: 0x02000719 RID: 1817
	[Token(Token = "0x2000719")]
	public enum SecondArmorType
	{
		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4001249")]
		Nothing,
		// Token: 0x0400124A RID: 4682
		[Token(Token = "0x400124A")]
		Door,
		// Token: 0x0400124B RID: 4683
		[Token(Token = "0x400124B")]
		Paper,
		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		Ladder,
		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		SnowShield,
		// Token: 0x0400124E RID: 4686
		[Token(Token = "0x400124E")]
		Protal,
		// Token: 0x0400124F RID: 4687
		[Token(Token = "0x400124F")]
		RedLadder
	}

	// Token: 0x0200071A RID: 1818
	[Token(Token = "0x200071A")]
	public enum UniqueItemType
	{
		// Token: 0x04001251 RID: 4689
		[Token(Token = "0x4001251")]
		Nothing,
		// Token: 0x04001252 RID: 4690
		[Token(Token = "0x4001252")]
		Jackbox,
		// Token: 0x04001253 RID: 4691
		[Token(Token = "0x4001253")]
		Jumper,
		// Token: 0x04001254 RID: 4692
		[Token(Token = "0x4001254")]
		Pickaxe,
		// Token: 0x04001255 RID: 4693
		[Token(Token = "0x4001255")]
		IronHead,
		// Token: 0x04001256 RID: 4694
		[Token(Token = "0x4001256")]
		RedIronHead
	}

	// Token: 0x0200071B RID: 1819
	[Token(Token = "0x200071B")]
	public enum ZombieColor
	{
		// Token: 0x04001258 RID: 4696
		[Token(Token = "0x4001258")]
		Default,
		// Token: 0x04001259 RID: 4697
		[Token(Token = "0x4001259")]
		Cold,
		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x400125A")]
		MindConrolled,
		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		Jalaed,
		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		Doom,
		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		Poison,
		// Token: 0x0400125E RID: 4702
		[Token(Token = "0x400125E")]
		Poison_with_cold,
		// Token: 0x0400125F RID: 4703
		[Token(Token = "0x400125F")]
		Ember,
		// Token: 0x04001260 RID: 4704
		[Token(Token = "0x4001260")]
		Jala_with_ember,
		// Token: 0x04001261 RID: 4705
		[Token(Token = "0x4001261")]
		Gold,
		// Token: 0x04001262 RID: 4706
		[Token(Token = "0x4001262")]
		Lunar
	}
}
