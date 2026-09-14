using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000248 RID: 584
[Token(Token = "0x2000248")]
public class JigsawClip : MonoBehaviour
{
	// Token: 0x06000A40 RID: 2624 RVA: 0x00038DEC File Offset: 0x00036FEC
	[Token(Token = "0x6000A40")]
	[Address(RVA = "0x8A1D10", Offset = "0x8A0310", VA = "0x1808A1D10")]
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

	// Token: 0x06000A41 RID: 2625 RVA: 0x00038E2C File Offset: 0x0003702C
	[Token(Token = "0x6000A41")]
	[Address(RVA = "0x8A1DB0", Offset = "0x8A03B0", VA = "0x1808A1DB0")]
	private void Start()
	{
		TextMeshPro textMeshPro = this.description;
		JigsawType jigsawType = this.jigsawType;
		Dictionary<JigsawType, ValueTuple<Color, int, string>> jigColor = JigsawManager.JigColor;
		textMeshPro.text = "";
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00038E64 File Offset: 0x00037064
	[Token(Token = "0x6000A42")]
	[Address(RVA = "0x8A1EC0", Offset = "0x8A04C0", VA = "0x1808A1EC0")]
	private void Update()
	{
		Board instance = Board.Instance;
		TextMeshPro textMeshPro = this.description;
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x00038E88 File Offset: 0x00037088
	[Token(Token = "0x6000A43")]
	[Address(RVA = "0x8A1F30", Offset = "0x8A0530", VA = "0x1808A1F30")]
	public JigsawClip()
	{
		List<Sprite> list = new List();
		this.jigSprites = list;
		base..ctor();
	}

	// Token: 0x040005B3 RID: 1459
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005B3")]
	public int theColumn;

	// Token: 0x040005B4 RID: 1460
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40005B4")]
	public int theRow;

	// Token: 0x040005B5 RID: 1461
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005B5")]
	public JigsawType jigsawType;

	// Token: 0x040005B6 RID: 1462
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005B6")]
	public SpriteRenderer r;

	// Token: 0x040005B7 RID: 1463
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005B7")]
	public List<Sprite> jigSprites;

	// Token: 0x040005B8 RID: 1464
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005B8")]
	private TextMeshPro description;
}
