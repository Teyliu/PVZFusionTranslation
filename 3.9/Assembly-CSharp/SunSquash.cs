using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200045C RID: 1116
[Token(Token = "0x200045C")]
public class SunSquash : Squash
{
	// Token: 0x0600148E RID: 5262 RVA: 0x00072240 File Offset: 0x00070440
	[Token(Token = "0x600148E")]
	[Address(RVA = "0x4C8380", Offset = "0x4C6980", VA = "0x1804C8380", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)1L);
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x0007225C File Offset: 0x0007045C
	[Token(Token = "0x600148F")]
	[Address(RVA = "0x4C83A0", Offset = "0x4C69A0", VA = "0x1804C83A0", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason != Plant.DieReason.ByShovel)
		{
			Board board = this.board;
			int num = this.attributeCount;
			num++;
			long num2 = (long)(num * (int)((uint)25));
			Transform axis = this.axis;
			CreatePlant instance = CreatePlant.Instance;
			int num3 = 0;
			Plant plant;
			if (plant != num3)
			{
				int num4 = this.attributeCount;
				num4++;
				plant.attributeCount = num4;
				Board board2 = this.board;
				int num5 = this.attributeCount;
				num5++;
				long num6 = (long)(num5 * (int)((uint)25));
				board2.UseSun((float)num3);
				return;
			}
		}
		Transform axis2 = this.axis;
		CreateItem instance2 = CreateItem.Instance;
		Vector3 vector;
		float z = vector.z;
		Transform axis3 = this.axis;
		CreateItem instance3 = CreateItem.Instance;
		Vector3 vector2;
		float z2 = vector2.z;
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00072324 File Offset: 0x00070524
	[Token(Token = "0x6001490")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SunSquash()
	{
	}
}
