using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001EF RID: 495
[Token(Token = "0x20001EF")]
public class Card : MonoBehaviour
{
	// Token: 0x0600085A RID: 2138 RVA: 0x0002A7C8 File Offset: 0x000289C8
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x856D80", Offset = "0x855380", VA = "0x180856D80")]
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

	// Token: 0x0600085B RID: 2139 RVA: 0x0002A878 File Offset: 0x00028A78
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Card()
	{
	}

	// Token: 0x040003D7 RID: 983
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003D7")]
	public bool dontdestory;
}
