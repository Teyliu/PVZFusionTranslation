using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200085C RID: 2140
[Token(Token = "0x200085C")]
public class LevelProgress : MonoBehaviour
{
	// Token: 0x06002BB7 RID: 11191 RVA: 0x000F0008 File Offset: 0x000EE208
	[Token(Token = "0x6002BB7")]
	[Address(RVA = "0x66C310", Offset = "0x66A910", VA = "0x18066C310")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06002BB8 RID: 11192 RVA: 0x000F0024 File Offset: 0x000EE224
	[Token(Token = "0x6002BB8")]
	[Address(RVA = "0x66C790", Offset = "0x66AD90", VA = "0x18066C790")]
	private void Start()
	{
		if (!this.useValue)
		{
			Board board = this.board;
			int num = 0;
			ulong num2;
			num2 += num2;
			if (num2 > (ulong)0L)
			{
				GameObject gameObject = this.sampleFlag;
				Transform parent = gameObject.transform.parent;
				Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, parent).transform;
				transform.SetAsFirstSibling();
				List<ValueTuple<GameObject, int>> list = this.flags;
				int size = list._size;
				list._size = transform;
				transform += transform;
				num++;
				uint num3;
				num3 += (uint)10;
			}
			GridLayoutGroup gridLayoutGroup = this.layout;
		}
		int num4 = 0;
		if (this.flagCount > num4)
		{
			GameObject gameObject2 = this.sampleFlag;
			Transform parent2 = gameObject2.transform.parent;
			Transform transform2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, parent2).transform;
			transform2.SetAsFirstSibling();
			List<ValueTuple<GameObject, int>> list2 = this.flags;
			int size2 = list2._size;
			list2._size = transform2;
			transform2 += transform2;
			num4++;
			uint num5;
			num5 += (uint)10;
		}
		GridLayoutGroup gridLayoutGroup2 = this.layout;
		Image image = this.head;
		bool flag = this.hasHead;
		image.enabled = flag;
		global::UnityEngine.Object.Destroy(this.sampleFlag);
	}

	// Token: 0x06002BB9 RID: 11193 RVA: 0x000F015C File Offset: 0x000EE35C
	[Token(Token = "0x6002BB9")]
	[Address(RVA = "0x66C360", Offset = "0x66A960", VA = "0x18066C360")]
	private void FlagUpdate()
	{
		ulong num3;
		do
		{
			List<ValueTuple<GameObject, int>> list = this.flags;
			bool flag;
			if (flag)
			{
				Board board = this.board;
				int num = 0;
				Transform transform2;
				Transform transform = transform2.GetChild(num).transform;
				int num2 = 0;
				Transform transform4;
				Transform transform3 = transform4.GetChild(num2).transform;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06002BBA RID: 11194 RVA: 0x000F01E4 File Offset: 0x000EE3E4
	[Token(Token = "0x6002BBA")]
	[Address(RVA = "0x66CC10", Offset = "0x66B210", VA = "0x18066CC10")]
	private void Update()
	{
		if (this.useValue && this.value != (ulong)0L)
		{
			Func<float> func = this.value;
			Slider slider = this.slider;
			this.FlagUpdate();
			return;
		}
		Board board = this.board;
		Zombie zombie = this.zombie;
		int num = 0;
		if (!(zombie == num))
		{
			Zombie zombie2 = this.zombie;
		}
		Zombie boss = this.GetBoss();
		this.zombie = boss;
		Board board2 = this.board;
		float num2 = this.slider.value;
		float num3 = this.slider.value;
		float deltaTime = Time.deltaTime;
		throw new NullReferenceException();
	}

	// Token: 0x06002BBB RID: 11195 RVA: 0x000F0280 File Offset: 0x000EE480
	[Token(Token = "0x6002BBB")]
	[Address(RVA = "0x66C600", Offset = "0x66AC00", VA = "0x18066C600")]
	private Zombie GetBoss()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06002BBC RID: 11196 RVA: 0x000F02C8 File Offset: 0x000EE4C8
	[Token(Token = "0x6002BBC")]
	[Address(RVA = "0x66CDF0", Offset = "0x66B3F0", VA = "0x18066CDF0")]
	public LevelProgress()
	{
		List<ValueTuple<GameObject, int>> list = new List();
		this.flags = list;
		base..ctor();
	}

	// Token: 0x040019E2 RID: 6626
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019E2")]
	private Board board;

	// Token: 0x040019E3 RID: 6627
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40019E3")]
	private Zombie zombie;

	// Token: 0x040019E4 RID: 6628
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019E4")]
	public Slider slider;

	// Token: 0x040019E5 RID: 6629
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40019E5")]
	public GridLayoutGroup layout;

	// Token: 0x040019E6 RID: 6630
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019E6")]
	public GameObject sampleFlag;

	// Token: 0x040019E7 RID: 6631
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40019E7")]
	public Image head;

	// Token: 0x040019E8 RID: 6632
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40019E8")]
	[TupleElementNames(new string[] { "flag", "upWave" })]
	private readonly List<ValueTuple<GameObject, int>> flags;

	// Token: 0x040019E9 RID: 6633
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40019E9")]
	public bool useValue;

	// Token: 0x040019EA RID: 6634
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40019EA")]
	public Func<float> value;

	// Token: 0x040019EB RID: 6635
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40019EB")]
	public int flagCount;

	// Token: 0x040019EC RID: 6636
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40019EC")]
	public bool hasHead;
}
