using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007F0 RID: 2032
[Token(Token = "0x20007F0")]
public class SaveMgr : MonoBehaviour
{
	// Token: 0x06002925 RID: 10533 RVA: 0x000DE244 File Offset: 0x000DC444
	[Token(Token = "0x6002925")]
	[Address(RVA = "0x66F2B0", Offset = "0x66D8B0", VA = "0x18066F2B0")]
	public static SurvivalData SaveBoard(int level, int id = -1, string name = "新的存档")
	{
		Board instance = Board.Instance;
		SaveBoardData saveBoardData = new SaveBoardData();
		saveBoardData.isBoardSaved = true;
		int theSun = instance.theSun;
		saveBoardData.theBoardSun = theSun;
		BoardStatistics boardStatistics = instance.boardStatistics;
		saveBoardData.boardStatistics = boardStatistics;
		int theMoney = instance.theMoney;
		saveBoardData.theBoardMoney = theMoney;
		float thePoints = instance.thePoints;
		saveBoardData.theBoardPoints = thePoints;
		int theCurrentSurvivalRound = instance.theCurrentSurvivalRound;
		saveBoardData.theCurrentSurvivalRound = theCurrentSurvivalRound;
		SceneType sceneType = instance.sceneType;
		saveBoardData.sceneType = sceneType;
		List<JigSawData> jigSawDatas = instance.jigSawDatas;
		saveBoardData.jigSawDatas = jigSawDatas;
		SaveMgr.boardData = saveBoardData;
		SaveBoardData saveBoardData2 = SaveMgr.boardData;
		string dataPath = SaveInfo.GetDataPath();
		string text = string.Format("level{0}.json", dataPath);
		string text2 = Path.Combine(dataPath, text);
		if (!File.Exists(text2))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(text2));
		}
		int num = JsonUtility.FromJson<SurvivalData>(File.ReadAllText(text2)).boardData.theEndlessSurvivalMaxRound;
		int theCurrentSurvivalRound2 = SaveMgr.boardData.theCurrentSurvivalRound;
		if (num <= theCurrentSurvivalRound2)
		{
			num = theCurrentSurvivalRound2;
		}
		saveBoardData2.theEndlessSurvivalMaxRound = num;
		SaveMgr.SavePlants();
		SaveInfo instance2 = SaveInfo.Instance;
		int num2 = 0;
		return instance2.SaveSurvivalData(level, num2 != 0, id, name);
	}

	// Token: 0x06002926 RID: 10534 RVA: 0x000DE37C File Offset: 0x000DC57C
	[Token(Token = "0x6002926")]
	[Address(RVA = "0x66DCA0", Offset = "0x66C2A0", VA = "0x18066DCA0")]
	public static void LoadBoard(int level, int id = -1)
	{
		SurvivalData survivalData = SaveInfo.Instance.GetSurvivalData(id, id);
		Board instance = Board.Instance;
		if (survivalData != 0)
		{
			int theBoardSun = survivalData.boardData.theBoardSun;
			instance.theSun = theBoardSun;
			int theBoardMoney = survivalData.boardData.theBoardMoney;
			instance.theMoney = theBoardMoney;
			SaveBoardData saveBoardData = survivalData.boardData;
			if (saveBoardData.boardStatistics != (ulong)0L)
			{
				BoardStatistics boardStatistics = saveBoardData.boardStatistics;
				instance.boardStatistics = boardStatistics;
				instance.boardStatistics.Repair(instance);
			}
			float theBoardPoints = survivalData.boardData.theBoardPoints;
			instance.thePoints = theBoardPoints;
			int theCurrentSurvivalRound = survivalData.boardData.theCurrentSurvivalRound;
			instance.theCurrentSurvivalRound = theCurrentSurvivalRound;
			SaveBoardData saveBoardData2 = survivalData.boardData;
			if (saveBoardData2.jigSawDatas != (ulong)0L)
			{
				List<JigSawData> jigSawDatas = saveBoardData2.jigSawDatas;
				instance.jigSawDatas = jigSawDatas;
				instance.GetJigsawFromList();
			}
			if (Lawnf.WithTravelBuff((LevelType)((uint)3), level))
			{
				SaveMgr.LoadTravelData(survivalData);
			}
			SaveMgr.LoadPlant(survivalData);
		}
	}

	// Token: 0x06002927 RID: 10535 RVA: 0x000DE470 File Offset: 0x000DC670
	[Token(Token = "0x6002927")]
	[Address(RVA = "0x66DB40", Offset = "0x66C140", VA = "0x18066DB40")]
	public static void ClearBoard(int level)
	{
		uint num;
		SurvivalData survivalData = SaveInfo.Instance.GetSurvivalData(level, (int)num);
		int num2 = 0;
		if (survivalData != 0)
		{
			SaveBoardData saveBoardData = survivalData.boardData;
		}
		SaveMgr.boardData = new SaveBoardData
		{
			isBoardSaved = false,
			theEndlessSurvivalMaxRound = num2
		};
		ulong num3;
		uint num4;
		string text;
		SurvivalData survivalData2 = SaveInfo.Instance.SaveSurvivalData(level, num3 != 0UL, (int)num4, text);
	}

	// Token: 0x06002928 RID: 10536 RVA: 0x000DE4D0 File Offset: 0x000DC6D0
	[Token(Token = "0x6002928")]
	[Address(RVA = "0x66F010", Offset = "0x66D610", VA = "0x18066F010")]
	private static void LoadTravelData(SurvivalData survivalData)
	{
		if (survivalData.travelData != (ulong)0L)
		{
			TravelMgr instance = TravelMgr.Instance;
			TravelData travelData = survivalData.travelData;
			instance.data = travelData;
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4000)))
		{
			PetData petData = survivalData.petData;
			int num = 0;
			Board instance2 = Board.Instance;
			MiniPet miniPet = petData.LoadPet(instance2, (PetType)num);
			return;
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4001)))
		{
			PetData petData2 = survivalData.petData;
			Board instance3 = Board.Instance;
			MiniPet miniPet2 = petData2.LoadPet(instance3, (PetType)((uint)1));
			return;
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4002)))
		{
			PetData petData3 = survivalData.petData;
			Board instance4 = Board.Instance;
			MiniPet miniPet3 = petData3.LoadPet(instance4, (PetType)((uint)2));
			return;
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4003)))
		{
			PetData petData4 = survivalData.petData;
			Board instance5 = Board.Instance;
			MiniPet miniPet4 = petData4.LoadPet(instance5, (PetType)((uint)3));
			return;
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4004)))
		{
			PetData petData5 = survivalData.petData;
			Board instance6 = Board.Instance;
			MiniPet miniPet5 = petData5.LoadPet(instance6, (PetType)((uint)4));
			return;
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4005)))
		{
			PetData petData6 = survivalData.petData;
			Board instance7 = Board.Instance;
			MiniPet miniPet6 = petData6.LoadPet(instance7, (PetType)((uint)5));
			return;
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4006)))
		{
			PetData petData7 = survivalData.petData;
			Board instance8 = Board.Instance;
			MiniPet miniPet7 = petData7.LoadPet(instance8, (PetType)((uint)6));
			return;
		}
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4007)))
		{
			PetData petData8 = survivalData.petData;
			Board instance9 = Board.Instance;
			MiniPet miniPet8 = petData8.LoadPet(instance9, (PetType)((uint)7));
			return;
		}
	}

	// Token: 0x06002929 RID: 10537 RVA: 0x000DE66C File Offset: 0x000DC86C
	[Token(Token = "0x6002929")]
	[Address(RVA = "0x66F5C0", Offset = "0x66DBC0", VA = "0x18066F5C0")]
	private static void SavePlants()
	{
		int num2;
		do
		{
			int num = 0;
			List<SavePlantData> list = SaveMgr.savePlantData;
			int size = list._size;
			num2 = 0;
			list._size = num2;
			if (size > 0)
			{
			}
			List<Plant> plantArray = Board.Instance.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				SavePlantData savePlantData = new SavePlantData(num);
				List<SavePlantData> list2 = SaveMgr.savePlantData;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x0600292A RID: 10538 RVA: 0x000DE6E4 File Offset: 0x000DC8E4
	[Token(Token = "0x600292A")]
	[Address(RVA = "0x66E3D0", Offset = "0x66C9D0", VA = "0x18066E3D0")]
	public static void LoadPlant(SurvivalData survivalData)
	{
		int num2;
		do
		{
			int num = 0;
			SaveMgr.LoadLily(survivalData);
			SaveMgr.LoadPot(survivalData);
			List<SavePlantData> plants = survivalData.plants;
			num2 = 0;
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				GridSystem gridSystem = Board.Instance.gridSystem;
				BoardGrid boardGrid;
				BoxType boxType = boardGrid.boxType;
				int num4;
				if (boxType != BoxType.Roof)
				{
					int num3;
					if (boxType != BoxType.Water)
					{
						num3 = 0;
					}
					CreatePlant instance = CreatePlant.Instance;
					num4 = 0;
					if (instance.OnHardLand((PlantType)num3))
					{
						continue;
					}
				}
				bool flag2;
				while (flag2)
				{
				}
				bool flag3;
				while (flag3)
				{
				}
				bool flag4;
				while (flag4)
				{
				}
				int num5 = 0;
				bool flag5;
				while (flag5)
				{
				}
				bool flag6;
				int num6;
				if (!Board.Instance.gridSystem.HasLily(num5, num4) && !flag6 && boxType == BoxType.Water)
				{
					CreatePlant instance2 = CreatePlant.Instance;
					num6 = 0;
					bool flag7;
					if (flag7)
					{
						CreatePlant instance3 = CreatePlant.Instance;
					}
				}
				if (!Board.Instance.gridSystem.HasPot(num6, num4) && boxType == BoxType.Roof)
				{
					CreatePlant instance4 = CreatePlant.Instance;
					bool flag8;
					if (flag8)
					{
						CreatePlant instance5 = CreatePlant.Instance;
					}
				}
				CreatePlant instance6 = CreatePlant.Instance;
				int num7 = 0;
				Plant plant;
				if (!(plant != num7))
				{
					continue;
				}
			}
		}
		while (num2 != 0);
	}

	// Token: 0x0600292B RID: 10539 RVA: 0x000DE844 File Offset: 0x000DCA44
	[Token(Token = "0x600292B")]
	[Address(RVA = "0x66DE70", Offset = "0x66C470", VA = "0x18066DE70")]
	public static void LoadLily(SurvivalData survivalData)
	{
		int num4;
		do
		{
			int num = 0;
			List<SavePlantData> list = new List(survivalData.plants);
			Predicate<SavePlantData> <>9__8_ = SaveMgr.<>c.<>9__8_0;
			if (<>9__8_ == 0)
			{
				Predicate<SavePlantData> predicate;
				SaveMgr.<>c.<>9__8_0 = predicate;
			}
			int num2 = list.RemoveAll(<>9__8_);
			int num3 = 0;
			bool flag;
			if (flag)
			{
				GridSystem gridSystem = Board.Instance.gridSystem;
				BoardGrid boardGrid;
				while (boardGrid.boxType != BoxType.Water)
				{
				}
				CreatePlant instance = CreatePlant.Instance;
			}
			if (num3 != 0)
			{
				goto IL_00D7;
			}
			num4 = 0;
			bool flag2;
			if (flag2)
			{
				while (num == 0)
				{
				}
				bool flag3;
				while (!flag3)
				{
				}
				GridSystem gridSystem2 = Board.Instance.gridSystem;
				BoardGrid boardGrid2;
				while (boardGrid2.boxType != BoxType.Water)
				{
				}
				CreatePlant instance2 = CreatePlant.Instance;
				int num5 = 0;
				Plant plant;
				bool flag4 = plant != num5;
				while (!flag4)
				{
				}
				plant.thePlantHealth = (flag4 ? 1 : 0);
				plant.theLilyType = (flag4 ? PlantType.SunFlower : PlantType.Peashooter);
			}
		}
		while (num4 != 0);
		return;
		IL_00D7:
		throw new NullReferenceException();
	}

	// Token: 0x0600292C RID: 10540 RVA: 0x000DE948 File Offset: 0x000DCB48
	[Token(Token = "0x600292C")]
	[Address(RVA = "0x66EAB0", Offset = "0x66D0B0", VA = "0x18066EAB0")]
	public static void LoadPot(SurvivalData survivalData)
	{
		int num4;
		do
		{
			int num = 0;
			List<SavePlantData> list = new List(survivalData.plants);
			Predicate<SavePlantData> <>9__9_ = SaveMgr.<>c.<>9__9_0;
			if (<>9__9_ == 0)
			{
				Predicate<SavePlantData> predicate;
				SaveMgr.<>c.<>9__9_0 = predicate;
			}
			int num2 = list.RemoveAll(<>9__9_);
			int num3 = 0;
			bool flag;
			if (flag)
			{
				GridSystem gridSystem = Board.Instance.gridSystem;
				BoardGrid boardGrid;
				while (boardGrid.boxType == BoxType.Water)
				{
				}
				CreatePlant instance = CreatePlant.Instance;
			}
			if (num3 != 0)
			{
				goto IL_00CE;
			}
			num4 = 0;
			bool flag2;
			if (flag2)
			{
				while (num == 0)
				{
				}
				bool flag3;
				while (!flag3)
				{
				}
				GridSystem gridSystem2 = Board.Instance.gridSystem;
				BoardGrid boardGrid2;
				while (boardGrid2.boxType == BoxType.Water)
				{
				}
				CreatePlant instance2 = CreatePlant.Instance;
				int num5 = 0;
				Plant plant;
				bool flag4 = plant != num5;
				while (!flag4)
				{
				}
				plant.thePlantHealth = (flag4 ? 1 : 0);
			}
		}
		while (num4 != 0);
		return;
		IL_00CE:
		throw new NullReferenceException();
	}

	// Token: 0x0600292D RID: 10541 RVA: 0x000DEA44 File Offset: 0x000DCC44
	[Token(Token = "0x600292D")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SaveMgr()
	{
	}

	// Token: 0x04001748 RID: 5960
	[Token(Token = "0x4001748")]
	public static List<SavePlantData> savePlantData = new List();

	// Token: 0x04001749 RID: 5961
	[Token(Token = "0x4001749")]
	public static SaveBoardData boardData;
}
