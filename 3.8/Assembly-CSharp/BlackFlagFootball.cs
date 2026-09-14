using System;
using Cpp2IlInjected;

// Token: 0x02000627 RID: 1575
[Token(Token = "0x2000627")]
public class BlackFlagFootball : FlagFootball
{
	// Token: 0x06001DCD RID: 7629 RVA: 0x0009FEB8 File Offset: 0x0009E0B8
	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x531650", Offset = "0x52FC50", VA = "0x180531650", Slot = "15")]
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

	// Token: 0x06001DCE RID: 7630 RVA: 0x0009FF8C File Offset: 0x0009E18C
	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x0009FF9C File Offset: 0x0009E19C
	[Token(Token = "0x6001DCF")]
	[Address(RVA = "0x531550", Offset = "0x52FB50", VA = "0x180531550", Slot = "68")]
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

	// Token: 0x06001DD0 RID: 7632 RVA: 0x0009FFD0 File Offset: 0x0009E1D0
	[Token(Token = "0x6001DD0")]
	[Address(RVA = "0x531640", Offset = "0x52FC40", VA = "0x180531640", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
		float num;
		base.KnockBack(num, reason);
	}

	// Token: 0x06001DD1 RID: 7633 RVA: 0x0009FFE8 File Offset: 0x0009E1E8
	[Token(Token = "0x6001DD1")]
	[Address(RVA = "0x5318A0", Offset = "0x52FEA0", VA = "0x1805318A0")]
	public BlackFlagFootball()
	{
	}
}
