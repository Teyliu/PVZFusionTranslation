using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001FC RID: 508
[Token(Token = "0x20001FC")]
public class PresentCard : MonoBehaviour
{
	// Token: 0x060008A5 RID: 2213 RVA: 0x0002C4FC File Offset: 0x0002A6FC
	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x8FC780", Offset = "0x8FAD80", VA = "0x1808FC780")]
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

	// Token: 0x060008A6 RID: 2214 RVA: 0x0002C54C File Offset: 0x0002A74C
	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public PresentCard()
	{
	}
}
