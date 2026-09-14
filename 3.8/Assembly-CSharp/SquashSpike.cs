using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200042F RID: 1071
[Token(Token = "0x200042F")]
public class SquashSpike : Caltrop
{
	// Token: 0x060013C7 RID: 5063 RVA: 0x0006EFA4 File Offset: 0x0006D1A4
	[Token(Token = "0x60013C7")]
	[Address(RVA = "0x46D830", Offset = "0x46BE30", VA = "0x18046D830", Slot = "72")]
	protected override void AnimAttack()
	{
		int num = 0;
		base.KillCar();
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		int num3 = 0;
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag2;
			if (flag2)
			{
				int thePlantRow = this.thePlantRow;
				if (base.SearchUniqueZombie(num))
				{
					PlantType thePlantType = this.thePlantType;
				}
			}
			num++;
		}
		if (num3 != 0)
		{
			uint num4;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
			uint num5;
			uint num6;
			GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num5, (int)num6), 0.5f, 1f);
			Transform axis2 = this.axis;
			CreateBullet instance = CreateBullet.Instance;
			Transform axis3 = this.axis;
			int num7 = this.attackDamage;
			num7 += num7;
			Bullet bullet;
			bullet.Damage = num7;
			PlantType thePlantType2 = this.thePlantType;
			bullet.fromType = thePlantType2;
		}
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x0006F08C File Offset: 0x0006D28C
	[Token(Token = "0x60013C8")]
	[Address(RVA = "0x400D00", Offset = "0x3FF300", VA = "0x180400D00")]
	public SquashSpike()
	{
	}
}
