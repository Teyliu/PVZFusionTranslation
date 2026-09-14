using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001F6 RID: 502
[Token(Token = "0x20001F6")]
public class Card : MonoBehaviour
{
	// Token: 0x06000874 RID: 2164 RVA: 0x0002A7A4 File Offset: 0x000289A4
	[Token(Token = "0x6000874")]
	[Address(RVA = "0x8E5A60", Offset = "0x8E4060", VA = "0x1808E5A60")]
	private void Start()
	{
		int num2;
		do
		{
			int num = 0;
			if ((this.dontdestory ? 1 : 0) != num)
			{
				break;
			}
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				bool flag;
				while (!flag)
				{
				}
				if (Lawnf.CheckIfPlantUnlock((PlantType)num) == UnlockType.NotUnlocked)
				{
					continue;
				}
				bool flag2 = AdvantureConfig.CheckPlantUnlock((PlantType)num);
			}
			if (enumerator != 0)
			{
			}
			if (num != 0)
			{
				goto IL_0084;
			}
			num2 = 0;
			if (num != 0)
			{
				break;
			}
			Transform transform;
			GameObject gameObject;
			if (transform.GetEnumerator() != 0)
			{
				int num3 = 0;
				gameObject.SetActive(num3 != 0);
			}
			if (gameObject != 0)
			{
			}
		}
		while (num2 != 0);
		return;
		IL_0084:
		throw new NullReferenceException();
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x0002A854 File Offset: 0x00028A54
	[Token(Token = "0x6000875")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Card()
	{
	}

	// Token: 0x040003E1 RID: 993
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003E1")]
	public bool dontdestory;
}
