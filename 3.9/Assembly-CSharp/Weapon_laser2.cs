using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007D9 RID: 2009
[Token(Token = "0x20007D9")]
public class Weapon_laser2 : PlayerWeapon
{
	// Token: 0x060028DD RID: 10461 RVA: 0x000DC378 File Offset: 0x000DA578
	[Token(Token = "0x60028DD")]
	[Address(RVA = "0x678950", Offset = "0x676F50", VA = "0x180678950", Slot = "7")]
	protected override void Awake()
	{
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
		LineRenderer componentInChildren = base.transform.GetComponentInChildren<LineRenderer>();
		this.r = componentInChildren;
		Mouse instance = Mouse.Instance;
		int num = 0;
		int num2 = 0;
		float landY = instance.GetLandY((float)num2, num);
		this.reflectionMaxY = landY;
		Board instance2 = Board.Instance;
		Mouse instance3 = Mouse.Instance;
		int rowNum = instance2.rowNum;
		int num3 = 0;
		float landY2 = instance3.GetLandY((float)num3, rowNum);
		this.reflectionMinY = landY2;
	}

	// Token: 0x060028DE RID: 10462 RVA: 0x000DC414 File Offset: 0x000DA614
	[Token(Token = "0x60028DE")]
	[Address(RVA = "0x678AE0", Offset = "0x6770E0", VA = "0x180678AE0", Slot = "9")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Transform transform = base.transform;
		Vector3 vector;
		float z2 = vector.z;
		Transform transform2 = base.transform;
		if (z2 * 57.29578f > 80f)
		{
		}
		Transform transform3 = base.transform;
		int num = 0;
		base.transform.rotation = num;
	}

	// Token: 0x060028DF RID: 10463 RVA: 0x000DC484 File Offset: 0x000DA684
	[Token(Token = "0x60028DF")]
	[Address(RVA = "0x6793E0", Offset = "0x6779E0", VA = "0x1806793E0")]
	private void UpdateLaserPath(Vector2 origin, Vector2 direction)
	{
		List<Vector3> list = new List();
		int size = list._size;
		list._size = list;
		int num = this.reflectionCount;
		int num2 = 0;
		float boardMaxX = Board.Instance.boardMaxX;
		float num3 = this.reflectionMaxY;
		if (num2 == 0)
		{
		}
		if (num2 != 0 || num != 0)
		{
		}
		LineRenderer lineRenderer = this.r;
		int size2 = list._size;
		lineRenderer.positionCount = size2;
		LineRenderer lineRenderer2 = this.r;
		num2++;
	}

	// Token: 0x060028E0 RID: 10464 RVA: 0x000DC50C File Offset: 0x000DA70C
	[Token(Token = "0x60028E0")]
	[Address(RVA = "0x678DA0", Offset = "0x6773A0", VA = "0x180678DA0", Slot = "10")]
	protected override void Shoot()
	{
		LineRenderer lineRenderer = this.r;
		int num = 0;
		int num2 = 0;
		Vector3[] array = new Vector3[lineRenderer.positionCount];
		if (this.r.GetPositions(array) - 1 > 0)
		{
			int num3 = this.zombieLayer;
			int i;
			if (this.player.moving)
			{
				RaycastHit2D[] array2;
				if (num < array2.Length)
				{
					int num4 = 0;
					Collider2D collider2D;
					bool flag;
					if (collider2D.TryGetComponent<Zombie>(num4) && flag)
					{
						int num5 = 0;
						int attackDamage = base.AttackDamage;
						int num6 = num2.System.IConvertible.ToInt32(num5);
					}
					num++;
				}
				this.r.startWidth = 0.3f;
				this.r.endWidth = 0.3f;
				num++;
				i = 0;
			}
			while (i >= array.Length)
			{
			}
			int num7 = 0;
			Collider2D collider2D2;
			bool flag2;
			if (collider2D2.TryGetComponent<Zombie>(num7) && flag2)
			{
				int attackDamage2 = base.AttackDamage;
			}
			i++;
		}
		float num8 = global::UnityEngine.Random.Range(0.8f, 1.2f);
		uint num9;
		GameAPP.PlaySound((int)num9, 0.3f, num8);
		if (num2 != 0)
		{
			uint num10;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num10), 0.5f, 1f);
		}
	}

	// Token: 0x060028E1 RID: 10465 RVA: 0x000DC634 File Offset: 0x000DA834
	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x679790", Offset = "0x677D90", VA = "0x180679790")]
	public Weapon_laser2()
	{
	}

	// Token: 0x040016D9 RID: 5849
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40016D9")]
	private LineRenderer r;

	// Token: 0x040016DA RID: 5850
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016DA")]
	public int reflectionCount = (int)((ulong)1L);

	// Token: 0x040016DB RID: 5851
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40016DB")]
	private float reflectionMaxY;

	// Token: 0x040016DC RID: 5852
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40016DC")]
	private float reflectionMinY;
}
