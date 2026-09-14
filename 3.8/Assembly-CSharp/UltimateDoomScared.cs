using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A5 RID: 1445
[Token(Token = "0x20005A5")]
public class UltimateDoomScared : GatlingDoomScaredy
{
	// Token: 0x06001AD6 RID: 6870 RVA: 0x0008FFB4 File Offset: 0x0008E1B4
	[Token(Token = "0x6001AD6")]
	[Address(RVA = "0x4FBEA0", Offset = "0x4FA4A0", VA = "0x1804FBEA0", Slot = "74")]
	protected override void ScaredEvent()
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		Board board = this.board;
		base.AttributeCountdown = 0.3f;
		this.thePlantAttackInterval = 1.5f;
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x00090000 File Offset: 0x0008E200
	[Token(Token = "0x6001AD7")]
	[Address(RVA = "0x4FBE50", Offset = "0x4FA450", VA = "0x1804FBE50", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.PlantShootUpdate();
		float num = this.coordination;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.coordination = num;
		}
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x00090030 File Offset: 0x0008E230
	[Token(Token = "0x6001AD8")]
	[Address(RVA = "0x4FC160", Offset = "0x4FA760", VA = "0x1804FC160", Slot = "69")]
	protected override Bullet Shoot1()
	{
		float thePlantAttackInterval = this.thePlantAttackInterval;
		if (thePlantAttackInterval <= 0.2f)
		{
			this.thePlantAttackInterval = 0.2f;
		}
		this.thePlantAttackInterval = thePlantAttackInterval;
		this.anim.SetFloat("ShootSpeed", 1f);
		int num = 0;
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			Func<Plant, bool> func;
			if (UltimateDoomScared.<>c.<>9__3_0 == 0)
			{
				UltimateDoomScared.<>c.<>9__3_0 = func;
			}
			if (Enumerable.FirstOrDefault<Plant>(list, func))
			{
				float num2 = this.coordination;
				int num3 = 0;
				if (num2 > (float)num)
				{
					float num4 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
					float num5 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
					Bullet bullet;
					if (num3 < 5)
					{
						int attackDamage = this.attackDamage;
						bullet.Damage = attackDamage;
						float num6 = this.coordination;
						num3++;
						while (num6 > 0.5f)
						{
						}
					}
					float num7 = this.coordination;
					int num8 = bullet._damage;
					num8 -= bullet;
					bullet.Damage = num8;
				}
				float num9 = this.coordination;
				this.coordination = num9;
			}
		}
		uint num10;
		uint num11;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num10, (int)num11), 0.5f, 1f);
		Bullet bullet2;
		return bullet2;
	}

	// Token: 0x06001AD9 RID: 6873 RVA: 0x00090168 File Offset: 0x0008E368
	[Token(Token = "0x6001AD9")]
	[Address(RVA = "0x4FBF80", Offset = "0x4FA580", VA = "0x1804FBF80")]
	private Bullet SetBullet(Vector3 offset)
	{
		Transform shoot = this.shoot;
		int num = this.doomTimes;
		num++;
		this.doomTimes = num;
		CreateBullet instance = CreateBullet.Instance;
		uint num2;
		if (num < (int)num2)
		{
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
		}
		int num3 = 0;
		num2 += num2;
		Bullet bullet2;
		bullet2.Damage = (int)num2;
		bullet2.theStatus = (BulletStatus)((ulong)6L);
		this.doomTimes = num3;
		bool flag;
		if (!flag)
		{
			float num4 = this.thePlantAttackInterval * 3f;
			this.thePlantAttackCountDown = num4;
		}
		PlantType thePlantType = this.thePlantType;
		bullet2.fromType = thePlantType;
		return bullet2;
	}

	// Token: 0x06001ADA RID: 6874 RVA: 0x00090210 File Offset: 0x0008E410
	[Token(Token = "0x6001ADA")]
	[Address(RVA = "0x4C8690", Offset = "0x4C6C90", VA = "0x1804C8690")]
	public UltimateDoomScared()
	{
	}

	// Token: 0x04000E9C RID: 3740
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E9C")]
	private float coordination;
}
