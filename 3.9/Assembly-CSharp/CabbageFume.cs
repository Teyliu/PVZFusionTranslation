using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E9 RID: 1257
[Token(Token = "0x20004E9")]
public class CabbageFume : Plant
{
	// Token: 0x060017BA RID: 6074 RVA: 0x00081C9C File Offset: 0x0007FE9C
	[Token(Token = "0x60017BA")]
	[Address(RVA = "0x50B410", Offset = "0x509A10", VA = "0x18050B410")]
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

	// Token: 0x060017BB RID: 6075 RVA: 0x00081CEC File Offset: 0x0007FEEC
	[Token(Token = "0x60017BB")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public CabbageFume()
	{
	}
}
