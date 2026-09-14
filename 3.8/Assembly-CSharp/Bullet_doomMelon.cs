using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000133 RID: 307
[Token(Token = "0x2000133")]
public class Bullet_doomMelon : Bullet_melon
{
	// Token: 0x060005CC RID: 1484 RVA: 0x0001F220 File Offset: 0x0001D420
	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x6BFFC0", Offset = "0x6BE5C0", VA = "0x1806BFFC0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		this.hit = false;
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0001F234 File Offset: 0x0001D434
	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x6BFBE0", Offset = "0x6BE1E0", VA = "0x1806BFBE0", Slot = "18")]
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

	// Token: 0x060005CE RID: 1486 RVA: 0x0001F324 File Offset: 0x0001D524
	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x6BFFD0", Offset = "0x6BE5D0", VA = "0x1806BFFD0")]
	public Bullet_doomMelon()
	{
	}
}
