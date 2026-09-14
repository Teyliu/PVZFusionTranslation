using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009A4 RID: 2468
[Token(Token = "0x20009A4")]
public class Synergy_爽快射击 : BaseSynergyData
{
	// Token: 0x060032F3 RID: 13043 RVA: 0x0010AE00 File Offset: 0x00109000
	[Token(Token = "0x60032F3")]
	[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.爽快射击;
	}

	// Token: 0x060032F4 RID: 13044 RVA: 0x0010AE10 File Offset: 0x00109010
	[Token(Token = "0x60032F4")]
	[Address(RVA = "0x75B9A0", Offset = "0x759FA0", VA = "0x18075B9A0", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 0.001f;
		synergyLevelData.<Value2>k__BackingField = 0.3f;
		synergyLevelData.<Description>k__BackingField = "羁绊队员每次射击，获得0.001固定速度增幅，最高叠加到基础速度的0.3倍";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)4L);
		synergyLevelData2.<Value>k__BackingField = 0.002f;
		synergyLevelData2.<Value2>k__BackingField = 0.6f;
		synergyLevelData2.<Description>k__BackingField = "0.002固定速度增幅， 0.6倍上限";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)6L);
		synergyLevelData3.<Value>k__BackingField = 0.003f;
		synergyLevelData3.<Value2>k__BackingField = 0.9f;
		synergyLevelData3.<Description>k__BackingField = "0.003固定速度增幅，0.9倍上限";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)8L);
		synergyLevelData4.<Value>k__BackingField = 0.005f;
		synergyLevelData4.<Value2>k__BackingField = 1.5f;
		synergyLevelData4.<Description>k__BackingField = "0.005固定速度增幅，1.5倍上限";
		int size4 = list._size;
		list._size = synergyLevelData4;
		synergyLevelData4.<Value>k__BackingField = synergyLevelData4;
		SynergyLevelData synergyLevelData5 = new SynergyLevelData();
		synergyLevelData5.<ActiveCount>k__BackingField = (int)((ulong)11L);
		synergyLevelData5.<Value>k__BackingField = 0.01f;
		synergyLevelData5.<Value2>k__BackingField = 2.25f;
		synergyLevelData5.<Description>k__BackingField = "0.01固定速度增幅，2.25倍上限";
		int size5 = list._size;
		return list;
	}

	// Token: 0x060032F5 RID: 13045 RVA: 0x0010AFA4 File Offset: 0x001091A4
	[Token(Token = "0x60032F5")]
	[Address(RVA = "0x75BDD0", Offset = "0x75A3D0", VA = "0x18075BDD0", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		ulong num2;
		do
		{
			SynergyLevelData data = base.GetData();
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)6), action, num != 0);
			float <Value>k__BackingField = data.<Value>k__BackingField;
			this.speeder = <Value>k__BackingField;
			this.restSpeed.Clear();
			HashSet<PlantType> plantsContained = this.plantsContained;
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, float> dictionary = this.restSpeed;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060032F6 RID: 13046 RVA: 0x0010B008 File Offset: 0x00109208
	[Token(Token = "0x60032F6")]
	[Address(RVA = "0x75BFD0", Offset = "0x75A5D0", VA = "0x18075BFD0")]
	private void OnPlantShoot(object obj)
	{
		int num = 0;
		Dictionary<PlantType, float> dictionary = this.restSpeed;
		bool flag;
		ulong num2;
		if (flag && num2 > (ulong)num)
		{
			Dictionary<PlantType, float> dictionary2 = this.restSpeed;
		}
	}

	// Token: 0x060032F7 RID: 13047 RVA: 0x0010B038 File Offset: 0x00109238
	[Token(Token = "0x60032F7")]
	[Address(RVA = "0x75C140", Offset = "0x75A740", VA = "0x18075C140")]
	public Synergy_爽快射击()
	{
		Dictionary<PlantType, float> dictionary = new Dictionary();
		this.restSpeed = dictionary;
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001D8F RID: 7567
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D8F")]
	private float speeder;

	// Token: 0x04001D90 RID: 7568
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001D90")]
	private readonly Dictionary<PlantType, float> restSpeed;
}
