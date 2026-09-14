using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000709 RID: 1801
[Token(Token = "0x2000709")]
public class Submarine_b : Submarine_a
{
	// Token: 0x0600237B RID: 9083 RVA: 0x000B935C File Offset: 0x000B755C
	[Token(Token = "0x600237B")]
	[Address(RVA = "0x5D6510", Offset = "0x5D4B10", VA = "0x1805D6510", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x0600237C RID: 9084 RVA: 0x000B9384 File Offset: 0x000B7584
	[Token(Token = "0x600237C")]
	[Address(RVA = "0x5D64B0", Offset = "0x5D4AB0", VA = "0x1805D64B0", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x0600237D RID: 9085 RVA: 0x000B93B4 File Offset: 0x000B75B4
	[Token(Token = "0x600237D")]
	[Address(RVA = "0x5D6230", Offset = "0x5D4830", VA = "0x1805D6230", Slot = "76")]
	protected virtual void AnimShoot()
	{
		Transform shoot = this.shoot;
		GameObject gameObject = this.bulletPrefab;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		SpiderWeapon component = gameObject2.GetComponent<SpiderWeapon>();
		int theZombieRow = this.theZombieRow;
		component.theRow = theZombieRow;
		Board board = this.board;
		component.board = board;
		SpriteRenderer component2 = component.GetComponent<SpriteRenderer>();
		int theZombieRow2 = this.theZombieRow;
		string text = string.Format("bullet{0}", component2);
		component2.sortingLayerName = text;
		Rigidbody2D rb = component.rb;
		float num = global::UnityEngine.Random.Range(-5f, -4f);
		Rigidbody2D rb2 = this.rb;
		int num2 = 0;
		Vector2 velocity = rb2.velocity;
		float num3 = global::UnityEngine.Random.Range(num, 4f);
		rb.velocity = num2;
	}

	// Token: 0x0600237E RID: 9086 RVA: 0x000B948C File Offset: 0x000B768C
	[Token(Token = "0x600237E")]
	[Address(RVA = "0x5D61B0", Offset = "0x5D47B0", VA = "0x1805D61B0")]
	public Submarine_b()
	{
	}

	// Token: 0x04001201 RID: 4609
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001201")]
	public GameObject bulletPrefab;
}
