using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200043D RID: 1085
[Token(Token = "0x200043D")]
public class SmallIceShroom : Plant
{
	// Token: 0x060013FB RID: 5115 RVA: 0x0006F544 File Offset: 0x0006D744
	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x4BD4B0", Offset = "0x4BBAB0", VA = "0x1804BD4B0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			bool flag2;
			bool flag3;
			if (!flag2 && flag3)
			{
				GameAPP.PlaySound(67, 0.5f, 1f);
				GameObject[] particlePrefab = GameAPP.particlePrefab;
				Transform axis = this.axis;
				GameObject gameObject = particlePrefab[24];
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = this.board.transform;
				int num = 0;
				base.Die((Plant.DieReason)num);
			}
		}
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x0006F5C0 File Offset: 0x0006D7C0
	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SmallIceShroom()
	{
	}
}
