using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200006F RID: 111
[Token(Token = "0x200006F")]
public class CircleOutline : Shadow
{
	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060001D8 RID: 472 RVA: 0x00006690 File Offset: 0x00004890
	// (set) Token: 0x060001D9 RID: 473 RVA: 0x000066A4 File Offset: 0x000048A4
	[Token(Token = "0x17000035")]
	public int OutlineWidth
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x3A67D0", Offset = "0x3A4DD0", VA = "0x1803A67D0")]
		get
		{
			return this.outlineWidth;
		}
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x3A67E0", Offset = "0x3A4DE0", VA = "0x1803A67E0")]
		set
		{
			this.outlineWidth = value;
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x000066B8 File Offset: 0x000048B8
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x3A6680", Offset = "0x3A4C80", VA = "0x1803A6680", Slot = "5")]
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

	// Token: 0x060001DB RID: 475 RVA: 0x000066F0 File Offset: 0x000048F0
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x3A6720", Offset = "0x3A4D20", VA = "0x1803A6720")]
	private void UpdateOutline()
	{
		Graphic graphic = base.graphic;
		int num = 0;
		if (graphic != num)
		{
			base.graphic.SetVerticesDirty();
		}
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00006724 File Offset: 0x00004924
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x3A62D0", Offset = "0x3A48D0", VA = "0x1803A62D0", Slot = "20")]
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

	// Token: 0x060001DD RID: 477 RVA: 0x000067AC File Offset: 0x000049AC
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x3A5FF0", Offset = "0x3A45F0", VA = "0x1803A5FF0")]
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

	// Token: 0x060001DE RID: 478 RVA: 0x00006814 File Offset: 0x00004A14
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x3A67C0", Offset = "0x3A4DC0", VA = "0x1803A67C0")]
	public CircleOutline()
	{
	}

	// Token: 0x0400006E RID: 110
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400006E")]
	[SerializeField]
	private int outlineWidth = (int)((ulong)2L);
}
