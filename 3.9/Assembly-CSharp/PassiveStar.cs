using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FE RID: 766
[Token(Token = "0x20002FE")]
public class PassiveStar : MonoBehaviour
{
	// Token: 0x06000DB2 RID: 3506 RVA: 0x0004E244 File Offset: 0x0004C444
	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x449C70", Offset = "0x448270", VA = "0x180449C70")]
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

	// Token: 0x06000DB3 RID: 3507 RVA: 0x0004E288 File Offset: 0x0004C488
	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x449D00", Offset = "0x448300", VA = "0x180449D00")]
	private void Update()
	{
		Board instance = Board.Instance;
		RectTransform rectTransform = this.rectTransform;
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x0004E2AC File Offset: 0x0004C4AC
	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public PassiveStar()
	{
	}

	// Token: 0x04000A70 RID: 2672
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A70")]
	private GameObject mask;

	// Token: 0x04000A71 RID: 2673
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A71")]
	private RectTransform rectTransform;
}
