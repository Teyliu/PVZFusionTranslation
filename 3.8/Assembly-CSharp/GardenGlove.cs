using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200075B RID: 1883
[Token(Token = "0x200075B")]
public class GardenGlove : BaseTool
{
	// Token: 0x06002642 RID: 9794 RVA: 0x000CBAB0 File Offset: 0x000C9CB0
	[Token(Token = "0x6002642")]
	[Address(RVA = "0x5DC7F0", Offset = "0x5DADF0", VA = "0x1805DC7F0", Slot = "4")]
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

	// Token: 0x06002643 RID: 9795 RVA: 0x000CBB10 File Offset: 0x000C9D10
	[Token(Token = "0x6002643")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public GardenGlove()
	{
	}

	// Token: 0x040013DB RID: 5083
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013DB")]
	public bool gold;
}
