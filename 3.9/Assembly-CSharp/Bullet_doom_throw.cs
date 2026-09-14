using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000139 RID: 313
[Token(Token = "0x2000139")]
public class Bullet_doom_throw : Bullet
{
	// Token: 0x060005D6 RID: 1494 RVA: 0x0001EB04 File Offset: 0x0001CD04
	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x6EBA00", Offset = "0x6EA000", VA = "0x1806EBA00", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		float trackSpeed = this.trackSpeed;
		float deltaTime = Time.deltaTime;
		Transform child2 = base.transform.GetChild(1);
		float trackSpeed2 = this.trackSpeed;
		float deltaTime2 = Time.deltaTime;
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x0001EB60 File Offset: 0x0001CD60
	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x6EB9F0", Offset = "0x6E9FF0", VA = "0x1806EB9F0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		this.Explode();
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x0001EB74 File Offset: 0x0001CD74
	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x6EB9F0", Offset = "0x6E9FF0", VA = "0x1806EB9F0", Slot = "17")]
	public override void HitLand()
	{
		this.Explode();
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0001EB88 File Offset: 0x0001CD88
	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x6EB6A0", Offset = "0x6E9CA0", VA = "0x1806EB6A0")]
	private void Explode()
	{
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Transform transform3 = base.transform;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				PlantType fromType = this.fromType;
			}
			num++;
			BoardAction boardAction = this.board.boardAction;
			Transform transform4 = base.transform;
			PlantType fromType2 = this.fromType;
			int damage = this._damage;
		}
		base.Die();
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0001EC28 File Offset: 0x0001CE28
	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_doom_throw()
	{
	}
}
