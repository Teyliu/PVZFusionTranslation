using System;
using Cpp2IlInjected;

// Token: 0x020005B0 RID: 1456
[Token(Token = "0x20005B0")]
public class SuperMelon : Thrower
{
	// Token: 0x06001ADE RID: 6878 RVA: 0x0008FFF8 File Offset: 0x0008E1F8
	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0x549A60", Offset = "0x548060", VA = "0x180549A60", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.thePlantAttackCountDown = 0f;
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x00090018 File Offset: 0x0008E218
	[Token(Token = "0x6001ADF")]
	[Address(RVA = "0x549950", Offset = "0x547F50", VA = "0x180549950", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_superMelon;
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x00090028 File Offset: 0x0008E228
	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x549960", Offset = "0x547F60", VA = "0x180549960", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		ulong num;
		PotEffects.CornPotEffect(this, theColumn, theRow, 4, (int)num);
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x00090048 File Offset: 0x0008E248
	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x5499E0", Offset = "0x547FE0", VA = "0x1805499E0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x00090058 File Offset: 0x0008E258
	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x549A80", Offset = "0x548080", VA = "0x180549A80", Slot = "77")]
	protected override void UniqueEffect(Bullet bullet)
	{
		int butterP = this.butterP;
		bool flag = "{il2cpp field on {'Bullet_superMelon' (constant value of type Mono.Cecil.TypeReference)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(Bullet_superMelon).TypeHandle;
		if (flag < true)
		{
			this.thePlantAttackCountDown = 0.1f;
		}
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x00090094 File Offset: 0x0008E294
	[Token(Token = "0x6001AE3")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public SuperMelon()
	{
	}
}
