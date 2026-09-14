using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000442 RID: 1090
[Token(Token = "0x2000442")]
public class SuperFurnace : AdvancedFurnuce
{
	// Token: 0x06001415 RID: 5141 RVA: 0x000703E0 File Offset: 0x0006E5E0
	[Token(Token = "0x6001415")]
	[Address(RVA = "0x471EE0", Offset = "0x4704E0", VA = "0x180471EE0", Slot = "15")]
	protected override void Start()
	{
		int num2;
		do
		{
			int num = 0;
			base.Start();
			int thePlantRow = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			num2 = 0;
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
				if (!(num != this))
				{
					continue;
				}
				InGameText instance = InGameText.Instance;
				int num3 = 0;
				instance.ShowText("距离其他小松炉太近", 3f, num3 != 0);
				base.Die((Plant.DieReason)((uint)8));
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x00070468 File Offset: 0x0006E668
	[Token(Token = "0x6001416")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "27")]
	public override void GetShield(float value)
	{
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00070478 File Offset: 0x0006E678
	[Token(Token = "0x6001417")]
	[Address(RVA = "0x471C40", Offset = "0x470240", VA = "0x180471C40", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			bool flag;
			if (flag)
			{
				while (num == 0)
				{
				}
				while (num == 0)
				{
				}
				if (!(num != this))
				{
					continue;
				}
				InGameText instance = InGameText.Instance;
				int num3 = 0;
				instance.ShowText("距离其他小松炉太近", 3f, num3 != 0);
				base.Die((Plant.DieReason)((uint)8));
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x000704E4 File Offset: 0x0006E6E4
	[Token(Token = "0x6001418")]
	[Address(RVA = "0x471950", Offset = "0x46FF50", VA = "0x180471950", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num2;
		do
		{
			base.AttributeCountdown = 3f;
			int size = this.board.griditemArray._size;
			int num = size - 1;
			num2 = 0;
			if (size > 0)
			{
				GridItem gridItem = this.board.griditemArray[num];
				int num3 = 0;
				if (!(gridItem != num3) || gridItem != 0)
				{
				}
			}
			int thePlantRow = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x00070570 File Offset: 0x0006E770
	[Token(Token = "0x6001419")]
	[Address(RVA = "0x472160", Offset = "0x470760", VA = "0x180472160", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			float num = this.timer;
			float deltaTime = Time.deltaTime;
			int num2 = 0;
			this.timer = num;
			if (num2 > (int)num)
			{
				Animator anim = this.anim;
				this.timer = 15f;
				anim.SetTrigger("shoot");
				return;
			}
		}
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x000705D0 File Offset: 0x0006E7D0
	[Token(Token = "0x600141A")]
	[Address(RVA = "0x4716E0", Offset = "0x46FCE0", VA = "0x1804716E0")]
	private void AnimShoot()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Transform shoot3 = this.shoot;
		Vector3 vector;
		float z = vector.z;
		Transform axis = this.axis;
		Bullet bullet;
		bullet.theStatus = (BulletStatus)((ulong)5L);
		float[] array;
		float num = array[0];
		bullet.Vx = num;
		bullet.Vy = 0f;
		float num2 = array[1];
		bullet.detaVy = num2;
		bullet.targetPlant = this;
		throw new NullReferenceException();
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x00070654 File Offset: 0x0006E854
	[Token(Token = "0x600141B")]
	[Address(RVA = "0x472200", Offset = "0x470800", VA = "0x180472200")]
	public SuperFurnace()
	{
	}

	// Token: 0x04000CB1 RID: 3249
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CB1")]
	private float timer;
}
