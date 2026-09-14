using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002C7 RID: 711
[Token(Token = "0x20002C7")]
public class FirePoint : MonoBehaviour, IClickable
{
	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00047290 File Offset: 0x00045490
	[Token(Token = "0x170000DF")]
	public FirePoint Tail
	{
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x423220", Offset = "0x421820", VA = "0x180423220")]
		get
		{
			int num = 0;
			if (!(this == num))
			{
				FirePoint firePoint = this.next;
				int num2 = 0;
				if (firePoint != num2)
				{
					FirePoint firePoint2 = this.next;
				}
				return this;
			}
			throw new NullReferenceException();
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000472D0 File Offset: 0x000454D0
	[Token(Token = "0x170000E0")]
	public int Priority
	{
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "4")]
		get
		{
			return 10;
		}
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x000472E0 File Offset: 0x000454E0
	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x420C40", Offset = "0x41F240", VA = "0x180420C40")]
	private void Awake()
	{
		Transform transform = base.transform;
		FirePoint firePoint = this.next;
		Vector3 vector;
		float z = vector.z;
		this.lastPosition.z = z;
		int num = 0;
		if (firePoint != num)
		{
			Transform transform2 = this.next.transform;
		}
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x00047330 File Offset: 0x00045530
	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x420C40", Offset = "0x41F240", VA = "0x180420C40")]
	private void InitializePositionCache()
	{
		Transform transform = base.transform;
		FirePoint firePoint = this.next;
		Vector3 vector;
		float z = vector.z;
		this.lastPosition.z = z;
		int num = 0;
		if (firePoint != num)
		{
			Transform transform2 = this.next.transform;
		}
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x00047380 File Offset: 0x00045580
	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x4221E0", Offset = "0x4207E0", VA = "0x1804221E0")]
	[ProButton]
	public void GenerateFireWalls(Plant plant)
	{
		int num;
		do
		{
			num = 0;
			FirePoint firePoint = this.next;
			int num2 = 0;
			if (firePoint == num2)
			{
				goto IL_00DB;
			}
			GameObject gameObject = this.fireWallPrefab;
			int num3 = 0;
			if (gameObject == num3)
			{
				goto IL_00DB;
			}
			this.ClearFireWalls();
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = this.next.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			this.fireWallTValues._size = num;
			int num4 = this.density;
			bool flag;
			if (flag)
			{
				GameObject gameObject2 = this.fireWallPrefab;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				GameObject gameObject3;
				Transform transform3 = gameObject3.transform;
				Transform transform4 = base.transform;
				transform3.parent = transform4;
				if (gameObject3.TryGetComponent<FireWall>(num))
				{
					FirePoint firePoint2 = this.next;
					num += 32;
				}
				List<GameObject> list = this.fireWalls;
				List<float> list2 = this.fireWallTValues;
			}
		}
		while (num != 0);
		bool flag2;
		if (flag2)
		{
		}
		IL_00DB:
		Debug.LogWarning("FirePoint: next或fireWallPrefab为空，无法生成FireWall");
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x00047498 File Offset: 0x00045698
	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x421D80", Offset = "0x420380", VA = "0x180421D80")]
	public void ClearFireWalls()
	{
		int num2;
		do
		{
			int num = 0;
			List<GameObject> list = this.fireWalls;
			num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				if (!Application.isPlaying)
				{
					global::UnityEngine.Object.DestroyImmediate(num);
				}
				global::UnityEngine.Object.Destroy(num);
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x000474EC File Offset: 0x000456EC
	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x421FB0", Offset = "0x4205B0", VA = "0x180421FB0")]
	[ProButton]
	public void Die()
	{
		List<FirePoint> list = new List();
		int num = 0;
		bool flag = this != num;
		if (flag)
		{
			int size = list._size;
			list._size = (flag ? 1 : 0);
			this.next = this;
		}
		int size2 = list._size;
		int num2 = 0;
		FirePoint firePoint = list[size2];
		firePoint.ClearFireWalls();
		firePoint.next = num2;
		if (!Application.isPlaying)
		{
			global::UnityEngine.Object.DestroyImmediate(firePoint.gameObject);
		}
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x0004756C File Offset: 0x0004576C
	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x421B70", Offset = "0x420170", VA = "0x180421B70")]
	[ProButton]
	public void ClearAllFireWalls()
	{
		ulong num2;
		do
		{
			List<FirePoint> list = new List();
			int num = 0;
			bool flag = this != num;
			if (flag)
			{
				int size = list._size;
				list._size = (flag ? 1 : 0);
				this.next = this;
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x000475C4 File Offset: 0x000457C4
	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x422E10", Offset = "0x421410", VA = "0x180422E10")]
	private void Update()
	{
		if (this.following)
		{
			Transform transform = base.transform;
			Vector2 mousePosition = Mouse.Instance.MousePosition;
		}
		if (this.realtimeUpdate && this.fireWalls != (ulong)0L)
		{
			Transform transform2 = base.transform;
			FirePoint firePoint = this.next;
			Vector3 vector;
			float z = vector.z;
			int num = 0;
			float z2;
			if (firePoint != num)
			{
				Transform transform3 = this.next.transform;
				Vector3 vector2;
				z2 = vector2.z;
			}
			int num2 = 0;
			if (num2 != 0)
			{
				FirePoint firePoint2 = this.next;
				int num3 = 0;
				if (!(firePoint2 != num3) || num2 == 0)
				{
					return;
				}
			}
			this.UpdateFireWalls();
			this.lastPosition.z = z;
			this.lastNextPosition.z = z2;
		}
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x00047690 File Offset: 0x00045890
	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x421240", Offset = "0x41F840", VA = "0x180421240")]
	private void CalculateControlPoints(Vector3 p0, Vector3 p3, [Out] Vector3 p1, [Out] Vector3 p2)
	{
		if (!this.randomOffsetInitialized)
		{
			if (this.randomSeed != 0)
			{
				global::System.Random random = new global::System.Random(this.randomSeed);
			}
			global::System.Random random2 = new global::System.Random();
			float num = this.curveStrength;
			double num2 = random2.NextDouble();
			double num3 = random2.NextDouble();
			double num4 = random2.NextDouble();
			double num5 = random2.NextDouble();
			this.savedOffset1 = num;
			this.savedOffset2 = num;
			double num6 = random2.NextDouble();
			float num7 = (float)(0 * (int)this.randomness * (int)0.2f);
			this.savedLineRandom1 = num7;
			double num8 = random2.NextDouble();
			int num9 = 0;
			this.randomOffsetInitialized = true;
			float num10 = (float)(num9 * (int)this.randomness * (int)0.2f);
			this.savedLineRandom2 = num10;
		}
		float num11 = this.savedOffset1;
		p1.z = num11;
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x0004775C File Offset: 0x0004595C
	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x4229B0", Offset = "0x420FB0", VA = "0x1804229B0")]
	private void UpdateFireWalls()
	{
		int num = 0;
		int num2 = 0;
		if (this.fireWalls != num)
		{
			List<GameObject> list = this.fireWalls;
			List<float> list2 = this.fireWallTValues;
			int size = list._size;
			Transform transform = base.transform;
			FirePoint firePoint = this.next;
			Vector3 vector;
			float z = vector.z;
			Transform transform2 = firePoint.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			List<GameObject> list3 = this.fireWalls;
			List<float> list4 = this.fireWallTValues;
			GameObject gameObject = this.fireWalls[num2];
			int num3 = 0;
			if (!(gameObject == num3))
			{
				float num4 = this.fireWallTValues[num2];
				int num5 = 0;
				gameObject.transform.position = num5;
				if (gameObject.TryGetComponent<FireWall>(num5))
				{
				}
			}
			List<GameObject> list5 = this.fireWalls;
			num2++;
		}
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x0004782C File Offset: 0x00045A2C
	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x4217F0", Offset = "0x41FDF0", VA = "0x1804217F0")]
	private Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x00047844 File Offset: 0x00045A44
	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x421980", Offset = "0x41FF80", VA = "0x180421980")]
	private Vector3 CalculateCubicBezierTangent(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x0004785C File Offset: 0x00045A5C
	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x420D50", Offset = "0x41F350", VA = "0x180420D50")]
	private List<float> CalculateArcLengthSamples(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, int density)
	{
		List<float> list = new List();
		List<float> list2 = new List();
		List<float> list3 = new List();
		float z = p0.z;
		int i = 0;
		float z2 = p2.z;
		if (i != 0)
		{
		}
		i++;
		while (i <= 100)
		{
		}
		int num;
		if (num != 0)
		{
			int num2 = num - 1;
			float num3 = list3[num2];
			num2 = num;
			float num4 = list3[num2];
			int num5 = num - 1;
			float num6 = list2[num5];
			num5 = num;
			float num7 = list2[num5];
		}
		return list;
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x000478F4 File Offset: 0x00045AF4
	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x422990", Offset = "0x420F90", VA = "0x180422990", Slot = "5")]
	public bool OnClick(Mouse mouse)
	{
		bool flag = !this.following;
		this.following = flag;
		return true;
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x00047914 File Offset: 0x00045B14
	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x423130", Offset = "0x421730", VA = "0x180423130")]
	public FirePoint()
	{
		List<GameObject> list = new List();
		this.fireWalls = list;
		List<float> list2 = new List();
		this.fireWallTValues = list2;
		base..ctor();
	}

	// Token: 0x04000895 RID: 2197
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000895")]
	public FirePoint next;

	// Token: 0x04000896 RID: 2198
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000896")]
	public GameObject fireWallPrefab;

	// Token: 0x04000897 RID: 2199
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000897")]
	[Header("贝塞尔曲线配置")]
	[Tooltip("FireWall密度（两个FirePoint之间放置的FireWall数量）")]
	[Range(1f, 50f)]
	public int density = (int)((ulong)5L);

	// Token: 0x04000898 RID: 2200
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000898")]
	[Tooltip("曲线强度系数（控制点偏移距离的比例）")]
	[Range(0.1f, 1f)]
	public float curveStrength = 0.3f;

	// Token: 0x04000899 RID: 2201
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000899")]
	[Tooltip("随机性系数（0=无随机，1=完全随机）")]
	[Range(0f, 1f)]
	public float randomness = 0.5f;

	// Token: 0x0400089A RID: 2202
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400089A")]
	[Tooltip("随机种子（设置为0则每次不同，设置固定值则结果固定）")]
	public int randomSeed;

	// Token: 0x0400089B RID: 2203
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400089B")]
	[Header("预览设置")]
	public bool showCurvePreview = true;

	// Token: 0x0400089C RID: 2204
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400089C")]
	public Color curveColor;

	// Token: 0x0400089D RID: 2205
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400089D")]
	public int curveSegments = (int)((ulong)50L);

	// Token: 0x0400089E RID: 2206
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400089E")]
	[Tooltip("移动FirePoint时实时更新FireWall位置")]
	[Header("实时更新")]
	public bool realtimeUpdate = true;

	// Token: 0x0400089F RID: 2207
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400089F")]
	public List<GameObject> fireWalls;

	// Token: 0x040008A0 RID: 2208
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008A0")]
	public List<float> fireWallTValues;

	// Token: 0x040008A1 RID: 2209
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008A1")]
	private bool randomOffsetInitialized;

	// Token: 0x040008A2 RID: 2210
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40008A2")]
	private float savedOffset1;

	// Token: 0x040008A3 RID: 2211
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008A3")]
	private float savedOffset2;

	// Token: 0x040008A4 RID: 2212
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40008A4")]
	private float savedLineRandom1;

	// Token: 0x040008A5 RID: 2213
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008A5")]
	private float savedLineRandom2;

	// Token: 0x040008A6 RID: 2214
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40008A6")]
	private bool following;

	// Token: 0x040008A7 RID: 2215
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008A7")]
	private Vector3 lastPosition;

	// Token: 0x040008A8 RID: 2216
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40008A8")]
	private Vector3 lastNextPosition;
}
