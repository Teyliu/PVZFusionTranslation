using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000794 RID: 1940
[Token(Token = "0x2000794")]
public class GardenGlove : BaseTool
{
	// Token: 0x06002769 RID: 10089 RVA: 0x000D0B34 File Offset: 0x000CED34
	[Token(Token = "0x6002769")]
	[Address(RVA = "0x63F710", Offset = "0x63DD10", VA = "0x18063F710", Slot = "4")]
	protected override void Update()
	{
		base.Update();
		if (Input.GetKeyDownInt((KeyCode)((uint)118)))
		{
			bool flag = !this.gold;
			this.gold = flag;
			Transform transform = base.transform;
			int num = 0;
			GameObject gameObject = transform.GetChild(num).gameObject;
			bool flag2 = this.gold;
			gameObject.SetActive(flag2);
			return;
		}
	}

	// Token: 0x0600276A RID: 10090 RVA: 0x000D0B94 File Offset: 0x000CED94
	[Token(Token = "0x600276A")]
	[Address(RVA = "0x5EDFC0", Offset = "0x5EC5C0", VA = "0x1805EDFC0")]
	public GardenGlove()
	{
	}

	// Token: 0x040014B3 RID: 5299
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014B3")]
	public bool gold;
}
