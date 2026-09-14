using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002AE RID: 686
[Token(Token = "0x20002AE")]
public class AbyssSword : MonoBehaviour
{
	// Token: 0x06000C0E RID: 3086 RVA: 0x00044704 File Offset: 0x00042904
	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x418600", Offset = "0x416C00", VA = "0x180418600")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		AbyssSwordStar abyssSwordStar = this.plant;
		int num = 0;
		if (!(abyssSwordStar == num))
		{
			AbyssSwordStar abyssSwordStar2 = this.plant;
			bool flag;
			if (flag)
			{
				AbyssSwordStar abyssSwordStar3 = this.plant;
				AbyssSwordStar abyssSwordStar4 = this.plant;
				bool flag2;
				if (flag2)
				{
					float num2 = global::UnityEngine.Random.Range(1.3f, 1.8f);
					uint num3;
					GameAPP.PlaySound((int)num3, 0.5f, num2);
				}
			}
		}
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x0004476C File Offset: 0x0004296C
	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x418790", Offset = "0x416D90", VA = "0x180418790")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		AbyssSwordStar abyssSwordStar = this.plant;
		int num = 0;
		if (!(abyssSwordStar == num))
		{
			AbyssSwordStar abyssSwordStar2 = this.plant;
			bool flag;
			if (flag)
			{
				AbyssSwordStar abyssSwordStar3 = this.plant;
				AbyssSwordStar abyssSwordStar4 = this.plant;
				bool flag2;
				if (flag2)
				{
					AbyssSwordStar abyssSwordStar5 = this.plant;
				}
			}
		}
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x000447BC File Offset: 0x000429BC
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public AbyssSword()
	{
	}

	// Token: 0x040007FC RID: 2044
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007FC")]
	public AbyssSwordStar plant;
}
