using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000083 RID: 131
[Token(Token = "0x2000083")]
public class ActiveStar : MonoBehaviour
{
	// Token: 0x0600020C RID: 524 RVA: 0x00007068 File Offset: 0x00005268
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x39C770", Offset = "0x39AD70", VA = "0x18039C770")]
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

	// Token: 0x0600020D RID: 525 RVA: 0x000070AC File Offset: 0x000052AC
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x39C800", Offset = "0x39AE00", VA = "0x18039C800")]
	private void Update()
	{
		Board instance = Board.Instance;
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x000070D0 File Offset: 0x000052D0
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ActiveStar()
	{
	}

	// Token: 0x04000073 RID: 115
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000073")]
	private GameObject mask;

	// Token: 0x04000074 RID: 116
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000074")]
	private RectTransform rectTransform;
}
