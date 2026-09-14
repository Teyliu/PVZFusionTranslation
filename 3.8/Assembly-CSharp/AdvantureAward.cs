using System;
using Cpp2IlInjected;

// Token: 0x020008B6 RID: 2230
[Token(Token = "0x20008B6")]
[Serializable]
public class AdvantureAward
{
	// Token: 0x06002D35 RID: 11573 RVA: 0x000F8DEC File Offset: 0x000F6FEC
	[Token(Token = "0x6002D35")]
	[Address(RVA = "0x67D770", Offset = "0x67BD70", VA = "0x18067D770")]
	public void FirstMix(Plant plant)
	{
		if (!this.firstMix && AdvantureConfig.data.GetResult((AdvantureLevel)((uint)1), (MissionResult)((uint)2)))
		{
			Board.Instance.GetSun(50f, true);
		}
		this.firstMix = true;
		if (AdvantureConfig.data.talents.Contains((uint)32))
		{
			int theBoardLevel = GameAPP.theBoardLevel;
			bool flag;
			if (!flag)
			{
				int num = 0;
				int num2 = 0;
				float num3;
				plant.ModifyDamage((PlantDamageAdder)((uint)30), num3, num2 != 0, num);
			}
		}
	}

	// Token: 0x06002D36 RID: 11574 RVA: 0x000F8E64 File Offset: 0x000F7064
	[Token(Token = "0x6002D36")]
	[Address(RVA = "0x67D950", Offset = "0x67BF50", VA = "0x18067D950")]
	public void FirstPlant(Plant plant)
	{
		if (!plant.isLily)
		{
			if (!this.firstPlant && AdvantureConfig.data.talents.Contains((uint)33))
			{
				int num = 0;
				bool flag = plant.Upgrade(3, true, num != 0);
			}
			this.firstPlant = true;
		}
	}

	// Token: 0x06002D37 RID: 11575 RVA: 0x000F8EB4 File Offset: 0x000F70B4
	[Token(Token = "0x6002D37")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public AdvantureAward()
	{
	}

	// Token: 0x04001B74 RID: 7028
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001B74")]
	private bool firstMix;

	// Token: 0x04001B75 RID: 7029
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4001B75")]
	private bool firstPlant;

	// Token: 0x04001B76 RID: 7030
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001B76")]
	private int mixCount;
}
