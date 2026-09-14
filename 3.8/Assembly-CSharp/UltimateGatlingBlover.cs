using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200046C RID: 1132
[Token(Token = "0x200046C")]
public class UltimateGatlingBlover : Shooter
{
	// Token: 0x060014ED RID: 5357 RVA: 0x00074448 File Offset: 0x00072648
	[Token(Token = "0x60014ED")]
	[Address(RVA = "0x481000", Offset = "0x47F600", VA = "0x180481000", Slot = "15")]
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
			int num2 = 0;
			instance.ShowText("究极浮空樱桃机枪数量已达上限", 3f, num2 != 0);
		}
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x000744B4 File Offset: 0x000726B4
	[Token(Token = "0x60014EE")]
	[Address(RVA = "0x480EF0", Offset = "0x47F4F0", VA = "0x180480EF0", Slot = "45")]
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

	// Token: 0x060014EF RID: 5359 RVA: 0x00074534 File Offset: 0x00072734
	[Token(Token = "0x60014EF")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "69")]
	protected override Bullet Shoot1()
	{
		return null;
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x00074544 File Offset: 0x00072744
	[Token(Token = "0x60014F0")]
	[Address(RVA = "0x480A60", Offset = "0x47F060", VA = "0x180480A60", Slot = "40")]
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
				Func<Plant, bool> func;
				UltimateGatlingBlover.<>c.<>9__4_0 = func;
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

	// Token: 0x060014F1 RID: 5361 RVA: 0x0007466C File Offset: 0x0007286C
	[Token(Token = "0x60014F1")]
	[Address(RVA = "0x481150", Offset = "0x47F750", VA = "0x180481150")]
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

	// Token: 0x060014F2 RID: 5362 RVA: 0x000746B8 File Offset: 0x000728B8
	[Token(Token = "0x60014F2")]
	[Address(RVA = "0x481100", Offset = "0x47F700", VA = "0x180481100", Slot = "46")]
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

	// Token: 0x060014F3 RID: 5363 RVA: 0x000746EC File Offset: 0x000728EC
	[Token(Token = "0x60014F3")]
	[Address(RVA = "0x480E90", Offset = "0x47F490", VA = "0x180480E90", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform shoot = this.shoot;
			return;
		}
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x0007470C File Offset: 0x0007290C
	[Token(Token = "0x60014F4")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateGatlingBlover()
	{
	}

	// Token: 0x04000CE3 RID: 3299
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CE3")]
	private float coordination;
}
