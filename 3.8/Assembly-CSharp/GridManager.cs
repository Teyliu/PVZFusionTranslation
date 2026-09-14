using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000763 RID: 1891
[Token(Token = "0x2000763")]
public class GridManager : MonoBehaviour
{
	// Token: 0x0600265D RID: 9821 RVA: 0x000CC690 File Offset: 0x000CA890
	[Token(Token = "0x600265D")]
	[Address(RVA = "0x5E2B90", Offset = "0x5E1190", VA = "0x1805E2B90")]
	private void OnDrawGizmos()
	{
		int num = this.theNumberOfColumn;
		this.theNumberOfColumn = 1;
		float y = this.spacing.y;
		this.spacing = (ulong)1065353216L;
		this.spacing.y = y;
		Vector2 vector = this.spacing;
		this.spacing = vector;
		this.spacing.y = 1f;
		int num2 = 0;
		int num3 = 0;
		Transform transform = base.transform;
		int childCount = transform.childCount;
		if (num3 < childCount)
		{
			Transform transform2 = base.transform;
			if (transform2 != 0 && transform2 != 0)
			{
				Transform child = transform2.GetChild(num2);
			}
			Transform transform3 = base.transform.GetChild(num2).transform;
			Transform transform4 = base.transform;
			num2++;
			Transform transform5 = base.transform;
		}
		if (this.minY > this.maxY)
		{
			float num4 = this.maxY;
			this.minY = num4;
		}
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x000CC778 File Offset: 0x000CA978
	[Token(Token = "0x600265E")]
	[Address(RVA = "0x5E30F0", Offset = "0x5E16F0", VA = "0x1805E30F0")]
	private void Update()
	{
		while (this.allowMoving)
		{
			this.PositionUpdate();
			Transform transform = base.transform;
			int num = 0;
			if (transform != 0 && transform != 0)
			{
				this.offsetY = (float)num;
				float num2 = this.minY;
				this.offsetY = (float)num;
				break;
			}
			Transform transform2 = base.transform;
			Vector3 vector;
			if (vector.y > this.maxY)
			{
				Transform transform3 = base.transform;
				Transform transform4 = base.transform;
				this.offsetY = (float)0;
			}
			Transform transform5 = base.transform;
			Vector3 vector2;
			if (this.minY > vector2.y)
			{
				Transform transform6 = base.transform;
				Transform transform7 = base.transform;
				throw new NullReferenceException();
			}
		}
		this.OnDrawGizmos();
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x000CC828 File Offset: 0x000CAA28
	[Token(Token = "0x600265F")]
	[Address(RVA = "0x5E2E40", Offset = "0x5E1440", VA = "0x1805E2E40")]
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
		if (num2 <= (float)num)
		{
			if (num > (int)num2)
			{
				Transform transform2 = base.transform;
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				float unscaledDeltaTime2 = Time.unscaledDeltaTime;
				this.offsetY = unscaledDeltaTime2;
				if (unscaledDeltaTime2 >= (float)num)
				{
					goto IL_00E6;
				}
			}
			return;
		}
		Transform transform3 = base.transform;
		float unscaledDeltaTime3 = Time.unscaledDeltaTime;
		float num3 = this.offsetY;
		float unscaledDeltaTime4 = Time.unscaledDeltaTime;
		this.offsetY = num3;
		IL_00E6:
		this.offsetY = 0f;
		throw new NullReferenceException();
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x000CC92C File Offset: 0x000CAB2C
	[Token(Token = "0x6002660")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GridManager()
	{
	}

	// Token: 0x040013ED RID: 5101
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013ED")]
	public Vector2 spacing;

	// Token: 0x040013EE RID: 5102
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013EE")]
	public int theNumberOfColumn;

	// Token: 0x040013EF RID: 5103
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40013EF")]
	public bool allowMoving;

	// Token: 0x040013F0 RID: 5104
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x40013F0")]
	public bool freezingX;

	// Token: 0x040013F1 RID: 5105
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x40013F1")]
	public bool freezingY;

	// Token: 0x040013F2 RID: 5106
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013F2")]
	public float minY;

	// Token: 0x040013F3 RID: 5107
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40013F3")]
	public float maxY;

	// Token: 0x040013F4 RID: 5108
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013F4")]
	private Vector2 startPosition;

	// Token: 0x040013F5 RID: 5109
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013F5")]
	private bool moving;

	// Token: 0x040013F6 RID: 5110
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40013F6")]
	private float offsetY;
}
