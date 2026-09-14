using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200076B RID: 1899
[Token(Token = "0x200076B")]
public class CanvasUpUI : MonoBehaviour
{
	// Token: 0x060026A2 RID: 9890 RVA: 0x000CA818 File Offset: 0x000C8A18
	[Token(Token = "0x60026A2")]
	[Address(RVA = "0x61F250", Offset = "0x61D850", VA = "0x18061F250", Slot = "4")]
	protected virtual void Start()
	{
		Transform transform = base.transform;
		Transform canvasUp = GameAPP.canvasUp;
		transform.parentInternal = canvasUp;
		GameObject gameObject = base.gameObject;
		bool flag;
		if (flag)
		{
			Vector2 anchoredPosition = base.GetComponent<RectTransform>().anchoredPosition;
		}
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x000CA85C File Offset: 0x000C8A5C
	[Token(Token = "0x60026A3")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CanvasUpUI()
	{
	}
}
