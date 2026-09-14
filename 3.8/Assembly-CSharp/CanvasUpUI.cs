using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000732 RID: 1842
[Token(Token = "0x2000732")]
public class CanvasUpUI : MonoBehaviour
{
	// Token: 0x0600257D RID: 9597 RVA: 0x000C587C File Offset: 0x000C3A7C
	[Token(Token = "0x600257D")]
	[Address(RVA = "0x5BE6D0", Offset = "0x5BCCD0", VA = "0x1805BE6D0", Slot = "4")]
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

	// Token: 0x0600257E RID: 9598 RVA: 0x000C58C0 File Offset: 0x000C3AC0
	[Token(Token = "0x600257E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CanvasUpUI()
	{
	}
}
