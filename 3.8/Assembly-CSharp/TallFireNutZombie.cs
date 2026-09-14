using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006EC RID: 1772
[Token(Token = "0x20006EC")]
public class TallFireNutZombie : WallNutZombie
{
	// Token: 0x060022FC RID: 8956 RVA: 0x000B7750 File Offset: 0x000B5950
	[Token(Token = "0x60022FC")]
	[Address(RVA = "0x57C880", Offset = "0x57AE80", VA = "0x18057C880", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1f;
	}

	// Token: 0x060022FD RID: 8957 RVA: 0x000B7770 File Offset: 0x000B5970
	[Token(Token = "0x60022FD")]
	[Address(RVA = "0x57C4C0", Offset = "0x57AAC0", VA = "0x18057C4C0", Slot = "23")]
	protected override void AttributeEvent()
	{
		int num = 0;
		this.attributeCountDown = 1f;
		float theOriginSpeed = this.theOriginSpeed;
		this.theOriginSpeed = theOriginSpeed;
		Collider2D col = this.col;
		int num2 = this.zombieLayer;
		int num3 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				bool isMindControlled = this.isMindControlled;
				int theZombieRow = this.theZombieRow;
			}
			num++;
			Collider2D col2 = this.col;
			ParticleManager instance = ParticleManager.Instance;
			uint num4;
			base.Die((int)num4);
			CreateZombie instance2 = CreateZombie.Instance;
		}
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x000B780C File Offset: 0x000B5A0C
	[Token(Token = "0x60022FE")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "49")]
	public override void SetJalaed()
	{
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x000B781C File Offset: 0x000B5A1C
	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public TallFireNutZombie()
	{
	}
}
