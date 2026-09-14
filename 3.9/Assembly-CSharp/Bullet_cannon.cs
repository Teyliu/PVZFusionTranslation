using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200012B RID: 299
[Token(Token = "0x200012B")]
public class Bullet_cannon : Bullet
{
	// Token: 0x060005AB RID: 1451 RVA: 0x0001DDAC File Offset: 0x0001BFAC
	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x6E9740", Offset = "0x6E7D40", VA = "0x1806E9740", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		GameObject gameObject = this.shadow.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
		Collider2D col = this.col;
		int num2 = 0;
		col.enabled = num2 != 0;
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x0001DDEC File Offset: 0x0001BFEC
	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x6E7470", Offset = "0x6E5A70", VA = "0x1806E7470", Slot = "17")]
	public override void HitLand()
	{
		int i;
		Bullet_cannon.<>c__DisplayClass1_1 CS$<>8__locals2;
		for (;;)
		{
			int num = 0;
			ScreenShake.TriggerShake(0.15f);
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			int mask = LayerMask.GetMask(new string[] { "Zombie", "Plant", "TorchWood", "Ladder", "Default" });
			List<Zombie> list = new List();
			HashSet<Plant> hashSet = new HashSet();
			Collider2D[] array;
			if (num < array.Length)
			{
				if (!array.TryGetComponent<Zombie>(num))
				{
					if (array.TryGetComponent<Plant>(num))
					{
						bool flag = hashSet.Add(num);
						num++;
					}
					bool flag2 = array.TryGetComponent<GridItem>(num);
					if (flag2)
					{
						if (flag2)
						{
							num++;
						}
						if (num == 8)
						{
							num++;
						}
					}
				}
				num++;
			}
			BulletType theBulletType = this.theBulletType;
			if (theBulletType > BulletType.Bullet_melonCannon)
			{
				int num3;
				if (theBulletType == BulletType.Bullet_goldMelonCannon)
				{
					bool flag3;
					if (flag3)
					{
						PlantType fromType = this.fromType;
					}
					if (num != 0)
					{
						continue;
					}
					num3 = 0;
				}
				bool flag4;
				if (flag4)
				{
				}
				if (num3 == 0)
				{
					int num4 = 0;
					List<Plant> allPlants = Lawnf.GetAllPlants();
					bool flag5;
					int num5;
					if (flag5)
					{
						bool flag6;
						if (!flag6)
						{
							bool flag7;
							while (!flag7)
							{
							}
							CreatePlant instance = CreatePlant.Instance;
						}
						CreatePlant instance2 = CreatePlant.Instance;
						num5 = 0;
					}
					if (num4 == 0)
					{
						int num6 = 0;
						int num7 = 0;
						uint num8;
						GameObject gameObject = CreateParticle.SetParticle((int)num8, num5, num, num7 != 0);
						bool flag8;
						if (flag8)
						{
							num6++;
						}
						if (num6 == 0)
						{
							i = 0;
							GameObject gameObject2 = Resources.Load<GameObject>("Plants/CobCannon/UltimateExplodeCannon/PopCorn");
							bool flag9;
							if (flag9)
							{
							}
							if (num6 > 0)
							{
								Vector3 vector;
								float z = vector.z;
								Quaternion identityQuaternion = Quaternion.identityQuaternion;
								GameObject gameObject3;
								CannonExplodeSplat component = gameObject3.GetComponent<CannonExplodeSplat>();
								Rigidbody2D rb = component.rb;
								float num10;
								float num9 = global::UnityEngine.Random.Range(num10, 5f);
								component.row = component;
								component.damage = gameObject2;
								SortingGroup sortingGroup = component.AddComponent<SortingGroup>();
								string text = string.Format("bullet{0}", sortingGroup);
								sortingGroup.sortingLayerName = text;
								component.fromType = text;
								i++;
							}
							bool flag10;
							bool flag11;
							if (flag10 && flag11)
							{
								Bullet_cannon.<>c__DisplayClass1_0 CS$<>8__locals1;
								CS$<>8__locals1.<>4__this = 0;
								CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
								if (hashSet == (ulong)2L)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		Bullet_cannon.<>c__DisplayClass1_0 CS$<>8__locals3 = CS$<>8__locals2.CS$<>8__locals1;
		Vector3 vector2;
		float z2 = vector2.z;
		CS$<>8__locals2.center.z = z2;
		while (i >= 10)
		{
		}
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x0001E04C File Offset: 0x0001C24C
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x6E7340", Offset = "0x6E5940", VA = "0x1806E7340")]
	private void FireDoomAction(Vector2 center, int damage)
	{
		LayerMask zombieLayer = this.zombieLayer;
		int num = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
			}
			num++;
		}
	}

	// Token: 0x060005AE RID: 1454 RVA: 0x0001E07C File Offset: 0x0001C27C
	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cannon()
	{
	}
}
