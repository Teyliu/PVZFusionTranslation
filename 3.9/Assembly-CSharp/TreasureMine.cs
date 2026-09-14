using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000336 RID: 822
[Token(Token = "0x2000336")]
public class TreasureMine : Plant
{
	// Token: 0x06000EF9 RID: 3833 RVA: 0x00054E78 File Offset: 0x00053078
	[Token(Token = "0x6000EF9")]
	[Address(RVA = "0x46D750", Offset = "0x46BD50", VA = "0x18046D750", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)30L);
		this.timer = 30f;
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00054EA0 File Offset: 0x000530A0
	[Token(Token = "0x6000EFA")]
	[Address(RVA = "0x46DE70", Offset = "0x46C470", VA = "0x18046DE70", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			float num = this.timer;
			float deltaTime = Time.deltaTime;
			Board board = this.board;
			this.timer = num;
			GridSystem gridSystem = board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			if (gridSystem.GetGrid(thePlantColumn, thePlantRow).existTreasure)
			{
				float num2 = this.timer;
				float deltaTime2 = Time.deltaTime;
				this.timer = num2;
			}
			Animator anim = this.anim;
			this.timer = deltaTime;
			anim.SetTrigger("rise");
			GameAPP.PlaySound(48, 0.5f, 1f);
			float num3 = this.flashTimer;
			float deltaTime3 = Time.deltaTime;
			this.flashTimer = num3;
			Animator anim2 = this.anim;
			float num4;
			this.flashTimer = num4;
			anim2.SetTrigger("flash");
		}
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00054F90 File Offset: 0x00053190
	[Token(Token = "0x6000EFB")]
	[Address(RVA = "0x46D510", Offset = "0x46BB10", VA = "0x18046D510")]
	public void AnimGive()
	{
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		bool existTreasure = gridSystem.GetGrid(thePlantColumn, thePlantRow).existTreasure;
		int num = global::UnityEngine.Random.Range(0, 100);
		if (!existTreasure)
		{
			if (num != 0)
			{
			}
			int num2 = 0;
			base.Die((Plant.DieReason)num2);
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
			int num3 = 0;
			Zombie zombie;
			if (zombie != num3)
			{
				zombie.GetComponent<Zombie>().theFirstArmorHealth = (int)((ulong)0L);
			}
			GameAPP.PlaySound(47, 0.5f, 1f);
			return;
		}
		this.DropResources();
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00055038 File Offset: 0x00053238
	[Token(Token = "0x6000EFC")]
	[Address(RVA = "0x46DB80", Offset = "0x46C180", VA = "0x18046DB80")]
	private void DropResources()
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		GameAPP.PlaySound(66, 0.5f, 1f);
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00055070 File Offset: 0x00053270
	[Token(Token = "0x6000EFD")]
	[Address(RVA = "0x46D910", Offset = "0x46BF10", VA = "0x18046D910")]
	private void DropCard()
	{
		List<PlantType> randomPlant = Lawnf.GetRandomPlant();
		Board board = this.board;
		Predicate<PlantType> <>9__7_ = TreasureMine.<>c.<>9__7_0;
		if (<>9__7_ == 0)
		{
			TreasureMine.<>c.<>9__7_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		int num = randomPlant.RemoveAll(<>9__7_);
		Transform axis = this.axis;
		int num2 = randomPlant._size;
		num2 = global::UnityEngine.Random.Range(0, num2);
		PlantType plantType = randomPlant[num2];
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
		int num4 = this.restPlant;
		this.restPlant = num4;
		int num5 = 0;
		base.Die((Plant.DieReason)num5);
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x0005510C File Offset: 0x0005330C
	[Token(Token = "0x6000EFE")]
	[Address(RVA = "0x46DCC0", Offset = "0x46C2C0", VA = "0x18046DCC0")]
	private void DropZombie()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2)
		{
			zombie.GetComponent<Zombie>().theFirstArmorHealth = (int)((ulong)0L);
		}
		GameAPP.PlaySound(47, 0.5f, 1f);
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00055168 File Offset: 0x00053368
	[Token(Token = "0x6000EFF")]
	[Address(RVA = "0x46D780", Offset = "0x46BD80", VA = "0x18046D780", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x000551DC File Offset: 0x000533DC
	[Token(Token = "0x6000F00")]
	[Address(RVA = "0x46E030", Offset = "0x46C630", VA = "0x18046E030")]
	public TreasureMine()
	{
	}

	// Token: 0x04000B58 RID: 2904
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B58")]
	private float timer;

	// Token: 0x04000B59 RID: 2905
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000B59")]
	private float flashTimer;

	// Token: 0x04000B5A RID: 2906
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B5A")]
	private int restPlant = (int)((ulong)3L);
}
