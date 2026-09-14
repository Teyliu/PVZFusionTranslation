using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200073F RID: 1855
[Token(Token = "0x200073F")]
public class UltimateSwordZombie : Zombie
{
	// Token: 0x0600252E RID: 9518 RVA: 0x000C11A4 File Offset: 0x000BF3A4
	[Token(Token = "0x600252E")]
	[Address(RVA = "0x608890", Offset = "0x606E90", VA = "0x180608890", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 7f;
	}

	// Token: 0x0600252F RID: 9519 RVA: 0x000C11C4 File Offset: 0x000BF3C4
	[Token(Token = "0x600252F")]
	[Address(RVA = "0x608700", Offset = "0x606D00", VA = "0x180608700", Slot = "24")]
	protected override void AttributeEvent()
	{
		ZombieStatus theStatus = this.theStatus;
		int num = 0;
		if (theStatus == ZombieStatus.Dying)
		{
			this.attributeCountDown = 5f;
			this.UseShovel();
			this.UseHammer();
			this.UseGlove();
			this.attributeCountDown = 5f;
			this.UseShovel();
			this.attributeCountDown = 4f;
			this.UseGlove();
			this.attributeCountDown = 3f;
			this.UseHammer();
			this.anim.SetTrigger("skill");
		}
		Dictionary<EffectType, BaseEffect> effects = this.effects;
		int num2 = 0;
		if (effects.TryGetValue(num2, num))
		{
			float attributeCountDown = this.attributeCountDown;
			this.attributeCountDown = attributeCountDown;
		}
	}

	// Token: 0x06002530 RID: 9520 RVA: 0x000C126C File Offset: 0x000BF46C
	[Token(Token = "0x6002530")]
	[Address(RVA = "0x608300", Offset = "0x606900", VA = "0x180608300")]
	private void AnimHammer()
	{
		int num3;
		do
		{
			GameAPP.PlaySound(74, 0.5f, 1f);
			ScreenShake.TriggerShake(0.05f);
			Board board = this.board;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			int num = 0;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				Plant plant;
				if (!(plant != num2))
				{
				}
				plant.FlashOnce();
			}
			if (num != 0)
			{
				goto IL_008F;
			}
			List<Plant> allPlants2 = Lawnf.GetAllPlants();
			num3 = 0;
			bool flag2;
			if (flag2)
			{
				int num4 = 0;
				Plant plant2;
				if (!(plant2 != num4))
				{
				}
				plant2.FlashOnce();
			}
		}
		while (num3 != 0);
		return;
		IL_008F:
		throw new NullReferenceException();
	}

	// Token: 0x06002531 RID: 9521 RVA: 0x000C1314 File Offset: 0x000BF514
	[Token(Token = "0x6002531")]
	[Address(RVA = "0x609F70", Offset = "0x608570", VA = "0x180609F70")]
	private void UseHammer()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(this.board, num);
			Func<Plant, bool> <>9__9_ = UltimateSwordZombie.<>c.<>9__9_0;
			if (<>9__9_ == 0)
			{
				UltimateSwordZombie.<>c.<>9__9_0 = delegate(Plant p)
				{
					if (p.plantTag == (ulong)0L)
					{
						return !p.isLily;
					}
					throw new NullReferenceException();
				};
			}
			IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(plantsByRow, <>9__9_);
			Func<Plant, int> func;
			if (UltimateSwordZombie.<>c.<>9__9_1 == 0)
			{
				UltimateSwordZombie.<>c.<>9__9_1 = func;
			}
			Plant plant5 = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderByDescending<Plant, int>(enumerable, func));
			Plant plant = plant5;
			Plant plant2 = plant;
			int num2 = 0;
			if (plant2 != num2)
			{
				Board board2 = this.board;
				GameObject gameObject = this.hammerPrefab;
				Transform transform = board2.transform;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
				GameObject hammer = gameObject2;
				GameObject hammer2 = hammer;
				int theAttackDamage = this.theAttackDamage;
				int damage = theAttackDamage;
				Transform transform2 = hammer2.transform;
				Transform axis = plant.axis;
				Vector3 vector;
				float z = vector.z;
				DelayAction delayAction = GameAPP.delayAction;
				Action action = delegate
				{
					global::UnityEngine.Object.Destroy(hammer);
					Plant plant3 = plant;
					int num3 = 0;
					if (plant3 != num3)
					{
						Plant pumpkin = plant.Pumpkin;
						int num4 = 0;
						bool flag = pumpkin != num4;
						Plant plant4 = plant;
						if (!flag)
						{
						}
						Plant pumpkin2 = plant4.Pumpkin;
						plant.Pumpkin.FlashOnce();
						GameAPP.PlaySound(64, 0.5f, 1f);
					}
				};
				delayAction.SetAction(action, 0.5f);
			}
			Board board3 = this.board;
			num++;
		}
	}

	// Token: 0x06002532 RID: 9522 RVA: 0x000C1458 File Offset: 0x000BF658
	[Token(Token = "0x6002532")]
	[Address(RVA = "0x609A00", Offset = "0x608000", VA = "0x180609A00")]
	private void UseGlove()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			int num2 = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(num, num2 != 0);
			Func<Zombie, bool> <>9__10_ = UltimateSwordZombie.<>c.<>9__10_0;
			if (<>9__10_ == 0)
			{
				UltimateSwordZombie.<>c.<>9__10_0 = delegate(Zombie z)
				{
					int theZombieType = (int)z.theZombieType;
					bool flag;
					if (flag)
					{
					}
					int theZombieType2 = (int)z.theZombieType;
					bool flag2;
					return flag2;
				};
			}
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombiesByRow, <>9__10_);
			Func<Zombie, float> func;
			if (UltimateSwordZombie.<>c.<>9__10_1 == 0)
			{
				UltimateSwordZombie.<>c.<>9__10_1 = func;
			}
			Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, float>(enumerable, func));
			int num3 = 0;
			if (zombie != num3)
			{
				Transform axis = zombie.axis;
				Mouse instance = Mouse.Instance;
				uint num4;
				GameAPP.PlaySound((int)num4, 0.5f, 1f);
				Transform axis2 = zombie.axis;
				GameObject gameObject = this.glovePrefab;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = this.board.transform;
				GameObject gameObject2;
				GameObject glove = gameObject2;
				DelayAction delayAction = GameAPP.delayAction;
				Action action = delegate
				{
					global::UnityEngine.Object.Destroy(glove);
				};
				delayAction.SetAction(action, 0.5f);
			}
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x000C1570 File Offset: 0x000BF770
	[Token(Token = "0x6002533")]
	[Address(RVA = "0x60A450", Offset = "0x608A50", VA = "0x18060A450")]
	private void UseShovel()
	{
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, bool> <>9__11_ = UltimateSwordZombie.<>c.<>9__11_0;
		if (<>9__11_ == 0)
		{
			UltimateSwordZombie.<>c.<>9__11_0 = delegate(Plant p)
			{
				if (p.plantTag == (ulong)0L)
				{
					return !p.isLily;
				}
				throw new NullReferenceException();
			};
		}
		IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(allPlants, <>9__11_);
		Func<Plant, int> func;
		if (UltimateSwordZombie.<>c.<>9__11_1 == 0)
		{
			UltimateSwordZombie.<>c.<>9__11_1 = func;
		}
		Plant plant5 = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderBy<Plant, int>(enumerable, func));
		Plant plant = plant5;
		Plant plant2 = plant;
		int num = 0;
		if (plant2 != num)
		{
			Board board = this.board;
			GameObject gameObject = this.shovelPrefab;
			Transform transform = board.transform;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
			GameObject shovel = gameObject2;
			Transform transform2 = shovel.transform;
			Transform axis = plant.axis;
			Vector3 vector;
			float z = vector.z;
			DelayAction delayAction = GameAPP.delayAction;
			Action action = delegate
			{
				global::UnityEngine.Object.Destroy(shovel);
				Plant plant3 = plant;
				int num2 = 0;
				if (plant3 != num2)
				{
					plant.Die((Plant.DieReason)((uint)7));
					UltimateSwordZombie <>4__this = this;
					Plant plant4 = plant;
					List<PlantType> list = <>4__this.shovelPlants;
					PlantType thePlantType = plant4.thePlantType;
					int size = list._size;
					HealthSlider healthSlider = plant4.snakePre.healthSlider;
					list._size = plant4;
					GameAPP.PlaySound(23, 0.5f, 1f);
				}
			};
			delayAction.SetAction(action, 0.5f);
		}
	}

	// Token: 0x06002534 RID: 9524 RVA: 0x000C1674 File Offset: 0x000BF874
	[Token(Token = "0x6002534")]
	[Address(RVA = "0x609070", Offset = "0x607670", VA = "0x180609070", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("enter");
		Action action = delegate
		{
			if (this.theStatus == ZombieStatus.Dying)
			{
				this.theStatus = (ZombieStatus)((ulong)48L);
				Shovel instance4 = Shovel.Instance;
				int num3 = 0;
				if (instance4 != num3)
				{
					GameObject gameObject2 = Shovel.Instance.gameObject;
					int num4 = 0;
					gameObject2.SetActive(num4 != 0);
				}
				Glove instance5 = Glove.Instance;
				int num5 = 0;
				if (instance5 != num5)
				{
					GameObject gameObject3 = Glove.Instance.gameObject;
					int num6 = 0;
					gameObject3.SetActive(num6 != 0);
				}
				Hammer instance6 = Hammer.Instance;
				int num7 = 0;
				if (instance6 != num7)
				{
					GameObject gameObject4 = Hammer.Instance.gameObject;
					int num8 = 0;
					gameObject4.SetActive(num8 != 0);
				}
			}
			int num9 = 0;
			this.wudi = false;
			base.Recover((float)num9);
			int num10 = 0;
			bool flag = base.RemoveBuff((EffectType)num10);
			this.attributeCountDown = 5f;
		};
		this.defaultAction = action;
		Board board = this.board;
		this.theStatus = (ZombieStatus)((ulong)45L);
		Mouse instance = Mouse.Instance;
		int columnNum = board.columnNum;
		float boxXFromColumn = instance.GetBoxXFromColumn(columnNum);
		Mouse instance2 = Mouse.Instance;
		int theZombieRow = this.theZombieRow;
		float landY = instance2.GetLandY(boxXFromColumn, theZombieRow);
		Hammer instance3 = Hammer.Instance;
		int num = 0;
		if (instance3 != num)
		{
			GameObject gameObject = Hammer.Instance.gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
		}
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x000C1728 File Offset: 0x000BF928
	[Token(Token = "0x6002535")]
	[Address(RVA = "0x608EE0", Offset = "0x6074E0", VA = "0x180608EE0")]
	private void Explode()
	{
		UltimateSwordZombie.<Exploding>d__14 <Exploding>d__;
		<Exploding>d__.System.IDisposable.Dispose();
		<Exploding>d__.<>1__state = (int)((ulong)0L);
		<Exploding>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Exploding>d__);
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x000C1754 File Offset: 0x000BF954
	[Token(Token = "0x6002536")]
	[Address(RVA = "0x608F60", Offset = "0x607560", VA = "0x180608F60")]
	private IEnumerator Exploding()
	{
		UltimateSwordZombie.<Exploding>d__14 <Exploding>d__;
		<Exploding>d__.System.IDisposable.Dispose();
		<Exploding>d__.<>1__state = (int)((ulong)0L);
		<Exploding>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002537 RID: 9527 RVA: 0x000C1778 File Offset: 0x000BF978
	[Token(Token = "0x6002537")]
	[Address(RVA = "0x608C00", Offset = "0x607200", VA = "0x180608C00", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		ulong num;
		do
		{
			this.Explode();
			List<PlantType> list = this.shovelPlants;
			bool flag;
			if (flag)
			{
				Transform axis = this.axis;
			}
		}
		while (num != (ulong)0L);
		Shovel instance = Shovel.Instance;
		int num2 = 0;
		if (instance != num2)
		{
			Shovel.Instance.gameObject.SetActive(true);
		}
		Glove instance2 = Glove.Instance;
		int num3 = 0;
		if (instance2 != num3)
		{
			Glove.Instance.gameObject.SetActive(true);
		}
		Hammer instance3 = Hammer.Instance;
		int num4 = 0;
		if (instance3 != num4)
		{
			Hammer.Instance.gameObject.SetActive(true);
		}
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x000C182C File Offset: 0x000BFA2C
	[Token(Token = "0x6002538")]
	[Address(RVA = "0x609650", Offset = "0x607C50", VA = "0x180609650", Slot = "17")]
	protected override void Update()
	{
		if (this.theStatus != ZombieStatus.Dying)
		{
			this.wudi = false;
			base.Update();
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x000C18E4 File Offset: 0x000BFAE4
	[Token(Token = "0x6002539")]
	[Address(RVA = "0x609250", Offset = "0x607850", VA = "0x180609250", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (!this.wudi)
		{
			return;
		}
	}

	// Token: 0x0600253A RID: 9530 RVA: 0x000C1900 File Offset: 0x000BFB00
	[Token(Token = "0x600253A")]
	[Address(RVA = "0x6088B0", Offset = "0x606EB0", VA = "0x1806088B0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		while (this.theStatus == ZombieStatus.Dying)
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				Lawnf.ChangeSprite(1f, 10f, gameObject);
			}
			ulong num;
			if (num == (ulong)0L)
			{
				throw new NullReferenceException();
			}
		}
	}

	// Token: 0x0600253B RID: 9531 RVA: 0x000C1994 File Offset: 0x000BFB94
	[Token(Token = "0x600253B")]
	[Address(RVA = "0x608FD0", Offset = "0x6075D0", VA = "0x180608FD0", Slot = "41")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
		}
	}

	// Token: 0x0600253C RID: 9532 RVA: 0x000C19B4 File Offset: 0x000BFBB4
	[Token(Token = "0x600253C")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "61")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x000C19C4 File Offset: 0x000BFBC4
	[Token(Token = "0x600253D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x000C19D4 File Offset: 0x000BFBD4
	[Token(Token = "0x600253E")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x0600253F RID: 9535 RVA: 0x000C19E4 File Offset: 0x000BFBE4
	[Token(Token = "0x600253F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "55")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x000C19F4 File Offset: 0x000BFBF4
	[Token(Token = "0x6002540")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "54")]
	public override void SetPoison(float time = 10f)
	{
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x000C1A04 File Offset: 0x000BFC04
	[Token(Token = "0x6002541")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "25")]
	public override void ChangeRow(int theTargetRow)
	{
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x000C1A14 File Offset: 0x000BFC14
	[Token(Token = "0x6002542")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x000C1A24 File Offset: 0x000BFC24
	[Token(Token = "0x6002543")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "72")]
	public override void RealKnockBack(float x)
	{
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x000C1A34 File Offset: 0x000BFC34
	[Token(Token = "0x6002544")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x000C1A44 File Offset: 0x000BFC44
	[Token(Token = "0x6002545")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "60")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x000C1A54 File Offset: 0x000BFC54
	[Token(Token = "0x6002546")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x06002547 RID: 9543 RVA: 0x000C1A68 File Offset: 0x000BFC68
	[Token(Token = "0x6002547")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002548 RID: 9544 RVA: 0x000C1A78 File Offset: 0x000BFC78
	[Token(Token = "0x6002548")]
	[Address(RVA = "0x60A890", Offset = "0x608E90", VA = "0x18060A890")]
	public UltimateSwordZombie()
	{
		List<PlantType> list = new List();
		this.shovelPlants = list;
		base..ctor();
	}

	// Token: 0x04001273 RID: 4723
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001273")]
	private bool wudi;

	// Token: 0x04001274 RID: 4724
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001274")]
	public GameObject hammerPrefab;

	// Token: 0x04001275 RID: 4725
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001275")]
	public GameObject glovePrefab;

	// Token: 0x04001276 RID: 4726
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001276")]
	public GameObject shovelPrefab;

	// Token: 0x04001277 RID: 4727
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4001277")]
	public Transform center1;

	// Token: 0x04001278 RID: 4728
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4001278")]
	private readonly List<PlantType> shovelPlants;
}
