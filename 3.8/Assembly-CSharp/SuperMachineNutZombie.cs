using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E5 RID: 1765
[Token(Token = "0x20006E5")]
public class SuperMachineNutZombie : MachineNutZombie
{
	// Token: 0x060022E0 RID: 8928 RVA: 0x000B701C File Offset: 0x000B521C
	[Token(Token = "0x60022E0")]
	[Address(RVA = "0x57B500", Offset = "0x579B00", VA = "0x18057B500", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (TravelMgr.Instance.data.invest_challenge)
		{
			float num;
			this.theOriginSpeed = num;
		}
	}

	// Token: 0x060022E1 RID: 8929 RVA: 0x000B7054 File Offset: 0x000B5254
	[Token(Token = "0x60022E1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected override void InitType()
	{
	}

	// Token: 0x060022E2 RID: 8930 RVA: 0x000B7064 File Offset: 0x000B5264
	[Token(Token = "0x60022E2")]
	[Address(RVA = "0x57B1E0", Offset = "0x5797E0", VA = "0x18057B1E0", Slot = "28")]
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

	// Token: 0x060022E3 RID: 8931 RVA: 0x000B7108 File Offset: 0x000B5308
	[Token(Token = "0x60022E3")]
	[Address(RVA = "0x57B590", Offset = "0x579B90", VA = "0x18057B590")]
	public SuperMachineNutZombie()
	{
	}
}
