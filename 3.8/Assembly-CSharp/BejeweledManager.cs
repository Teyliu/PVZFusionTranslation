using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200008C RID: 140
[Token(Token = "0x200008C")]
public class BejeweledManager : MonoBehaviour
{
	// Token: 0x06000234 RID: 564 RVA: 0x000081B4 File Offset: 0x000063B4
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x39F780", Offset = "0x39DD80", VA = "0x18039F780")]
	private void Awake()
	{
		BejeweledManager.Instance = this;
		this.InitPlants();
	}

	// Token: 0x06000235 RID: 565 RVA: 0x000081D0 File Offset: 0x000063D0
	[Token(Token = "0x6000235")]
	[Address(RVA = "0x3A3860", Offset = "0x3A1E60", VA = "0x1803A3860")]
	private void Start()
	{
		int columnNum = this.board.columnNum;
		this.maxColumn = columnNum;
	}

	// Token: 0x06000236 RID: 566 RVA: 0x000081F8 File Offset: 0x000063F8
	[Token(Token = "0x6000236")]
	[Address(RVA = "0x3A4050", Offset = "0x3A2650", VA = "0x1803A4050")]
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

	// Token: 0x06000237 RID: 567 RVA: 0x00008244 File Offset: 0x00006444
	[Token(Token = "0x6000237")]
	[Address(RVA = "0x3A08D0", Offset = "0x39EED0", VA = "0x1803A08D0")]
	public void FillBankOptimized()
	{
		this.MoveRestPlantsInBejaw();
		this.SupplyPlantsInBejaw();
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00008260 File Offset: 0x00006460
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x3A1FE0", Offset = "0x3A05E0", VA = "0x1803A1FE0")]
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

	// Token: 0x06000239 RID: 569 RVA: 0x00008340 File Offset: 0x00006540
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x3A3890", Offset = "0x3A1E90", VA = "0x1803A3890")]
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

	// Token: 0x0600023A RID: 570 RVA: 0x00008450 File Offset: 0x00006650
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x3A1090", Offset = "0x39F690", VA = "0x1803A1090")]
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

	// Token: 0x0600023B RID: 571 RVA: 0x00008644 File Offset: 0x00006844
	[Token(Token = "0x600023B")]
	[Address(RVA = "0x39FC50", Offset = "0x39E250", VA = "0x18039FC50")]
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

	// Token: 0x0600023C RID: 572 RVA: 0x000087D4 File Offset: 0x000069D4
	[Token(Token = "0x600023C")]
	[Address(RVA = "0x3A2570", Offset = "0x3A0B70", VA = "0x1803A2570")]
	private void SetPlantFall(Plant plant)
	{
		Rigidbody2D rb = plant.rb;
		int num = 0;
		rb.bodyType = (RigidbodyType2D)num;
		plant.rb.gravityScale = (float)num;
		Rigidbody2D rb2 = plant.rb;
		int size = this.plantToFall._size;
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00008818 File Offset: 0x00006A18
	[Token(Token = "0x600023D")]
	[Address(RVA = "0x3A0630", Offset = "0x39EC30", VA = "0x1803A0630")]
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

	// Token: 0x0600023E RID: 574 RVA: 0x000088FC File Offset: 0x00006AFC
	[Token(Token = "0x600023E")]
	[Address(RVA = "0x3A1CE0", Offset = "0x3A02E0", VA = "0x1803A1CE0")]
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

	// Token: 0x0600023F RID: 575 RVA: 0x00008988 File Offset: 0x00006B88
	[Token(Token = "0x600023F")]
	[Address(RVA = "0x3A0CF0", Offset = "0x39F2F0", VA = "0x1803A0CF0")]
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

	// Token: 0x06000240 RID: 576 RVA: 0x00008AF4 File Offset: 0x00006CF4
	[Token(Token = "0x6000240")]
	[Address(RVA = "0x3A3E60", Offset = "0x3A2460", VA = "0x1803A3E60")]
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

	// Token: 0x06000241 RID: 577 RVA: 0x00008B88 File Offset: 0x00006D88
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x3A0580", Offset = "0x39EB80", VA = "0x1803A0580")]
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

	// Token: 0x06000242 RID: 578 RVA: 0x00008BBC File Offset: 0x00006DBC
	[Token(Token = "0x6000242")]
	[Address(RVA = "0x39FA20", Offset = "0x39E020", VA = "0x18039FA20")]
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

	// Token: 0x06000243 RID: 579 RVA: 0x00008C34 File Offset: 0x00006E34
	[Token(Token = "0x6000243")]
	[Address(RVA = "0x39FB70", Offset = "0x39E170", VA = "0x18039FB70")]
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

	// Token: 0x06000244 RID: 580 RVA: 0x00008C78 File Offset: 0x00006E78
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x39FAE0", Offset = "0x39E0E0", VA = "0x18039FAE0")]
	private bool CheckPlantMatch(Plant plant, bool tip)
	{
		List<Plant> bejeweledConnect = global::Lawnf.GetBejeweledConnect(plant);
		int num = 0;
		this.HeighLightPlant(num);
		return true;
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00008CA0 File Offset: 0x00006EA0
	[Token(Token = "0x6000245")]
	[Address(RVA = "0x39F7E0", Offset = "0x39DDE0", VA = "0x18039F7E0")]
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
			int num7 = 0;
			instance.ShowText("没有配对的植物了", 5f, num7 != 0);
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00008D68 File Offset: 0x00006F68
	[Token(Token = "0x6000246")]
	[Address(RVA = "0x3A2380", Offset = "0x3A0980", VA = "0x1803A2380")]
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

	// Token: 0x06000247 RID: 583 RVA: 0x00008D9C File Offset: 0x00006F9C
	[Token(Token = "0x6000247")]
	[Address(RVA = "0x3A24D0", Offset = "0x3A0AD0", VA = "0x1803A24D0")]
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

	// Token: 0x06000248 RID: 584 RVA: 0x00008DF0 File Offset: 0x00006FF0
	[Token(Token = "0x6000248")]
	[Address(RVA = "0x3A2AD0", Offset = "0x3A10D0", VA = "0x1803A2AD0")]
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

	// Token: 0x06000249 RID: 585 RVA: 0x00008E5C File Offset: 0x0000705C
	[Token(Token = "0x6000249")]
	[Address(RVA = "0x3A2680", Offset = "0x3A0C80", VA = "0x1803A2680")]
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

	// Token: 0x0600024A RID: 586 RVA: 0x00008F78 File Offset: 0x00007178
	[Token(Token = "0x600024A")]
	[Address(RVA = "0x3A0A30", Offset = "0x39F030", VA = "0x1803A0A30")]
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

	// Token: 0x0600024B RID: 587 RVA: 0x00008F9C File Offset: 0x0000719C
	[Token(Token = "0x600024B")]
	[Address(RVA = "0x3A0300", Offset = "0x39E900", VA = "0x1803A0300")]
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

	// Token: 0x0600024C RID: 588 RVA: 0x00009138 File Offset: 0x00007338
	[Token(Token = "0x600024C")]
	[Address(RVA = "0x3A08F0", Offset = "0x39EEF0", VA = "0x1803A08F0")]
	public PlantType GetBejeweledPlant()
	{
		List<PlantType> list = this.currentPlants;
		int num = list._size;
		num = global::UnityEngine.Random.Range(0, num);
		return list[num];
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00009168 File Offset: 0x00007368
	[Token(Token = "0x600024D")]
	[Address(RVA = "0x3A0960", Offset = "0x39EF60", VA = "0x1803A0960")]
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

	// Token: 0x0600024E RID: 590 RVA: 0x000091A8 File Offset: 0x000073A8
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x3A0B40", Offset = "0x39F140", VA = "0x1803A0B40")]
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

	// Token: 0x0600024F RID: 591 RVA: 0x00009200 File Offset: 0x00007400
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x3A2CB0", Offset = "0x3A12B0", VA = "0x1803A2CB0")]
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

	// Token: 0x06000250 RID: 592 RVA: 0x00009260 File Offset: 0x00007460
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x3A2FD0", Offset = "0x3A15D0", VA = "0x1803A2FD0")]
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

	// Token: 0x06000251 RID: 593 RVA: 0x000092C0 File Offset: 0x000074C0
	[Token(Token = "0x6000251")]
	[Address(RVA = "0x3A32F0", Offset = "0x3A18F0", VA = "0x1803A32F0")]
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

	// Token: 0x06000252 RID: 594 RVA: 0x00009300 File Offset: 0x00007500
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x3A3400", Offset = "0x3A1A00", VA = "0x1803A3400")]
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

	// Token: 0x06000253 RID: 595 RVA: 0x00009358 File Offset: 0x00007558
	[Token(Token = "0x6000253")]
	[Address(RVA = "0x3A34E0", Offset = "0x3A1AE0", VA = "0x1803A34E0")]
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
				float[] array;
				float num4 = array[0];
				Bullet bullet;
				bullet.Vx = num4;
				float num5 = array[1];
				bullet.Vy = num5;
				float num6 = array[1];
				bullet.detaVy = num6;
				int attackDamage = plant.attackDamage;
				bullet.Damage = attackDamage;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00009424 File Offset: 0x00007624
	[Token(Token = "0x6000254")]
	[Address(RVA = "0x3A4120", Offset = "0x3A2720", VA = "0x1803A4120")]
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

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	public static BejeweledManager Instance;

	// Token: 0x0400009C RID: 156
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009C")]
	public Board board;

	// Token: 0x0400009D RID: 157
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009D")]
	public Plant plantSelected;

	// Token: 0x0400009E RID: 158
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400009E")]
	public Vector2 firstPosition;

	// Token: 0x0400009F RID: 159
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400009F")]
	public float tipTime = 7.5f;

	// Token: 0x040000A0 RID: 160
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40000A0")]
	public float bejeweledTimer = 5f;

	// Token: 0x040000A1 RID: 161
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000A1")]
	public readonly List<PlantType> currentPlants;

	// Token: 0x040000A2 RID: 162
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000A2")]
	public List<Plant> plantToFall;

	// Token: 0x040000A3 RID: 163
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000A3")]
	public List<Plant> plantToMove;

	// Token: 0x040000A4 RID: 164
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000A4")]
	public List<Plant> plantToMatch;

	// Token: 0x040000A5 RID: 165
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000A5")]
	public HashSet<Plant> plantToClear;

	// Token: 0x040000A6 RID: 166
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000A6")]
	public int combo;

	// Token: 0x040000A7 RID: 167
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40000A7")]
	private bool fakeMoving;

	// Token: 0x040000A8 RID: 168
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000A8")]
	private readonly float moveSpeed;

	// Token: 0x040000A9 RID: 169
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40000A9")]
	private int maxColumn;

	// Token: 0x040000AA RID: 170
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000AA")]
	private readonly Dictionary<int, int> pitchDic;

	// Token: 0x040000AB RID: 171
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000AB")]
	public List<List<PlantType>> Upgrades;
}
