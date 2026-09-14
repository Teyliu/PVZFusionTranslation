using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001F5 RID: 501
[Token(Token = "0x20001F5")]
public class PresentCard : MonoBehaviour
{
	// Token: 0x0600088B RID: 2187 RVA: 0x0002C520 File Offset: 0x0002A720
	[Token(Token = "0x600088B")]
	[Address(RVA = "0x86CC80", Offset = "0x86B280", VA = "0x18086CC80")]
	private void Start()
	{
		Board instance = Board.Instance;
		int theBoardLevel = GameAPP.theBoardLevel;
		if (theBoardLevel > 39)
		{
			if (theBoardLevel != 119)
			{
				GameObject gameObject = base.gameObject;
				int num = 0;
				gameObject.SetActive(num != 0);
				return;
			}
		}
		else
		{
			GameObject gameObject;
			while (gameObject > 0)
			{
			}
			while (gameObject >= 0)
			{
			}
		}
		base.gameObject.SetActive(true);
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0002C570 File Offset: 0x0002A770
	[Token(Token = "0x600088C")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public PresentCard()
	{
	}
}
