using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000409 RID: 1033
[Token(Token = "0x2000409")]
public class Prismflower : Attacker
{
	// Token: 0x06001312 RID: 4882 RVA: 0x0006B6B0 File Offset: 0x000698B0
	[Token(Token = "0x6001312")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x0006B6D0 File Offset: 0x000698D0
	[Token(Token = "0x6001313")]
	[Address(RVA = "0x461400", Offset = "0x45FA00", VA = "0x180461400", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.SearchZombieUpdate();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x0006B6F8 File Offset: 0x000698F8
	[Token(Token = "0x6001314")]
	[Address(RVA = "0x461080", Offset = "0x45F680", VA = "0x180461080", Slot = "69")]
	protected virtual void AttackOtherZombie(Zombie basicZombie, Vector2 center, int damage)
	{
		LayerMask zombieLayer = this.zombieLayer;
		int num = 0;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && num != basicZombie && base.SearchUniqueZombie(num))
			{
				int num3 = 0;
				GameObject gameObject = this.CreateLine(num, num3, (float)num2, num);
				SortingGroup sortingGroup = gameObject.AddComponent<SortingGroup>();
				int theZombieRow = basicZombie.theZombieRow;
				string text = string.Format("particle{0}", sortingGroup);
				sortingGroup.sortingLayerName = text;
				PlantType thePlantType = this.thePlantType;
				global::UnityEngine.Object.Destroy(gameObject, 0.5f);
				num++;
				if (num >= 3)
				{
					return;
				}
			}
			num++;
		}
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x0006B798 File Offset: 0x00069998
	[Token(Token = "0x6001315")]
	[Address(RVA = "0x461450", Offset = "0x45FA50", VA = "0x180461450")]
	protected GameObject CreateLine(Vector2 startPosition, Vector2 endPosition, float width = 0f, int row = 11)
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
		return gameObject2;
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x0006B81C File Offset: 0x00069A1C
	[Token(Token = "0x6001316")]
	[Address(RVA = "0x4601D0", Offset = "0x45E7D0", VA = "0x1804601D0")]
	private void AnimShoot()
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
					goto IL_0313;
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
					goto IL_0313;
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
		int theZombieRow = this.targetZombie.theZombieRow;
		GameObject gameObject5;
		SortingGroup sortingGroup3 = gameObject5.AddComponent<SortingGroup>();
		int thePlantRow4 = this.thePlantRow;
		int theZombieRow2 = this.targetZombie.theZombieRow;
		if (thePlantRow4 <= theZombieRow2)
		{
		}
		string text3 = string.Format("particle{0}", sortingGroup3);
		sortingGroup3.sortingLayerName = text3;
		uint num10;
		GameAPP.PlaySound((int)num10, 0.3f, 1f);
		global::UnityEngine.Object.Destroy(gameObject5, 0.5f);
		bool flag2;
		if (flag2)
		{
		}
		Zombie targetZombie2 = this.targetZombie;
		PlantType thePlantType = this.thePlantType;
		gameObject5 -= gameObject5;
		IL_0313:
		this.targetZombie = num;
		this.targetPlant = num;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x0006BB54 File Offset: 0x00069D54
	[Token(Token = "0x6001317")]
	[Address(RVA = "0x4618C0", Offset = "0x45FEC0", VA = "0x1804618C0", Slot = "70")]
	protected virtual void SearchZombieUpdate()
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

	// Token: 0x06001318 RID: 4888 RVA: 0x0006BC14 File Offset: 0x00069E14
	[Token(Token = "0x6001318")]
	[Address(RVA = "0x461680", Offset = "0x45FC80", VA = "0x180461680")]
	protected List<Plant> GetOtherPrismflowers()
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

	// Token: 0x06001319 RID: 4889 RVA: 0x0006BC80 File Offset: 0x00069E80
	[Token(Token = "0x6001319")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public Prismflower()
	{
	}

	// Token: 0x04000C4A RID: 3146
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C4A")]
	public GameObject prism;
}
