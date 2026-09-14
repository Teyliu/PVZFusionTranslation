using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002C1 RID: 705
[Token(Token = "0x20002C1")]
public class IFVWingman : MonoBehaviour
{
	// Token: 0x06000C8A RID: 3210 RVA: 0x000480B8 File Offset: 0x000462B8
	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x3E35D0", Offset = "0x3E1BD0", VA = "0x1803E35D0")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		SortingGroup component2 = base.GetComponent<SortingGroup>();
		this.sortingGroup = component2;
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
		Animator animator = this.anim;
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		animator.SetFloat("Speed", num);
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x00048134 File Offset: 0x00046334
	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x3E3EB0", Offset = "0x3E24B0", VA = "0x1803E3EB0")]
	private void Start()
	{
		Plant plant = this.from;
		int num = 0;
		if (plant != num)
		{
			Plant plant2 = this.from;
			SortingGroup sortingGroup = this.sortingGroup;
			int thePlantRow = plant2.thePlantRow;
			string text = string.Format("fly{0}", thePlantRow);
			sortingGroup.sortingLayerName = text;
		}
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x00048188 File Offset: 0x00046388
	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x3E3F80", Offset = "0x3E2580", VA = "0x1803E3F80")]
	private void Update()
	{
		if (this.hasTarget)
		{
			this.PositionUpdate();
		}
		Plant plant = this.from;
		int num = 0;
		if (plant == num)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x000481C4 File Offset: 0x000463C4
	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x3E3700", Offset = "0x3E1D00", VA = "0x1803E3700")]
	private void FixedUpdate()
	{
		if (this.nearTarget)
		{
			this.SearchUpdate();
			return;
		}
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x000481E4 File Offset: 0x000463E4
	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x3E3BB0", Offset = "0x3E21B0", VA = "0x1803E3BB0")]
	private void SearchUpdate()
	{
		int num = 0;
		Transform transform = base.transform;
		int num2 = this.zombieLayer;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			Collider2D collider2D;
			if (collider2D.TryGetComponent<Zombie>(num))
			{
				int y = this.targetGrid.m_Y;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					goto IL_004C;
				}
			}
			num++;
		}
		IL_004C:
		ulong num3;
		this.anim.SetBool("shooting", num3 != 0UL);
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00048258 File Offset: 0x00046458
	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x3E3DE0", Offset = "0x3E23E0", VA = "0x1803E3DE0")]
	[ProButton]
	public void SetTarget(Vector2Int target)
	{
		string text;
		this.sortingGroup.sortingLayerName = text;
		Animator animator = this.anim;
		this.targetGrid = target;
		this.hasTarget = true;
		int num = 0;
		animator.SetBool("shooting", num != 0);
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0004829C File Offset: 0x0004649C
	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x3E3710", Offset = "0x3E1D10", VA = "0x1803E3710")]
	private void PositionUpdate()
	{
		Mouse instance = Mouse.Instance;
		Mouse instance2 = Mouse.Instance;
		int y = this.targetGrid.m_Y;
		float num;
		float landY = instance2.GetLandY(num, y);
		Transform transform = base.transform;
		num = landY;
		Transform transform2 = base.transform;
		if (landY <= 0.1f)
		{
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			float deltaTime = Time.deltaTime;
		}
		Transform transform5 = base.transform;
		Transform transform6 = base.transform;
		float deltaTime2 = Time.deltaTime;
		Transform transform7 = base.transform;
		num = Time.deltaTime;
		int num2 = 0;
		this.nearTarget = num2 != 0;
		Transform transform8 = this.shadow.transform;
		Transform transform9 = base.transform;
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x00048354 File Offset: 0x00046554
	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x3E31B0", Offset = "0x3E17B0", VA = "0x1803E31B0")]
	private void AnimShoot()
	{
		int num2;
		do
		{
			Plant plant = this.from;
			int num = 0;
			if (!(plant != num))
			{
				break;
			}
			List<Transform> list = this.shoots;
			num2 = 0;
			bool flag;
			if (flag)
			{
				CreateBullet instance = CreateBullet.Instance;
				int attackDamage = this.from.attackDamage;
				Bullet bullet;
				bullet.Damage = attackDamage;
				Transform transform = bullet.transform;
				PlantType plantType = this.fromType;
				bullet.fromType = plantType;
				float y = this.shootRoad.y;
				Vector2 zeroVector = Vector2.zeroVector;
				bullet.Vx = zeroVector;
				bullet.Vy = y;
				int num3 = 0;
				if (Lawnf.TravelAdvanced((AdvBuff)((uint)25)))
				{
					bullet.Damage = num3;
				}
				int num4 = 0;
				if (!Lawnf.TravelAdvanced((AdvBuff)((uint)24)))
				{
					continue;
				}
				bullet.Damage = num4;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x00048448 File Offset: 0x00046648
	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x3E4060", Offset = "0x3E2660", VA = "0x1803E4060")]
	public IFVWingman()
	{
		List<Transform> list = new List();
		this.shoots = list;
		this.shootRoad = (ulong)1073741824L;
		this.shootRoad.y = -1f;
		base..ctor();
	}

	// Token: 0x0400089F RID: 2207
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400089F")]
	private Animator anim;

	// Token: 0x040008A0 RID: 2208
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008A0")]
	private SortingGroup sortingGroup;

	// Token: 0x040008A1 RID: 2209
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008A1")]
	public Plant from;

	// Token: 0x040008A2 RID: 2210
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008A2")]
	public Board board;

	// Token: 0x040008A3 RID: 2211
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008A3")]
	public List<Transform> shoots;

	// Token: 0x040008A4 RID: 2212
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008A4")]
	public Transform shadow;

	// Token: 0x040008A5 RID: 2213
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008A5")]
	public PlantType fromType;

	// Token: 0x040008A6 RID: 2214
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40008A6")]
	private Vector2 shootRoad;

	// Token: 0x040008A7 RID: 2215
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40008A7")]
	private LayerMask zombieLayer;

	// Token: 0x040008A8 RID: 2216
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008A8")]
	private Vector2Int targetGrid;

	// Token: 0x040008A9 RID: 2217
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008A9")]
	private bool nearTarget;

	// Token: 0x040008AA RID: 2218
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40008AA")]
	private bool hasTarget;
}
