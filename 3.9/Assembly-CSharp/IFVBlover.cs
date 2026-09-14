using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D0 RID: 976
[Token(Token = "0x20003D0")]
public class IFVBlover : Blover
{
	// Token: 0x060011DB RID: 4571 RVA: 0x000649A4 File Offset: 0x00062BA4
	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x491830", Offset = "0x48FE30", VA = "0x180491830")]
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

	// Token: 0x060011DC RID: 4572 RVA: 0x00064A98 File Offset: 0x00062C98
	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x491730", Offset = "0x48FD30", VA = "0x180491730", Slot = "68")]
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

	// Token: 0x060011DD RID: 4573 RVA: 0x00064AEC File Offset: 0x00062CEC
	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public IFVBlover()
	{
	}

	// Token: 0x04000C24 RID: 3108
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C24")]
	public GameObject targetPrefab;

	// Token: 0x04000C25 RID: 3109
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C25")]
	public GameObject wingmanPrefab;

	// Token: 0x04000C26 RID: 3110
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C26")]
	public IFVWingman wingman;
}
