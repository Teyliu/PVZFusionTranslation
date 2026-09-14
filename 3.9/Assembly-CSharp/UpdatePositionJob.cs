using System;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

// Token: 0x02000A3E RID: 2622
[Token(Token = "0x2000A3E")]
[BurstCompile]
public struct UpdatePositionJob : IJobParallelFor
{
	// Token: 0x060035D5 RID: 13781 RVA: 0x0011E664 File Offset: 0x0011C864
	[Token(Token = "0x60035D5")]
	[Address(RVA = "0x7AF8E0", Offset = "0x7ADEE0", VA = "0x1807AF8E0", Slot = "4")]
	public void Execute(int index)
	{
		float num = this.deltaTime;
		this.positions.m_Length = (int)num;
	}

	// Token: 0x0400294A RID: 10570
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400294A")]
	[ReadOnly]
	public NativeArray<Vector3> velocities;

	// Token: 0x0400294B RID: 10571
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400294B")]
	public NativeArray<Vector3> positions;

	// Token: 0x0400294C RID: 10572
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400294C")]
	public float deltaTime;
}
