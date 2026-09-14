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

// Token: 0x0200074F RID: 1871
[Token(Token = "0x200074F")]
public class Zombie : Entity
{
	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x06002590 RID: 9616 RVA: 0x000C2958 File Offset: 0x000C0B58
	[Token(Token = "0x170001B7")]
	public long CurrentFirstHealth
	{
		[Token(Token = "0x6002590")]
		[Address(RVA = "0x61E120", Offset = "0x61C720", VA = "0x18061E120")]
		get
		{
			int num = this.theFirstArmorHealth;
			return 0L;
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x06002591 RID: 9617 RVA: 0x000C2970 File Offset: 0x000C0B70
	[Token(Token = "0x170001B8")]
	public long CurrentAllHealth
	{
		[Token(Token = "0x6002591")]
		[Address(RVA = "0x61E100", Offset = "0x61C700", VA = "0x18061E100")]
		get
		{
			int num = this.theSecondArmorHealth;
			int num2 = this.theFirstArmorHealth;
			num += num2;
			return 0L;
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06002592 RID: 9618 RVA: 0x000C2994 File Offset: 0x000C0B94
	[Token(Token = "0x170001B9")]
	public long TotalAllHealth
	{
		[Token(Token = "0x6002592")]
		[Address(RVA = "0x61E1D0", Offset = "0x61C7D0", VA = "0x18061E1D0")]
		get
		{
			int num = this.theSecondArmorMaxHealth;
			int num2 = this.theFirstArmorMaxHealth;
			num += num2;
			return 0L;
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06002593 RID: 9619 RVA: 0x000C29B8 File Offset: 0x000C0BB8
	[Token(Token = "0x170001BA")]
	public long TotalFirstHealth
	{
		[Token(Token = "0x6002593")]
		[Address(RVA = "0x61E1F0", Offset = "0x61C7F0", VA = "0x18061E1F0")]
		get
		{
			int num = this.theFirstArmorMaxHealth;
			return 0L;
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06002594 RID: 9620 RVA: 0x000C29D0 File Offset: 0x000C0BD0
	[Token(Token = "0x170001BB")]
	public float DamageMultiplier
	{
		[Token(Token = "0x6002594")]
		[Address(RVA = "0x61E130", Offset = "0x61C730", VA = "0x18061E130")]
		get
		{
			TravelData data = TravelMgr.Instance.data;
			throw new NullReferenceException();
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06002595 RID: 9621 RVA: 0x000C29F8 File Offset: 0x000C0BF8
	[Token(Token = "0x170001BC")]
	public virtual bool Alive
	{
		[Token(Token = "0x6002595")]
		[Address(RVA = "0x61DDB0", Offset = "0x61C3B0", VA = "0x18061DDB0", Slot = "15")]
		get
		{
			bool flag;
			return !this.beforeDying && this.theStatus != ZombieStatus.Dying && flag;
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06002596 RID: 9622 RVA: 0x000C2A1C File Offset: 0x000C0C1C
	[Token(Token = "0x170001BD")]
	public int Column
	{
		[Token(Token = "0x6002596")]
		[Address(RVA = "0x61E0D0", Offset = "0x61C6D0", VA = "0x18061E0D0")]
		get
		{
			Transform axis = this.axis;
			int num;
			return num;
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06002597 RID: 9623 RVA: 0x000C2A3C File Offset: 0x000C0C3C
	[Token(Token = "0x170001BE")]
	public BoxType BoxType
	{
		[Token(Token = "0x6002597")]
		[Address(RVA = "0x61DDD0", Offset = "0x61C3D0", VA = "0x18061DDD0")]
		get
		{
			Transform axis = this.axis;
			Board board = this.board;
			int num = this.theZombieRow;
			int num2;
			return board.GetBoxType(num2, num);
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06002598 RID: 9624 RVA: 0x000C2A7C File Offset: 0x000C0C7C
	[Token(Token = "0x170001BF")]
	public Vector2 Velocity
	{
		[Token(Token = "0x6002598")]
		[Address(RVA = "0x61E200", Offset = "0x61C800", VA = "0x18061E200")]
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

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06002599 RID: 9625 RVA: 0x000C2B7C File Offset: 0x000C0D7C
	[Token(Token = "0x170001C0")]
	public Vector2 ColliderPosition
	{
		[Token(Token = "0x6002599")]
		[Address(RVA = "0x61DFF0", Offset = "0x61C5F0", VA = "0x18061DFF0")]
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

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x0600259A RID: 9626 RVA: 0x000C2BBC File Offset: 0x000C0DBC
	[Token(Token = "0x170001C1")]
	public Vector2 CenterPosition
	{
		[Token(Token = "0x600259A")]
		[Address(RVA = "0x61DE30", Offset = "0x61C430", VA = "0x18061DE30")]
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

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x0600259B RID: 9627 RVA: 0x000C2BFC File Offset: 0x000C0DFC
	[Token(Token = "0x170001C2")]
	public Vector2 ColliderCenter
	{
		[Token(Token = "0x600259B")]
		[Address(RVA = "0x61DF10", Offset = "0x61C510", VA = "0x18061DF10")]
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

	// Token: 0x0600259C RID: 9628 RVA: 0x000C2C3C File Offset: 0x000C0E3C
	[Token(Token = "0x600259C")]
	[Address(RVA = "0x60D6E0", Offset = "0x60BCE0", VA = "0x18060D6E0", Slot = "10")]
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

	// Token: 0x0600259D RID: 9629 RVA: 0x000C2CE8 File Offset: 0x000C0EE8
	[Token(Token = "0x600259D")]
	[Address(RVA = "0x61ACA0", Offset = "0x6192A0", VA = "0x18061ACA0", Slot = "16")]
	protected virtual void Start()
	{
		Animator anim = this.anim;
		int num = 0;
		AnimatorControllerParameter[] parameters = anim.parameters;
		Func<AnimatorControllerParameter, bool> <>9__136_ = Zombie.<>c.<>9__136_0;
		if (<>9__136_ == 0)
		{
			Zombie.<>c.<>9__136_0 = (AnimatorControllerParameter param) => string.Equals(param.name, "isAttacking");
		}
		bool flag = Enumerable.Any<AnimatorControllerParameter>(parameters, <>9__136_);
		this.hasIsAttackingParam = flag;
		HashSet<EveZombieBuff> hashSet = new HashSet(this.board.eveZombieBuffs);
		this.eveBuffs = hashSet;
		Board board = this.board;
		hashSet += hashSet;
		this.theAttackDamage = hashSet;
		Board board2 = this.board;
		if (GameAPP.config.difficulty == 4 || GameAPP.config.difficulty == 5)
		{
			float num2 = this.theOriginSpeed;
			this.theOriginSpeed = num2;
		}
		this.UpdateHealthText();
		this.FindJaw();
		List<Zombie> zombieHead = this.board.zombieHead;
		Func<Zombie, bool> func = delegate(Zombie n)
		{
			ZombieType zombieType3 = this.theZombieType;
			return n.theZombieType == zombieType3;
		};
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(zombieHead, func);
		int num3 = 0;
		if (!(zombie != num3))
		{
			List<Zombie> zombieHead2 = this.board.zombieHead;
		}
		Zombie zombie2 = zombie.next;
		int num4 = 0;
		if (zombie2 != num4)
		{
			zombie.next.pre = this;
			Zombie zombie3 = zombie.next;
			this.next = zombie3;
		}
		this.pre = zombie;
		zombie.next = this;
		Dictionary<ZombieType, List<Zombie>> zombieHeads = this.board.zombieHeads;
		ZombieType zombieType = this.theZombieType;
		List<Zombie> list;
		if (!zombieHeads.TryGetValue(zombieType, num))
		{
			list = new List();
			Dictionary<ZombieType, List<Zombie>> zombieHeads2 = this.board.zombieHeads;
			ZombieType zombieType2 = this.theZombieType;
			zombieHeads2[zombieType2] = list;
		}
		int size = list._size;
		list._size = list;
		if (!this.isMindControlled)
		{
			this.InitArmor();
		}
		if (this.axis.TryGetComponent<SpriteRenderer>(num))
		{
			Material material = GameMaterial.GetMaterial(MaterialType.Default);
		}
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x000C2EB4 File Offset: 0x000C10B4
	[Token(Token = "0x600259E")]
	[Address(RVA = "0x61CE10", Offset = "0x61B410", VA = "0x18061CE10", Slot = "17")]
	protected virtual void Update()
	{
		int num5;
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
				int num4 = 0;
				this.attributeCountDown = (float)num4;
				this.AttributeEvent();
			}
			num5 = 0;
			float num6 = this.dogeTime;
			if (num6 > (float)num2)
			{
				float deltaTime2 = Time.deltaTime;
				this.dogeTime = num6;
				this.dogeTime = (float)num5;
			}
			this.ZombieUpdate();
			this.theHealth = (long)num5;
			int num7 = 0;
			this.Die(num7);
			List<ZombieTimer> list = Enumerable.ToList<ZombieTimer>(this.timers.Keys);
			bool flag;
			if (flag)
			{
				if (this.timers[num] <= num2)
				{
					continue;
				}
				num6 = this.timers[num];
				float deltaTime3 = Time.deltaTime;
				float num8 = this.timers[num];
				Dictionary<ZombieTimer, float> dictionary = this.timers;
			}
		}
		while (num5 != 0);
		float deltaTime4 = Time.deltaTime;
		float deltaTime5 = Time.deltaTime;
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x000C2FD0 File Offset: 0x000C11D0
	[Token(Token = "0x600259F")]
	[Address(RVA = "0x614280", Offset = "0x612880", VA = "0x180614280", Slot = "18")]
	protected virtual void FixedUpdate()
	{
		ulong num8;
		do
		{
			int num = 0;
			if ((this.beforeDying ? 1 : 0) != num)
			{
				long num2 = this.theHealth;
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

	// Token: 0x060025A0 RID: 9632 RVA: 0x000C3094 File Offset: 0x000C1294
	[Token(Token = "0x60025A0")]
	[Address(RVA = "0x616B80", Offset = "0x615180", VA = "0x180616B80")]
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

	// Token: 0x060025A1 RID: 9633 RVA: 0x000C30D0 File Offset: 0x000C12D0
	[Token(Token = "0x60025A1")]
	[Address(RVA = "0x616C80", Offset = "0x615280", VA = "0x180616C80")]
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
			Func<KeyValuePair<ZombieFragile, float>, float> <>9__140_ = Zombie.<>c.<>9__140_0;
			if (<>9__140_ == 0)
			{
				Func<KeyValuePair<ZombieFragile, float>, float> func;
				Zombie.<>c.<>9__140_0 = func;
			}
			float num3 = Enumerable.Sum<KeyValuePair<ZombieFragile, float>>(dictionary3, <>9__140_);
			this.fragileValue = num3;
		}
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x000C3134 File Offset: 0x000C1334
	[Token(Token = "0x60025A2")]
	[Address(RVA = "0x61D230", Offset = "0x61B830", VA = "0x18061D230")]
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

	// Token: 0x060025A3 RID: 9635 RVA: 0x000C322C File Offset: 0x000C142C
	[Token(Token = "0x60025A3")]
	[Address(RVA = "0x615D80", Offset = "0x614380", VA = "0x180615D80")]
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

	// Token: 0x060025A4 RID: 9636 RVA: 0x000C3324 File Offset: 0x000C1524
	[Token(Token = "0x60025A4")]
	[Address(RVA = "0x60ED40", Offset = "0x60D340", VA = "0x18060ED40")]
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

	// Token: 0x060025A5 RID: 9637 RVA: 0x000C334C File Offset: 0x000C154C
	[Token(Token = "0x60025A5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "19")]
	protected virtual void ZombieUpdate()
	{
	}

	// Token: 0x060025A6 RID: 9638 RVA: 0x000C335C File Offset: 0x000C155C
	[Token(Token = "0x60025A6")]
	[Address(RVA = "0x617690", Offset = "0x615C90", VA = "0x180617690", Slot = "20")]
	protected virtual void OverRangeDie()
	{
		Transform axis = this.axis;
		Transform axis2 = this.axis;
		float num = this.deadLeft;
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x000C3388 File Offset: 0x000C1588
	[Token(Token = "0x60025A7")]
	[Address(RVA = "0x616EB0", Offset = "0x6154B0", VA = "0x180616EB0", Slot = "21")]
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

	// Token: 0x060025A8 RID: 9640 RVA: 0x000C3458 File Offset: 0x000C1658
	[Token(Token = "0x60025A8")]
	[Address(RVA = "0x61CCF0", Offset = "0x61B2F0", VA = "0x18061CCF0")]
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

	// Token: 0x060025A9 RID: 9641 RVA: 0x000C34E4 File Offset: 0x000C16E4
	[Token(Token = "0x60025A9")]
	[Address(RVA = "0x617D90", Offset = "0x616390", VA = "0x180617D90", Slot = "22")]
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

	// Token: 0x060025AA RID: 9642 RVA: 0x000C36B0 File Offset: 0x000C18B0
	[Token(Token = "0x60025AA")]
	[Address(RVA = "0x616AE0", Offset = "0x6150E0", VA = "0x180616AE0")]
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

	// Token: 0x060025AB RID: 9643 RVA: 0x000C3704 File Offset: 0x000C1904
	[Token(Token = "0x60025AB")]
	[Address(RVA = "0x60D640", Offset = "0x60BC40", VA = "0x18060D640")]
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

	// Token: 0x060025AC RID: 9644 RVA: 0x000C3768 File Offset: 0x000C1968
	[Token(Token = "0x60025AC")]
	[Address(RVA = "0x617130", Offset = "0x615730", VA = "0x180617130", Slot = "23")]
	protected virtual void OnFixedUpdate()
	{
		do
		{
			this.OverRangeDie();
		}
		while (this.Alive);
		this.theAttackTarget = (ulong)0L;
		this.isAttacking = false;
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x000C3794 File Offset: 0x000C1994
	[Token(Token = "0x60025AD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "24")]
	protected virtual void AttributeEvent()
	{
	}

	// Token: 0x060025AE RID: 9646 RVA: 0x000C37A4 File Offset: 0x000C19A4
	[Token(Token = "0x60025AE")]
	[Address(RVA = "0x60F320", Offset = "0x60D920", VA = "0x18060F320")]
	public void DamagedByPoison(float damageMultiplier = 1f)
	{
		if (AdvantureConfig.data.GetResult(AdvantureLevel.Roof4, (MissionResult)((uint)1)))
		{
		}
	}

	// Token: 0x060025AF RID: 9647 RVA: 0x000C37CC File Offset: 0x000C19CC
	[Token(Token = "0x60025AF")]
	[Address(RVA = "0x60E880", Offset = "0x60CE80", VA = "0x18060E880", Slot = "25")]
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

	// Token: 0x060025B0 RID: 9648 RVA: 0x000C3820 File Offset: 0x000C1A20
	[Token(Token = "0x60025B0")]
	[Address(RVA = "0x60E960", Offset = "0x60CF60", VA = "0x18060E960", Slot = "26")]
	public virtual void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
		float num;
		do
		{
			AdvantureData data = AdvantureConfig.data;
			bool flag;
			if (flag)
			{
			}
			if (GameAPP.config.difficulty >= 4 || this.theHealth > (long)damage)
			{
			}
			if (this.takeDmgMultiplier == 0f)
			{
			}
		}
		while (GameAPP.config.difficulty == 4 && 0 > (int)num);
		if (GameAPP.config.difficulty == 5)
		{
			int i = 0;
			float num2 = num * 0.4f;
			while (i > (int)num2)
			{
			}
		}
		DamageReporter damageReporter = this.board.damageReporter;
		int num3 = 0;
		if (0 <= num3)
		{
		}
		Vector2 centerPosition = this.CenterPosition;
		this.SetCarred();
	}

	// Token: 0x060025B1 RID: 9649 RVA: 0x000C38BC File Offset: 0x000C1ABC
	[Token(Token = "0x60025B1")]
	[Address(RVA = "0x618F70", Offset = "0x617570", VA = "0x180618F70")]
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

	// Token: 0x060025B2 RID: 9650 RVA: 0x000C3A5C File Offset: 0x000C1C5C
	[Token(Token = "0x60025B2")]
	[Address(RVA = "0x612FA0", Offset = "0x6115A0", VA = "0x180612FA0")]
	private bool ExistAnim()
	{
		for (;;)
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
			}
			IL_0044:
			if (this.theStatus <= ZombieStatus.Pol_jump)
			{
				continue;
			}
			uint num;
			while (num == (uint)(-3))
			{
			}
			if (num > (uint)1)
			{
				return false;
			}
			if (0 != -3)
			{
				break;
			}
			continue;
			IL_002D:
			i = 0;
			goto IL_002F;
		}
		return false;
	}

	// Token: 0x060025B3 RID: 9651 RVA: 0x000C3ACC File Offset: 0x000C1CCC
	[Token(Token = "0x60025B3")]
	[Address(RVA = "0x61A110", Offset = "0x618710", VA = "0x18061A110", Slot = "27")]
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
			if ((this.subed ? 1 : 0) == num)
			{
				Board board2 = this.board;
				this.subed = true;
			}
			BoardStatistics boardStatistics = this.board.boardStatistics;
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

	// Token: 0x060025B4 RID: 9652 RVA: 0x000C3C84 File Offset: 0x000C1E84
	[Token(Token = "0x60025B4")]
	[Address(RVA = "0x60F5A0", Offset = "0x60DBA0", VA = "0x18060F5A0", Slot = "28")]
	public virtual void Die(int reason = 0)
	{
		int num;
		int num5;
		uint num10;
		do
		{
			num = 0;
			int num2 = 0;
			if ((this.subed ? 1 : 0) == num2)
			{
				this.subed = true;
				Board board = this.board;
			}
			if (this.theStatus == ZombieStatus.Dying)
			{
				goto IL_02F1;
			}
			this.dieReason = reason;
			this.theStatus = (ZombieStatus)((ulong)1L);
			if ((this.isMindControlled ? 1 : 0) == num2)
			{
				BoardStatistics boardStatistics = this.board.boardStatistics;
				Dictionary<ZombieType, int> zombiesKilledByType = this.board.boardStatistics.zombiesKilledByType;
				ZombieType zombieType = this.theZombieType;
				bool flag = zombiesKilledByType.ContainsKey(zombieType);
				Board board2 = this.board;
				if (!flag)
				{
					Dictionary<ZombieType, int> zombiesKilledByType2 = board2.boardStatistics.zombiesKilledByType;
				}
				ZombieType zombieType2 = this.theZombieType;
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
			Board board3 = this.board;
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
			if (this.onDeath != 0)
			{
			}
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
		IL_02F1:
		GameObject gameObject3;
		global::UnityEngine.Object.Destroy(gameObject3);
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x000C3F90 File Offset: 0x000C2190
	[Token(Token = "0x60025B5")]
	[Address(RVA = "0x6187C0", Offset = "0x616DC0", VA = "0x1806187C0")]
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

	// Token: 0x060025B6 RID: 9654 RVA: 0x000C40EC File Offset: 0x000C22EC
	[Token(Token = "0x60025B6")]
	[Address(RVA = "0x612C40", Offset = "0x611240", VA = "0x180612C40")]
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

	// Token: 0x060025B7 RID: 9655 RVA: 0x000C4164 File Offset: 0x000C2364
	[Token(Token = "0x60025B7")]
	[Address(RVA = "0x6164B0", Offset = "0x614AB0", VA = "0x1806164B0")]
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

	// Token: 0x060025B8 RID: 9656 RVA: 0x000C41FC File Offset: 0x000C23FC
	[Token(Token = "0x60025B8")]
	[Address(RVA = "0x610A70", Offset = "0x60F070", VA = "0x180610A70")]
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

	// Token: 0x060025B9 RID: 9657 RVA: 0x000C42A0 File Offset: 0x000C24A0
	[Token(Token = "0x60025B9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "29")]
	protected virtual void DieEvent(int reason = 0)
	{
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x000C42B0 File Offset: 0x000C24B0
	[Token(Token = "0x60025BA")]
	[Address(RVA = "0x60DCE0", Offset = "0x60C2E0", VA = "0x18060DCE0", Slot = "30")]
	protected virtual void BodyTakeDamage(int theDamage)
	{
		do
		{
			long num = this.theHealth;
			num -= (long)theDamage;
			this.theHealth = num;
			if (!this.loseHand)
			{
				long num2 = this.theMaxHealth;
				num2 += num2;
				int num3 = 0;
				float num4;
				if (num4 > (float)num3)
				{
					GameObject gameObject = this.theSecondArmor;
					int num5 = 0;
					if (gameObject == num5)
					{
						this.loseHand = true;
						uint num6;
						GameAPP.PlaySound((int)num6, 0.5f, 1f);
						GameObject gameObject2 = base.gameObject;
						this.FindAndDestoryZombieHand(gameObject2);
						GameObject gameObject3 = base.gameObject;
						this.FindAndReplaceArmUpperSprite(gameObject3);
						int num7 = 0;
						int num8 = 0;
						int childCount = base.transform.childCount;
						if (num8 < childCount)
						{
							if (string.Equals(base.transform.GetChild(num7).name, "LoseArm"))
							{
								Transform child = base.transform.GetChild(num7);
								this.AnimLoseActive(child);
							}
							num7++;
							Transform transform = base.transform;
						}
					}
				}
			}
			if (this.beforeDying)
			{
				return;
			}
			int num9 = 0;
			float num10;
			if (num10 <= (float)num9)
			{
				return;
			}
			this.beforeDying = true;
			this.LoseHeadEvent();
			uint num11;
			GameAPP.PlaySound((int)num11, 0.5f, 1f);
			GameObject gameObject4 = base.gameObject;
			this.FindAndDestoryZombieHead(gameObject4);
			int num12 = 0;
			int num13 = 0;
			int childCount2 = base.transform.childCount;
			if (num13 >= childCount2)
			{
				break;
			}
			if (string.Equals(base.transform.GetChild(num12).name, "LoseHead"))
			{
				Transform child2 = base.transform.GetChild(num12);
				this.AnimLoseActive(child2);
			}
			num12++;
		}
		while (base.transform != 0);
		GameObject gameObject5 = this.theSecondArmor;
		int num14 = 0;
		if (gameObject5 != num14)
		{
			this.SecondArmorFall();
			this.theSecondArmorHealth = (int)((ulong)0L);
			this.theSecondArmorType = (Zombie.SecondArmorType)((ulong)0L);
			this.theSecondArmor = (ulong)0L;
		}
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x000C4484 File Offset: 0x000C2684
	[Token(Token = "0x60025BB")]
	[Address(RVA = "0x6163F0", Offset = "0x6149F0", VA = "0x1806163F0", Slot = "31")]
	protected virtual bool Instead(int damage)
	{
		List<Zombie> certainZombies = global::Lawnf.GetCertainZombies(this.board, (ZombieType)((uint)219));
		return true;
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x000C44B0 File Offset: 0x000C26B0
	[Token(Token = "0x60025BC")]
	[Address(RVA = "0x61B2B0", Offset = "0x6198B0", VA = "0x18061B2B0", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		int num = 0;
		this.flashTime = 0.2f;
		int num2 = 0;
		if (theDamage != 0)
		{
			int num3 = 0;
			if ((this.isMindControlled ? 1 : 0) == num)
			{
				int num4 = ((long)theDamage).ToInt();
				bool flag;
				bool flag2;
				if (!this.Instead(num4) && (!flag || this.takeDamageTimes > 50) && flag2)
				{
					if (this.lastMaxDamage == num3)
					{
						CancellationToken cancellationTokenOnDestroy = this.GetCancellationTokenOnDestroy();
						Action action = delegate
						{
							this.lastMaxDamage = (int)((ulong)0L);
						};
						int num5 = 0;
						int num6 = 0;
						ulong num7;
						TimePeriod.StartPeriod(0.2f, cancellationTokenOnDestroy, num6, num5, action, num3 != 0, (int)num7);
					}
					int num8 = this.lastMaxDamage;
					if (theDamage <= num8)
					{
						return;
					}
					int num9 = ((long)theDamage).ToInt();
					this.lastMaxDamage = num9;
				}
			}
			this.OnTakeDamage();
			this.lastTakeDamageDuring = (float)num3;
			long num11;
			int num10 = num11.ToInt();
			if ((this.isMindControlled ? 1 : 0) == num3)
			{
				bool flag3;
				if (!flag3)
				{
					Board board = this.board;
					if (num10 != 14)
					{
						DamageReporter damageReporter = board.damageReporter;
						Vector2 centerPosition = this.CenterPosition;
						DamageReporter damageReporter2 = this.board.damageReporter;
						AdvantureData data = AdvantureConfig.data;
						bool flag4;
						bool flag5;
						if (flag4 || flag5)
						{
							float num12 = (float)(num2 * (int)0.3f);
							DamageReporter damageReporter3 = this.board.damageReporter;
							Vector2 centerPosition2 = this.CenterPosition;
						}
						AdvantureData data2 = AdvantureConfig.data;
						bool flag6;
						if (!flag6)
						{
							goto IL_018C;
						}
						int num13 = this.theFirstArmorMaxHealth;
						int num14 = this.theSecondArmorMaxHealth;
						int num15 = this.theSecondArmorHealth;
						num14 += num13;
						int num16 = this.theFirstArmorHealth;
						uint num17;
						num14 -= (int)num17;
						num15 += num16;
						if (num15 < num14)
						{
							DamageReporter damageReporter4 = this.board.damageReporter;
							Vector2 centerPosition3 = this.CenterPosition;
							goto IL_018C;
						}
						goto IL_018C;
					}
					else
					{
						Vector2 centerPosition4 = this.CenterPosition;
					}
				}
				DamageReporter damageReporter5 = this.board.damageReporter;
				Vector2 centerPosition5 = this.CenterPosition;
				throw new NullReferenceException();
			}
			IL_018C:
			if (this.theHealth < (long)num3)
			{
				this.theHealth = (long)num3;
			}
			this.UpdateHealthText();
		}
	}

	// Token: 0x060025BD RID: 9661 RVA: 0x000C4690 File Offset: 0x000C2890
	[Token(Token = "0x60025BD")]
	[Address(RVA = "0x60CA20", Offset = "0x60B020", VA = "0x18060CA20")]
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

	// Token: 0x060025BE RID: 9662 RVA: 0x000C480C File Offset: 0x000C2A0C
	[Token(Token = "0x60025BE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "32")]
	protected virtual void OnDodge()
	{
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x000C481C File Offset: 0x000C2A1C
	[Token(Token = "0x60025BF")]
	[Address(RVA = "0x614CE0", Offset = "0x6132E0", VA = "0x180614CE0", Slot = "33")]
	public virtual long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num = 0;
		GameConfig config = GameAPP.config;
		TravelMgr instance = TravelMgr.Instance;
		if (!this.isMindControlled)
		{
			bool flag;
			if (flag && flag)
			{
				this.OnDodge();
			}
			int num2 = 0;
			int num3 = 0;
			uint num4;
			num4 -= (uint)num;
			if (num2 <= num3)
			{
			}
			if (SingleBuffManager.CheckBuff(SingleBuffManager.BuffType.Damage))
			{
			}
			bool flag2;
			if (flag2)
			{
				bool flag3;
				if (flag3)
				{
				}
				bool flag4;
				if (flag4)
				{
				}
			}
			if (RogueManager.Instance.leaderType == LeaderType.SnowGatlingPuff)
			{
			}
			if (theDamageType == DamageType.Squash)
			{
				AdvantureData data = AdvantureConfig.data;
				bool flag5;
				if (flag5)
				{
				}
			}
			float num5;
			if (num5 > (float)num2)
			{
				float num6 = global::UnityEngine.Random.Range((float)0, 1f);
				float num7;
				if (num7 > num6)
				{
				}
			}
			float num11;
			if (!fix)
			{
				float num9;
				float num8 = num9;
				float num10 = num8 * 0.4f * 0.7f;
				bool flag6;
				if (global::Lawnf.TravelCurse() || TravelMgr.Instance.data.invest_challenge || flag6)
				{
					num11 = num10 * 0.5f;
				}
			}
			bool flag7;
			if (!flag7 || num11 > 1800f)
			{
			}
			bool flag8;
			if (flag8)
			{
				float time = Time.time;
			}
			bool flag9;
			if (flag9)
			{
			}
			bool flag10;
			if (!flag10)
			{
				goto IL_013B;
			}
			if (global::Lawnf.GetAllPlants()._size <= 5)
			{
			}
		}
		bool flag11;
		bool flag12;
		if (!flag11 || flag12)
		{
		}
		TravelData data2 = TravelMgr.Instance.data;
		IL_013B:
		bool flag13;
		bool flag14;
		if (!flag13 || flag14)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x000C497C File Offset: 0x000C2B7C
	[Token(Token = "0x60025C0")]
	[Address(RVA = "0x61CB60", Offset = "0x61B160", VA = "0x18061CB60")]
	private void UpdateShooting(float lastDamage, PlantType fromType)
	{
		bool flag;
		if (flag)
		{
			float time = Time.time;
			if (lastDamage > time)
			{
			}
		}
		bool flag2;
		if (flag2)
		{
			DamageReporter damageReporter = this.board.damageReporter;
			if (fromType != damageReporter.maxDamageType)
			{
			}
		}
		bool flag3;
		if (!flag3 || global::Lawnf.GetAllPlants()._size <= 5)
		{
		}
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x000C49D8 File Offset: 0x000C2BD8
	[Token(Token = "0x60025C1")]
	[Address(RVA = "0x6171B0", Offset = "0x6157B0", VA = "0x1806171B0")]
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
			if (Zombie.<>c.<>9__172_0 == 0)
			{
				Zombie.<>c.<>9__172_0 = func;
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

	// Token: 0x060025C2 RID: 9666 RVA: 0x000C4ABC File Offset: 0x000C2CBC
	[Token(Token = "0x60025C2")]
	[Address(RVA = "0x615B90", Offset = "0x614190", VA = "0x180615B90")]
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

	// Token: 0x060025C3 RID: 9667 RVA: 0x000C4B6C File Offset: 0x000C2D6C
	[Token(Token = "0x60025C3")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "34")]
	protected virtual void LoseHeadEvent()
	{
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x000C4B7C File Offset: 0x000C2D7C
	[Token(Token = "0x60025C4")]
	[Address(RVA = "0x618BB0", Offset = "0x6171B0", VA = "0x180618BB0", Slot = "35")]
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

	// Token: 0x060025C5 RID: 9669 RVA: 0x000C4C4C File Offset: 0x000C2E4C
	[Token(Token = "0x60025C5")]
	[Address(RVA = "0x613220", Offset = "0x611820", VA = "0x180613220")]
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

	// Token: 0x060025C6 RID: 9670 RVA: 0x000C4CC0 File Offset: 0x000C2EC0
	[Token(Token = "0x60025C6")]
	[Address(RVA = "0x613490", Offset = "0x611A90", VA = "0x180613490")]
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

	// Token: 0x060025C7 RID: 9671 RVA: 0x000C4D40 File Offset: 0x000C2F40
	[Token(Token = "0x60025C7")]
	[Address(RVA = "0x60C6A0", Offset = "0x60ACA0", VA = "0x18060C6A0", Slot = "36")]
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

	// Token: 0x060025C8 RID: 9672 RVA: 0x000C4E58 File Offset: 0x000C3058
	[Token(Token = "0x60025C8")]
	[Address(RVA = "0x613730", Offset = "0x611D30", VA = "0x180613730", Slot = "37")]
	protected virtual void FindAndReplaceArmUpperSprite(GameObject obj)
	{
		int num;
		do
		{
			num = 0;
			if (obj.CompareTag("ZombieArmUpper"))
			{
				break;
			}
			GameObject gameObject;
			if (obj.transform.GetEnumerator() != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				this.FindAndReplaceArmUpperSprite(gameObject);
			}
			if (gameObject != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x000C4EC4 File Offset: 0x000C30C4
	[Token(Token = "0x60025C9")]
	[Address(RVA = "0x60E790", Offset = "0x60CD90", VA = "0x18060E790", Slot = "38")]
	protected virtual void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = GameAPP.spritePrefab[0];
		component.sprite = sprite;
		Transform transform = arm.transform;
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x000C4EFC File Offset: 0x000C30FC
	[Token(Token = "0x60025CA")]
	[Address(RVA = "0x6139B0", Offset = "0x611FB0", VA = "0x1806139B0")]
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

	// Token: 0x060025CB RID: 9675 RVA: 0x000C4F48 File Offset: 0x000C3148
	[Token(Token = "0x60025CB")]
	[Address(RVA = "0x614550", Offset = "0x612B50", VA = "0x180614550")]
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

	// Token: 0x060025CC RID: 9676 RVA: 0x000C4FA4 File Offset: 0x000C31A4
	[Token(Token = "0x60025CC")]
	[Address(RVA = "0x618F10", Offset = "0x617510", VA = "0x180618F10")]
	protected void SetBrightness(float b)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x060025CD RID: 9677 RVA: 0x000C4FC0 File Offset: 0x000C31C0
	[Token(Token = "0x60025CD")]
	[Address(RVA = "0x617710", Offset = "0x615D10", VA = "0x180617710", Slot = "39")]
	protected virtual void PlayEatSound2()
	{
		if (this.Alive)
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

	// Token: 0x060025CE RID: 9678 RVA: 0x000C502C File Offset: 0x000C322C
	[Token(Token = "0x60025CE")]
	[Address(RVA = "0x60D270", Offset = "0x60B870", VA = "0x18060D270", Slot = "40")]
	protected virtual void AttackUpdate()
	{
		List<IDamageable> list = this.contacts;
		Func<IDamageable, bool> func = (IDamageable a) => false;
		IEnumerable<IDamageable> enumerable = Enumerable.Where<IDamageable>(list, func);
		if (Enumerable.Count<IDamageable>(enumerable) != 0)
		{
			Func<IDamageable, int> <>9__185_ = Zombie.<>c.<>9__185_1;
			if (<>9__185_ == 0)
			{
				Func<IDamageable, int> func2;
				Zombie.<>c.<>9__185_1 = func2;
			}
			IDamageable damageable = Enumerable.FirstOrDefault<IDamageable>(Enumerable.OrderBy<IDamageable, int>(enumerable, <>9__185_));
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

	// Token: 0x060025CF RID: 9679 RVA: 0x000C50B8 File Offset: 0x000C32B8
	[Token(Token = "0x60025CF")]
	[Address(RVA = "0x60E2A0", Offset = "0x60C8A0", VA = "0x18060E2A0", Slot = "13")]
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
						if (Zombie.<>c.<>9__186_0 == 0)
						{
							func = (Plant p) => p.thePlantType == PlantType.ScaredyBlover;
							Zombie.<>c.<>9__186_0 = func;
						}
						List<Plant> list;
						Plant plant = Enumerable.FirstOrDefault<Plant>(list, func);
						bool flag3 = plant;
						SortingGroup sortingGroup = plant.sortingGroup;
						if (sortingGroup > (ulong)10L)
						{
							if (sortingGroup != (ulong)12L && flag3 > true && sortingGroup != (ulong)44L)
							{
								goto IL_00BA;
							}
						}
					}
				}
			}
		}
		IL_0095:
		while (typeof(Zombie).TypeHandle == (ulong)1L)
		{
		}
		while (typeof(Zombie).TypeHandle == (ulong)10L)
		{
		}
		int num4 = this.theZombieRow;
		int num5 = this.theZombieRow;
		goto IL_00BA;
		goto IL_0095;
		IL_00BA:
		throw new NullReferenceException();
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x000C5188 File Offset: 0x000C3388
	[Token(Token = "0x60025D0")]
	[Address(RVA = "0x617500", Offset = "0x615B00", VA = "0x180617500", Slot = "41")]
	protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			List<IDamageable> list = this.contacts;
		}
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x000C51A8 File Offset: 0x000C33A8
	[Token(Token = "0x60025D1")]
	[Address(RVA = "0x6175B0", Offset = "0x615BB0", VA = "0x1806175B0", Slot = "42")]
	protected virtual void OnTriggerExit2D(Collider2D collision)
	{
		if (!this.Alive)
		{
			this.theAttackTarget = (ulong)0L;
			this.isAttacking = false;
			return;
		}
		bool flag;
		while (!flag)
		{
		}
		List<IDamageable> list = this.contacts;
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x000C51E4 File Offset: 0x000C33E4
	[Token(Token = "0x60025D2")]
	[Address(RVA = "0x6158A0", Offset = "0x613EA0", VA = "0x1806158A0", Slot = "43")]
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

	// Token: 0x060025D3 RID: 9683 RVA: 0x000C5254 File Offset: 0x000C3454
	[Token(Token = "0x60025D3")]
	[Address(RVA = "0x60E710", Offset = "0x60CD10", VA = "0x18060E710", Slot = "44")]
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

	// Token: 0x060025D4 RID: 9684 RVA: 0x000C5298 File Offset: 0x000C3498
	[Token(Token = "0x60025D4")]
	[Address(RVA = "0x6178F0", Offset = "0x615EF0", VA = "0x1806178F0", Slot = "45")]
	public virtual void PlayEatSound()
	{
		if (this.Alive)
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

	// Token: 0x060025D5 RID: 9685 RVA: 0x000C5328 File Offset: 0x000C3528
	[Token(Token = "0x60025D5")]
	[Address(RVA = "0x60CE00", Offset = "0x60B400", VA = "0x18060CE00")]
	private void AttackBrain(Brain brain)
	{
		int num = brain.theHealth;
		brain.theHealth = num;
		uint num2;
		uint num3;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num2, (int)num3), 0.3f, 1f);
		brain.FlashOnce();
	}

	// Token: 0x060025D6 RID: 9686 RVA: 0x000C5368 File Offset: 0x000C3568
	[Token(Token = "0x60025D6")]
	[Address(RVA = "0x60D4D0", Offset = "0x60BAD0", VA = "0x18060D4D0")]
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

	// Token: 0x060025D7 RID: 9687 RVA: 0x000C53B8 File Offset: 0x000C35B8
	[Token(Token = "0x60025D7")]
	[Address(RVA = "0x617D20", Offset = "0x616320", VA = "0x180617D20", Slot = "46")]
	public virtual void PlayFallSound()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(5, 7), 0.5f, 1f);
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x000C53DC File Offset: 0x000C35DC
	[Token(Token = "0x60025D8")]
	[Address(RVA = "0x60F520", Offset = "0x60DB20", VA = "0x18060F520", Slot = "47")]
	public virtual void DestoryZombie()
	{
		int num;
		Zombie.<DecreaseTransparent>d__196 <DecreaseTransparent>d__ = new Zombie.<DecreaseTransparent>d__196(num);
		num = 0;
		<DecreaseTransparent>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<DecreaseTransparent>d__);
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x000C5408 File Offset: 0x000C3608
	[Token(Token = "0x60025D9")]
	[Address(RVA = "0x60F4B0", Offset = "0x60DAB0", VA = "0x18060F4B0")]
	private IEnumerator DecreaseTransparent()
	{
		int num;
		Zombie.<DecreaseTransparent>d__196 <DecreaseTransparent>d__ = new Zombie.<DecreaseTransparent>d__196(num);
		num = 0;
		<DecreaseTransparent>d__.<>4__this = this;
		throw new NullReferenceException();
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x000C542C File Offset: 0x000C362C
	[Token(Token = "0x60025DA")]
	[Address(RVA = "0x60E950", Offset = "0x60CF50", VA = "0x18060E950")]
	public void ChangeStatus(ZombieStatus targetStatus)
	{
		if (this.theStatus != ZombieStatus.Dying)
		{
			this.theStatus = targetStatus;
		}
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x000C544C File Offset: 0x000C364C
	[Token(Token = "0x60025DB")]
	[Address(RVA = "0x610DA0", Offset = "0x60F3A0", VA = "0x180610DA0")]
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
		if (board5 == 0)
		{
			Transform axis3 = this.axis;
			CreateItem instance = CreateItem.Instance;
			Vector3 vector3;
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
			float currentRoundPoint = this.board.currentRoundPoint;
			int num4 = this.theSecondArmorMaxHealth;
			int num5 = this.theFirstArmorMaxHealth;
			num4 += num5;
			float num6;
			if (num6 <= 1.5f)
			{
			}
			float num7 = num6 * 3f;
			if (global::Lawnf.TravelCurse())
			{
			}
			Board board7 = this.board;
			num6 = num7;
			board7.currentRoundPoint = num6;
			ulong num8;
			this.board.GetPoint(num7, num8 != 0UL);
			Transform axis4 = this.axis;
			Board board8 = this.board;
			int num9 = this.theZombieRow;
			int num10;
			if (board8.GetBoxType(num10, num9) == BoxType.Water)
			{
				Transform axis5 = this.axis;
				CreatePlant instance2 = CreatePlant.Instance;
			}
			Board board9 = this.board;
			ulong num11;
			PlayerShootingManager.Instance.Evolution(num11 != 0UL);
		}
	}

	// Token: 0x060025DC RID: 9692 RVA: 0x000C562C File Offset: 0x000C382C
	[Token(Token = "0x60025DC")]
	[Address(RVA = "0x611460", Offset = "0x60FA60", VA = "0x180611460")]
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

	// Token: 0x060025DD RID: 9693 RVA: 0x000C56FC File Offset: 0x000C38FC
	[Token(Token = "0x60025DD")]
	[Address(RVA = "0x61A800", Offset = "0x618E00", VA = "0x18061A800")]
	private void ShootingDropSun()
	{
		int num = this.theSecondArmorMaxHealth;
		int num2 = this.theFirstArmorMaxHealth;
		num += num2;
		this.droppedSun = true;
		Transform axis = this.axis;
		CreateItem instance = CreateItem.Instance;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		uint num6;
		Vector3 vector;
		ulong num7;
		GameObject gameObject = instance.SetCoin(num5, num4, (int)num6, num3, vector, num7 != 0UL);
		Transform axis2 = this.axis;
		CreateItem instance2 = CreateItem.Instance;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		uint num11;
		Vector3 vector2;
		ulong num12;
		GameObject gameObject2 = instance2.SetCoin(num10, num9, (int)num11, num8, vector2, num12 != 0UL);
		Transform axis3 = this.axis;
		CreateItem instance3 = CreateItem.Instance;
		int num13 = 0;
		int num14 = 0;
		int num15 = 0;
		uint num16;
		Vector3 vector3;
		ulong num17;
		GameObject gameObject3 = instance3.SetCoin(num15, num14, (int)num16, num13, vector3, num17 != 0UL);
		Board board = this.board;
		Transform axis4 = this.axis;
		CreateItem instance4 = CreateItem.Instance;
		int num18 = 0;
		int num19 = 0;
		uint num20;
		Vector3 vector4;
		ulong num21;
		GameObject gameObject4 = instance4.SetCoin(num19, num18, (int)num20, num13, vector4, num21 != 0UL);
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x000C57E4 File Offset: 0x000C39E4
	[Token(Token = "0x60025DE")]
	[Address(RVA = "0x6117A0", Offset = "0x60FDA0", VA = "0x1806117A0")]
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

	// Token: 0x060025DF RID: 9695 RVA: 0x000C5870 File Offset: 0x000C3A70
	[Token(Token = "0x60025DF")]
	[Address(RVA = "0x610300", Offset = "0x60E900", VA = "0x180610300")]
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

	// Token: 0x060025E0 RID: 9696 RVA: 0x000C58F0 File Offset: 0x000C3AF0
	[Token(Token = "0x60025E0")]
	[Address(RVA = "0x610510", Offset = "0x60EB10", VA = "0x180610510")]
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
			if (Zombie.<>c.<>9__203_0 == 0)
			{
				predicate = delegate(PlantType p)
				{
					bool flag2;
					bool flag3;
					return flag2 || p == PlantType.PresentZombie || flag3;
				};
				Zombie.<>c.<>9__203_0 = predicate;
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

	// Token: 0x060025E1 RID: 9697 RVA: 0x000C5A2C File Offset: 0x000C3C2C
	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x60C540", Offset = "0x60AB40", VA = "0x18060C540")]
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

	// Token: 0x060025E2 RID: 9698 RVA: 0x000C5A6C File Offset: 0x000C3C6C
	[Token(Token = "0x60025E2")]
	[Address(RVA = "0x61BA10", Offset = "0x61A010", VA = "0x18061BA10", Slot = "48")]
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

	// Token: 0x060025E3 RID: 9699 RVA: 0x000C5C2C File Offset: 0x000C3E2C
	[Token(Token = "0x60025E3")]
	[Address(RVA = "0x6159A0", Offset = "0x613FA0", VA = "0x1806159A0")]
	private Color GetMixColor(List<Color> colors)
	{
		int num = 0;
		num++;
		return default(Color);
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x000C5C48 File Offset: 0x000C3E48
	[Token(Token = "0x60025E4")]
	[Address(RVA = "0x614C20", Offset = "0x613220", VA = "0x180614C20")]
	private Color GetColor(Zombie.ZombieColor colorType)
	{
		Dictionary<Zombie.ZombieColor, Color> colorDictionary = Zombie.ColorDictionary;
		bool flag;
		if (!flag)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x000C5C70 File Offset: 0x000C3E70
	[Token(Token = "0x60025E5")]
	[Address(RVA = "0x618B10", Offset = "0x617110", VA = "0x180618B10")]
	public void Scared()
	{
		float num = this.theOriginSpeed;
		this.theOriginSpeed = num;
		this.towards = (Towards)((ulong)1L);
		Transform transform = base.transform;
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x000C5CA4 File Offset: 0x000C3EA4
	[Token(Token = "0x60025E6")]
	[Address(RVA = "0x616910", Offset = "0x614F10", VA = "0x180616910")]
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

	// Token: 0x060025E7 RID: 9703 RVA: 0x000C5D00 File Offset: 0x000C3F00
	[Token(Token = "0x60025E7")]
	[Address(RVA = "0x61BA00", Offset = "0x61A000", VA = "0x18061BA00", Slot = "49")]
	public virtual void Unfreezing()
	{
		bool flag = base.RemoveBuff((EffectType)((uint)2));
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x000C5D18 File Offset: 0x000C3F18
	[Token(Token = "0x60025E8")]
	[Address(RVA = "0x60C4E0", Offset = "0x60AAE0", VA = "0x18060C4E0")]
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

	// Token: 0x060025E9 RID: 9705 RVA: 0x000C5D4C File Offset: 0x000C3F4C
	[Token(Token = "0x60025E9")]
	[Address(RVA = "0x61A6F0", Offset = "0x618CF0", VA = "0x18061A6F0", Slot = "50")]
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

	// Token: 0x060025EA RID: 9706 RVA: 0x000C5D70 File Offset: 0x000C3F70
	[Token(Token = "0x60025EA")]
	[Address(RVA = "0x619D80", Offset = "0x618380", VA = "0x180619D80")]
	public void SetGold()
	{
		this.isGold = true;
	}

	// Token: 0x060025EB RID: 9707 RVA: 0x000C5D84 File Offset: 0x000C3F84
	[Token(Token = "0x60025EB")]
	[Address(RVA = "0x619DA0", Offset = "0x6183A0", VA = "0x180619DA0", Slot = "51")]
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

	// Token: 0x060025EC RID: 9708 RVA: 0x000C5DD0 File Offset: 0x000C3FD0
	[Token(Token = "0x60025EC")]
	[Address(RVA = "0x619940", Offset = "0x617F40", VA = "0x180619940", Slot = "52")]
	public virtual void SetEmbered(bool ulti = false)
	{
		if (this.SetEffect((EffectType)((uint)3), 1f, 1f) && ulti)
		{
			this.ultiEmbered = true;
		}
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x000C5E00 File Offset: 0x000C4000
	[Token(Token = "0x60025ED")]
	[Address(RVA = "0x619990", Offset = "0x617F90", VA = "0x180619990", Slot = "53")]
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

	// Token: 0x060025EE RID: 9710 RVA: 0x000C5E7C File Offset: 0x000C407C
	[Token(Token = "0x60025EE")]
	[Address(RVA = "0x61A620", Offset = "0x618C20", VA = "0x18061A620", Slot = "54")]
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

	// Token: 0x060025EF RID: 9711 RVA: 0x000C5EA4 File Offset: 0x000C40A4
	[Token(Token = "0x60025EF")]
	[Address(RVA = "0x60C320", Offset = "0x60A920", VA = "0x18060C320", Slot = "55")]
	public virtual void AddPoisonLevel()
	{
		if (!global::Lawnf.TravelUltimate((UltiBuff)((uint)13)))
		{
			bool flag = this.SetEffect((EffectType)((uint)4), 5f, 1f);
			return;
		}
	}

	// Token: 0x060025F0 RID: 9712 RVA: 0x000C5ED0 File Offset: 0x000C40D0
	[Token(Token = "0x60025F0")]
	[Address(RVA = "0x619580", Offset = "0x617B80", VA = "0x180619580", Slot = "56")]
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

	// Token: 0x060025F1 RID: 9713 RVA: 0x000C5F2C File Offset: 0x000C412C
	[Token(Token = "0x60025F1")]
	[Address(RVA = "0x619E20", Offset = "0x618420", VA = "0x180619E20", Slot = "57")]
	public virtual void SetKelped(float time, bool land = false)
	{
		int num = (int)this.theZombieType;
		bool flag;
		bool flag2;
		if (!flag && flag2)
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

	// Token: 0x060025F2 RID: 9714 RVA: 0x000C5F74 File Offset: 0x000C4174
	[Token(Token = "0x60025F2")]
	[Address(RVA = "0x61D1E0", Offset = "0x61B7E0", VA = "0x18061D1E0")]
	public void Warm()
	{
		bool flag = base.RemoveBuff((EffectType)((uint)2));
		bool flag2 = base.RemoveBuff((EffectType)((uint)10));
		int num = 0;
		bool flag3 = base.RemoveBuff((EffectType)num);
		bool flag4 = base.RemoveBuff((EffectType)((uint)4));
	}

	// Token: 0x060025F3 RID: 9715 RVA: 0x000C5FA8 File Offset: 0x000C41A8
	[Token(Token = "0x60025F3")]
	[Address(RVA = "0x60E0E0", Offset = "0x60C6E0", VA = "0x18060E0E0", Slot = "58")]
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

	// Token: 0x060025F4 RID: 9716 RVA: 0x000C6044 File Offset: 0x000C4244
	[Token(Token = "0x60025F4")]
	[Address(RVA = "0x60EC60", Offset = "0x60D260", VA = "0x18060EC60")]
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
		return false;
	}

	// Token: 0x060025F5 RID: 9717 RVA: 0x000C60A0 File Offset: 0x000C42A0
	[Token(Token = "0x60025F5")]
	[Address(RVA = "0x61B9F0", Offset = "0x619FF0", VA = "0x18061B9F0", Slot = "59")]
	protected virtual void UnButtered()
	{
		bool flag = base.RemoveBuff((EffectType)((uint)6));
	}

	// Token: 0x060025F6 RID: 9718 RVA: 0x000C60B8 File Offset: 0x000C42B8
	[Token(Token = "0x60025F6")]
	[Address(RVA = "0x6129F0", Offset = "0x610FF0", VA = "0x1806129F0", Slot = "60")]
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

	// Token: 0x060025F7 RID: 9719 RVA: 0x000C6184 File Offset: 0x000C4384
	[Token(Token = "0x60025F7")]
	[Address(RVA = "0x60F400", Offset = "0x60DA00", VA = "0x18060F400")]
	private IEnumerator DeLayGarliced(float during, bool playSound, bool certainRow)
	{
		int num;
		Zombie.<DeLayGarliced>d__226 <DeLayGarliced>d__ = new Zombie.<DeLayGarliced>d__226(num);
		num = 0;
		<DeLayGarliced>d__.<>4__this = this;
		<DeLayGarliced>d__.during = during;
		<DeLayGarliced>d__.playSound = playSound;
		<DeLayGarliced>d__.certainRow = certainRow;
		throw new NullReferenceException();
	}

	// Token: 0x060025F8 RID: 9720 RVA: 0x000C61C0 File Offset: 0x000C43C0
	[Token(Token = "0x60025F8")]
	[Address(RVA = "0x6145F0", Offset = "0x612BF0", VA = "0x1806145F0", Slot = "61")]
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

	// Token: 0x060025F9 RID: 9721 RVA: 0x000C629C File Offset: 0x000C449C
	[Token(Token = "0x60025F9")]
	[Address(RVA = "0x618620", Offset = "0x616C20", VA = "0x180618620")]
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

	// Token: 0x060025FA RID: 9722 RVA: 0x000C62E4 File Offset: 0x000C44E4
	[Token(Token = "0x60025FA")]
	[Address(RVA = "0x613B80", Offset = "0x612180", VA = "0x180613B80")]
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

	// Token: 0x060025FB RID: 9723 RVA: 0x000C6344 File Offset: 0x000C4544
	[Token(Token = "0x60025FB")]
	[Address(RVA = "0x61A070", Offset = "0x618670", VA = "0x18061A070")]
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

	// Token: 0x060025FC RID: 9724 RVA: 0x000C6378 File Offset: 0x000C4578
	[Token(Token = "0x60025FC")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "62")]
	public virtual GameObject DropArmor()
	{
		return null;
	}

	// Token: 0x060025FD RID: 9725 RVA: 0x000C6388 File Offset: 0x000C4588
	[Token(Token = "0x60025FD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "63")]
	protected virtual void FirstArmorBroken()
	{
	}

	// Token: 0x060025FE RID: 9726 RVA: 0x000C6398 File Offset: 0x000C4598
	[Token(Token = "0x60025FE")]
	[Address(RVA = "0x613F20", Offset = "0x612520", VA = "0x180613F20", Slot = "64")]
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

	// Token: 0x060025FF RID: 9727 RVA: 0x000C6468 File Offset: 0x000C4668
	[Token(Token = "0x60025FF")]
	[Address(RVA = "0x6141B0", Offset = "0x6127B0", VA = "0x1806141B0", Slot = "65")]
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

	// Token: 0x06002600 RID: 9728 RVA: 0x000C64AC File Offset: 0x000C46AC
	[Token(Token = "0x6002600")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "66")]
	protected virtual void SecondArmorBroken()
	{
	}

	// Token: 0x06002601 RID: 9729 RVA: 0x000C64BC File Offset: 0x000C46BC
	[Token(Token = "0x6002601")]
	[Address(RVA = "0x618E40", Offset = "0x617440", VA = "0x180618E40", Slot = "67")]
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

	// Token: 0x06002602 RID: 9730 RVA: 0x000C6500 File Offset: 0x000C4700
	[Token(Token = "0x6002602")]
	[Address(RVA = "0x60EDD0", Offset = "0x60D3D0", VA = "0x18060EDD0", Slot = "68")]
	protected virtual Plant CrashEntity(Collider2D collision, bool inWater = false, float knockBack = 1f)
	{
		int num = 0;
		bool flag;
		if ((this.isMindControlled ? 1 : 0) == num && flag)
		{
			bool flag2;
			if (flag2)
			{
				goto IL_00E6;
			}
			if (global::Lawnf.TravelDebuff((TravelDebuff)((uint)41)))
			{
			}
			int num2 = this.theZombieRow;
			bool flag3;
			if (!flag3)
			{
				Transform transform;
				if (flag3)
				{
					GameAPP.PlaySound(77, 0.5f, 1f);
					this.KillByCaltrop();
					transform = base.transform;
					int num3 = 0;
					int num4 = 0;
					transform.Translate(knockBack, (float)num4, (float)num3);
				}
				if (transform == (ulong)1048L)
				{
					ZombieType zombieType = this.theZombieType;
					if (zombieType > ZombieType.CherryCatapultZombie)
					{
						if (zombieType > ZombieType.DrownpultZombie)
						{
							while (transform <= (ulong)1L)
							{
							}
							while (transform <= (ulong)2L)
							{
							}
							while (transform <= (ulong)2L)
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
				}
				int num5 = global::UnityEngine.Random.Range(8, 10);
			}
			Transform transform2 = base.transform;
		}
		bool flag4;
		if (flag4)
		{
			int num6 = this.theZombieRow;
			bool flag5 = this.isMindControlled;
		}
		IL_00E6:
		throw new NullReferenceException();
	}

	// Token: 0x06002603 RID: 9731 RVA: 0x000C65FC File Offset: 0x000C47FC
	[Token(Token = "0x6002603")]
	[Address(RVA = "0x614820", Offset = "0x612E20", VA = "0x180614820")]
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

	// Token: 0x06002604 RID: 9732 RVA: 0x000C6718 File Offset: 0x000C4918
	[Token(Token = "0x6002604")]
	[Address(RVA = "0x614A40", Offset = "0x613040", VA = "0x180614A40")]
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

	// Token: 0x06002605 RID: 9733 RVA: 0x000C685C File Offset: 0x000C4A5C
	[Token(Token = "0x6002605")]
	[Address(RVA = "0x60CF80", Offset = "0x60B580", VA = "0x18060CF80", Slot = "69")]
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

	// Token: 0x06002606 RID: 9734 RVA: 0x000C6918 File Offset: 0x000C4B18
	[Token(Token = "0x6002606")]
	[Address(RVA = "0x60CEA0", Offset = "0x60B4A0", VA = "0x18060CEA0", Slot = "70")]
	protected virtual void AttackEffect(Plant plant)
	{
		plant.FlashOnce();
		if (!plant.invincible || plant.disableCount > 0)
		{
			GameAPP.PlaySound(11, 0.5f, 1f);
		}
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x000C6958 File Offset: 0x000C4B58
	[Token(Token = "0x6002607")]
	[Address(RVA = "0x611A30", Offset = "0x610030", VA = "0x180611A30")]
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

	// Token: 0x06002608 RID: 9736 RVA: 0x000C6F44 File Offset: 0x000C5144
	[Token(Token = "0x6002608")]
	[Address(RVA = "0x60D8D0", Offset = "0x60BED0", VA = "0x18060D8D0", Slot = "71")]
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

	// Token: 0x06002609 RID: 9737 RVA: 0x000C7004 File Offset: 0x000C5204
	[Token(Token = "0x6002609")]
	[Address(RVA = "0x6169A0", Offset = "0x614FA0", VA = "0x1806169A0", Slot = "72")]
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

	// Token: 0x0600260A RID: 9738 RVA: 0x000C704C File Offset: 0x000C524C
	[Token(Token = "0x600260A")]
	[Address(RVA = "0x6169A0", Offset = "0x614FA0", VA = "0x1806169A0", Slot = "73")]
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

	// Token: 0x0600260B RID: 9739 RVA: 0x000C7094 File Offset: 0x000C5294
	[Token(Token = "0x600260B")]
	[Address(RVA = "0x616340", Offset = "0x614940", VA = "0x180616340")]
	public void InitHealth()
	{
		GameObject health = this.GetHealth("health", 100);
		TextMeshPro component = health.GetComponent<TextMeshPro>();
		this.healthText = component;
		bool showZombieHealth = this.board.showZombieHealth;
		health.SetActive(showZombieHealth);
	}

	// Token: 0x0600260C RID: 9740 RVA: 0x000C70D8 File Offset: 0x000C52D8
	[Token(Token = "0x600260C")]
	[Address(RVA = "0x6155C0", Offset = "0x613BC0", VA = "0x1806155C0")]
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

	// Token: 0x0600260D RID: 9741 RVA: 0x000C7188 File Offset: 0x000C5388
	[Token(Token = "0x600260D")]
	[Address(RVA = "0x61C160", Offset = "0x61A760", VA = "0x18061C160", Slot = "74")]
	public virtual void UpdateHealthText()
	{
		TextMeshPro textMeshPro = this.healthText;
		int num = 0;
		if (textMeshPro != num && this.healthText.gameObject.activeSelf)
		{
			GameObject gameObject = this.theFirstArmor;
			int num2 = 0;
			if (gameObject != num2)
			{
				GameObject gameObject2 = this.theSecondArmor;
				int num3 = 0;
				if (gameObject2 != num3)
				{
					TextMeshPro textMeshPro2 = this.healthText;
					object[] array = new object[6];
					if (array != 0)
					{
					}
					array[0] = array;
					long num4 = this.theMaxHealth;
					array[1] = num4;
					int num5 = this.theFirstArmorHealth;
					if (num5 != 0)
					{
					}
					array[2] = num5;
					int num6 = this.theFirstArmorMaxHealth;
					num5 = num6;
					if (num6 != 0)
					{
					}
					array[3] = num5;
					int num7 = this.theSecondArmorHealth;
					num5 = num7;
					if (num7 != 0)
					{
					}
					array[4] = num5;
					int num8 = this.theSecondArmorMaxHealth;
					num5 = num8;
					if (num8 != 0)
					{
					}
					array[5] = num5;
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
					TextMeshPro textMeshPro3 = this.healthText;
					object[] array2 = new object[4];
					if (array2 != 0)
					{
					}
					array2[0] = array2;
					long num11 = this.theMaxHealth;
					array2[1] = num11;
					int num12 = this.theFirstArmorHealth;
					if (num12 != 0)
					{
					}
					array2[2] = num12;
					int num13 = this.theFirstArmorMaxHealth;
					num12 = num13;
					if (num13 != 0)
					{
					}
					array2[3] = num12;
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
					TextMeshPro textMeshPro4 = this.healthText;
					object[] array3 = new object[4];
					if (array3 != 0)
					{
					}
					array3[0] = array3;
					long num16 = this.theMaxHealth;
					array3[1] = num16;
					int num17 = this.theSecondArmorHealth;
					if (num17 != 0)
					{
					}
					array3[2] = num17;
					int num18 = this.theSecondArmorMaxHealth;
					num17 = num18;
					if (num18 != 0)
					{
					}
					array3[3] = num17;
					string text3 = string.Format("HP：{0}/{1}\n二类：{2}/{3}", array3);
				}
			}
			TextMeshPro textMeshPro5 = this.healthText;
			long num19;
			long num20;
			string text4 = string.Format("HP：{0}/{1}\n", num19, num20);
			textMeshPro5.text = text4;
			if (this.level > 1)
			{
				int num21 = this.level;
				TextMeshPro textMeshPro6 = this.healthText;
				string text5 = string.Format("{0}阶\n", num21);
				string text6 = this.healthText.text;
				string text7 = text5 + text6;
				textMeshPro6.text = text7;
			}
		}
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x000C7454 File Offset: 0x000C5654
	[Token(Token = "0x600260E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "75")]
	public virtual void KillByCaltrop()
	{
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x000C7464 File Offset: 0x000C5664
	[Token(Token = "0x600260F")]
	[Address(RVA = "0x6186C0", Offset = "0x616CC0", VA = "0x1806186C0")]
	public void Recover(float value)
	{
		GameObject gameObject = this.theFirstArmor;
		int num = 0;
		if (!(gameObject != num))
		{
			long num2 = this.theHealth;
			num2 += gameObject;
			this.theHealth = num2;
			if (num2 <= this.theMaxHealth)
			{
				return;
			}
			long num3 = this.theMaxHealth;
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

	// Token: 0x06002610 RID: 9744 RVA: 0x000C74E0 File Offset: 0x000C56E0
	[Token(Token = "0x6002610")]
	[Address(RVA = "0x60C3F0", Offset = "0x60A9F0", VA = "0x18060C3F0")]
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

	// Token: 0x06002611 RID: 9745 RVA: 0x000C7508 File Offset: 0x000C5708
	[Token(Token = "0x6002611")]
	[Address(RVA = "0x615B00", Offset = "0x614100", VA = "0x180615B00")]
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

	// Token: 0x06002612 RID: 9746 RVA: 0x000C7538 File Offset: 0x000C5738
	[Token(Token = "0x6002612")]
	[Address(RVA = "0x613D60", Offset = "0x612360", VA = "0x180613D60")]
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

	// Token: 0x06002613 RID: 9747 RVA: 0x000C75D8 File Offset: 0x000C57D8
	[Token(Token = "0x6002613")]
	[Address(RVA = "0x6131B0", Offset = "0x6117B0", VA = "0x1806131B0")]
	protected IEnumerator FadeDeath()
	{
		int num;
		Zombie.<FadeDeath>d__254 <FadeDeath>d__ = new Zombie.<FadeDeath>d__254(num);
		num = 0;
		<FadeDeath>d__.<>4__this = this;
		throw new NullReferenceException();
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x000C75FC File Offset: 0x000C57FC
	[Token(Token = "0x6002614")]
	[Address(RVA = "0x61B280", Offset = "0x619880", VA = "0x18061B280")]
	private void SubCount()
	{
		if (!this.subed)
		{
			this.subed = true;
			Board board = this.board;
		}
	}

	// Token: 0x06002615 RID: 9749 RVA: 0x000C7628 File Offset: 0x000C5828
	[Token(Token = "0x6002615")]
	[Address(RVA = "0x61D9C0", Offset = "0x61BFC0", VA = "0x18061D9C0")]
	public Zombie()
	{
		List<GameObject> list = new List();
		this.theUniqueItems = list;
		List<Transform> list2 = new List();
		this.changeSprites = list2;
		this.theHealth = (long)((ulong)270L);
		this.theMaxHealth = (long)((ulong)270L);
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

	// Token: 0x06002616 RID: 9750 RVA: 0x000C77C8 File Offset: 0x000C59C8
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6002616")]
	[Address(RVA = "0x61D7C0", Offset = "0x61BDC0", VA = "0x18061D7C0")]
	static Zombie()
	{
		throw new NullReferenceException();
	}

	// Token: 0x0400129C RID: 4764
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400129C")]
	public ZombieType theZombieType;

	// Token: 0x0400129D RID: 4765
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400129D")]
	public Zombie.FirstArmorType theFirstArmorType;

	// Token: 0x0400129E RID: 4766
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400129E")]
	public Zombie.SecondArmorType theSecondArmorType;

	// Token: 0x0400129F RID: 4767
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400129F")]
	public Zombie.UniqueItemType theUniqueItemType;

	// Token: 0x040012A0 RID: 4768
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40012A0")]
	public ZombieStatus theStatus;

	// Token: 0x040012A1 RID: 4769
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40012A1")]
	public Towards towards;

	// Token: 0x040012A2 RID: 4770
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40012A2")]
	public GameObject theFirstArmor;

	// Token: 0x040012A3 RID: 4771
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40012A3")]
	public GameObject theSecondArmor;

	// Token: 0x040012A4 RID: 4772
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40012A4")]
	public List<GameObject> theUniqueItems;

	// Token: 0x040012A5 RID: 4773
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40012A5")]
	public List<Transform> changeSprites;

	// Token: 0x040012A6 RID: 4774
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40012A6")]
	public Transform shoot;

	// Token: 0x040012A7 RID: 4775
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40012A7")]
	public long theHealth;

	// Token: 0x040012A8 RID: 4776
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40012A8")]
	public long theMaxHealth;

	// Token: 0x040012A9 RID: 4777
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40012A9")]
	public int theFirstArmorHealth;

	// Token: 0x040012AA RID: 4778
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40012AA")]
	public int theFirstArmorMaxHealth;

	// Token: 0x040012AB RID: 4779
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40012AB")]
	public int theSecondArmorHealth;

	// Token: 0x040012AC RID: 4780
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x40012AC")]
	public int theSecondArmorMaxHealth;

	// Token: 0x040012AD RID: 4781
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40012AD")]
	public int theAttackDamage;

	// Token: 0x040012AE RID: 4782
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40012AE")]
	public int level;

	// Token: 0x040012AF RID: 4783
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40012AF")]
	public int freezeMaxLevel;

	// Token: 0x040012B0 RID: 4784
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40012B0")]
	public int theZombieRow;

	// Token: 0x040012B1 RID: 4785
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40012B1")]
	public int freezeLevel;

	// Token: 0x040012B2 RID: 4786
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40012B2")]
	public int poisonLevel;

	// Token: 0x040012B3 RID: 4787
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40012B3")]
	public int attributeCount;

	// Token: 0x040012B4 RID: 4788
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x40012B4")]
	public int awardLevel;

	// Token: 0x040012B5 RID: 4789
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40012B5")]
	public int kelpTimes;

	// Token: 0x040012B6 RID: 4790
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40012B6")]
	public float theArmor;

	// Token: 0x040012B7 RID: 4791
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40012B7")]
	public float takeDmgMultiplier;

	// Token: 0x040012B8 RID: 4792
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40012B8")]
	public float fragileValue;

	// Token: 0x040012B9 RID: 4793
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40012B9")]
	public int read;

	// Token: 0x040012BA RID: 4794
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x40012BA")]
	public int zombieCount;

	// Token: 0x040012BB RID: 4795
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40012BB")]
	[Header("速度")]
	public float theSpeed;

	// Token: 0x040012BC RID: 4796
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x40012BC")]
	public float theOriginSpeed;

	// Token: 0x040012BD RID: 4797
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40012BD")]
	public float freezeSpeed;

	// Token: 0x040012BE RID: 4798
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x40012BE")]
	public float coldSpeed;

	// Token: 0x040012BF RID: 4799
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40012BF")]
	public float butterSpeed;

	// Token: 0x040012C0 RID: 4800
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x40012C0")]
	public float kelpSpeed;

	// Token: 0x040012C1 RID: 4801
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40012C1")]
	public float garlicSpeed;

	// Token: 0x040012C2 RID: 4802
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x40012C2")]
	public float uniqueSpeed;

	// Token: 0x040012C3 RID: 4803
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40012C3")]
	public float holeSpeed;

	// Token: 0x040012C4 RID: 4804
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40012C4")]
	[Header("倒计时")]
	public float dogeTime;

	// Token: 0x040012C5 RID: 4805
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40012C5")]
	public float attributeCountDown;

	// Token: 0x040012C6 RID: 4806
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40012C6")]
	public float existTime;

	// Token: 0x040012C7 RID: 4807
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40012C7")]
	public float ladderTime;

	// Token: 0x040012C8 RID: 4808
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x40012C8")]
	public bool inWater;

	// Token: 0x040012C9 RID: 4809
	[FieldOffset(Offset = "0x125")]
	[Token(Token = "0x40012C9")]
	public bool isMindControlled;

	// Token: 0x040012CA RID: 4810
	[FieldOffset(Offset = "0x126")]
	[Token(Token = "0x40012CA")]
	public bool isChangingRow;

	// Token: 0x040012CB RID: 4811
	[FieldOffset(Offset = "0x127")]
	[Token(Token = "0x40012CB")]
	public bool isAttacking;

	// Token: 0x040012CC RID: 4812
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40012CC")]
	public bool ultiEmbered;

	// Token: 0x040012CD RID: 4813
	[FieldOffset(Offset = "0x129")]
	[Token(Token = "0x40012CD")]
	public bool isDoom;

	// Token: 0x040012CE RID: 4814
	[FieldOffset(Offset = "0x12A")]
	[Token(Token = "0x40012CE")]
	public bool garlicDoom;

	// Token: 0x040012CF RID: 4815
	[FieldOffset(Offset = "0x12B")]
	[Token(Token = "0x40012CF")]
	public bool isSmall;

	// Token: 0x040012D0 RID: 4816
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x40012D0")]
	public bool doomWithPit;

	// Token: 0x040012D1 RID: 4817
	[FieldOffset(Offset = "0x12D")]
	[Token(Token = "0x40012D1")]
	public bool beforeDying;

	// Token: 0x040012D2 RID: 4818
	[FieldOffset(Offset = "0x12E")]
	[Token(Token = "0x40012D2")]
	public bool isSplited;

	// Token: 0x040012D3 RID: 4819
	[FieldOffset(Offset = "0x12F")]
	[Token(Token = "0x40012D3")]
	public bool isGold;

	// Token: 0x040012D4 RID: 4820
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40012D4")]
	public bool isBlowed;

	// Token: 0x040012D5 RID: 4821
	[FieldOffset(Offset = "0x131")]
	[Token(Token = "0x40012D5")]
	public bool isPreview;

	// Token: 0x040012D6 RID: 4822
	[FieldOffset(Offset = "0x132")]
	[Token(Token = "0x40012D6")]
	public bool fragile;

	// Token: 0x040012D7 RID: 4823
	[FieldOffset(Offset = "0x133")]
	[Token(Token = "0x40012D7")]
	public bool revived;

	// Token: 0x040012D8 RID: 4824
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40012D8")]
	public bool[] controlledLevel;

	// Token: 0x040012D9 RID: 4825
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40012D9")]
	public IDamageable theAttackTarget;

	// Token: 0x040012DA RID: 4826
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40012DA")]
	public Rigidbody2D rb;

	// Token: 0x040012DB RID: 4827
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40012DB")]
	public Collider2D col;

	// Token: 0x040012DC RID: 4828
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40012DC")]
	public SortingGroup sortingGroup;

	// Token: 0x040012DD RID: 4829
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40012DD")]
	public WaterSpray waterSpray;

	// Token: 0x040012DE RID: 4830
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40012DE")]
	public SpriteRenderer headGarlic;

	// Token: 0x040012DF RID: 4831
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40012DF")]
	public SpriteRenderer jawGarlic;

	// Token: 0x040012E0 RID: 4832
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x40012E0")]
	public TextMeshPro healthText;

	// Token: 0x040012E1 RID: 4833
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x40012E1")]
	public TimeBomb timeBomb;

	// Token: 0x040012E2 RID: 4834
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x40012E2")]
	public Tentacle tentacle;

	// Token: 0x040012E3 RID: 4835
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40012E3")]
	public Zombie pre;

	// Token: 0x040012E4 RID: 4836
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40012E4")]
	public Zombie next;

	// Token: 0x040012E5 RID: 4837
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40012E5")]
	public Corner targetCorner;

	// Token: 0x040012E6 RID: 4838
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40012E6")]
	public Action<Zombie> onDeath;

	// Token: 0x040012E7 RID: 4839
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40012E7")]
	public Action defaultAction;

	// Token: 0x040012E8 RID: 4840
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40012E8")]
	public HashSet<EveZombieBuff> eveBuffs;

	// Token: 0x040012E9 RID: 4841
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40012E9")]
	public Dictionary<ZombieTimer, float> timers;

	// Token: 0x040012EA RID: 4842
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40012EA")]
	public Dictionary<ArmorBonus, float> armorBonus;

	// Token: 0x040012EB RID: 4843
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40012EB")]
	public HashSet<string> used;

	// Token: 0x040012EC RID: 4844
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40012EC")]
	public Dictionary<ZombieFragile, float> fragiles;

	// Token: 0x040012ED RID: 4845
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x40012ED")]
	protected int theFirstArmorBroken;

	// Token: 0x040012EE RID: 4846
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x40012EE")]
	protected int theSecondArmorBroken;

	// Token: 0x040012EF RID: 4847
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40012EF")]
	protected int takeDamageTimes;

	// Token: 0x040012F0 RID: 4848
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x40012F0")]
	protected int lastMaxDamage;

	// Token: 0x040012F1 RID: 4849
	[Token(Token = "0x40012F1")]
	public const int butterLayer = 140;

	// Token: 0x040012F2 RID: 4850
	[Token(Token = "0x40012F2")]
	public const int kelpLayer = 139;

	// Token: 0x040012F3 RID: 4851
	[Token(Token = "0x40012F3")]
	public const int iceLayer = 138;

	// Token: 0x040012F4 RID: 4852
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x40012F4")]
	protected float hugeDamage;

	// Token: 0x040012F5 RID: 4853
	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x40012F5")]
	protected float vx;

	// Token: 0x040012F6 RID: 4854
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x40012F6")]
	protected float vy;

	// Token: 0x040012F7 RID: 4855
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x40012F7")]
	protected float flashTime;

	// Token: 0x040012F8 RID: 4856
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x40012F8")]
	protected float lastTakeDamageDuring;

	// Token: 0x040012F9 RID: 4857
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x40012F9")]
	protected float deadRight;

	// Token: 0x040012FA RID: 4858
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x40012FA")]
	protected float deadLeft;

	// Token: 0x040012FB RID: 4859
	[FieldOffset(Offset = "0x20C")]
	[Token(Token = "0x40012FB")]
	protected readonly float dy;

	// Token: 0x040012FC RID: 4860
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x40012FC")]
	protected bool loseHand;

	// Token: 0x040012FD RID: 4861
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40012FD")]
	protected readonly List<IDamageable> contacts;

	// Token: 0x040012FE RID: 4862
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40012FE")]
	private int dieReason;

	// Token: 0x040012FF RID: 4863
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x40012FF")]
	private int fireFlyedCount;

	// Token: 0x04001300 RID: 4864
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4001300")]
	private bool droppedSun;

	// Token: 0x04001301 RID: 4865
	[FieldOffset(Offset = "0x229")]
	[Token(Token = "0x4001301")]
	private bool eatGarlic;

	// Token: 0x04001302 RID: 4866
	[FieldOffset(Offset = "0x22A")]
	[Token(Token = "0x4001302")]
	private bool hasIsAttackingParam;

	// Token: 0x04001303 RID: 4867
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4001303")]
	private Sprite headOriginalSprite;

	// Token: 0x04001304 RID: 4868
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4001304")]
	private GameObject fireFly;

	// Token: 0x04001305 RID: 4869
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4001305")]
	public GameObject butterHead;

	// Token: 0x04001306 RID: 4870
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4001306")]
	private GameObject zombieJaw;

	// Token: 0x04001307 RID: 4871
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4001307")]
	private Color currentColor;

	// Token: 0x04001308 RID: 4872
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001308")]
	private Vector2 lastLadder;

	// Token: 0x04001309 RID: 4873
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001309")]
	private readonly List<Color> colorsBuffers;

	// Token: 0x0400130A RID: 4874
	[Token(Token = "0x400130A")]
	private static readonly Dictionary<Zombie.ZombieColor, Color> ColorDictionary = new Dictionary();

	// Token: 0x0400130B RID: 4875
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400130B")]
	public bool subed;

	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	public enum KnockBackReason
	{
		// Token: 0x0400130D RID: 4877
		[Token(Token = "0x400130D")]
		ByUmbrella,
		// Token: 0x0400130E RID: 4878
		[Token(Token = "0x400130E")]
		Normal,
		// Token: 0x0400130F RID: 4879
		[Token(Token = "0x400130F")]
		ByJalapeno,
		// Token: 0x04001310 RID: 4880
		[Token(Token = "0x4001310")]
		ByTangleKelp
	}

	// Token: 0x02000751 RID: 1873
	[Token(Token = "0x2000751")]
	public enum FirstArmorType
	{
		// Token: 0x04001312 RID: 4882
		[Token(Token = "0x4001312")]
		Nothing,
		// Token: 0x04001313 RID: 4883
		[Token(Token = "0x4001313")]
		Cone,
		// Token: 0x04001314 RID: 4884
		[Token(Token = "0x4001314")]
		Bucket,
		// Token: 0x04001315 RID: 4885
		[Token(Token = "0x4001315")]
		Doll,
		// Token: 0x04001316 RID: 4886
		[Token(Token = "0x4001316")]
		FootballHelmet,
		// Token: 0x04001317 RID: 4887
		[Token(Token = "0x4001317")]
		WallNut,
		// Token: 0x04001318 RID: 4888
		[Token(Token = "0x4001318")]
		TallNut,
		// Token: 0x04001319 RID: 4889
		[Token(Token = "0x4001319")]
		TallNutFootball,
		// Token: 0x0400131A RID: 4890
		[Token(Token = "0x400131A")]
		BucketNut,
		// Token: 0x0400131B RID: 4891
		[Token(Token = "0x400131B")]
		Balloon,
		// Token: 0x0400131C RID: 4892
		[Token(Token = "0x400131C")]
		IronBalloon
	}

	// Token: 0x02000752 RID: 1874
	[Token(Token = "0x2000752")]
	public enum SecondArmorType
	{
		// Token: 0x0400131E RID: 4894
		[Token(Token = "0x400131E")]
		Nothing,
		// Token: 0x0400131F RID: 4895
		[Token(Token = "0x400131F")]
		Door,
		// Token: 0x04001320 RID: 4896
		[Token(Token = "0x4001320")]
		Paper,
		// Token: 0x04001321 RID: 4897
		[Token(Token = "0x4001321")]
		Ladder,
		// Token: 0x04001322 RID: 4898
		[Token(Token = "0x4001322")]
		SnowShield,
		// Token: 0x04001323 RID: 4899
		[Token(Token = "0x4001323")]
		Protal,
		// Token: 0x04001324 RID: 4900
		[Token(Token = "0x4001324")]
		RedLadder
	}

	// Token: 0x02000753 RID: 1875
	[Token(Token = "0x2000753")]
	public enum UniqueItemType
	{
		// Token: 0x04001326 RID: 4902
		[Token(Token = "0x4001326")]
		Nothing,
		// Token: 0x04001327 RID: 4903
		[Token(Token = "0x4001327")]
		Jackbox,
		// Token: 0x04001328 RID: 4904
		[Token(Token = "0x4001328")]
		Jumper,
		// Token: 0x04001329 RID: 4905
		[Token(Token = "0x4001329")]
		Pickaxe,
		// Token: 0x0400132A RID: 4906
		[Token(Token = "0x400132A")]
		IronHead,
		// Token: 0x0400132B RID: 4907
		[Token(Token = "0x400132B")]
		RedIronHead
	}

	// Token: 0x02000754 RID: 1876
	[Token(Token = "0x2000754")]
	public enum ZombieColor
	{
		// Token: 0x0400132D RID: 4909
		[Token(Token = "0x400132D")]
		Default,
		// Token: 0x0400132E RID: 4910
		[Token(Token = "0x400132E")]
		Cold,
		// Token: 0x0400132F RID: 4911
		[Token(Token = "0x400132F")]
		MindConrolled,
		// Token: 0x04001330 RID: 4912
		[Token(Token = "0x4001330")]
		Jalaed,
		// Token: 0x04001331 RID: 4913
		[Token(Token = "0x4001331")]
		Doom,
		// Token: 0x04001332 RID: 4914
		[Token(Token = "0x4001332")]
		Poison,
		// Token: 0x04001333 RID: 4915
		[Token(Token = "0x4001333")]
		Poison_with_cold,
		// Token: 0x04001334 RID: 4916
		[Token(Token = "0x4001334")]
		Ember,
		// Token: 0x04001335 RID: 4917
		[Token(Token = "0x4001335")]
		Jala_with_ember,
		// Token: 0x04001336 RID: 4918
		[Token(Token = "0x4001336")]
		Gold,
		// Token: 0x04001337 RID: 4919
		[Token(Token = "0x4001337")]
		Lunar
	}
}
