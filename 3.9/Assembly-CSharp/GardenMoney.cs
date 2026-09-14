using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200079B RID: 1947
[Token(Token = "0x200079B")]
public class GardenMoney : MonoBehaviour
{
	// Token: 0x06002781 RID: 10113 RVA: 0x000D1664 File Offset: 0x000CF864
	[Token(Token = "0x6002781")]
	[Address(RVA = "0x63F790", Offset = "0x63DD90", VA = "0x18063F790")]
	private void Awake()
	{
		GardenMoney.Instance = this;
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x000D1678 File Offset: 0x000CF878
	[Token(Token = "0x6002782")]
	[Address(RVA = "0x63F7F0", Offset = "0x63DDF0", VA = "0x18063F7F0")]
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

	// Token: 0x06002783 RID: 10115 RVA: 0x000D16AC File Offset: 0x000CF8AC
	[Token(Token = "0x6002783")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GardenMoney()
	{
	}

	// Token: 0x040014C2 RID: 5314
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014C2")]
	public TextMeshProUGUI textMesh;

	// Token: 0x040014C3 RID: 5315
	[Token(Token = "0x40014C3")]
	public static GardenMoney Instance;

	// Token: 0x040014C4 RID: 5316
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014C4")]
	public Transform pos;
}
