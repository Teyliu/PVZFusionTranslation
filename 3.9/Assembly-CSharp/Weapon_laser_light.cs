using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020007DA RID: 2010
[Token(Token = "0x20007DA")]
public class Weapon_laser_light : MonoBehaviour
{
	// Token: 0x060028E2 RID: 10466 RVA: 0x000DC650 File Offset: 0x000DA850
	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x67AB40", Offset = "0x679140", VA = "0x18067AB40")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.lineRenderer = component;
		SortingGroup sortingGroup = this.AddComponent<SortingGroup>();
		this.sortingGroup = sortingGroup;
		this.sortingGroup.sortingLayerName = "fog";
	}

	// Token: 0x060028E3 RID: 10467 RVA: 0x000DC690 File Offset: 0x000DA890
	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x67ABE0", Offset = "0x6791E0", VA = "0x18067ABE0")]
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

	// Token: 0x060028E4 RID: 10468 RVA: 0x000DC7F8 File Offset: 0x000DA9F8
	[Token(Token = "0x60028E4")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Weapon_laser_light()
	{
	}

	// Token: 0x040016DD RID: 5853
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016DD")]
	public Weapon_laser weapon_Laser;

	// Token: 0x040016DE RID: 5854
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016DE")]
	public Zombie zombie;

	// Token: 0x040016DF RID: 5855
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40016DF")]
	private LineRenderer lineRenderer;

	// Token: 0x040016E0 RID: 5856
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40016E0")]
	private SortingGroup sortingGroup;
}
