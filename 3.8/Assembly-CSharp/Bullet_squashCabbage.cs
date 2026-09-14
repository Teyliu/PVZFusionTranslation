using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001AB RID: 427
[Token(Token = "0x20001AB")]
public class Bullet_squashCabbage : Bullet
{
	// Token: 0x0600076C RID: 1900 RVA: 0x000263C8 File Offset: 0x000245C8
	[Token(Token = "0x600076C")]
	[Address(RVA = "0x7E3910", Offset = "0x7E1F10", VA = "0x1807E3910", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		this.small = (int)((ulong)0L);
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x000263E4 File Offset: 0x000245E4
	[Token(Token = "0x600076D")]
	[Address(RVA = "0x7E38E0", Offset = "0x7E1EE0", VA = "0x1807E38E0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		this.hit = false;
		float num = this.Vx * 0.5f;
		this.Vx = num;
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00026410 File Offset: 0x00024610
	[Token(Token = "0x600076E")]
	[Address(RVA = "0x7E3570", Offset = "0x7E1B70", VA = "0x1807E3570", Slot = "18")]
	public override void HitLand()
	{
		GridSystem gridSystem = this.board.gridSystem;
		Mouse instance = Mouse.Instance;
		Transform transform = base.transform;
		int theBulletRow = this.theBulletRow;
		int num;
		if (gridSystem.GetBoxType(num, theBulletRow) != BoxType.Water)
		{
			GameObject gameObject = this.littleCabbagePrefab;
			Transform transform2 = base.transform;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform3 = this.board.transform;
			GameObject gameObject2;
			LittleCabbageSquash component = gameObject2.GetComponent<LittleCabbageSquash>();
			Board board = this.board;
			component.board = board;
			int damage = this._damage;
			component.attackDamage = damage;
			PlantType fromType = this.fromType;
			component.fromType = fromType;
			int theBulletRow2 = this.theBulletRow;
			component.row = theBulletRow2;
			int num2 = this.small;
			component.small = num2;
			component.x = 2f;
			component.y = 7f;
			float detaVy = this.detaVy;
			component.dy = detaVy;
			base.Die();
			return;
		}
		Transform transform4 = base.transform;
		Vector2 oneVector = Vector2.oneVector;
		GameAPP.PlaySound(75, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00026530 File Offset: 0x00024730
	[Token(Token = "0x600076F")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_squashCabbage()
	{
	}

	// Token: 0x04000397 RID: 919
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000397")]
	public GameObject littleCabbagePrefab;

	// Token: 0x04000398 RID: 920
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000398")]
	public int small;
}
