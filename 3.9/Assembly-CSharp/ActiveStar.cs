using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000088 RID: 136
[Token(Token = "0x2000088")]
public class ActiveStar : MonoBehaviour
{
	// Token: 0x06000227 RID: 551 RVA: 0x0000743C File Offset: 0x0000563C
	[Token(Token = "0x6000227")]
	[Address(RVA = "0x3E8780", Offset = "0x3E6D80", VA = "0x1803E8780")]
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

	// Token: 0x06000228 RID: 552 RVA: 0x00007480 File Offset: 0x00005680
	[Token(Token = "0x6000228")]
	[Address(RVA = "0x3E8810", Offset = "0x3E6E10", VA = "0x1803E8810")]
	private void Update()
	{
		Board instance = Board.Instance;
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06000229 RID: 553 RVA: 0x000074A4 File Offset: 0x000056A4
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ActiveStar()
	{
	}

	// Token: 0x04000080 RID: 128
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000080")]
	private GameObject mask;

	// Token: 0x04000081 RID: 129
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000081")]
	private RectTransform rectTransform;
}
