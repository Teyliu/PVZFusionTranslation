using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000863 RID: 2147
[Token(Token = "0x2000863")]
public class Page : MonoBehaviour
{
	// Token: 0x06002BE5 RID: 11237 RVA: 0x000F0DA8 File Offset: 0x000EEFA8
	[Token(Token = "0x6002BE5")]
	[Address(RVA = "0x66EBA0", Offset = "0x66D1A0", VA = "0x18066EBA0")]
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

	// Token: 0x06002BE6 RID: 11238 RVA: 0x000F0E98 File Offset: 0x000EF098
	[Token(Token = "0x6002BE6")]
	[Address(RVA = "0x66EF30", Offset = "0x66D530", VA = "0x18066EF30")]
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

	// Token: 0x06002BE7 RID: 11239 RVA: 0x000F0F18 File Offset: 0x000EF118
	[Token(Token = "0x6002BE7")]
	[Address(RVA = "0x66EDF0", Offset = "0x66D3F0", VA = "0x18066EDF0")]
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

	// Token: 0x06002BE8 RID: 11240 RVA: 0x000F0F94 File Offset: 0x000EF194
	[Token(Token = "0x6002BE8")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Page()
	{
	}
}
