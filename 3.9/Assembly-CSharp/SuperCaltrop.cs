using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200045D RID: 1117
[Token(Token = "0x200045D")]
public class SuperCaltrop : Caltrop
{
	// Token: 0x06001491 RID: 5265 RVA: 0x00072338 File Offset: 0x00070538
	[Token(Token = "0x6001491")]
	[Address(RVA = "0x4C8A70", Offset = "0x4C7070", VA = "0x1804C8A70", Slot = "71")]
	protected override void AnimAttack()
	{
		int num = 0;
		int num2 = 0;
		bool flag;
		if (flag)
		{
		}
		Transform axis = this.axis;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		bool flag2;
		if (num < array.Length)
		{
			if (flag2)
			{
				int thePlantRow = this.thePlantRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					PlantType thePlantType = this.thePlantType;
					int num4 = this.attributeCount;
					num4++;
					this.attributeCount = num4;
					this.attributeCount = num;
				}
			}
			num++;
		}
		if (num2 != 0)
		{
			GameAPP.PlaySound(flag2 ? 1 : 0, 0.5f, 1f);
		}
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x000723CC File Offset: 0x000705CC
	[Token(Token = "0x6001492")]
	[Address(RVA = "0x4C8DC0", Offset = "0x4C73C0", VA = "0x1804C8DC0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)33));
		bool flag2;
		if (flag && flag2)
		{
			int thePlantRow = this.thePlantRow;
			bool flag3;
			if (flag3)
			{
				ulong num;
				if (num > (ulong)63L)
				{
					if (num == (ulong)231L || flag3 <= true)
					{
						return;
					}
				}
				else
				{
					while (flag <= true)
					{
					}
					while ((ulong)((uint)33) == (ulong)63L)
					{
					}
				}
				float num2 = Time.fixedDeltaTime * 0.3f;
				return;
			}
		}
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00072434 File Offset: 0x00070634
	[Token(Token = "0x6001493")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00072444 File Offset: 0x00070644
	[Token(Token = "0x6001494")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00072454 File Offset: 0x00070654
	[Token(Token = "0x6001495")]
	[Address(RVA = "0x4C8D80", Offset = "0x4C7380", VA = "0x1804C8D80", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		base.FlashOnce();
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00072468 File Offset: 0x00070668
	[Token(Token = "0x6001496")]
	[Address(RVA = "0x444D10", Offset = "0x443310", VA = "0x180444D10")]
	public SuperCaltrop()
	{
	}
}
