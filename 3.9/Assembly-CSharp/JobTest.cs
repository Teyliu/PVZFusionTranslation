using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

// Token: 0x02000A3F RID: 2623
[Token(Token = "0x2000A3F")]
public class JobTest : MonoBehaviour
{
	// Token: 0x060035D6 RID: 13782 RVA: 0x0011E688 File Offset: 0x0011C888
	[Token(Token = "0x60035D6")]
	[Address(RVA = "0x7992E0", Offset = "0x7978E0", VA = "0x1807992E0")]
	private void Start()
	{
		int num = 0;
		int num2 = 0;
		this.positions = num;
		this.velocities = num2;
		uint num3;
		List<GameObject> list = new List((int)num3);
		this.objects = list;
		int num4 = 0;
		ulong num5;
		this.velocities.m_Length = (int)num5;
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.prefab);
		int size = this.objects._size;
		num4 += 12;
	}

	// Token: 0x060035D7 RID: 13783 RVA: 0x0011E6F0 File Offset: 0x0011C8F0
	[Token(Token = "0x60035D7")]
	[Address(RVA = "0x799530", Offset = "0x797B30", VA = "0x180799530")]
	private void Update()
	{
		NativeArray<Vector3> nativeArray = this.positions;
		NativeArray<Vector3> nativeArray2 = this.velocities;
		float deltaTime = Time.deltaTime;
		this.jobHandle = 0;
	}

	// Token: 0x060035D8 RID: 13784 RVA: 0x0011E724 File Offset: 0x0011C924
	[Token(Token = "0x60035D8")]
	[Address(RVA = "0x799190", Offset = "0x797790", VA = "0x180799190")]
	private void LateUpdate()
	{
		List<GameObject> list = this.objects;
		int num = 0;
		Transform transform = this.objects[num].transform;
		NativeArray<Vector3> nativeArray = this.positions;
		List<GameObject> list2 = this.objects;
		num++;
		num += 12;
	}

	// Token: 0x060035D9 RID: 13785 RVA: 0x0011E76C File Offset: 0x0011C96C
	[Token(Token = "0x60035D9")]
	[Address(RVA = "0x799270", Offset = "0x797870", VA = "0x180799270")]
	private void OnDestroy()
	{
		if (this.positions != (ulong)0L)
		{
		}
		if (this.velocities != (ulong)0L)
		{
			return;
		}
	}

	// Token: 0x060035DA RID: 13786 RVA: 0x0011E794 File Offset: 0x0011C994
	[Token(Token = "0x60035DA")]
	[Address(RVA = "0x799600", Offset = "0x797C00", VA = "0x180799600")]
	public JobTest()
	{
		List<GameObject> list = new List();
		this.objects = list;
		base..ctor();
	}

	// Token: 0x0400294D RID: 10573
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400294D")]
	private NativeArray<Vector3> positions;

	// Token: 0x0400294E RID: 10574
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400294E")]
	private NativeArray<Vector3> velocities;

	// Token: 0x0400294F RID: 10575
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400294F")]
	private JobHandle jobHandle;

	// Token: 0x04002950 RID: 10576
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002950")]
	private List<GameObject> objects;

	// Token: 0x04002951 RID: 10577
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002951")]
	public GameObject prefab;
}
