using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001FC RID: 508
[Token(Token = "0x20001FC")]
public class ElementDefenceCard : SpecialCard
{
	// Token: 0x0600089A RID: 2202 RVA: 0x0002CADC File Offset: 0x0002ACDC
	[Token(Token = "0x600089A")]
	[Address(RVA = "0x867D80", Offset = "0x866380", VA = "0x180867D80", Slot = "10")]
	public override void ClickedEvent()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
		GameAPP.PlaySound(125, 0.5f, 1f);
		List<PlantType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		PlantType random = ListExtensions.GetRandom<PlantType>(list);
		ParticleManager instance = ParticleManager.Instance;
		DroppedCard droppedCard;
		Transform transform = droppedCard.transform;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)62), num, 11, num3 != 0UL, (float)num2);
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x0002CB8C File Offset: 0x0002AD8C
	[Token(Token = "0x600089B")]
	[Address(RVA = "0x8516E0", Offset = "0x84FCE0", VA = "0x1808516E0")]
	public ElementDefenceCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
