using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200079D RID: 1949
[Token(Token = "0x200079D")]
public class Weapon_gloom : PlayerWeapon
{
	// Token: 0x0600279E RID: 10142 RVA: 0x000D6E48 File Offset: 0x000D5048
	[Token(Token = "0x600279E")]
	[Address(RVA = "0x6148D0", Offset = "0x612ED0", VA = "0x1806148D0", Slot = "10")]
	protected override void Shoot()
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			Transform transform = this.player.transform;
			Vector3 vector;
			float z = vector.z;
			int rowFromY = Lawnf.GetRowFromY((float)num2);
			int rowFromY2 = Lawnf.GetRowFromY((float)num2);
			GameObject gameObject;
			IEnumerator enumerator = gameObject.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				Vector3 vector2;
				float z2 = vector2.z;
				ParticleSystem particleSystem;
				ParticleSystem.MainModule main = particleSystem.main;
				ParticleSystem.MinMaxCurve minMaxCurve;
				AnimationCurve curveMax = minMaxCurve.m_CurveMax;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		int num3 = 0;
		int num4 = 0;
		Collider2D[] array;
		if (num3 < array.Length)
		{
			bool flag;
			if (!flag || Lawnf.InLandStatus((ZombieStatus)num))
			{
			}
			num3++;
		}
		if (num4 != 0)
		{
			uint num5;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num5), 0.5f, 1f);
		}
	}

	// Token: 0x0600279F RID: 10143 RVA: 0x000D6F2C File Offset: 0x000D512C
	[Token(Token = "0x600279F")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_gloom()
	{
	}
}
