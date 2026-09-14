using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000978 RID: 2424
[Token(Token = "0x2000978")]
public class DY : MonoBehaviour
{
	// Token: 0x060031FD RID: 12797 RVA: 0x00107750 File Offset: 0x00105950
	[Token(Token = "0x60031FD")]
	[Address(RVA = "0x6E3E20", Offset = "0x6E2420", VA = "0x1806E3E20")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)117)))
		{
			TextMeshPro textMeshPro = this.TextMeshPro;
			if (!this.a)
			{
			}
			textMeshPro.text = "该视频仅在中国哔哩哔哩发布\r\n其他均为假冒\r\n认准UP主：蓝飘飘fly";
			bool flag = !this.a;
			this.a = flag;
		}
	}

	// Token: 0x060031FE RID: 12798 RVA: 0x0010779C File Offset: 0x0010599C
	[Token(Token = "0x60031FE")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public DY()
	{
	}

	// Token: 0x04001CFE RID: 7422
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001CFE")]
	public TextMeshPro TextMeshPro;

	// Token: 0x04001CFF RID: 7423
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001CFF")]
	private bool a;
}
