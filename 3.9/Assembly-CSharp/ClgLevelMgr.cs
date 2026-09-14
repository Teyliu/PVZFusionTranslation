using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200084D RID: 2125
[Token(Token = "0x200084D")]
public class ClgLevelMgr : MonoBehaviour
{
	// Token: 0x06002B43 RID: 11075 RVA: 0x000EAEF0 File Offset: 0x000E90F0
	[Token(Token = "0x6002B43")]
	[Address(RVA = "0x6998A0", Offset = "0x697EA0", VA = "0x1806998A0")]
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

	// Token: 0x06002B44 RID: 11076 RVA: 0x000EAF80 File Offset: 0x000E9180
	[Token(Token = "0x6002B44")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ClgLevelMgr()
	{
	}

	// Token: 0x0400194A RID: 6474
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400194A")]
	public int currentPage;
}
