using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000968 RID: 2408
[Token(Token = "0x2000968")]
public class Synergy_爽快射击 : BaseSynergyData
{
	// Token: 0x060031C0 RID: 12736 RVA: 0x00106080 File Offset: 0x00104280
	[Token(Token = "0x60031C0")]
	[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.爽快射击;
	}

	// Token: 0x060031C1 RID: 12737 RVA: 0x00106090 File Offset: 0x00104290
	[Token(Token = "0x60031C1")]
	[Address(RVA = "0x6F65F0", Offset = "0x6F4BF0", VA = "0x1806F65F0", Slot = "8")]
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

	// Token: 0x060031C2 RID: 12738 RVA: 0x00106224 File Offset: 0x00104424
	[Token(Token = "0x60031C2")]
	[Address(RVA = "0x6F6A20", Offset = "0x6F5020", VA = "0x1806F6A20", Slot = "4")]
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

	// Token: 0x060031C3 RID: 12739 RVA: 0x00106288 File Offset: 0x00104488
	[Token(Token = "0x60031C3")]
	[Address(RVA = "0x6F6C20", Offset = "0x6F5220", VA = "0x1806F6C20")]
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

	// Token: 0x060031C4 RID: 12740 RVA: 0x001062B8 File Offset: 0x001044B8
	[Token(Token = "0x60031C4")]
	[Address(RVA = "0x6F6D90", Offset = "0x6F5390", VA = "0x1806F6D90")]
	public Synergy_爽快射击()
	{
		Dictionary<PlantType, float> dictionary = new Dictionary();
		this.restSpeed = dictionary;
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001C9F RID: 7327
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001C9F")]
	private float speeder;

	// Token: 0x04001CA0 RID: 7328
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001CA0")]
	private readonly Dictionary<PlantType, float> restSpeed;
}
