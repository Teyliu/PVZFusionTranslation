using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001FB RID: 507
[Token(Token = "0x20001FB")]
public class ElementChaosCard : SpecialCard
{
	// Token: 0x06000898 RID: 2200 RVA: 0x0002CA20 File Offset: 0x0002AC20
	[Token(Token = "0x6000898")]
	[Address(RVA = "0x867A30", Offset = "0x866030", VA = "0x180867A30", Slot = "10")]
	public override void ClickedEvent()
	{
		int num2;
		do
		{
			int num = 0;
			List<CardUI> cardsOnBelt = ConveyManager.Instance.cardsOnBelt;
			num2 = 0;
			int num3 = 0;
			bool flag;
			if (flag)
			{
				if (num != 0)
				{
					while (num != 0)
					{
					}
				}
				PlantType random = ListExtensions.GetRandom<PlantType>(ConveyManager.Instance.GetElementPlants());
				ParticleManager instance = ParticleManager.Instance;
				int num4 = 0;
				ulong num5;
				Particle particle = instance.SetParticle((ParticleType)((uint)62), num4, 11, num5 != 0UL, (float)num3);
			}
		}
		while (num2 != 0);
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
		GameAPP.PlaySound(125, 0.5f, 1f);
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x0002CABC File Offset: 0x0002ACBC
	[Token(Token = "0x6000899")]
	[Address(RVA = "0x8516E0", Offset = "0x84FCE0", VA = "0x1808516E0")]
	public ElementChaosCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
