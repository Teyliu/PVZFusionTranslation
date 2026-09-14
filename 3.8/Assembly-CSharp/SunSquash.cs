using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200043D RID: 1085
[Token(Token = "0x200043D")]
public class SunSquash : Squash
{
	// Token: 0x06001404 RID: 5124 RVA: 0x0006FF90 File Offset: 0x0006E190
	[Token(Token = "0x6001404")]
	[Address(RVA = "0x470B20", Offset = "0x46F120", VA = "0x180470B20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)1L);
	}

	// Token: 0x06001405 RID: 5125 RVA: 0x0006FFAC File Offset: 0x0006E1AC
	[Token(Token = "0x6001405")]
	[Address(RVA = "0x470B40", Offset = "0x46F140", VA = "0x180470B40", Slot = "52")]
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

	// Token: 0x06001406 RID: 5126 RVA: 0x00070074 File Offset: 0x0006E274
	[Token(Token = "0x6001406")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SunSquash()
	{
	}
}
