using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BA RID: 1210
[Token(Token = "0x20004BA")]
public class VectorPlant : Plant
{
	// Token: 0x060016A2 RID: 5794 RVA: 0x0007CA80 File Offset: 0x0007AC80
	[Token(Token = "0x60016A2")]
	[Address(RVA = "0x51A960", Offset = "0x518F60", VA = "0x18051A960", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		SpriteRenderer component = transform.GetChild(num).GetComponent<SpriteRenderer>();
		this.r = component;
		throw new NullReferenceException();
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x0007CAB8 File Offset: 0x0007ACB8
	[Token(Token = "0x60016A3")]
	[Address(RVA = "0x51B510", Offset = "0x519B10", VA = "0x18051B510", Slot = "15")]
	protected override void Start()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060016A4 RID: 5796 RVA: 0x0007CADC File Offset: 0x0007ACDC
	[Token(Token = "0x60016A4")]
	[Address(RVA = "0x51AA30", Offset = "0x519030", VA = "0x18051AA30")]
	private void FindOrCreateCorner(int theColumn, int theRow)
	{
		BoardGrid grid = this.board.gridSystem.GetGrid(theColumn, theRow);
		Corner <Corner>k__BackingField = grid.<Corner>k__BackingField;
		int num = 0;
		bool flag = <Corner>k__BackingField == num;
		if (flag)
		{
			GameObject gameObject = new GameObject(string.Format("corner_{0}_{1}", flag, flag));
			Transform transform = gameObject.transform;
			Transform transform2 = this.board.background.transform;
			transform.parentInternal = transform2;
			Corner corner = gameObject.AddComponent<Corner>();
			corner.theColumn = theColumn;
			corner.theRow = theRow;
			bool flag2 = this.board.rowNum == 6;
			corner.road = (flag2 ? 1 : 0);
			corner.SetPosition();
			BoxCollider2D boxCollider2D = gameObject.AddComponent<BoxCollider2D>();
			LayerMask zombieLayer = this.zombieLayer;
			boxCollider2D.contactCaptureLayers = zombieLayer;
			LayerMask zombieLayer2 = this.zombieLayer;
			boxCollider2D.callbackLayers = zombieLayer2;
			ulong num2;
			boxCollider2D.isTrigger = num2 != 0UL;
			grid.<Corner>k__BackingField = corner;
		}
		Corner <Corner>k__BackingField2 = grid.<Corner>k__BackingField;
		this.corner = <Corner>k__BackingField2;
		Corner next = this.corner.next;
		int num3 = 0;
		if (!(next == num3))
		{
			Corner next2 = this.corner.next;
			Towards direction = Corner.GetDirection(this.corner, next2);
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x0007CC10 File Offset: 0x0007AE10
	[Token(Token = "0x60016A5")]
	[Address(RVA = "0x51AE50", Offset = "0x519450", VA = "0x18051AE50", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		Board board = this.board;
		mouse.cannonPlant = this;
		GameObject gameObject = GameAPP.itemPrefab[16];
		Vector2 mousePosition = mouse.MousePosition;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		mouse.theItemOnMouse = gameObject2;
		mouse.theItemOnMouse.name = "cannon";
		throw new NullReferenceException();
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x0007CC78 File Offset: 0x0007AE78
	[Token(Token = "0x60016A6")]
	[Address(RVA = "0x51B110", Offset = "0x519710", VA = "0x18051B110", Slot = "62")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		int theMouseRow = mouse.theMouseRow;
		List<Plant> list = global::Lawnf.Get1x1Plants(mouse.theMouseColumn, theMouseRow);
		Func<Plant, bool> func = delegate(Plant p)
		{
			PlantType thePlantType = this.thePlantType;
			return p.thePlantType == thePlantType;
		};
		Plant plant = Enumerable.FirstOrDefault<Plant>(list, func);
		int num = 0;
		if (plant == num)
		{
			this.corner.next = (ulong)0L;
			int num2 = 0;
			this.UpdateTowrds((Towards)num2);
			return;
		}
		if (plant == this)
		{
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			return;
		}
		int thePlantColumn = this.thePlantColumn;
		if (plant.thePlantColumn != thePlantColumn)
		{
			int thePlantRow = this.thePlantRow;
			if (plant.thePlantRow != thePlantRow)
			{
				uint num4;
				GameAPP.PlaySound((int)num4, 0.5f, 1f);
				InGameText instance2 = InGameText.Instance;
				return;
			}
		}
		this.corner.next = plant;
		Corner corner = this.corner;
		Corner corner2 = this.corner;
		Towards towards;
		if (towards != Towards.Right)
		{
		}
		uint num5;
		ulong num6;
		num5.m_value = (uint)num6;
		Corner next = this.corner.next;
		int num7 = 0;
		if (!(next != num7))
		{
			this.attributeCount = (int)((ulong)0L);
			return;
		}
		Corner next2 = this.corner.next;
		int theRow = next2.theRow;
		int theColumn = next2.theColumn;
		this.attributeCount = theColumn;
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x0007CDC0 File Offset: 0x0007AFC0
	[Token(Token = "0x60016A7")]
	[Address(RVA = "0x51BA80", Offset = "0x51A080", VA = "0x18051BA80", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			Corner corner = this.corner;
			SpriteRenderer spriteRenderer = this.r;
			Corner next = corner.next;
			int num = 0;
			if (next != num)
			{
			}
		}
		Board board = this.board;
		int num2 = 0;
		base.Die((Plant.DieReason)num2);
		CreatePlant instance = CreatePlant.Instance;
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x0007CE24 File Offset: 0x0007B024
	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x51B5C0", Offset = "0x519BC0", VA = "0x18051B5C0")]
	private void UpdateTowrds(Towards towards)
	{
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		if (towards != Towards.Left)
		{
			if (towards != Towards.Left)
			{
				if (towards != Towards.Left)
				{
					if (towards != Towards.Right)
					{
						return;
					}
					int num2 = 0;
					child.transform.rotation = num2;
					Transform transform2 = child.transform;
					Transform transform3 = child.transform;
					Vector3 localScale = child.localScale;
				}
				int num3 = 0;
				child.transform.rotation = num3;
				Transform transform4 = child.transform;
				Transform transform5 = child.transform;
				Vector3 localScale2 = child.localScale;
			}
			int num4 = 0;
			child.transform.rotation = num4;
			Transform transform6 = child.transform;
			Transform transform7 = child.transform;
			Vector3 localScale3 = child.localScale;
		}
		int num5 = 0;
		child.transform.rotation = num5;
		Transform transform8 = child.transform;
		Transform transform9 = child.transform;
		Vector3 localScale4 = child.localScale;
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x0007CF10 File Offset: 0x0007B110
	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x51A9E0", Offset = "0x518FE0", VA = "0x18051A9E0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		gridSystem.GetGrid(thePlantColumn, thePlantRow).<Corner>k__BackingField.Die();
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x0007CF50 File Offset: 0x0007B150
	[Token(Token = "0x60016AA")]
	[Address(RVA = "0x51B060", Offset = "0x519660", VA = "0x18051B060")]
	private void SaveTargetInfo()
	{
		Corner next = this.corner.next;
		int num = 0;
		if (!(next != num))
		{
			this.attributeCount = (int)((ulong)0L);
			return;
		}
		Corner next2 = this.corner.next;
		int theRow = next2.theRow;
		int theColumn = next2.theColumn;
		this.attributeCount = theColumn;
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x0007CFA8 File Offset: 0x0007B1A8
	[Token(Token = "0x60016AB")]
	[Address(RVA = "0x51AD10", Offset = "0x519310", VA = "0x18051AD10")]
	private void LoadTargetInfo()
	{
		GridSystem gridSystem = this.board.gridSystem;
		int attributeCount = this.attributeCount;
		BoardGrid boardGrid;
		if (boardGrid != 0)
		{
		}
		int num = 0;
		int num2 = 0;
		if (num != num2)
		{
			Corner corner = this.corner;
			Corner <Corner>k__BackingField = boardGrid.<Corner>k__BackingField;
			corner.next = <Corner>k__BackingField;
			Corner next = this.corner.next;
			Towards direction = Corner.GetDirection(this.corner, next);
		}
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x0007D02C File Offset: 0x0007B22C
	[Token(Token = "0x60016AC")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public VectorPlant()
	{
	}

	// Token: 0x04000E03 RID: 3587
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E03")]
	private Corner corner;

	// Token: 0x04000E04 RID: 3588
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000E04")]
	private SpriteRenderer r;
}
