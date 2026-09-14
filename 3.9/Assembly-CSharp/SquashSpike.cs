using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200044E RID: 1102
[Token(Token = "0x200044E")]
public class SquashSpike : Caltrop
{
	// Token: 0x06001451 RID: 5201 RVA: 0x00071248 File Offset: 0x0006F448
	[Token(Token = "0x6001451")]
	[Address(RVA = "0x4C4FA0", Offset = "0x4C35A0", VA = "0x1804C4FA0", Slot = "71")]
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

	// Token: 0x06001452 RID: 5202 RVA: 0x00071330 File Offset: 0x0006F530
	[Token(Token = "0x6001452")]
	[Address(RVA = "0x444D10", Offset = "0x443310", VA = "0x180444D10")]
	public SquashSpike()
	{
	}
}
