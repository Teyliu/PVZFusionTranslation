using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000430 RID: 1072
[Token(Token = "0x2000430")]
public class SquashTorch : TorchWood
{
	// Token: 0x060013C9 RID: 5065 RVA: 0x0006F0A0 File Offset: 0x0006D2A0
	[Token(Token = "0x60013C9")]
	[Address(RVA = "0x46DC20", Offset = "0x46C220", VA = "0x18046DC20", Slot = "69")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag;
		if (collision.TryGetComponent<Bullet>(num) && !flag)
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			if (typeof(global::UnityEngine.Object).TypeHandle != (ulong)2L && typeof(global::UnityEngine.Object).TypeHandle != (ulong)6L)
			{
				if (<Team>k__BackingField <= (Team)5)
				{
				}
				int thePlantRow = this.thePlantRow;
			}
			Board board;
			if (<Team>k__BackingField == Team.Player)
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
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x0006F154 File Offset: 0x0006D354
	[Token(Token = "0x60013CA")]
	[Address(RVA = "0x46DE10", Offset = "0x46C410", VA = "0x18046DE10", Slot = "70")]
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

	// Token: 0x060013CB RID: 5067 RVA: 0x0006F1E4 File Offset: 0x0006D3E4
	[Token(Token = "0x60013CB")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SquashTorch()
	{
	}

	// Token: 0x04000C93 RID: 3219
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C93")]
	protected int fireTimes;
}
