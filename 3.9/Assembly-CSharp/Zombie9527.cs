using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200075D RID: 1885
[Token(Token = "0x200075D")]
public class Zombie9527 : Zombie
{
	// Token: 0x06002634 RID: 9780 RVA: 0x000C7CF8 File Offset: 0x000C5EF8
	[Token(Token = "0x6002634")]
	[Address(RVA = "0x62EEF0", Offset = "0x62D4F0", VA = "0x18062EEF0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002635 RID: 9781 RVA: 0x000C7D38 File Offset: 0x000C5F38
	[Token(Token = "0x6002635")]
	[Address(RVA = "0x62ECB0", Offset = "0x62D2B0", VA = "0x18062ECB0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num4;
		do
		{
			int num = 0;
			base.BodyTakeDamage(theDamage);
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				int num3 = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)0, (float)num3, gameObject);
			}
		}
		while (num4 != (ulong)0L);
		num4 += num4;
	}

	// Token: 0x06002636 RID: 9782 RVA: 0x000C7D98 File Offset: 0x000C5F98
	[Token(Token = "0x6002636")]
	[Address(RVA = "0x62EF90", Offset = "0x62D590", VA = "0x18062EF90")]
	public Zombie9527()
	{
	}

	// Token: 0x04001363 RID: 4963
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001363")]
	private bool changeRow;
}
