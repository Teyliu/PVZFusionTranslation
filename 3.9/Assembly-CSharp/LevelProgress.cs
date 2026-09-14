using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000898 RID: 2200
[Token(Token = "0x2000898")]
public class LevelProgress : MonoBehaviour
{
	// Token: 0x06002CE9 RID: 11497 RVA: 0x000F4C60 File Offset: 0x000F2E60
	[Token(Token = "0x6002CE9")]
	[Address(RVA = "0x6D0E20", Offset = "0x6CF420", VA = "0x1806D0E20")]
	private void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06002CEA RID: 11498 RVA: 0x000F4C7C File Offset: 0x000F2E7C
	[Token(Token = "0x6002CEA")]
	[Address(RVA = "0x6D12A0", Offset = "0x6CF8A0", VA = "0x1806D12A0")]
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
				int num3 = 0;
				int size = list._size;
				list.Add(num3);
				list._size = transform;
				transform += transform;
				num++;
				uint num4;
				num4 += (uint)10;
			}
			GridLayoutGroup gridLayoutGroup = this.layout;
		}
		int num5 = 0;
		if (this.flagCount > num5)
		{
			GameObject gameObject2 = this.sampleFlag;
			Transform parent2 = gameObject2.transform.parent;
			Transform transform2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, parent2).transform;
			transform2.SetAsFirstSibling();
			List<ValueTuple<GameObject, int>> list2 = this.flags;
			int num6 = 0;
			int size2 = list2._size;
			list2.Add(num6);
			list2._size = transform2;
			transform2 += transform2;
			num5++;
			uint num7;
			num7 += (uint)10;
		}
		GridLayoutGroup gridLayoutGroup2 = this.layout;
		Image image = this.head;
		bool flag = this.hasHead;
		image.enabled = flag;
		global::UnityEngine.Object.Destroy(this.sampleFlag);
	}

	// Token: 0x06002CEB RID: 11499 RVA: 0x000F4DC8 File Offset: 0x000F2FC8
	[Token(Token = "0x6002CEB")]
	[Address(RVA = "0x6D0E70", Offset = "0x6CF470", VA = "0x1806D0E70")]
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

	// Token: 0x06002CEC RID: 11500 RVA: 0x000F4E50 File Offset: 0x000F3050
	[Token(Token = "0x6002CEC")]
	[Address(RVA = "0x6D1720", Offset = "0x6CFD20", VA = "0x1806D1720")]
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
		int num2;
		if (!(zombie == num))
		{
			Zombie zombie2 = this.zombie;
			num2 = 0;
		}
		Zombie boss = this.GetBoss();
		this.zombie = boss;
		Board board2 = this.board;
		float num3 = this.slider.value;
		Slider slider2 = this.slider;
		if (num2 <= (int)num3)
		{
		}
		float num4 = slider2.value;
		float deltaTime = Time.deltaTime;
		throw new NullReferenceException();
	}

	// Token: 0x06002CED RID: 11501 RVA: 0x000F4EFC File Offset: 0x000F30FC
	[Token(Token = "0x6002CED")]
	[Address(RVA = "0x6D1110", Offset = "0x6CF710", VA = "0x1806D1110")]
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

	// Token: 0x06002CEE RID: 11502 RVA: 0x000F4F44 File Offset: 0x000F3144
	[Token(Token = "0x6002CEE")]
	[Address(RVA = "0x6D1910", Offset = "0x6CFF10", VA = "0x1806D1910")]
	public LevelProgress()
	{
		List<ValueTuple<GameObject, int>> list = new List();
		this.flags = list;
		base..ctor();
	}

	// Token: 0x04001AD0 RID: 6864
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001AD0")]
	private Board board;

	// Token: 0x04001AD1 RID: 6865
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001AD1")]
	private Zombie zombie;

	// Token: 0x04001AD2 RID: 6866
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001AD2")]
	public Slider slider;

	// Token: 0x04001AD3 RID: 6867
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001AD3")]
	public GridLayoutGroup layout;

	// Token: 0x04001AD4 RID: 6868
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AD4")]
	public GameObject sampleFlag;

	// Token: 0x04001AD5 RID: 6869
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AD5")]
	public Image head;

	// Token: 0x04001AD6 RID: 6870
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001AD6")]
	[TupleElementNames(new string[] { "flag", "upWave" })]
	private readonly List<ValueTuple<GameObject, int>> flags;

	// Token: 0x04001AD7 RID: 6871
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001AD7")]
	public bool useValue;

	// Token: 0x04001AD8 RID: 6872
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001AD8")]
	public Func<float> value;

	// Token: 0x04001AD9 RID: 6873
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001AD9")]
	public int flagCount;

	// Token: 0x04001ADA RID: 6874
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001ADA")]
	public bool hasHead;
}
