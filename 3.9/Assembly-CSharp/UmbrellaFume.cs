using System;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;

// Token: 0x020005FA RID: 1530
[Token(Token = "0x20005FA")]
public class UmbrellaFume : CornUmbrella
{
	// Token: 0x06001C92 RID: 7314 RVA: 0x000986C8 File Offset: 0x000968C8
	[Token(Token = "0x6001C92")]
	[Address(RVA = "0x56EC90", Offset = "0x56D290", VA = "0x18056EC90", Slot = "68")]
	public override void Block(Bullet bullet)
	{
		base.Block(bullet);
		int attributeCount = this.attributeCount;
		this.attributeCount = attributeCount;
	}

	// Token: 0x06001C93 RID: 7315 RVA: 0x000986F0 File Offset: 0x000968F0
	[Token(Token = "0x6001C93")]
	[Address(RVA = "0x56EE40", Offset = "0x56D440", VA = "0x18056EE40", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x00098718 File Offset: 0x00096918
	[Token(Token = "0x6001C94")]
	[Address(RVA = "0x56ED90", Offset = "0x56D390", VA = "0x18056ED90")]
	private void ShootUpdate()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001C95 RID: 7317 RVA: 0x00098738 File Offset: 0x00096938
	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x56EB90", Offset = "0x56D190", VA = "0x18056EB90", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		Plant umbrellaPot = base.UmbrellaPot;
		int num = 0;
		bool flag = umbrellaPot == num;
		int num2 = 0;
		if (!flag)
		{
		}
		zombie.KnockBack((float)num, (Zombie.KnockBackReason)num2);
		int attributeCount = this.attributeCount;
		this.attributeCount = attributeCount;
	}

	// Token: 0x06001C96 RID: 7318 RVA: 0x00098788 File Offset: 0x00096988
	[Token(Token = "0x6001C96")]
	[Address(RVA = "0x56ECD0", Offset = "0x56D2D0", VA = "0x18056ECD0", Slot = "71")]
	protected override void DamageHealth(int count)
	{
		this.locked = true;
		if (count <= 0)
		{
			this.locked = false;
			return;
		}
		if (count == 1)
		{
			this.locked = false;
			return;
		}
		this.locked = false;
	}

	// Token: 0x06001C97 RID: 7319 RVA: 0x000987C8 File Offset: 0x000969C8
	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x56EEF0", Offset = "0x56D4F0", VA = "0x18056EEF0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (!this.locked)
		{
			int attributeCount = this.attributeCount;
			this.attributeCount = damage;
		}
		int num = damage.Multiply(0.1f);
	}

	// Token: 0x06001C98 RID: 7320 RVA: 0x000987FC File Offset: 0x000969FC
	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x56EAE0", Offset = "0x56D0E0", VA = "0x18056EAE0")]
	private void AnimShoot()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001C99 RID: 7321 RVA: 0x0009881C File Offset: 0x00096A1C
	[Token(Token = "0x6001C99")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public UmbrellaFume()
	{
	}

	// Token: 0x04000FA7 RID: 4007
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000FA7")]
	private bool locked;
}
