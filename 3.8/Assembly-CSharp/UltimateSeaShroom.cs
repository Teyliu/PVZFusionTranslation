using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200048C RID: 1164
[Token(Token = "0x200048C")]
public class UltimateSeaShroom : Shooter
{
	// Token: 0x060015BB RID: 5563 RVA: 0x00078970 File Offset: 0x00076B70
	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x492990", Offset = "0x490F90", VA = "0x180492990", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
		SortingGroup sortingGroup = this.stem.AddComponent<SortingGroup>();
		this.g = sortingGroup;
		this.g.sortAtRoot = true;
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x000789B4 File Offset: 0x00076BB4
	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x492690", Offset = "0x490C90", VA = "0x180492690", Slot = "40")]
	protected override void AttributeEvent()
	{
		Animator anim = this.anim;
		int num = 0;
		anim.SetTrigger("shoot2");
		if (this.status != UltimateSeaShroom.Status.Hypno)
		{
		}
		base.AttributeCountdown = 25f;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					goto IL_0068;
				}
			}
			num++;
			IL_0068:
			Transform transform = this.stem;
			Vector3 vector2;
			float z2 = vector2.z;
			this.anim.SetTrigger("knockback");
			SortingGroup sortingGroup = this.g;
			int num3;
			string text = string.Format("bullet{0}", num3);
			sortingGroup.sortingLayerName = text;
		}
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x00078A70 File Offset: 0x00076C70
	[Token(Token = "0x60015BD")]
	[Address(RVA = "0x4924D0", Offset = "0x490AD0", VA = "0x1804924D0")]
	private void AnimKnockBack()
	{
		Transform transform = this.stem;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
				}
			}
			num++;
		}
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x00078AC0 File Offset: 0x00076CC0
	[Token(Token = "0x60015BE")]
	[Address(RVA = "0x4933E0", Offset = "0x4919E0", VA = "0x1804933E0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.from = this;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound(57, 0.5f, 1f);
		if (Lawnf.TravelUltimate((UltiBuff)((uint)45)))
		{
			CreateBullet instance2 = CreateBullet.Instance;
			Bullet bullet2;
			bullet2.from = this;
			int attackDamage2 = this.attackDamage;
			bullet2.Damage = attackDamage2;
			CreateBullet instance3 = CreateBullet.Instance;
			Bullet bullet3;
			bullet3.from = this;
			int attackDamage3 = this.attackDamage;
			bullet3.Damage = attackDamage3;
		}
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x00078B6C File Offset: 0x00076D6C
	[Token(Token = "0x60015BF")]
	[Address(RVA = "0x492EB0", Offset = "0x4914B0", VA = "0x180492EB0")]
	public void EatSeaShroom(int count)
	{
		int num;
		bool flag;
		ulong num2;
		do
		{
			num = 0;
			base.UpdateText();
			if (this.status != UltimateSeaShroom.Status.Ice)
			{
				break;
			}
			int thePlantRow = this.thePlantRow;
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(this.board, thePlantRow);
		}
		while ((flag && !(num != this)) || num2 != (ulong)0L);
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x00078BC0 File Offset: 0x00076DC0
	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x493110", Offset = "0x491710", VA = "0x180493110", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		ulong num3;
		do
		{
			int num = 0;
			if (this.status != UltimateSeaShroom.Status.Hypno)
			{
				break;
			}
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				PlantType thePlantType = this.thePlantType;
			}
		}
		while (num3 != (ulong)0L);
		return base.Instead(theDamage);
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x00078C20 File Offset: 0x00076E20
	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x493070", Offset = "0x491670", VA = "0x180493070", Slot = "32")]
	protected override int GetDamage(int damage)
	{
		if (this.status != UltimateSeaShroom.Status.Ice)
		{
		}
		int num;
		return num;
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x00078C3C File Offset: 0x00076E3C
	[Token(Token = "0x60015C2")]
	[Address(RVA = "0x492A20", Offset = "0x491020", VA = "0x180492A20")]
	public void ChangeStatus(PlantType thePlantType, bool eat = true)
	{
		for (;;)
		{
			List<GameObject> list = this.iceTentacles;
			bool flag;
			if (flag)
			{
			}
			ulong num;
			if (num == (ulong)0L)
			{
				if (num != (ulong)0L)
				{
					if (num != (ulong)0L)
					{
						if (num == (ulong)0L || num != (ulong)1L)
						{
							bool flag2;
							if (flag2)
							{
							}
							ulong num2;
							if (num2 != (ulong)0L)
							{
								goto IL_0087;
							}
						}
					}
				}
				IL_004B:
				bool flag3;
				if (flag3)
				{
				}
				ulong num3;
				if (num3 == (ulong)0L)
				{
					break;
				}
				continue;
				goto IL_004B;
			}
			goto IL_0081;
		}
		GameObject gameObject;
		ulong num4;
		gameObject.SetActive(num4 != 0UL);
		uint num5;
		GameAPP.PlaySound((int)num5, 0.5f, 1f);
		return;
		IL_0081:
		throw new NullReferenceException();
		IL_0087:
		throw new NullReferenceException();
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00078CD8 File Offset: 0x00076ED8
	[Token(Token = "0x60015C3")]
	[Address(RVA = "0x493640", Offset = "0x491C40", VA = "0x180493640", Slot = "70")]
	protected override Bullet Shoot2()
	{
		List<GameObject> list = this.tentacles;
		Transform shoot = this.shoot2;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject;
		Tentacle component = gameObject.GetComponent<Tentacle>();
		Transform axis = this.axis;
		Vector3 vector2;
		float z2 = vector2.z;
		component.waterPosition.z = z2;
		UltimateSeaShroom.Status status = this.status;
		component.status = status;
		int thePlantRow = this.thePlantRow;
		component.waterRow = thePlantRow;
		Board board = this.board;
		component.board = board;
		component.AddComponent<SortingGroup>().sortingLayerName = "particle11";
		int attackDamage = this.attackDamage;
		component.damage = attackDamage;
		component.plant = this;
		base.UpdateText();
		UltimateSeaShroom.Status status2 = this.status;
		if (status2 != UltimateSeaShroom.Status.Ice && status2 == UltimateSeaShroom.Status.Doom)
		{
			int num = 0;
			this.ChangeStatus((PlantType)((uint)19), num != 0);
		}
		throw new NullReferenceException();
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x00078DC4 File Offset: 0x00076FC4
	[Token(Token = "0x60015C4")]
	[Address(RVA = "0x493310", Offset = "0x491910", VA = "0x180493310", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00078DE4 File Offset: 0x00076FE4
	[Token(Token = "0x60015C5")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateSeaShroom()
	{
	}

	// Token: 0x04000D4C RID: 3404
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D4C")]
	public List<GameObject> heads;

	// Token: 0x04000D4D RID: 3405
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D4D")]
	public List<GameObject> tentacles;

	// Token: 0x04000D4E RID: 3406
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000D4E")]
	public List<GameObject> iceTentacles;

	// Token: 0x04000D4F RID: 3407
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000D4F")]
	public UltimateSeaShroom.Status status;

	// Token: 0x04000D50 RID: 3408
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000D50")]
	public Transform stem;

	// Token: 0x04000D51 RID: 3409
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000D51")]
	public SortingGroup g;

	// Token: 0x0200048D RID: 1165
	[Token(Token = "0x200048D")]
	public enum Status
	{
		// Token: 0x04000D53 RID: 3411
		[Token(Token = "0x4000D53")]
		Default,
		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		Ice,
		// Token: 0x04000D55 RID: 3413
		[Token(Token = "0x4000D55")]
		Hypno,
		// Token: 0x04000D56 RID: 3414
		[Token(Token = "0x4000D56")]
		Doom
	}
}
