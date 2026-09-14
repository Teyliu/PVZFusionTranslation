using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004ED RID: 1261
[Token(Token = "0x20004ED")]
public class FireFume : FumeShroom
{
	// Token: 0x060017AA RID: 6058 RVA: 0x00081394 File Offset: 0x0007F594
	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x4C7DB0", Offset = "0x4C63B0", VA = "0x1804C7DB0", Slot = "69")]
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

	// Token: 0x060017AB RID: 6059 RVA: 0x000813F4 File Offset: 0x0007F5F4
	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x4C7D70", Offset = "0x4C6370", VA = "0x1804C7D70", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x00081408 File Offset: 0x0007F608
	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x4C7B40", Offset = "0x4C6140", VA = "0x1804C7B40", Slot = "73")]
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

	// Token: 0x060017AD RID: 6061 RVA: 0x000814A0 File Offset: 0x0007F6A0
	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x4C7F30", Offset = "0x4C6530", VA = "0x1804C7F30")]
	public FireFume()
	{
		this.range = 7f;
		base..ctor();
	}
}
