using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000471 RID: 1137
[Token(Token = "0x2000471")]
public class UltimateHypnoDoom : Plant
{
	// Token: 0x06001515 RID: 5397 RVA: 0x00074DB4 File Offset: 0x00072FB4
	[Token(Token = "0x6001515")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x00074DD4 File Offset: 0x00072FD4
	[Token(Token = "0x6001516")]
	[Address(RVA = "0x486EF0", Offset = "0x4854F0", VA = "0x180486EF0", Slot = "40")]
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

	// Token: 0x06001517 RID: 5399 RVA: 0x00074E8C File Offset: 0x0007308C
	[Token(Token = "0x6001517")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public UltimateHypnoDoom()
	{
	}
}
