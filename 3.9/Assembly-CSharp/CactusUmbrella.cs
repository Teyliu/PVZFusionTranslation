using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000367 RID: 871
[Token(Token = "0x2000367")]
public class CactusUmbrella : Umbrellaleaf
{
	// Token: 0x06000FEF RID: 4079 RVA: 0x0005B898 File Offset: 0x00059A98
	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0x476460", Offset = "0x474A60", VA = "0x180476460", Slot = "17")]
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

	// Token: 0x06000FF0 RID: 4080 RVA: 0x0005B8CC File Offset: 0x00059ACC
	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0x475F70", Offset = "0x474570", VA = "0x180475F70")]
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

	// Token: 0x06000FF1 RID: 4081 RVA: 0x0005B9BC File Offset: 0x00059BBC
	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CactusUmbrella()
	{
	}
}
