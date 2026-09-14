using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A42 RID: 2626
[Token(Token = "0x2000A42")]
public class Test : MonoBehaviour
{
	// Token: 0x060035EA RID: 13802 RVA: 0x0011EF70 File Offset: 0x0011D170
	[Token(Token = "0x60035EA")]
	[Address(RVA = "0x7A6C00", Offset = "0x7A5200", VA = "0x1807A6C00")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)9)))
		{
			this.MoveNext();
			return;
		}
	}

	// Token: 0x060035EB RID: 13803 RVA: 0x0011EF90 File Offset: 0x0011D190
	[Token(Token = "0x60035EB")]
	[Address(RVA = "0x7A6860", Offset = "0x7A4E60", VA = "0x1807A6860")]
	public void LookFirst()
	{
		this.index = (int)((ulong)0L);
		this.MoveNext();
	}

	// Token: 0x060035EC RID: 13804 RVA: 0x0011EFAC File Offset: 0x0011D1AC
	[Token(Token = "0x60035EC")]
	[Address(RVA = "0x7A6870", Offset = "0x7A4E70", VA = "0x1807A6870")]
	public void MoveNext()
	{
		List<Sprite> list = this.sprites;
		SpriteRenderer spriteRenderer = this.r;
		int num = this.index;
		Sprite sprite = list[num];
		spriteRenderer.sprite = sprite;
		int num2 = this.index;
		List<Sprite> list2 = this.sprites;
		num2++;
		this.index = num2;
		this.index = (int)((ulong)0L);
		this.UpdateCollider();
	}

	// Token: 0x060035ED RID: 13805 RVA: 0x0011F010 File Offset: 0x0011D210
	[Token(Token = "0x60035ED")]
	[Address(RVA = "0x7A6910", Offset = "0x7A4F10", VA = "0x1807A6910")]
	private void OnMouseDrag()
	{
		Transform transform = base.transform;
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Vector3 vector;
		float z2 = vector.z;
		Vector3 vector2;
		float z3 = vector2.z;
	}

	// Token: 0x060035EE RID: 13806 RVA: 0x0011F054 File Offset: 0x0011D254
	[Token(Token = "0x60035EE")]
	[Address(RVA = "0x7A6A30", Offset = "0x7A5030", VA = "0x1807A6A30")]
	public void UpdateCollider()
	{
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		BoxCollider2D component2 = base.GetComponent<BoxCollider2D>();
		Sprite sprite = component.sprite;
		int num = 0;
		if (sprite != num)
		{
			Sprite sprite2 = component.sprite;
			float pixelsPerUnit = component.sprite.pixelsPerUnit;
			Sprite sprite3 = component.sprite;
			Sprite sprite4 = component.sprite;
		}
	}

	// Token: 0x060035EF RID: 13807 RVA: 0x0011F0B0 File Offset: 0x0011D2B0
	[Token(Token = "0x60035EF")]
	[Address(RVA = "0x7A6C30", Offset = "0x7A5230", VA = "0x1807A6C30")]
	public Test()
	{
		List<Sprite> list = new List();
		this.sprites = list;
		base..ctor();
	}

	// Token: 0x0400295D RID: 10589
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400295D")]
	public List<Sprite> sprites;

	// Token: 0x0400295E RID: 10590
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400295E")]
	public int index;

	// Token: 0x0400295F RID: 10591
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400295F")]
	public SpriteRenderer r;
}
