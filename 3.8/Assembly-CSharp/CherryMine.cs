using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000363 RID: 867
[Token(Token = "0x2000363")]
public class CherryMine : Plant
{
	// Token: 0x06000FEA RID: 4074 RVA: 0x0005BF90 File Offset: 0x0005A190
	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x4244B0", Offset = "0x422AB0", VA = "0x1804244B0", Slot = "52")]
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

	// Token: 0x06000FEB RID: 4075 RVA: 0x0005C0DC File Offset: 0x0005A2DC
	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public CherryMine()
	{
	}
}
