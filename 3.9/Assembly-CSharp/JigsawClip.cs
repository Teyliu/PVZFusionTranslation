using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200024E RID: 590
[Token(Token = "0x200024E")]
public class JigsawClip : MonoBehaviour
{
	// Token: 0x06000A5B RID: 2651 RVA: 0x00038C4C File Offset: 0x00036E4C
	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x931CB0", Offset = "0x9302B0", VA = "0x180931CB0")]
	private void Awake()
	{
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		this.r = component;
		Transform transform = base.transform;
		int num = 0;
		TextMeshPro component2 = transform.GetChild(num).GetComponent<TextMeshPro>();
		this.description = component2;
		throw new NullReferenceException();
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00038C8C File Offset: 0x00036E8C
	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x931D50", Offset = "0x930350", VA = "0x180931D50")]
	private void Start()
	{
		TextMeshPro textMeshPro = this.description;
		JigsawType jigsawType = this.jigsawType;
		Dictionary<JigsawType, ValueTuple<Color, int, string>> jigColor = JigsawManager.JigColor;
		textMeshPro.text = "";
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00038CC4 File Offset: 0x00036EC4
	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x931E60", Offset = "0x930460", VA = "0x180931E60")]
	private void Update()
	{
		Board instance = Board.Instance;
		TextMeshPro textMeshPro = this.description;
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00038CE8 File Offset: 0x00036EE8
	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x931ED0", Offset = "0x9304D0", VA = "0x180931ED0")]
	public JigsawClip()
	{
		List<Sprite> list = new List();
		this.jigSprites = list;
		base..ctor();
	}

	// Token: 0x040005BE RID: 1470
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005BE")]
	public int theColumn;

	// Token: 0x040005BF RID: 1471
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40005BF")]
	public int theRow;

	// Token: 0x040005C0 RID: 1472
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005C0")]
	public JigsawType jigsawType;

	// Token: 0x040005C1 RID: 1473
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005C1")]
	public SpriteRenderer r;

	// Token: 0x040005C2 RID: 1474
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005C2")]
	public List<Sprite> jigSprites;

	// Token: 0x040005C3 RID: 1475
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005C3")]
	private TextMeshPro description;
}
