using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200013F RID: 319
[Token(Token = "0x200013F")]
public class Bullet_firePea_purple : Bullet_firePea
{
	// Token: 0x060005F9 RID: 1529 RVA: 0x00020070 File Offset: 0x0001E270
	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x6C3050", Offset = "0x6C1650", VA = "0x1806C3050", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Board board = this.board;
		int num3 = this._damage;
		num3 += num3;
		PlantType fromType = this.fromType;
		Transform transform2 = base.transform;
		LayerMask zombieLayer = this.zombieLayer;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType fromType2 = this.fromType;
		Transform transform3 = base.transform;
		int num4 = this._damage;
		num4 += num4;
		Vector3 vector3;
		float z3 = vector3.z;
		PlantType fromType3 = this.fromType;
		base.Die();
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x0002011C File Offset: 0x0001E31C
	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x6C3330", Offset = "0x6C1930", VA = "0x1806C3330")]
	private void SetEmbered(Zombie zombie)
	{
		throw new NullReferenceException();
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00020130 File Offset: 0x0001E330
	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_firePea_purple()
	{
	}
}
