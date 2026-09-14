using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002F0 RID: 752
[Token(Token = "0x20002F0")]
public class PassiveStar : MonoBehaviour
{
	// Token: 0x06000D6F RID: 3439 RVA: 0x0004D5D0 File Offset: 0x0004B7D0
	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x3ED250", Offset = "0x3EB850", VA = "0x1803ED250")]
	private void Awake()
	{
		Transform transform = base.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
		this.mask = gameObject;
		RectTransform component = this.mask.GetComponent<RectTransform>();
		this.rectTransform = component;
		throw new NullReferenceException();
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x0004D614 File Offset: 0x0004B814
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x3ED2E0", Offset = "0x3EB8E0", VA = "0x1803ED2E0")]
	private void Update()
	{
		Board instance = Board.Instance;
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x0004D638 File Offset: 0x0004B838
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public PassiveStar()
	{
	}

	// Token: 0x04000A31 RID: 2609
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A31")]
	private GameObject mask;

	// Token: 0x04000A32 RID: 2610
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A32")]
	private RectTransform rectTransform;
}
