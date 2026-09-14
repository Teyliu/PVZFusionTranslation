using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000357 RID: 855
[Token(Token = "0x2000357")]
public class CactusUmbrella : Umbrellaleaf
{
	// Token: 0x06000FA3 RID: 4003 RVA: 0x0005A908 File Offset: 0x00058B08
	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x41F520", Offset = "0x41DB20", VA = "0x18041F520", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			this.ConvertUpdate();
		}
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0005A93C File Offset: 0x00058B3C
	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x41F030", Offset = "0x41D630", VA = "0x18041F030")]
	private void ConvertUpdate()
	{
		ulong num7;
		do
		{
			int num = 0;
			List<Zombie> list = new List();
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = this.zombieLayer;
			int num3 = 0;
			int num4 = 0;
			Collider2D[] array;
			if (num4 < array.Length)
			{
				bool flag;
				if (flag)
				{
					int thePlantRow = this.thePlantRow;
				}
				num3++;
			}
			if (num == 0)
			{
				break;
			}
			this.anim.SetTrigger("block");
			this.flashCountDown = 1f;
			uint num5;
			GameAPP.PlaySound((int)num5, 0.5f, 1f);
			base.FlashOnce();
			if (list._size == 1)
			{
			}
			bool flag2;
			if (flag2)
			{
				if (flag2 <= true || flag2 <= true)
				{
					BalloonZombie balloonZombie;
					balloonZombie.Fall();
				}
				Plant umbrellaPot = base.UmbrellaPot;
				int num6 = 0;
				if (!(umbrellaPot == num6))
				{
				}
			}
		}
		while (num7 != (ulong)0L);
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x0005AA2C File Offset: 0x00058C2C
	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public CactusUmbrella()
	{
	}
}
