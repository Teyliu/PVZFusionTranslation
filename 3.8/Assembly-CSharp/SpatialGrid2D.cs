using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000205 RID: 517
[Token(Token = "0x2000205")]
public class SpatialGrid2D : MonoBehaviour
{
	// Token: 0x060008BD RID: 2237 RVA: 0x0002D7C0 File Offset: 0x0002B9C0
	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x86D290", Offset = "0x86B890", VA = "0x18086D290")]
	private void Awake()
	{
		SpatialGrid2D.Instance = this;
		this.gridWidth = typeof(Math).TypeHandle;
		int num = this.gridWidth;
		Dictionary<int, HashSet<Zombie>> dictionary = new Dictionary(num);
		num -= this;
		this.grid = dictionary;
		uint num2;
		Dictionary<Zombie, int> dictionary2 = new Dictionary((int)num2);
		this.zombieCellMap = dictionary2;
		int num3 = this.gridWidth;
		int num4 = this.gridHeight;
		int num5 = this.gridHeight;
		Debug.Log(string.Format("网格初始化: {0}×{1} = {2}个格子", num3, num3, num3));
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x0002D834 File Offset: 0x0002BA34
	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x86E5D0", Offset = "0x86CBD0", VA = "0x18086E5D0")]
	private int WorldToCellIndex(Vector2 worldPos)
	{
		if (this.minX <= worldPos)
		{
			float num = this.maxX;
			if (worldPos > num)
			{
			}
		}
		float num2 = this.minY;
		float num3 = this.maxY;
		return typeof(Math).TypeHandle;
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x0002D86C File Offset: 0x0002BA6C
	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x86DA60", Offset = "0x86C060", VA = "0x18086DA60")]
	private List<int> GetNearbyCellIndices(Vector2 position, float radius)
	{
		uint num;
		List<int> list = new List((int)num);
		if (this.minX <= position)
		{
		}
		float num2 = this.maxX;
		if (position <= num2)
		{
		}
		float num3 = this.minY;
		float num4 = this.maxY;
		return list;
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x86E180", Offset = "0x86C780", VA = "0x18086E180")]
	public List<Zombie> GetNearbyZombies(Vector2 position, float radius, int maxResults = 10, int targetRow = -1)
	{
		List<Zombie> list;
		ulong num4;
		do
		{
			int num = 0;
			list = new List(maxResults);
			bool flag;
			if (flag)
			{
				if (!this.grid.TryGetValue(num, num))
				{
					continue;
				}
				bool flag2;
				if (flag2)
				{
					int num2 = 0;
					if (num == num2)
					{
						continue;
					}
					Vector3 vector;
					float z = vector.z;
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					goto IL_0064;
				}
			}
		}
		while (num4 != (ulong)0L);
		return list;
		IL_0064:
		throw new NullReferenceException();
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x0002D940 File Offset: 0x0002BB40
	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x86DD00", Offset = "0x86C300", VA = "0x18086DD00")]
	public List<Zombie> GetNearbyZombiesInRow(Vector2 position, float xRadius, int row)
	{
		List<Zombie> list;
		ulong num9;
		do
		{
			int num = 0;
			uint num2;
			list = new List((int)num2);
			float boxYFromRow = Mouse.Instance.GetBoxYFromRow(row);
			float num3 = this.minX;
			float num4 = this.maxX;
			if (num3 > position || position > num4)
			{
			}
			float num5 = this.minY;
			float num6 = this.maxY;
			if (num5 > boxYFromRow || boxYFromRow > num6)
			{
			}
			int num7 = this.gridWidth;
			if (num7 >= row)
			{
			}
			Dictionary<int, HashSet<Zombie>> dictionary = this.grid;
			bool flag;
			if (!flag)
			{
				break;
			}
			bool flag2;
			if (flag2)
			{
				int num8 = 0;
				if (num == num8)
				{
					continue;
				}
			}
		}
		while (num9 != (ulong)0L);
		return list;
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x0002DA0C File Offset: 0x0002BC0C
	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x86D500", Offset = "0x86BB00", VA = "0x18086D500")]
	public void BatchGetNearbyZombies(Vector2[] positions, float radius, List<Zombie>[] results, [Optional] int[] targetRows)
	{
		int num3;
		ulong num6;
		do
		{
			int num = 0;
			int num2 = 0;
			num3 = 0;
			if (num3 >= positions.Length)
			{
				return;
			}
			List<Zombie> list = results[num3];
			int size = list._size;
			list._size = (int)((ulong)0L);
			if (size > 0)
			{
			}
			List<int> nearbyCellIndices = this.GetNearbyCellIndices(num2, radius);
			bool flag;
			if (flag)
			{
				if (!this.grid.TryGetValue(num, num))
				{
					continue;
				}
				bool flag2;
				if (flag2)
				{
					int num4 = 0;
					if (num == num4)
					{
						continue;
					}
					if ((ulong)((uint)(-1)) != (ulong)(-1L))
					{
					}
				}
				ulong num5;
				if (num5 != (ulong)0L)
				{
					goto IL_00BB;
				}
			}
		}
		while (num6 != (ulong)0L);
		num3++;
		return;
		IL_00BB:
		throw new NullReferenceException();
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x0002DAE0 File Offset: 0x0002BCE0
	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x86E700", Offset = "0x86CD00", VA = "0x18086E700")]
	public SpatialGrid2D()
	{
	}

	// Token: 0x04000452 RID: 1106
	[Token(Token = "0x4000452")]
	public static SpatialGrid2D Instance;

	// Token: 0x04000453 RID: 1107
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000453")]
	[Header("网格设置 - 针对植物大战僵尸优化")]
	public float cellSizeX = 2.7f;

	// Token: 0x04000454 RID: 1108
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000454")]
	public float cellSizeY = 2.9f;

	// Token: 0x04000455 RID: 1109
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000455")]
	[Header("地图边界")]
	public float minX = -6f;

	// Token: 0x04000456 RID: 1110
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000456")]
	public float maxX = 12f;

	// Token: 0x04000457 RID: 1111
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000457")]
	public float minY = -5f;

	// Token: 0x04000458 RID: 1112
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000458")]
	public float maxY = 5f;

	// Token: 0x04000459 RID: 1113
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000459")]
	[Header("网格维度（自动计算）")]
	public int gridWidth;

	// Token: 0x0400045A RID: 1114
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400045A")]
	public int gridHeight;

	// Token: 0x0400045B RID: 1115
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400045B")]
	private Dictionary<int, HashSet<Zombie>> grid;

	// Token: 0x0400045C RID: 1116
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400045C")]
	private Dictionary<Zombie, int> zombieCellMap;
}
