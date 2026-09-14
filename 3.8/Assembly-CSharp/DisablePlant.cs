using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002BA RID: 698
[Token(Token = "0x20002BA")]
public class DisablePlant : MonoBehaviour
{
	// Token: 0x06000C49 RID: 3145 RVA: 0x00046CC0 File Offset: 0x00044EC0
	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x3D38F0", Offset = "0x3D1EF0", VA = "0x1803D38F0")]
	private void Start()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x00046CDC File Offset: 0x00044EDC
	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x3D3940", Offset = "0x3D1F40", VA = "0x1803D3940")]
	private void Update()
	{
		Zombie zombie = this.Zombie;
		int num = 0;
		if (zombie != num)
		{
			Zombie zombie2 = this.Zombie;
			if (zombie2.isMindControlled || zombie2.beforeDying || zombie2.theStatus == ZombieStatus.Dying)
			{
				Collider2D collider2D = this.col;
				int num2 = 0;
				collider2D.enabled = num2 != 0;
			}
		}
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x00046D38 File Offset: 0x00044F38
	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x3D35B0", Offset = "0x3D1BB0", VA = "0x1803D35B0")]
	private bool CheckRow(Plant plant)
	{
		Zombie zombie = this.Zombie;
		return plant.thePlantRow <= this.nearRow;
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x00046D64 File Offset: 0x00044F64
	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x3D3700", Offset = "0x3D1D00", VA = "0x1803D3700")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		Zombie zombie = this.Zombie;
		int num = 0;
		bool flag;
		if (!(zombie == num) && flag)
		{
			Zombie zombie2 = this.Zombie;
			HashSet<Plant> hashSet = this.disabledPlants;
			int num2 = this.nearRow;
			bool flag2;
			if (!flag2)
			{
				HashSet<Plant> hashSet2 = this.disabledPlants;
				throw new NullReferenceException();
			}
			if (zombie > num2)
			{
				HashSet<Plant> hashSet3 = this.disabledPlants;
			}
		}
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x00046DC4 File Offset: 0x00044FC4
	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x3D3630", Offset = "0x3D1C30", VA = "0x1803D3630")]
	private void OnTriggerExit2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			HashSet<Plant> hashSet = this.disabledPlants;
			bool flag2;
			if (flag2)
			{
				HashSet<Plant> hashSet2 = this.disabledPlants;
			}
		}
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x00046DF0 File Offset: 0x00044FF0
	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x3D39E0", Offset = "0x3D1FE0", VA = "0x1803D39E0")]
	public DisablePlant()
	{
		HashSet<Plant> hashSet = new HashSet();
		this.disabledPlants = hashSet;
		base..ctor();
	}

	// Token: 0x0400086C RID: 2156
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400086C")]
	private Collider2D col;

	// Token: 0x0400086D RID: 2157
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400086D")]
	public Zombie Zombie;

	// Token: 0x0400086E RID: 2158
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400086E")]
	public int nearRow;

	// Token: 0x0400086F RID: 2159
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400086F")]
	private readonly HashSet<Plant> disabledPlants;
}
