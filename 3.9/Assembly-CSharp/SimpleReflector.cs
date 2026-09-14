using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A43 RID: 2627
[Token(Token = "0x2000A43")]
public class SimpleReflector : MonoBehaviour
{
	// Token: 0x060035F0 RID: 13808 RVA: 0x0011F0D0 File Offset: 0x0011D2D0
	[Token(Token = "0x60035F0")]
	[Address(RVA = "0x7A4EA0", Offset = "0x7A34A0", VA = "0x1807A4EA0")]
	[ProButton]
	public void Test()
	{
		int num = 0;
		if (this.count > num)
		{
			float value = global::UnityEngine.Random.value;
			int num2;
			Debug.Log(num2);
			num++;
		}
		string text;
		Debug.Log("共触发" + text + "次");
	}

	// Token: 0x060035F1 RID: 13809 RVA: 0x0011F114 File Offset: 0x0011D314
	[Token(Token = "0x60035F1")]
	[Address(RVA = "0x7A4D80", Offset = "0x7A3380", VA = "0x1807A4D80")]
	[ProButton]
	public void Test2()
	{
		int num = 0;
		float value = global::UnityEngine.Random.value;
		int num2;
		Debug.Log(num2);
		num++;
		string text;
		Debug.Log("共触发" + text + "次");
	}

	// Token: 0x060035F2 RID: 13810 RVA: 0x0011F150 File Offset: 0x0011D350
	[Token(Token = "0x60035F2")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SimpleReflector()
	{
	}

	// Token: 0x04002960 RID: 10592
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002960")]
	public int count;

	// Token: 0x04002961 RID: 10593
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4002961")]
	public int count2;
}
