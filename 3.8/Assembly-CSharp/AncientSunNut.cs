using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200033F RID: 831
[Token(Token = "0x200033F")]
public class AncientSunNut : WallNut
{
	// Token: 0x06000F3B RID: 3899 RVA: 0x00058BBC File Offset: 0x00056DBC
	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0x418AE0", Offset = "0x4170E0", VA = "0x180418AE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x00058BDC File Offset: 0x00056DDC
	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0x418B40", Offset = "0x417140", VA = "0x180418B40", Slot = "15")]
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

	// Token: 0x06000F3D RID: 3901 RVA: 0x00058C18 File Offset: 0x00056E18
	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x418B20", Offset = "0x417120", VA = "0x180418B20", Slot = "29")]
	protected override void ReplaceSprite()
	{
		base.ReplaceSprite();
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00058C30 File Offset: 0x00056E30
	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x418DC0", Offset = "0x4173C0", VA = "0x180418DC0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00058C4C File Offset: 0x00056E4C
	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x418BF0", Offset = "0x4171F0", VA = "0x180418BF0")]
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

	// Token: 0x06000F40 RID: 3904 RVA: 0x00058CCC File Offset: 0x00056ECC
	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x418B00", Offset = "0x417100", VA = "0x180418B00", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		this.SummonAndRecover();
		return true;
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00058CE0 File Offset: 0x00056EE0
	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public AncientSunNut()
	{
	}
}
