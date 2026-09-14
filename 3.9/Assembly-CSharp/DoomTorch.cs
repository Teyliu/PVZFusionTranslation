using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000391 RID: 913
[Token(Token = "0x2000391")]
public class DoomTorch : TorchWood
{
	// Token: 0x060010C0 RID: 4288 RVA: 0x0005F4E4 File Offset: 0x0005D6E4
	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x485280", Offset = "0x483880", VA = "0x180485280", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.Charge(60f);
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0005F504 File Offset: 0x0005D704
	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x484F80", Offset = "0x483580", VA = "0x180484F80", Slot = "68")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Bullet>(num))
		{
			bool flag = base.CheckFire(num);
			if (flag)
			{
				if (this > (ulong)15L)
				{
					if (this == (ulong)23L)
					{
						BoardAction boardAction = this.board.boardAction;
						Bullet bullet;
						bullet.theStatus = (BulletStatus)((ulong)6L);
						if (this.attributeCountdown <= 10f)
						{
							this.AttributeEvent();
							return;
						}
						return;
					}
					else
					{
						if (flag <= true)
						{
							goto IL_006D;
						}
						while (this != (ulong)123L)
						{
						}
						BoardAction boardAction2 = this.board.boardAction;
					}
				}
				BoardAction boardAction3;
				if (this != 0)
				{
					while (boardAction3 != (ulong)15L)
					{
					}
					Bullet bullet2;
					BulletHelper hitHelper = bullet2.hitHelper;
					return;
				}
				IL_006D:
				boardAction3 = this.board.boardAction;
				return;
			}
		}
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x0005F5F4 File Offset: 0x0005D7F4
	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x484DD0", Offset = "0x4833D0", VA = "0x180484DD0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.AttributeCountdown = (float)num;
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)0L);
		int num2 = 0;
		anim.SetBool("active", num2 != 0);
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x0005F630 File Offset: 0x0005D830
	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x484E40", Offset = "0x483440", VA = "0x180484E40")]
	public void Charge(float timer)
	{
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)18L);
		anim.SetTrigger("charge");
		this.anim.SetBool("active", true);
		base.AttributeCountdown = timer;
		if (this.attributeCountdown > 600f)
		{
			base.AttributeCountdown = 600f;
		}
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x0005F6A0 File Offset: 0x0005D8A0
	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public DoomTorch()
	{
	}
}
