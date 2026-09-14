using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020008FD RID: 2301
[Token(Token = "0x20008FD")]
public abstract class BaseLevelStrategy : ILevelStrategy
{
	// Token: 0x06002EB4 RID: 11956 RVA: 0x000FEEC8 File Offset: 0x000FD0C8
	[Token(Token = "0x6002EB4")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "20")]
	public virtual AdvantureLevel GetLevel()
	{
		return AdvantureLevel.Day1;
	}

	// Token: 0x06002EB5 RID: 11957 RVA: 0x000FEED8 File Offset: 0x000FD0D8
	[Token(Token = "0x6002EB5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "21")]
	public virtual void SetupBoard(Board board)
	{
	}

	// Token: 0x06002EB6 RID: 11958 RVA: 0x000FEEE8 File Offset: 0x000FD0E8
	[Token(Token = "0x6002EB6")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "22")]
	public virtual AdvantureMission CreateMission(Board board)
	{
		return null;
	}

	// Token: 0x06002EB7 RID: 11959 RVA: 0x000FEEF8 File Offset: 0x000FD0F8
	[Token(Token = "0x6002EB7")]
	[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "23")]
	public virtual int GetMaxWave()
	{
		return 10;
	}

	// Token: 0x06002EB8 RID: 11960 RVA: 0x000FEF08 File Offset: 0x000FD108
	[Token(Token = "0x6002EB8")]
	[Address(RVA = "0x710D20", Offset = "0x70F320", VA = "0x180710D20", Slot = "24")]
	public virtual List<ZombieType> GetZombieTypes()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06002EB9 RID: 11961 RVA: 0x000FEF40 File Offset: 0x000FD140
	[Token(Token = "0x6002EB9")]
	[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "25")]
	public virtual PlantType GetBasePlant()
	{
		return PlantType.SunFlower;
	}

	// Token: 0x06002EBA RID: 11962 RVA: 0x000FEF50 File Offset: 0x000FD150
	[Token(Token = "0x6002EBA")]
	[Address(RVA = "0x7106E0", Offset = "0x70ECE0", VA = "0x1807106E0", Slot = "26")]
	public virtual List<PlantType> GetConveyPlants()
	{
		List<PlantType> list = new List();
		int size = list._size;
		return list;
	}

	// Token: 0x06002EBB RID: 11963 RVA: 0x000FEF88 File Offset: 0x000FD188
	[Token(Token = "0x6002EBB")]
	[Address(RVA = "0x7108A0", Offset = "0x70EEA0", VA = "0x1807108A0", Slot = "27")]
	public virtual List<PlantType> GetRandomPlantTypes()
	{
		List<PlantType> list;
		bool flag;
		for (;;)
		{
			int num = 0;
			list = new List();
			List<PlantType> allPlantTypes = Lawnf.GetAllPlantTypes();
			Func<PlantType, bool> <>9__7_ = BaseLevelStrategy.<>c.<>9__7_0;
			if (<>9__7_ == 0)
			{
				BaseLevelStrategy.<>c.<>9__7_0 = delegate(PlantType a)
				{
					bool flag2;
					return flag2;
				};
			}
			IEnumerable<PlantType> enumerable = Enumerable.Where<PlantType>(allPlantTypes, <>9__7_);
			if (num >= <>9__7_)
			{
				goto IL_004D;
			}
			num += num;
			if (num != <>9__7_)
			{
				num++;
				goto IL_004D;
			}
			goto IL_006A;
			IL_006E:
			flag += flag;
			if ("{il2cpp array field local12->}" != (ulong)0L)
			{
			}
			if (num == 0)
			{
				break;
			}
			continue;
			IL_004D:
			if (num < typeof(IEnumerator).TypeHandle)
			{
				num += num;
				if (num == typeof(IEnumerator).TypeHandle)
				{
					goto IL_006E;
				}
				num++;
			}
			while (!flag)
			{
			}
			IL_006A:
			list += list;
			goto IL_006E;
		}
		int size = list._size;
		list._size = (flag ? 1 : 0);
		return list;
	}

	// Token: 0x06002EBC RID: 11964 RVA: 0x000FF058 File Offset: 0x000FD258
	[Token(Token = "0x6002EBC")]
	[Address(RVA = "0x710CC0", Offset = "0x70F2C0", VA = "0x180710CC0", Slot = "28")]
	public virtual List<ZombieType> GetRandomZombieTypes()
	{
		return new List();
	}

	// Token: 0x06002EBD RID: 11965 RVA: 0x000FF06C File Offset: 0x000FD26C
	[Token(Token = "0x6002EBD")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "29")]
	public virtual SceneType GetSceneType()
	{
		return SceneType.Day;
	}

	// Token: 0x06002EBE RID: 11966 RVA: 0x000FF084 File Offset: 0x000FD284
	[Token(Token = "0x6002EBE")]
	[Address(RVA = "0x7107B0", Offset = "0x70EDB0", VA = "0x1807107B0", Slot = "30")]
	public virtual string GetLevelName()
	{
		return "未命名关卡";
	}

	// Token: 0x06002EBF RID: 11967 RVA: 0x000FF098 File Offset: 0x000FD298
	[Token(Token = "0x6002EBF")]
	[Address(RVA = "0x7107E0", Offset = "0x70EDE0", VA = "0x1807107E0", Slot = "31")]
	public virtual string GetLevelTip()
	{
		return string.Empty;
	}

	// Token: 0x06002EC0 RID: 11968 RVA: 0x000FF0AC File Offset: 0x000FD2AC
	[Token(Token = "0x6002EC0")]
	[Address(RVA = "0x710860", Offset = "0x70EE60", VA = "0x180710860", Slot = "32")]
	public virtual string GetMissionDescription(MissionResult result)
	{
		return string.Empty;
	}

	// Token: 0x06002EC1 RID: 11969 RVA: 0x000FF0C0 File Offset: 0x000FD2C0
	[Token(Token = "0x6002EC1")]
	[Address(RVA = "0x710820", Offset = "0x70EE20", VA = "0x180710820", Slot = "33")]
	public virtual string GetMissionAwardDescription(MissionResult result)
	{
		return string.Empty;
	}

	// Token: 0x06002EC2 RID: 11970 RVA: 0x000FF0D4 File Offset: 0x000FD2D4
	[Token(Token = "0x6002EC2")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "34")]
	public virtual void OnBoardStart(Board board)
	{
	}

	// Token: 0x06002EC3 RID: 11971 RVA: 0x000FF0E4 File Offset: 0x000FD2E4
	[Token(Token = "0x6002EC3")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "35")]
	public virtual void InitCard(InitBoard board)
	{
	}

	// Token: 0x06002EC4 RID: 11972 RVA: 0x000FF0F4 File Offset: 0x000FD2F4
	[Token(Token = "0x6002EC4")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	protected BaseLevelStrategy()
	{
		int num = 0;
		this.SetupBoard(num);
	}
}
