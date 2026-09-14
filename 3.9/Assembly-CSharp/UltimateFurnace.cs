using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200048C RID: 1164
[Token(Token = "0x200048C")]
public class UltimateFurnace : SuperFurnace
{
	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06001580 RID: 5504 RVA: 0x0007694C File Offset: 0x00074B4C
	// (set) Token: 0x06001581 RID: 5505 RVA: 0x00076960 File Offset: 0x00074B60
	[Token(Token = "0x1700014F")]
	private int EssenceCount
	{
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x4DE1A0", Offset = "0x4DC7A0", VA = "0x1804DE1A0")]
		get
		{
			return this._essenceCount;
		}
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x4DE1B0", Offset = "0x4DC7B0", VA = "0x1804DE1B0")]
		set
		{
			if (value > 3)
			{
				this.DropEssence();
			}
			uint num2;
			int num = Mathf.Min(value, (int)num2);
			this._essenceCount = num;
			GameObject gameObject;
			if (num != 0 && num != 0)
			{
				if (num != 0)
				{
					if (num == 1)
					{
						this.es1.SetActive(num != 0);
						ulong num3;
						this.es2.SetActive(num3 != 0UL);
						gameObject = this.es3;
						ulong num4;
						gameObject.SetActive(num4 != 0UL);
						return;
					}
					return;
				}
				else
				{
					ulong num5;
					gameObject.SetActive(num5 != 0UL);
				}
			}
			int num6 = 0;
			gameObject.SetActive(num6 != 0);
			int num7 = 0;
			gameObject.SetActive(num7 != 0);
			int num8 = 0;
			gameObject.SetActive(num8 != 0);
		}
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x000769F0 File Offset: 0x00074BF0
	[Token(Token = "0x6001582")]
	[Address(RVA = "0x4DD9F0", Offset = "0x4DBFF0", VA = "0x1804DD9F0", Slot = "68")]
	protected override void Near(int column, int row)
	{
		int num2;
		do
		{
			int num = 0;
			List<Plant> rangePlants = global::Lawnf.GetRangePlants(column, column, 2);
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
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x00076A70 File Offset: 0x00074C70
	[Token(Token = "0x6001583")]
	[Address(RVA = "0x4DD930", Offset = "0x4DBF30", VA = "0x1804DD930")]
	private void EssenceUpdate()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x00076A94 File Offset: 0x00074C94
	[Token(Token = "0x6001584")]
	[Address(RVA = "0x4DD9E0", Offset = "0x4DBFE0", VA = "0x1804DD9E0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
		int num = this._essenceCount;
		num++;
		this.EssenceCount = num;
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x00076AB4 File Offset: 0x00074CB4
	[Token(Token = "0x6001585")]
	[Address(RVA = "0x4DD5D0", Offset = "0x4DBBD0", VA = "0x1804DD5D0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 3f;
		this.DropEssence();
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x00076AD4 File Offset: 0x00074CD4
	[Token(Token = "0x6001586")]
	[Address(RVA = "0x4DDD40", Offset = "0x4DC340", VA = "0x1804DDD40", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		int num;
		do
		{
			num = 0;
			if (this._essenceCount <= num)
			{
				break;
			}
			int thePlantRow = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				int essenceCount = this._essenceCount;
				this.EssenceCount = essenceCount;
				this.DropEssence();
				bool flag2;
				float num2;
				if (flag2 && num2 > 0.66f)
				{
					int essenceCount2 = this._essenceCount;
					this.EssenceCount = essenceCount2;
					this.DropEssence();
				}
				int i = this.board.griditemArray._size;
				while (i <= 0)
				{
				}
				GridItem gridItem = this.board.griditemArray[i];
				int num3 = 0;
				if (!(gridItem != num3))
				{
					continue;
				}
				while (gridItem == 0)
				{
				}
				int essenceCount3 = this._essenceCount;
				this.EssenceCount = essenceCount3;
				this.DropEssence();
				int essenceCount4 = this._essenceCount;
				this.EssenceCount = essenceCount4;
				this.DropEssence();
			}
		}
		while (num != 0);
	}

	// Token: 0x06001587 RID: 5511 RVA: 0x00076BEC File Offset: 0x00074DEC
	[Token(Token = "0x6001587")]
	[Address(RVA = "0x4DD600", Offset = "0x4DBC00", VA = "0x1804DD600")]
	private void DropEssence()
	{
		int i;
		do
		{
			int size = this.board.griditemArray._size;
			int num = size - 1;
			i = 0;
			if (size > 0)
			{
				GridItem gridItem = this.board.griditemArray[num];
				int num2 = 0;
				ulong num3;
				if (!(gridItem != num2) || gridItem == 0 || num3 == (ulong)0L)
				{
				}
			}
			int thePlantRow = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				while (i >= 10)
				{
				}
				i++;
			}
		}
		while (i != 0);
	}

	// Token: 0x06001588 RID: 5512 RVA: 0x00076C84 File Offset: 0x00074E84
	[Token(Token = "0x6001588")]
	[Address(RVA = "0x4DD3D0", Offset = "0x4DB9D0", VA = "0x1804DD3D0", Slot = "70")]
	protected override void AnimShoot()
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
		bullet.theStatus = (BulletStatus)((ulong)10L);
		bullet.targetPlant = this;
		throw new NullReferenceException();
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x00076CE8 File Offset: 0x00074EE8
	[Token(Token = "0x6001589")]
	[Address(RVA = "0x4DE190", Offset = "0x4DC790", VA = "0x1804DE190")]
	public UltimateFurnace()
	{
	}

	// Token: 0x04000D72 RID: 3442
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D72")]
	public GameObject es1;

	// Token: 0x04000D73 RID: 3443
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D73")]
	public GameObject es2;

	// Token: 0x04000D74 RID: 3444
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D74")]
	public GameObject es3;

	// Token: 0x04000D75 RID: 3445
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D75")]
	private int _essenceCount;
}
