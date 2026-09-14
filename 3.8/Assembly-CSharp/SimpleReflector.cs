using System;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A02 RID: 2562
[Token(Token = "0x2000A02")]
public class SimpleReflector : MonoBehaviour
{
	// Token: 0x060034AA RID: 13482 RVA: 0x00119E08 File Offset: 0x00118008
	[Token(Token = "0x60034AA")]
	[Address(RVA = "0x73E3C0", Offset = "0x73C9C0", VA = "0x18073E3C0")]
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

	// Token: 0x060034AB RID: 13483 RVA: 0x00119E4C File Offset: 0x0011804C
	[Token(Token = "0x60034AB")]
	[Address(RVA = "0x73E2A0", Offset = "0x73C8A0", VA = "0x18073E2A0")]
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

	// Token: 0x060034AC RID: 13484 RVA: 0x00119E88 File Offset: 0x00118088
	[Token(Token = "0x60034AC")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SimpleReflector()
	{
	}

	// Token: 0x040027F0 RID: 10224
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40027F0")]
	public int count;

	// Token: 0x040027F1 RID: 10225
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40027F1")]
	public int count2;
}
