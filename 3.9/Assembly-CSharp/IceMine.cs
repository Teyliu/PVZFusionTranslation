using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200031D RID: 797
[Token(Token = "0x200031D")]
public class IceMine : PotatoMine
{
	// Token: 0x06000E7B RID: 3707 RVA: 0x00052938 File Offset: 0x00050B38
	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x447950", Offset = "0x445F50", VA = "0x180447950", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)29L);
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00052958 File Offset: 0x00050B58
	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x447D80", Offset = "0x446380", VA = "0x180447D80", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("Unearthed");
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00052984 File Offset: 0x00050B84
	[Token(Token = "0x6000E7D")]
	[Address(RVA = "0x4478A0", Offset = "0x445EA0", VA = "0x1804478A0", Slot = "39")]
	protected override void AttributeEvent()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x000529A4 File Offset: 0x00050BA4
	[Token(Token = "0x6000E7E")]
	[Address(RVA = "0x447A20", Offset = "0x446020", VA = "0x180447A20", Slot = "35")]
	protected override bool OnCrash()
	{
		return base.OnCrash();
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x000529D0 File Offset: 0x00050BD0
	[Token(Token = "0x6000E7F")]
	[Address(RVA = "0x447B30", Offset = "0x446130", VA = "0x180447B30", Slot = "70")]
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

	// Token: 0x06000E80 RID: 3712 RVA: 0x00052A84 File Offset: 0x00050C84
	[Token(Token = "0x6000E80")]
	[Address(RVA = "0x447A80", Offset = "0x446080", VA = "0x180447A80", Slot = "69")]
	protected override void OnFlash()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00052AA4 File Offset: 0x00050CA4
	[Token(Token = "0x6000E81")]
	[Address(RVA = "0x447970", Offset = "0x445F70", VA = "0x180447970")]
	private void Freeze()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00052AC8 File Offset: 0x00050CC8
	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x446250", Offset = "0x444850", VA = "0x180446250")]
	public IceMine()
	{
	}

	// Token: 0x04000B1F RID: 2847
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B1F")]
	public SpriteRenderer flashRenderer;

	// Token: 0x04000B20 RID: 2848
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B20")]
	public Sprite originalSprite;

	// Token: 0x04000B21 RID: 2849
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000B21")]
	public Sprite flashSprite;
}
