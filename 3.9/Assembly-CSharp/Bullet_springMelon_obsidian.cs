using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UIElements;

// Token: 0x020001AB RID: 427
[Token(Token = "0x20001AB")]
public class Bullet_springMelon_obsidian : Bullet_springMelon
{
	// Token: 0x06000761 RID: 1889 RVA: 0x00025724 File Offset: 0x00023924
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x810020", Offset = "0x80E620", VA = "0x180810020", Slot = "17")]
	public override void HitLand()
	{
		int num;
		do
		{
			num = 0;
			int damage = this._damage;
			List<Plant> allPlants = Lawnf.GetAllPlants();
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
		int num2 = 0;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		EasingMode mode = ((EasingMode)num).m_Mode;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag2;
			if (!flag2 || Lawnf.InLandStatus((ZombieStatus)num))
			{
			}
			num2++;
		}
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector3;
		float z3 = vector3.z;
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x000257C4 File Offset: 0x000239C4
	[Token(Token = "0x6000762")]
	[Address(RVA = "0x810010", Offset = "0x80E610", VA = "0x180810010")]
	public Bullet_springMelon_obsidian()
	{
	}
}
