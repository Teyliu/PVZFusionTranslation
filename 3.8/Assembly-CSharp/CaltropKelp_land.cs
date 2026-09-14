using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FC RID: 764
[Token(Token = "0x20002FC")]
public class CaltropKelp_land : Caltrop
{
	// Token: 0x06000DF3 RID: 3571 RVA: 0x00050C30 File Offset: 0x0004EE30
	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x400A80", Offset = "0x3FF080", VA = "0x180400A80", Slot = "72")]
	protected override void AnimAttack()
	{
		int num = 0;
		base.KillCar();
		Transform axis = this.axis;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (base.SearchUniqueZombie(num))
				{
					PlantType thePlantType = this.thePlantType;
				}
			}
			num++;
		}
		if (num2 != 0)
		{
			uint num3;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num3), 0.5f, 1f);
		}
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00050CA0 File Offset: 0x0004EEA0
	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x400D00", Offset = "0x3FF300", VA = "0x180400D00")]
	public CaltropKelp_land()
	{
	}
}
