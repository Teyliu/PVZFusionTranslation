using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000449 RID: 1097
[Token(Token = "0x2000449")]
public class SuperPumpkin : BloverPumpkin
{
	// Token: 0x0600143F RID: 5183 RVA: 0x0007109C File Offset: 0x0006F29C
	[Token(Token = "0x600143F")]
	[Address(RVA = "0x474630", Offset = "0x472C30", VA = "0x180474630", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x000710BC File Offset: 0x0006F2BC
	[Token(Token = "0x6001440")]
	[Address(RVA = "0x4744B0", Offset = "0x472AB0", VA = "0x1804744B0")]
	public void DelaySummon(float time)
	{
		base.Invoke("CreateFly", time);
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x000710D8 File Offset: 0x0006F2D8
	[Token(Token = "0x6001441")]
	[Address(RVA = "0x474000", Offset = "0x472600", VA = "0x180474000", Slot = "40")]
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

	// Token: 0x06001442 RID: 5186 RVA: 0x000711A4 File Offset: 0x0006F3A4
	[Token(Token = "0x6001442")]
	[Address(RVA = "0x474500", Offset = "0x472B00", VA = "0x180474500", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		LittleFly littleFly = this.littleFly;
		int num = 0;
		if (littleFly != num)
		{
			this.littleFly.Die();
		}
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x000711D8 File Offset: 0x0006F3D8
	[Token(Token = "0x6001443")]
	[Address(RVA = "0x474250", Offset = "0x472850", VA = "0x180474250", Slot = "70")]
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

	// Token: 0x06001444 RID: 5188 RVA: 0x00071284 File Offset: 0x0006F484
	[Token(Token = "0x6001444")]
	[Address(RVA = "0x4745E0", Offset = "0x472BE0", VA = "0x1804745E0", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		base.System.Collections.IEnumerator.Reset();
		this.littleFly.theFlyRow = 0;
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x000712AC File Offset: 0x0006F4AC
	[Token(Token = "0x6001445")]
	[Address(RVA = "0x474590", Offset = "0x472B90", VA = "0x180474590", Slot = "71")]
	protected virtual GameObject GetFly()
	{
		return Resources.Load<GameObject>("Plants/Pumpkin/SuperPumpkin/LittleFly");
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x000712C4 File Offset: 0x0006F4C4
	[Token(Token = "0x6001446")]
	[Address(RVA = "0x41A9A0", Offset = "0x418FA0", VA = "0x18041A9A0")]
	public SuperPumpkin()
	{
	}

	// Token: 0x04000CB8 RID: 3256
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CB8")]
	protected LittleFly littleFly;

	// Token: 0x04000CB9 RID: 3257
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CB9")]
	protected LittleFly littleFly2;

	// Token: 0x04000CBA RID: 3258
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CBA")]
	protected LittleFly littleFly3;
}
