using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200020C RID: 524
[Token(Token = "0x200020C")]
public class SpatialGrid2D : MonoBehaviour
{
	// Token: 0x060008D7 RID: 2263 RVA: 0x0002D7BC File Offset: 0x0002B9BC
	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x8FCD90", Offset = "0x8FB390", VA = "0x1808FCD90")]
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

	// Token: 0x060008D8 RID: 2264 RVA: 0x0002D830 File Offset: 0x0002BA30
	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x8FE0D0", Offset = "0x8FC6D0", VA = "0x1808FE0D0")]
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

	// Token: 0x060008D9 RID: 2265 RVA: 0x0002D868 File Offset: 0x0002BA68
	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x8FD560", Offset = "0x8FBB60", VA = "0x1808FD560")]
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

	// Token: 0x060008DA RID: 2266 RVA: 0x0002D8B4 File Offset: 0x0002BAB4
	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x8FDC80", Offset = "0x8FC280", VA = "0x1808FDC80")]
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

	// Token: 0x060008DB RID: 2267 RVA: 0x0002D93C File Offset: 0x0002BB3C
	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x8FD800", Offset = "0x8FBE00", VA = "0x1808FD800")]
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

	// Token: 0x060008DC RID: 2268 RVA: 0x0002DA08 File Offset: 0x0002BC08
	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x8FD000", Offset = "0x8FB600", VA = "0x1808FD000")]
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

	// Token: 0x060008DD RID: 2269 RVA: 0x0002DADC File Offset: 0x0002BCDC
	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x8FE200", Offset = "0x8FC800", VA = "0x1808FE200")]
	public SpatialGrid2D()
	{
	}

	// Token: 0x0400045C RID: 1116
	[Token(Token = "0x400045C")]
	public static SpatialGrid2D Instance;

	// Token: 0x0400045D RID: 1117
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400045D")]
	[Header("网格设置 - 针对植物大战僵尸优化")]
	public float cellSizeX = 2.7f;

	// Token: 0x0400045E RID: 1118
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400045E")]
	public float cellSizeY = 2.9f;

	// Token: 0x0400045F RID: 1119
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400045F")]
	[Header("地图边界")]
	public float minX = -6f;

	// Token: 0x04000460 RID: 1120
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000460")]
	public float maxX = 12f;

	// Token: 0x04000461 RID: 1121
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000461")]
	public float minY = -5f;

	// Token: 0x04000462 RID: 1122
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000462")]
	public float maxY = 5f;

	// Token: 0x04000463 RID: 1123
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000463")]
	[Header("网格维度（自动计算）")]
	public int gridWidth;

	// Token: 0x04000464 RID: 1124
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000464")]
	public int gridHeight;

	// Token: 0x04000465 RID: 1125
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000465")]
	private Dictionary<int, HashSet<Zombie>> grid;

	// Token: 0x04000466 RID: 1126
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000466")]
	private Dictionary<Zombie, int> zombieCellMap;
}
