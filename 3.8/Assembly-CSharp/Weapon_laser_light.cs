using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020007A1 RID: 1953
[Token(Token = "0x20007A1")]
public class Weapon_laser_light : MonoBehaviour
{
	// Token: 0x060027B3 RID: 10163 RVA: 0x000D7694 File Offset: 0x000D5894
	[Token(Token = "0x60027B3")]
	[Address(RVA = "0x6172B0", Offset = "0x6158B0", VA = "0x1806172B0")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.lineRenderer = component;
		SortingGroup sortingGroup = this.AddComponent<SortingGroup>();
		this.sortingGroup = sortingGroup;
		this.sortingGroup.sortingLayerName = "fog";
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x000D76D4 File Offset: 0x000D58D4
	[Token(Token = "0x60027B4")]
	[Address(RVA = "0x617350", Offset = "0x615950", VA = "0x180617350")]
	public void OnUpdate()
	{
		Transform transform = this.weapon_Laser.transform;
		Zombie zombie = this.zombie;
		int num = 0;
		if (zombie != num)
		{
			Collider2D col = this.zombie.col;
			int num2 = 0;
			if (col != num2)
			{
				Zombie zombie2 = this.zombie;
				if (!zombie2.isMindControlled && !zombie2.beforeDying && zombie2.theStatus != ZombieStatus.Dying)
				{
					base.gameObject.SetActive(true);
					LineRenderer lineRenderer = this.lineRenderer;
					Collider2D col2 = this.zombie.col;
					int num3 = 0;
					float deltaTime = Time.deltaTime;
					int num4 = 0;
					float num5 = deltaTime * 10f;
					if (num4 > (int)num5 || num5 > 1f)
					{
					}
					LineRenderer lineRenderer2 = this.lineRenderer;
					int num6 = 0;
					lineRenderer2.SetPosition(num6, num3);
					this.lineRenderer.SetPosition(1, num3);
					Transform transform2 = base.transform;
					int num7 = 0;
					transform2.GetChild(num7).position = num7;
					return;
				}
			}
		}
		this.zombie = (ulong)0L;
		GameObject gameObject = base.gameObject;
		int num8 = 0;
		int num9 = 0;
		gameObject.SetActive(num9 != 0);
		LineRenderer lineRenderer3 = this.lineRenderer;
		int num10 = 0;
		lineRenderer3.SetPosition(num10, num8);
		this.lineRenderer.SetPosition(1, num8);
		Transform transform3 = base.transform;
		int num11 = 0;
		Transform child = transform3.GetChild(num11);
		throw new NullReferenceException();
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x000D783C File Offset: 0x000D5A3C
	[Token(Token = "0x60027B5")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Weapon_laser_light()
	{
	}

	// Token: 0x04001601 RID: 5633
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001601")]
	public Weapon_laser weapon_Laser;

	// Token: 0x04001602 RID: 5634
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001602")]
	public Zombie zombie;

	// Token: 0x04001603 RID: 5635
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001603")]
	private LineRenderer lineRenderer;

	// Token: 0x04001604 RID: 5636
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001604")]
	private SortingGroup sortingGroup;
}
