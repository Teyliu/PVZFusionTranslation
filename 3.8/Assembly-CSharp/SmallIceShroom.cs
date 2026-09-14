using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200041E RID: 1054
[Token(Token = "0x200041E")]
public class SmallIceShroom : Plant
{
	// Token: 0x06001371 RID: 4977 RVA: 0x0006D29C File Offset: 0x0006B49C
	[Token(Token = "0x6001371")]
	[Address(RVA = "0x4664C0", Offset = "0x464AC0", VA = "0x1804664C0")]
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

	// Token: 0x06001372 RID: 4978 RVA: 0x0006D318 File Offset: 0x0006B518
	[Token(Token = "0x6001372")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SmallIceShroom()
	{
	}
}
