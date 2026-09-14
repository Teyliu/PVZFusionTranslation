using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003DF RID: 991
[Token(Token = "0x20003DF")]
public class LanternNut : WallNut
{
	// Token: 0x06001211 RID: 4625 RVA: 0x00065580 File Offset: 0x00063780
	[Token(Token = "0x6001211")]
	[Address(RVA = "0x49B140", Offset = "0x499740", VA = "0x18049B140", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		ulong num3;
		base.Recover(15f, (DamageType)num, num2 != 0UL, num3 != 0UL);
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x000655AC File Offset: 0x000637AC
	[Token(Token = "0x6001212")]
	[Address(RVA = "0x49B3F0", Offset = "0x4999F0", VA = "0x18049B3F0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		base.AttributeCountdown = 15f;
		GameAPP.PlaySound(85, 0.5f, 1f);
		Transform axis = this.axis;
		GameObject gameObject = GameAPP.particlePrefab[40];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		this.lanternLight = gameObject2;
		throw new NullReferenceException();
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x00065610 File Offset: 0x00063810
	[Token(Token = "0x6001213")]
	[Address(RVA = "0x49B600", Offset = "0x499C00", VA = "0x18049B600", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform transform = this.lanternLight.transform;
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00065644 File Offset: 0x00063844
	[Token(Token = "0x6001214")]
	[Address(RVA = "0x49B1B0", Offset = "0x4997B0", VA = "0x18049B1B0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		CreatePlant instance = CreatePlant.Instance;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		ulong num;
		instance.AdjustLightLevel(thePlantColumn, thePlantRow, -1, (int)num);
		global::UnityEngine.Object.Destroy(this.lanternLight);
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x00065684 File Offset: 0x00063884
	[Token(Token = "0x6001215")]
	[Address(RVA = "0x49B320", Offset = "0x499920", VA = "0x18049B320", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -1, (int)num);
		ulong num2;
		CreatePlant.Instance.AdjustLightLevel(originalColumn, (int)num2, 1, (int)num);
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x000656B4 File Offset: 0x000638B4
	[Token(Token = "0x6001216")]
	[Address(RVA = "0x49B270", Offset = "0x499870", VA = "0x18049B270", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		base.OnCreate(theColumn, theRow);
		ulong num;
		CreatePlant.Instance.AdjustLightLevel(theColumn, theRow, 1, (int)num);
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x000656E0 File Offset: 0x000638E0
	[Token(Token = "0x6001217")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public LanternNut()
	{
	}

	// Token: 0x04000C32 RID: 3122
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C32")]
	protected GameObject lanternLight;

	// Token: 0x04000C33 RID: 3123
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C33")]
	private Vector3 lightPos;
}
