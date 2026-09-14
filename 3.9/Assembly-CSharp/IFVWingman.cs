using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002CF RID: 719
[Token(Token = "0x20002CF")]
public class IFVWingman : MonoBehaviour
{
	// Token: 0x06000CCD RID: 3277 RVA: 0x00048C84 File Offset: 0x00046E84
	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x434270", Offset = "0x432870", VA = "0x180434270")]
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

	// Token: 0x06000CCE RID: 3278 RVA: 0x00048D00 File Offset: 0x00046F00
	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x434B50", Offset = "0x433150", VA = "0x180434B50")]
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

	// Token: 0x06000CCF RID: 3279 RVA: 0x00048D54 File Offset: 0x00046F54
	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x434C20", Offset = "0x433220", VA = "0x180434C20")]
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

	// Token: 0x06000CD0 RID: 3280 RVA: 0x00048D90 File Offset: 0x00046F90
	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x4343A0", Offset = "0x4329A0", VA = "0x1804343A0")]
	private void FixedUpdate()
	{
		if (this.nearTarget)
		{
			this.SearchUpdate();
			return;
		}
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00048DB0 File Offset: 0x00046FB0
	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x434850", Offset = "0x432E50", VA = "0x180434850")]
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

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00048E24 File Offset: 0x00047024
	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x434A80", Offset = "0x433080", VA = "0x180434A80")]
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

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00048E68 File Offset: 0x00047068
	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x4343B0", Offset = "0x4329B0", VA = "0x1804343B0")]
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

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00048F20 File Offset: 0x00047120
	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x433E50", Offset = "0x432450", VA = "0x180433E50")]
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
				bullet.velocity = zeroVector;
				bullet.velocity.y = y;
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

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00049018 File Offset: 0x00047218
	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x434D00", Offset = "0x433300", VA = "0x180434D00")]
	public IFVWingman()
	{
		List<Transform> list = new List();
		this.shoots = list;
		this.shootRoad = (ulong)1073741824L;
		this.shootRoad.y = -1f;
		base..ctor();
	}

	// Token: 0x040008DC RID: 2268
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008DC")]
	private Animator anim;

	// Token: 0x040008DD RID: 2269
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008DD")]
	private SortingGroup sortingGroup;

	// Token: 0x040008DE RID: 2270
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008DE")]
	public Plant from;

	// Token: 0x040008DF RID: 2271
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008DF")]
	public Board board;

	// Token: 0x040008E0 RID: 2272
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008E0")]
	public List<Transform> shoots;

	// Token: 0x040008E1 RID: 2273
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008E1")]
	public Transform shadow;

	// Token: 0x040008E2 RID: 2274
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008E2")]
	public PlantType fromType;

	// Token: 0x040008E3 RID: 2275
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40008E3")]
	private Vector2 shootRoad;

	// Token: 0x040008E4 RID: 2276
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40008E4")]
	private LayerMask zombieLayer;

	// Token: 0x040008E5 RID: 2277
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008E5")]
	private Vector2Int targetGrid;

	// Token: 0x040008E6 RID: 2278
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008E6")]
	private bool nearTarget;

	// Token: 0x040008E7 RID: 2279
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40008E7")]
	private bool hasTarget;
}
