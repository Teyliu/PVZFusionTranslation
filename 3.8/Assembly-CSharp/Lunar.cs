using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002C8 RID: 712
[Token(Token = "0x20002C8")]
public class Lunar : MonoBehaviour
{
	// Token: 0x06000CB2 RID: 3250 RVA: 0x000491B0 File Offset: 0x000473B0
	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x3E8150", Offset = "0x3E6750", VA = "0x1803E8150")]
	private void Awake()
	{
		Lunar.Instance = this;
		if (GameAPP.config.disableSolarStarEffect)
		{
			Transform transform = base.transform;
			int num = 0;
			GameObject gameObject = transform.GetChild(num).gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
		}
		Board instance = Board.Instance;
		this.board = instance;
		Board board = this.board;
		Mouse instance2 = Mouse.Instance;
		int columnNum = board.columnNum;
		float boxXFromColumn = instance2.GetBoxXFromColumn(columnNum);
		Mouse instance3 = Mouse.Instance;
		int num3 = 0;
		float boxYFromRow = instance3.GetBoxYFromRow(num3);
		Transform transform2 = base.transform;
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x00049248 File Offset: 0x00047448
	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x3E8730", Offset = "0x3E6D30", VA = "0x1803E8730")]
	public void Init()
	{
		int num3;
		do
		{
			int num = 0;
			this.lifeTimer = 15f;
			List<LunarLine> list = this.lines;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
			if (num2 != 0)
			{
				goto IL_00D2;
			}
			num3 = 0;
			int num4 = 0;
			if (!Lawnf.TravelAdvanced((AdvBuff)((uint)3003)))
			{
				break;
			}
			int plantCount = Lawnf.GetPlantCount((PlantType)((uint)909), num4);
			int plantCount2 = Lawnf.GetPlantCount((PlantType)((uint)955), num4);
			int num5 = 0;
			List<Plant> plants = Lawnf.GetPlants((PlantType)((uint)909), num4, num5 != 0);
			int num6 = 0;
			List<Plant> plants2 = Lawnf.GetPlants((PlantType)((uint)955), num4, num6 != 0);
			List<Plant> list2 = Enumerable.ToList<Plant>(Enumerable.Concat<Plant>(plants, plants2));
			bool flag2;
			if (flag2)
			{
				GameObject gameObject2;
				LunarLine component = gameObject2.GetComponent<LunarLine>();
				component.plant = num;
				component.lunar = 0;
				component.lunar = component;
			}
		}
		while (num3 != 0);
		return;
		IL_00D2:
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x00049348 File Offset: 0x00047548
	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x3E9400", Offset = "0x3E7A00", VA = "0x1803E9400")]
	private void Update()
	{
		int num = 0;
		if ((this.red ? 1 : 0) == num)
		{
			this.RecoverUpdate();
		}
		this.SummonUpdate();
		float num2 = this.lifeTimer;
		float deltaTime = Time.deltaTime;
		this.lifeTimer = num2;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)3003)))
		{
			Board board = this.board;
			int plantCount = Lawnf.GetPlantCount((PlantType)((uint)909), board);
			Board board2 = this.board;
			int plantCount2 = Lawnf.GetPlantCount((PlantType)((uint)955), board2);
			this.lifeTimer = 15f;
			return;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x000493D8 File Offset: 0x000475D8
	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x3E8C70", Offset = "0x3E7270", VA = "0x1803E8C70")]
	private void RecoverUpdate()
	{
		int num;
		int num3;
		do
		{
			num = 0;
			float num2 = this.timer;
			float deltaTime = Time.deltaTime;
			this.timer = num2;
			this.timer = 1f;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			num3 = 0;
			Board board = this.board;
			int plantCount = Lawnf.GetPlantCount((PlantType)((uint)955), board);
			long num4 = (long)(1U * (uint)50);
			Solar instance = Solar.Instance;
			int num5 = 0;
			if (instance != num5)
			{
				long num6 = (long)(1U * (uint)100);
			}
			if (Lawnf.TravelUltimate((UltiBuff)((uint)23)))
			{
			}
			bool flag;
			if (flag)
			{
			}
		}
		while (num3 != 0);
		int num7 = 0;
		if (num != num7)
		{
		}
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x0004948C File Offset: 0x0004768C
	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x3E8BA0", Offset = "0x3E71A0", VA = "0x1803E8BA0")]
	private void LiveUpdate()
	{
		float num = this.lifeTimer;
		float deltaTime = Time.deltaTime;
		this.lifeTimer = num;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)3003)))
		{
			Board board = this.board;
			int plantCount = Lawnf.GetPlantCount((PlantType)((uint)909), board);
			Board board2 = this.board;
			int plantCount2 = Lawnf.GetPlantCount((PlantType)((uint)955), board2);
			this.lifeTimer = 15f;
			return;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00049504 File Offset: 0x00047704
	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x3E8F90", Offset = "0x3E7590", VA = "0x1803E8F90")]
	private void SummonUpdate()
	{
		float num = this.summonTimer;
		float deltaTime = Time.deltaTime;
		this.summonTimer = num;
		this.summonTimer = 10f;
		List<Vector2Int> list = Enumerable.ToList<Vector2Int>(this.GetFreeBoxes());
		Board board = this.board;
		int num2 = 0;
		int num3 = list._size;
		num3 += board;
		if (num2 < num3)
		{
			int num4 = list._size;
			num4 = global::UnityEngine.Random.Range(0, num4);
			Vector2Int vector2Int = list[num4];
			List<ZombieType> redSummonZombies = this.RedSummonZombies;
			int num5 = redSummonZombies._size;
			num5 = global::UnityEngine.Random.Range(0, num5);
			int num6 = redSummonZombies[num5];
			CreateZombie instance = CreateZombie.Instance;
			Mouse instance2 = Mouse.Instance;
			int x = vector2Int.m_X;
			float boxXFromColumn = instance2.GetBoxXFromColumn(x);
			int num7 = 0;
			Zombie zombie;
			if (zombie != num7)
			{
				Zombie component = zombie.GetComponent<Zombie>();
				ParticleManager instance3 = ParticleManager.Instance;
				Transform axis = component.axis;
				Lawnf.SetZombieHealth(component, 1f);
				Particle particle;
				component.theAttackDamage = particle;
				if (num6 > 203)
				{
					if (num6 == 204)
					{
						goto IL_012C;
					}
					if (num6 != 209)
					{
						goto IL_0150;
					}
					component.theFirstArmorHealth = (int)((ulong)1L);
					component.UpdateHealthText();
				}
				if (num6 != 36)
				{
					goto IL_013E;
				}
				IL_012C:
				float theOriginSpeed = component.theOriginSpeed;
				component.theOriginSpeed = theOriginSpeed;
				IL_013E:
				if (num6 == 203)
				{
					component.theSecondArmorHealth = num2;
				}
			}
			IL_0150:
			num2++;
		}
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x00049670 File Offset: 0x00047870
	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x3E83E0", Offset = "0x3E69E0", VA = "0x1803E83E0")]
	private HashSet<Vector2Int> GetFreeBoxes()
	{
		HashSet<Vector2Int> hashSet;
		ulong num6;
		do
		{
			int num = 0;
			hashSet = new HashSet();
			int num2 = 0;
			int num3 = 0;
			Board board = this.board;
			if (num3 < board.columnNum)
			{
				int num4 = 0;
				Board board2 = this.board;
				if (num4 < board2.rowNum)
				{
					if (board2.gridSystem.GetGrid(num2, num4).boxType != BoxType.Water)
					{
						bool flag = hashSet.Add(num2);
					}
					num4++;
				}
				num2++;
			}
			Board board3 = this.board;
			List<Plant> plants = Lawnf.GetPlants((PlantType)((uint)302), board3, true);
			int num5 = 0;
			Board board4 = this.board;
			List<Plant> plants2 = Lawnf.GetPlants((PlantType)((uint)955), board4, num5 != 0);
			List<Plant> list = Enumerable.ToList<Plant>(Enumerable.Concat<Plant>(plants, plants2));
			bool flag2;
			if (flag2)
			{
				int columnNum = this.board.columnNum;
				int rowNum = this.board.rowNum;
				bool flag3 = hashSet.Remove(num);
				num++;
			}
		}
		while (num6 != (ulong)0L);
		return hashSet;
	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x00049780 File Offset: 0x00047980
	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x3E8320", Offset = "0x3E6920", VA = "0x1803E8320")]
	private void FixedUpdate()
	{
		List<LunarLine> list = this.lines;
		GameObject gameObject = this.AttackLine.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x000497B4 File Offset: 0x000479B4
	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x3E7CA0", Offset = "0x3E62A0", VA = "0x1803E7CA0")]
	private void AttackUpdate()
	{
		List<Zombie> allZombies = Lawnf.GetAllZombies(false);
		Predicate<Zombie> <>9__19_ = Lunar.<>c.<>9__19_0;
		if (<>9__19_ == 0)
		{
			Predicate<Zombie> predicate;
			Lunar.<>c.<>9__19_0 = predicate;
		}
		List<Zombie> list = allZombies.FindAll(<>9__19_);
		Func<Zombie, float> func;
		if (Lunar.<>c.<>9__19_1 == 0)
		{
			Lunar.<>c.<>9__19_1 = func;
		}
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, float>(list, func));
		int num = 0;
		if (!(zombie != num))
		{
			GameObject gameObject = this.AttackLine.gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
			this.lockedTimer = 0f;
			return;
		}
		Zombie zombie2 = this.lockedZombie;
		bool flag;
		if (!flag)
		{
			this.lockedTimer = 0f;
			this.lockedZombie = 0;
		}
		float fixedDeltaTime = Time.fixedDeltaTime;
		this.lockedTimer = fixedDeltaTime;
		ulong num3;
		this.AttackLine.gameObject.SetActive(num3 != 0UL);
		LunarLine attackLine = this.AttackLine;
		LineRenderer lineRenderer = attackLine.lineRenderer;
		LineRenderer lineRenderer2 = attackLine.lineRenderer;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		float num4;
		int num5;
		if (0 > (int)num4 || num4 > 1f)
		{
			num5 = 0;
		}
		List<LunarLine> list2 = this.lines;
		float num6 = (float)(num5 * (int)4f);
		throw new NullReferenceException();
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000CBB RID: 3259 RVA: 0x000498CC File Offset: 0x00047ACC
	[Token(Token = "0x170000A6")]
	private LunarLine AttackLine
	{
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x3E97C0", Offset = "0x3E7DC0", VA = "0x1803E97C0")]
		get
		{
			LunarLine attackLine = this._attackLine;
			int num = 0;
			if (attackLine == num)
			{
				GameObject gameObject = this.line;
				Transform transform = base.transform;
				LunarLine component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<LunarLine>();
				this._attackLine = component;
				this._attackLine.attack = true;
				LineRenderer lineRenderer = this._attackLine.lineRenderer;
				float num2 = lineRenderer.startWidth * 1.5f;
				lineRenderer.startWidth = num2;
				LineRenderer lineRenderer2 = this._attackLine.lineRenderer;
				float endWidth = lineRenderer2.endWidth;
				lineRenderer2.endWidth = num2;
			}
			return this._attackLine;
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00049970 File Offset: 0x00047B70
	[Token(Token = "0x170000A7")]
	private bool God
	{
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x3E9920", Offset = "0x3E7F20", VA = "0x1803E9920")]
		get
		{
			if (Lawnf.TravelAdvanced((AdvBuff)((uint)3003)))
			{
				Board board = this.board;
				int plantCount = Lawnf.GetPlantCount((PlantType)((uint)909), board);
				Board board2 = this.board;
				return Lawnf.GetPlantCount((PlantType)((uint)955), board2) >= 10;
			}
			return false;
		}
	}

	// Token: 0x06000CBD RID: 3261 RVA: 0x000499C0 File Offset: 0x00047BC0
	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x3E9530", Offset = "0x3E7B30", VA = "0x1803E9530")]
	public Lunar()
	{
		List<LunarLine> list = new List();
		this.lines = list;
		this.summonTimer = 3f;
		List<ZombieType> list2 = new List();
		int size = list2._size;
		int size2 = list2._size;
		int size3 = list2._size;
		int size4 = list2._size;
		int size5 = list2._size;
		this.RedSummonZombies = list2;
		base..ctor();
	}

	// Token: 0x040008DE RID: 2270
	[Token(Token = "0x40008DE")]
	public static Lunar Instance;

	// Token: 0x040008DF RID: 2271
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008DF")]
	public GameObject line;

	// Token: 0x040008E0 RID: 2272
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008E0")]
	public readonly List<LunarLine> lines;

	// Token: 0x040008E1 RID: 2273
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008E1")]
	public bool red;

	// Token: 0x040008E2 RID: 2274
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008E2")]
	private Board board;

	// Token: 0x040008E3 RID: 2275
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008E3")]
	private float timer;

	// Token: 0x040008E4 RID: 2276
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40008E4")]
	private float summonTimer;

	// Token: 0x040008E5 RID: 2277
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008E5")]
	public float lifeTimer;

	// Token: 0x040008E6 RID: 2278
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008E6")]
	private readonly List<ZombieType> RedSummonZombies;

	// Token: 0x040008E7 RID: 2279
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008E7")]
	private Zombie lockedZombie;

	// Token: 0x040008E8 RID: 2280
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008E8")]
	private float lockedTimer;

	// Token: 0x040008E9 RID: 2281
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008E9")]
	private LunarLine _attackLine;
}
