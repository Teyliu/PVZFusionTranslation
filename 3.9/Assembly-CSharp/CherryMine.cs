using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000373 RID: 883
[Token(Token = "0x2000373")]
public class CherryMine : Plant
{
	// Token: 0x06001036 RID: 4150 RVA: 0x0005CF50 File Offset: 0x0005B150
	[Token(Token = "0x6001036")]
	[Address(RVA = "0x47B2C0", Offset = "0x4798C0", VA = "0x18047B2C0", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason != Plant.DieReason.ByFreeze)
		{
			Transform axis = this.axis;
			int num = 0;
			Vector3 vector;
			float z = vector.z;
			PlantType thePlantType = this.thePlantType;
			Transform axis2 = this.axis;
			ParticleManager instance = ParticleManager.Instance;
			int num2 = 0;
			int num3 = 0;
			ulong num4;
			Particle particle = instance.SetParticle((ParticleType)((uint)8), num2, 11, num4 != 0UL, (float)num3);
			GameAPP.PlaySound(47, 0.5f, 1f);
			ScreenShake.TriggerShake(0.15f);
			int num5 = this.thePlantColumn;
			int i = this.thePlantColumn;
			num5++;
			Board board = this.board;
			if (i < board.columnNum)
			{
				int j = this.thePlantRow;
				int num6 = this.thePlantRow;
				num6++;
				Board board2 = this.board;
				if (j < board2.rowNum)
				{
					CreatePlant instance2 = CreatePlant.Instance;
					int num7 = 0;
					ulong num8;
					Plant plant = instance2.SetPlant(i, j, (PlantType)((uint)4), num, num3, num7 != 0, num8 != 0UL, num);
					int num9 = 0;
					if (plant != num9 && plant != 0)
					{
						plant.AttributeCountdown = 5f;
					}
				}
				int num10 = this.thePlantRow;
				j++;
				num10++;
				while (j <= num10)
				{
				}
			}
			int num11 = this.thePlantColumn;
			i++;
			num11++;
			while (i <= num11)
			{
			}
		}
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x0005D09C File Offset: 0x0005B29C
	[Token(Token = "0x6001037")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public CherryMine()
	{
	}
}
