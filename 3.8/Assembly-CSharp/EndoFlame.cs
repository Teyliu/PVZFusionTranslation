using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000383 RID: 899
[Token(Token = "0x2000383")]
public class EndoFlame : Plant
{
	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06001083 RID: 4227 RVA: 0x0005EAB8 File Offset: 0x0005CCB8
	// (set) Token: 0x06001084 RID: 4228 RVA: 0x0005EACC File Offset: 0x0005CCCC
	[Token(Token = "0x170000E0")]
	public ZombieType ZombieType
	{
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x434F20", Offset = "0x433520", VA = "0x180434F20")]
		get
		{
			return this._zombieType;
		}
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x434F30", Offset = "0x433530", VA = "0x180434F30")]
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

	// Token: 0x06001085 RID: 4229 RVA: 0x0005EB80 File Offset: 0x0005CD80
	[Token(Token = "0x6001085")]
	[Address(RVA = "0x434540", Offset = "0x432B40", VA = "0x180434540", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)6L);
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x0005EB9C File Offset: 0x0005CD9C
	[Token(Token = "0x6001086")]
	[Address(RVA = "0x434330", Offset = "0x432930", VA = "0x180434330", Slot = "40")]
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

	// Token: 0x06001087 RID: 4231 RVA: 0x0005EC2C File Offset: 0x0005CE2C
	[Token(Token = "0x6001087")]
	[Address(RVA = "0x4349A0", Offset = "0x432FA0", VA = "0x1804349A0", Slot = "17")]
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

	// Token: 0x06001088 RID: 4232 RVA: 0x0005EC60 File Offset: 0x0005CE60
	[Token(Token = "0x6001088")]
	[Address(RVA = "0x434E80", Offset = "0x433480", VA = "0x180434E80", Slot = "57")]
	protected override bool OnStarUp()
	{
		this.attributeCount = (int)((ulong)0L);
		base.UpdateText();
		return true;
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x0005EC80 File Offset: 0x0005CE80
	[Token(Token = "0x6001089")]
	[Address(RVA = "0x4346F0", Offset = "0x432CF0", VA = "0x1804346F0")]
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

	// Token: 0x0600108A RID: 4234 RVA: 0x0005ECFC File Offset: 0x0005CEFC
	[Token(Token = "0x600108A")]
	[Address(RVA = "0x434AC0", Offset = "0x4330C0", VA = "0x180434AC0")]
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

	// Token: 0x0600108B RID: 4235 RVA: 0x0005EDD8 File Offset: 0x0005CFD8
	[Token(Token = "0x600108B")]
	[Address(RVA = "0x434560", Offset = "0x432B60", VA = "0x180434560", Slot = "52")]
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

	// Token: 0x0600108C RID: 4236 RVA: 0x0005EE20 File Offset: 0x0005D020
	[Token(Token = "0x600108C")]
	[Address(RVA = "0x4349F0", Offset = "0x432FF0", VA = "0x1804349F0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x0005EE40 File Offset: 0x0005D040
	[Token(Token = "0x600108D")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public EndoFlame()
	{
	}

	// Token: 0x04000B82 RID: 2946
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B82")]
	public GameObject fertilizePrefab;

	// Token: 0x04000B83 RID: 2947
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B83")]
	private ZombieType _zombieType;
}
