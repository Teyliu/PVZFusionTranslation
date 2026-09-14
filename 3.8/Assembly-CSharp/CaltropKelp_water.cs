using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FD RID: 765
[Token(Token = "0x20002FD")]
public class CaltropKelp_water : Attacker
{
	// Token: 0x06000DF5 RID: 3573 RVA: 0x00050CB4 File Offset: 0x0004EEB4
	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x401130", Offset = "0x3FF730", VA = "0x180401130", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00050CD0 File Offset: 0x0004EED0
	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x400D90", Offset = "0x3FF390", VA = "0x180400D90", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		Action<Zombie> action;
		this.SearchZombieUpdate(action);
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00050D04 File Offset: 0x0004EF04
	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x400E60", Offset = "0x3FF460", VA = "0x180400E60")]
	private void SearchZombieUpdate(Action<Zombie> action)
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
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				if (<Team>k__BackingField == (Team)10 || <Team>k__BackingField == (Team)(-5) || action != 0)
				{
				}
			}
			num++;
		}
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x00050D60 File Offset: 0x0004EF60
	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x400D10", Offset = "0x3FF310", VA = "0x180400D10")]
	private void AnimAttack()
	{
		Action<Zombie> action;
		this.SearchZombieUpdate(action);
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00050D78 File Offset: 0x0004EF78
	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public CaltropKelp_water()
	{
	}
}
