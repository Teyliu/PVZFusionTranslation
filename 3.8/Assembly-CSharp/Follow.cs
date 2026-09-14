using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200078E RID: 1934
[Token(Token = "0x200078E")]
public class Follow : MonoBehaviour
{
	// Token: 0x06002718 RID: 10008 RVA: 0x000D13D0 File Offset: 0x000CF5D0
	[Token(Token = "0x6002718")]
	[Address(RVA = "0x6027A0", Offset = "0x600DA0", VA = "0x1806027A0")]
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

	// Token: 0x06002719 RID: 10009 RVA: 0x000D1418 File Offset: 0x000CF618
	[Token(Token = "0x6002719")]
	[Address(RVA = "0x6023F0", Offset = "0x6009F0", VA = "0x1806023F0")]
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

	// Token: 0x0600271A RID: 10010 RVA: 0x000D14CC File Offset: 0x000CF6CC
	[Token(Token = "0x600271A")]
	[Address(RVA = "0x602940", Offset = "0x600F40", VA = "0x180602940")]
	public Follow()
	{
	}

	// Token: 0x0400158C RID: 5516
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400158C")]
	public Vector2 spacing;

	// Token: 0x0400158D RID: 5517
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400158D")]
	public bool freezingX;

	// Token: 0x0400158E RID: 5518
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400158E")]
	public bool freezingY;

	// Token: 0x0400158F RID: 5519
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400158F")]
	public float minX;

	// Token: 0x04001590 RID: 5520
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001590")]
	public float maxX;

	// Token: 0x04001591 RID: 5521
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001591")]
	public float minY;

	// Token: 0x04001592 RID: 5522
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001592")]
	public float maxY;

	// Token: 0x04001593 RID: 5523
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001593")]
	public float minScale = 0.5f;

	// Token: 0x04001594 RID: 5524
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001594")]
	public float maxScale = 1f;

	// Token: 0x04001595 RID: 5525
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001595")]
	private Vector2 startPosition;

	// Token: 0x04001596 RID: 5526
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001596")]
	private bool moving;
}
