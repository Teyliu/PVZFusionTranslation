using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000223 RID: 547
[Token(Token = "0x2000223")]
public class KirovBomb : MonoBehaviour
{
	// Token: 0x06000963 RID: 2403 RVA: 0x00032A94 File Offset: 0x00030C94
	[Token(Token = "0x6000963")]
	[Address(RVA = "0x914AA0", Offset = "0x9130A0", VA = "0x180914AA0")]
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

	// Token: 0x06000964 RID: 2404 RVA: 0x00032B00 File Offset: 0x00030D00
	[Token(Token = "0x6000964")]
	[Address(RVA = "0x9142B0", Offset = "0x9128B0", VA = "0x1809142B0")]
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

	// Token: 0x06000965 RID: 2405 RVA: 0x00032C94 File Offset: 0x00030E94
	[Token(Token = "0x6000965")]
	[Address(RVA = "0x914BB0", Offset = "0x9131B0", VA = "0x180914BB0")]
	public KirovBomb()
	{
	}

	// Token: 0x040004C3 RID: 1219
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004C3")]
	private float existTime;

	// Token: 0x040004C4 RID: 1220
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004C4")]
	private bool explode;

	// Token: 0x040004C5 RID: 1221
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004C5")]
	public int bombRow;

	// Token: 0x040004C6 RID: 1222
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40004C6")]
	public int bombDamage = (int)((ulong)500L);

	// Token: 0x040004C7 RID: 1223
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004C7")]
	public bool fromHypno;

	// Token: 0x040004C8 RID: 1224
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40004C8")]
	public DamageType damageType = (DamageType)((ulong)16L);
}
