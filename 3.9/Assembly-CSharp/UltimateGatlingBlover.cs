using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200048E RID: 1166
[Token(Token = "0x200048E")]
public class UltimateGatlingBlover : Shooter
{
	// Token: 0x0600158C RID: 5516 RVA: 0x00076DA8 File Offset: 0x00074FA8
	[Token(Token = "0x600158C")]
	[Address(RVA = "0x4DE8C0", Offset = "0x4DCEC0", VA = "0x1804DE8C0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		int plantCount = global::Lawnf.GetPlantCount(this.thePlantType, board);
		int num = this.board.rowNum;
		num += num;
		if (plantCount > num)
		{
			Transform shoot = this.shoot;
			InGameText instance = InGameText.Instance;
		}
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x00076DFC File Offset: 0x00074FFC
	[Token(Token = "0x600158D")]
	[Address(RVA = "0x4DE7B0", Offset = "0x4DCDB0", VA = "0x1804DE7B0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		this.UpdateAttackCountDown();
		float num = this.coordination;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.coordination = num;
		}
		if (base.Shootable())
		{
			this.anim.SetTrigger("shoot");
			this.UpdateInterval();
			float num3 = global::UnityEngine.Random.Range(0.95f, 1.05f);
			this.thePlantAttackCountDown = num3;
			float num4 = num3 * 0.3f;
			base.AttributeCountdown = num4;
		}
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x00076E7C File Offset: 0x0007507C
	[Token(Token = "0x600158E")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "68")]
	protected override Bullet Shoot1()
	{
		return null;
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x00076E8C File Offset: 0x0007508C
	[Token(Token = "0x600158F")]
	[Address(RVA = "0x4DE320", Offset = "0x4DC920", VA = "0x1804DE320", Slot = "39")]
	protected override void AttributeEvent()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int num = 0;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			Func<Plant, bool> <>9__4_ = UltimateGatlingBlover.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				UltimateGatlingBlover.<>c.<>9__4_0 = (Plant p) => p.thePlantType == PlantType.UltimateDoomScaredy;
			}
			if (Enumerable.FirstOrDefault<Plant>(list, <>9__4_))
			{
				float num2 = this.coordination;
				int num3 = 0;
				if (num2 > (float)num3)
				{
					CreateBullet instance2 = CreateBullet.Instance;
					float num4 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
					float num5 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
					PlantType thePlantType2 = this.thePlantType;
					Bullet bullet2;
					bullet2.fromType = thePlantType2;
					if (num < 5)
					{
						int attackDamage2 = this.attackDamage;
						bullet2.Damage = attackDamage2;
						float num6 = this.coordination;
						num++;
					}
					float num7 = this.coordination;
					int num8 = bullet2._damage;
					num8 -= bullet2;
					bullet2.Damage = num8;
				}
				float num9 = this.coordination;
				this.coordination = num9;
			}
		}
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x00076FC4 File Offset: 0x000751C4
	[Token(Token = "0x6001590")]
	[Address(RVA = "0x4DEA20", Offset = "0x4DD020", VA = "0x1804DEA20")]
	private void UpdateInterval()
	{
		int num;
		bool flag;
		ulong num2;
		do
		{
			num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		}
		while ((flag && !(num != this)) || num2 != (ulong)0L);
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x00077010 File Offset: 0x00075210
	[Token(Token = "0x6001591")]
	[Address(RVA = "0x4DE9D0", Offset = "0x4DCFD0", VA = "0x1804DE9D0", Slot = "45")]
	protected override void UpdateAttackCountDown()
	{
		base.UpdateAttackCountDown();
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)3)))
		{
			float thePlantAttackCountDown = this.thePlantAttackCountDown;
			float deltaTime = Time.deltaTime;
			this.thePlantAttackCountDown = thePlantAttackCountDown;
		}
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x00077044 File Offset: 0x00075244
	[Token(Token = "0x6001592")]
	[Address(RVA = "0x4DE750", Offset = "0x4DCD50", VA = "0x1804DE750", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform shoot = this.shoot;
			return;
		}
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x00077064 File Offset: 0x00075264
	[Token(Token = "0x6001593")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateGatlingBlover()
	{
	}

	// Token: 0x04000D7B RID: 3451
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D7B")]
	private float coordination;
}
