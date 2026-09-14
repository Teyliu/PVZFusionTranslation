using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200089F RID: 2207
[Token(Token = "0x200089F")]
public class Page : MonoBehaviour
{
	// Token: 0x06002D17 RID: 11543 RVA: 0x000F5A38 File Offset: 0x000F3C38
	[Token(Token = "0x6002D17")]
	[Address(RVA = "0x6D36E0", Offset = "0x6D1CE0", VA = "0x1806D36E0")]
	public void ChangePage()
	{
		Transform transform = base.transform;
		int num = base.transform.childCount - 1;
		if (!transform.GetChild(num).gameObject.activeSelf)
		{
			int num2 = 0;
			int childCount = base.transform.childCount;
			if (num2 < childCount)
			{
				if (!base.transform.GetChild(num2).gameObject.activeSelf)
				{
					num2++;
					Transform transform2 = base.transform;
				}
				GameObject gameObject = base.transform.GetChild(num2).gameObject;
				int num3 = 0;
				gameObject.SetActive(num3 != 0);
				base.transform.GetChild(1).gameObject.SetActive(true);
			}
			return;
		}
		Transform transform3 = base.transform;
		int num4 = 0;
		transform3.GetChild(num4).gameObject.SetActive(true);
		Transform transform4 = base.transform;
		int num5 = base.transform.childCount - 1;
		GameObject gameObject2 = transform4.GetChild(num5).gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x06002D18 RID: 11544 RVA: 0x000F5B28 File Offset: 0x000F3D28
	[Token(Token = "0x6002D18")]
	[Address(RVA = "0x6D3A70", Offset = "0x6D2070", VA = "0x1806D3A70")]
	public void NextPage()
	{
		int num = 0;
		int childCount = base.transform.childCount;
		if (num < childCount)
		{
			if (!base.transform.GetChild(num).gameObject.activeSelf)
			{
				num++;
				Transform transform = base.transform;
			}
			GameObject gameObject = base.transform.GetChild(num).gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
			base.transform.GetChild(1).gameObject.SetActive(true);
		}
	}

	// Token: 0x06002D19 RID: 11545 RVA: 0x000F5BA8 File Offset: 0x000F3DA8
	[Token(Token = "0x6002D19")]
	[Address(RVA = "0x6D3930", Offset = "0x6D1F30", VA = "0x1806D3930")]
	public void LastPage()
	{
		int childCount = base.transform.childCount;
		if (1 < childCount)
		{
			if (!base.transform.GetChild(1).gameObject.activeSelf)
			{
				Transform transform = base.transform;
			}
			GameObject gameObject = base.transform.GetChild(1).gameObject;
			int num = 0;
			gameObject.SetActive(num != 0);
			int num2 = 0;
			base.transform.GetChild(num2).gameObject.SetActive(true);
		}
	}

	// Token: 0x06002D1A RID: 11546 RVA: 0x000F5C24 File Offset: 0x000F3E24
	[Token(Token = "0x6002D1A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Page()
	{
	}
}
