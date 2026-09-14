using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000498 RID: 1176
[Token(Token = "0x2000498")]
public class VectorPlant : Plant
{
	// Token: 0x06001602 RID: 5634 RVA: 0x0007A094 File Offset: 0x00078294
	[Token(Token = "0x6001602")]
	[Address(RVA = "0x496BD0", Offset = "0x4951D0", VA = "0x180496BD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		SpriteRenderer component = transform.GetChild(num).GetComponent<SpriteRenderer>();
		this.r = component;
		throw new NullReferenceException();
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x0007A0CC File Offset: 0x000782CC
	[Token(Token = "0x6001603")]
	[Address(RVA = "0x497760", Offset = "0x495D60", VA = "0x180497760", Slot = "15")]
	protected override void Start()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x0007A0F0 File Offset: 0x000782F0
	[Token(Token = "0x6001604")]
	[Address(RVA = "0x496CA0", Offset = "0x4952A0", VA = "0x180496CA0")]
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

	// Token: 0x06001605 RID: 5637 RVA: 0x0007A224 File Offset: 0x00078424
	[Token(Token = "0x6001605")]
	[Address(RVA = "0x4970C0", Offset = "0x4956C0", VA = "0x1804970C0", Slot = "62")]
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

	// Token: 0x06001606 RID: 5638 RVA: 0x0007A28C File Offset: 0x0007848C
	[Token(Token = "0x6001606")]
	[Address(RVA = "0x497380", Offset = "0x495980", VA = "0x180497380", Slot = "63")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		int theMouseRow = mouse.theMouseRow;
		Func<Plant, bool> func;
		Plant plant = Enumerable.FirstOrDefault<Plant>(global::Lawnf.Get1x1Plants(mouse.theMouseColumn, theMouseRow), func);
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
			int num4 = 0;
			instance.ShowText("不可指向自己", 3f, num4 != 0);
			return;
		}
		int thePlantColumn = this.thePlantColumn;
		if (plant.thePlantColumn != thePlantColumn)
		{
			int thePlantRow = this.thePlantRow;
			if (plant.thePlantRow != thePlantRow)
			{
				uint num5;
				GameAPP.PlaySound((int)num5, 0.5f, 1f);
				InGameText instance2 = InGameText.Instance;
				int num6 = 0;
				instance2.ShowText("目标必须在同一行或者同一列", 7f, num6 != 0);
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
		uint num7;
		ulong num8;
		num7.m_value = (uint)num8;
		Corner next = this.corner.next;
		int num9 = 0;
		if (!(next != num9))
		{
			this.attributeCount = (int)((ulong)0L);
			return;
		}
		Corner next2 = this.corner.next;
		int theRow = next2.theRow;
		int theColumn = next2.theColumn;
		this.attributeCount = theColumn;
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x0007A3F0 File Offset: 0x000785F0
	[Token(Token = "0x6001607")]
	[Address(RVA = "0x497CD0", Offset = "0x4962D0", VA = "0x180497CD0", Slot = "16")]
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

	// Token: 0x06001608 RID: 5640 RVA: 0x0007A454 File Offset: 0x00078654
	[Token(Token = "0x6001608")]
	[Address(RVA = "0x497810", Offset = "0x495E10", VA = "0x180497810")]
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

	// Token: 0x06001609 RID: 5641 RVA: 0x0007A540 File Offset: 0x00078740
	[Token(Token = "0x6001609")]
	[Address(RVA = "0x496C50", Offset = "0x495250", VA = "0x180496C50", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		gridSystem.GetGrid(thePlantColumn, thePlantRow).<Corner>k__BackingField.Die();
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x0007A580 File Offset: 0x00078780
	[Token(Token = "0x600160A")]
	[Address(RVA = "0x4972D0", Offset = "0x4958D0", VA = "0x1804972D0")]
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

	// Token: 0x0600160B RID: 5643 RVA: 0x0007A5D8 File Offset: 0x000787D8
	[Token(Token = "0x600160B")]
	[Address(RVA = "0x496F80", Offset = "0x495580", VA = "0x180496F80")]
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

	// Token: 0x0600160C RID: 5644 RVA: 0x0007A65C File Offset: 0x0007885C
	[Token(Token = "0x600160C")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public VectorPlant()
	{
	}

	// Token: 0x04000D6A RID: 3434
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D6A")]
	private Corner corner;

	// Token: 0x04000D6B RID: 3435
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D6B")]
	private SpriteRenderer r;
}
