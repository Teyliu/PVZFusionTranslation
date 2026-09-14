using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200080F RID: 2063
[Token(Token = "0x200080F")]
public class ClgLevelMgr : MonoBehaviour
{
	// Token: 0x06002A05 RID: 10757 RVA: 0x000E5BB0 File Offset: 0x000E3DB0
	[Token(Token = "0x6002A05")]
	[Address(RVA = "0x635330", Offset = "0x633930", VA = "0x180635330")]
	public void ChangePage(int page)
	{
		int num;
		do
		{
			num = 0;
			this.currentPage = page;
			Transform transform = base.transform;
			int num2 = 0;
			IEnumerator enumerator = transform.GetEnumerator();
			if (num < num2)
			{
				num += num;
				num++;
			}
			if (num < enumerator)
			{
				num += num;
				num++;
			}
			enumerator += enumerator;
			enumerator += enumerator;
			int num3;
			if (num3 != page)
			{
				int num4 = 0;
				GameObject gameObject;
				gameObject.SetActive(num4 != 0);
			}
			GameObject gameObject2;
			ulong num5;
			gameObject2.SetActive(num5 != 0UL);
			if (gameObject2 != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06002A06 RID: 10758 RVA: 0x000E5C40 File Offset: 0x000E3E40
	[Token(Token = "0x6002A06")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ClgLevelMgr()
	{
	}

	// Token: 0x0400184E RID: 6222
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400184E")]
	public int currentPage;
}
