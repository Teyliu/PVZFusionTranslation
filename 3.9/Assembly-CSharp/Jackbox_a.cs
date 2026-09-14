using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C1 RID: 1729
[Token(Token = "0x20006C1")]
public class Jackbox_a : Zombie
{
	// Token: 0x0600214D RID: 8525 RVA: 0x000AF808 File Offset: 0x000ADA08
	[Token(Token = "0x600214D")]
	[Address(RVA = "0x5B7430", Offset = "0x5B5A30", VA = "0x1805B7430", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)14L);
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x000AF828 File Offset: 0x000ADA28
	[Token(Token = "0x600214E")]
	[Address(RVA = "0x5B7FF0", Offset = "0x5B65F0", VA = "0x1805B7FF0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		Animator anim = this.anim;
		float num = global::UnityEngine.Random.Range(1.1f, 1.4f);
		anim.SetFloat("jumpSpeed", num);
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x000AF864 File Offset: 0x000ADA64
	[Token(Token = "0x600214F")]
	[Address(RVA = "0x5B7960", Offset = "0x5B5F60", VA = "0x1805B7960")]
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

	// Token: 0x06002150 RID: 8528 RVA: 0x000AF8B4 File Offset: 0x000ADAB4
	[Token(Token = "0x6002150")]
	[Address(RVA = "0x5B7470", Offset = "0x5B5A70", VA = "0x1805B7470", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x000AF8F4 File Offset: 0x000ADAF4
	[Token(Token = "0x6002151")]
	[Address(RVA = "0x5B7450", Offset = "0x5B5A50", VA = "0x1805B7450", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return base.CanAttack(target);
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x000AF90C File Offset: 0x000ADB0C
	[Token(Token = "0x6002152")]
	[Address(RVA = "0x5B7520", Offset = "0x5B5B20", VA = "0x1805B7520", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (this.wait == 0)
		{
			this.PoloUpdate();
			return;
		}
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x000AF930 File Offset: 0x000ADB30
	[Token(Token = "0x6002153")]
	[Address(RVA = "0x5B7B70", Offset = "0x5B6170", VA = "0x1805B7B70")]
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

	// Token: 0x06002154 RID: 8532 RVA: 0x000AF9B8 File Offset: 0x000ADBB8
	[Token(Token = "0x6002154")]
	[Address(RVA = "0x5B7A00", Offset = "0x5B6000", VA = "0x1805B7A00", Slot = "34")]
	protected override void LoseHeadEvent()
	{
		Transform axis = this.axis;
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x000AF9D8 File Offset: 0x000ADBD8
	[Token(Token = "0x6002155")]
	[Address(RVA = "0x5B7560", Offset = "0x5B5B60", VA = "0x1805B7560")]
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

	// Token: 0x06002156 RID: 8534 RVA: 0x000AFAAC File Offset: 0x000ADCAC
	[Token(Token = "0x6002156")]
	[Address(RVA = "0x5B7AC0", Offset = "0x5B60C0", VA = "0x1805B7AC0", Slot = "76")]
	public virtual void LoseJumper()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
		this.anim.SetTrigger("walk");
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x000AFAE0 File Offset: 0x000ADCE0
	[Token(Token = "0x6002157")]
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

	// Token: 0x06002158 RID: 8536 RVA: 0x000AFB50 File Offset: 0x000ADD50
	[Token(Token = "0x6002158")]
	[Address(RVA = "0x5B7510", Offset = "0x5B5B10", VA = "0x1805B7510", Slot = "25")]
	public override void ChangeRow(int theTargetRow)
	{
		base.ChangeRow(theTargetRow);
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x000AFB68 File Offset: 0x000ADD68
	[Token(Token = "0x6002159")]
	[Address(RVA = "0x5B43D0", Offset = "0x5B29D0", VA = "0x1805B43D0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x000AFB8C File Offset: 0x000ADD8C
	[Token(Token = "0x600215A")]
	[Address(RVA = "0x5B7FA0", Offset = "0x5B65A0", VA = "0x1805B7FA0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		int num = 0;
		base.SetFreeze(time, num);
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x000AFBB4 File Offset: 0x000ADDB4
	[Token(Token = "0x600215B")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x000AFBF0 File Offset: 0x000ADDF0
	[Token(Token = "0x600215C")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x0600215D RID: 8541 RVA: 0x000AFC00 File Offset: 0x000ADE00
	[Token(Token = "0x600215D")]
	[Address(RVA = "0x5B8060", Offset = "0x5B6660", VA = "0x1805B8060")]
	public Jackbox_a()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04001196 RID: 4502
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001196")]
	private Vector2 jumpPos2;

	// Token: 0x04001197 RID: 4503
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001197")]
	private Vector2 range = (ulong)1065353216L;

	// Token: 0x04001198 RID: 4504
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001198")]
	private bool pause;

	// Token: 0x04001199 RID: 4505
	[FieldOffset(Offset = "0x289")]
	[Token(Token = "0x4001199")]
	private bool startJump;

	// Token: 0x0400119A RID: 4506
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x400119A")]
	[SerializeField]
	private int wait;
}
