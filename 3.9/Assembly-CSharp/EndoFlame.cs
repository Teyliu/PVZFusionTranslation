using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000396 RID: 918
[Token(Token = "0x2000396")]
public class EndoFlame : Plant
{
	// Token: 0x17000123 RID: 291
	// (get) Token: 0x060010D8 RID: 4312 RVA: 0x0005FDD4 File Offset: 0x0005DFD4
	// (set) Token: 0x060010D9 RID: 4313 RVA: 0x0005FDE8 File Offset: 0x0005DFE8
	[Token(Token = "0x17000123")]
	public ZombieType ZombieType
	{
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x4887C0", Offset = "0x486DC0", VA = "0x1804887C0")]
		get
		{
			return this._zombieType;
		}
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x4887D0", Offset = "0x486DD0", VA = "0x1804887D0")]
		set
		{
			this._zombieType = value;
			Transform transform = this.board.transform;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			Vector3 vector2;
			float z2 = vector2.z;
			GameObject gameObject;
			Transform transform2 = gameObject.transform;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform transform3 = gameObject.transform;
			int num = 0;
			int num2 = 0;
			transform3.Rotate((float)num2, 180f, (float)num);
			Transform transform4 = gameObject.transform;
			Transform transform5 = base.transform;
			transform4.parentInternal = transform5;
			SortingGroup orAddComponent = gameObject.GetOrAddComponent<SortingGroup>();
			orAddComponent.sortAtRoot = true;
			orAddComponent.sortingOrder = 1;
			int num3 = 0;
			orAddComponent.sortingLayerID = num3;
		}
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x0005FE9C File Offset: 0x0005E09C
	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x487DF0", Offset = "0x4863F0", VA = "0x180487DF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)6L);
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x0005FEB8 File Offset: 0x0005E0B8
	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x487BE0", Offset = "0x4861E0", VA = "0x180487BE0", Slot = "39")]
	protected override void AttributeEvent()
	{
		Board board = this.board;
		int num = 0;
		Transform axis = this.axis;
		ZombieType zombieType = this._zombieType;
		CreateZombie instance = CreateZombie.Instance;
		float thePlantAttackInterval = this.thePlantAttackInterval;
		base.AttributeCountdown = thePlantAttackInterval;
		Transform axis2 = this.axis;
		ParticleManager instance2 = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance2.SetParticle((ParticleType)((uint)11), num, thePlantRow, num3 != 0UL, (float)num2);
		if (this._zombieType == ZombieType.ProjectileZombie)
		{
			int num4 = 0;
			base.Die((Plant.DieReason)num4);
		}
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x0005FF48 File Offset: 0x0005E148
	[Token(Token = "0x60010DC")]
	[Address(RVA = "0x488240", Offset = "0x486840", VA = "0x180488240", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			Board board = this.board;
			this.FireBullets();
			return;
		}
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x0005FF7C File Offset: 0x0005E17C
	[Token(Token = "0x60010DD")]
	[Address(RVA = "0x488720", Offset = "0x486D20", VA = "0x180488720", Slot = "56")]
	protected override bool OnStarUp()
	{
		this.attributeCount = (int)((ulong)0L);
		base.UpdateText();
		return true;
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x0005FF9C File Offset: 0x0005E19C
	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x487FA0", Offset = "0x4865A0", VA = "0x180487FA0")]
	private void FireBullets()
	{
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.bulletLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				uint num3;
				uint num4;
				GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num3, (int)num4), 0.5f, 1f);
				CreateItem instance = CreateItem.Instance;
				Transform transform = base.transform;
				Vector3 vector2;
				float z2 = vector2.z;
				this.OnFire();
			}
			num++;
		}
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00060018 File Offset: 0x0005E218
	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x488360", Offset = "0x486960", VA = "0x180488360")]
	private void OnFire()
	{
		int attributeCount;
		int num4;
		do
		{
			int num = 0;
			attributeCount = this.attributeCount;
			int num2 = attributeCount + 1;
			this.attributeCount = num2;
			int num3 = attributeCount + 1;
			num4 = 0;
			this.attributeCount = num4;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
				GameObject gameObject = this.fertilizePrefab;
				Transform axis = this.axis;
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = this.board.transform;
				GameObject gameObject2;
				gameObject2.GetComponent<Fertilize>().isLand = true;
			}
		}
		while (num4 != 0);
		int num6 = attributeCount - 1;
		this.attributeCount = num6;
		int num7 = 0;
		base.Die((Plant.DieReason)num7);
		base.UpdateText();
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x000600F4 File Offset: 0x0005E2F4
	[Token(Token = "0x60010E0")]
	[Address(RVA = "0x487E10", Offset = "0x486410", VA = "0x180487E10", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Board board = this.board;
		Transform axis = this.axis;
		GameObject gameObject = this.fertilizePrefab;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x0006013C File Offset: 0x0005E33C
	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x488290", Offset = "0x486890", VA = "0x180488290", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x0006015C File Offset: 0x0005E35C
	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public EndoFlame()
	{
	}

	// Token: 0x04000BD9 RID: 3033
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BD9")]
	public GameObject fertilizePrefab;

	// Token: 0x04000BDA RID: 3034
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BDA")]
	private ZombieType _zombieType;
}
