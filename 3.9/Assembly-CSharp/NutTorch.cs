using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000409 RID: 1033
[Token(Token = "0x2000409")]
public class NutTorch : SquashTorch
{
	// Token: 0x06001308 RID: 4872 RVA: 0x0006A944 File Offset: 0x00068B44
	[Token(Token = "0x6001308")]
	[Address(RVA = "0x4AC660", Offset = "0x4AAC60", VA = "0x1804AC660", Slot = "69")]
	protected override bool SummonPlant(int dmg = 300)
	{
		int num;
		int num5;
		Plant plant;
		do
		{
			num = 0;
			CreatePlant instance = CreatePlant.Instance;
			int num2 = this.thePlantColumn;
			uint num3;
			num2 += (int)num3;
			Board board = this.board;
			int num4 = this.thePlantColumn;
			int columnNum = board.columnNum;
			num4 += (int)num3;
			num3 += (uint)1;
			num5 = 0;
		}
		while (plant == num5);
		int num6 = 0;
		bool flag = plant != num6;
		if (!flag)
		{
			return flag;
		}
		ParticleManager instance2 = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		this.fireTimes = num;
		throw new NullReferenceException();
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x0006A9D4 File Offset: 0x00068BD4
	[Token(Token = "0x6001309")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public NutTorch()
	{
	}
}
