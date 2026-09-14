using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007D6 RID: 2006
[Token(Token = "0x20007D6")]
public class Weapon_gloom : PlayerWeapon
{
	// Token: 0x060028CD RID: 10445 RVA: 0x000DBE04 File Offset: 0x000DA004
	[Token(Token = "0x60028CD")]
	[Address(RVA = "0x678160", Offset = "0x676760", VA = "0x180678160", Slot = "10")]
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

	// Token: 0x060028CE RID: 10446 RVA: 0x000DBEE8 File Offset: 0x000DA0E8
	[Token(Token = "0x60028CE")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_gloom()
	{
	}
}
