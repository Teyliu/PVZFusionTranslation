using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A03 RID: 2563
[Token(Token = "0x2000A03")]
public class Test : MonoBehaviour
{
	// Token: 0x060034AD RID: 13485 RVA: 0x00119E9C File Offset: 0x0011809C
	[Token(Token = "0x60034AD")]
	[Address(RVA = "0x73FD80", Offset = "0x73E380", VA = "0x18073FD80")]
	[ProButton]
	public void 获取spriterenderer()
	{
		int num = 0;
		int childCount = base.transform.childCount;
		if (num < childCount)
		{
			GameObject gameObject = base.transform.GetChild(num).gameObject;
			if (!gameObject.name.StartsWith("Z"))
			{
			}
			List<SpriteRenderer> list = this.z;
			SpriteRenderer component = gameObject.GetComponent<SpriteRenderer>();
			num++;
			Transform transform = base.transform;
		}
	}

	// Token: 0x060034AE RID: 13486 RVA: 0x00119F04 File Offset: 0x00118104
	[Token(Token = "0x60034AE")]
	[Address(RVA = "0x73FEC0", Offset = "0x73E4C0", VA = "0x18073FEC0")]
	[ProButton]
	public void Z放到P下面()
	{
		int num;
		do
		{
			List<SpriteRenderer> list = this.p;
			num = 0;
			bool flag;
			if (flag)
			{
				List<SpriteRenderer> list2 = this.z;
				bool flag2;
				if (flag2)
				{
					string text;
					int stringLength = text._stringLength;
					string text2 = text.Substring(1, stringLength);
					string text3;
					int stringLength2 = text3._stringLength;
					string text4 = text3.Substring(1, stringLength2);
					if (!string.Equals(text2, text4))
					{
						continue;
					}
					Transform transform;
					Transform transform2;
					transform.parentInternal = transform2;
				}
				if (num != 0)
				{
					goto IL_008A;
				}
			}
		}
		while (num != 0);
		return;
		IL_008A:
		throw new NullReferenceException();
	}

	// Token: 0x060034AF RID: 13487 RVA: 0x00119FA4 File Offset: 0x001181A4
	[Token(Token = "0x60034AF")]
	[Address(RVA = "0x7401A0", Offset = "0x73E7A0", VA = "0x1807401A0")]
	public Test()
	{
		List<SpriteRenderer> list = new List();
		this.z = list;
		List<SpriteRenderer> list2 = new List();
		this.p = list2;
		base..ctor();
	}

	// Token: 0x040027F2 RID: 10226
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40027F2")]
	public List<SpriteRenderer> z;

	// Token: 0x040027F3 RID: 10227
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40027F3")]
	public List<SpriteRenderer> p;
}
