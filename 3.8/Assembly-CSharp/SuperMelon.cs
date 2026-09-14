using System;
using Cpp2IlInjected;

// Token: 0x0200057F RID: 1407
[Token(Token = "0x200057F")]
public class SuperMelon : Thrower
{
	// Token: 0x060019F8 RID: 6648 RVA: 0x0008BC60 File Offset: 0x00089E60
	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x4E9C00", Offset = "0x4E8200", VA = "0x1804E9C00", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.thePlantAttackCountDown = 0f;
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x0008BC80 File Offset: 0x00089E80
	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x4E9AF0", Offset = "0x4E80F0", VA = "0x1804E9AF0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_superMelon;
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x0008BC90 File Offset: 0x00089E90
	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x4E9B00", Offset = "0x4E8100", VA = "0x1804E9B00", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x0008BCB0 File Offset: 0x00089EB0
	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x4E9B80", Offset = "0x4E8180", VA = "0x1804E9B80", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x0008BCC0 File Offset: 0x00089EC0
	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x4E9C20", Offset = "0x4E8220", VA = "0x1804E9C20", Slot = "78")]
	protected override void UniqueEffect(Bullet bullet)
	{
		int butterP = this.butterP;
		bool flag = "{il2cpp field on {'Bullet_superMelon' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Bullet_superMelon).TypeHandle;
		if (flag < true)
		{
			this.thePlantAttackCountDown = 0.1f;
		}
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x0008BCFC File Offset: 0x00089EFC
	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public SuperMelon()
	{
	}
}
