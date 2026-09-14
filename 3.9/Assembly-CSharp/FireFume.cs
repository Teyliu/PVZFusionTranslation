using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000515 RID: 1301
[Token(Token = "0x2000515")]
public class FireFume : FumeShroom
{
	// Token: 0x06001861 RID: 6241 RVA: 0x000845DC File Offset: 0x000827DC
	[Token(Token = "0x6001861")]
	[Address(RVA = "0x5230F0", Offset = "0x5216F0", VA = "0x1805230F0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		this.theStatus = (PlantStatus)((ulong)16L);
		Transform transform = base.transform.Find("Shoot").transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		Quaternion quaternion;
		GameAPP.PlaySound((int)quaternion.x, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06001862 RID: 6242 RVA: 0x0008463C File Offset: 0x0008283C
	[Token(Token = "0x6001862")]
	[Address(RVA = "0x5230B0", Offset = "0x5216B0", VA = "0x1805230B0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x00084650 File Offset: 0x00082850
	[Token(Token = "0x6001863")]
	[Address(RVA = "0x522E80", Offset = "0x521480", VA = "0x180522E80", Slot = "72")]
	protected override void AttackZombie()
	{
		int size = this.board.zombieArray._size;
		int num = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num];
			int num2 = 0;
			if (zombie != num2)
			{
				Transform axis = zombie.axis;
				Transform axis2 = this.axis;
				Transform axis3 = zombie.axis;
				Transform axis4 = this.axis;
				if (base.SearchUniqueZombie(zombie))
				{
					int thePlantRow = this.thePlantRow;
					if (zombie.theZombieRow == thePlantRow)
					{
						PlantType thePlantType = this.thePlantType;
						zombie.SetJalaed();
					}
				}
			}
		}
	}

	// Token: 0x06001864 RID: 6244 RVA: 0x000846E8 File Offset: 0x000828E8
	[Token(Token = "0x6001864")]
	[Address(RVA = "0x523270", Offset = "0x521870", VA = "0x180523270")]
	public FireFume()
	{
		this.range = 7f;
		base..ctor();
	}
}
