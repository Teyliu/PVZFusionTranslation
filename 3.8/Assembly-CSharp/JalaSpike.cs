using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C4 RID: 964
[Token(Token = "0x20003C4")]
public class JalaSpike : Caltrop
{
	// Token: 0x0600119F RID: 4511 RVA: 0x00063A10 File Offset: 0x00061C10
	[Token(Token = "0x600119F")]
	[Address(RVA = "0x445CF0", Offset = "0x4442F0", VA = "0x180445CF0", Slot = "72")]
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

	// Token: 0x060011A0 RID: 4512 RVA: 0x00063A80 File Offset: 0x00061C80
	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x400D00", Offset = "0x3FF300", VA = "0x180400D00")]
	public JalaSpike()
	{
	}
}
