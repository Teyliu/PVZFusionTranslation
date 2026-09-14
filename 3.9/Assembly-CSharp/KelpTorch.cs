using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000327 RID: 807
[Token(Token = "0x2000327")]
public class KelpTorch : Tanglekelp
{
	// Token: 0x06000EA3 RID: 3747 RVA: 0x00053740 File Offset: 0x00051940
	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x459560", Offset = "0x457B60", VA = "0x180459560")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Bullet>(num) && !(collision == this))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			int thePlantRow = this.thePlantRow;
			Board board2;
			if (<Team>k__BackingField > (Team)10)
			{
				Board board;
				if (<Team>k__BackingField == (Team)15)
				{
					board = this.board;
					BoardAction boardAction = board.boardAction;
				}
				if (board != (ulong)29L)
				{
					goto IL_0086;
				}
				board2 = this.board;
				BoardAction boardAction2 = board2.boardAction;
			}
			Board board3;
			if (board2 == 0)
			{
				board3 = this.board;
				BoardAction boardAction3 = board3.boardAction;
			}
			if (board3 == (ulong)10L)
			{
				BoardAction boardAction4 = this.board.boardAction;
			}
			IL_0086:
			if (this.count > 100)
			{
				this.count = num;
				this.Summon();
			}
		}
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x000537F4 File Offset: 0x000519F4
	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x459750", Offset = "0x457D50", VA = "0x180459750")]
	private void Summon()
	{
		int i = this.thePlantColumn;
		int num = 0;
		i++;
		int num2 = 0;
		int num3 = 0;
		if (num2 == num3)
		{
			CreatePlant instance = CreatePlant.Instance;
			int num4 = 0;
			Plant plant;
			if (plant != num4)
			{
				ParticleManager instance2 = ParticleManager.Instance;
				Transform axis = plant.axis;
				int num5 = 0;
				int thePlantRow = plant.thePlantRow;
				ulong num6;
				Particle particle = instance2.SetParticle((ParticleType)((uint)11), num5, thePlantRow, num6 != 0UL, (float)num);
			}
			Board board = this.board;
			i++;
			int columnNum = board.columnNum;
			while (i <= columnNum)
			{
			}
		}
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00053888 File Offset: 0x00051A88
	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x459540", Offset = "0x457B40", VA = "0x180459540")]
	public KelpTorch()
	{
		this.range = (ulong)1073741824L;
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04000B36 RID: 2870
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B36")]
	private int count;
}
