using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000091 RID: 145
[Token(Token = "0x2000091")]
public class BejeweledManager : MonoBehaviour
{
	// Token: 0x0600024F RID: 591 RVA: 0x00008598 File Offset: 0x00006798
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x3EB7B0", Offset = "0x3E9DB0", VA = "0x1803EB7B0")]
	private void Awake()
	{
		BejeweledManager.Instance = this;
		this.InitPlants();
	}

	// Token: 0x06000250 RID: 592 RVA: 0x000085B4 File Offset: 0x000067B4
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x3EF7F0", Offset = "0x3EDDF0", VA = "0x1803EF7F0")]
	private void Start()
	{
		int columnNum = this.board.columnNum;
		this.maxColumn = columnNum;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x000085DC File Offset: 0x000067DC
	[Token(Token = "0x6000251")]
	[Address(RVA = "0x3EFFE0", Offset = "0x3EE5E0", VA = "0x1803EFFE0")]
	private void Update()
	{
		this.BejeweledUpdate();
		List<Plant> list = this.plantToFall;
		List<Plant> list2 = this.plantToMove;
		if (!this.fakeMoving)
		{
			this.InputUpdate();
		}
		this.FallingPlantUpdate();
		this.MovePlantUpdate();
		this.MatchPlantUpdate();
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00008628 File Offset: 0x00006828
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x3EC910", Offset = "0x3EAF10", VA = "0x1803EC910")]
	public void FillBankOptimized()
	{
		this.MoveRestPlantsInBejaw();
		this.SupplyPlantsInBejaw();
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00008644 File Offset: 0x00006844
	[Token(Token = "0x6000253")]
	[Address(RVA = "0x3EE020", Offset = "0x3EC620", VA = "0x1803EE020")]
	private void MoveRestPlantsInBejaw()
	{
		int num = 0;
		if (this.maxColumn > num)
		{
			Plant[] array = new Plant[this.board.rowNum];
			bool[] array2 = new bool[this.board.rowNum];
			int num2 = 0;
			Board board = this.board;
			if (num2 < board.rowNum)
			{
				Plant plant = Enumerable.FirstOrDefault<Plant>(global::Lawnf.Get1x1Plants(num, num2));
				if (plant != 0)
				{
				}
				num2 += 4;
				array[0] = plant;
				bool flag = this.board.gridSystem.HasPit(num, num2);
				num2++;
				array2[0] = flag;
			}
			int num3 = array.Length;
			int num4 = array.Length - 1;
			num3 += 4;
			bool flag2;
			if (flag2 && num3 != num4)
			{
				num4 += 4;
			}
			int num5 = 0;
			if (num5 < array.Length)
			{
				bool flag3;
				if (flag3)
				{
				}
				num5++;
			}
			num++;
		}
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00008724 File Offset: 0x00006924
	[Token(Token = "0x6000254")]
	[Address(RVA = "0x3EF820", Offset = "0x3EDE20", VA = "0x1803EF820")]
	private void SupplyPlantsInBejaw()
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			if (num >= this.maxColumn)
			{
				return;
			}
			Board board = this.board;
			if (num < board.rowNum)
			{
				Plant plant = Enumerable.FirstOrDefault<Plant>(global::Lawnf.Get1x1Plants(num, num));
				int num3 = 0;
				if (!(plant != num3))
				{
					num++;
				}
				bool flag = this.plantToFall.Contains(plant);
			}
			List<Plant> list = new List();
			int rowNum = this.board.rowNum;
			if (!this.board.gridSystem.HasPit(num, rowNum))
			{
				Plant plant2 = Enumerable.FirstOrDefault<Plant>(global::Lawnf.Get1x1Plants(num, rowNum));
				int num4 = 0;
				if (plant2 == num4)
				{
					Plant plant3 = this.SetPlant(num, rowNum, (float)num2);
					int num5 = 0;
					Plant plant4;
					plant4.AdjustPositionY((float)num5);
				}
			}
			Func<Plant, float> func;
			if (BejeweledManager.<>c.<>9__20_0 == 0)
			{
				BejeweledManager.<>c.<>9__20_0 = func;
			}
			Transform axis = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderBy<Plant, float>(list, func)).axis;
			bool flag2;
			if (flag2)
			{
				Vector3 vector;
				float z = vector.z;
			}
		}
		while (num != 0);
		num++;
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00008834 File Offset: 0x00006A34
	[Token(Token = "0x6000255")]
	[Address(RVA = "0x3ED0D0", Offset = "0x3EB6D0", VA = "0x1803ED0D0")]
	private void MatchPlantUpdate()
	{
		int num4;
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			List<HashSet<Plant>> list = new List();
			HashSet<Plant> hashSet = new HashSet();
			int size = this.plantToMatch._size;
			Debug.LogError(string.Format("[BejeweledManager] plantToMatch数量异常: {0}，可能是死循环前兆", size));
			List<Plant> list2 = this.plantToMatch;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (num == num3 || hashSet.Contains(num))
				{
					continue;
				}
				Board board = this.board;
				bool flag3;
				if (hashSet < board.columnNum)
				{
					int rowNum = board.rowNum;
					List<Plant> bejeweledConnect = global::Lawnf.GetBejeweledConnect(num);
					int size2 = bejeweledConnect._size;
					Debug.LogWarning(string.Format("[BejeweledManager] 单次匹配植物数量异常: {0}，可能存在位置错误", bejeweledConnect));
					HashSet<Plant> hashSet2 = new HashSet(bejeweledConnect);
					bool flag2;
					if (flag2)
					{
						flag3 = hashSet.Add(num);
					}
					if (num2 != 0)
					{
						goto IL_01A8;
					}
				}
				Debug.LogError(string.Format("[BejeweledManager] 植物位置越界: ({0}, {1})", flag3, flag3));
			}
			if (num2 != 0)
			{
				goto IL_01C6;
			}
			num4 = 0;
			bool flag4;
			int i;
			if (flag4)
			{
				Plant plant = Enumerable.FirstOrDefault<Plant>(num);
				int num5 = 0;
				if (plant == num5)
				{
					continue;
				}
				bool flag5;
				if (flag5 && num == plant)
				{
					uint num6;
					GameAPP.PlaySound((int)num6, 0.3f, 1f);
					num4++;
				}
				if (num4 != 0)
				{
					goto IL_01CC;
				}
				i = 0;
				num += 2;
				num++;
				while (i >= num)
				{
				}
				CreateItem instance = CreateItem.Instance;
				i++;
			}
			if (num4 == 0)
			{
				int num7 = 0;
				int num8 = 0;
				Vector2 vector;
				ulong num9;
				if (global::Lawnf.SetAward(i, vector, num9 != 0UL, num8 != 0).horizontalSpeed <= 0f)
				{
					break;
				}
				bool flag6;
				if (flag6)
				{
				}
				if (num7 == 0)
				{
					break;
				}
			}
		}
		if (num4 > 0)
		{
			bool flag7;
			if (!flag7)
			{
			}
			float num11;
			float num10 = num11 * 0.5f;
			uint num12;
			GameAPP.PlaySound((int)num12, num10, num11);
		}
		return;
		IL_01A8:
		throw new NullReferenceException();
		IL_01C6:
		throw new NullReferenceException();
		IL_01CC:
		throw new NullReferenceException();
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00008A28 File Offset: 0x00006C28
	[Token(Token = "0x6000256")]
	[Address(RVA = "0x3EBC90", Offset = "0x3EA290", VA = "0x1803EBC90")]
	private void ClearPlant(Plant plant)
	{
		int num;
		int num2;
		for (;;)
		{
			num = 0;
			ParticleManager instance = ParticleManager.Instance;
			Transform axis = plant.axis;
			Vector3 vector;
			float z = vector.z;
			num2 = 0;
			int theLevel = plant.theLevel;
			if (theLevel == 1)
			{
				break;
			}
			while (theLevel != 3)
			{
			}
			int num3 = 0;
			Board board = this.board;
			List<Plant> plants = global::Lawnf.GetPlants(plant.thePlantType, board, num3 != 0);
			bool flag;
			if (flag)
			{
				bool flag2 = this.plantToClear.Add(num);
				BoardAction boardAction = this.board.boardAction;
				CreateItem instance2 = CreateItem.Instance;
			}
			if (num2 == 0)
			{
				goto Block_10;
			}
		}
		PlantType thePlantType = plant.thePlantType;
		int indexFromUpgrades = this.GetIndexFromUpgrades(thePlantType);
		if (indexFromUpgrades != 0)
		{
			if (indexFromUpgrades != 0)
			{
				if (indexFromUpgrades != 0)
				{
					if (indexFromUpgrades != 0)
					{
						if (indexFromUpgrades != 1)
						{
							goto IL_0098;
						}
						int num4 = 0;
						this.Skill_5(plant, num4 != 0);
					}
					BoardAction boardAction2 = this.board.boardAction;
				}
				int num5 = 0;
				this.Skill_3(plant, num5 != 0);
			}
			int num6 = 0;
			this.Skill_2(plant, num6 != 0);
		}
		int num7 = 0;
		this.Skill_1(plant, num7 != 0);
		IL_0098:
		int thePlantRow = plant.thePlantRow;
		List<Plant> plantsByRow = global::Lawnf.GetPlantsByRow(this.board, thePlantRow);
		bool flag3;
		if (flag3)
		{
			bool flag4 = this.plantToClear.Add(num);
			CreateItem instance3 = CreateItem.Instance;
		}
		if (num2 == 0)
		{
			return;
		}
		throw new NullReferenceException();
		Block_10:
		int num8;
		if (num8 != 0 && num8 != 0 && num8 != 0 && num8 != 0)
		{
			while (num8 != 1)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00008BB8 File Offset: 0x00006DB8
	[Token(Token = "0x6000257")]
	[Address(RVA = "0x3EE5B0", Offset = "0x3ECBB0", VA = "0x1803EE5B0")]
	private void SetPlantFall(Plant plant)
	{
		Rigidbody2D rb = plant.rb;
		int num = 0;
		rb.bodyType = (RigidbodyType2D)num;
		plant.rb.gravityScale = (float)num;
		Rigidbody2D rb2 = plant.rb;
		int size = this.plantToFall._size;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00008BFC File Offset: 0x00006DFC
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x3EC670", Offset = "0x3EAC70", VA = "0x1803EC670")]
	private void FallingPlantUpdate()
	{
		int size = this.plantToFall._size;
		int num = size - 1;
		if (size > 0)
		{
			Plant plant = this.plantToFall[num];
			int num2 = 0;
			if (!(plant == num2))
			{
				Board board = this.board;
				Transform axis = plant.axis;
				if (plant.rb.bodyType != RigidbodyType2D.Kinematic)
				{
					return;
				}
				Rigidbody2D rb = plant.rb;
				int num3 = 0;
				rb.bodyType = (RigidbodyType2D)num3;
				Rigidbody2D rb2 = plant.rb;
				plant.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
				plant.rb.bodyType = (RigidbodyType2D)((uint)1);
				Rigidbody2D rb3 = plant.rb;
				Vector2 vector;
				rb3.velocity = vector;
				this.plantToFall.RemoveAt(num);
				List<Plant> list = this.plantToMatch;
			}
			this.plantToFall.RemoveAt(num);
		}
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00008CE0 File Offset: 0x00006EE0
	[Token(Token = "0x6000259")]
	[Address(RVA = "0x3EDD20", Offset = "0x3EC320", VA = "0x1803EDD20")]
	private void MovePlantUpdate()
	{
		int size = this.plantToMove._size;
		int num = size - 1;
		if (size > 0)
		{
			Plant plant = this.plantToMove[num];
			int num2 = 0;
			if (!(plant == num2))
			{
				Board board = this.board;
				Transform axis = plant.axis;
				float deltaTime = Time.deltaTime;
				this.plantToMove.RemoveAt(num);
				List<Plant> list = this.plantToMatch;
			}
			this.plantToMove.RemoveAt(num);
		}
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00008D6C File Offset: 0x00006F6C
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x3ECD30", Offset = "0x3EB330", VA = "0x1803ECD30")]
	private void InputUpdate()
	{
		int num = 0;
		this.combo = (int)((ulong)0L);
		if (Input.GetMouseButtonDown(num))
		{
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			Vector3 vector;
			float z2 = vector.z;
			Mouse instance = Mouse.Instance;
			int theMouseRow = instance.theMouseRow;
			Plant plant = Enumerable.FirstOrDefault<Plant>(global::Lawnf.Get1x1Plants(instance.theMouseColumn, theMouseRow));
			this.plantSelected = plant;
		}
		if (Input.GetMouseButton(0))
		{
			Plant plant2 = this.plantSelected;
			int num2 = 0;
			if (plant2 != num2)
			{
				Camera main2 = Camera.main;
				float z3 = Input.mousePosition.z;
				Vector3 vector2;
				float z4 = vector2.z;
				int num3 = 0;
				float num4 = (float)(num3 * (int)57.29578f);
				if (!global::Core.Lawnf.ValueBetween(-45f, num4, 45f))
				{
					if (!global::Core.Lawnf.ValueBetween(45f, num4, 135f))
					{
						bool flag = global::Core.Lawnf.ValueBetween(-135f, num4, -45f);
						int num5 = this.plantSelected.thePlantRow;
						if (!flag)
						{
						}
						num5++;
					}
					Plant plant3 = this.plantSelected;
				}
				Plant plant4 = this.plantSelected;
				int thePlantRow = plant4.thePlantRow;
				int num6 = plant4.thePlantColumn;
				num6++;
				Board board = this.board;
				Plant plant5 = global::Lawnf.GetPlant(num6, thePlantRow, board);
				bool flag2 = this.TryExchangePlant(plant4, plant5);
				this.plantSelected = (ulong)0L;
			}
		}
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00008ED8 File Offset: 0x000070D8
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x3EFDF0", Offset = "0x3EE3F0", VA = "0x1803EFDF0")]
	private bool TryExchangePlant(Plant plant1, Plant plant2)
	{
		int num = 0;
		if (!(plant1 == num))
		{
			int num2 = 0;
			if (!(plant2 == num2))
			{
				this.ExchangePlant(plant1, plant2);
				List<Plant> bejeweledConnect = global::Lawnf.GetBejeweledConnect(plant1);
				List<Plant> bejeweledConnect2 = global::Lawnf.GetBejeweledConnect(plant2);
				int num3;
				BejeweledManager.<FakeExchange>d__29 <FakeExchange>d__ = new BejeweledManager.<FakeExchange>d__29(num3);
				num3 = 0;
				<FakeExchange>d__.<>4__this = this;
				<FakeExchange>d__.plant1 = plant1;
				<FakeExchange>d__.plant2 = plant2;
				Coroutine coroutine = base.StartCoroutine(<FakeExchange>d__);
				this.ExchangePlant(plant1, plant2);
				List<Plant> list = this.plantToMove;
				List<Plant> list2 = this.plantToMove;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00008F6C File Offset: 0x0000716C
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x3EC5C0", Offset = "0x3EABC0", VA = "0x1803EC5C0")]
	private IEnumerator FakeExchange(Plant plant1, Plant plant2)
	{
		int num;
		BejeweledManager.<FakeExchange>d__29 <FakeExchange>d__ = new BejeweledManager.<FakeExchange>d__29(num);
		num = 0;
		<FakeExchange>d__.<>4__this = this;
		<FakeExchange>d__.plant1 = plant1;
		<FakeExchange>d__.plant2 = plant2;
		throw new NullReferenceException();
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00008FA0 File Offset: 0x000071A0
	[Token(Token = "0x600025D")]
	[Address(RVA = "0x3EBA60", Offset = "0x3EA060", VA = "0x1803EBA60")]
	private bool CheckMatch(Plant plant, bool tip = false)
	{
		int num = plant.thePlantColumn;
		Board board = this.board;
		num++;
		int thePlantRow = plant.thePlantRow;
		Plant plant2 = global::Lawnf.GetPlant(num, thePlantRow, board);
		bool flag;
		if (!flag)
		{
			int num2 = plant.thePlantRow;
			Board board2 = this.board;
			num2++;
			Plant plant3 = global::Lawnf.GetPlant(plant.thePlantColumn, num2, board2);
			bool flag2 = this.CheckSwapMatch(plant, plant3, tip);
			if (!flag2)
			{
				return flag2;
			}
		}
		return true;
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00009018 File Offset: 0x00007218
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x3EBBB0", Offset = "0x3EA1B0", VA = "0x1803EBBB0")]
	private bool CheckSwapMatch(Plant plant1, Plant plant2, bool tip)
	{
		int num = 0;
		if (!(plant2 == num))
		{
			this.ExchangePlant(plant1, plant2);
			if (this.CheckPlantMatch(plant1, tip))
			{
			}
			bool flag = this.CheckPlantMatch(plant2, tip);
			this.ExchangePlant(plant1, plant2);
		}
		return false;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0000905C File Offset: 0x0000725C
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x3EBB20", Offset = "0x3EA120", VA = "0x1803EBB20")]
	private bool CheckPlantMatch(Plant plant, bool tip)
	{
		List<Plant> bejeweledConnect = global::Lawnf.GetBejeweledConnect(plant);
		int num = 0;
		this.HeighLightPlant(num);
		return true;
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00009084 File Offset: 0x00007284
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x3EB810", Offset = "0x3E9E10", VA = "0x1803EB810")]
	private void BejeweledUpdate()
	{
		ulong num5;
		do
		{
			int num = 0;
			float num2 = this.tipTime;
			float deltaTime = Time.deltaTime;
			this.tipTime = num2;
			float num3 = this.bejeweledTimer;
			float deltaTime2 = Time.deltaTime;
			this.bejeweledTimer = num3;
			int num4 = 0;
			int i = 0;
			if (i > (int)this.tipTime)
			{
				this.tipTime = 7.5f;
			}
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
				if (num4 == 0)
				{
					while (i <= (int)this.bejeweledTimer)
					{
					}
				}
				if (!this.CheckMatch(num, num4 != 0))
				{
					continue;
				}
			}
		}
		while (num5 != (ulong)0L);
		ulong num6;
		if (num6 == (ulong)0L)
		{
			InGameText instance = InGameText.Instance;
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00009134 File Offset: 0x00007334
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x3EE3C0", Offset = "0x3EC9C0", VA = "0x1803EE3C0")]
	public void RefrashBejeweldPlant()
	{
		ulong num;
		do
		{
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00009168 File Offset: 0x00007368
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x3EE510", Offset = "0x3ECB10", VA = "0x1803EE510")]
	public void SetBejeweledPlant()
	{
		int num = 0;
		if (this.maxColumn > num)
		{
			Board board = this.board;
			if (num < board.rowNum)
			{
				if (!board.gridSystem.HasPit(num, num))
				{
					Plant plant = this.SetPlantWithoutMatches(num, num, 10f);
				}
				num++;
			}
			num++;
		}
	}

	// Token: 0x06000263 RID: 611 RVA: 0x000091BC File Offset: 0x000073BC
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x3EEB10", Offset = "0x3ED110", VA = "0x1803EEB10")]
	private Plant SetPlant(int theColumn, int theRow, float offset = 10f)
	{
		CreatePlant instance = CreatePlant.Instance;
		List<PlantType> list = this.currentPlants;
		int num = list._size;
		num = global::UnityEngine.Random.Range(0, num);
		PlantType plantType = list[num];
		int num2 = 0;
		Plant plant;
		if (!(plant != num2))
		{
		}
		Transform transform = plant.transform;
		Vector3 vector;
		float z = vector.z;
		this.SetPlantFall(plant);
		throw new NullReferenceException();
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00009228 File Offset: 0x00007428
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x3EE6C0", Offset = "0x3ECCC0", VA = "0x1803EE6C0")]
	private Plant SetPlantWithoutMatches(int theColumn, int theRow, float offset = 10f)
	{
		Plant plant = Enumerable.FirstOrDefault<Plant>(global::Lawnf.Get1x1Plants(theColumn - 1, theColumn));
		List<Plant> list;
		Plant plant2 = Enumerable.FirstOrDefault<Plant>(list);
		int num = theRow - 1;
		Plant plant3 = Enumerable.FirstOrDefault<Plant>(global::Lawnf.Get1x1Plants(theColumn, num));
		List<Plant> list2;
		Plant plant4 = Enumerable.FirstOrDefault<Plant>(list2);
		List<PlantType> list3 = new List(this.currentPlants);
		int num2 = 0;
		if (plant != num2)
		{
			int num3 = 0;
			if (plant2 != num3)
			{
				PlantType thePlantType = plant2.thePlantType;
				if (plant.thePlantType == thePlantType)
				{
				}
			}
		}
		int num4 = 0;
		if (plant3 != num4)
		{
			int num5 = 0;
			if (plant4 != num5)
			{
				PlantType thePlantType2 = plant4.thePlantType;
				if (plant3.thePlantType == thePlantType2)
				{
				}
			}
		}
		List<PlantType> list5;
		List<PlantType> list4 = Enumerable.ToList<PlantType>(Enumerable.Except<PlantType>(list3, list5));
		int num6 = 0;
		PlantType bejeweledPlant = this.GetBejeweledPlant();
		int num7 = global::UnityEngine.Random.Range(0, num6);
		PlantType plantType = list4[num7];
		CreatePlant instance = CreatePlant.Instance;
		int num8 = 0;
		Plant plant5;
		if (!(plant5 != num8))
		{
		}
		Transform transform = plant5.transform;
		Vector3 vector;
		float z = vector.z;
		this.SetPlantFall(plant5);
		throw new NullReferenceException();
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00009344 File Offset: 0x00007544
	[Token(Token = "0x6000265")]
	[Address(RVA = "0x3ECA70", Offset = "0x3EB070", VA = "0x1803ECA70")]
	private void HeighLightPlant(List<Plant> plants)
	{
		ulong num;
		do
		{
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00009368 File Offset: 0x00007568
	[Token(Token = "0x6000266")]
	[Address(RVA = "0x3EC340", Offset = "0x3EA940", VA = "0x1803EC340")]
	private void ExchangePlant(Plant plant1, Plant plant2)
	{
		int num = 0;
		if (!(plant1 == num))
		{
			int num2 = 0;
			if (!(plant2 == num2))
			{
				GridSystem gridSystem = this.board.gridSystem;
				int thePlantRow = plant1.thePlantRow;
				int thePlantColumn = plant1.thePlantColumn;
				gridSystem.RemovePlant(plant1, thePlantColumn, thePlantRow);
				GridSystem gridSystem2 = this.board.gridSystem;
				int thePlantRow2 = plant2.thePlantRow;
				int thePlantColumn2 = plant2.thePlantColumn;
				gridSystem2.RemovePlant(plant2, thePlantColumn2, thePlantRow2);
				GridSystem gridSystem3 = this.board.gridSystem;
				int thePlantRow3 = plant1.thePlantRow;
				int thePlantColumn3 = plant1.thePlantColumn;
				gridSystem3.AddPlant(plant2, thePlantColumn3, thePlantRow3);
				GridSystem gridSystem4 = this.board.gridSystem;
				int thePlantRow4 = plant2.thePlantRow;
				int thePlantColumn4 = plant2.thePlantColumn;
				gridSystem4.AddPlant(plant1, thePlantColumn4, thePlantRow4);
				SortingGroup sortingGroup = plant1.sortingGroup;
				int thePlantColumn5 = plant1.thePlantColumn;
				int thePlantRow5 = plant1.thePlantRow;
				int sortingOrder = sortingGroup.sortingOrder;
				int sortingLayerID = plant1.sortingGroup.sortingLayerID;
				int thePlantColumn6 = plant2.thePlantColumn;
				SortingGroup sortingGroup2 = plant1.sortingGroup;
				plant1.thePlantColumn = thePlantColumn6;
				int thePlantRow6 = plant2.thePlantRow;
				plant1.thePlantRow = thePlantRow6;
				int sortingOrder2 = plant2.sortingGroup.sortingOrder;
				sortingGroup2.sortingOrder = sortingOrder2;
				SortingGroup sortingGroup3 = plant2.sortingGroup;
				SortingGroup sortingGroup4 = plant1.sortingGroup;
				int num3 = sortingGroup3.sortingLayerID;
				sortingGroup4.sortingLayerID = num3;
				SortingGroup sortingGroup5 = plant2.sortingGroup;
				plant2.thePlantColumn = thePlantColumn5;
				plant2.thePlantRow = thePlantRow5;
				num3 = sortingOrder;
				sortingGroup5.sortingOrder = num3;
				SortingGroup sortingGroup6 = plant2.sortingGroup;
				num3 = sortingLayerID;
				sortingGroup6.sortingLayerID = num3;
			}
		}
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00009504 File Offset: 0x00007704
	[Token(Token = "0x6000267")]
	[Address(RVA = "0x3EC930", Offset = "0x3EAF30", VA = "0x1803EC930")]
	public PlantType GetBejeweledPlant()
	{
		List<PlantType> list = this.currentPlants;
		int num = list._size;
		num = global::UnityEngine.Random.Range(0, num);
		return list[num];
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00009534 File Offset: 0x00007734
	[Token(Token = "0x6000268")]
	[Address(RVA = "0x3EC9A0", Offset = "0x3EAFA0", VA = "0x1803EC9A0")]
	private int GetIndexFromUpgrades(PlantType thePlantType)
	{
		List<List<PlantType>> upgrades = this.Upgrades;
		int num = 0;
		List<PlantType> list = this.Upgrades[num];
		bool flag;
		if (!flag)
		{
			List<List<PlantType>> upgrades2 = this.Upgrades;
			num++;
		}
		return num;
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00009574 File Offset: 0x00007774
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x3ECB80", Offset = "0x3EB180", VA = "0x1803ECB80")]
	private void InitPlants()
	{
		ulong num;
		do
		{
			List<List<PlantType>> upgrades = this.Upgrades;
			bool flag;
			if (flag)
			{
				List<PlantType> list = this.currentPlants;
				int size = list._size;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x0600026A RID: 618 RVA: 0x000095CC File Offset: 0x000077CC
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x3EECF0", Offset = "0x3ED2F0", VA = "0x1803EECF0")]
	private void Skill_1(Plant plant, bool upgraded)
	{
		Transform axis = plant.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		CreateBullet instance = CreateBullet.Instance;
		if (!upgraded)
		{
			Bullet bullet;
			Transform transform = bullet.transform;
		}
		Bullet bullet2;
		Transform transform2 = bullet2.transform;
		int attackDamage = plant.attackDamage;
		bullet2.Damage = attackDamage;
		num += 10;
		num++;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x0000962C File Offset: 0x0000782C
	[Token(Token = "0x600026B")]
	[Address(RVA = "0x3EF010", Offset = "0x3ED610", VA = "0x1803EF010")]
	private void Skill_2(Plant plant, bool upgraded)
	{
		Transform axis = plant.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		CreateBullet instance = CreateBullet.Instance;
		if (!upgraded)
		{
			Bullet bullet;
			Transform transform = bullet.transform;
		}
		Bullet bullet2;
		Transform transform2 = bullet2.transform;
		int attackDamage = plant.attackDamage;
		bullet2.Damage = attackDamage;
		num += 10;
		num++;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0000968C File Offset: 0x0000788C
	[Token(Token = "0x600026C")]
	[Address(RVA = "0x3EF330", Offset = "0x3ED930", VA = "0x1803EF330")]
	private void Skill_3(Plant plant, bool upgraded)
	{
		if (!upgraded)
		{
			GameObject[] itemPrefab = GameAPP.itemPrefab;
		}
		GameObject gameObject = GameAPP.itemPrefab[11];
		Transform transform = this.board.transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
	}

	// Token: 0x0600026D RID: 621 RVA: 0x000096CC File Offset: 0x000078CC
	[Token(Token = "0x600026D")]
	[Address(RVA = "0x3EF440", Offset = "0x3EDA40", VA = "0x1803EF440")]
	private void Skill_4(Plant plant, bool upgraded)
	{
		Board board = this.board;
		if (!upgraded)
		{
			BoardAction boardAction = board.boardAction;
			return;
		}
		int i = 0;
		while (i >= board.rowNum)
		{
		}
		BoardAction boardAction2 = this.board.boardAction;
		Board board2 = this.board;
		i++;
		while (board2 != 0)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00009724 File Offset: 0x00007924
	[Token(Token = "0x600026E")]
	[Address(RVA = "0x3EF520", Offset = "0x3EDB20", VA = "0x1803EF520")]
	private void Skill_5(Plant plant, bool upgraded)
	{
		int num2;
		do
		{
			int num = 0;
			Transform shoot = plant.shoot;
			List<Zombie> zombieArray = this.board.zombieArray;
			num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !global::Lawnf.InLandStatus((ZombieStatus)num))
				{
					continue;
				}
				CreateBullet instance = CreateBullet.Instance;
				int attackDamage = plant.attackDamage;
				Bullet bullet;
				bullet.Damage = attackDamage;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0000979C File Offset: 0x0000799C
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x3F00B0", Offset = "0x3EE6B0", VA = "0x1803F00B0")]
	public BejeweledManager()
	{
		List<PlantType> list = new List();
		this.currentPlants = list;
		List<Plant> list2 = new List();
		this.plantToFall = list2;
		List<Plant> list3 = new List();
		this.plantToMove = list3;
		List<Plant> list4 = new List();
		this.plantToMatch = list4;
		HashSet<Plant> hashSet = new HashSet();
		this.plantToClear = hashSet;
		this.moveSpeed = 6f;
		Dictionary<int, int> dictionary = new Dictionary();
		int num = 0;
		uint num2;
		dictionary.Add(num2, num);
		uint num3;
		dictionary.Add(num3, num3);
		uint num4;
		uint num5;
		dictionary.Add(num4, num5);
		uint num6;
		uint num7;
		dictionary.Add(num6, num7);
		uint num8;
		uint num9;
		dictionary.Add(num8, num9);
		uint num10;
		uint num11;
		dictionary.Add(num10, num11);
		uint num12;
		uint num13;
		dictionary.Add(num12, num13);
		uint num14;
		uint num15;
		dictionary.Add(num14, num15);
		this.pitchDic = dictionary;
		List<List<PlantType>> list5 = new List();
		List<PlantType> list6 = new List();
		int size = list6._size;
		int size2 = list6._size;
		int size3 = list6._size;
		int size4 = list6._size;
		int size5 = list5._size;
		list6._syncRoot = list6;
		List<PlantType> list7 = new List();
		int size6 = list7._size;
		int size7 = list7._size;
		int size8 = list7._size;
		int size9 = list7._size;
		int size10 = list5._size;
		list7._syncRoot = list7;
		List<PlantType> list8 = new List();
		int size11 = list8._size;
		int size12 = list8._size;
		int size13 = list8._size;
		int size14 = list5._size;
		list8._syncRoot = list8;
		List<PlantType> list9 = new List();
		int size15 = list9._size;
		int size16 = list9._size;
		int size17 = list5._size;
		list9._syncRoot = list9;
		this.Upgrades = list5;
		base..ctor();
	}

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	public static BejeweledManager Instance;

	// Token: 0x040000A9 RID: 169
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A9")]
	public Board board;

	// Token: 0x040000AA RID: 170
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000AA")]
	public Plant plantSelected;

	// Token: 0x040000AB RID: 171
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000AB")]
	public Vector2 firstPosition;

	// Token: 0x040000AC RID: 172
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000AC")]
	public float tipTime = 7.5f;

	// Token: 0x040000AD RID: 173
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000AD")]
	public float bejeweledTimer = 5f;

	// Token: 0x040000AE RID: 174
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000AE")]
	public readonly List<PlantType> currentPlants;

	// Token: 0x040000AF RID: 175
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000AF")]
	public List<Plant> plantToFall;

	// Token: 0x040000B0 RID: 176
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000B0")]
	public List<Plant> plantToMove;

	// Token: 0x040000B1 RID: 177
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000B1")]
	public List<Plant> plantToMatch;

	// Token: 0x040000B2 RID: 178
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000B2")]
	public HashSet<Plant> plantToClear;

	// Token: 0x040000B3 RID: 179
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000B3")]
	public int combo;

	// Token: 0x040000B4 RID: 180
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40000B4")]
	private bool fakeMoving;

	// Token: 0x040000B5 RID: 181
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000B5")]
	private readonly float moveSpeed;

	// Token: 0x040000B6 RID: 182
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40000B6")]
	private int maxColumn;

	// Token: 0x040000B7 RID: 183
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000B7")]
	private readonly Dictionary<int, int> pitchDic;

	// Token: 0x040000B8 RID: 184
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000B8")]
	public List<List<PlantType>> Upgrades;
}
