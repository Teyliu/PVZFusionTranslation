using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D1 RID: 1745
[Token(Token = "0x20006D1")]
public class Submarine_b : Submarine_a
{
	// Token: 0x06002261 RID: 8801 RVA: 0x000B45A0 File Offset: 0x000B27A0
	[Token(Token = "0x6002261")]
	[Address(RVA = "0x572EA0", Offset = "0x5714A0", VA = "0x180572EA0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.inWater = true;
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06002262 RID: 8802 RVA: 0x000B45C8 File Offset: 0x000B27C8
	[Token(Token = "0x6002262")]
	[Address(RVA = "0x572E40", Offset = "0x571440", VA = "0x180572E40", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("shoot");
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x000B45F8 File Offset: 0x000B27F8
	[Token(Token = "0x6002263")]
	[Address(RVA = "0x572BC0", Offset = "0x5711C0", VA = "0x180572BC0", Slot = "74")]
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

	// Token: 0x06002264 RID: 8804 RVA: 0x000B46D0 File Offset: 0x000B28D0
	[Token(Token = "0x6002264")]
	[Address(RVA = "0x572B40", Offset = "0x571140", VA = "0x180572B40")]
	public Submarine_b()
	{
	}

	// Token: 0x04001134 RID: 4404
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001134")]
	public GameObject bulletPrefab;
}
