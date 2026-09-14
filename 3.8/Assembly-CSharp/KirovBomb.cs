using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200021E RID: 542
[Token(Token = "0x200021E")]
public class KirovBomb : MonoBehaviour
{
	// Token: 0x0600094D RID: 2381 RVA: 0x00032C64 File Offset: 0x00030E64
	[Token(Token = "0x600094D")]
	[Address(RVA = "0x884F60", Offset = "0x883560", VA = "0x180884F60")]
	private void Update()
	{
		float deltaTime = Time.deltaTime;
		this.existTime = deltaTime;
		Transform transform = base.transform;
		float num = this.existTime;
		float deltaTime2 = Time.deltaTime;
		if (this.existTime > 1f && !this.explode)
		{
			this.explode = true;
			this.Explode();
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00032CD0 File Offset: 0x00030ED0
	[Token(Token = "0x600094E")]
	[Address(RVA = "0x884770", Offset = "0x882D70", VA = "0x180884770")]
	private void Explode()
	{
		int num;
		do
		{
			num = 0;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.3f, 1f);
			GameObject gameObject = GameAPP.particlePrefab[41];
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform2 = Board.Instance.transform;
			if ((this.fromHypno ? 1 : 0) != num)
			{
				break;
			}
			Transform transform3 = base.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			int mask = LayerMask.GetMask(new string[] { "Plant", "TorchWood" });
			HashSet<Plant> hashSet = new HashSet();
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int num3 = this.bombRow;
					bool flag2 = hashSet.Add(num);
				}
				num++;
			}
			bool flag3;
			if (flag3)
			{
				int num4 = 0;
				Plant plant;
				if (!(plant == num4))
				{
				}
				DamageType damageType = this.damageType;
			}
		}
		while (num != 0);
		int num5 = this.bombDamage;
		MiniPet pet = Board.Instance.pet;
		int num6 = 0;
		if (pet != num6)
		{
			MiniPet pet2 = Board.Instance.pet;
			if (pet2 != 0)
			{
				float damage = pet2.Damage;
			}
		}
		Transform transform4 = base.transform;
		int mask2 = LayerMask.GetMask(new string[] { "Zombie" });
		Collider2D[] array2;
		if (num < array2.Length)
		{
			bool flag4;
			if (flag4)
			{
				int num7 = this.bombRow;
				if (num > 10)
				{
					if (num == 12 || 18446744073709551596UL <= (ulong)4L || num != 44)
					{
						goto IL_017C;
					}
					num++;
				}
				if (num == 1 || num != 10)
				{
				}
			}
			IL_017C:
			num++;
		}
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00032E64 File Offset: 0x00031064
	[Token(Token = "0x600094F")]
	[Address(RVA = "0x885070", Offset = "0x883670", VA = "0x180885070")]
	public KirovBomb()
	{
	}

	// Token: 0x040004BE RID: 1214
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004BE")]
	private float existTime;

	// Token: 0x040004BF RID: 1215
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004BF")]
	private bool explode;

	// Token: 0x040004C0 RID: 1216
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004C0")]
	public int bombRow;

	// Token: 0x040004C1 RID: 1217
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40004C1")]
	public int bombDamage = (int)((ulong)500L);

	// Token: 0x040004C2 RID: 1218
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004C2")]
	public bool fromHypno;

	// Token: 0x040004C3 RID: 1219
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40004C3")]
	public DamageType damageType = (DamageType)((ulong)16L);
}
