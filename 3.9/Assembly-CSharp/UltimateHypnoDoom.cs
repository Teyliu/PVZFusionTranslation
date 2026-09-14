using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000493 RID: 1171
[Token(Token = "0x2000493")]
public class UltimateHypnoDoom : Plant
{
	// Token: 0x060015B4 RID: 5556 RVA: 0x00077738 File Offset: 0x00075938
	[Token(Token = "0x60015B4")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00077758 File Offset: 0x00075958
	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x4E02E0", Offset = "0x4DE8E0", VA = "0x1804E02E0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(41, 0.5f, 1f);
		if (!GameAPP.config.distablexplodeFlash)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
		}
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int random = (int)ListExtensions.GetRandom<ZombieType>(list);
		Transform axis2 = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2)
		{
			Zombie component = zombie.GetComponent<Zombie>();
			if (random == 223)
			{
				component.KillByCaltrop();
			}
		}
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x00077810 File Offset: 0x00075A10
	[Token(Token = "0x60015B6")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public UltimateHypnoDoom()
	{
	}
}
