using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000202 RID: 514
[Token(Token = "0x2000202")]
public class ElementChaosCard : SpecialCard
{
	// Token: 0x060008B2 RID: 2226 RVA: 0x0002CA4C File Offset: 0x0002AC4C
	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x8F6780", Offset = "0x8F4D80", VA = "0x1808F6780", Slot = "10")]
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

	// Token: 0x060008B3 RID: 2227 RVA: 0x0002CAE8 File Offset: 0x0002ACE8
	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x8DF910", Offset = "0x8DDF10", VA = "0x1808DF910")]
	public ElementChaosCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
