using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000211 RID: 529
[Token(Token = "0x2000211")]
[Serializable]
public class DamageReporter
{
	// Token: 0x0600091C RID: 2332 RVA: 0x000318C0 File Offset: 0x0002FAC0
	[Token(Token = "0x600091C")]
	[Address(RVA = "0x8772E0", Offset = "0x8758E0", VA = "0x1808772E0")]
	public void Report(PlantType thePlantType, int damage)
	{
		while (thePlantType != PlantType.Nothing)
		{
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
					long num = reportDic4[plantType2];
					Dictionary<PlantType, long> reportDic5 = this.ReportDic;
					long num2;
					if (num >= num2)
					{
						goto IL_00F9;
					}
				}
			}
			if (global::Lawnf.TravelInvest((InvestBuff)((uint)9)) || global::Lawnf.TravelInvest((InvestBuff)((uint)1004)))
			{
				bool flag2 = global::Lawnf.TravelInvest((InvestBuff)((uint)9));
				if (flag2)
				{
				}
				if (global::Lawnf.TravelInvest((InvestBuff)((uint)1004)))
				{
				}
				if (this.maxDamageType != thePlantType)
				{
					int num3 = 0;
					Board board = this.board;
					List<Plant> plants = global::Lawnf.GetPlants(this.maxDamageType, board, num3 != 0);
					int num4 = 0;
					bool flag3;
					if (flag3)
					{
					}
					if (num4 != 0)
					{
						throw new NullReferenceException();
					}
				}
				int num5 = 0;
				bool flag4;
				if (flag4)
				{
				}
				if (num5 != 0)
				{
					continue;
				}
			}
			IL_00F9:
			Board instance = Board.Instance;
			int num6 = 0;
			if (instance == num6)
			{
				break;
			}
			if (!AdvantureConfig.data.CheckTalent((TalentType)((uint)44)) || !AdvantureConfig.data.CheckTalent((TalentType)((uint)45)) || AdvantureConfig.data.CheckTalent((TalentType)6.4E-44f))
			{
			}
			if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)2005)))
			{
				break;
			}
			break;
		}
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00031A30 File Offset: 0x0002FC30
	[Token(Token = "0x600091D")]
	[Address(RVA = "0x876D40", Offset = "0x875340", VA = "0x180876D40")]
	private void OnReport(PlantType thePlantType, int damage)
	{
		Board instance = Board.Instance;
		int num = 0;
		if (!(instance == num))
		{
			if (AdvantureConfig.data.CheckTalent((TalentType)((uint)44)))
			{
				if (!AdvantureConfig.data.CheckTalent((TalentType)6.3E-44f) || AdvantureConfig.data.CheckTalent((TalentType)((uint)46)))
				{
				}
				this.StealHealth(6.3E-44f);
			}
			if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)2005)))
			{
				float num2;
				this.StealHealth(num2);
			}
		}
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00031AA8 File Offset: 0x0002FCA8
	[Token(Token = "0x600091E")]
	[Address(RVA = "0x877890", Offset = "0x875E90", VA = "0x180877890")]
	private void StealHealth(float health)
	{
		health = 1f;
		List<Plant> allPlants = global::Lawnf.GetAllPlants();
		Func<Plant, float> <>9__6_ = DamageReporter.<>c.<>9__6_0;
		if (<>9__6_ == 0)
		{
			Func<Plant, float> func;
			DamageReporter.<>c.<>9__6_0 = func;
		}
		Plant plant6 = Enumerable.FirstOrDefault<Plant>(Enumerable.OrderBy<Plant, float>(allPlants, <>9__6_));
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

	// Token: 0x0600091F RID: 2335 RVA: 0x00031B5C File Offset: 0x0002FD5C
	[Token(Token = "0x600091F")]
	[Address(RVA = "0x876F10", Offset = "0x875510", VA = "0x180876F10")]
	public void ReportToFile()
	{
		ulong num;
		do
		{
			this.UpdateLook();
			List<DamageReporter.DamageBody> list = this.damageBodies;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		if (DamageReporter.<>c.<>9__7_0 == 0)
		{
			Func<DamageReporter.DamageBody, long> func;
			DamageReporter.<>c.<>9__7_0 = func;
		}
		IOrderedEnumerable<DamageReporter.DamageBody> orderedEnumerable;
		List<DamageReporter.DamageBody> list2 = Enumerable.ToList<DamageReporter.DamageBody>(orderedEnumerable);
		DamageReporter.SavedBody savedBody = new DamageReporter.SavedBody();
		List<DamageReporter.DamageBody> list3 = new List();
		savedBody.damageBodies = list3;
		int num2 = 0;
		savedBody.damageBodies = num2;
		ulong num3;
		string text = JsonUtility.ToJson(savedBody, num3 != 0UL);
		string text2 = Path.Combine(SaveInfo.GetDataPath(), "report.json");
		DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(text2));
		File.WriteAllText(text2, text);
		InGameText instance = InGameText.Instance;
		string text3 = "数据已导出在：" + text2;
		int num4 = 0;
		instance.ShowText(text3, 5f, num4 != 0);
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00031C30 File Offset: 0x0002FE30
	[Token(Token = "0x6000920")]
	[Address(RVA = "0x877B20", Offset = "0x876120", VA = "0x180877B20")]
	public void UpdateLook()
	{
		int num;
		do
		{
			List<DamageReporter.DamageBody> list = this.damageBodies;
			int size = list._size;
			num = 0;
			list._size = num;
			if (size > 0)
			{
			}
			Dictionary<PlantType, long> reportDic = this.ReportDic;
			bool flag;
			if (flag)
			{
				List<DamageReporter.DamageBody> list2 = this.damageBodies;
				int size2 = list2._size;
				DamageReporter.DamageBody damageBody;
				list2._size = damageBody;
				damageBody.name = damageBody;
			}
		}
		while (num != 0);
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00031CAC File Offset: 0x0002FEAC
	[Token(Token = "0x6000921")]
	[Address(RVA = "0x877D80", Offset = "0x876380", VA = "0x180877D80")]
	public DamageReporter()
	{
		Dictionary<PlantType, long> dictionary = new Dictionary();
		this.ReportDic = dictionary;
		List<DamageReporter.DamageBody> list = new List();
		this.damageBodies = list;
		base..ctor();
	}

	// Token: 0x04000481 RID: 1153
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000481")]
	public Board board;

	// Token: 0x04000482 RID: 1154
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000482")]
	public PlantType maxDamageType = (PlantType)((ulong)4294967295L);

	// Token: 0x04000483 RID: 1155
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000483")]
	public Dictionary<PlantType, long> ReportDic;

	// Token: 0x04000484 RID: 1156
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000484")]
	public List<DamageReporter.DamageBody> damageBodies;

	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	[Serializable]
	public class SavedBody
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x00031CEC File Offset: 0x0002FEEC
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x885760", Offset = "0x883D60", VA = "0x180885760")]
		public SavedBody()
		{
			List<DamageReporter.DamageBody> list = new List();
			this.damageBodies = list;
			base..ctor();
		}

		// Token: 0x04000485 RID: 1157
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000485")]
		public List<DamageReporter.DamageBody> damageBodies;
	}

	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	[Serializable]
	public class DamageBody
	{
		// Token: 0x06000923 RID: 2339 RVA: 0x00031D0C File Offset: 0x0002FF0C
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x876D00", Offset = "0x875300", VA = "0x180876D00")]
		public DamageBody(PlantType thePlantType, long damage)
		{
			this.thePlantType = thePlantType;
			this.damage = damage;
		}

		// Token: 0x04000486 RID: 1158
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000486")]
		public PlantType thePlantType;

		// Token: 0x04000487 RID: 1159
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000487")]
		public long damage;

		// Token: 0x04000488 RID: 1160
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000488")]
		public string name;
	}
}
