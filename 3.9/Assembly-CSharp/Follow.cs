using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007C7 RID: 1991
[Token(Token = "0x20007C7")]
public class Follow : MonoBehaviour
{
	// Token: 0x06002847 RID: 10311 RVA: 0x000D63F8 File Offset: 0x000D45F8
	[Token(Token = "0x6002847")]
	[Address(RVA = "0x665FB0", Offset = "0x6645B0", VA = "0x180665FB0")]
	private void Update()
	{
		this.PositionUpdate();
		Transform transform = base.transform;
		if (transform != 0 && transform != 0)
		{
			Vector2 vector;
			if (vector > this.maxX)
			{
			}
			float num = this.minY;
			float num2 = this.minX;
		}
	}

	// Token: 0x06002848 RID: 10312 RVA: 0x000D6440 File Offset: 0x000D4640
	[Token(Token = "0x6002848")]
	[Address(RVA = "0x665C00", Offset = "0x664200", VA = "0x180665C00")]
	private void PositionUpdate()
	{
		bool mouseButton = Input.GetMouseButton(0);
		if (!mouseButton)
		{
			this.moving = mouseButton;
		}
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Transform transform;
		if (this.moving)
		{
			if (this.freezingX)
			{
			}
			if (this.freezingY)
			{
			}
			int num = 0;
			transform = base.transform;
			transform.Translate(num);
		}
		this.moving = true;
		float axis = Input.GetAxis("Mouse ScrollWheel");
		if (transform != 0)
		{
			Transform transform2 = base.transform;
		}
		Transform transform3 = base.transform;
		float num2 = this.minScale;
		Transform transform4 = base.transform;
		Transform transform5 = base.transform;
		Transform transform6 = base.transform;
	}

	// Token: 0x06002849 RID: 10313 RVA: 0x000D64F4 File Offset: 0x000D46F4
	[Token(Token = "0x6002849")]
	[Address(RVA = "0x666150", Offset = "0x664750", VA = "0x180666150")]
	public Follow()
	{
	}

	// Token: 0x04001668 RID: 5736
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001668")]
	public Vector2 spacing;

	// Token: 0x04001669 RID: 5737
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001669")]
	public bool freezingX;

	// Token: 0x0400166A RID: 5738
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400166A")]
	public bool freezingY;

	// Token: 0x0400166B RID: 5739
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400166B")]
	public float minX;

	// Token: 0x0400166C RID: 5740
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400166C")]
	public float maxX;

	// Token: 0x0400166D RID: 5741
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400166D")]
	public float minY;

	// Token: 0x0400166E RID: 5742
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400166E")]
	public float maxY;

	// Token: 0x0400166F RID: 5743
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400166F")]
	public float minScale = 0.5f;

	// Token: 0x04001670 RID: 5744
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001670")]
	public float maxScale = 1f;

	// Token: 0x04001671 RID: 5745
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001671")]
	private Vector2 startPosition;

	// Token: 0x04001672 RID: 5746
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001672")]
	private bool moving;
}
