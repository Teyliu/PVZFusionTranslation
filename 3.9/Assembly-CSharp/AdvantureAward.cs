using System;
using Cpp2IlInjected;

// Token: 0x020008F2 RID: 2290
[Token(Token = "0x20008F2")]
[Serializable]
public class AdvantureAward
{
	// Token: 0x06002E68 RID: 11880 RVA: 0x000FD970 File Offset: 0x000FBB70
	[Token(Token = "0x6002E68")]
	[Address(RVA = "0x6F6D30", Offset = "0x6F5330", VA = "0x1806F6D30")]
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

	// Token: 0x06002E69 RID: 11881 RVA: 0x000FD9E8 File Offset: 0x000FBBE8
	[Token(Token = "0x6002E69")]
	[Address(RVA = "0x6F6F10", Offset = "0x6F5510", VA = "0x1806F6F10")]
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

	// Token: 0x06002E6A RID: 11882 RVA: 0x000FDA38 File Offset: 0x000FBC38
	[Token(Token = "0x6002E6A")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public AdvantureAward()
	{
	}

	// Token: 0x04001C64 RID: 7268
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001C64")]
	private bool firstMix;

	// Token: 0x04001C65 RID: 7269
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4001C65")]
	private bool firstPlant;

	// Token: 0x04001C66 RID: 7270
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001C66")]
	private int mixCount;
}
