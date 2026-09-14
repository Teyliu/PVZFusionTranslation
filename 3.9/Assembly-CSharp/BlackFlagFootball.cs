using System;
using Cpp2IlInjected;

// Token: 0x0200065C RID: 1628
[Token(Token = "0x200065C")]
public class BlackFlagFootball : FlagFootball
{
	// Token: 0x06001ECC RID: 7884 RVA: 0x000A44CC File Offset: 0x000A26CC
	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0x5881A0", Offset = "0x5867A0", VA = "0x1805881A0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)34));
		int num = 0;
		if (flag)
		{
			this.anim.SetTrigger("roll");
			base.ChangeStatus((ZombieStatus)((uint)3));
			Action defaultAction = this.defaultAction;
			Action action = delegate
			{
				base.ChangeStatus((ZombieStatus)((uint)34));
			};
			Delegate @delegate = Delegate.Combine(defaultAction, action);
			if (@delegate == 0)
			{
				this.defaultAction = num;
			}
			if (@delegate != 0)
			{
				this.defaultAction = @delegate;
				if (@delegate != 0)
				{
					goto IL_0068;
				}
			}
			throw new InvalidCastException();
		}
		IL_0068:
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)35)))
		{
			Action defaultAction2 = this.defaultAction;
			Action action2 = delegate
			{
				int num2 = this.theAttackDamage;
				num2 += num2;
				this.theAttackDamage = num2;
			};
			Delegate delegate2 = Delegate.Combine(defaultAction2, action2);
			if (delegate2 == 0)
			{
				this.defaultAction = num;
			}
			if (delegate2 == 0)
			{
				throw new InvalidCastException();
			}
			this.defaultAction = delegate2;
			if (delegate2 == 0)
			{
				throw new InvalidCastException();
			}
		}
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x000A45A0 File Offset: 0x000A27A0
	[Token(Token = "0x6001ECD")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x000A45B0 File Offset: 0x000A27B0
	[Token(Token = "0x6001ECE")]
	[Address(RVA = "0x5880A0", Offset = "0x5866A0", VA = "0x1805880A0", Slot = "70")]
	protected override void AttackEffect(Plant plant)
	{
		base.AttackEffect(plant);
		bool flag;
		if (!flag)
		{
			bool flag2 = plant.SetEffect((EffectType)((uint)103), 1f, 1f);
			return;
		}
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x000A45E4 File Offset: 0x000A27E4
	[Token(Token = "0x6001ECF")]
	[Address(RVA = "0x588190", Offset = "0x586790", VA = "0x180588190", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
		float num;
		base.KnockBack(num, reason);
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x000A45FC File Offset: 0x000A27FC
	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0x5883F0", Offset = "0x5869F0", VA = "0x1805883F0")]
	public BlackFlagFootball()
	{
	}
}
