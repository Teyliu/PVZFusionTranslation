using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A40 RID: 2624
[Token(Token = "0x2000A40")]
public class JobTest2 : MonoBehaviour
{
	// Token: 0x060035DB RID: 13787 RVA: 0x0011E7B4 File Offset: 0x0011C9B4
	[Token(Token = "0x60035DB")]
	[Address(RVA = "0x798DF0", Offset = "0x7973F0", VA = "0x180798DF0")]
	private void Start()
	{
		uint num;
		List<GameObject> list = new List((int)num);
		this.objects = list;
		int num2 = 0;
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(this.prefab);
		int size = this.objects._size;
		num2++;
	}

	// Token: 0x060035DC RID: 13788 RVA: 0x0011E7F8 File Offset: 0x0011C9F8
	[Token(Token = "0x60035DC")]
	[Address(RVA = "0x798F40", Offset = "0x797540", VA = "0x180798F40")]
	private void Update()
	{
		List<GameObject> list = this.objects;
		int num = 0;
		Transform transform = this.objects[num].transform;
		Transform transform2 = this.objects[num].transform;
		float deltaTime = Time.deltaTime;
		List<GameObject> list2 = this.objects;
		num++;
	}

	// Token: 0x060035DD RID: 13789 RVA: 0x0011E850 File Offset: 0x0011CA50
	[Token(Token = "0x60035DD")]
	[Address(RVA = "0x799110", Offset = "0x797710", VA = "0x180799110")]
	public JobTest2()
	{
		List<GameObject> list = new List();
		this.objects = list;
		base..ctor();
	}

	// Token: 0x04002952 RID: 10578
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002952")]
	private List<GameObject> objects;

	// Token: 0x04002953 RID: 10579
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002953")]
	public GameObject prefab;
}
