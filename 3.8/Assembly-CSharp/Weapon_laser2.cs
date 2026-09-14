using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A0 RID: 1952
[Token(Token = "0x20007A0")]
public class Weapon_laser2 : PlayerWeapon
{
	// Token: 0x060027AE RID: 10158 RVA: 0x000D73BC File Offset: 0x000D55BC
	[Token(Token = "0x60027AE")]
	[Address(RVA = "0x6150C0", Offset = "0x6136C0", VA = "0x1806150C0", Slot = "7")]
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

	// Token: 0x060027AF RID: 10159 RVA: 0x000D7458 File Offset: 0x000D5658
	[Token(Token = "0x60027AF")]
	[Address(RVA = "0x615250", Offset = "0x613850", VA = "0x180615250", Slot = "9")]
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

	// Token: 0x060027B0 RID: 10160 RVA: 0x000D74C8 File Offset: 0x000D56C8
	[Token(Token = "0x60027B0")]
	[Address(RVA = "0x615B50", Offset = "0x614150", VA = "0x180615B50")]
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

	// Token: 0x060027B1 RID: 10161 RVA: 0x000D7550 File Offset: 0x000D5750
	[Token(Token = "0x60027B1")]
	[Address(RVA = "0x615510", Offset = "0x613B10", VA = "0x180615510", Slot = "10")]
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

	// Token: 0x060027B2 RID: 10162 RVA: 0x000D7678 File Offset: 0x000D5878
	[Token(Token = "0x60027B2")]
	[Address(RVA = "0x615F00", Offset = "0x614500", VA = "0x180615F00")]
	public Weapon_laser2()
	{
	}

	// Token: 0x040015FD RID: 5629
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40015FD")]
	private LineRenderer r;

	// Token: 0x040015FE RID: 5630
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40015FE")]
	public int reflectionCount = (int)((ulong)1L);

	// Token: 0x040015FF RID: 5631
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40015FF")]
	private float reflectionMaxY;

	// Token: 0x04001600 RID: 5632
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001600")]
	private float reflectionMinY;
}
