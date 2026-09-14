using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000326 RID: 806
[Token(Token = "0x2000326")]
public class TreasureMine : Plant
{
	// Token: 0x06000EAF RID: 3759 RVA: 0x00053E60 File Offset: 0x00052060
	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x415360", Offset = "0x413960", VA = "0x180415360", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)30L);
		this.timer = 30f;
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00053E88 File Offset: 0x00052088
	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x415A80", Offset = "0x414080", VA = "0x180415A80", Slot = "16")]
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

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00053F78 File Offset: 0x00052178
	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x415120", Offset = "0x413720", VA = "0x180415120")]
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

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00054020 File Offset: 0x00052220
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x415790", Offset = "0x413D90", VA = "0x180415790")]
	private void DropResources()
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		GameAPP.PlaySound(66, 0.5f, 1f);
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00054058 File Offset: 0x00052258
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x415520", Offset = "0x413B20", VA = "0x180415520")]
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

	// Token: 0x06000EB4 RID: 3764 RVA: 0x000540F4 File Offset: 0x000522F4
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x4158D0", Offset = "0x413ED0", VA = "0x1804158D0")]
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

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00054150 File Offset: 0x00052350
	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x415390", Offset = "0x413990", VA = "0x180415390", Slot = "52")]
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

	// Token: 0x06000EB6 RID: 3766 RVA: 0x000541C4 File Offset: 0x000523C4
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x415C40", Offset = "0x414240", VA = "0x180415C40")]
	public TreasureMine()
	{
	}

	// Token: 0x04000B07 RID: 2823
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B07")]
	private float timer;

	// Token: 0x04000B08 RID: 2824
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000B08")]
	private float flashTimer;

	// Token: 0x04000B09 RID: 2825
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B09")]
	private int restPlant = (int)((ulong)3L);
}
