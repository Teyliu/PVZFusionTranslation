using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002CA RID: 714
[Token(Token = "0x20002CA")]
public class FreezedPlant : GridItem, IDamageable
{
	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00047C04 File Offset: 0x00045E04
	// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00047C18 File Offset: 0x00045E18
	[Token(Token = "0x170000E1")]
	public Team Team
	{
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x3F2760", Offset = "0x3F0D60", VA = "0x1803F2760", Slot = "6")]
		get;
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x3F2770", Offset = "0x3F0D70", VA = "0x1803F2770", Slot = "7")]
		set;
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x00047C2C File Offset: 0x00045E2C
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x431910", Offset = "0x42FF10", VA = "0x180431910")]
	private void Start()
	{
		if (this.fired)
		{
			this.<Team>k__BackingField = (Team)((ulong)1L);
		}
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x00047C4C File Offset: 0x00045E4C
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x431920", Offset = "0x42FF20", VA = "0x180431920", Slot = "8")]
	public void TakeDamage(int value, IDamageMaker damageFrom, DamageType DamageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		int num = 0;
		if (damageFrom != 0)
		{
			if (num < value)
			{
				num += num;
				num++;
			}
			if (typeof(global::Core.Lawnf).TypeHandle != 0)
			{
				goto IL_0026;
			}
		}
		if (this.fired)
		{
			return;
		}
		IL_0026:
		float num2 = this.health;
		this.deathTeam = (Team)num;
		this.lightCountDown = 0.2f;
		this.health = num2;
		float num3;
		float num4;
		if (!global::Core.Lawnf.ValueBetween(num3, num2, num4))
		{
			float num5;
			if (num5 <= this.health)
			{
				goto IL_0140;
			}
			SpriteRenderer component = this.g.GetComponent<SpriteRenderer>();
			int num6 = 0;
			component.enabled = num6 != 0;
			Transform transform = this.g.transform;
			int num7 = 0;
			GameObject gameObject = transform.GetChild(num7).gameObject;
			int num8 = 0;
			gameObject.SetActive(num8 != 0);
			uint num9;
			ulong num10;
			this.g.transform.GetChild((int)num9).gameObject.SetActive(num10 != 0UL);
			GameObject gameObject2 = this.iceTrap2;
			gameObject2 += gameObject2;
		}
		SpriteRenderer component2 = this.g.GetComponent<SpriteRenderer>();
		int num11 = 0;
		component2.enabled = num11 != 0;
		Transform transform2 = this.g.transform;
		int num12 = 0;
		ulong num13;
		transform2.GetChild(num12).gameObject.SetActive(num13 != 0UL);
		uint num14;
		GameObject gameObject3 = this.g.transform.GetChild((int)num14).gameObject;
		int num15 = 0;
		gameObject3.SetActive(num15 != 0);
		ulong num16;
		this.iceTrap.SetActive(num16 != 0UL);
		IL_0140:
		base.Die();
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00047DAC File Offset: 0x00045FAC
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x4311C0", Offset = "0x42F7C0", VA = "0x1804311C0")]
	public void InitFreezedPlant(PlantType thePlantType)
	{
		Board board = this.board;
		this.thePlantType = thePlantType;
		Transform transform = base.transform;
		GameObject gameObject;
		SortingGroup component = gameObject.GetComponent<SortingGroup>();
		int num = 0;
		component.sortingLayerID = num;
		component.sortingOrder = 5;
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00047DF8 File Offset: 0x00045FF8
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x431570", Offset = "0x42FB70", VA = "0x180431570")]
	public void SetEntity(Team team)
	{
		if (!this.set)
		{
			this.set = true;
			int num = 0;
			bool flag;
			if (flag || this.thePlantType == PlantType.Bamboo)
			{
			}
			int theItemRow = this.theItemRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(this.theItemColumn, theItemRow);
			Func<Plant, bool> func;
			if (FreezedPlant.<>c.<>9__19_0 == 0)
			{
				func = delegate(Plant a)
				{
					int num7 = 0;
					if (a != 0)
					{
					}
					return num7 != 0;
				};
				FreezedPlant.<>c.<>9__19_0 = func;
			}
			bool flag2 = Enumerable.Any<Plant>(list, func);
			if (team != Team.Player)
			{
				CreateZombie instance = CreateZombie.Instance;
				if ((this.fired ? 1 : 0) == num)
				{
					uint num3;
					int num2 = global::UnityEngine.Random.Range(0, (int)num3);
				}
				Transform transform = base.transform;
			}
			CreatePlant instance2 = CreatePlant.Instance;
			PlantType plantType = this.thePlantType;
			int theItemRow2 = this.theItemRow;
			int theItemColumn = this.theItemColumn;
			ulong num4;
			ulong num5;
			Plant plant = instance2.SetPlant(theItemColumn, theItemRow2, plantType, num, num, num4 != 0UL, num5 != 0UL, num);
			int num6 = 0;
			if (plant != num6 && (this.saved ? 1 : 0) != num)
			{
				this.savedData.LoadData(plant);
			}
			ParticleManager instance3 = ParticleManager.Instance;
			Transform transform2 = base.transform;
		}
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00047F0C File Offset: 0x0004610C
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x430870", Offset = "0x42EE70", VA = "0x180430870")]
	public PlantType GetPlantType(int index)
	{
		List<PlantType> list = new List();
		if (GameAPP.theBoardLevel <= 7)
		{
			List<PlantType> list2 = new List();
			List<PlantType> list3 = new List();
			List<PlantType> list4 = new List();
			List<PlantType> list5 = new List();
			List<PlantType> list6 = new List();
			List<PlantType> list7 = new List();
			List<PlantType> list8 = new List();
			List<PlantType> list9 = new List();
		}
		List<PlantType> list10 = new List();
		int size = list10._size;
		list10._size = list10;
		int size2 = list10._size;
		list10._size = list10;
		int size3 = list10._size;
		list10._size = list10;
		int size4 = list10._size;
		list10._size = list10;
		int size5 = list10._size;
		list10._size = list10;
		PlantType plantType;
		return plantType;
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00047FD8 File Offset: 0x000461D8
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x431000", Offset = "0x42F600", VA = "0x180431000")]
	private ZombieType GetZombieType()
	{
		if (!this.fired)
		{
			int num = global::UnityEngine.Random.Range(0, 4);
			return ZombieType.SnowConeZombie;
		}
		return ZombieType.EndoFlameZombie;
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x00047FFC File Offset: 0x000461FC
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x4312E0", Offset = "0x42F8E0", VA = "0x1804312E0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet>(num);
		if (flag && flag <= true)
		{
			int theItemRow = this.theItemRow;
			this.deathTeam = typeof(GameAPP).TypeHandle;
			if ((this.fired ? 1 : 0) != num)
			{
				uint num2;
				uint num3;
				GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num2, (int)num3), 0.5f, 1f);
				Transform transform = collision.transform;
				Vector3 vector;
				float z = vector.z;
				int num4 = this.fireCount;
				this.lightCountDown = 0.2f;
				this.fireCount = num4;
				base.Die();
				throw new NullReferenceException();
			}
		}
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x0004809C File Offset: 0x0004629C
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x431040", Offset = "0x42F640", VA = "0x180431040")]
	private void HitBullet(Bullet bullet)
	{
		Team team = bullet.<Team>k__BackingField;
		this.deathTeam = team;
		if (!this.fired)
		{
			bullet.HitBlock();
			return;
		}
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		Transform transform = bullet.transform;
		Vector3 vector;
		float z = vector.z;
		bullet.Die();
		int num = this.fireCount;
		this.lightCountDown = 0.2f;
		this.fireCount = num;
		throw new NullReferenceException();
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00048118 File Offset: 0x00046318
	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x4302F0", Offset = "0x42E8F0", VA = "0x1804302F0", Slot = "5")]
	protected override void DieEvent()
	{
		base.DieEvent();
		if (this.deathTeam == Team.Player)
		{
			AdvantureMission.TryAddCount((AdvantureLevel)((uint)61));
		}
		Team team = this.deathTeam;
		this.SetEntity(team);
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0004814C File Offset: 0x0004634C
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x430330", Offset = "0x42E930", VA = "0x180430330")]
	private void FixedUpdate()
	{
		base.FlashUpdate();
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00048160 File Offset: 0x00046360
	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x430290", Offset = "0x42E890", VA = "0x180430290")]
	public static bool CanFreeze(Plant plant)
	{
		if (plant.plantTag == (ulong)0L)
		{
			bool flag;
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00048184 File Offset: 0x00046384
	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x430230", Offset = "0x42E830", VA = "0x180430230")]
	public static bool CanFreezeFire(Plant plant)
	{
		if (plant.plantTag == (ulong)0L)
		{
			bool flag;
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x000481A8 File Offset: 0x000463A8
	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x430340", Offset = "0x42E940", VA = "0x180430340")]
	public static FreezedPlant FreezePlant(Plant plant, bool fire = false)
	{
		if (plant.plantTag == (ulong)0L)
		{
		}
		int num = 0;
		if (!fire || plant.plantTag == num)
		{
		}
		if (num != 0)
		{
			Board board = plant.board;
			int thePlantColumn = plant.thePlantColumn;
			PlantType plantType = plant.thePlantType;
			GridItem gridItem;
			Board board2 = gridItem.board;
			Transform transform = gridItem.transform;
			GameObject gameObject;
			SortingGroup component = gameObject.GetComponent<SortingGroup>();
			int num2 = 0;
			component.sortingLayerID = num2;
			uint num3;
			component.sortingOrder = (int)num3;
			SavePlantData savePlantData = new SavePlantData(plant);
			Transform axis = plant.axis;
			ParticleManager instance = ParticleManager.Instance;
			if (fire)
			{
				gridItem.GetComponent<Animator>().Play("idle");
				bool flag;
				if (flag)
				{
					List<Zombie> zombieHead = Board.Instance.zombieHead;
					Func<Zombie, bool> func;
					if (FreezedPlant.<>c.<>9__28_0 == 0)
					{
						func = (Zombie a) => a.theZombieType == ZombieType.UltimateEndoflameZombie;
						FreezedPlant.<>c.<>9__28_0 = func;
					}
					Zombie zombie = Enumerable.FirstOrDefault<Zombie>(zombieHead, func);
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00048294 File Offset: 0x00046494
	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x431C90", Offset = "0x430290", VA = "0x180431C90")]
	public FreezedPlant()
	{
	}

	// Token: 0x040008B4 RID: 2228
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40008B4")]
	private Team deathTeam;

	// Token: 0x040008B5 RID: 2229
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008B5")]
	public float health = 2000f;

	// Token: 0x040008B6 RID: 2230
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40008B6")]
	public float maxHealth = 2000f;

	// Token: 0x040008B7 RID: 2231
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008B7")]
	public bool fired;

	// Token: 0x040008B8 RID: 2232
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40008B8")]
	public int fireCount;

	// Token: 0x040008B9 RID: 2233
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008B9")]
	private bool set;

	// Token: 0x040008BA RID: 2234
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40008BA")]
	public PlantType thePlantType;

	// Token: 0x040008BB RID: 2235
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008BB")]
	public GameObject g;

	// Token: 0x040008BC RID: 2236
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008BC")]
	public GameObject iceTrap;

	// Token: 0x040008BD RID: 2237
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008BD")]
	public GameObject iceTrap2;

	// Token: 0x040008BE RID: 2238
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008BE")]
	public SavePlantData savedData;

	// Token: 0x040008BF RID: 2239
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008BF")]
	public bool saved;
}
