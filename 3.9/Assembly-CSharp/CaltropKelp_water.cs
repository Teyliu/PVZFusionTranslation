using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200030D RID: 781
[Token(Token = "0x200030D")]
public class CaltropKelp_water : Attacker
{
	// Token: 0x06000E3E RID: 3646 RVA: 0x00051C08 File Offset: 0x0004FE08
	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0x445140", Offset = "0x443740", VA = "0x180445140", Slot = "16")]
	protected override void Update()
	{
		base.PlantUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
		}
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00051C34 File Offset: 0x0004FE34
	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0x444DA0", Offset = "0x4433A0", VA = "0x180444DA0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		Action<Zombie> action;
		this.SearchZombieUpdate(action);
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00051C68 File Offset: 0x0004FE68
	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x444E70", Offset = "0x443470", VA = "0x180444E70")]
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

	// Token: 0x06000E41 RID: 3649 RVA: 0x00051CC4 File Offset: 0x0004FEC4
	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x444D20", Offset = "0x443320", VA = "0x180444D20")]
	private void AnimAttack()
	{
		Action<Zombie> action;
		this.SearchZombieUpdate(action);
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00051CDC File Offset: 0x0004FEDC
	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public CaltropKelp_water()
	{
	}
}
