using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003EB RID: 1003
[Token(Token = "0x20003EB")]
public class NuclearDoomCherry : Plant
{
	// Token: 0x06001285 RID: 4741 RVA: 0x00068760 File Offset: 0x00066960
	[Token(Token = "0x6001285")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x00068780 File Offset: 0x00066980
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x430A10", Offset = "0x42F010", VA = "0x180430A10", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x00068798 File Offset: 0x00066998
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x456350", Offset = "0x454950", VA = "0x180456350", Slot = "40")]
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
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x0006888C File Offset: 0x00066A8C
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public NuclearDoomCherry()
	{
	}

	// Token: 0x04000C1C RID: 3100
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C1C")]
	public GameObject radiationPrefab;
}
