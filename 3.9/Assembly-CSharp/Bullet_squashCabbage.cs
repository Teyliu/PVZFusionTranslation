using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B2 RID: 434
[Token(Token = "0x20001B2")]
public class Bullet_squashCabbage : Bullet
{
	// Token: 0x06000779 RID: 1913 RVA: 0x00025CE0 File Offset: 0x00023EE0
	[Token(Token = "0x6000779")]
	[Address(RVA = "0x6F49E0", Offset = "0x6F2FE0", VA = "0x1806F49E0", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		this.small = (int)((ulong)0L);
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x00025CFC File Offset: 0x00023EFC
	[Token(Token = "0x600077A")]
	[Address(RVA = "0x810F70", Offset = "0x80F570", VA = "0x180810F70", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		float num = this.velocity * 0.5f;
		this.velocity = num;
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x00025D20 File Offset: 0x00023F20
	[Token(Token = "0x600077B")]
	[Address(RVA = "0x810BF0", Offset = "0x80F1F0", VA = "0x180810BF0", Slot = "17")]
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
			float y = this.velocity.y;
			component.dy = y;
			base.Die();
			return;
		}
		Transform transform4 = base.transform;
		Vector2 oneVector = Vector2.oneVector;
		GameAPP.PlaySound(75, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00025E44 File Offset: 0x00024044
	[Token(Token = "0x600077C")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_squashCabbage()
	{
	}

	// Token: 0x040003A0 RID: 928
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40003A0")]
	public GameObject littleCabbagePrefab;

	// Token: 0x040003A1 RID: 929
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40003A1")]
	public int small;
}
