using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020009B4 RID: 2484
[Token(Token = "0x20009B4")]
public class DY : MonoBehaviour
{
	// Token: 0x06003331 RID: 13105 RVA: 0x0010C4D0 File Offset: 0x0010A6D0
	[Token(Token = "0x6003331")]
	[Address(RVA = "0x7491E0", Offset = "0x7477E0", VA = "0x1807491E0")]
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

	// Token: 0x06003332 RID: 13106 RVA: 0x0010C51C File Offset: 0x0010A71C
	[Token(Token = "0x6003332")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public DY()
	{
	}

	// Token: 0x04001DEE RID: 7662
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001DEE")]
	public TextMeshPro TextMeshPro;

	// Token: 0x04001DEF RID: 7663
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001DEF")]
	private bool a;
}
