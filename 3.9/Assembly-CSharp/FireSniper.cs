using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000518 RID: 1304
[Token(Token = "0x2000518")]
public class FireSniper : SniperPea
{
	// Token: 0x0600186A RID: 6250 RVA: 0x00084874 File Offset: 0x00082A74
	[Token(Token = "0x600186A")]
	[Address(RVA = "0x523790", Offset = "0x521D90", VA = "0x180523790", Slot = "72")]
	protected override void AttackZombie(Zombie zombie, int damage, DamageType theDamageType = DamageType.Shieldless)
	{
		Board board = this.board;
		if (theDamageType == DamageType.MaxDamage)
		{
		}
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(damage, this, theDamageType, thePlantType, num != 0UL);
		zombie.SetJalaed();
		int num2 = 0;
		ulong num3;
		uint num4;
		zombie.JalaedExplode(num3 != 0UL, (int)num4, num2 != 0);
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x000848BC File Offset: 0x00082ABC
	[Token(Token = "0x600186B")]
	[Address(RVA = "0x5238E0", Offset = "0x521EE0", VA = "0x1805238E0", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		int num = this.restPointCount;
		return base.OnClicked(mouse);
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x000848E0 File Offset: 0x00082AE0
	[Token(Token = "0x600186C")]
	[Address(RVA = "0x523700", Offset = "0x521D00", VA = "0x180523700")]
	public void AddWallCount(int count)
	{
		FirePoint firePoint = this.main;
		int num = 0;
		if (firePoint != num)
		{
			this.main.Die();
		}
		this.usedCount = (int)((ulong)0L);
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x0008491C File Offset: 0x00082B1C
	[Token(Token = "0x600186D")]
	[Address(RVA = "0x523910", Offset = "0x521F10", VA = "0x180523910", Slot = "62")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		int num = 0;
		FirePoint firePoint = this.main;
		int num2 = 0;
		bool flag = firePoint == num2;
		FirePoint firePoint2 = this.pointPrefab;
		if (!flag)
		{
			Vector2 mousePosition = mouse.MousePosition;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			int num3 = this.shootingLevel;
			num3 += 4;
			FirePoint firePoint3;
			firePoint3.density = num3;
			FirePoint tail = this.main.Tail;
			tail.next = firePoint3;
			tail.GenerateFireWalls(this);
			if (!firePoint3.TryGetComponent<FireWall>(num))
			{
				FireWall fireWall = firePoint3.AddComponent<FireWall>();
			}
		}
		Vector2 mousePosition2 = mouse.MousePosition;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		Transform transform2 = this.board.transform;
		FirePoint firePoint4;
		this.main = firePoint4;
		FirePoint firePoint5 = this.main;
		int num4 = this.shootingLevel;
		num4 += 4;
		firePoint5.density = num4;
		if (!this.main.TryGetComponent<FireWall>(num))
		{
			FireWall fireWall2 = this.main.AddComponent<FireWall>();
		}
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x00084A1C File Offset: 0x00082C1C
	[Token(Token = "0x600186E")]
	[Address(RVA = "0x523850", Offset = "0x521E50", VA = "0x180523850", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num = 0;
		base.OnCreate((int)reason, num);
		FirePoint firePoint = this.main;
		int num2 = 0;
		if (firePoint != num2)
		{
			this.main.Die();
		}
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x00084A5C File Offset: 0x00082C5C
	[Token(Token = "0x600186F")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public FireSniper()
	{
	}

	// Token: 0x04000E69 RID: 3689
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000E69")]
	public FirePoint pointPrefab;

	// Token: 0x04000E6A RID: 3690
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000E6A")]
	public int restPointCount;

	// Token: 0x04000E6B RID: 3691
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000E6B")]
	private int usedCount;

	// Token: 0x04000E6C RID: 3692
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000E6C")]
	public FirePoint main;
}
