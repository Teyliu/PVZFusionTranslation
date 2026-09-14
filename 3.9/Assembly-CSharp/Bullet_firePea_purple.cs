using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000144 RID: 324
[Token(Token = "0x2000144")]
public class Bullet_firePea_purple : Bullet_firePea
{
	// Token: 0x06000600 RID: 1536 RVA: 0x0001F858 File Offset: 0x0001DA58
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x6EDE30", Offset = "0x6EC430", VA = "0x1806EDE30", Slot = "22")]
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

	// Token: 0x06000601 RID: 1537 RVA: 0x0001F904 File Offset: 0x0001DB04
	[Token(Token = "0x6000601")]
	[Address(RVA = "0x6EE110", Offset = "0x6EC710", VA = "0x1806EE110")]
	private void SetEmbered(Zombie zombie)
	{
		throw new NullReferenceException();
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0001F918 File Offset: 0x0001DB18
	[Token(Token = "0x6000602")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_firePea_purple()
	{
	}
}
