using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000236 RID: 566
[Token(Token = "0x2000236")]
public class GridItem : MonoBehaviour
{
	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000359D0 File Offset: 0x00033BD0
	[Token(Token = "0x170000C2")]
	protected List<SpriteRenderer> R
	{
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x90D650", Offset = "0x90BC50", VA = "0x18090D650")]
		get
		{
			ulong num2;
			do
			{
				int num = 0;
				if (this._r != num)
				{
					break;
				}
				List<SpriteRenderer> list = new List();
				this._r = list;
				List<GameObject> childs = global::Core.Lawnf.GetChilds(base.transform);
				bool flag;
				if (flag)
				{
					bool flag2;
					while (!flag2)
					{
					}
					List<SpriteRenderer> r = this._r;
				}
			}
			while (num2 != (ulong)0L);
			return this._r;
		}
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00035A40 File Offset: 0x00033C40
	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x90CAF0", Offset = "0x90B0F0", VA = "0x18090CAF0")]
	protected void FlashUpdate()
	{
		float num = this.lightCountDown;
		int num2 = 0;
		if (num > (float)num2)
		{
			if (num > 0.2f || num > (float)num2)
			{
				float num3 = num * -30f;
				this.Flash(num3);
			}
			float num4 = this.lightCountDown;
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.lightCountDown = num4;
			this.Flash(1f);
			this.lightCountDown = 0f;
		}
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00035AA4 File Offset: 0x00033CA4
	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x90CB90", Offset = "0x90B190", VA = "0x18090CB90")]
	private void Flash(float b)
	{
		GameMaterial.SetBrightness(this.R, b);
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00035AC0 File Offset: 0x00033CC0
	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x90C920", Offset = "0x90AF20", VA = "0x18090C920", Slot = "4")]
	public virtual void Die()
	{
		int num = 0;
		if ((this.dying ? 1 : 0) == num)
		{
			Board board = this.board;
			this.dying = true;
			List<GridItem> griditemArray = board.griditemArray;
			if (this.board.griditemArray[num] == this)
			{
				List<GridItem> griditemArray2 = this.board.griditemArray;
				int num2 = 0;
				griditemArray2[num] = num2;
			}
			Board board2 = this.board;
			num++;
			this.DieEvent();
			global::UnityEngine.Object.Destroy(base.gameObject);
			if (base.TryGetComponent<MinesweeperCell>(num))
			{
			}
		}
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00035B50 File Offset: 0x00033D50
	[Token(Token = "0x60009FD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "5")]
	protected virtual void DieEvent()
	{
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00035B60 File Offset: 0x00033D60
	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x90CC00", Offset = "0x90B200", VA = "0x18090CC00")]
	public static GridItem SetGridItem(int theColumn, int theRow, GridItemType theType, GraveType graveType = GraveType.Default)
	{
		int num = 0;
		new GridItem.<>c__DisplayClass13_0().graveType = graveType;
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theColumn);
		float landY = Mouse.Instance.GetLandY(boxXFromColumn, theRow);
		if (typeof(Mouse).TypeHandle <= (ulong)9L)
		{
			if (Board.Instance.gridSystem.GetGrid(theColumn, theRow) != 0)
			{
			}
			List<GameObject> list = new List(GameAPP.resourcesManager.gravePrefabs);
			Predicate<GameObject> predicate;
			int num2 = list.RemoveAll(predicate);
			int num3 = list._size;
			num3 = global::UnityEngine.Random.Range(0, num3);
			GameObject gameObject = list[num3];
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = Board.Instance.transform;
			GameObject gameObject2;
			GridItem component = gameObject2.GetComponent<GridItem>();
			Board instance = Board.Instance;
			component.board = instance;
			component.theItemColumn = theColumn;
			component.theItemRow = theRow;
			component.theItemType = theType;
			if (theType > GridItemType.CraterNight)
			{
				goto IL_0142;
			}
			if (Board.Instance.gridSystem.GetGrid(theColumn, theRow) == 0)
			{
				goto IL_015A;
			}
			Board instance2 = Board.Instance;
		}
		while (theType == GridItemType.Grave)
		{
		}
		Dictionary<GridItemType, GameObject> gridItemPrefabs = GameAPP.resourcesManager.gridItemPrefabs;
		bool flag;
		if (!flag)
		{
			InGameText instance3 = InGameText.Instance;
			string text = string.Format("没有找到类型为{0}的场地物品", instance3);
			instance3.DebugWarning(text);
		}
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		Transform transform2 = Board.Instance.transform;
		IL_0142:
		if (theType != GridItemType.Grave || Board.Instance.gridSystem.GetGrid(theColumn, theRow) != 0)
		{
		}
		IL_015A:
		Board instance4 = Board.Instance;
		GridItem gridItem = instance4.griditemArray[num];
		int num4 = 0;
		if (!(gridItem == num4))
		{
			num++;
		}
		List<GridItem> griditemArray = instance4.griditemArray;
		IntPtr cachedPtr = transform2.m_CachedPtr;
		griditemArray._size = transform2;
		throw new NullReferenceException();
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00035D14 File Offset: 0x00033F14
	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x90D3E0", Offset = "0x90B9E0", VA = "0x18090D3E0")]
	private static void SetLayer(GridItem gridItem, int theRow, GridItemType type, int theColumn)
	{
		bool flag;
		if (!flag)
		{
			SortingGroup sortingGroup = gridItem.AddComponent<SortingGroup>();
		}
		if (type <= GridItemType.ScaryPot_red)
		{
		}
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00035D6C File Offset: 0x00033F6C
	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x90C7A0", Offset = "0x90ADA0", VA = "0x18090C7A0")]
	private static void AddToList(Board board, GridItem item)
	{
		int num = 0;
		List<GridItem> griditemArray = board.griditemArray;
		GridItem gridItem = griditemArray[num];
		bool flag;
		if (!flag)
		{
			num++;
		}
		board.griditemArray[num] = item;
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00035DB8 File Offset: 0x00033FB8
	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GridItem()
	{
	}

	// Token: 0x04000536 RID: 1334
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000536")]
	public GridItemType theItemType;

	// Token: 0x04000537 RID: 1335
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000537")]
	public int theItemRow;

	// Token: 0x04000538 RID: 1336
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000538")]
	public int theItemColumn;

	// Token: 0x04000539 RID: 1337
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000539")]
	public Board board;

	// Token: 0x0400053A RID: 1338
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400053A")]
	private List<SpriteRenderer> _r;

	// Token: 0x0400053B RID: 1339
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400053B")]
	protected float lightCountDown;

	// Token: 0x0400053C RID: 1340
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400053C")]
	protected bool dying;
}
