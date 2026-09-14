using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000211 RID: 529
[Token(Token = "0x2000211")]
public class CreateMower
{
	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060008ED RID: 2285 RVA: 0x0002DFD4 File Offset: 0x0002C1D4
	[Token(Token = "0x170000AC")]
	public static CreateMower Instance
	{
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x8E8920", Offset = "0x8E6F20", VA = "0x1808E8920")]
		get
		{
			return CreateMower._instance;
		}
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x8E82B0", Offset = "0x8E68B0", VA = "0x1808E82B0")]
	public void SetMowers(BoxType[] roadtype)
	{
		int num = 0;
		Board instance = Board.Instance;
		if (num < instance.rowNum)
		{
			Mower mower = this.SetMower((MowerType)num, -6.6f, num);
			num++;
			Board instance2 = Board.Instance;
		}
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x0002E028 File Offset: 0x0002C228
	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x8E7ED0", Offset = "0x8E64D0", VA = "0x1808E7ED0")]
	private void SetMowerOnRoad(BoxType rowtype, int row)
	{
		if (rowtype != (BoxType)(-1))
		{
			int num = 0;
			if (rowtype <= BoxType.River)
			{
			}
			Mower mower = this.SetMower((MowerType)num, -6.6f, row);
		}
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x0002E064 File Offset: 0x0002C264
	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x8E7F40", Offset = "0x8E6540", VA = "0x1808E7F40")]
	public Mower SetMower(MowerType mowerType, float x, int row)
	{
		Dictionary<MowerType, string> pathDic = this.PathDic;
		bool flag;
		if (!flag)
		{
		}
		GameObject gameObject;
		Mower component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject).GetComponent<Mower>();
		string name = gameObject.name;
		string text = string.Format("_{0}", name);
		string text2 = name + text;
		component.name = text2;
		component.theMowerType = mowerType;
		component.theMowerRow = row;
		Board instance = Board.Instance;
		component.board = instance;
		component.MoveWaterUpdate();
		List<Mower> mowerArray = Board.Instance.mowerArray;
		int size = mowerArray._size;
		mowerArray._size = typeof(Board).TypeHandle;
		this.SetTransform(component, row);
		Transform transform = component.transform;
		Transform transform2 = component.transform;
		SortingGroup component2 = component.GetComponent<SortingGroup>();
		string text3 = string.Format("zombie{0}", component2);
		component2.sortingLayerName = text3;
		uint num;
		component2.sortingOrder = (int)num;
		return component;
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x0002E154 File Offset: 0x0002C354
	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x8E83D0", Offset = "0x8E69D0", VA = "0x1808E83D0")]
	private void SetTransform(Mower theMower, int theRow)
	{
		float landY = Mouse.Instance.GetLandY(-6.6f, theRow);
		Board instance = Board.Instance;
		Transform axis = theMower.axis;
		Transform transform = theMower.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = theMower.transform;
		Transform transform3 = Board.Instance.transform;
		transform2.parentInternal = transform3;
		Transform transform4 = theMower.transform;
		Transform transform5 = theMower.transform;
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x0002E1C8 File Offset: 0x0002C3C8
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x8E87C0", Offset = "0x8E6DC0", VA = "0x1808E87C0")]
	public CreateMower()
	{
		Dictionary<MowerType, string> dictionary = new Dictionary();
		int num = 0;
		dictionary.Add(num, "Mower/lawn/LawnMowerPrefab");
		dictionary.Add((uint)1, "Mower/pool/PoolCleanerPrefab");
		dictionary.Add((uint)2, "Mower/cleaner/CleanerPrefab");
		dictionary.Add((uint)3, "Mower/LawnShooter/LawnShooterPrefab");
		dictionary.Add((uint)4, "Mower/SolarMower/SolarMower");
		this.PathDic = dictionary;
		base..ctor();
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x0002E230 File Offset: 0x0002C430
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x8E8610", Offset = "0x8E6C10", VA = "0x1808E8610")]
	static CreateMower()
	{
		CreateMower createMower = new CreateMower();
		Dictionary<MowerType, string> dictionary = new Dictionary();
		int num = 0;
		dictionary.Add(num, "Mower/lawn/LawnMowerPrefab");
		dictionary.Add((uint)1, "Mower/pool/PoolCleanerPrefab");
		dictionary.Add((uint)2, "Mower/cleaner/CleanerPrefab");
		dictionary.Add((uint)3, "Mower/LawnShooter/LawnShooterPrefab");
		dictionary.Add((uint)4, "Mower/SolarMower/SolarMower");
		createMower.PathDic = dictionary;
		CreateMower._instance = createMower;
		throw new NullReferenceException();
	}

	// Token: 0x04000474 RID: 1140
	[Token(Token = "0x4000474")]
	private static readonly CreateMower _instance;

	// Token: 0x04000475 RID: 1141
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000475")]
	private readonly Dictionary<MowerType, string> PathDic;
}
