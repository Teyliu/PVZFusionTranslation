using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003BC RID: 956
[Token(Token = "0x20003BC")]
public class IFVBlover : Blover
{
	// Token: 0x0600117F RID: 4479 RVA: 0x00063384 File Offset: 0x00061584
	[Token(Token = "0x600117F")]
	[Address(RVA = "0x442E60", Offset = "0x441460", VA = "0x180442E60")]
	public void SetWingman()
	{
		IFVWingman ifvwingman = this.wingman;
		int num = 0;
		if (ifvwingman != num)
		{
			global::UnityEngine.Object.Destroy(this.wingman.gameObject);
		}
		Transform shoot = this.shoot;
		GameObject gameObject = this.wingmanPrefab;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		IFVWingman component = gameObject2.GetComponent<IFVWingman>();
		this.wingman = component;
		this.wingman.from = this;
		IFVWingman ifvwingman2 = this.wingman;
		Board board = this.board;
		ifvwingman2.board = board;
		int thePlantColumn = this.thePlantColumn;
		IFVWingman ifvwingman3 = this.wingman;
		int thePlantRow = this.thePlantRow;
		IFVWingman ifvwingman4 = this.wingman;
		PlantType thePlantType = this.thePlantType;
		ifvwingman4.fromType = thePlantType;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		ParticleManager instance = ParticleManager.Instance;
		Transform transform2 = this.wingman.transform;
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00063478 File Offset: 0x00061678
	[Token(Token = "0x6001180")]
	[Address(RVA = "0x442D60", Offset = "0x441360", VA = "0x180442D60", Slot = "69")]
	protected override void AnimBlow()
	{
		GameAPP.PlaySound(87, 0.5f, 1f);
		base.BlowZombie();
		GameObject fog = this.board.fog;
		int num = 0;
		if (fog != num)
		{
			FogMgr.Instance.Blown();
		}
		this.SetWingman();
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x000634CC File Offset: 0x000616CC
	[Token(Token = "0x6001181")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public IFVBlover()
	{
	}

	// Token: 0x04000BBE RID: 3006
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BBE")]
	public GameObject targetPrefab;

	// Token: 0x04000BBF RID: 3007
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000BBF")]
	public GameObject wingmanPrefab;

	// Token: 0x04000BC0 RID: 3008
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000BC0")]
	public IFVWingman wingman;
}
