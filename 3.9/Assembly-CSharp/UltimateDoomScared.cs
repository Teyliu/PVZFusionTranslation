using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005D6 RID: 1494
[Token(Token = "0x20005D6")]
public class UltimateDoomScared : GatlingDoomScaredy
{
	// Token: 0x06001BBC RID: 7100 RVA: 0x0009436C File Offset: 0x0009256C
	[Token(Token = "0x6001BBC")]
	[Address(RVA = "0x559430", Offset = "0x557A30", VA = "0x180559430", Slot = "73")]
	protected override void ScaredEvent()
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		Board board = this.board;
		base.AttributeCountdown = 0.3f;
		this.thePlantAttackInterval = 1.5f;
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x000943B8 File Offset: 0x000925B8
	[Token(Token = "0x6001BBD")]
	[Address(RVA = "0x5593E0", Offset = "0x5579E0", VA = "0x1805593E0", Slot = "44")]
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

	// Token: 0x06001BBE RID: 7102 RVA: 0x000943E8 File Offset: 0x000925E8
	[Token(Token = "0x6001BBE")]
	[Address(RVA = "0x5596F0", Offset = "0x557CF0", VA = "0x1805596F0", Slot = "68")]
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
				func = (Plant p) => p.thePlantType == PlantType.UltimateGatlingBlover;
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

	// Token: 0x06001BBF RID: 7103 RVA: 0x00094534 File Offset: 0x00092734
	[Token(Token = "0x6001BBF")]
	[Address(RVA = "0x559510", Offset = "0x557B10", VA = "0x180559510")]
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

	// Token: 0x06001BC0 RID: 7104 RVA: 0x000945DC File Offset: 0x000927DC
	[Token(Token = "0x6001BC0")]
	[Address(RVA = "0x540AB0", Offset = "0x53F0B0", VA = "0x180540AB0")]
	public UltimateDoomScared()
	{
	}

	// Token: 0x04000F5B RID: 3931
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F5B")]
	private float coordination;
}
