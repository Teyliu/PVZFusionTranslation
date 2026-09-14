using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000317 RID: 791
[Token(Token = "0x2000317")]
public class KelpTorch : Tanglekelp
{
	// Token: 0x06000E5A RID: 3674 RVA: 0x00052768 File Offset: 0x00050968
	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0x405160", Offset = "0x403760", VA = "0x180405160")]
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

	// Token: 0x06000E5B RID: 3675 RVA: 0x0005281C File Offset: 0x00050A1C
	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x405350", Offset = "0x403950", VA = "0x180405350")]
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

	// Token: 0x06000E5C RID: 3676 RVA: 0x000528B0 File Offset: 0x00050AB0
	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x402450", Offset = "0x400A50", VA = "0x180402450")]
	public KelpTorch()
	{
		this.range = (ulong)1073741824L;
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04000AE5 RID: 2789
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000AE5")]
	private int count;
}
