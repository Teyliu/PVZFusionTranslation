using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006EC RID: 1772
[Token(Token = "0x20006EC")]
public class PogoZombie : Zombie
{
	// Token: 0x060022A1 RID: 8865 RVA: 0x000B57E0 File Offset: 0x000B39E0
	[Token(Token = "0x60022A1")]
	[Address(RVA = "0x5B7430", Offset = "0x5B5A30", VA = "0x1805B7430", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)14L);
	}

	// Token: 0x060022A2 RID: 8866 RVA: 0x000B5800 File Offset: 0x000B3A00
	[Token(Token = "0x60022A2")]
	[Address(RVA = "0x5CADE0", Offset = "0x5C93E0", VA = "0x1805CADE0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		float num = global::UnityEngine.Random.Range(1.1f, 1.4f);
		anim.SetFloat("jumpSpeed", num);
	}

	// Token: 0x060022A3 RID: 8867 RVA: 0x000B583C File Offset: 0x000B3A3C
	[Token(Token = "0x60022A3")]
	[Address(RVA = "0x5CA920", Offset = "0x5C8F20", VA = "0x1805CA920")]
	private void LandSound()
	{
		GameAPP.PlaySound(109, 0.5f, 1f);
		if (this.pause)
		{
			if (this.startJump)
			{
				this.pause = false;
				this.wait = (int)((ulong)2L);
			}
			this.startJump = true;
		}
		if (this.wait > 0)
		{
		}
	}

	// Token: 0x060022A4 RID: 8868 RVA: 0x000B588C File Offset: 0x000B3A8C
	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x5CA370", Offset = "0x5C8970", VA = "0x1805CA370", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Transform transform = arm.transform;
		int num = 0;
		Sprite sprite = transform.GetChild(num).GetComponent<SpriteRenderer>().sprite;
		component.sprite = sprite;
		Transform transform2 = base.transform;
		int num2 = 0;
		SpriteRenderer component2 = transform2.GetChild(num2).GetComponent<SpriteRenderer>();
		int num3 = 0;
		component2.enabled = num3 != 0;
		Transform transform3 = base.transform;
		int num4 = 0;
		Transform child = transform3.GetChild(num4);
		int num5 = 0;
		child.GetChild(num5).GetComponent<SpriteRenderer>().enabled = true;
	}

	// Token: 0x060022A5 RID: 8869 RVA: 0x000B591C File Offset: 0x000B3B1C
	[Token(Token = "0x60022A5")]
	[Address(RVA = "0x5CA4E0", Offset = "0x5C8AE0", VA = "0x1805CA4E0", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (this.wait == 0)
		{
			this.PoloUpdate();
			return;
		}
	}

	// Token: 0x060022A6 RID: 8870 RVA: 0x000B5940 File Offset: 0x000B3B40
	[Token(Token = "0x60022A6")]
	[Address(RVA = "0x5CAB70", Offset = "0x5C9170", VA = "0x1805CAB70")]
	private void PoloUpdate()
	{
		Transform axis = this.axis;
		int num = 0;
		Transform axis2 = this.axis;
		LayerMask plantLayer = this.plantLayer;
		Vector3 vector;
		float y = vector.y;
		this.jumpPos2.y = y;
		int num2 = plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				Transform axis3 = this.axis;
			}
			num++;
			Rigidbody2D rb = this.rb;
			this.pause = true;
			this.wait = (int)((ulong)2L);
		}
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x000B59C8 File Offset: 0x000B3BC8
	[Token(Token = "0x60022A7")]
	[Address(RVA = "0x5CA9C0", Offset = "0x5C8FC0", VA = "0x1805CA9C0", Slot = "34")]
	protected override void LoseHeadEvent()
	{
		base.ZombieUpdate();
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x000B59DC File Offset: 0x000B3BDC
	[Token(Token = "0x60022A8")]
	[Address(RVA = "0x5CA520", Offset = "0x5C8B20", VA = "0x1805CA520")]
	private void JumpFail()
	{
		int num = 0;
		if (this.wait == 1 && (this.pause ? 1 : 0) == num)
		{
			Transform axis = this.axis;
			LayerMask plantLayer = this.plantLayer;
			int num2 = plantLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int theZombieRow = this.theZombieRow;
					Transform axis2 = this.axis;
				}
				num++;
				Transform axis3 = this.axis;
				uint num3;
				GameAPP.PlaySound((int)num3, 0.5f, 1f);
				int num4 = 0;
				this.LoseJumper(num4);
				base.AdjustPosition(num4);
				GameObject[] particlePrefab = GameAPP.particlePrefab;
				Transform axis4 = this.axis;
				GameObject gameObject = particlePrefab[23];
				Transform axis5 = this.axis;
				int num5 = 0;
				Board board = this.board;
				int num6 = 0;
				Transform transform = board.transform;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num6, num5, transform);
			}
		}
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x000B5AC0 File Offset: 0x000B3CC0
	[Token(Token = "0x60022A9")]
	[Address(RVA = "0x5CAA00", Offset = "0x5C9000", VA = "0x1805CAA00", Slot = "76")]
	public virtual void LoseJumper(int reason = 0)
	{
		global::UnityEngine.Object.Destroy(this.theUniqueItems[1]);
		global::UnityEngine.Object.Destroy(this.theUniqueItems[2]);
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num = 0;
		int num2 = 0;
		theUniqueItems[num2] = num;
		int num3 = 0;
		this.theUniqueItemType = (Zombie.UniqueItemType)num3;
		this.theStatus = (ZombieStatus)num3;
		this.anim.SetTrigger("walk");
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x000B5B34 File Offset: 0x000B3D34
	[Token(Token = "0x60022AA")]
	[Address(RVA = "0x5B7510", Offset = "0x5B5B10", VA = "0x1805B7510", Slot = "25")]
	public override void ChangeRow(int theTargetRow)
	{
		base.ChangeRow(theTargetRow);
	}

	// Token: 0x060022AB RID: 8875 RVA: 0x000B5B4C File Offset: 0x000B3D4C
	[Token(Token = "0x60022AB")]
	[Address(RVA = "0x5B7DE0", Offset = "0x5B63E0", VA = "0x1805B7DE0", Slot = "22")]
	protected override void PositionUpdate()
	{
		if (!this.pause)
		{
			if (this.wait != 0)
			{
			}
			Board board = this.board;
			Transform axis = this.axis;
			Rigidbody2D rb = this.rb;
			int num = 0;
			Vector2 velocity = rb.velocity;
			this.rb.velocity = num;
		}
	}

	// Token: 0x060022AC RID: 8876 RVA: 0x000B5BBC File Offset: 0x000B3DBC
	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x5B43D0", Offset = "0x5B29D0", VA = "0x1805B43D0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x060022AD RID: 8877 RVA: 0x000B5BE0 File Offset: 0x000B3DE0
	[Token(Token = "0x60022AD")]
	[Address(RVA = "0x5B7FA0", Offset = "0x5B65A0", VA = "0x1805B7FA0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x000B5C08 File Offset: 0x000B3E08
	[Token(Token = "0x60022AE")]
	[Address(RVA = "0x5CAE50", Offset = "0x5C9450", VA = "0x1805CAE50")]
	public PogoZombie()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x040011E1 RID: 4577
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011E1")]
	private Vector2 jumpPos2;

	// Token: 0x040011E2 RID: 4578
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011E2")]
	private Vector2 range = (ulong)1065353216L;

	// Token: 0x040011E3 RID: 4579
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x40011E3")]
	private bool pause;

	// Token: 0x040011E4 RID: 4580
	[FieldOffset(Offset = "0x289")]
	[Token(Token = "0x40011E4")]
	private bool startJump;

	// Token: 0x040011E5 RID: 4581
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x40011E5")]
	[SerializeField]
	private int wait;
}
