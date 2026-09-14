using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000690 RID: 1680
[Token(Token = "0x2000690")]
public class Jackson_b : Jackson_a
{
	// Token: 0x06002073 RID: 8307 RVA: 0x000ABE68 File Offset: 0x000AA068
	[Token(Token = "0x6002073")]
	[Address(RVA = "0x556D00", Offset = "0x555300", VA = "0x180556D00", Slot = "10")]
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

	// Token: 0x06002074 RID: 8308 RVA: 0x000ABEC0 File Offset: 0x000AA0C0
	[Token(Token = "0x6002074")]
	[Address(RVA = "0x5570E0", Offset = "0x5556E0", VA = "0x1805570E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.particle.gameObject.SetActive(true);
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x000ABEEC File Offset: 0x000AA0EC
	[Token(Token = "0x6002075")]
	[Address(RVA = "0x556C80", Offset = "0x555280", VA = "0x180556C80", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("summon");
		ParticleSystem.MainModule main = this.particle.main;
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x000ABF1C File Offset: 0x000AA11C
	[Token(Token = "0x6002076")]
	[Address(RVA = "0x556E10", Offset = "0x555410", VA = "0x180556E10", Slot = "21")]
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

	// Token: 0x06002077 RID: 8311 RVA: 0x000ABFCC File Offset: 0x000AA1CC
	[Token(Token = "0x6002077")]
	[Address(RVA = "0x556DB0", Offset = "0x5553B0", VA = "0x180556DB0", Slot = "27")]
	public override void Die(int reason = 0)
	{
		ParticleSystem.MainModule main = this.particle.main;
		base.Die(reason);
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x000ABFF4 File Offset: 0x000AA1F4
	[Token(Token = "0x6002078")]
	[Address(RVA = "0x556C00", Offset = "0x555200", VA = "0x180556C00")]
	public Jackson_b()
	{
		Zombie[] array = new Zombie[4];
		this.zombies = array;
		base..ctor();
	}

	// Token: 0x040010D4 RID: 4308
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010D4")]
	private ParticleSystem particle;
}
