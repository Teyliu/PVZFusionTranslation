using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000230 RID: 560
[Token(Token = "0x2000230")]
public class GridItem : MonoBehaviour
{
	// Token: 0x17000084 RID: 132
	// (get) Token: 0x060009DE RID: 2526 RVA: 0x00035AC8 File Offset: 0x00033CC8
	[Token(Token = "0x17000084")]
	protected List<SpriteRenderer> R
	{
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x87DB40", Offset = "0x87C140", VA = "0x18087DB40")]
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

	// Token: 0x060009DF RID: 2527 RVA: 0x00035B38 File Offset: 0x00033D38
	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x87CFE0", Offset = "0x87B5E0", VA = "0x18087CFE0")]
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

	// Token: 0x060009E0 RID: 2528 RVA: 0x00035B9C File Offset: 0x00033D9C
	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x87D080", Offset = "0x87B680", VA = "0x18087D080")]
	private void Flash(float b)
	{
		GameMaterial.SetBrightness(this.R, b);
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00035BB8 File Offset: 0x00033DB8
	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x87CE10", Offset = "0x87B410", VA = "0x18087CE10", Slot = "4")]
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

	// Token: 0x060009E2 RID: 2530 RVA: 0x00035C48 File Offset: 0x00033E48
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "5")]
	protected virtual void DieEvent()
	{
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00035C58 File Offset: 0x00033E58
	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x87D0F0", Offset = "0x87B6F0", VA = "0x18087D0F0")]
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

	// Token: 0x060009E4 RID: 2532 RVA: 0x00035E0C File Offset: 0x0003400C
	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x87D8D0", Offset = "0x87BED0", VA = "0x18087D8D0")]
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

	// Token: 0x060009E5 RID: 2533 RVA: 0x00035E64 File Offset: 0x00034064
	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x87CC90", Offset = "0x87B290", VA = "0x18087CC90")]
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

	// Token: 0x060009E6 RID: 2534 RVA: 0x00035EB0 File Offset: 0x000340B0
	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GridItem()
	{
	}

	// Token: 0x0400052B RID: 1323
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400052B")]
	public GridItemType theItemType;

	// Token: 0x0400052C RID: 1324
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400052C")]
	public int theItemRow;

	// Token: 0x0400052D RID: 1325
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400052D")]
	public int theItemColumn;

	// Token: 0x0400052E RID: 1326
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400052E")]
	public Board board;

	// Token: 0x0400052F RID: 1327
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400052F")]
	private List<SpriteRenderer> _r;

	// Token: 0x04000530 RID: 1328
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000530")]
	protected float lightCountDown;

	// Token: 0x04000531 RID: 1329
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000531")]
	protected bool dying;
}
