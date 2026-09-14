using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068B RID: 1675
[Token(Token = "0x200068B")]
public class Jackbox_a : Zombie
{
	// Token: 0x0600204B RID: 8267 RVA: 0x000AAEDC File Offset: 0x000A90DC
	[Token(Token = "0x600204B")]
	[Address(RVA = "0x553890", Offset = "0x551E90", VA = "0x180553890", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)14L);
	}

	// Token: 0x0600204C RID: 8268 RVA: 0x000AAEFC File Offset: 0x000A90FC
	[Token(Token = "0x600204C")]
	[Address(RVA = "0x554450", Offset = "0x552A50", VA = "0x180554450", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		float num = global::UnityEngine.Random.Range(1.1f, 1.4f);
		anim.SetFloat("jumpSpeed", num);
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x000AAF38 File Offset: 0x000A9138
	[Token(Token = "0x600204D")]
	[Address(RVA = "0x553DC0", Offset = "0x5523C0", VA = "0x180553DC0")]
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

	// Token: 0x0600204E RID: 8270 RVA: 0x000AAF88 File Offset: 0x000A9188
	[Token(Token = "0x600204E")]
	[Address(RVA = "0x5538D0", Offset = "0x551ED0", VA = "0x1805538D0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x000AAFC8 File Offset: 0x000A91C8
	[Token(Token = "0x600204F")]
	[Address(RVA = "0x5538B0", Offset = "0x551EB0", VA = "0x1805538B0", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return base.CanAttack(target);
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x000AAFE0 File Offset: 0x000A91E0
	[Token(Token = "0x6002050")]
	[Address(RVA = "0x553980", Offset = "0x551F80", VA = "0x180553980", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (this.wait == 0)
		{
			this.PoloUpdate();
			return;
		}
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x000AB004 File Offset: 0x000A9204
	[Token(Token = "0x6002051")]
	[Address(RVA = "0x553FD0", Offset = "0x5525D0", VA = "0x180553FD0")]
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

	// Token: 0x06002052 RID: 8274 RVA: 0x000AB08C File Offset: 0x000A928C
	[Token(Token = "0x6002052")]
	[Address(RVA = "0x553E60", Offset = "0x552460", VA = "0x180553E60", Slot = "33")]
	protected override void LoseHeadEvent()
	{
		Transform axis = this.axis;
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x000AB0AC File Offset: 0x000A92AC
	[Token(Token = "0x6002053")]
	[Address(RVA = "0x5539C0", Offset = "0x551FC0", VA = "0x1805539C0")]
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
				this.LoseJumper();
				GameObject[] particlePrefab = GameAPP.particlePrefab;
				Transform axis4 = this.axis;
				GameObject gameObject = particlePrefab[23];
				Transform axis5 = this.axis;
				int num4 = 0;
				Board board = this.board;
				int num5 = 0;
				Transform transform = board.transform;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num5, num4, transform);
			}
		}
	}

	// Token: 0x06002054 RID: 8276 RVA: 0x000AB180 File Offset: 0x000A9380
	[Token(Token = "0x6002054")]
	[Address(RVA = "0x553F20", Offset = "0x552520", VA = "0x180553F20", Slot = "74")]
	public virtual void LoseJumper()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		this.anim.SetTrigger("walk");
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x000AB1B4 File Offset: 0x000A93B4
	[Token(Token = "0x6002055")]
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

	// Token: 0x06002056 RID: 8278 RVA: 0x000AB224 File Offset: 0x000A9424
	[Token(Token = "0x6002056")]
	[Address(RVA = "0x553970", Offset = "0x551F70", VA = "0x180553970", Slot = "24")]
	public override void ChangeRow(int theTargetRow)
	{
		base.ChangeRow(theTargetRow);
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x000AB23C File Offset: 0x000A943C
	[Token(Token = "0x6002057")]
	[Address(RVA = "0x550840", Offset = "0x54EE40", VA = "0x180550840", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002058 RID: 8280 RVA: 0x000AB260 File Offset: 0x000A9460
	[Token(Token = "0x6002058")]
	[Address(RVA = "0x554400", Offset = "0x552A00", VA = "0x180554400", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x06002059 RID: 8281 RVA: 0x000AB288 File Offset: 0x000A9488
	[Token(Token = "0x6002059")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x000AB2C4 File Offset: 0x000A94C4
	[Token(Token = "0x600205A")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x000AB2D4 File Offset: 0x000A94D4
	[Token(Token = "0x600205B")]
	[Address(RVA = "0x5544C0", Offset = "0x552AC0", VA = "0x1805544C0")]
	public Jackbox_a()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x040010C9 RID: 4297
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x40010C9")]
	private Vector2 jumpPos2;

	// Token: 0x040010CA RID: 4298
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010CA")]
	private Vector2 range = (ulong)1065353216L;

	// Token: 0x040010CB RID: 4299
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x40010CB")]
	private bool pause;

	// Token: 0x040010CC RID: 4300
	[FieldOffset(Offset = "0x269")]
	[Token(Token = "0x40010CC")]
	private bool startJump;

	// Token: 0x040010CD RID: 4301
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x40010CD")]
	[SerializeField]
	private int wait;
}
