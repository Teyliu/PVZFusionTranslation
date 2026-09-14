using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000371 RID: 881
[Token(Token = "0x2000371")]
public class CornUmbrella : Umbrellaleaf
{
	// Token: 0x06001030 RID: 4144 RVA: 0x0005D1C0 File Offset: 0x0005B3C0
	[Token(Token = "0x6001030")]
	[Address(RVA = "0x42E820", Offset = "0x42CE20", VA = "0x18042E820")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			Animator anim = this.anim;
			float speed = anim.speed;
			if (anim != 0)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				bool flag3;
				if (flag2 && !flag3)
				{
					this.anim.SetTrigger("block");
					base.AttributeCountdown = 1f;
					GameAPP.PlaySound(106, 0.5f, 1f);
					base.FlashOnce();
					this.BlockZombies();
				}
			}
		}
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x0005D238 File Offset: 0x0005B438
	[Token(Token = "0x6001031")]
	[Address(RVA = "0x42E410", Offset = "0x42CA10", VA = "0x18042E410", Slot = "70")]
	protected virtual void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num != 0UL);
		Plant umbrellaPot = base.UmbrellaPot;
		int num2 = 0;
		if (!(umbrellaPot == num2))
		{
			zombie.Buttered(4f, true);
		}
		zombie.Buttered((float)num2, true);
		throw new NullReferenceException();
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x0005D288 File Offset: 0x0005B488
	[Token(Token = "0x6001032")]
	[Address(RVA = "0x42E540", Offset = "0x42CB40", VA = "0x18042E540", Slot = "71")]
	protected virtual void BlockZombies()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				if (base.SearchUniqueZombie(num) && !flag2)
				{
					this.BlockEffect(num);
					num++;
					int num3 = 0;
					PogoZombie pogoZombie;
					pogoZombie.LoseJumper(num3);
				}
			}
			num++;
		}
		if (num <= 0 || num == 1)
		{
			return;
		}
		if (18446744073709551614UL <= (ulong)2L)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x0005D304 File Offset: 0x0005B504
	[Token(Token = "0x6001033")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public CornUmbrella()
	{
	}
}
