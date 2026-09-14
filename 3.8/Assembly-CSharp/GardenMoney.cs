using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000762 RID: 1890
[Token(Token = "0x2000762")]
public class GardenMoney : MonoBehaviour
{
	// Token: 0x0600265A RID: 9818 RVA: 0x000CC634 File Offset: 0x000CA834
	[Token(Token = "0x600265A")]
	[Address(RVA = "0x5DC870", Offset = "0x5DAE70", VA = "0x1805DC870")]
	private void Awake()
	{
		GardenMoney.Instance = this;
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x000CC648 File Offset: 0x000CA848
	[Token(Token = "0x600265B")]
	[Address(RVA = "0x5DC8D0", Offset = "0x5DAED0", VA = "0x1805DC8D0")]
	private void Update()
	{
		TextMeshProUGUI textMeshProUGUI = this.textMesh;
		int num = 0;
		if (textMeshProUGUI != num)
		{
			string text;
			this.textMesh.text = text;
		}
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x000CC67C File Offset: 0x000CA87C
	[Token(Token = "0x600265C")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GardenMoney()
	{
	}

	// Token: 0x040013EA RID: 5098
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013EA")]
	public TextMeshProUGUI textMesh;

	// Token: 0x040013EB RID: 5099
	[Token(Token = "0x40013EB")]
	public static GardenMoney Instance;

	// Token: 0x040013EC RID: 5100
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013EC")]
	public Transform pos;
}
