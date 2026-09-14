using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000706 RID: 1798
[Token(Token = "0x2000706")]
public class UltimateSwordZombie : Zombie
{
	// Token: 0x06002410 RID: 9232 RVA: 0x000BC42C File Offset: 0x000BA62C
	[Token(Token = "0x6002410")]
	[Address(RVA = "0x58E780", Offset = "0x58CD80", VA = "0x18058E780", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 7f;
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x000BC44C File Offset: 0x000BA64C
	[Token(Token = "0x6002411")]
	[Address(RVA = "0x58E5F0", Offset = "0x58CBF0", VA = "0x18058E5F0", Slot = "23")]
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

	// Token: 0x06002412 RID: 9234 RVA: 0x000BC4F4 File Offset: 0x000BA6F4
	[Token(Token = "0x6002412")]
	[Address(RVA = "0x58E1F0", Offset = "0x58C7F0", VA = "0x18058E1F0")]
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

	// Token: 0x06002413 RID: 9235 RVA: 0x000BC59C File Offset: 0x000BA79C
	[Token(Token = "0x6002413")]
	[Address(RVA = "0x58FE50", Offset = "0x58E450", VA = "0x18058FE50")]
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
				Func<Plant, bool> func;
				UltimateSwordZombie.<>c.<>9__9_0 = func;
			}
			IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(plantsByRow, <>9__9_);
			Func<Plant, int> func2;
			if (UltimateSwordZombie.<>c.<>9__9_1 == 0)
			{
				UltimateSwordZombie.<>c.<>9__9_1 = func2;
			}
			Plant plant5 = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderByDescending<Plant, int>(enumerable, func2));
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

	// Token: 0x06002414 RID: 9236 RVA: 0x000BC6D0 File Offset: 0x000BA8D0
	[Token(Token = "0x6002414")]
	[Address(RVA = "0x58F8E0", Offset = "0x58DEE0", VA = "0x18058F8E0")]
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
				Func<Zombie, bool> func;
				UltimateSwordZombie.<>c.<>9__10_0 = func;
			}
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombiesByRow, <>9__10_);
			Func<Zombie, float> func2;
			if (UltimateSwordZombie.<>c.<>9__10_1 == 0)
			{
				UltimateSwordZombie.<>c.<>9__10_1 = func2;
			}
			Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, float>(enumerable, func2));
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

	// Token: 0x06002415 RID: 9237 RVA: 0x000BC7D8 File Offset: 0x000BA9D8
	[Token(Token = "0x6002415")]
	[Address(RVA = "0x590330", Offset = "0x58E930", VA = "0x180590330")]
	private void UseShovel()
	{
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, bool> <>9__11_ = UltimateSwordZombie.<>c.<>9__11_0;
		if (<>9__11_ == 0)
		{
			Func<Plant, bool> func;
			UltimateSwordZombie.<>c.<>9__11_0 = func;
		}
		IEnumerable<Plant> enumerable = Enumerable.Where<Plant>(allPlants, <>9__11_);
		Func<Plant, int> func2;
		if (UltimateSwordZombie.<>c.<>9__11_1 == 0)
		{
			UltimateSwordZombie.<>c.<>9__11_1 = func2;
		}
		Plant plant5 = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderBy<Plant, int>(enumerable, func2));
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

	// Token: 0x06002416 RID: 9238 RVA: 0x000BC8CC File Offset: 0x000BAACC
	[Token(Token = "0x6002416")]
	[Address(RVA = "0x58EF50", Offset = "0x58D550", VA = "0x18058EF50", Slot = "15")]
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
			this.wudi = false;
			int num9 = 0;
			bool flag = base.RemoveBuff((EffectType)num9);
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

	// Token: 0x06002417 RID: 9239 RVA: 0x000BC980 File Offset: 0x000BAB80
	[Token(Token = "0x6002417")]
	[Address(RVA = "0x58EDC0", Offset = "0x58D3C0", VA = "0x18058EDC0")]
	private void Explode()
	{
		UltimateSwordZombie.<Exploding>d__14 <Exploding>d__;
		<Exploding>d__.System.IDisposable.Dispose();
		<Exploding>d__.<>1__state = (int)((ulong)0L);
		<Exploding>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Exploding>d__);
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x000BC9AC File Offset: 0x000BABAC
	[Token(Token = "0x6002418")]
	[Address(RVA = "0x58EE40", Offset = "0x58D440", VA = "0x18058EE40")]
	private IEnumerator Exploding()
	{
		UltimateSwordZombie.<Exploding>d__14 <Exploding>d__;
		<Exploding>d__.System.IDisposable.Dispose();
		<Exploding>d__.<>1__state = (int)((ulong)0L);
		<Exploding>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x000BC9D0 File Offset: 0x000BABD0
	[Token(Token = "0x6002419")]
	[Address(RVA = "0x58EAE0", Offset = "0x58D0E0", VA = "0x18058EAE0", Slot = "28")]
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

	// Token: 0x0600241A RID: 9242 RVA: 0x000BCA84 File Offset: 0x000BAC84
	[Token(Token = "0x600241A")]
	[Address(RVA = "0x58F530", Offset = "0x58DB30", VA = "0x18058F530", Slot = "16")]
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

	// Token: 0x0600241B RID: 9243 RVA: 0x000BCB3C File Offset: 0x000BAD3C
	[Token(Token = "0x600241B")]
	[Address(RVA = "0x58F130", Offset = "0x58D730", VA = "0x18058F130", Slot = "12")]
	public override void TakeDamage(int theDamage, IDamageMaker damageFrom, DamageType theDamageType, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (!this.wudi)
		{
			return;
		}
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x000BCB58 File Offset: 0x000BAD58
	[Token(Token = "0x600241C")]
	[Address(RVA = "0x58E7A0", Offset = "0x58CDA0", VA = "0x18058E7A0", Slot = "29")]
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

	// Token: 0x0600241D RID: 9245 RVA: 0x000BCBEC File Offset: 0x000BADEC
	[Token(Token = "0x600241D")]
	[Address(RVA = "0x58EEB0", Offset = "0x58D4B0", VA = "0x18058EEB0", Slot = "39")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
		}
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x000BCC0C File Offset: 0x000BAE0C
	[Token(Token = "0x600241E")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public override void Garliced(bool playSound = false, bool certainRow = false)
	{
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x000BCC1C File Offset: 0x000BAE1C
	[Token(Token = "0x600241F")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x000BCC2C File Offset: 0x000BAE2C
	[Token(Token = "0x6002420")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x000BCC3C File Offset: 0x000BAE3C
	[Token(Token = "0x6002421")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "53")]
	public override void AddPoisonLevel()
	{
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x000BCC4C File Offset: 0x000BAE4C
	[Token(Token = "0x6002422")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x000BCC5C File Offset: 0x000BAE5C
	[Token(Token = "0x6002423")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "70")]
	public override void RealKnockBack(float x)
	{
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x000BCC6C File Offset: 0x000BAE6C
	[Token(Token = "0x6002424")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x000BCC7C File Offset: 0x000BAE7C
	[Token(Token = "0x6002425")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "58")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x000BCC8C File Offset: 0x000BAE8C
	[Token(Token = "0x6002426")]
	[Address(RVA = "0x546F50", Offset = "0x545550", VA = "0x180546F50", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		if (num > 5000)
		{
		}
		return num;
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x000BCCA8 File Offset: 0x000BAEA8
	[Token(Token = "0x6002427")]
	[Address(RVA = "0x546D50", Offset = "0x545350", VA = "0x180546D50", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002428 RID: 9256 RVA: 0x000BCCB8 File Offset: 0x000BAEB8
	[Token(Token = "0x6002428")]
	[Address(RVA = "0x590770", Offset = "0x58ED70", VA = "0x180590770")]
	public UltimateSwordZombie()
	{
		List<PlantType> list = new List();
		this.shovelPlants = list;
		base..ctor();
	}

	// Token: 0x040011A1 RID: 4513
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40011A1")]
	private bool wudi;

	// Token: 0x040011A2 RID: 4514
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40011A2")]
	public GameObject hammerPrefab;

	// Token: 0x040011A3 RID: 4515
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40011A3")]
	public GameObject glovePrefab;

	// Token: 0x040011A4 RID: 4516
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x40011A4")]
	public GameObject shovelPrefab;

	// Token: 0x040011A5 RID: 4517
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011A5")]
	public Transform center1;

	// Token: 0x040011A6 RID: 4518
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011A6")]
	private readonly List<PlantType> shovelPlants;
}
