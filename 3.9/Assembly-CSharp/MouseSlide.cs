using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007CA RID: 1994
[Token(Token = "0x20007CA")]
public class MouseSlide : MonoBehaviour
{
	// Token: 0x0600288D RID: 10381 RVA: 0x000DA7EC File Offset: 0x000D89EC
	[Token(Token = "0x600288D")]
	[Address(RVA = "0x666D50", Offset = "0x665350", VA = "0x180666D50")]
	private void Update()
	{
		this.PositionUpdate();
	}

	// Token: 0x0600288E RID: 10382 RVA: 0x000DA800 File Offset: 0x000D8A00
	[Token(Token = "0x600288E")]
	[Address(RVA = "0x6669D0", Offset = "0x664FD0", VA = "0x1806669D0")]
	private void PositionUpdate()
	{
		bool mouseButton = Input.GetMouseButton(0);
		int num = 0;
		if (!mouseButton)
		{
			this.moving = mouseButton;
			float axis = Input.GetAxis("Mouse ScrollWheel");
			if (!mouseButton)
			{
				goto IL_007E;
			}
			this.offsetY = axis;
		}
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Vector3 vector;
		float z2 = vector.z;
		if (this.moving)
		{
			if (this.freezingX)
			{
			}
			if (this.freezingY)
			{
			}
			Transform transform = base.transform;
		}
		this.moving = true;
		this.startPosition.y = (float)0;
		IL_007E:
		float num2 = this.offsetY;
		int num3 = 0;
		if (num2 <= (float)num)
		{
			if (num <= (int)num2)
			{
				goto IL_00F0;
			}
			Transform transform2 = base.transform;
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			float unscaledDeltaTime2 = Time.unscaledDeltaTime;
			this.offsetY = unscaledDeltaTime2;
			if (unscaledDeltaTime2 >= (float)num)
			{
				goto IL_00E8;
			}
		}
		Transform transform3 = base.transform;
		float unscaledDeltaTime3 = Time.unscaledDeltaTime;
		float num4 = this.offsetY;
		float unscaledDeltaTime4 = Time.unscaledDeltaTime;
		this.offsetY = num4;
		IL_00E8:
		this.offsetY = (float)num3;
		IL_00F0:
		if (this.minY > this.maxY)
		{
			float num5 = this.minY;
			this.maxY = num5;
		}
		Transform transform4 = base.transform;
		float num6 = this.minY;
		float num7 = this.maxY;
		Transform transform5 = base.transform;
	}

	// Token: 0x0600288F RID: 10383 RVA: 0x000DA944 File Offset: 0x000D8B44
	[Token(Token = "0x600288F")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public MouseSlide()
	{
	}

	// Token: 0x04001692 RID: 5778
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001692")]
	private Vector2 startPosition;

	// Token: 0x04001693 RID: 5779
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001693")]
	private bool moving;

	// Token: 0x04001694 RID: 5780
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001694")]
	private float offsetY;

	// Token: 0x04001695 RID: 5781
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001695")]
	public bool freezingX;

	// Token: 0x04001696 RID: 5782
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4001696")]
	public bool freezingY;

	// Token: 0x04001697 RID: 5783
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001697")]
	public float minY;

	// Token: 0x04001698 RID: 5784
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001698")]
	public float maxY;
}
