using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200024F RID: 591
[Token(Token = "0x200024F")]
public class JigsawManager : MonoBehaviour
{
	// Token: 0x06000A5F RID: 2655 RVA: 0x00038D08 File Offset: 0x00036F08
	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x931F50", Offset = "0x930550", VA = "0x180931F50")]
	private void Awake()
	{
		JigsawManager.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
		this.InitCurrentJig();
		this.showJig = true;
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00038D38 File Offset: 0x00036F38
	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x932F90", Offset = "0x931590", VA = "0x180932F90")]
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

	// Token: 0x06000A61 RID: 2657 RVA: 0x00038D8C File Offset: 0x00036F8C
	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x932700", Offset = "0x930D00", VA = "0x180932700")]
	public void GetRandomShape()
	{
		InGameText instance = InGameText.Instance;
		Transform transform = Camera.main.transform;
		JigsawClip jigsaw = this.GetJigsaw();
		this.jigsawOnMouse = jigsaw;
		throw new NullReferenceException();
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00038DC8 File Offset: 0x00036FC8
	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x9327E0", Offset = "0x930DE0", VA = "0x1809327E0")]
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

	// Token: 0x06000A63 RID: 2659 RVA: 0x00038F08 File Offset: 0x00037108
	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x9330D0", Offset = "0x9316D0", VA = "0x1809330D0")]
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
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x000390E0 File Offset: 0x000372E0
	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x932EA0", Offset = "0x9314A0", VA = "0x180932EA0")]
	private void QuitJigStatus()
	{
		this.showJig = true;
		this.SwitchJigs();
		Time.timeScale = GameAPP.config.gameSpeed;
		this.board.TravelNextRound();
		int num = 0;
		base.enabled = num != 0;
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x0003912C File Offset: 0x0003732C
	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x932000", Offset = "0x930600", VA = "0x180932000")]
	private Vector2 GetBoxCenter(int theColumn, int theRow)
	{
		float boxXFromColumn = global::Lawnf.GetBoxXFromColumn(theColumn);
		float boxYFromRow = global::Lawnf.GetBoxYFromRow(theColumn, 6);
		float boxYFromRow2 = global::Lawnf.GetBoxYFromRow(theRow - 1, 6);
		return default(Vector2);
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x0003915C File Offset: 0x0003735C
	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x932500", Offset = "0x930B00", VA = "0x180932500")]
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

	// Token: 0x06000A67 RID: 2663 RVA: 0x000391FC File Offset: 0x000373FC
	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x932280", Offset = "0x930880", VA = "0x180932280")]
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

	// Token: 0x06000A68 RID: 2664 RVA: 0x000392B0 File Offset: 0x000374B0
	[Token(Token = "0x6000A68")]
	[Address(RVA = "0x932070", Offset = "0x930670", VA = "0x180932070")]
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

	// Token: 0x06000A69 RID: 2665 RVA: 0x000392E0 File Offset: 0x000374E0
	[Token(Token = "0x6000A69")]
	[Address(RVA = "0x9321D0", Offset = "0x9307D0", VA = "0x1809321D0")]
	public static string GetJigName(JigsawType jigsawType)
	{
		Dictionary<JigsawType, ValueTuple<Color, int, string>> jigColor = JigsawManager.JigColor;
		return "";
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00039304 File Offset: 0x00037504
	[Token(Token = "0x6000A6A")]
	[Address(RVA = "0x932130", Offset = "0x930730", VA = "0x180932130")]
	public static int GetJigIndex(JigsawType jigsawType)
	{
		Dictionary<JigsawType, ValueTuple<Color, int, string>> jigColor = JigsawManager.JigColor;
		return -1;
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00039324 File Offset: 0x00037524
	[Token(Token = "0x6000A6B")]
	[Address(RVA = "0x933A60", Offset = "0x932060", VA = "0x180933A60")]
	public JigsawManager()
	{
		List<JigsawClip> list = new List();
		this.jigsawClips = list;
		base..ctor();
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00039344 File Offset: 0x00037544
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x9336C0", Offset = "0x931CC0", VA = "0x1809336C0")]
	static JigsawManager()
	{
		Dictionary<JigsawType, ValueTuple<Color, int, string>> dictionary = new Dictionary();
		JigsawManager.JigColor = dictionary;
	}

	// Token: 0x040005C4 RID: 1476
	[Token(Token = "0x40005C4")]
	public static JigsawManager Instance;

	// Token: 0x040005C5 RID: 1477
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005C5")]
	public JigsawClip jigsawOnMouse;

	// Token: 0x040005C6 RID: 1478
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005C6")]
	public Action endAction;

	// Token: 0x040005C7 RID: 1479
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005C7")]
	public List<JigsawClip> jigsawClips;

	// Token: 0x040005C8 RID: 1480
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005C8")]
	private Board board;

	// Token: 0x040005C9 RID: 1481
	[Token(Token = "0x40005C9")]
	public const int JigLength = 3;

	// Token: 0x040005CA RID: 1482
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005CA")]
	public bool showJig;

	// Token: 0x040005CB RID: 1483
	[Token(Token = "0x40005CB")]
	[TupleElementNames(new string[] { "color", "index", "name" })]
	private static readonly Dictionary<JigsawType, ValueTuple<Color, int, string>> JigColor;
}
