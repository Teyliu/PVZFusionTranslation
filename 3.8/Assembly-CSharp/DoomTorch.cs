using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000381 RID: 897
[Token(Token = "0x2000381")]
public class DoomTorch : TorchWood
{
	// Token: 0x06001074 RID: 4212 RVA: 0x0005E4C0 File Offset: 0x0005C6C0
	[Token(Token = "0x6001074")]
	[Address(RVA = "0x4325C0", Offset = "0x430BC0", VA = "0x1804325C0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.Charge(60f);
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x0005E4E0 File Offset: 0x0005C6E0
	[Token(Token = "0x6001075")]
	[Address(RVA = "0x4322C0", Offset = "0x4308C0", VA = "0x1804322C0", Slot = "69")]
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

	// Token: 0x06001076 RID: 4214 RVA: 0x0005E5D0 File Offset: 0x0005C7D0
	[Token(Token = "0x6001076")]
	[Address(RVA = "0x432110", Offset = "0x430710", VA = "0x180432110", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.AttributeCountdown = (float)num;
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)0L);
		int num2 = 0;
		anim.SetBool("active", num2 != 0);
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x0005E60C File Offset: 0x0005C80C
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x432180", Offset = "0x430780", VA = "0x180432180")]
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

	// Token: 0x06001078 RID: 4216 RVA: 0x0005E67C File Offset: 0x0005C87C
	[Token(Token = "0x6001078")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public DoomTorch()
	{
	}
}
