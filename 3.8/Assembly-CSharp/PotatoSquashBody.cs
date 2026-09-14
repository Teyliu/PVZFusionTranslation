using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000404 RID: 1028
[Token(Token = "0x2000404")]
public class PotatoSquashBody : Plant
{
	// Token: 0x060012F6 RID: 4854 RVA: 0x0006ACFC File Offset: 0x00068EFC
	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x45DE90", Offset = "0x45C490", VA = "0x18045DE90", Slot = "17")]
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
				Func<Plant, bool> func;
				PotatoSquashBody.<>c.<>9__0_0 = func;
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
							goto IL_0081;
						}
					}
					num++;
					IL_0081:
					this.theStatus = (PlantStatus)((ulong)29L);
					CreatePlant instance = CreatePlant.Instance;
					base.AttributeCountdown = 15f;
					this.anim.SetTrigger("unrise");
				}
			}
		}
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x0006ADC0 File Offset: 0x00068FC0
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x45DD50", Offset = "0x45C350", VA = "0x18045DD50", Slot = "40")]
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

	// Token: 0x060012F8 RID: 4856 RVA: 0x0006AE2C File Offset: 0x0006902C
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x439AA0", Offset = "0x4380A0", VA = "0x180439AA0")]
	private void Rise()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x0006AE44 File Offset: 0x00069044
	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public PotatoSquashBody()
	{
	}
}
