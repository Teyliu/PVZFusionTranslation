using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200060B RID: 1547
[Token(Token = "0x200060B")]
public class Tower_electricOnion : TowerPlant
{
	// Token: 0x06001D05 RID: 7429 RVA: 0x0009A48C File Offset: 0x0009868C
	[Token(Token = "0x6001D05")]
	[Address(RVA = "0x561C40", Offset = "0x560240", VA = "0x180561C40", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x0009A4B0 File Offset: 0x000986B0
	[Token(Token = "0x6001D06")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "46")]
	protected override bool Shootable()
	{
		return false;
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x0009A4C0 File Offset: 0x000986C0
	[Token(Token = "0x6001D07")]
	[Address(RVA = "0x5612E0", Offset = "0x55F8E0", VA = "0x1805612E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetSpeed(1f);
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x0009A4EC File Offset: 0x000986EC
	[Token(Token = "0x6001D08")]
	[Address(RVA = "0x5612A0", Offset = "0x55F8A0", VA = "0x1805612A0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.SearchZombieUpdate();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x0009A514 File Offset: 0x00098714
	[Token(Token = "0x6001D09")]
	[Address(RVA = "0x560F40", Offset = "0x55F540", VA = "0x180560F40")]
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

	// Token: 0x06001D0A RID: 7434 RVA: 0x0009A5A0 File Offset: 0x000987A0
	[Token(Token = "0x6001D0A")]
	[Address(RVA = "0x561320", Offset = "0x55F920", VA = "0x180561320")]
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

	// Token: 0x06001D0B RID: 7435 RVA: 0x0009A62C File Offset: 0x0009882C
	[Token(Token = "0x6001D0B")]
	[Address(RVA = "0x560080", Offset = "0x55E680", VA = "0x180560080", Slot = "71")]
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

	// Token: 0x06001D0C RID: 7436 RVA: 0x0009A948 File Offset: 0x00098B48
	[Token(Token = "0x6001D0C")]
	[Address(RVA = "0x5617B0", Offset = "0x55FDB0", VA = "0x1805617B0")]
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

	// Token: 0x06001D0D RID: 7437 RVA: 0x0009AA08 File Offset: 0x00098C08
	[Token(Token = "0x6001D0D")]
	[Address(RVA = "0x561570", Offset = "0x55FB70", VA = "0x180561570")]
	private List<Plant> GetOtherPrismflowers()
	{
		List<Plant> plantHead = this.board.boardEntity.plantHead;
		Func<Plant, bool> func = delegate(Plant n)
		{
			PlantType thePlantType = this.thePlantType;
			return n.thePlantType == thePlantType;
		};
		Plant plant = Enumerable.FirstOrDefault<Plant>(plantHead, func);
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

	// Token: 0x06001D0E RID: 7438 RVA: 0x0009AA84 File Offset: 0x00098C84
	[Token(Token = "0x6001D0E")]
	[Address(RVA = "0x55D890", Offset = "0x55BE90", VA = "0x18055D890")]
	public Tower_electricOnion()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000FCB RID: 4043
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000FCB")]
	public GameObject prism;
}
