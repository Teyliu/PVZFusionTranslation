using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200027D RID: 637
[Token(Token = "0x200027D")]
public class PetDrown : MiniPet
{
	// Token: 0x06000B79 RID: 2937 RVA: 0x000413C8 File Offset: 0x0003F5C8
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x937FC0", Offset = "0x9365C0", VA = "0x180937FC0", Slot = "19")]
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

	// Token: 0x06000B7A RID: 2938 RVA: 0x00041470 File Offset: 0x0003F670
	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x937F10", Offset = "0x936510", VA = "0x180937F10", Slot = "12")]
	protected override void AttributeEvent()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x00041494 File Offset: 0x0003F694
	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x938170", Offset = "0x936770", VA = "0x180938170")]
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
			Func<Zombie, bool> func = delegate(Zombie z)
			{
				int i3 = i;
				if (z.theZombieRow == i3 && !z.isMindControlled)
				{
					return Lawnf.ThrowLandStatus(z.theStatus);
				}
				throw new NullReferenceException();
			};
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
				float z3 = vector.z;
				Vector3 vector2;
				float z2 = vector2.z;
				int i2 = i;
			}
		}
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x00041598 File Offset: 0x0003F798
	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x937D70", Offset = "0x936370", VA = "0x180937D70", Slot = "11")]
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

	// Token: 0x06000B7D RID: 2941 RVA: 0x00041608 File Offset: 0x0003F808
	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x427620", Offset = "0x425C20", VA = "0x180427620", Slot = "18")]
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

	// Token: 0x06000B7E RID: 2942 RVA: 0x0004166C File Offset: 0x0003F86C
	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0x937940", Offset = "0x935F40", VA = "0x180937940", Slot = "9")]
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

	// Token: 0x06000B7F RID: 2943 RVA: 0x00041774 File Offset: 0x0003F974
	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0x938620", Offset = "0x936C20", VA = "0x180938620", Slot = "16")]
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

	// Token: 0x06000B80 RID: 2944 RVA: 0x000417C0 File Offset: 0x0003F9C0
	[Token(Token = "0x6000B80")]
	[Address(RVA = "0x9386D0", Offset = "0x936CD0", VA = "0x1809386D0")]
	private void WeaponUpdate(GameObject weapon, Vector3 velocity, float gravity, int weaponRow, int level)
	{
		float z = velocity.z;
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x000417DC File Offset: 0x0003F9DC
	[Token(Token = "0x6000B81")]
	[Address(RVA = "0x9387F0", Offset = "0x936DF0", VA = "0x1809387F0")]
	public PetDrown()
	{
	}
}
