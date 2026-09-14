using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003EF RID: 1007
[Token(Token = "0x20003EF")]
public class NutTorch : SquashTorch
{
	// Token: 0x06001295 RID: 4757 RVA: 0x00068B98 File Offset: 0x00066D98
	[Token(Token = "0x6001295")]
	[Address(RVA = "0x4571D0", Offset = "0x4557D0", VA = "0x1804571D0", Slot = "70")]
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

	// Token: 0x06001296 RID: 4758 RVA: 0x00068C28 File Offset: 0x00066E28
	[Token(Token = "0x6001296")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public NutTorch()
	{
	}
}
