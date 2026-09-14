using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004F6 RID: 1270
[Token(Token = "0x20004F6")]
public class CherryPuff : DoomPuff
{
	// Token: 0x060017EE RID: 6126 RVA: 0x00082D18 File Offset: 0x00080F18
	[Token(Token = "0x60017EE")]
	[Address(RVA = "0x51E570", Offset = "0x51CB70", VA = "0x18051E570", Slot = "68")]
	protected override void Explode()
	{
		int num = 0;
		this.exploded = true;
		GameAPP.PlaySound((SoundType)((uint)40), 0.5f, 1f);
		ScreenShake.TriggerShake(0.1f);
		bool set = num != 0;
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction = board.boardAction;
		Vector3 vector;
		float z = vector.z;
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x00082D94 File Offset: 0x00080F94
	[Token(Token = "0x60017EF")]
	[Address(RVA = "0x51E7E0", Offset = "0x51CDE0", VA = "0x18051E7E0")]
	protected void SetBomb(Zombie zombie)
	{
		Board board = this.board;
		GameObject gameObject = this.bombPrefab;
		Transform transform = board.transform;
		TimeBomb component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<TimeBomb>();
		Transform transform2 = component.transform;
		Collider2D col = zombie.col;
		Transform transform3 = component.transform;
		Transform transform4 = zombie.transform;
		transform3.parentInternal = transform4;
		component.zombie = zombie;
		int attackDamage = this.attackDamage;
		component.damage = attackDamage;
		zombie.timeBomb = component;
		PlantType thePlantType = this.thePlantType;
		component.fromType = thePlantType;
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x00082E24 File Offset: 0x00081024
	[Token(Token = "0x60017F0")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CherryPuff()
	{
	}

	// Token: 0x04000E5F RID: 3679
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000E5F")]
	public GameObject bombPrefab;
}
