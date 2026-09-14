using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000218 RID: 536
[Token(Token = "0x2000218")]
[Serializable]
public class DamageReporter
{
	// Token: 0x06000936 RID: 2358 RVA: 0x00031898 File Offset: 0x0002FA98
	[Token(Token = "0x6000936")]
	[Address(RVA = "0x906F00", Offset = "0x905500", VA = "0x180906F00")]
	public void Report(PlantType thePlantType, long damage, Vector2 position, [Optional] Color? color)
	{
		while (thePlantType != PlantType.Nothing)
		{
			if (GameAPP.config.damagePop)
			{
				NumberPopManager instance = NumberPopManager.Instance;
			}
			int num = 0;
			Dictionary<PlantType, long> reportDic = this.ReportDic;
			Dictionary<PlantType, long> reportDic2 = this.ReportDic;
			bool flag;
			if (!flag)
			{
			}
			if (this.maxDamageType != PlantType.Nothing)
			{
				Dictionary<PlantType, long> reportDic3 = this.ReportDic;
				PlantType plantType = this.maxDamageType;
				if (reportDic3.ContainsKey(plantType))
				{
					Dictionary<PlantType, long> reportDic4 = this.ReportDic;
					PlantType plantType2 = this.maxDamageType;
					long num2 = reportDic4[plantType2];
					Dictionary<PlantType, long> reportDic5 = this.ReportDic;
					long num3;
					if (num2 >= num3)
					{
						goto IL_00E2;
					}
				}
			}
			bool flag2;
			bool flag3;
			if (flag2 || flag3)
			{
				bool flag4;
				if (flag4)
				{
				}
				bool flag5;
				if (flag5)
				{
				}
				int num5;
				if (this.maxDamageType != thePlantType)
				{
					int num4 = 0;
					Board board = this.board;
					List<Plant> plants = Lawnf.GetPlants(this.maxDamageType, board, num4 != 0);
					bool flag6;
					if (flag6)
					{
					}
					if (num != 0)
					{
						throw new NullReferenceException();
					}
					num5 = 0;
				}
				bool flag7;
				if (flag7)
				{
				}
				if (num5 != 0)
				{
					continue;
				}
			}
			IL_00E2:
			Board instance2 = Board.Instance;
			int num6 = 0;
			if (instance2 == num6)
			{
				break;
			}
			AdvantureData data = AdvantureConfig.data;
			bool flag8;
			if (flag8)
			{
				AdvantureData data2 = AdvantureConfig.data;
				bool flag9;
				if (flag9)
				{
					AdvantureData data3 = AdvantureConfig.data;
					bool flag10;
					if (flag10)
					{
					}
				}
			}
			bool flag11;
			if (flag11)
			{
				float num7 = (float)(0 * (int)0.01f);
				break;
			}
			break;
		}
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x000319E8 File Offset: 0x0002FBE8
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x906CB0", Offset = "0x9052B0", VA = "0x180906CB0")]
	public long GetDamage(PlantType plantType)
	{
		Dictionary<PlantType, long> reportDic = this.ReportDic;
		throw new NullReferenceException();
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00031A08 File Offset: 0x0002FC08
	[Token(Token = "0x6000938")]
	[Address(RVA = "0x906D30", Offset = "0x905330", VA = "0x180906D30")]
	private void OnReport(long damage)
	{
		Board instance = Board.Instance;
		int num = 0;
		if (!(instance == num))
		{
			if (AdvantureConfig.data.CheckTalent((TalentType)((uint)44)))
			{
				if (!AdvantureConfig.data.CheckTalent((TalentType)((uint)45)) || AdvantureConfig.data.CheckTalent((TalentType)((uint)46)))
				{
				}
				int num2 = 0;
				this.StealHealth((float)num2);
			}
			if (Lawnf.TravelAdvanced((AdvBuff)((uint)2005)))
			{
				float num3 = (float)(0 * (int)0.01f);
				this.StealHealth(num3);
			}
		}
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00031A84 File Offset: 0x0002FC84
	[Token(Token = "0x6000939")]
	[Address(RVA = "0x9075D0", Offset = "0x905BD0", VA = "0x1809075D0")]
	private void StealHealth(float health)
	{
		health = 1f;
		List<Plant> allPlants = Lawnf.GetAllPlants();
		Func<Plant, float> <>9__7_ = DamageReporter.<>c.<>9__7_0;
		if (<>9__7_ == 0)
		{
			Func<Plant, float> func;
			DamageReporter.<>c.<>9__7_0 = func;
		}
		Plant plant6 = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderBy<Plant, float>(allPlants, <>9__7_));
		Plant plant = plant6;
		Plant plant2 = plant;
		int num = 0;
		if (plant2 != num)
		{
			Plant plant3 = plant;
			int thePlantMaxHealth = plant3.thePlantMaxHealth;
			if (plant3.thePlantHealth < thePlantMaxHealth)
			{
				DelayAction delayAction = GameAPP.delayAction;
				Action action = delegate
				{
					Plant plant4 = plant;
					int num3 = 0;
					if (plant4 != num3)
					{
						Plant plant5 = plant;
						float health2 = health;
						int num4 = 0;
						ulong num5;
						plant5.Recover(health2, (DamageType)num4, true, num5 != 0UL);
					}
				};
				int num2 = 0;
				delayAction.SetAction(action, (float)num2);
			}
		}
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00031B38 File Offset: 0x0002FD38
	[Token(Token = "0x600093A")]
	[Address(RVA = "0x907860", Offset = "0x905E60", VA = "0x180907860")]
	public DamageReporter()
	{
		Dictionary<PlantType, long> dictionary = new Dictionary();
		this.ReportDic = dictionary;
		base..ctor();
	}

	// Token: 0x0400048B RID: 1163
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400048B")]
	public Board board;

	// Token: 0x0400048C RID: 1164
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400048C")]
	public PlantType maxDamageType = (PlantType)((ulong)4294967295L);

	// Token: 0x0400048D RID: 1165
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400048D")]
	public Dictionary<PlantType, long> ReportDic;

	// Token: 0x0400048E RID: 1166
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400048E")]
	public long totalDamage;
}
