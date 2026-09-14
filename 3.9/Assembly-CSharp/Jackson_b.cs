using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C7 RID: 1735
[Token(Token = "0x20006C7")]
public class Jackson_b : Jackson_a
{
	// Token: 0x0600218A RID: 8586 RVA: 0x000B0A98 File Offset: 0x000AEC98
	[Token(Token = "0x600218A")]
	[Address(RVA = "0x5BB1A0", Offset = "0x5B97A0", VA = "0x1805BB1A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)32L);
		this.attributeCountDown = 3f;
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		ParticleSystem component = child.GetChild(num2).GetComponent<ParticleSystem>();
		this.particle = component;
		throw new NullReferenceException();
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x000B0AF0 File Offset: 0x000AECF0
	[Token(Token = "0x600218B")]
	[Address(RVA = "0x5BB580", Offset = "0x5B9B80", VA = "0x1805BB580", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.particle.gameObject.SetActive(true);
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x000B0B1C File Offset: 0x000AED1C
	[Token(Token = "0x600218C")]
	[Address(RVA = "0x5BB120", Offset = "0x5B9720", VA = "0x1805BB120", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("summon");
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x0600218D RID: 8589 RVA: 0x000B0B4C File Offset: 0x000AED4C
	[Token(Token = "0x600218D")]
	[Address(RVA = "0x5BB2B0", Offset = "0x5B98B0", VA = "0x1805BB2B0", Slot = "22")]
	protected override void PositionUpdate()
	{
		base.PositionUpdate();
		Animator anim = this.anim;
		AnimatorStateInfo animatorStateInfo;
		float length = animatorStateInfo.m_Length;
		int loop = animatorStateInfo.m_Loop;
		bool flag;
		if (flag)
		{
			Transform axis = this.axis;
			Transform transform = base.transform;
			float theSpeed = this.theSpeed;
			float deltaTime = Time.deltaTime;
			Board board = this.board;
			Transform axis2 = this.axis;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			Vector3 vector;
			float z = vector.z;
			this.anim.SetTrigger("summon");
			ParticleSystem.MainModule main = this.particle.main;
		}
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x000B0BFC File Offset: 0x000AEDFC
	[Token(Token = "0x600218E")]
	[Address(RVA = "0x5BB250", Offset = "0x5B9850", VA = "0x1805BB250", Slot = "28")]
	public override void Die(int reason = 0)
	{
		ParticleSystem.MainModule main = this.particle.main;
		base.Die(reason);
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x000B0C24 File Offset: 0x000AEE24
	[Token(Token = "0x600218F")]
	[Address(RVA = "0x5BB0A0", Offset = "0x5B96A0", VA = "0x1805BB0A0")]
	public Jackson_b()
	{
		Zombie[] array = new Zombie[4];
		this.zombies = array;
		base..ctor();
	}

	// Token: 0x040011A1 RID: 4513
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011A1")]
	private ParticleSystem particle;
}
