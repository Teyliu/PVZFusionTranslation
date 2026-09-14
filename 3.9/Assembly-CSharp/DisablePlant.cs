using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002C5 RID: 709
[Token(Token = "0x20002C5")]
public class DisablePlant : MonoBehaviour
{
	// Token: 0x06000C72 RID: 3186 RVA: 0x00046FF4 File Offset: 0x000451F4
	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x420740", Offset = "0x41ED40", VA = "0x180420740")]
	private void Start()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x00047010 File Offset: 0x00045210
	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x420790", Offset = "0x41ED90", VA = "0x180420790")]
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

	// Token: 0x06000C74 RID: 3188 RVA: 0x0004706C File Offset: 0x0004526C
	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x420410", Offset = "0x41EA10", VA = "0x180420410")]
	private bool CheckRow(Plant plant)
	{
		Zombie zombie = this.Zombie;
		return plant.thePlantRow <= this.nearRow;
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x00047098 File Offset: 0x00045298
	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x420560", Offset = "0x41EB60", VA = "0x180420560")]
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
				int num3 = 0;
				ulong num4;
				string text = num4.ToString(num, num3);
				HashSet<Plant> hashSet2 = this.disabledPlants;
				throw new NullReferenceException();
			}
			if (zombie > num2)
			{
				HashSet<Plant> hashSet3 = this.disabledPlants;
			}
		}
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00047108 File Offset: 0x00045308
	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x420490", Offset = "0x41EA90", VA = "0x180420490")]
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

	// Token: 0x06000C77 RID: 3191 RVA: 0x00047138 File Offset: 0x00045338
	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x420830", Offset = "0x41EE30", VA = "0x180420830")]
	public DisablePlant()
	{
		HashSet<Plant> hashSet = new HashSet();
		this.disabledPlants = hashSet;
		base..ctor();
	}

	// Token: 0x0400088B RID: 2187
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400088B")]
	private Collider2D col;

	// Token: 0x0400088C RID: 2188
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400088C")]
	public Zombie Zombie;

	// Token: 0x0400088D RID: 2189
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400088D")]
	public int nearRow;

	// Token: 0x0400088E RID: 2190
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400088E")]
	private readonly HashSet<Plant> disabledPlants;
}
