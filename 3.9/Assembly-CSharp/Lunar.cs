using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D6 RID: 726
[Token(Token = "0x20002D6")]
public class Lunar : MonoBehaviour
{
	// Token: 0x06000CF5 RID: 3317 RVA: 0x00049D9C File Offset: 0x00047F9C
	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x438C90", Offset = "0x437290", VA = "0x180438C90")]
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

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00049E34 File Offset: 0x00048034
	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x439270", Offset = "0x437870", VA = "0x180439270")]
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

	// Token: 0x06000CF7 RID: 3319 RVA: 0x00049F34 File Offset: 0x00048134
	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x439F40", Offset = "0x438540", VA = "0x180439F40")]
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

	// Token: 0x06000CF8 RID: 3320 RVA: 0x00049FC4 File Offset: 0x000481C4
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x4397B0", Offset = "0x437DB0", VA = "0x1804397B0")]
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

	// Token: 0x06000CF9 RID: 3321 RVA: 0x0004A078 File Offset: 0x00048278
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x4396E0", Offset = "0x437CE0", VA = "0x1804396E0")]
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

	// Token: 0x06000CFA RID: 3322 RVA: 0x0004A0F0 File Offset: 0x000482F0
	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x439AD0", Offset = "0x4380D0", VA = "0x180439AD0")]
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

	// Token: 0x06000CFB RID: 3323 RVA: 0x0004A25C File Offset: 0x0004845C
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x438F20", Offset = "0x437520", VA = "0x180438F20")]
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

	// Token: 0x06000CFC RID: 3324 RVA: 0x0004A36C File Offset: 0x0004856C
	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x438E60", Offset = "0x437460", VA = "0x180438E60")]
	private void FixedUpdate()
	{
		List<LunarLine> list = this.lines;
		GameObject gameObject = this.AttackLine.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x0004A3A0 File Offset: 0x000485A0
	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x4387E0", Offset = "0x436DE0", VA = "0x1804387E0")]
	private void AttackUpdate()
	{
		List<Zombie> allZombies = Lawnf.GetAllZombies(false);
		Predicate<Zombie> predicate;
		if (Lunar.<>c.<>9__19_0 == 0)
		{
			Lunar.<>c.<>9__19_0 = predicate;
		}
		List<Zombie> list = allZombies.FindAll(predicate);
		Func<Zombie, long> func;
		if (Lunar.<>c.<>9__19_1 == 0)
		{
			Lunar.<>c.<>9__19_1 = func;
		}
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderByDescending<Zombie, long>(list, func));
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

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0004A4B4 File Offset: 0x000486B4
	[Token(Token = "0x170000E7")]
	private LunarLine AttackLine
	{
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x43A300", Offset = "0x438900", VA = "0x18043A300")]
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

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0004A558 File Offset: 0x00048758
	[Token(Token = "0x170000E8")]
	private bool God
	{
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x43A460", Offset = "0x438A60", VA = "0x18043A460")]
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

	// Token: 0x06000D00 RID: 3328 RVA: 0x0004A5A8 File Offset: 0x000487A8
	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x43A070", Offset = "0x438670", VA = "0x18043A070")]
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

	// Token: 0x0400091B RID: 2331
	[Token(Token = "0x400091B")]
	public static Lunar Instance;

	// Token: 0x0400091C RID: 2332
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400091C")]
	public GameObject line;

	// Token: 0x0400091D RID: 2333
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400091D")]
	public readonly List<LunarLine> lines;

	// Token: 0x0400091E RID: 2334
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400091E")]
	public bool red;

	// Token: 0x0400091F RID: 2335
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400091F")]
	private Board board;

	// Token: 0x04000920 RID: 2336
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000920")]
	private float timer;

	// Token: 0x04000921 RID: 2337
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000921")]
	private float summonTimer;

	// Token: 0x04000922 RID: 2338
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000922")]
	public float lifeTimer;

	// Token: 0x04000923 RID: 2339
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000923")]
	private readonly List<ZombieType> RedSummonZombies;

	// Token: 0x04000924 RID: 2340
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000924")]
	private Zombie lockedZombie;

	// Token: 0x04000925 RID: 2341
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000925")]
	private float lockedTimer;

	// Token: 0x04000926 RID: 2342
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000926")]
	private LunarLine _attackLine;
}
