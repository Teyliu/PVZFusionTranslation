using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000073 RID: 115
[Token(Token = "0x2000073")]
public class CircleOutline : Shadow
{
	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060001EF RID: 495 RVA: 0x0000692C File Offset: 0x00004B2C
	// (set) Token: 0x060001F0 RID: 496 RVA: 0x00006940 File Offset: 0x00004B40
	[Token(Token = "0x17000072")]
	public int OutlineWidth
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x3F2760", Offset = "0x3F0D60", VA = "0x1803F2760")]
		get
		{
			return this.outlineWidth;
		}
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x3F2770", Offset = "0x3F0D70", VA = "0x1803F2770")]
		set
		{
			this.outlineWidth = value;
		}
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00006954 File Offset: 0x00004B54
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x3F2610", Offset = "0x3F0C10", VA = "0x1803F2610", Slot = "5")]
	protected override void OnEnable()
	{
		base.OnEnable();
		Graphic graphic = base.graphic;
		int num = 0;
		if (graphic != num)
		{
			base.graphic.SetVerticesDirty();
		}
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x0000698C File Offset: 0x00004B8C
	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x3F26B0", Offset = "0x3F0CB0", VA = "0x1803F26B0")]
	private void UpdateOutline()
	{
		Graphic graphic = base.graphic;
		int num = 0;
		if (graphic != num)
		{
			base.graphic.SetVerticesDirty();
		}
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x000069C0 File Offset: 0x00004BC0
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x3F2260", Offset = "0x3F0860", VA = "0x1803F2260", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
		if (base.IsActive())
		{
			List<UIVertex> list = new List();
			vh.GetUIVertexStream(list);
			int size = list._size;
			int i = this.outlineWidth;
			int j = this.outlineWidth;
			int num = i * i;
			if (i != 0 || j != 0)
			{
				int num2 = j * j;
				num2 += num;
				if (j <= 0)
				{
				}
				int num3 = 0;
				if (size > 0)
				{
					num3++;
				}
			}
			j++;
			while (j <= this.outlineWidth)
			{
			}
			i++;
			while (i <= this.outlineWidth)
			{
			}
		}
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00006A48 File Offset: 0x00004C48
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x3F1F80", Offset = "0x3F0580", VA = "0x1803F1F80")]
	private void ApplyOutline(List<UIVertex> vertices, int startCount)
	{
		int i = this.outlineWidth;
		int j = this.outlineWidth;
		int num = i * i;
		if (i != 0 || j != 0)
		{
			int num2 = j * j;
			num2 += num;
			if (j <= 0)
			{
			}
			int num3 = 0;
			if (startCount > 0)
			{
				num3++;
			}
		}
		j++;
		while (j <= this.outlineWidth)
		{
		}
		i++;
		while (i <= this.outlineWidth)
		{
		}
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00006AB0 File Offset: 0x00004CB0
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x3F2750", Offset = "0x3F0D50", VA = "0x1803F2750")]
	public CircleOutline()
	{
	}

	// Token: 0x04000078 RID: 120
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000078")]
	[SerializeField]
	private int outlineWidth = (int)((ulong)2L);
}
