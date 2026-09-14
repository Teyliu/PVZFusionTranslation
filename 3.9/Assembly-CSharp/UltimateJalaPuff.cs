using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200049F RID: 1183
[Token(Token = "0x200049F")]
public class UltimateJalaPuff : UltimateJalapeno
{
	// Token: 0x060015FA RID: 5626 RVA: 0x00078CE8 File Offset: 0x00076EE8
	[Token(Token = "0x60015FA")]
	[Address(RVA = "0x4E44A0", Offset = "0x4E2AA0", VA = "0x1804E44A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 0.5f;
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x00078D10 File Offset: 0x00076F10
	[Token(Token = "0x60015FB")]
	[Address(RVA = "0x4E4160", Offset = "0x4E2760", VA = "0x1804E4160", Slot = "39")]
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

	// Token: 0x060015FC RID: 5628 RVA: 0x00078DE0 File Offset: 0x00076FE0
	[Token(Token = "0x60015FC")]
	[Address(RVA = "0x4E4910", Offset = "0x4E2F10", VA = "0x1804E4910", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		this.UdpateSheildPosition();
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x00078DF4 File Offset: 0x00076FF4
	[Token(Token = "0x60015FD")]
	[Address(RVA = "0x4E4E30", Offset = "0x4E3430", VA = "0x1804E4E30", Slot = "15")]
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

	// Token: 0x060015FE RID: 5630 RVA: 0x00078E94 File Offset: 0x00077094
	[Token(Token = "0x60015FE")]
	[Address(RVA = "0x4E4590", Offset = "0x4E2B90", VA = "0x1804E4590", Slot = "68")]
	protected override void LimCount()
	{
		Board board = this.board;
		int plantCount = Lawnf.GetPlantCount(this.thePlantType, board);
		int num = this.board.rowNum;
		num += 2;
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x00078EE8 File Offset: 0x000770E8
	[Token(Token = "0x60015FF")]
	[Address(RVA = "0x4E5090", Offset = "0x4E3690", VA = "0x1804E5090")]
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

	// Token: 0x06001600 RID: 5632 RVA: 0x00078FC4 File Offset: 0x000771C4
	[Token(Token = "0x6001600")]
	[Address(RVA = "0x4E4920", Offset = "0x4E2F20", VA = "0x1804E4920", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x00078FE8 File Offset: 0x000771E8
	[Token(Token = "0x6001601")]
	[Address(RVA = "0x4ACF00", Offset = "0x4AB500", VA = "0x1804ACF00", Slot = "69")]
	public override void OnDeath()
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction2 = board.boardAction;
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x00079028 File Offset: 0x00077228
	[Token(Token = "0x6001602")]
	[Address(RVA = "0x4E44E0", Offset = "0x4E2AE0", VA = "0x1804E44E0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		global::UnityEngine.Object.Destroy(this.shield.gameObject);
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x0007904C File Offset: 0x0007724C
	[Token(Token = "0x6001603")]
	[Address(RVA = "0x4E4720", Offset = "0x4E2D20", VA = "0x1804E4720", Slot = "61")]
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

	// Token: 0x06001604 RID: 5636 RVA: 0x000790AC File Offset: 0x000772AC
	[Token(Token = "0x6001604")]
	[Address(RVA = "0x4E4550", Offset = "0x4E2B50", VA = "0x1804E4550")]
	public void DontSet()
	{
		this.targetPlant = (ulong)0L;
		this.UdpateSheildPosition();
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x000790C8 File Offset: 0x000772C8
	[Token(Token = "0x6001605")]
	[Address(RVA = "0x4E4BC0", Offset = "0x4E31C0", VA = "0x1804E4BC0", Slot = "62")]
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

	// Token: 0x06001606 RID: 5638 RVA: 0x00079158 File Offset: 0x00077358
	[Token(Token = "0x6001606")]
	[Address(RVA = "0x4E4A10", Offset = "0x4E3010", VA = "0x1804E4A10", Slot = "70")]
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

	// Token: 0x06001607 RID: 5639 RVA: 0x00079200 File Offset: 0x00077400
	[Token(Token = "0x6001607")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public UltimateJalaPuff()
	{
	}

	// Token: 0x04000DA9 RID: 3497
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000DA9")]
	public GameObject shieldPrefab;

	// Token: 0x04000DAA RID: 3498
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DAA")]
	private SortingGroup shield;

	// Token: 0x04000DAB RID: 3499
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DAB")]
	private int shieldRow;
}
