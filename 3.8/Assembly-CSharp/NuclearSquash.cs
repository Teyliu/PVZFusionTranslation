using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003EC RID: 1004
[Token(Token = "0x20003EC")]
public class NuclearSquash : Squash
{
	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06001289 RID: 4745 RVA: 0x000688A0 File Offset: 0x00066AA0
	[Token(Token = "0x170000F2")]
	protected override Vector2 Range
	{
		[Token(Token = "0x6001289")]
		[Address(RVA = "0x424C40", Offset = "0x423240", VA = "0x180424C40", Slot = "69")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x000688B8 File Offset: 0x00066AB8
	[Token(Token = "0x600128A")]
	[Address(RVA = "0x431B90", Offset = "0x430190", VA = "0x180431B90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 30f;
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x000688D8 File Offset: 0x00066AD8
	[Token(Token = "0x600128B")]
	[Address(RVA = "0x456780", Offset = "0x454D80", VA = "0x180456780", Slot = "73")]
	protected override void AttackZombie()
	{
		base.AttackZombie();
		BoardAction boardAction = this.board.boardAction;
		Transform axis = this.axis;
		Mouse instance = Mouse.Instance;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int attackDamage = this.attackDamage;
		Transform axis2 = this.axis;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = this.radiationPrefab;
		Transform transform = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = Board.Instance.transform;
		GameObject gameObject2;
		Radiation component = gameObject2.GetComponent<Radiation>();
		int attackDamage2 = this.attackDamage;
		component.damage = attackDamage2;
		PlantType thePlantType2 = this.thePlantType;
		component.fromType = thePlantType2;
		Board board2 = this.board;
		Transform axis3 = this.axis;
		Vector3 vector3;
		float z3 = vector3.z;
		CreateBullet instance2 = CreateBullet.Instance;
		int attackDamage3 = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage3;
		Transform transform3 = bullet.transform;
		num += 10;
		bullet.normalSpeed = 10f;
		PlantType thePlantType3 = this.thePlantType;
		bullet.fromType = thePlantType3;
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x000689FC File Offset: 0x00066BFC
	[Token(Token = "0x600128C")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public NuclearSquash()
	{
	}

	// Token: 0x04000C1D RID: 3101
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000C1D")]
	public GameObject radiationPrefab;
}
