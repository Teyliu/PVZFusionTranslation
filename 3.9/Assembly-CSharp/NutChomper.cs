using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200033D RID: 829
[Token(Token = "0x200033D")]
public class NutChomper : Chomper
{
	// Token: 0x06000F1D RID: 3869 RVA: 0x00057C38 File Offset: 0x00055E38
	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0x4664F0", Offset = "0x464AF0", VA = "0x1804664F0", Slot = "10")]
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

	// Token: 0x06000F1E RID: 3870 RVA: 0x00057D0C File Offset: 0x00055F0C
	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0x466C30", Offset = "0x465230", VA = "0x180466C30", Slot = "70")]
	protected override void Swallow()
	{
		base.Swallow();
		int num = 0;
		ulong num2;
		base.Recover(1000f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00057D30 File Offset: 0x00055F30
	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00057D40 File Offset: 0x00055F40
	[Token(Token = "0x6000F20")]
	[Address(RVA = "0x466740", Offset = "0x464D40", VA = "0x180466740", Slot = "28")]
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

	// Token: 0x06000F21 RID: 3873 RVA: 0x00057EF0 File Offset: 0x000560F0
	[Token(Token = "0x6000F21")]
	[Address(RVA = "0x458C10", Offset = "0x457210", VA = "0x180458C10")]
	public NutChomper()
	{
	}

	// Token: 0x04000B63 RID: 2915
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B63")]
	private Sprite backCrack1;

	// Token: 0x04000B64 RID: 2916
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B64")]
	private Sprite backCrack2;

	// Token: 0x04000B65 RID: 2917
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B65")]
	private Sprite headCrack1;

	// Token: 0x04000B66 RID: 2918
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B66")]
	private Sprite headCrack2;

	// Token: 0x04000B67 RID: 2919
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000B67")]
	private Sprite originBack;

	// Token: 0x04000B68 RID: 2920
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000B68")]
	private Sprite originHead;

	// Token: 0x04000B69 RID: 2921
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000B69")]
	private GameObject back;

	// Token: 0x04000B6A RID: 2922
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000B6A")]
	private GameObject head;

	// Token: 0x04000B6B RID: 2923
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000B6B")]
	private bool cracked1;

	// Token: 0x04000B6C RID: 2924
	[FieldOffset(Offset = "0x269")]
	[Token(Token = "0x4000B6C")]
	private bool cracked2;
}
