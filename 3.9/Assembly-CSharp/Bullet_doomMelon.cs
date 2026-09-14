using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000138 RID: 312
[Token(Token = "0x2000138")]
public class Bullet_doomMelon : Bullet_melon
{
	// Token: 0x060005D3 RID: 1491 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x6EAD90", Offset = "0x6E9390", VA = "0x1806EAD90", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x0001EA00 File Offset: 0x0001CC00
	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x6EA9B0", Offset = "0x6E8FB0", VA = "0x1806EA9B0", Slot = "17")]
	public override void HitLand()
	{
		Mouse instance = Mouse.Instance;
		Transform transform = base.transform;
		Board board = this.board;
		int theBulletRow = this.theBulletRow;
		int num;
		BoardGrid grid = board.gridSystem.GetGrid(num, theBulletRow);
		if (this.board.gridSystem.GetBoxType(num, theBulletRow) != BoxType.Water)
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType fromType = this.fromType;
			int damage = this._damage;
			int num2 = 0;
			Crater crater;
			if (!(crater != num2))
			{
				goto IL_00D6;
			}
			ulong num3;
			crater.Embered = num3 != 0UL;
		}
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform3 = gameObject.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform transform4 = base.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		Vector3 vector4;
		float z4 = vector4.z;
		PlantType fromType2 = this.fromType;
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
		IL_00D6:
		base.Die();
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x0001EAF0 File Offset: 0x0001CCF0
	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x6EADA0", Offset = "0x6E93A0", VA = "0x1806EADA0")]
	public Bullet_doomMelon()
	{
	}
}
