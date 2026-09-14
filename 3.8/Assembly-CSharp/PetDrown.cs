using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000277 RID: 631
[Token(Token = "0x2000277")]
public class PetDrown : MiniPet
{
	// Token: 0x06000B5D RID: 2909 RVA: 0x00041584 File Offset: 0x0003F784
	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x8A7FA0", Offset = "0x8A65A0", VA = "0x1808A7FA0", Slot = "19")]
	protected override void Awake()
	{
		SortingGroup component = base.GetComponent<SortingGroup>();
		this.sortingGroup = component;
		this.sortingGroup.sortingOrder = 30000;
		Animator component2 = base.GetComponent<Animator>();
		this.anim = component2;
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
		LayerMask layerMask2 = LayerMask.GetMask(new string[] { "Plant", "TorchWood" });
		this.plantLayer = layerMask2;
		this.attributeTimer = 10f;
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x0004162C File Offset: 0x0003F82C
	[Token(Token = "0x6000B5E")]
	[Address(RVA = "0x8A7EF0", Offset = "0x8A64F0", VA = "0x1808A7EF0", Slot = "12")]
	protected override void AttributeEvent()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00041650 File Offset: 0x0003F850
	[Token(Token = "0x6000B5F")]
	[Address(RVA = "0x8A8150", Offset = "0x8A6750", VA = "0x1808A8150")]
	private void BossShoot()
	{
		int num = 0;
		int i = num;
		int rowNum = this.board.rowNum;
		if (i < rowNum)
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(-3);
			Mouse mouse = this.mouse;
			int j = i;
			float landY = mouse.GetLandY(boxXFromColumn, j);
			Board board = this.board;
			int num2 = 0;
			Zombie zombie;
			if (zombie != num2)
			{
				GameObject gameObject = this.shoot.gameObject;
				Transform shoot = this.shoot;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform parent = shoot.transform.parent;
				GameObject gameObject2;
				Transform transform = gameObject2.transform;
				Transform transform2 = this.board.transform;
				transform.parentInternal = transform2;
				Vector2 velocity = zombie.Velocity;
				Transform axis = zombie.axis;
				Vector3 vector;
				float z = vector.z;
				Vector3 vector2;
				float z2 = vector2.z;
				int i2 = i;
			}
		}
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x00041744 File Offset: 0x0003F944
	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x8A7D50", Offset = "0x8A6350", VA = "0x1808A7D50", Slot = "11")]
	protected override void AttackReady(bool moveOver)
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		int num = 0;
		Zombie zombie;
		if (!(zombie == num))
		{
			if (!moveOver)
			{
				Animator anim = this.anim;
				float attackInterval = this.attackInterval;
				this.attackTimer = attackInterval;
				anim.SetTrigger("shoot");
				base.Invoke("SetTarget", 1f);
				base.GetExperience(5);
			}
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x000417B4 File Offset: 0x0003F9B4
	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x3D9480", Offset = "0x3D7A80", VA = "0x1803D9480", Slot = "18")]
	protected override void SetTarget()
	{
		int zombieMaxHealthRow = base.GetZombieMaxHealthRow();
		this.moving = true;
		int num = 0;
		this.targetGrid = (ulong)0L;
		this.targetGrid.m_Y = zombieMaxHealthRow;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(num);
		this.targetPosition = boxXFromColumn;
		float landY = this.mouse.GetLandY(boxXFromColumn, zombieMaxHealthRow);
		this.targetPosition.y = landY;
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00041818 File Offset: 0x0003FA18
	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x8A7920", Offset = "0x8A5F20", VA = "0x1808A7920", Slot = "9")]
	protected override void AnimAttack()
	{
		Transform shoot = this.shoot;
		int num = 0;
		Board board = this.board;
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2)
		{
			Transform shoot2 = this.shoot;
			GameObject gameObject = shoot2.gameObject;
			Transform shoot3 = this.shoot;
			Vector3 position = shoot2.position;
			Transform shoot4 = this.shoot;
			Transform transform = shoot4.transform;
			int num3 = 0;
			Quaternion rotation = shoot4.rotation;
			Transform transform2 = this.shoot.transform;
			int num4 = 0;
			Transform parent = transform2.parent;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num4, num3, parent);
			Transform transform3 = gameObject2.transform;
			Transform transform4 = this.board.transform;
			transform3.parentInternal = transform4;
			Transform shoot5 = this.shoot;
			Vector3 position2 = transform3.position;
			Vector2 velocity = zombie.Velocity;
			Transform axis = zombie.axis;
			int level = this.level;
			float[] array;
			float num5 = array[1];
			int thePetRow = this.thePetRow;
			this.WeaponUpdate(gameObject2, num, num5, thePetRow, level);
		}
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x00041920 File Offset: 0x0003FB20
	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x8A8600", Offset = "0x8A6C00", VA = "0x1808A8600", Slot = "16")]
	protected override bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && Lawnf.ThrowLandStatus(zombie.theStatus))
		{
			int thePetRow = this.thePetRow;
			if (zombie.theZombieRow == thePetRow)
			{
				Transform axis = zombie.axis;
				Transform transform = base.transform;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x0004196C File Offset: 0x0003FB6C
	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x8A86B0", Offset = "0x8A6CB0", VA = "0x1808A86B0")]
	private void WeaponUpdate(GameObject weapon, Vector3 velocity, float gravity, int weaponRow, int level)
	{
		float z = velocity.z;
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00041988 File Offset: 0x0003FB88
	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x8A87D0", Offset = "0x8A6DD0", VA = "0x1808A87D0")]
	public PetDrown()
	{
	}
}
