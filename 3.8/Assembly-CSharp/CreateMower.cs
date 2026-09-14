using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200020A RID: 522
[Token(Token = "0x200020A")]
public class CreateMower
{
	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
	[Token(Token = "0x1700006F")]
	public static CreateMower Instance
	{
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x859C40", Offset = "0x858240", VA = "0x180859C40")]
		get
		{
			return CreateMower._instance;
		}
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x0002DFEC File Offset: 0x0002C1EC
	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x8595D0", Offset = "0x857BD0", VA = "0x1808595D0")]
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

	// Token: 0x060008D5 RID: 2261 RVA: 0x0002E02C File Offset: 0x0002C22C
	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x8591F0", Offset = "0x8577F0", VA = "0x1808591F0")]
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

	// Token: 0x060008D6 RID: 2262 RVA: 0x0002E054 File Offset: 0x0002C254
	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x859260", Offset = "0x857860", VA = "0x180859260")]
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

	// Token: 0x060008D7 RID: 2263 RVA: 0x0002E144 File Offset: 0x0002C344
	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x8596F0", Offset = "0x857CF0", VA = "0x1808596F0")]
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

	// Token: 0x060008D8 RID: 2264 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x859AE0", Offset = "0x8580E0", VA = "0x180859AE0")]
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

	// Token: 0x060008D9 RID: 2265 RVA: 0x0002E220 File Offset: 0x0002C420
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x859930", Offset = "0x857F30", VA = "0x180859930")]
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

	// Token: 0x0400046A RID: 1130
	[Token(Token = "0x400046A")]
	private static readonly CreateMower _instance;

	// Token: 0x0400046B RID: 1131
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400046B")]
	private readonly Dictionary<MowerType, string> PathDic;
}
