using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006B5 RID: 1717
[Token(Token = "0x20006B5")]
public class PogoZombie : Zombie
{
	// Token: 0x0600218A RID: 8586 RVA: 0x000B0B30 File Offset: 0x000AED30
	[Token(Token = "0x600218A")]
	[Address(RVA = "0x553890", Offset = "0x551E90", VA = "0x180553890", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)14L);
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x000B0B50 File Offset: 0x000AED50
	[Token(Token = "0x600218B")]
	[Address(RVA = "0x567530", Offset = "0x565B30", VA = "0x180567530", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		float num = global::UnityEngine.Random.Range(1.1f, 1.4f);
		anim.SetFloat("jumpSpeed", num);
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x000B0B8C File Offset: 0x000AED8C
	[Token(Token = "0x600218C")]
	[Address(RVA = "0x567070", Offset = "0x565670", VA = "0x180567070")]
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

	// Token: 0x0600218D RID: 8589 RVA: 0x000B0BDC File Offset: 0x000AEDDC
	[Token(Token = "0x600218D")]
	[Address(RVA = "0x566AC0", Offset = "0x5650C0", VA = "0x180566AC0", Slot = "36")]
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

	// Token: 0x0600218E RID: 8590 RVA: 0x000B0C6C File Offset: 0x000AEE6C
	[Token(Token = "0x600218E")]
	[Address(RVA = "0x566C30", Offset = "0x565230", VA = "0x180566C30", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (this.wait == 0)
		{
			this.PoloUpdate();
			return;
		}
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x000B0C90 File Offset: 0x000AEE90
	[Token(Token = "0x600218F")]
	[Address(RVA = "0x5672C0", Offset = "0x5658C0", VA = "0x1805672C0")]
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

	// Token: 0x06002190 RID: 8592 RVA: 0x000B0D18 File Offset: 0x000AEF18
	[Token(Token = "0x6002190")]
	[Address(RVA = "0x567110", Offset = "0x565710", VA = "0x180567110", Slot = "33")]
	protected override void LoseHeadEvent()
	{
		base.ZombieUpdate();
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x000B0D2C File Offset: 0x000AEF2C
	[Token(Token = "0x6002191")]
	[Address(RVA = "0x566C70", Offset = "0x565270", VA = "0x180566C70")]
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

	// Token: 0x06002192 RID: 8594 RVA: 0x000B0E10 File Offset: 0x000AF010
	[Token(Token = "0x6002192")]
	[Address(RVA = "0x567150", Offset = "0x565750", VA = "0x180567150", Slot = "74")]
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

	// Token: 0x06002193 RID: 8595 RVA: 0x000B0E84 File Offset: 0x000AF084
	[Token(Token = "0x6002193")]
	[Address(RVA = "0x553970", Offset = "0x551F70", VA = "0x180553970", Slot = "24")]
	public override void ChangeRow(int theTargetRow)
	{
		base.ChangeRow(theTargetRow);
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x000B0E9C File Offset: 0x000AF09C
	[Token(Token = "0x6002194")]
	[Address(RVA = "0x554240", Offset = "0x552840", VA = "0x180554240", Slot = "21")]
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

	// Token: 0x06002195 RID: 8597 RVA: 0x000B0F0C File Offset: 0x000AF10C
	[Token(Token = "0x6002195")]
	[Address(RVA = "0x550840", Offset = "0x54EE40", VA = "0x180550840", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x000B0F30 File Offset: 0x000AF130
	[Token(Token = "0x6002196")]
	[Address(RVA = "0x554400", Offset = "0x552A00", VA = "0x180554400", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x000B0F58 File Offset: 0x000AF158
	[Token(Token = "0x6002197")]
	[Address(RVA = "0x5675A0", Offset = "0x565BA0", VA = "0x1805675A0")]
	public PogoZombie()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04001114 RID: 4372
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001114")]
	private Vector2 jumpPos2;

	// Token: 0x04001115 RID: 4373
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001115")]
	private Vector2 range = (ulong)1065353216L;

	// Token: 0x04001116 RID: 4374
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001116")]
	private bool pause;

	// Token: 0x04001117 RID: 4375
	[FieldOffset(Offset = "0x269")]
	[Token(Token = "0x4001117")]
	private bool startJump;

	// Token: 0x04001118 RID: 4376
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x4001118")]
	[SerializeField]
	private int wait;
}
