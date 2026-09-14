using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000203 RID: 515
[Token(Token = "0x2000203")]
public class CheckAdv : MonoBehaviour
{
	// Token: 0x060008B2 RID: 2226 RVA: 0x0002D278 File Offset: 0x0002B478
	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x8571E0", Offset = "0x8557E0", VA = "0x1808571E0")]
	private void Start()
	{
		int buttonNumber = base.transform.GetChild(1).GetComponent<Advanture_Btn>().buttonNumber;
		this.theLevel = buttonNumber;
		if (buttonNumber > 1)
		{
			bool[] advLevelCompleted = GameAPP.advLevelCompleted;
			int num = this.theLevel;
			GameObject gameObject = base.gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
			return;
		}
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CheckAdv()
	{
	}

	// Token: 0x04000446 RID: 1094
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000446")]
	private int theLevel;
}
