using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200030D RID: 781
[Token(Token = "0x200030D")]
public class IceMine : PotatoMine
{
	// Token: 0x06000E32 RID: 3634 RVA: 0x000519D4 File Offset: 0x0004FBD4
	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x4036D0", Offset = "0x401CD0", VA = "0x1804036D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(14f, 16f);
		base.AttributeCountdown = num;
		this.theStatus = (PlantStatus)((ulong)29L);
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00051A08 File Offset: 0x0004FC08
	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x403B50", Offset = "0x402150", VA = "0x180403B50", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("Unearthed");
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00051A34 File Offset: 0x0004FC34
	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x403620", Offset = "0x401C20", VA = "0x180403620", Slot = "40")]
	protected override void AttributeEvent()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00051A54 File Offset: 0x0004FC54
	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x4037D0", Offset = "0x401DD0", VA = "0x1804037D0", Slot = "36")]
	protected override bool OnCrash()
	{
		base.Explode();
		return true;
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00051A84 File Offset: 0x0004FC84
	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x403900", Offset = "0x401F00", VA = "0x180403900", Slot = "71")]
	protected override void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		if (collision.TryGetComponent<Zombie>(num))
		{
			int thePlantRow = this.thePlantRow;
			if (base.PotatoSearchZombie(num))
			{
				this.exploded = true;
				this.Freeze();
				int num2 = 0;
				base.Die((Plant.DieReason)num2);
				Transform axis = this.axis;
				Vector3 vector;
				float z = vector.z;
				PlantType thePlantType = this.thePlantType;
				int attackDamage = this.attackDamage;
				Transform axis2 = this.axis;
				ParticleManager instance = ParticleManager.Instance;
				int num3 = 0;
				int num4 = 0;
				ulong num5;
				Particle particle = instance.SetParticle((ParticleType)((uint)149), num3, 11, num5 != 0UL, (float)num4);
				GameAPP.PlaySound(47, 0.5f, 1f);
				ScreenShake.TriggerShake(0.15f);
			}
		}
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00051B38 File Offset: 0x0004FD38
	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x403850", Offset = "0x401E50", VA = "0x180403850", Slot = "70")]
	protected override void OnFlash()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00051B58 File Offset: 0x0004FD58
	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x403720", Offset = "0x401D20", VA = "0x180403720")]
	private void Freeze()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00051B7C File Offset: 0x0004FD7C
	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x401F90", Offset = "0x400590", VA = "0x180401F90")]
	public IceMine()
	{
		this.flashInterval = 3f;
		base..ctor();
	}

	// Token: 0x04000ACE RID: 2766
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000ACE")]
	public SpriteRenderer flashRenderer;

	// Token: 0x04000ACF RID: 2767
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000ACF")]
	public Sprite originalSprite;

	// Token: 0x04000AD0 RID: 2768
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000AD0")]
	public Sprite flashSprite;
}
