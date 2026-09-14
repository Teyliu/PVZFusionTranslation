using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002A3 RID: 675
[Token(Token = "0x20002A3")]
public class AbyssSword : MonoBehaviour
{
	// Token: 0x06000BE6 RID: 3046 RVA: 0x00044418 File Offset: 0x00042618
	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x3CB780", Offset = "0x3C9D80", VA = "0x1803CB780")]
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

	// Token: 0x06000BE7 RID: 3047 RVA: 0x00044480 File Offset: 0x00042680
	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x3CB910", Offset = "0x3C9F10", VA = "0x1803CB910")]
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

	// Token: 0x06000BE8 RID: 3048 RVA: 0x000444D0 File Offset: 0x000426D0
	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public AbyssSword()
	{
	}

	// Token: 0x040007DE RID: 2014
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007DE")]
	public AbyssSwordStar plant;
}
