using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200044F RID: 1103
[Token(Token = "0x200044F")]
public class SquashTorch : TorchWood
{
	// Token: 0x06001453 RID: 5203 RVA: 0x00071344 File Offset: 0x0006F544
	[Token(Token = "0x6001453")]
	[Address(RVA = "0x4C5390", Offset = "0x4C3990", VA = "0x1804C5390", Slot = "68")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num;
		Team <Team>k__BackingField;
		do
		{
			num = 0;
			bool flag;
			if (!collision.TryGetComponent<Bullet>(num) || flag)
			{
				return;
			}
			<Team>k__BackingField = this.<Team>k__BackingField;
			if (<Team>k__BackingField > (Team)5)
			{
			}
		}
		while (<Team>k__BackingField == (Team)(-3));
		Board board;
		if (this.thePlantRow == 0)
		{
			board = this.board;
			BoardAction boardAction = board.boardAction;
		}
		if (board == (ulong)15L)
		{
			BoardAction boardAction2 = this.board.boardAction;
			int num2 = 0;
			ulong num3;
			Bullet bullet = boardAction2.FirePeas(num, this, num2, (BulletType)num, num3 != 0UL);
			int num4 = this.fireTimes;
			num4++;
			this.fireTimes = num4;
			if (num4 > 50)
			{
				uint num5;
				bool flag2 = this.SummonPlant((int)num5);
			}
		}
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x000713E4 File Offset: 0x0006F5E4
	[Token(Token = "0x6001454")]
	[Address(RVA = "0x4C5550", Offset = "0x4C3B50", VA = "0x1804C5550", Slot = "69")]
	protected virtual bool SummonPlant(int dmg = 300)
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

	// Token: 0x06001455 RID: 5205 RVA: 0x00071474 File Offset: 0x0006F674
	[Token(Token = "0x6001455")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SquashTorch()
	{
	}

	// Token: 0x04000D1D RID: 3357
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D1D")]
	protected int fireTimes;
}
