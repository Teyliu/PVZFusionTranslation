using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200032D RID: 813
[Token(Token = "0x200032D")]
public class NutChomper : Chomper
{
	// Token: 0x06000ED3 RID: 3795 RVA: 0x00056BC4 File Offset: 0x00054DC4
	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x427940", Offset = "0x425F40", VA = "0x180427940", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Sprite sprite = Resources.Load<Sprite>("Plants/_Mixer/NutChomper/cracked1_back");
		this.backCrack1 = sprite;
		Sprite sprite2 = Resources.Load<Sprite>("Plants/_Mixer/NutChomper/cracked2_back");
		this.backCrack2 = sprite2;
		Sprite sprite3 = Resources.Load<Sprite>("Plants/_Mixer/NutChomper/cracked1_head");
		this.headCrack1 = sprite3;
		Sprite sprite4 = Resources.Load<Sprite>("Plants/_Mixer/NutChomper/cracked2_head");
		this.headCrack2 = sprite4;
		GameObject gameObject = base.transform.Find("Wallnut_body").gameObject;
		this.back = gameObject;
		GameObject gameObject2 = base.transform.Find("head").gameObject;
		this.head = gameObject2;
		Sprite sprite5 = this.back.GetComponent<SpriteRenderer>().sprite;
		this.originBack = sprite5;
		Sprite sprite6 = this.head.GetComponent<SpriteRenderer>().sprite;
		this.originHead = sprite6;
		throw new NullReferenceException();
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00056C98 File Offset: 0x00054E98
	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x428080", Offset = "0x426680", VA = "0x180428080", Slot = "70")]
	protected override void Swallow()
	{
		this.anim.SetTrigger("swallow");
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("chew", num != 0);
		int num2 = 0;
		ulong num3;
		base.Recover(1000f, (DamageType)num2, true, num3 != 0UL);
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00056CE0 File Offset: 0x00054EE0
	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00056CF0 File Offset: 0x00054EF0
	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x427B90", Offset = "0x426190", VA = "0x180427B90", Slot = "29")]
	protected override void ReplaceSprite()
	{
		int num = this.thePlantMaxHealth;
		num += num;
		SpriteRenderer component = this.head.GetComponent<SpriteRenderer>();
		Sprite sprite = this.originHead;
		component.sprite = sprite;
		SpriteRenderer component2 = this.back.GetComponent<SpriteRenderer>();
		Sprite sprite2 = this.originBack;
		component2.sprite = sprite2;
		this.cracked1 = false;
		int num2 = this.thePlantMaxHealth;
		num2 += num2;
		SpriteRenderer component3 = this.head.GetComponent<SpriteRenderer>();
		Sprite sprite3 = this.headCrack1;
		component3.sprite = sprite3;
		SpriteRenderer component4 = this.back.GetComponent<SpriteRenderer>();
		Sprite sprite4 = this.backCrack1;
		component4.sprite = sprite4;
		this.cracked2 = false;
		Transform transform3;
		if (!this.cracked1)
		{
			GameObject gameObject = GameAPP.particlePrefab[13];
			Transform transform = this.head.transform;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject2;
			Transform transform2 = gameObject2.transform;
			transform3 = this.board.gameObject.transform;
			transform2.parentInternal = transform3;
			this.cracked1 = true;
		}
		transform3 += transform3;
		SpriteRenderer component5 = this.head.GetComponent<SpriteRenderer>();
		Sprite sprite5 = this.headCrack2;
		component5.sprite = sprite5;
		SpriteRenderer component6 = this.back.GetComponent<SpriteRenderer>();
		Sprite sprite6 = this.backCrack2;
		component6.sprite = sprite6;
		if (!this.cracked2)
		{
			GameObject gameObject3 = GameAPP.particlePrefab[13];
			Transform transform4 = this.head.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
			GameObject gameObject4;
			Transform transform5 = gameObject4.transform;
			Transform transform6 = this.board.gameObject.transform;
			transform5.parentInternal = transform6;
			this.cracked2 = true;
		}
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00056EA0 File Offset: 0x000550A0
	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x41A920", Offset = "0x418F20", VA = "0x18041A920")]
	public NutChomper()
	{
		this.swallowMaxCountDown = 40f;
		base..ctor();
	}

	// Token: 0x04000B12 RID: 2834
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B12")]
	private Sprite backCrack1;

	// Token: 0x04000B13 RID: 2835
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B13")]
	private Sprite backCrack2;

	// Token: 0x04000B14 RID: 2836
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B14")]
	private Sprite headCrack1;

	// Token: 0x04000B15 RID: 2837
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000B15")]
	private Sprite headCrack2;

	// Token: 0x04000B16 RID: 2838
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000B16")]
	private Sprite originBack;

	// Token: 0x04000B17 RID: 2839
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000B17")]
	private Sprite originHead;

	// Token: 0x04000B18 RID: 2840
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000B18")]
	private GameObject back;

	// Token: 0x04000B19 RID: 2841
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000B19")]
	private GameObject head;

	// Token: 0x04000B1A RID: 2842
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000B1A")]
	private bool cracked1;

	// Token: 0x04000B1B RID: 2843
	[FieldOffset(Offset = "0x271")]
	[Token(Token = "0x4000B1B")]
	private bool cracked2;
}
