using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000405 RID: 1029
[Token(Token = "0x2000405")]
public class NuclearDoomCherry : Plant
{
	// Token: 0x060012F8 RID: 4856 RVA: 0x0006A4FC File Offset: 0x000686FC
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x0006A51C File Offset: 0x0006871C
	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x481300", Offset = "0x47F900", VA = "0x180481300", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x0006A534 File Offset: 0x00068734
	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x4AB7D0", Offset = "0x4A9DD0", VA = "0x1804AB7D0", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num2 = 0;
		int attackDamage = this.attackDamage;
		Transform axis = this.axis;
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
		PlantType thePlantType2 = this.thePlantType;
		component.fromType = thePlantType2;
		int attackDamage2 = this.attackDamage;
		component.damage = attackDamage2;
		Transform axis2 = this.axis;
		Vector3 vector3;
		float z3 = vector3.z;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage3 = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage3;
		Transform transform3 = bullet.transform;
		num2 += 10;
		bullet.normalSpeed = 10f;
		PlantType thePlantType3 = this.thePlantType;
		bullet.fromType = thePlantType3;
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x0006A638 File Offset: 0x00068838
	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public NuclearDoomCherry()
	{
	}

	// Token: 0x04000C93 RID: 3219
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C93")]
	public GameObject radiationPrefab;
}
