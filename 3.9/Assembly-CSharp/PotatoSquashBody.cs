using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041F RID: 1055
[Token(Token = "0x200041F")]
public class PotatoSquashBody : Plant
{
	// Token: 0x0600136C RID: 4972 RVA: 0x0006CB30 File Offset: 0x0006AD30
	[Token(Token = "0x600136C")]
	[Address(RVA = "0x4B4380", Offset = "0x4B2980", VA = "0x1804B4380", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		if (base.Active)
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			Func<Plant, bool> <>9__0_ = PotatoSquashBody.<>c.<>9__0_0;
			if (<>9__0_ == 0)
			{
				PotatoSquashBody.<>c.<>9__0_0 = (Plant p) => p.thePlantType == PlantType.PotatoSquash;
			}
			if (!Enumerable.FirstOrDefault<Plant>(list, <>9__0_))
			{
				Transform axis = this.axis;
				int num2 = this.zombieLayer;
				Collider2D[] array;
				if (num < array.Length)
				{
					bool flag;
					if (flag)
					{
						int thePlantRow2 = this.thePlantRow;
						if (Lawnf.InLandStatus((ZombieStatus)num))
						{
							goto IL_008F;
						}
					}
					num++;
					IL_008F:
					this.theStatus = (PlantStatus)((ulong)29L);
					CreatePlant instance = CreatePlant.Instance;
					base.AttributeCountdown = 15f;
					this.anim.SetTrigger("unrise");
				}
			}
		}
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x0006CC04 File Offset: 0x0006AE04
	[Token(Token = "0x600136D")]
	[Address(RVA = "0x4B4240", Offset = "0x4B2840", VA = "0x1804B4240", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("rise");
		base.Invoke("Rise", 0.5f);
		GameAPP.PlaySound(48, 0.5f, 1f);
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)9), num, 11, num3 != 0UL, (float)num2);
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x0006CC70 File Offset: 0x0006AE70
	[Token(Token = "0x600136E")]
	[Address(RVA = "0x48D320", Offset = "0x48B920", VA = "0x18048D320")]
	private void Rise()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x0006CC88 File Offset: 0x0006AE88
	[Token(Token = "0x600136F")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public PotatoSquashBody()
	{
	}
}
