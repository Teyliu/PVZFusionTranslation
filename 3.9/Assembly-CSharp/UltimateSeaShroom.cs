using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020004AE RID: 1198
[Token(Token = "0x20004AE")]
public class UltimateSeaShroom : Shooter
{
	// Token: 0x0600165B RID: 5723 RVA: 0x0007B2F4 File Offset: 0x000794F4
	[Token(Token = "0x600165B")]
	[Address(RVA = "0x4EBE40", Offset = "0x4EA440", VA = "0x1804EBE40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
		SortingGroup sortingGroup = this.stem.AddComponent<SortingGroup>();
		this.g = sortingGroup;
		this.g.sortAtRoot = true;
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x0007B338 File Offset: 0x00079538
	[Token(Token = "0x600165C")]
	[Address(RVA = "0x4EBB40", Offset = "0x4EA140", VA = "0x1804EBB40", Slot = "39")]
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

	// Token: 0x0600165D RID: 5725 RVA: 0x0007B3F4 File Offset: 0x000795F4
	[Token(Token = "0x600165D")]
	[Address(RVA = "0x4EB980", Offset = "0x4E9F80", VA = "0x1804EB980")]
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

	// Token: 0x0600165E RID: 5726 RVA: 0x0007B444 File Offset: 0x00079644
	[Token(Token = "0x600165E")]
	[Address(RVA = "0x4EC890", Offset = "0x4EAE90", VA = "0x1804EC890", Slot = "68")]
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

	// Token: 0x0600165F RID: 5727 RVA: 0x0007B4F0 File Offset: 0x000796F0
	[Token(Token = "0x600165F")]
	[Address(RVA = "0x4EC360", Offset = "0x4EA960", VA = "0x1804EC360")]
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

	// Token: 0x06001660 RID: 5728 RVA: 0x0007B544 File Offset: 0x00079744
	[Token(Token = "0x6001660")]
	[Address(RVA = "0x4EC5C0", Offset = "0x4EABC0", VA = "0x1804EC5C0", Slot = "32")]
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

	// Token: 0x06001661 RID: 5729 RVA: 0x0007B5A4 File Offset: 0x000797A4
	[Token(Token = "0x6001661")]
	[Address(RVA = "0x4EC520", Offset = "0x4EAB20", VA = "0x1804EC520", Slot = "31")]
	protected override int GetDamage(int damage)
	{
		if (this.status != UltimateSeaShroom.Status.Ice)
		{
		}
		int num;
		return num;
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x0007B5C0 File Offset: 0x000797C0
	[Token(Token = "0x6001662")]
	[Address(RVA = "0x4EBED0", Offset = "0x4EA4D0", VA = "0x1804EBED0")]
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

	// Token: 0x06001663 RID: 5731 RVA: 0x0007B65C File Offset: 0x0007985C
	[Token(Token = "0x6001663")]
	[Address(RVA = "0x4ECAF0", Offset = "0x4EB0F0", VA = "0x1804ECAF0", Slot = "69")]
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

	// Token: 0x06001664 RID: 5732 RVA: 0x0007B748 File Offset: 0x00079948
	[Token(Token = "0x6001664")]
	[Address(RVA = "0x4EC7C0", Offset = "0x4EADC0", VA = "0x1804EC7C0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x0007B768 File Offset: 0x00079968
	[Token(Token = "0x6001665")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateSeaShroom()
	{
	}

	// Token: 0x04000DE5 RID: 3557
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DE5")]
	public List<GameObject> heads;

	// Token: 0x04000DE6 RID: 3558
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DE6")]
	public List<GameObject> tentacles;

	// Token: 0x04000DE7 RID: 3559
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000DE7")]
	public List<GameObject> iceTentacles;

	// Token: 0x04000DE8 RID: 3560
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000DE8")]
	public UltimateSeaShroom.Status status;

	// Token: 0x04000DE9 RID: 3561
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000DE9")]
	public Transform stem;

	// Token: 0x04000DEA RID: 3562
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000DEA")]
	public SortingGroup g;

	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	public enum Status
	{
		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000DEC")]
		Default,
		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000DED")]
		Ice,
		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000DEE")]
		Hypno,
		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		Doom
	}
}
