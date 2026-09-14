using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005D6 RID: 1494
[Token(Token = "0x20005D6")]
public class Tower_electricOnion : TowerPlant
{
	// Token: 0x06001C06 RID: 7174 RVA: 0x00095874 File Offset: 0x00093A74
	[Token(Token = "0x6001C06")]
	[Address(RVA = "0x5109F0", Offset = "0x50EFF0", VA = "0x1805109F0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x00095898 File Offset: 0x00093A98
	[Token(Token = "0x6001C07")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "47")]
	protected override bool Shootable()
	{
		return false;
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x000958A8 File Offset: 0x00093AA8
	[Token(Token = "0x6001C08")]
	[Address(RVA = "0x510090", Offset = "0x50E690", VA = "0x180510090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetSpeed(1f);
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x000958D4 File Offset: 0x00093AD4
	[Token(Token = "0x6001C09")]
	[Address(RVA = "0x510050", Offset = "0x50E650", VA = "0x180510050", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.SearchZombieUpdate();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x000958FC File Offset: 0x00093AFC
	[Token(Token = "0x6001C0A")]
	[Address(RVA = "0x50FCF0", Offset = "0x50E2F0", VA = "0x18050FCF0")]
	private void AttackOtherZombie(Zombie basicZombie, Vector2 center, int damage)
	{
		LayerMask zombieLayer = this.zombieLayer;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			bool flag2;
			bool flag3;
			if (flag && flag2 && flag3)
			{
				GameObject gameObject;
				SortingGroup sortingGroup = gameObject.AddComponent<SortingGroup>();
				int theZombieRow = basicZombie.theZombieRow;
				string text = string.Format("particle{0}", sortingGroup);
				sortingGroup.sortingLayerName = text;
				PlantType thePlantType = this.thePlantType;
				global::UnityEngine.Object.Destroy(gameObject, 0.5f);
				num++;
				if (num >= 5)
				{
					return;
				}
			}
			num3++;
		}
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x00095988 File Offset: 0x00093B88
	[Token(Token = "0x6001C0B")]
	[Address(RVA = "0x5100D0", Offset = "0x50E6D0", VA = "0x1805100D0")]
	private GameObject CreateLine(Vector2 startPosition, Vector2 endPosition, float width = 0f)
	{
		Board board = this.board;
		GameObject gameObject = this.prism;
		Transform transform = board.transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
		Transform transform2 = gameObject2.transform;
		int num = 0;
		LineRenderer component = transform2.GetChild(num).GetComponent<LineRenderer>();
		PrismLight prismLight = component.gameObject.AddComponent<PrismLight>();
		float num2 = component.startWidth;
		component.startWidth = num2;
		num2 = component.endWidth;
		component.endWidth = num2;
		Zombie targetZombie = this.targetZombie;
		return gameObject2;
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x00095A14 File Offset: 0x00093C14
	[Token(Token = "0x6001C0C")]
	[Address(RVA = "0x50EE30", Offset = "0x50D430", VA = "0x18050EE30", Slot = "72")]
	public override void AnimShoot()
	{
		int num;
		GameObject gameObject4;
		do
		{
			num = 0;
			Zombie targetZombie = this.targetZombie;
			int num2 = 0;
			if (targetZombie != num2)
			{
				goto IL_026A;
			}
			Plant targetPlant = this.targetPlant;
			int num3 = 0;
			if (!(targetPlant != num3))
			{
				Plant targetPlant2 = this.targetPlant;
				int num4 = 0;
				if (!(targetPlant2 == num4))
				{
					goto IL_02FA;
				}
				Transform shoot = this.shoot;
				Vector3 vector;
				float z = vector.z;
				int num5 = this.zombieLayer;
				Collider2D[] array;
				if (num < array.Length)
				{
					bool flag;
					if (flag && base.SearchUniqueZombie(num))
					{
						Vector3 vector2;
						float z2 = vector2.z;
						Transform shoot2 = this.shoot;
						Vector3 vector3;
						float z3 = vector3.z;
					}
					num++;
				}
				int num6 = 0;
				if (!(num != num6))
				{
					goto IL_02FA;
				}
				GameObject gameObject = this.prism;
				Transform transform = this.board.transform;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
				SortingGroup sortingGroup = gameObject2.AddComponent<SortingGroup>();
				int thePlantRow = this.thePlantRow;
				string text = string.Format("particle{0}", sortingGroup);
				sortingGroup.sortingLayerName = text;
				float num7;
				if (num7 < 0.25f)
				{
				}
				Vector3 vector5;
				if (gameObject2.transform.GetEnumerator() != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						num++;
					}
					LineRenderer lineRenderer;
					PrismLight prismLight = lineRenderer.gameObject.AddComponent<PrismLight>();
					Transform shoot3 = this.shoot;
					Vector3 vector4;
					float z4 = vector4.z;
					float num8 = vector5.z;
					num8 = lineRenderer.startWidth;
					lineRenderer.startWidth = num8;
					num8 = lineRenderer.endWidth;
					lineRenderer.endWidth = num8;
					lineRenderer += lineRenderer;
				}
				if (vector5 != 0)
				{
				}
				if (num != 0)
				{
					continue;
				}
				uint num9;
				GameAPP.PlaySound((int)num9, 0.2f, 1f);
			}
			GameObject gameObject3 = this.prism;
			Transform transform2 = this.board.transform;
			gameObject4 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject3, transform2);
			SortingGroup sortingGroup2 = gameObject4.AddComponent<SortingGroup>();
			int thePlantRow2 = this.thePlantRow;
			int thePlantRow3 = this.targetPlant.thePlantRow;
			if (thePlantRow2 <= thePlantRow3)
			{
			}
			string text2 = string.Format("particle{0}", sortingGroup2);
			sortingGroup2.sortingLayerName = text2;
			IEnumerator enumerator = gameObject4.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				LineRenderer lineRenderer2;
				PrismLight prismLight2 = lineRenderer2.gameObject.AddComponent<PrismLight>();
				Transform shoot4 = this.shoot;
				Vector3 vector6;
				float z5 = vector6.z;
				Transform shoot5 = this.targetPlant.shoot;
				Vector3 vector7;
				float z6 = vector7.z;
				lineRenderer2 += lineRenderer2;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		global::UnityEngine.Object.Destroy(gameObject4, 0.5f);
		IL_026A:
		Transform axis = this.targetZombie.axis;
		if (0 * (int)0.05f < (int)0.25f)
		{
		}
		Transform shoot6 = this.shoot;
		GameObject gameObject5;
		SortingGroup sortingGroup3 = gameObject5.AddComponent<SortingGroup>();
		int thePlantRow4 = this.thePlantRow;
		int theZombieRow = this.targetZombie.theZombieRow;
		if (thePlantRow4 <= theZombieRow)
		{
		}
		string text3 = string.Format("particle{0}", sortingGroup3);
		sortingGroup3.sortingLayerName = text3;
		uint num10;
		GameAPP.PlaySound((int)num10, 0.3f, 1f);
		global::UnityEngine.Object.Destroy(gameObject5, 0.5f);
		Zombie targetZombie2 = this.targetZombie;
		PlantType thePlantType = this.thePlantType;
		IL_02FA:
		this.targetZombie = num;
		this.targetPlant = num;
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x00095D30 File Offset: 0x00093F30
	[Token(Token = "0x6001C0D")]
	[Address(RVA = "0x510560", Offset = "0x50EB60", VA = "0x180510560")]
	private void SearchZombieUpdate()
	{
		ulong num6;
		do
		{
			Transform shoot = this.shoot;
			int num = this.zombieLayer;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Collider2D[] array;
			if (num4 < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && flag2)
				{
					Transform shoot2 = this.shoot;
				}
				num3++;
			}
			int num5 = 0;
			if (!(num2 != num5))
			{
				return;
			}
			this.targetZombie = num2;
			this.thePlantStage = (int)((ulong)0L);
			this.anim.SetTrigger("shoot");
			this.theStatus = (PlantStatus)((ulong)11L);
			List<Plant> otherPrismflowers = this.GetOtherPrismflowers();
			bool flag3;
			if (flag3)
			{
			}
		}
		while (num6 != (ulong)0L);
		uint num7;
		GameAPP.PlaySound((int)num7, 0.4f, 1f);
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x00095DF0 File Offset: 0x00093FF0
	[Token(Token = "0x6001C0E")]
	[Address(RVA = "0x510320", Offset = "0x50E920", VA = "0x180510320")]
	private List<Plant> GetOtherPrismflowers()
	{
		Func<Plant, bool> func;
		Plant plant = Enumerable.FirstOrDefault<Plant>(this.board.boardEntity.plantHead, func);
		List<Plant> list = new List();
		int num = 0;
		if (plant != num)
		{
			int thePlantColumn = plant.thePlantColumn;
			int thePlantRow = plant.thePlantRow;
			if (!(plant != this) || plant.theStatus == PlantStatus.Default)
			{
			}
		}
		return list;
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x00095E5C File Offset: 0x0009405C
	[Token(Token = "0x6001C0F")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_electricOnion()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000F03 RID: 3843
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F03")]
	public GameObject prism;
}
