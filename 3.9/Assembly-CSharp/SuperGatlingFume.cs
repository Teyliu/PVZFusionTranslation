using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005AB RID: 1451
[Token(Token = "0x20005AB")]
public class SuperGatlingFume : PeaFume
{
	// Token: 0x06001ACA RID: 6858 RVA: 0x0008F920 File Offset: 0x0008DB20
	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0x5484C0", Offset = "0x546AC0", VA = "0x1805484C0", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = base.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x0008F970 File Offset: 0x0008DB70
	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0x548610", Offset = "0x546C10", VA = "0x180548610", Slot = "72")]
	protected override void StartShooting()
	{
		base.StartShooting();
		if (Lawnf.TravelUltimate((UltiBuff)((uint)50)))
		{
		}
		int num = global::UnityEngine.Random.Range(0, 100);
		this.super = num != 0;
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x0008F9A0 File Offset: 0x0008DBA0
	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0x5484A0", Offset = "0x546AA0", VA = "0x1805484A0", Slot = "73")]
	protected override void EndShooting()
	{
		base.EndShooting();
		this.super = false;
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x0008F9BC File Offset: 0x0008DBBC
	[Token(Token = "0x6001ACD")]
	[Address(RVA = "0x547DA0", Offset = "0x5463A0", VA = "0x180547DA0", Slot = "74")]
	protected override void AddDamage()
	{
		ulong num11;
		do
		{
			int num = 0;
			if ((this.super ? 1 : 0) != num)
			{
				List<Bullet> bulletArray = this.board.boardEntity.bulletArray;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
					int thePlantRow = this.thePlantRow;
					Transform axis = this.axis;
					int num4;
					uint num5;
					int num3 = Mathf.Max(num4, (int)num5);
				}
				ulong num6;
				if (num6 != (ulong)0L)
				{
					goto IL_0185;
				}
			}
			List<Bullet> bulletArray2 = this.board.boardEntity.bulletArray;
			bool flag2;
			if (flag2)
			{
				int num7 = 0;
				if (!(num != num7))
				{
					continue;
				}
				int thePlantRow2 = this.thePlantRow;
				Transform axis2 = this.axis;
				int num9;
				uint num10;
				int num8 = Mathf.Max(num9, (int)num10);
			}
		}
		while (num11 != (ulong)0L);
		float num12 = global::UnityEngine.Random.Range(-15f, 15f);
		float num13 = global::UnityEngine.Random.Range(12f, 14f);
		float num14 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num15 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		num12 = global::UnityEngine.Random.Range(-15f, 15f);
		num13 = global::UnityEngine.Random.Range(12f, 14f);
		num14 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num16 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		num12 = global::UnityEngine.Random.Range(-15f, 15f);
		num13 = global::UnityEngine.Random.Range(12f, 14f);
		num14 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		float num17 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
		return;
		IL_0185:
		throw new NullReferenceException();
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x0008FB60 File Offset: 0x0008DD60
	[Token(Token = "0x6001ACE")]
	[Address(RVA = "0x548680", Offset = "0x546C80", VA = "0x180548680")]
	private void SuperShoot(float angle, float speed, float x, float y, BulletMoveWay mw, int dmg)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = base.GetBulletType();
		Bullet bullet;
		Transform transform = bullet.transform;
		int num = 0;
		int num2 = 0;
		transform.Rotate((float)num2, (float)num, x);
		bullet.normalSpeed = speed;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x0008FBB8 File Offset: 0x0008DDB8
	[Token(Token = "0x6001ACF")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public SuperGatlingFume()
	{
	}

	// Token: 0x04000F08 RID: 3848
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F08")]
	private bool super;
}
