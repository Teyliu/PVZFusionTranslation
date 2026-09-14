using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000467 RID: 1127
[Token(Token = "0x2000467")]
public class SuperJalaNut : WallNut
{
	// Token: 0x060014C1 RID: 5313 RVA: 0x00073024 File Offset: 0x00071224
	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x47E710", Offset = "0x47CD10", VA = "0x18047E710", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x060014C2 RID: 5314 RVA: 0x00073044 File Offset: 0x00071244
	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x4CAE50", Offset = "0x4C9450", VA = "0x1804CAE50", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 3f;
		int thePlantMaxHealth = this.thePlantMaxHealth;
		this.thePlantHealth = thePlantMaxHealth;
	}

	// Token: 0x060014C3 RID: 5315 RVA: 0x0007306C File Offset: 0x0007126C
	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x4CB290", Offset = "0x4C9890", VA = "0x1804CB290", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		Board board = this.board;
	}

	// Token: 0x060014C4 RID: 5316 RVA: 0x000730AC File Offset: 0x000712AC
	[Token(Token = "0x60014C4")]
	[Address(RVA = "0x4CAEC0", Offset = "0x4C94C0", VA = "0x1804CAEC0", Slot = "27")]
	protected override void LimHealth()
	{
		this.thePlantHealth = (int)((ulong)1000000000L);
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x000730C8 File Offset: 0x000712C8
	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x4CAEE0", Offset = "0x4C94E0", VA = "0x1804CAEE0", Slot = "25")]
	public override void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)4)))
		{
		}
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x000730E0 File Offset: 0x000712E0
	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x4CAF50", Offset = "0x4C9550", VA = "0x1804CAF50", Slot = "69")]
	public virtual void SummonAndRecover()
	{
		int num3;
		Plant plant;
		for (;;)
		{
			base.UpdateText();
			base.ReplaceSprite();
			Plant targetPlant = this.targetPlant;
			int num = 0;
			if (!(targetPlant == num) && this.targetPlant.theStatus == PlantStatus.Default)
			{
				break;
			}
			CreatePlant instance = CreatePlant.Instance;
			int num2 = this.thePlantColumn;
			num3 = 0;
			num2++;
			int num4 = 0;
			if (plant != num4)
			{
				goto Block_2;
			}
		}
		return;
		Block_2:
		if (plant != 0)
		{
			this.targetPlant = plant;
			Plant targetPlant2 = this.targetPlant;
			ParticleManager instance2 = ParticleManager.Instance;
			Transform axis = targetPlant2.axis;
			Plant targetPlant3 = this.targetPlant;
		}
		this.targetPlant = num3;
		throw new NullReferenceException();
	}

	// Token: 0x060014C7 RID: 5319 RVA: 0x00073188 File Offset: 0x00071388
	[Token(Token = "0x60014C7")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SuperJalaNut()
	{
	}
}
