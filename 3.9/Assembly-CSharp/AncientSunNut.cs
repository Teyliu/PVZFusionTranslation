using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200034F RID: 847
[Token(Token = "0x200034F")]
public class AncientSunNut : WallNut
{
	// Token: 0x06000F86 RID: 3974 RVA: 0x00059B7C File Offset: 0x00057D7C
	[Token(Token = "0x6000F86")]
	[Address(RVA = "0x46F9B0", Offset = "0x46DFB0", VA = "0x18046F9B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00059B9C File Offset: 0x00057D9C
	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x46FA10", Offset = "0x46E010", VA = "0x18046FA10", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("enter");
		Action action = delegate
		{
			int num = 0;
			Transform axis = this.axis;
			ParticleManager instance = ParticleManager.Instance;
			Vector3 vector;
			float z = vector.z;
			int thePlantRow = this.thePlantRow;
			int num2 = 0;
			ulong num3;
			Particle particle = instance.SetParticle((ParticleType)((uint)11), num, thePlantRow, num3 != 0UL, (float)num2);
			this.theStatus = (PlantStatus)num;
			this.ReplaceSprite();
		};
		this.defaultAction = action;
		throw new NullReferenceException();
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00059BD8 File Offset: 0x00057DD8
	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x46F9F0", Offset = "0x46DFF0", VA = "0x18046F9F0", Slot = "28")]
	protected override void ReplaceSprite()
	{
		base.ReplaceSprite();
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00059BF0 File Offset: 0x00057DF0
	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x46FC90", Offset = "0x46E290", VA = "0x18046FC90", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00059C0C File Offset: 0x00057E0C
	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x46FAC0", Offset = "0x46E0C0", VA = "0x18046FAC0")]
	public void SummonAndRecover()
	{
		this.board.UseSun(500f);
		int num = 0;
		ulong num2;
		base.Recover(500f, (DamageType)num, true, num2 != 0UL);
		CreatePlant instance = CreatePlant.Instance;
		int num3 = this.thePlantColumn;
		num3++;
		int num4 = 0;
		Plant plant;
		if (plant != num4)
		{
			float deltaTime = Time.deltaTime;
			plant.AttributeCountdown = deltaTime;
			Transform transform = plant.transform;
			Vector3 vector;
			float z = vector.z;
		}
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00059C8C File Offset: 0x00057E8C
	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x46F9D0", Offset = "0x46DFD0", VA = "0x18046F9D0", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		this.SummonAndRecover();
		return true;
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00059CA0 File Offset: 0x00057EA0
	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public AncientSunNut()
	{
	}
}
