using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200020A RID: 522
[Token(Token = "0x200020A")]
public class CheckAdv : MonoBehaviour
{
	// Token: 0x060008CC RID: 2252 RVA: 0x0002D274 File Offset: 0x0002B474
	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x8E5EC0", Offset = "0x8E44C0", VA = "0x1808E5EC0")]
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

	// Token: 0x060008CD RID: 2253 RVA: 0x0002D2CC File Offset: 0x0002B4CC
	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CheckAdv()
	{
	}

	// Token: 0x04000450 RID: 1104
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000450")]
	private int theLevel;
}
