using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000406 RID: 1030
[Token(Token = "0x2000406")]
public class NuclearSquash : Squash
{
	// Token: 0x17000136 RID: 310
	// (get) Token: 0x060012FC RID: 4860 RVA: 0x0006A64C File Offset: 0x0006884C
	[Token(Token = "0x17000136")]
	protected override Vector2 Range
	{
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x47B920", Offset = "0x479F20", VA = "0x18047B920", Slot = "68")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x0006A664 File Offset: 0x00068864
	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x482420", Offset = "0x480A20", VA = "0x180482420", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 30f;
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x0006A684 File Offset: 0x00068884
	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x4ABC10", Offset = "0x4AA210", VA = "0x1804ABC10", Slot = "72")]
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

	// Token: 0x060012FF RID: 4863 RVA: 0x0006A7A8 File Offset: 0x000689A8
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public NuclearSquash()
	{
	}

	// Token: 0x04000C94 RID: 3220
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000C94")]
	public GameObject radiationPrefab;
}
