using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000155 RID: 341
[Token(Token = "0x2000155")]
public class Bullet_iceBlock_recover : Bullet_cabbage
{
	// Token: 0x06000633 RID: 1587 RVA: 0x00020710 File Offset: 0x0001E910
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x6F0D20", Offset = "0x6EF320", VA = "0x1806F0D20", Slot = "17")]
	public override void HitLand()
	{
		int num6;
		do
		{
			int num = 0;
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			Plant targetPlant = this.targetPlant;
			int num2 = 0;
			if (!(targetPlant != num2))
			{
				Mouse instance2 = Mouse.Instance;
				Transform transform2 = base.transform;
			}
			Plant targetPlant2 = this.targetPlant;
			int thePlantColumn = targetPlant2.thePlantColumn;
			int thePlantRow = targetPlant2.thePlantRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(thePlantColumn, thePlantRow);
			int num3;
			if (this.theStatus == BulletStatus.Super)
			{
				bool flag;
				if (flag)
				{
				}
				if (num != 0)
				{
					goto IL_0162;
				}
				num3 = 0;
			}
			bool flag2;
			if (flag2)
			{
				bool flag3;
				bool flag4;
				bool flag5;
				if (flag3 && flag4)
				{
					PlantDataManager.PlantData plantData;
					int num4 = plantData.maxHealth.MultiplyPercent(0.2f);
					num4 += (flag5 ? 1 : 0);
				}
				if (num3 != 0)
				{
					goto IL_0174;
				}
				int num5 = 0;
				Func<Plant, bool> func;
				if (Bullet_iceBlock_recover.<>c.<>9__0_0 == 0)
				{
					func = delegate(Plant a)
					{
						Animator anim = a.anim;
						float speed = anim.speed;
						if (anim == 0)
						{
							return true;
						}
						throw new NullReferenceException();
					};
					Bullet_iceBlock_recover.<>c.<>9__0_0 = func;
				}
				IEnumerable<Plant> enumerable = Enumerable.Take<Plant>(Enumerable.Where<Plant>(list, func), flag5 ? 1 : 0);
				if (num5 >= (flag5 ? 1 : 0))
				{
					goto IL_0109;
				}
				num5 += num5;
				if (num5 != (flag5 ? 1 : 0))
				{
					num5++;
					goto IL_0109;
				}
				IL_0136:
				if (num5 == 0)
				{
					num6 = 0;
					goto IL_0141;
				}
				goto IL_0186;
				IL_0109:
				if (num5 < typeof(IEnumerable<Plant>).TypeHandle)
				{
					num5 += num5;
					num5++;
				}
				if (num5 >= num5)
				{
					goto IL_0136;
				}
				num5 += num5;
				if (num5 != 0)
				{
					num5++;
					goto IL_0136;
				}
				goto IL_0136;
			}
			IL_0141:
			bool flag6;
			if (flag6)
			{
				ParticleManager instance3 = ParticleManager.Instance;
			}
		}
		while (num6 != 0);
		return;
		IL_0162:
		throw new NullReferenceException();
		IL_0174:
		throw new NullReferenceException();
		IL_0186:
		throw new NullReferenceException();
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x000208B8 File Offset: 0x0001EAB8
	[Token(Token = "0x6000634")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_iceBlock_recover()
	{
	}
}
