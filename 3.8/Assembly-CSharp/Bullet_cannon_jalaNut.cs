using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000129 RID: 297
[Token(Token = "0x2000129")]
public class Bullet_cannon_jalaNut : Bullet_cannon
{
	// Token: 0x060005AC RID: 1452 RVA: 0x0001E9E0 File Offset: 0x0001CBE0
	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x6BE9D0", Offset = "0x6BCFD0", VA = "0x1806BE9D0", Slot = "13")]
	protected override bool CannonEffect()
	{
		Board board = this.board;
		if (this.board.cannonNutCount < 8)
		{
		}
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		GameObject gameObject = this.prefab;
		Transform transform = Board.Instance.transform;
		NutItem component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<NutItem>();
		int damage = this._damage;
		component.damage = damage;
		throw new NullReferenceException();
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x0001EA4C File Offset: 0x0001CC4C
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_cannon_jalaNut()
	{
	}

	// Token: 0x04000368 RID: 872
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000368")]
	public GameObject prefab;
}
