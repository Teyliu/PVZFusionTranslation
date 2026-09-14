using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200037D RID: 893
[Token(Token = "0x200037D")]
public class ChomperSquash : Squash
{
	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06001062 RID: 4194 RVA: 0x0005DC38 File Offset: 0x0005BE38
	[Token(Token = "0x1700011E")]
	protected override Vector2 Range
	{
		[Token(Token = "0x6001062")]
		[Address(RVA = "0x47D250", Offset = "0x47B850", VA = "0x18047D250", Slot = "68")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x0005DC50 File Offset: 0x0005BE50
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x47CDF0", Offset = "0x47B3F0", VA = "0x18047CDF0", Slot = "71")]
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

	// Token: 0x06001064 RID: 4196 RVA: 0x0005DC9C File Offset: 0x0005BE9C
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x47CEF0", Offset = "0x47B4F0", VA = "0x18047CEF0", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason != Plant.DieReason.ByShovel)
		{
			int columnNum = this.board.columnNum;
			Transform axis = this.axis;
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x0005DCD0 File Offset: 0x0005BED0
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x47D000", Offset = "0x47B600", VA = "0x18047D000", Slot = "69")]
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

	// Token: 0x06001066 RID: 4198 RVA: 0x0005DD38 File Offset: 0x0005BF38
	[Token(Token = "0x6001066")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public ChomperSquash()
	{
	}
}
