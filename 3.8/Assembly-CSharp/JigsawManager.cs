using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000249 RID: 585
[Token(Token = "0x2000249")]
public class JigsawManager : MonoBehaviour
{
	// Token: 0x06000A44 RID: 2628 RVA: 0x00038EA8 File Offset: 0x000370A8
	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x8A1FB0", Offset = "0x8A05B0", VA = "0x1808A1FB0")]
	private void Awake()
	{
		JigsawManager.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
		this.InitCurrentJig();
		this.showJig = true;
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x00038ED8 File Offset: 0x000370D8
	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x8A2FD0", Offset = "0x8A15D0", VA = "0x1808A2FD0")]
	public void SwitchJigs()
	{
		ulong num2;
		do
		{
			int num = 0;
			bool flag = (this.showJig ? 1 : 0) == num;
			this.showJig = flag;
			List<JigsawClip> list = this.jigsawClips;
			bool flag2;
			if (flag2)
			{
				bool flag3 = this.showJig;
				GameObject gameObject;
				gameObject.SetActive(flag3);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00038F2C File Offset: 0x0003712C
	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x8A2760", Offset = "0x8A0D60", VA = "0x1808A2760")]
	public void GetRandomShape()
	{
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("左键放下拼图\n紫色：增伤 绿色：减伤 淡蓝色：增加射速\n红色：治疗加成 黄色：3x3替伤 灰色：防压", 120f, num != 0);
		Transform transform = Camera.main.transform;
		JigsawClip jigsaw = this.GetJigsaw();
		this.jigsawOnMouse = jigsaw;
		throw new NullReferenceException();
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00038F7C File Offset: 0x0003717C
	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x8A2830", Offset = "0x8A0E30", VA = "0x1808A2830")]
	private void InitCurrentJig()
	{
		int num3;
		int num4;
		ulong num6;
		do
		{
			int num = 0;
			List<JigsawClip> list = this.jigsawClips;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_00F4;
			}
			num3 = 0;
			num4 = 0;
			BoardGrid boardGrid;
			List<JigsawType> jigsaws = boardGrid.jigsaws;
			bool flag2;
			if (flag2)
			{
				while (num == 0)
				{
				}
				Transform transform;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Jigsaw/JigSawClip"), transform);
				Transform transform2 = gameObject2.transform;
				Transform transform3 = gameObject2.transform;
				Vector3 vector;
				float z = vector.z;
				JigsawClip component = gameObject2.GetComponent<JigsawClip>();
				SpriteRenderer r = component.r;
				SortingGroup sortingGroup = component.AddComponent<SortingGroup>();
				int num5;
				string text = string.Format("particle{0}", num5);
				sortingGroup.sortingLayerName = text;
				component.jigsawType = (JigsawType)num;
				SpriteRenderer r2 = component.r;
				List<Sprite> jigSprites = component.jigSprites;
				int jigIndex = JigsawManager.GetJigIndex((JigsawType)num);
				Sprite sprite = jigSprites[jigIndex];
				r2.sprite = sprite;
			}
		}
		while (num6 != (ulong)0L);
		num4++;
		num3++;
		return;
		IL_00F4:
		throw new NullReferenceException();
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x000390BC File Offset: 0x000372BC
	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x8A3110", Offset = "0x8A1710", VA = "0x1808A3110")]
	private void Update()
	{
		ulong num6;
		do
		{
			int num = 0;
			JigsawClip jigsawClip = this.jigsawOnMouse;
			int num2 = 0;
			if (!(jigsawClip != num2))
			{
				break;
			}
			JigsawClip jigsawClip2 = this.jigsawOnMouse;
			int theMouseColumn = Mouse.Instance.theMouseColumn;
			jigsawClip2.theColumn = theMouseColumn;
			JigsawClip jigsawClip3 = this.jigsawOnMouse;
			int theMouseRow = Mouse.Instance.theMouseRow;
			jigsawClip3.theRow = theMouseRow;
			Transform transform = this.jigsawOnMouse.transform;
			JigsawClip jigsawClip4 = this.jigsawOnMouse;
			int theRow = jigsawClip4.theRow;
			int num3 = jigsawClip4.theColumn;
			float boxXFromColumn = global::Lawnf.GetBoxXFromColumn(num3);
			num3 = theRow;
			float boxYFromRow = global::Lawnf.GetBoxYFromRow(num3, 6);
			float boxYFromRow2 = global::Lawnf.GetBoxYFromRow(theRow - 1, 6);
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			GridSystem gridSystem = this.board.gridSystem;
			JigsawClip jigsawClip5 = this.jigsawOnMouse;
			int theColumn = jigsawClip5.theColumn;
			int theRow2 = jigsawClip5.theRow;
			List<JigsawType> jigsaws = gridSystem.GetGrid(theColumn, theRow2).jigsaws;
			JigsawType jigsawType = this.jigsawOnMouse.jigsawType;
			int num4 = jigsaws._size + 1;
			jigsaws._size = num4;
			this.board.SaveJiasawToList();
			global::UnityEngine.Object.Destroy(this.jigsawOnMouse.gameObject);
			this.InitCurrentJig();
			Time.timeScale = GameAPP.config.gameSpeed;
			this.showJig = true;
			this.SwitchJigs();
			int num5 = 0;
			base.enabled = num5 != 0;
			List<BaseMenu> list = GameAPP.UIManager.Peak();
			bool flag;
			if (flag)
			{
				TypeCode typeCode = num.GetTypeCode();
			}
		}
		while (num6 != (ulong)0L);
		if (Input.GetMouseButtonDown(0))
		{
			this.showJig = true;
			this.SwitchJigs();
			Time.timeScale = GameAPP.config.gameSpeed;
			this.board.TravelNextRound();
			int num7 = 0;
			base.enabled = num7 != 0;
			InGameText instance = InGameText.Instance;
			throw new NullReferenceException();
		}
		InGameText instance2 = InGameText.Instance;
		int num8 = 0;
		instance2.ShowText("点击屏幕继续", 0.5f, num8 != 0);
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x000392A8 File Offset: 0x000374A8
	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x8A2EF0", Offset = "0x8A14F0", VA = "0x1808A2EF0")]
	private void QuitJigStatus()
	{
		this.showJig = true;
		this.SwitchJigs();
		Time.timeScale = GameAPP.config.gameSpeed;
		this.board.TravelNextRound();
		int num = 0;
		base.enabled = num != 0;
		InGameText instance = InGameText.Instance;
		int num2 = 0;
		instance.ShowText("", 0.01f, num2 != 0);
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x00039308 File Offset: 0x00037508
	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x8A2060", Offset = "0x8A0660", VA = "0x1808A2060")]
	private Vector2 GetBoxCenter(int theColumn, int theRow)
	{
		float boxXFromColumn = global::Lawnf.GetBoxXFromColumn(theColumn);
		float boxYFromRow = global::Lawnf.GetBoxYFromRow(theColumn, 6);
		float boxYFromRow2 = global::Lawnf.GetBoxYFromRow(theRow - 1, 6);
		return default(Vector2);
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x00039338 File Offset: 0x00037538
	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x8A2560", Offset = "0x8A0B60", VA = "0x1808A2560")]
	private JigsawType GetRandomJigsawType()
	{
		Array values = Enum.GetValues(typeof(JigsawType));
		if (values == 0 || values != 0)
		{
			List<JigsawType> list = Enumerable.ToList<JigsawType>(values);
			int num = 0;
			bool flag = list.Remove(num);
			bool flag2 = list.Remove((uint)1);
			if (this.board.theCurrentSurvivalRound > 1)
			{
				if (global::UnityEngine.Random.Range(0, 5) != 0)
				{
					bool flag3 = list.Remove((uint)6);
				}
				if (global::UnityEngine.Random.Range(0, 4) == 0)
				{
					goto IL_0073;
				}
			}
			bool flag4 = list.Remove((uint)6);
			bool flag5 = list.Remove((uint)7);
			IL_0073:
			int num2 = list._size;
			num2 = global::UnityEngine.Random.Range(0, num2);
			return list[num2];
		}
		throw new InvalidCastException();
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x000393D8 File Offset: 0x000375D8
	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x8A22E0", Offset = "0x8A08E0", VA = "0x1808A22E0")]
	private JigsawClip GetJigsaw()
	{
		GameObject gameObject = Resources.Load<GameObject>("Jigsaw/JigSawClip");
		Transform transform = this.board.transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
		Transform transform2 = gameObject2.transform;
		Vector3 vector;
		float z = vector.z;
		JigsawClip component = gameObject2.GetComponent<JigsawClip>();
		JigsawType randomJigsawType = this.GetRandomJigsawType();
		component.jigsawType = randomJigsawType;
		SpriteRenderer r = component.r;
		JigsawType jigsawType = component.jigsawType;
		SpriteRenderer r2 = component.r;
		List<Sprite> jigSprites = component.jigSprites;
		int jigIndex = JigsawManager.GetJigIndex(jigsawType);
		Sprite sprite = jigSprites[jigIndex];
		r2.sprite = sprite;
		component.AddComponent<SortingGroup>().sortingLayerName = "up";
		return component;
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x0003948C File Offset: 0x0003768C
	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x8A20D0", Offset = "0x8A06D0", VA = "0x1808A20D0")]
	public static Color GetJigColor(JigsawType jigsawType)
	{
		int num = 0;
		Dictionary<JigsawType, ValueTuple<Color, int, string>> jigColor = JigsawManager.JigColor;
		bool flag;
		if (!flag)
		{
		}
		jigsawType.value__ = num;
		throw new NullReferenceException();
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x000394BC File Offset: 0x000376BC
	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x8A2230", Offset = "0x8A0830", VA = "0x1808A2230")]
	public static string GetJigName(JigsawType jigsawType)
	{
		Dictionary<JigsawType, ValueTuple<Color, int, string>> jigColor = JigsawManager.JigColor;
		return "";
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x000394E0 File Offset: 0x000376E0
	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x8A2190", Offset = "0x8A0790", VA = "0x1808A2190")]
	public static int GetJigIndex(JigsawType jigsawType)
	{
		Dictionary<JigsawType, ValueTuple<Color, int, string>> jigColor = JigsawManager.JigColor;
		return -1;
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x00039500 File Offset: 0x00037700
	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x8A3A80", Offset = "0x8A2080", VA = "0x1808A3A80")]
	public JigsawManager()
	{
		List<JigsawClip> list = new List();
		this.jigsawClips = list;
		base..ctor();
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x00039520 File Offset: 0x00037720
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x8A36E0", Offset = "0x8A1CE0", VA = "0x1808A36E0")]
	static JigsawManager()
	{
		Dictionary<JigsawType, ValueTuple<Color, int, string>> dictionary = new Dictionary();
		JigsawManager.JigColor = dictionary;
	}

	// Token: 0x040005B9 RID: 1465
	[Token(Token = "0x40005B9")]
	public static JigsawManager Instance;

	// Token: 0x040005BA RID: 1466
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005BA")]
	public JigsawClip jigsawOnMouse;

	// Token: 0x040005BB RID: 1467
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005BB")]
	public Action endAction;

	// Token: 0x040005BC RID: 1468
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005BC")]
	public List<JigsawClip> jigsawClips;

	// Token: 0x040005BD RID: 1469
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005BD")]
	private Board board;

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x40005BE")]
	public const int JigLength = 3;

	// Token: 0x040005BF RID: 1471
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005BF")]
	public bool showJig;

	// Token: 0x040005C0 RID: 1472
	[Token(Token = "0x40005C0")]
	[TupleElementNames(new string[] { "color", "index", "name" })]
	private static readonly Dictionary<JigsawType, ValueTuple<Color, int, string>> JigColor;
}
