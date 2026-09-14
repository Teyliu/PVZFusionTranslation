using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000791 RID: 1937
[Token(Token = "0x2000791")]
public class MouseSlide : MonoBehaviour
{
	// Token: 0x0600275E RID: 10078 RVA: 0x000D5804 File Offset: 0x000D3A04
	[Token(Token = "0x600275E")]
	[Address(RVA = "0x603540", Offset = "0x601B40", VA = "0x180603540")]
	private void Update()
	{
		this.PositionUpdate();
	}

	// Token: 0x0600275F RID: 10079 RVA: 0x000D5818 File Offset: 0x000D3A18
	[Token(Token = "0x600275F")]
	[Address(RVA = "0x6031C0", Offset = "0x6017C0", VA = "0x1806031C0")]
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

	// Token: 0x06002760 RID: 10080 RVA: 0x000D595C File Offset: 0x000D3B5C
	[Token(Token = "0x6002760")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public MouseSlide()
	{
	}

	// Token: 0x040015B6 RID: 5558
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40015B6")]
	private Vector2 startPosition;

	// Token: 0x040015B7 RID: 5559
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40015B7")]
	private bool moving;

	// Token: 0x040015B8 RID: 5560
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40015B8")]
	private float offsetY;

	// Token: 0x040015B9 RID: 5561
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015B9")]
	public bool freezingX;

	// Token: 0x040015BA RID: 5562
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x40015BA")]
	public bool freezingY;

	// Token: 0x040015BB RID: 5563
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40015BB")]
	public float minY;

	// Token: 0x040015BC RID: 5564
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015BC")]
	public float maxY;
}
