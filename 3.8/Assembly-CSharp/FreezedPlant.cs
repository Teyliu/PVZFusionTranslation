using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002BC RID: 700
[Token(Token = "0x20002BC")]
public class FreezedPlant : GridItem, IDamageable
{
	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00046F48 File Offset: 0x00045148
	// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00046F5C File Offset: 0x0004515C
	[Token(Token = "0x170000A0")]
	public Team Team
	{
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x3A67D0", Offset = "0x3A4DD0", VA = "0x1803A67D0", Slot = "6")]
		get;
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x3A67E0", Offset = "0x3A4DE0", VA = "0x1803A67E0", Slot = "7")]
		set;
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x00046F70 File Offset: 0x00045170
	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x3D5510", Offset = "0x3D3B10", VA = "0x1803D5510")]
	private void Start()
	{
		if (this.fired)
		{
			this.<Team>k__BackingField = (Team)((ulong)1L);
		}
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00046F90 File Offset: 0x00045190
	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x3D5520", Offset = "0x3D3B20", VA = "0x1803D5520", Slot = "8")]
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

	// Token: 0x06000C57 RID: 3159 RVA: 0x000470F0 File Offset: 0x000452F0
	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x3D4E20", Offset = "0x3D3420", VA = "0x1803D4E20")]
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

	// Token: 0x06000C58 RID: 3160 RVA: 0x0004713C File Offset: 0x0004533C
	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x3D51F0", Offset = "0x3D37F0", VA = "0x1803D51F0")]
	public void SetEntity(Team team)
	{
		if (!this.set)
		{
			this.set = true;
			if (team != Team.Player)
			{
				CreateZombie instance = CreateZombie.Instance;
				int num = 0;
				if ((this.fired ? 1 : 0) == num)
				{
					Dictionary<PlantType, ZombieType> turnDic = FreezedPlant.TurnDic;
					PlantType plantType = this.thePlantType;
					if (!turnDic.TryGetValue(plantType, num))
					{
						int num2 = (int)(team + 57);
					}
				}
				Transform transform = base.transform;
			}
			CreatePlant instance2 = CreatePlant.Instance;
			int num3 = 0;
			int num4 = 0;
			Plant plant;
			if (plant != num4)
			{
				Plant component = plant.GetComponent<Plant>();
				if ((this.saved ? 1 : 0) != num3)
				{
					this.savedData.LoadData(component);
				}
			}
			ParticleManager instance3 = ParticleManager.Instance;
			Transform transform2 = base.transform;
		}
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x000471F4 File Offset: 0x000453F4
	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x3D4440", Offset = "0x3D2A40", VA = "0x1803D4440")]
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

	// Token: 0x06000C5A RID: 3162 RVA: 0x000472C0 File Offset: 0x000454C0
	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x3D4BD0", Offset = "0x3D31D0", VA = "0x1803D4BD0")]
	private ZombieType GetZombieType()
	{
		if (!this.fired)
		{
			Dictionary<PlantType, ZombieType> turnDic = FreezedPlant.TurnDic;
			bool flag;
			if (!flag)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x000472F4 File Offset: 0x000454F4
	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x3D4F40", Offset = "0x3D3540", VA = "0x1803D4F40")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet>(num);
		if (flag)
		{
			if (flag <= true)
			{
				this.deathTeam = typeof(GameAPP).TypeHandle;
				if ((this.fired ? 1 : 0) == num)
				{
					return;
				}
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
			}
			int theItemRow = this.theItemRow;
			this.deathTeam = typeof(GameAPP).TypeHandle;
			while ((this.fired ? 1 : 0) == num)
			{
			}
			throw new NullReferenceException();
		}
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00047394 File Offset: 0x00045594
	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x3D4C90", Offset = "0x3D3290", VA = "0x1803D4C90")]
	private void HitBullet(Bullet bullet)
	{
		Team team = bullet.<Team>k__BackingField;
		bullet.hit = true;
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

	// Token: 0x06000C5D RID: 3165 RVA: 0x00047418 File Offset: 0x00045618
	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x3D3EB0", Offset = "0x3D24B0", VA = "0x1803D3EB0", Slot = "5")]
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

	// Token: 0x06000C5E RID: 3166 RVA: 0x0004744C File Offset: 0x0004564C
	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x3D3EF0", Offset = "0x3D24F0", VA = "0x1803D3EF0")]
	private void FixedUpdate()
	{
		base.FlashUpdate();
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x00047460 File Offset: 0x00045660
	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x3D3E50", Offset = "0x3D2450", VA = "0x1803D3E50")]
	public static bool CanFreeze(Plant plant)
	{
		if (plant.plantTag == (ulong)0L)
		{
			bool flag;
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00047484 File Offset: 0x00045684
	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x3D3DF0", Offset = "0x3D23F0", VA = "0x1803D3DF0")]
	public static bool CanFreezeFire(Plant plant)
	{
		if (plant.plantTag == (ulong)0L)
		{
			bool flag;
			return flag;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x000474A8 File Offset: 0x000456A8
	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x3D3F00", Offset = "0x3D2500", VA = "0x1803D3F00")]
	public static FreezedPlant FreezePlant(Plant plant, bool fire = false)
	{
		if (plant.plantTag == (ulong)0L)
		{
		}
		int num = 0;
		if (!fire || plant.plantTag == num)
		{
		}
		if (num == 0)
		{
		}
		int thePlantColumn = plant.thePlantColumn;
		PlantType plantType = plant.thePlantType;
		GridItem gridItem;
		Board board = gridItem.board;
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
					FreezedPlant.<>c.<>9__28_0 = func;
				}
				Zombie zombie = Enumerable.FirstOrDefault<Zombie>(zombieHead, func);
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x0004757C File Offset: 0x0004577C
	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x3D5B70", Offset = "0x3D4170", VA = "0x1803D5B70")]
	public FreezedPlant()
	{
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x000475A8 File Offset: 0x000457A8
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x3D5890", Offset = "0x3D3E90", VA = "0x1803D5890")]
	static FreezedPlant()
	{
		Dictionary<PlantType, ZombieType> dictionary = new Dictionary();
		dictionary.Add((uint)3, (uint)103);
		int num = 0;
		dictionary.Add(num, (uint)100);
		dictionary.Add((uint)1001, (uint)101);
		dictionary.Add((uint)1005, (uint)102);
		dictionary.Add((uint)2, (uint)104);
		dictionary.Add((uint)13, (uint)115);
		dictionary.Add((uint)16, (uint)117);
		dictionary.Add((uint)1054, (uint)116);
		dictionary.Add((uint)1020, (uint)108);
		dictionary.Add((uint)1029, (uint)106);
		dictionary.Add((uint)1028, (uint)109);
		dictionary.Add((uint)901, (uint)203);
		dictionary.Add((uint)1208, (uint)52);
		dictionary.Add((uint)1003, (uint)107);
		dictionary.Add((uint)11, (uint)120);
		dictionary.Add((uint)913, (uint)127);
		dictionary.Add((uint)905, (uint)129);
		dictionary.Add((uint)1006, (uint)128);
		dictionary.Add((uint)971, (uint)242);
		dictionary.Add((uint)1215, (uint)80);
		dictionary.Add((uint)1032, (uint)130);
		dictionary.Add((uint)1106, (uint)131);
		FreezedPlant.TurnDic = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x04000877 RID: 2167
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000877")]
	private Team deathTeam;

	// Token: 0x04000878 RID: 2168
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000878")]
	public float health = 2000f;

	// Token: 0x04000879 RID: 2169
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000879")]
	public float maxHealth = 2000f;

	// Token: 0x0400087A RID: 2170
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400087A")]
	public bool fired;

	// Token: 0x0400087B RID: 2171
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400087B")]
	public int fireCount;

	// Token: 0x0400087C RID: 2172
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400087C")]
	private bool set;

	// Token: 0x0400087D RID: 2173
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400087D")]
	public PlantType thePlantType;

	// Token: 0x0400087E RID: 2174
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400087E")]
	public GameObject g;

	// Token: 0x0400087F RID: 2175
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400087F")]
	public GameObject iceTrap;

	// Token: 0x04000880 RID: 2176
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000880")]
	public GameObject iceTrap2;

	// Token: 0x04000881 RID: 2177
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000881")]
	public SavePlantData savedData;

	// Token: 0x04000882 RID: 2178
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000882")]
	public bool saved;

	// Token: 0x04000883 RID: 2179
	[Token(Token = "0x4000883")]
	private static readonly Dictionary<PlantType, ZombieType> TurnDic;
}
