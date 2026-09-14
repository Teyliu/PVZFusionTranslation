using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D8 RID: 728
[Token(Token = "0x20002D8")]
public class LunarLine : MonoBehaviour
{
	// Token: 0x06000D05 RID: 3333 RVA: 0x0004A6A0 File Offset: 0x000488A0
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x4382A0", Offset = "0x4368A0", VA = "0x1804382A0")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.lineRenderer = component;
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x0004A6BC File Offset: 0x000488BC
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x438470", Offset = "0x436A70", VA = "0x180438470")]
	private void Start()
	{
		Plant plant = this.plant;
		int num = 0;
		if (plant != num)
		{
			if (this.attack)
			{
				goto IL_0066;
			}
			Plant plant2 = this.plant;
			LineRenderer lineRenderer = this.lineRenderer;
			Transform axis = plant2.axis;
			Vector3 vector;
			float z = vector.z;
			Lunar lunar = this.lunar;
			LineRenderer lineRenderer2 = this.lineRenderer;
			Transform transform = lunar.transform;
			Vector3 vector2;
			float z2 = vector2.z;
		}
		if (!this.attack)
		{
			return;
		}
		IL_0066:
		Transform transform2 = base.transform;
		int num2 = 0;
		transform2.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06000D07 RID: 3335 RVA: 0x0004A758 File Offset: 0x00048958
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x4385E0", Offset = "0x436BE0", VA = "0x1804385E0")]
	private void Update()
	{
		if (this.attack)
		{
			Transform transform = base.transform;
			int num = 0;
			Transform child = transform.GetChild(num);
			LineRenderer lineRenderer = this.lineRenderer;
			Vector3 vector;
			float z = vector.z;
			return;
		}
		Plant plant = this.plant;
		int num2 = 0;
		if (!(plant != num2))
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			bool flag = this.lunar.lines.Remove(this);
			return;
		}
		Plant plant2 = this.plant;
		LineRenderer lineRenderer2 = this.lineRenderer;
		Transform axis = plant2.axis;
		Vector3 vector2;
		float z2 = vector2.z;
		Lunar lunar = this.lunar;
		LineRenderer lineRenderer3 = this.lineRenderer;
		Transform transform2 = lunar.transform;
		Vector3 vector3;
		float z3 = vector3.z;
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x0004A810 File Offset: 0x00048A10
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x4382F0", Offset = "0x4368F0", VA = "0x1804382F0")]
	private void NormalUpdate()
	{
		Plant plant = this.plant;
		int num = 0;
		if (!(plant != num))
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			bool flag = this.lunar.lines.Remove(this);
			return;
		}
		Plant plant2 = this.plant;
		LineRenderer lineRenderer = this.lineRenderer;
		Transform axis = plant2.axis;
		Vector3 vector;
		float z = vector.z;
		Lunar lunar = this.lunar;
		LineRenderer lineRenderer2 = this.lineRenderer;
		Transform transform = lunar.transform;
		Vector3 vector2;
		float z2 = vector2.z;
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x0004A898 File Offset: 0x00048A98
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x438220", Offset = "0x436820", VA = "0x180438220")]
	private void AttackUpdate()
	{
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		LineRenderer lineRenderer = this.lineRenderer;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x0004A8D0 File Offset: 0x00048AD0
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public LunarLine()
	{
	}

	// Token: 0x0400092A RID: 2346
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400092A")]
	public LineRenderer lineRenderer;

	// Token: 0x0400092B RID: 2347
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400092B")]
	public Plant plant;

	// Token: 0x0400092C RID: 2348
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400092C")]
	public Lunar lunar;

	// Token: 0x0400092D RID: 2349
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400092D")]
	public bool attack;
}
