using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000424 RID: 1060
[Token(Token = "0x2000424")]
public class Prismflower : Attacker
{
	// Token: 0x06001388 RID: 5000 RVA: 0x0006D534 File Offset: 0x0006B734
	[Token(Token = "0x6001388")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x0006D554 File Offset: 0x0006B754
	[Token(Token = "0x6001389")]
	[Address(RVA = "0x4B7AB0", Offset = "0x4B60B0", VA = "0x1804B7AB0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.SearchZombieUpdate();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x0006D57C File Offset: 0x0006B77C
	[Token(Token = "0x600138A")]
	[Address(RVA = "0x4B7730", Offset = "0x4B5D30", VA = "0x1804B7730", Slot = "68")]
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

	// Token: 0x0600138B RID: 5003 RVA: 0x0006D61C File Offset: 0x0006B81C
	[Token(Token = "0x600138B")]
	[Address(RVA = "0x4B7B00", Offset = "0x4B6100", VA = "0x1804B7B00")]
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

	// Token: 0x0600138C RID: 5004 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
	[Token(Token = "0x600138C")]
	[Address(RVA = "0x4B6880", Offset = "0x4B4E80", VA = "0x1804B6880")]
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

	// Token: 0x0600138D RID: 5005 RVA: 0x0006D9D8 File Offset: 0x0006BBD8
	[Token(Token = "0x600138D")]
	[Address(RVA = "0x4B7F70", Offset = "0x4B6570", VA = "0x1804B7F70", Slot = "69")]
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

	// Token: 0x0600138E RID: 5006 RVA: 0x0006DA98 File Offset: 0x0006BC98
	[Token(Token = "0x600138E")]
	[Address(RVA = "0x4B7D30", Offset = "0x4B6330", VA = "0x1804B7D30")]
	protected List<Plant> GetOtherPrismflowers()
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

	// Token: 0x0600138F RID: 5007 RVA: 0x0006DB14 File Offset: 0x0006BD14
	[Token(Token = "0x600138F")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public Prismflower()
	{
	}

	// Token: 0x04000CC5 RID: 3269
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CC5")]
	public GameObject prism;
}
