using System;
using Cpp2IlInjected;

// Token: 0x020006DA RID: 1754
[Token(Token = "0x20006DA")]
public class SuperCherryZ : PeaShooterZ
{
	// Token: 0x0600228B RID: 8843 RVA: 0x000B4FC0 File Offset: 0x000B31C0
	[Token(Token = "0x600228B")]
	[Address(RVA = "0x574A40", Offset = "0x573040", VA = "0x180574A40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 3f;
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x000B4FE0 File Offset: 0x000B31E0
	[Token(Token = "0x600228C")]
	[Address(RVA = "0x574A20", Offset = "0x573020", VA = "0x180574A20", Slot = "23")]
	protected override void AttributeEvent()
	{
		base.AttributeEvent();
		this.attributeCountDown = 6f;
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x000B5000 File Offset: 0x000B3200
	[Token(Token = "0x600228D")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "75")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_superCherry;
	}

	// Token: 0x0600228E RID: 8846 RVA: 0x000B5010 File Offset: 0x000B3210
	[Token(Token = "0x600228E")]
	[Address(RVA = "0x574A60", Offset = "0x573060", VA = "0x180574A60", Slot = "76")]
	protected override int GetBulletDamage()
	{
		long num = (long)(base.GetBulletDamage() * (int)((uint)15));
		return 0;
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x000B502C File Offset: 0x000B322C
	[Token(Token = "0x600228F")]
	[Address(RVA = "0x539090", Offset = "0x537690", VA = "0x180539090")]
	public SuperCherryZ()
	{
	}
}
