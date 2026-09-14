using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200047D RID: 1149
[Token(Token = "0x200047D")]
public class UltimateJalaPuff : UltimateJalapeno
{
	// Token: 0x0600155A RID: 5466 RVA: 0x0007632C File Offset: 0x0007452C
	[Token(Token = "0x600155A")]
	[Address(RVA = "0x48AF40", Offset = "0x489540", VA = "0x18048AF40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 0.5f;
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x00076354 File Offset: 0x00074554
	[Token(Token = "0x600155B")]
	[Address(RVA = "0x48AC00", Offset = "0x489200", VA = "0x18048AC00", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		int num2 = 0;
		base.OnFixedUpdate();
		SortingGroup sortingGroup = this.shield;
		int num3 = 0;
		num2 += num2;
		Transform transform = sortingGroup.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = this.shield.transform;
		int num4 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				int num5 = this.shieldRow;
				PlantType thePlantType = this.thePlantType;
				Plant targetPlant = this.targetPlant;
				int num6 = 0;
				if (targetPlant != num6)
				{
					Plant targetPlant2 = this.targetPlant;
					ulong num7;
					num7 += num7;
				}
			}
			num++;
		}
		if (num3 != 0)
		{
			uint num8;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num8), 0.5f, 1f);
		}
		base.AttributeCountdown = 0.5f;
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x00076424 File Offset: 0x00074624
	[Token(Token = "0x600155C")]
	[Address(RVA = "0x48B3A0", Offset = "0x4899A0", VA = "0x18048B3A0", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		this.UdpateSheildPosition();
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x00076438 File Offset: 0x00074638
	[Token(Token = "0x600155D")]
	[Address(RVA = "0x48B8B0", Offset = "0x489EB0", VA = "0x18048B8B0", Slot = "15")]
	protected override void Start()
	{
		Transform axis = this.axis;
		GameObject gameObject = this.shieldPrefab;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		SortingGroup component = gameObject2.GetComponent<SortingGroup>();
		this.shield = component;
		int thePlantRow = this.thePlantRow;
		SortingGroup sortingGroup = this.shield;
		string text = string.Format("particle{0}", thePlantRow);
		sortingGroup.sortingLayerName = text;
		int thePlantRow2 = this.thePlantRow;
		this.shieldRow = thePlantRow2;
		base.Start();
		this.LimCount();
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x000764D8 File Offset: 0x000746D8
	[Token(Token = "0x600155E")]
	[Address(RVA = "0x48B030", Offset = "0x489630", VA = "0x18048B030", Slot = "69")]
	protected override void LimCount()
	{
		Board board = this.board;
		int plantCount = Lawnf.GetPlantCount(this.thePlantType, board);
		int num = this.board.rowNum;
		num += 2;
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x00076544 File Offset: 0x00074744
	[Token(Token = "0x600155F")]
	[Address(RVA = "0x48BB10", Offset = "0x48A110", VA = "0x18048BB10")]
	public void UdpateSheildPosition()
	{
		Plant targetPlant = this.targetPlant;
		int num = 0;
		if (!(targetPlant != num))
		{
			int thePlantRow = this.thePlantRow;
			SortingGroup sortingGroup = this.shield;
			this.shieldRow = thePlantRow;
			int num2;
			string text = string.Format("particle{0}", num2);
			sortingGroup.sortingLayerName = text;
			Transform transform = this.shield.transform;
			Transform axis = this.axis;
			Transform transform2 = this.shield.transform;
			return;
		}
		int thePlantRow2 = this.targetPlant.thePlantRow;
		SortingGroup sortingGroup2 = this.shield;
		this.shieldRow = thePlantRow2;
		Plant targetPlant2 = this.targetPlant;
		int num3;
		string text2 = string.Format("particle{0}", num3);
		sortingGroup2.sortingLayerName = text2;
		Transform transform3 = this.shield.transform;
		Transform axis2 = this.targetPlant.axis;
		Transform transform4 = this.shield.transform;
		throw new NullReferenceException();
	}

	// Token: 0x06001560 RID: 5472 RVA: 0x00076620 File Offset: 0x00074820
	[Token(Token = "0x6001560")]
	[Address(RVA = "0x48B3B0", Offset = "0x4899B0", VA = "0x18048B3B0", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x00076644 File Offset: 0x00074844
	[Token(Token = "0x6001561")]
	[Address(RVA = "0x458B30", Offset = "0x457130", VA = "0x180458B30", Slot = "70")]
	public override void OnDeath()
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int attackDamage = this.attackDamage;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		ulong num4;
		boardAction.CreateFireLine(thePlantRow, attackDamage, num2 != 0, num3 != 0UL, num4 != 0UL, num, thePlantType);
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction2 = board.boardAction;
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x000766AC File Offset: 0x000748AC
	[Token(Token = "0x6001562")]
	[Address(RVA = "0x48AF80", Offset = "0x489580", VA = "0x18048AF80", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		global::UnityEngine.Object.Destroy(this.shield.gameObject);
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x000766D0 File Offset: 0x000748D0
	[Token(Token = "0x6001563")]
	[Address(RVA = "0x48B1B0", Offset = "0x4897B0", VA = "0x18048B1B0", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		mouse.cannonPlant = this;
		GameObject gameObject = GameAPP.itemPrefab[16];
		Vector2 mousePosition = mouse.MousePosition;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		mouse.theItemOnMouse = gameObject2;
		mouse.theItemOnMouse.name = "cannon";
		return true;
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x00076730 File Offset: 0x00074930
	[Token(Token = "0x6001564")]
	[Address(RVA = "0x48AFF0", Offset = "0x4895F0", VA = "0x18048AFF0")]
	public void DontSet()
	{
		this.targetPlant = (ulong)0L;
		this.UdpateSheildPosition();
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x0007674C File Offset: 0x0007494C
	[Token(Token = "0x6001565")]
	[Address(RVA = "0x48B640", Offset = "0x489C40", VA = "0x18048B640", Slot = "63")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		ulong num3;
		do
		{
			int num = 0;
			int theMouseRow = mouse.theMouseRow;
			List<Plant> list = Lawnf.Get1x1Plants(mouse.theMouseColumn, theMouseRow);
			bool flag;
			if (flag)
			{
				PlantType thePlantType = this.thePlantType;
				bool flag2;
				while (!flag2)
				{
				}
				Plant targetPlant = this.targetPlant;
				int num2 = 0;
				if (targetPlant != num2)
				{
					this.targetPlant.jalapuff = (ulong)0L;
				}
				this.targetPlant = num;
				this.targetPlant.jalapuff = this;
				this.UdpateSheildPosition();
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x000767DC File Offset: 0x000749DC
	[Token(Token = "0x6001566")]
	[Address(RVA = "0x48B4A0", Offset = "0x489AA0", VA = "0x18048B4A0", Slot = "71")]
	public override void RecoverAll(Plant plant)
	{
		int thePlantHealth = plant.thePlantHealth;
		plant.thePlantHealth = thePlantHealth;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)47)))
		{
			float[] timers = plant.Timers;
			float num = plant.Timers[1];
			timers[1] = num;
		}
		base.UpdateText();
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num2 = 0;
		int attackDamage = this.attackDamage;
		int num3 = 0;
		int thePlantRow = plant.thePlantRow;
		ulong num4;
		ulong num5;
		boardAction.CreateFireLine(thePlantRow, attackDamage, num3 != 0, num4 != 0UL, num5 != 0UL, num2, thePlantType);
		Board board = this.board;
		Transform axis = plant.axis;
		BoardAction boardAction2 = board.boardAction;
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x00076884 File Offset: 0x00074A84
	[Token(Token = "0x6001567")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public UltimateJalaPuff()
	{
	}

	// Token: 0x04000D10 RID: 3344
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D10")]
	public GameObject shieldPrefab;

	// Token: 0x04000D11 RID: 3345
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D11")]
	private SortingGroup shield;

	// Token: 0x04000D12 RID: 3346
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D12")]
	private int shieldRow;
}
