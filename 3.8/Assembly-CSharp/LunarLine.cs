using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002CA RID: 714
[Token(Token = "0x20002CA")]
public class LunarLine : MonoBehaviour
{
	// Token: 0x06000CC2 RID: 3266 RVA: 0x00049AB8 File Offset: 0x00047CB8
	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x3E7760", Offset = "0x3E5D60", VA = "0x1803E7760")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.lineRenderer = component;
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x00049AD4 File Offset: 0x00047CD4
	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x3E7930", Offset = "0x3E5F30", VA = "0x1803E7930")]
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

	// Token: 0x06000CC4 RID: 3268 RVA: 0x00049B70 File Offset: 0x00047D70
	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x3E7AA0", Offset = "0x3E60A0", VA = "0x1803E7AA0")]
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

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00049C28 File Offset: 0x00047E28
	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x3E77B0", Offset = "0x3E5DB0", VA = "0x1803E77B0")]
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

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00049CB0 File Offset: 0x00047EB0
	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x3E76E0", Offset = "0x3E5CE0", VA = "0x1803E76E0")]
	private void AttackUpdate()
	{
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		LineRenderer lineRenderer = this.lineRenderer;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x00049CE8 File Offset: 0x00047EE8
	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public LunarLine()
	{
	}

	// Token: 0x040008ED RID: 2285
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008ED")]
	public LineRenderer lineRenderer;

	// Token: 0x040008EE RID: 2286
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008EE")]
	public Plant plant;

	// Token: 0x040008EF RID: 2287
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008EF")]
	public Lunar lunar;

	// Token: 0x040008F0 RID: 2288
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008F0")]
	public bool attack;
}
