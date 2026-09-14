using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200071D RID: 1821
[Token(Token = "0x200071D")]
public class SuperMachineNutZombie : MachineNutZombie
{
	// Token: 0x060023FC RID: 9212 RVA: 0x000BBE64 File Offset: 0x000BA064
	[Token(Token = "0x60023FC")]
	[Address(RVA = "0x5F5AE0", Offset = "0x5F40E0", VA = "0x1805F5AE0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		if (TravelMgr.Instance.data.invest_challenge)
		{
			float num;
			this.theOriginSpeed = num;
		}
	}

	// Token: 0x060023FD RID: 9213 RVA: 0x000BBE9C File Offset: 0x000BA09C
	[Token(Token = "0x60023FD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected override void InitType()
	{
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x000BBEAC File Offset: 0x000BA0AC
	[Token(Token = "0x60023FE")]
	[Address(RVA = "0x5F57C0", Offset = "0x5F3DC0", VA = "0x1805F57C0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[36];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		if (!TravelMgr.Instance.data.invest_challenge)
		{
			Transform axis2 = this.axis;
			Vector3 vector2;
			float z2 = vector2.z;
			GameObject gameObject2 = Resources.Load<GameObject>("Items/SuperMachine");
			Board board = this.board;
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
			Transform transform2 = board.transform;
		}
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x000BBF50 File Offset: 0x000BA150
	[Token(Token = "0x60023FF")]
	[Address(RVA = "0x5F5B70", Offset = "0x5F4170", VA = "0x1805F5B70")]
	public SuperMachineNutZombie()
	{
	}
}
