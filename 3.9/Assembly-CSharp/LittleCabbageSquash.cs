using System;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200055D RID: 1373
[Token(Token = "0x200055D")]
public class LittleCabbageSquash : MonoBehaviour
{
	// Token: 0x0600198B RID: 6539 RVA: 0x0008A2EC File Offset: 0x000884EC
	[Token(Token = "0x600198B")]
	[Address(RVA = "0x535240", Offset = "0x533840", VA = "0x180535240")]
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

	// Token: 0x0600198C RID: 6540 RVA: 0x0008A40C File Offset: 0x0008860C
	[Token(Token = "0x600198C")]
	[Address(RVA = "0x535020", Offset = "0x533620", VA = "0x180535020")]
	private void AnimShoot()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = this.shoot;
		Transform transform2 = this.shoot;
		float num = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		Bullet bullet;
		bullet.velocity = num;
		float num2 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		bullet.velocity.y = num2;
		float num3 = this.dy;
		bullet.acceleration.y = num3;
		int num4 = this.attackDamage;
		num4 -= transform2;
		bullet._damage = num4;
		PlantType plantType = this.fromType;
		bullet.fromType = plantType;
		int num5 = this.small + 1;
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x0008A4B8 File Offset: 0x000886B8
	[Token(Token = "0x600198D")]
	[Address(RVA = "0x5351E0", Offset = "0x5337E0", VA = "0x1805351E0")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x0008A4D0 File Offset: 0x000886D0
	[Token(Token = "0x600198E")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public LittleCabbageSquash()
	{
	}

	// Token: 0x04000EE2 RID: 3810
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EE2")]
	public int row;

	// Token: 0x04000EE3 RID: 3811
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000EE3")]
	public int attackDamage;

	// Token: 0x04000EE4 RID: 3812
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EE4")]
	public PlantType fromType;

	// Token: 0x04000EE5 RID: 3813
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000EE5")]
	public Board board;

	// Token: 0x04000EE6 RID: 3814
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000EE6")]
	public Transform shoot;

	// Token: 0x04000EE7 RID: 3815
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000EE7")]
	public Transform center;

	// Token: 0x04000EE8 RID: 3816
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000EE8")]
	public int small;

	// Token: 0x04000EE9 RID: 3817
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000EE9")]
	public float x;

	// Token: 0x04000EEA RID: 3818
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000EEA")]
	public float y;

	// Token: 0x04000EEB RID: 3819
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000EEB")]
	public float dy;
}
