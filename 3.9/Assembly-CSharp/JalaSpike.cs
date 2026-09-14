using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D8 RID: 984
[Token(Token = "0x20003D8")]
public class JalaSpike : Caltrop
{
	// Token: 0x060011FB RID: 4603 RVA: 0x00065030 File Offset: 0x00063230
	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x49A180", Offset = "0x498780", VA = "0x18049A180", Slot = "71")]
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

	// Token: 0x060011FC RID: 4604 RVA: 0x000650A0 File Offset: 0x000632A0
	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x444D10", Offset = "0x443310", VA = "0x180444D10")]
	public JalaSpike()
	{
	}
}
