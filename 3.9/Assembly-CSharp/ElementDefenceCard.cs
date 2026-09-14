using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000203 RID: 515
[Token(Token = "0x2000203")]
public class ElementDefenceCard : SpecialCard
{
	// Token: 0x060008B4 RID: 2228 RVA: 0x0002CB08 File Offset: 0x0002AD08
	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x8F6AD0", Offset = "0x8F50D0", VA = "0x1808F6AD0", Slot = "10")]
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

	// Token: 0x060008B5 RID: 2229 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x8DF910", Offset = "0x8DDF10", VA = "0x1808DF910")]
	public ElementDefenceCard()
	{
		this.d = 1f;
		base..ctor();
	}
}
