using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C4 RID: 1220
[Token(Token = "0x20004C4")]
public class CabbageFume : Plant
{
	// Token: 0x0600170C RID: 5900 RVA: 0x0007ED34 File Offset: 0x0007CF34
	[Token(Token = "0x600170C")]
	[Address(RVA = "0x49BAC0", Offset = "0x49A0C0", VA = "0x18049BAC0")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		int num = 0;
		int num2 = this.bulletLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				num += 120;
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x0007ED84 File Offset: 0x0007CF84
	[Token(Token = "0x600170D")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public CabbageFume()
	{
	}
}
