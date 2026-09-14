using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000240 RID: 576
[Token(Token = "0x2000240")]
public class IceRoad : MonoBehaviour
{
	// Token: 0x06000A22 RID: 2594 RVA: 0x0003674C File Offset: 0x0003494C
	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x90ECB0", Offset = "0x90D2B0", VA = "0x18090ECB0")]
	private void Update()
	{
		float num = this.fadeTimer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.fadeTimer = num;
			float num3 = this.roadStartX;
			this.x = num3;
		}
		Mouse instance = Mouse.Instance;
		int num4 = this.theRow;
		float num5 = this.x;
		float landY = instance.GetLandY(num5, num4);
		Transform transform = base.transform;
		LineRenderer lineRenderer = this.r;
		LineRenderer lineRenderer2 = this.r;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x000367DC File Offset: 0x000349DC
	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x90EB70", Offset = "0x90D170", VA = "0x18090EB70")]
	public void PositionUpdate()
	{
		Mouse instance = Mouse.Instance;
		int num = this.theRow;
		float num2 = this.x;
		float landY = instance.GetLandY(num2, num);
		Transform transform = base.transform;
		LineRenderer lineRenderer = this.r;
		LineRenderer lineRenderer2 = this.r;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x0003683C File Offset: 0x00034A3C
	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x489720", Offset = "0x487D20", VA = "0x180489720")]
	public IceRoad()
	{
	}

	// Token: 0x04000562 RID: 1378
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000562")]
	public int theRow;

	// Token: 0x04000563 RID: 1379
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000563")]
	public LineRenderer r;

	// Token: 0x04000564 RID: 1380
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000564")]
	public float x;

	// Token: 0x04000565 RID: 1381
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000565")]
	public float roadStartX = 10f;

	// Token: 0x04000566 RID: 1382
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000566")]
	public float fadeTimer;

	// Token: 0x04000567 RID: 1383
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000567")]
	public bool active;
}
