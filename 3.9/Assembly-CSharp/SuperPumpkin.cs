using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000469 RID: 1129
[Token(Token = "0x2000469")]
public class SuperPumpkin : BloverPumpkin
{
	// Token: 0x060014CF RID: 5327 RVA: 0x000733C8 File Offset: 0x000715C8
	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x4CBEE0", Offset = "0x4CA4E0", VA = "0x1804CBEE0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x000733E8 File Offset: 0x000715E8
	[Token(Token = "0x60014D0")]
	[Address(RVA = "0x4CBD60", Offset = "0x4CA360", VA = "0x1804CBD60")]
	public void DelaySummon(float time)
	{
		base.Invoke("CreateFly", time);
	}

	// Token: 0x060014D1 RID: 5329 RVA: 0x00073404 File Offset: 0x00071604
	[Token(Token = "0x60014D1")]
	[Address(RVA = "0x4CB8B0", Offset = "0x4C9EB0", VA = "0x1804CB8B0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = this.thePlantColumn;
		Board board = this.board;
		int num2 = this.thePlantColumn;
		int columnNum = board.columnNum;
		num2++;
		if (columnNum >= num2)
		{
		}
		int num3 = this.thePlantRow;
		Board board2 = this.board;
		int num4 = this.thePlantRow;
		int rowNum = board2.rowNum;
		num4++;
		if (rowNum >= num4)
		{
		}
		CreatePlant instance = CreatePlant.Instance;
		int num5 = 0;
		Plant plant;
		if (!(plant != num5))
		{
			num3++;
			num++;
		}
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(num);
		Mouse instance2 = Mouse.Instance;
		num = num3;
		float boxYFromRow = instance2.GetBoxYFromRow(num);
		base.AttributeCountdown = 30f;
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x000734D0 File Offset: 0x000716D0
	[Token(Token = "0x60014D2")]
	[Address(RVA = "0x4CBDB0", Offset = "0x4CA3B0", VA = "0x1804CBDB0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		LittleFly littleFly = this.littleFly;
		int num = 0;
		if (littleFly != num)
		{
			this.littleFly.Die();
		}
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x00073504 File Offset: 0x00071704
	[Token(Token = "0x60014D3")]
	[Address(RVA = "0x4CBB00", Offset = "0x4CA100", VA = "0x1804CBB00", Slot = "69")]
	protected virtual void CreateFly()
	{
		LittleFly littleFly = this.littleFly;
		int num = 0;
		if (littleFly == num)
		{
			GameObject fly = this.GetFly();
			Transform axis = this.axis;
			float num2 = global::UnityEngine.Random.Range(1.3f, 1.5f);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject;
			LittleFly component = gameObject.GetComponent<LittleFly>();
			this.littleFly = component;
			LittleFly littleFly2 = this.littleFly;
			int thePlantRow = this.thePlantRow;
			littleFly2.theFlyRow = thePlantRow;
			this.littleFly.parentPlant = this;
			LittleFly littleFly3 = this.littleFly;
			PlantType thePlantType = this.thePlantType;
			littleFly3.fromType = thePlantType;
		}
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x000735B0 File Offset: 0x000717B0
	[Token(Token = "0x60014D4")]
	[Address(RVA = "0x4CBE90", Offset = "0x4CA490", VA = "0x1804CBE90", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		base..ctor();
		this.littleFly.theFlyRow = 0;
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x000735D8 File Offset: 0x000717D8
	[Token(Token = "0x60014D5")]
	[Address(RVA = "0x4CBE40", Offset = "0x4CA440", VA = "0x1804CBE40", Slot = "70")]
	protected virtual GameObject GetFly()
	{
		return Resources.Load<GameObject>("Plants/Pumpkin/SuperPumpkin/LittleFly");
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x000735F0 File Offset: 0x000717F0
	[Token(Token = "0x60014D6")]
	[Address(RVA = "0x497370", Offset = "0x495970", VA = "0x180497370")]
	public SuperPumpkin()
	{
	}

	// Token: 0x04000D44 RID: 3396
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D44")]
	protected LittleFly littleFly;

	// Token: 0x04000D45 RID: 3397
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D45")]
	protected LittleFly littleFly2;

	// Token: 0x04000D46 RID: 3398
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D46")]
	protected LittleFly littleFly3;
}
