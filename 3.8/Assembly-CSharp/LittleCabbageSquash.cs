using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000530 RID: 1328
[Token(Token = "0x2000530")]
public class LittleCabbageSquash : MonoBehaviour
{
	// Token: 0x060018BB RID: 6331 RVA: 0x00086628 File Offset: 0x00084828
	[Token(Token = "0x60018BB")]
	[Address(RVA = "0x4D4960", Offset = "0x4D2F60", VA = "0x1804D4960")]
	private void Start()
	{
		int num = 0;
		Animator component = base.GetComponent<Animator>();
		float num2 = global::UnityEngine.Random.Range(0.95f, 1.05f);
		component.SetFloat("Speed", num2);
		Transform transform = this.center;
		Vector3 vector;
		float z = vector.z;
		int mask = LayerMask.GetMask(new string[] { "Zombie" });
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				int num3 = this.row;
				PlantType plantType = this.fromType;
			}
			num++;
		}
		SortingGroup sortingGroup = this.AddComponent<SortingGroup>();
		int num4 = this.row;
		string text = string.Format("bullet{0}", sortingGroup);
		sortingGroup.sortingLayerName = text;
		GridSystem gridSystem = this.board.gridSystem;
		Mouse instance = Mouse.Instance;
		Transform transform2 = base.transform;
		int num5 = this.row;
		int num6;
		if (gridSystem.GetBoxType(num6, num5) != BoxType.Water)
		{
		}
		Transform transform3 = base.transform;
		Vector2 oneVector = Vector2.oneVector;
		uint num7;
		GameAPP.PlaySound((int)num7, 0.5f, 1f);
		if (this.small == 2)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060018BC RID: 6332 RVA: 0x00086748 File Offset: 0x00084948
	[Token(Token = "0x60018BC")]
	[Address(RVA = "0x4D4740", Offset = "0x4D2D40", VA = "0x1804D4740")]
	private void AnimShoot()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = this.shoot;
		Transform transform2 = this.shoot;
		float num = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		Bullet bullet;
		bullet.Vx = num;
		float num2 = this.y;
		float num3 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		bullet.Vy = num2;
		float num4 = this.dy;
		bullet.detaVy = num4;
		int num5 = this.attackDamage;
		num5 -= transform2;
		bullet._damage = num5;
		PlantType plantType = this.fromType;
		bullet.fromType = plantType;
		int num6 = this.small + 1;
	}

	// Token: 0x060018BD RID: 6333 RVA: 0x000867F4 File Offset: 0x000849F4
	[Token(Token = "0x60018BD")]
	[Address(RVA = "0x4D4900", Offset = "0x4D2F00", VA = "0x1804D4900")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x0008680C File Offset: 0x00084A0C
	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public LittleCabbageSquash()
	{
	}

	// Token: 0x04000E27 RID: 3623
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E27")]
	public int row;

	// Token: 0x04000E28 RID: 3624
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000E28")]
	public int attackDamage;

	// Token: 0x04000E29 RID: 3625
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E29")]
	public PlantType fromType;

	// Token: 0x04000E2A RID: 3626
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E2A")]
	public Board board;

	// Token: 0x04000E2B RID: 3627
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E2B")]
	public Transform shoot;

	// Token: 0x04000E2C RID: 3628
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E2C")]
	public Transform center;

	// Token: 0x04000E2D RID: 3629
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E2D")]
	public int small;

	// Token: 0x04000E2E RID: 3630
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000E2E")]
	public float x;

	// Token: 0x04000E2F RID: 3631
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E2F")]
	public float y;

	// Token: 0x04000E30 RID: 3632
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000E30")]
	public float dy;
}
