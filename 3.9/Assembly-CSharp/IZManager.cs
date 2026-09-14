using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x020000D8 RID: 216
[Token(Token = "0x20000D8")]
public class IZManager : MonoBehaviour
{
	// Token: 0x06000405 RID: 1029 RVA: 0x000139EC File Offset: 0x00011BEC
	[Token(Token = "0x6000405")]
	[Address(RVA = "0x4F2C80", Offset = "0x4F1280", VA = "0x1804F2C80")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		this.InitCards();
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00013A0C File Offset: 0x00011C0C
	[Token(Token = "0x6000406")]
	[Address(RVA = "0x4F39A0", Offset = "0x4F1FA0", VA = "0x1804F39A0")]
	private void Start()
	{
		InitBoard instance = InitBoard.Instance;
		int num = 0;
		IZECard izecard = instance.CreateCard((ZombieType)num, true);
		izecard.theSeedCost = (int)((ulong)4294967271L);
		izecard.fullCD = 3f;
		IZECard izecard2 = InitBoard.Instance.CreateCard((ZombieType)((uint)2), true);
		izecard2.theSeedCost = (int)((ulong)4294967246L);
		izecard2.fullCD = 6f;
		IZECard izecard3 = InitBoard.Instance.CreateCard((ZombieType)((uint)4), true);
		izecard3.theSeedCost = (int)((ulong)4294967221L);
		izecard3.fullCD = 10f;
		GameObject shovelBank = InGameUI.Instance.ShovelBank;
		int num2 = 0;
		shovelBank.SetActive(num2 != 0);
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00013AB8 File Offset: 0x00011CB8
	[Token(Token = "0x6000407")]
	[Address(RVA = "0x4F3080", Offset = "0x4F1680", VA = "0x1804F3080")]
	public void InitZombieCard()
	{
		InitBoard instance = InitBoard.Instance;
		int num = 0;
		IZECard izecard = instance.CreateCard((ZombieType)num, true);
		izecard.theSeedCost = (int)((ulong)4294967271L);
		izecard.fullCD = 3f;
		IZECard izecard2 = InitBoard.Instance.CreateCard((ZombieType)((uint)2), true);
		izecard2.theSeedCost = (int)((ulong)4294967246L);
		izecard2.fullCD = 6f;
		IZECard izecard3 = InitBoard.Instance.CreateCard((ZombieType)((uint)4), true);
		izecard3.theSeedCost = (int)((ulong)4294967221L);
		izecard3.fullCD = 10f;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00013B4C File Offset: 0x00011D4C
	[Token(Token = "0x6000408")]
	[Address(RVA = "0x4F2E40", Offset = "0x4F1440", VA = "0x1804F2E40")]
	private void InitCards()
	{
		int num2;
		do
		{
			int num = 0;
			List<PlantType> list = this.avaliablePlants;
			num2 = 0;
			bool flag;
			if (flag)
			{
				PlantDataManager.PlantData plantData = PlantDataManager.GetPlantData((PlantType)num);
				IZManager.AICard aicard;
				aicard.cd = (float)num2;
				float cd = plantData.cd;
				aicard.fullcd = cd;
				int cost = plantData.cost;
				aicard.cost = cost;
				aicard.thePlantType = (PlantType)num;
				List<IZManager.AICard> list2 = this.cards;
				int size = list2._size;
				list2._size = cost;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00013BE8 File Offset: 0x00011DE8
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x4F3160", Offset = "0x4F1760", VA = "0x1804F3160")]
	private void ObservalUpdate()
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			this.sunCount = num2;
			int[] array = new int[this.board.rowNum];
			this.damageLevel = array;
			int[] array2 = new int[this.board.rowNum];
			this.dangerLevel = array2;
			int[] array3 = new int[this.board.rowNum];
			this.subLevel = array3;
			Zombie[] array4 = new Zombie[this.board.rowNum];
			this.leftestZombie = array4;
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				bool flag2 = num != num3;
				while (!flag2)
				{
				}
				if (flag2 <= true)
				{
					goto IL_00E7;
				}
				if (flag2 > true)
				{
					if (flag2)
					{
						int[] array5 = this.damageLevel;
					}
					while (!flag2)
					{
					}
					int[] array6 = this.damageLevel;
				}
				if (flag2)
				{
					int[] array7 = this.damageLevel;
				}
				if (num == 0)
				{
					goto IL_00F1;
				}
				while (num == 0)
				{
				}
				if (num != 0)
				{
					while (num != 1)
					{
					}
					goto IL_00E7;
				}
				goto IL_00FE;
				IL_00F9:
				while (!flag2)
				{
				}
				goto IL_00FE;
				IL_0106:
				if (!flag2)
				{
					int[] array8 = this.damageLevel;
				}
				while (!flag2)
				{
				}
				goto IL_0118;
				IL_00FE:
				int[] array9 = this.damageLevel;
				goto IL_0106;
				IL_00F1:
				int[] array10 = this.damageLevel;
				goto IL_00F9;
				IL_00E7:
				if (flag2 <= true)
				{
					goto IL_0106;
				}
				if (flag2)
				{
					goto IL_00F1;
				}
				goto IL_00F9;
			}
			IL_0118:
			if (num2 == 0)
			{
				int num4 = 0;
				uint num5;
				num5.m_value = (uint)num4;
				num4++;
				num5 += (uint)8;
				bool flag3;
				if (flag3)
				{
					int num6 = 0;
					if (!(num != num6))
					{
						continue;
					}
					bool flag4;
					if (!flag4)
					{
					}
				}
				if (num4 == 0)
				{
					break;
				}
			}
		}
		int num7 = 0;
		int[] array11 = this.subLevel;
		Vector3 vector;
		if (num7 < vector.upVector)
		{
			uint num8;
			num8.m_value = vector;
			num7++;
			num8 += (uint)4;
			while (vector != 0)
			{
			}
		}
		int num9 = Enumerable.Min(array11);
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00013DE0 File Offset: 0x00011FE0
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x4F3AD0", Offset = "0x4F20D0", VA = "0x1804F3AD0")]
	private void Update()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		this.timer = num;
		Board board = this.board;
		this.timer = 30f;
		BoardConfig config = board.config;
		float zombieHealthMultiplier = config.zombieHealthMultiplier;
		config.zombieHealthMultiplier = zombieHealthMultiplier;
		this.CardUpdate();
		this.ObservalUpdate();
		this.ActionUpdate();
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00013E4C File Offset: 0x0001204C
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x4F26F0", Offset = "0x4F0CF0", VA = "0x1804F26F0")]
	private void ActionUpdate()
	{
		ulong num14;
		do
		{
			List<IZManager.AICard> list = this.cards;
			bool flag;
			if (flag)
			{
				if (Board.Instance.theSun <= typeof(Board).TypeHandle)
				{
					continue;
				}
				while (typeof(Board).TypeHandle > (ulong)5L)
				{
				}
				if (this.board.enermyCount <= 0)
				{
					continue;
				}
				uint num;
				while (num >= (uint)4)
				{
				}
				int num2 = this.targetRow;
				bool flag2;
				while (flag2)
				{
				}
				num += (uint)1;
				int num3 = 0;
				Board board = this.board;
				bool flag3;
				if (num3 < board.rowNum && !flag3)
				{
					num3++;
				}
				Board board2 = this.board;
				List<Plant> plantHead = this.board.boardEntity.plantHead;
				Func<Plant, bool> func;
				if (IZManager.<>c.<>9__16_0 == 0)
				{
					func = delegate(Plant p)
					{
						PlantType thePlantType = p.thePlantType;
						return (thePlantType > PlantType.DoubleShooter && (thePlantType == PlantType.GatlingPea || thePlantType == PlantType.SplitPea)) || thePlantType == PlantType.Peashooter || thePlantType == PlantType.DoubleShooter;
					};
					IZManager.<>c.<>9__16_0 = func;
				}
				Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, func);
				int num4 = 0;
				if (!(plant != num4))
				{
					continue;
				}
				int thePlantRow = plant.thePlantRow;
				int thePlantColumn = plant.thePlantColumn;
				if (this.board.enermyCount <= 0)
				{
					continue;
				}
				while (this.leftestZombie == (ulong)0L)
				{
				}
				Zombie[] array = this.leftestZombie;
				int num5 = this.targetRow;
				Zombie zombie = array[num5];
				int num6 = 0;
				if (!(zombie != num6))
				{
					continue;
				}
				Zombie[] array2 = this.leftestZombie;
				int num7 = this.targetRow;
				Zombie zombie2 = array2[num7];
				int column = zombie2.Column;
				int num8 = this.targetRow;
				if (this.board.enermyCount <= 0)
				{
					continue;
				}
				while (this.leftestZombie == (ulong)0L)
				{
				}
				Zombie[] array3 = this.leftestZombie;
				int num9 = this.targetRow;
				Zombie zombie3 = array3[num9];
				int num10 = 0;
				if (!(zombie3 != num10))
				{
					continue;
				}
				Zombie[] array4 = this.leftestZombie;
				int num11 = this.targetRow;
				int num12 = array4[num11].Column - 1;
				int num13 = this.targetRow;
			}
		}
		while (num14 != (ulong)0L);
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x000140A4 File Offset: 0x000122A4
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x4F2CE0", Offset = "0x4F12E0", VA = "0x1804F2CE0")]
	private void CardUpdate()
	{
		int num;
		do
		{
			List<IZManager.AICard> list = this.cards;
			num = 0;
			bool flag;
			if (flag)
			{
				float deltaTime = Time.deltaTime;
			}
		}
		while (num != 0);
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x000140E0 File Offset: 0x000122E0
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x4F3BB0", Offset = "0x4F21B0", VA = "0x1804F3BB0")]
	public IZManager()
	{
		List<IZManager.AICard> list = new List();
		this.cards = list;
		this.timer = 30f;
		List<PlantType> list2 = new List();
		int size = list2._size;
		int size2 = list2._size;
		int size3 = list2._size;
		int size4 = list2._size;
		int size5 = list2._size;
		int size6 = list2._size;
		this.avaliablePlants = list2;
		base..ctor();
	}

	// Token: 0x0400022C RID: 556
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400022C")]
	public Board board;

	// Token: 0x0400022D RID: 557
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400022D")]
	public List<IZManager.AICard> cards;

	// Token: 0x0400022E RID: 558
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400022E")]
	public int sunCount;

	// Token: 0x0400022F RID: 559
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400022F")]
	public int[] damageLevel;

	// Token: 0x04000230 RID: 560
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000230")]
	public int[] dangerLevel;

	// Token: 0x04000231 RID: 561
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000231")]
	public int[] subLevel;

	// Token: 0x04000232 RID: 562
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000232")]
	public Zombie[] leftestZombie;

	// Token: 0x04000233 RID: 563
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000233")]
	public int minValue;

	// Token: 0x04000234 RID: 564
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000234")]
	public int targetRow;

	// Token: 0x04000235 RID: 565
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000235")]
	private float timer;

	// Token: 0x04000236 RID: 566
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000236")]
	private readonly List<PlantType> avaliablePlants;

	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	[Serializable]
	public class AICard
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00014150 File Offset: 0x00012350
		[Token(Token = "0x1700008E")]
		public bool Avaliable
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x4EE9A0", Offset = "0x4ECFA0", VA = "0x1804EE9A0")]
			get
			{
				if (0 < (int)this.cd)
				{
				}
				Board instance = Board.Instance;
				int num = this.cost;
				return instance.theSun > num;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00014188 File Offset: 0x00012388
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x4EE820", Offset = "0x4ECE20", VA = "0x1804EE820")]
		public void Update()
		{
			float num = this.cd;
			float deltaTime = Time.deltaTime;
			this.cd = num;
			this.cd = 0f;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000141B8 File Offset: 0x000123B8
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x4EE860", Offset = "0x4ECE60", VA = "0x1804EE860")]
		public bool Use(int theColumn, int theRow)
		{
			CreatePlant instance = CreatePlant.Instance;
			int num = 0;
			Plant plant;
			bool flag = plant != num;
			if (!flag)
			{
				return flag;
			}
			float num2 = this.fullcd;
			this.cd = num2;
			Board.Instance.UseSun((float)num);
			throw new NullReferenceException();
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00014208 File Offset: 0x00012408
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public AICard()
		{
		}

		// Token: 0x04000237 RID: 567
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000237")]
		public PlantType thePlantType;

		// Token: 0x04000238 RID: 568
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000238")]
		public int cost;

		// Token: 0x04000239 RID: 569
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000239")]
		public float cd;

		// Token: 0x0400023A RID: 570
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400023A")]
		public float fullcd;
	}
}
