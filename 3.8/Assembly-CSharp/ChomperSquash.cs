using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200036D RID: 877
[Token(Token = "0x200036D")]
public class ChomperSquash : Squash
{
	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06001017 RID: 4119 RVA: 0x0005CCB4 File Offset: 0x0005AEB4
	[Token(Token = "0x170000DB")]
	protected override Vector2 Range
	{
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x426560", Offset = "0x424B60", VA = "0x180426560", Slot = "69")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x0005CCCC File Offset: 0x0005AECC
	[Token(Token = "0x6001018")]
	[Address(RVA = "0x426100", Offset = "0x424700", VA = "0x180426100", Slot = "72")]
	protected override void ActionOnZombie(Zombie zombie)
	{
		int theZombieType = (int)zombie.theZombieType;
		bool flag;
		if (!flag)
		{
			zombie.Die(2);
			GameAPP.PlaySound((SoundType)((uint)49), 0.5f, 1f);
			this.theStatus = (PlantStatus)((ulong)25L);
			return;
		}
		base.ActionOnZombie(zombie);
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x0005CD18 File Offset: 0x0005AF18
	[Token(Token = "0x6001019")]
	[Address(RVA = "0x426200", Offset = "0x424800", VA = "0x180426200", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason != Plant.DieReason.ByShovel)
		{
			int columnNum = this.board.columnNum;
			Transform axis = this.axis;
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x0005CD4C File Offset: 0x0005AF4C
	[Token(Token = "0x600101A")]
	[Address(RVA = "0x426310", Offset = "0x424910", VA = "0x180426310", Slot = "70")]
	protected override void UpdateZombieList()
	{
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		Vector2 range = this.Range;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.ThrowLandStatus((ZombieStatus)num))
			{
				int thePlantRow = this.thePlantRow;
				List<Zombie> zombieList = this.zombieList;
			}
			num++;
		}
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x0005CDB4 File Offset: 0x0005AFB4
	[Token(Token = "0x600101B")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public ChomperSquash()
	{
	}
}
