using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200012E RID: 302
[Token(Token = "0x200012E")]
public class Bullet_cannon_jalaNut : Bullet_cannon
{
	// Token: 0x060005B3 RID: 1459 RVA: 0x0001E1B0 File Offset: 0x0001C3B0
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x6E9790", Offset = "0x6E7D90", VA = "0x1806E9790", Slot = "14")]
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

	// Token: 0x060005B4 RID: 1460 RVA: 0x0001E21C File Offset: 0x0001C41C
	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cannon_jalaNut()
	{
	}

	// Token: 0x0400036F RID: 879
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400036F")]
	public GameObject prefab;
}
