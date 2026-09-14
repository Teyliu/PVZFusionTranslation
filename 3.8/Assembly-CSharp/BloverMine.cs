using System;
using Cpp2IlInjected;

// Token: 0x02000349 RID: 841
[Token(Token = "0x2000349")]
public class BloverMine : Plant
{
	// Token: 0x06000F71 RID: 3953 RVA: 0x00059B78 File Offset: 0x00057D78
	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x41BC70", Offset = "0x41A270", VA = "0x18041BC70", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)20), action, num != 0);
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00059B98 File Offset: 0x00057D98
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x41BA80", Offset = "0x41A080", VA = "0x18041BA80", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)20), action);
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x00059BB0 File Offset: 0x00057DB0
	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x41BB20", Offset = "0x41A120", VA = "0x18041BB20")]
	private void OnPlantDeath(object obj)
	{
		if (obj != 0)
		{
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			CreatePlant instance = CreatePlant.Instance;
			this.attributeCountdown = 15f;
		}
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00059BEC File Offset: 0x00057DEC
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public BloverMine()
	{
	}
}
