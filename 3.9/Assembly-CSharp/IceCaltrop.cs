using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003C0 RID: 960
[Token(Token = "0x20003C0")]
public class IceCaltrop : Caltrop
{
	// Token: 0x06001199 RID: 4505 RVA: 0x00063834 File Offset: 0x00061A34
	[Token(Token = "0x6001199")]
	[Address(RVA = "0x492370", Offset = "0x490970", VA = "0x180492370", Slot = "71")]
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

	// Token: 0x0600119A RID: 4506 RVA: 0x000638A4 File Offset: 0x00061AA4
	[Token(Token = "0x600119A")]
	[Address(RVA = "0x444D10", Offset = "0x443310", VA = "0x180444D10")]
	public IceCaltrop()
	{
	}
}
