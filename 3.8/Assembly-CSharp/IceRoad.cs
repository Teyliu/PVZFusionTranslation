using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200023A RID: 570
[Token(Token = "0x200023A")]
public class IceRoad : MonoBehaviour
{
	// Token: 0x06000A07 RID: 2567 RVA: 0x00036850 File Offset: 0x00034A50
	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x87F1A0", Offset = "0x87D7A0", VA = "0x18087F1A0")]
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

	// Token: 0x06000A08 RID: 2568 RVA: 0x000368E0 File Offset: 0x00034AE0
	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x87F060", Offset = "0x87D660", VA = "0x18087F060")]
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

	// Token: 0x06000A09 RID: 2569 RVA: 0x00036940 File Offset: 0x00034B40
	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x435E80", Offset = "0x434480", VA = "0x180435E80")]
	public IceRoad()
	{
	}

	// Token: 0x04000557 RID: 1367
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000557")]
	public int theRow;

	// Token: 0x04000558 RID: 1368
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000558")]
	public LineRenderer r;

	// Token: 0x04000559 RID: 1369
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000559")]
	public float x;

	// Token: 0x0400055A RID: 1370
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400055A")]
	public float roadStartX = 10f;

	// Token: 0x0400055B RID: 1371
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400055B")]
	public float fadeTimer;

	// Token: 0x0400055C RID: 1372
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400055C")]
	public bool active;
}
