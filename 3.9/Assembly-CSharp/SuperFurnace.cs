using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000461 RID: 1121
[Token(Token = "0x2000461")]
public class SuperFurnace : AdvancedFurnuce
{
	// Token: 0x0600149F RID: 5279 RVA: 0x0007268C File Offset: 0x0007088C
	[Token(Token = "0x600149F")]
	[Address(RVA = "0x4C9A40", Offset = "0x4C8040", VA = "0x1804C9A40", Slot = "15")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x000726A0 File Offset: 0x000708A0
	[Token(Token = "0x60014A0")]
	[Address(RVA = "0x4C96C0", Offset = "0x4C7CC0", VA = "0x1804C96C0", Slot = "68")]
	protected virtual void Near(int column, int row)
	{
		int num2;
		do
		{
			int num = 0;
			List<Plant> list = global::Lawnf.Get3x3Plants(column, column);
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
				base.Die((Plant.DieReason)((uint)8));
				Transform axis = this.axis;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x00072700 File Offset: 0x00070900
	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "26")]
	public override void GetShield(float value)
	{
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x00072710 File Offset: 0x00070910
	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x4C9940", Offset = "0x4C7F40", VA = "0x1804C9940", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		this.GetShield((float)originalColumn);
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x00072724 File Offset: 0x00070924
	[Token(Token = "0x60014A3")]
	[Address(RVA = "0x4C9150", Offset = "0x4C7750", VA = "0x1804C9150", Slot = "39")]
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
			}
		}
		while (num2 != 0);
		bool flag2;
		if (flag2)
		{
		}
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x000727B8 File Offset: 0x000709B8
	[Token(Token = "0x60014A4")]
	[Address(RVA = "0x4C9470", Offset = "0x4C7A70", VA = "0x1804C9470")]
	private void MixUpdate()
	{
		int thePlantRow = this.thePlantRow;
		List<Plant> list = global::Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__6_ = SuperFurnace.<>c.<>9__6_0;
		if (<>9__6_ == 0)
		{
			SuperFurnace.<>c.<>9__6_0 = (Plant a) => a.thePlantType == PlantType.ThronsAloes;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, <>9__6_));
		int num = 0;
		if (plant != num)
		{
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x00072824 File Offset: 0x00070A24
	[Token(Token = "0x60014A5")]
	[Address(RVA = "0x4C9A80", Offset = "0x4C8080", VA = "0x1804C9A80", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x00072838 File Offset: 0x00070A38
	[Token(Token = "0x60014A6")]
	[Address(RVA = "0x4C99A0", Offset = "0x4C7FA0", VA = "0x1804C99A0", Slot = "69")]
	protected virtual void ShootUpdate()
	{
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

	// Token: 0x060014A7 RID: 5287 RVA: 0x00072890 File Offset: 0x00070A90
	[Token(Token = "0x60014A7")]
	[Address(RVA = "0x4C8F50", Offset = "0x4C7550", VA = "0x1804C8F50", Slot = "70")]
	protected virtual void AnimShoot()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Transform shoot3 = this.shoot;
		Vector3 vector;
		float z = vector.z;
		Transform axis = this.axis;
		Bullet bullet;
		bullet.velocity.y = 0f;
		bullet.theStatus = (BulletStatus)((ulong)5L);
		bullet.targetPlant = this;
		throw new NullReferenceException();
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x000728F4 File Offset: 0x00070AF4
	[Token(Token = "0x60014A8")]
	[Address(RVA = "0x4C9AB0", Offset = "0x4C80B0", VA = "0x1804C9AB0")]
	public SuperFurnace()
	{
	}

	// Token: 0x04000D3B RID: 3387
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D3B")]
	private float timer;
}
