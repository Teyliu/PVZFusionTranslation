using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000134 RID: 308
[Token(Token = "0x2000134")]
public class Bullet_doom_throw : Bullet
{
	// Token: 0x060005CF RID: 1487 RVA: 0x0001F338 File Offset: 0x0001D538
	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x6C0C30", Offset = "0x6BF230", VA = "0x1806C0C30", Slot = "11")]
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

	// Token: 0x060005D0 RID: 1488 RVA: 0x0001F394 File Offset: 0x0001D594
	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x6C0C20", Offset = "0x6BF220", VA = "0x1806C0C20", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		this.Explode();
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0001F3A8 File Offset: 0x0001D5A8
	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x6C0C20", Offset = "0x6BF220", VA = "0x1806C0C20", Slot = "18")]
	public override void HitLand()
	{
		this.Explode();
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0001F3BC File Offset: 0x0001D5BC
	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x6C08D0", Offset = "0x6BEED0", VA = "0x1806C08D0")]
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

	// Token: 0x060005D3 RID: 1491 RVA: 0x0001F45C File Offset: 0x0001D65C
	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_doom_throw()
	{
	}
}
