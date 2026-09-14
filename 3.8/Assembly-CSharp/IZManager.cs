using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using GameLevel;
using UnityEngine;

// Token: 0x020000D3 RID: 211
[Token(Token = "0x20000D3")]
public class IZManager : MonoBehaviour
{
	// Token: 0x060003EA RID: 1002 RVA: 0x00013660 File Offset: 0x00011860
	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x4B35C0", Offset = "0x4B1BC0", VA = "0x1804B35C0")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		this.InitCards();
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00013680 File Offset: 0x00011880
	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x4B42E0", Offset = "0x4B28E0", VA = "0x1804B42E0")]
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

	// Token: 0x060003EC RID: 1004 RVA: 0x0001372C File Offset: 0x0001192C
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x4B39C0", Offset = "0x4B1FC0", VA = "0x1804B39C0")]
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

	// Token: 0x060003ED RID: 1005 RVA: 0x000137C0 File Offset: 0x000119C0
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x4B3780", Offset = "0x4B1D80", VA = "0x1804B3780")]
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

	// Token: 0x060003EE RID: 1006 RVA: 0x0001385C File Offset: 0x00011A5C
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x4B3AA0", Offset = "0x4B20A0", VA = "0x1804B3AA0")]
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

	// Token: 0x060003EF RID: 1007 RVA: 0x00013A54 File Offset: 0x00011C54
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x4B4410", Offset = "0x4B2A10", VA = "0x1804B4410")]
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

	// Token: 0x060003F0 RID: 1008 RVA: 0x00013AC0 File Offset: 0x00011CC0
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x4B3030", Offset = "0x4B1630", VA = "0x1804B3030")]
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

	// Token: 0x060003F1 RID: 1009 RVA: 0x00013D04 File Offset: 0x00011F04
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x4B3620", Offset = "0x4B1C20", VA = "0x1804B3620")]
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

	// Token: 0x060003F2 RID: 1010 RVA: 0x00013D40 File Offset: 0x00011F40
	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x4B44F0", Offset = "0x4B2AF0", VA = "0x1804B44F0")]
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

	// Token: 0x0400021F RID: 543
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400021F")]
	public Board board;

	// Token: 0x04000220 RID: 544
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000220")]
	public List<IZManager.AICard> cards;

	// Token: 0x04000221 RID: 545
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000221")]
	public int sunCount;

	// Token: 0x04000222 RID: 546
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000222")]
	public int[] damageLevel;

	// Token: 0x04000223 RID: 547
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000223")]
	public int[] dangerLevel;

	// Token: 0x04000224 RID: 548
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000224")]
	public int[] subLevel;

	// Token: 0x04000225 RID: 549
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000225")]
	public Zombie[] leftestZombie;

	// Token: 0x04000226 RID: 550
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000226")]
	public int minValue;

	// Token: 0x04000227 RID: 551
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000227")]
	public int targetRow;

	// Token: 0x04000228 RID: 552
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000228")]
	private float timer;

	// Token: 0x04000229 RID: 553
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000229")]
	private readonly List<PlantType> avaliablePlants;

	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[Serializable]
	public class AICard
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00013DB0 File Offset: 0x00011FB0
		[Token(Token = "0x17000051")]
		public bool Avaliable
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x4AF310", Offset = "0x4AD910", VA = "0x1804AF310")]
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

		// Token: 0x060003F4 RID: 1012 RVA: 0x00013DE8 File Offset: 0x00011FE8
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x4AF190", Offset = "0x4AD790", VA = "0x1804AF190")]
		public void Update()
		{
			float num = this.cd;
			float deltaTime = Time.deltaTime;
			this.cd = num;
			this.cd = 0f;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00013E18 File Offset: 0x00012018
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x4AF1D0", Offset = "0x4AD7D0", VA = "0x1804AF1D0")]
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

		// Token: 0x060003F6 RID: 1014 RVA: 0x00013E68 File Offset: 0x00012068
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public AICard()
		{
		}

		// Token: 0x0400022A RID: 554
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400022A")]
		public PlantType thePlantType;

		// Token: 0x0400022B RID: 555
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400022B")]
		public int cost;

		// Token: 0x0400022C RID: 556
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400022C")]
		public float cd;

		// Token: 0x0400022D RID: 557
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400022D")]
		public float fullcd;
	}
}
