using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x020009E1 RID: 2529
[Token(Token = "0x20009E1")]
[Serializable]
public class TalentData
{
	// Token: 0x06003404 RID: 13316 RVA: 0x00115938 File Offset: 0x00113B38
	[Token(Token = "0x6003404")]
	[Address(RVA = "0x71D2B0", Offset = "0x71B8B0", VA = "0x18071D2B0")]
	public void Load(TalentNode node)
	{
		int num = node.id;
		if (this.id == num)
		{
			int num2 = this.id;
			TextMeshProUGUI nametextMesh = node.nametextMesh;
			int num3 = this.cost;
			string text = string.Format("{0}_{1}", num2, num2);
			string text2 = this.name;
			string text3 = text + "\n" + text2;
			nametextMesh.text = text3;
			PlantType plantType = this.icon;
			node.ChangeCardSprite(plantType);
			node.data = this;
		}
	}

	// Token: 0x06003405 RID: 13317 RVA: 0x001159B8 File Offset: 0x00113BB8
	[Token(Token = "0x6003405")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public TalentData()
	{
	}

	// Token: 0x04002581 RID: 9601
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002581")]
	public int id;

	// Token: 0x04002582 RID: 9602
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4002582")]
	public int cost;

	// Token: 0x04002583 RID: 9603
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002583")]
	public string name;

	// Token: 0x04002584 RID: 9604
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002584")]
	public string description;

	// Token: 0x04002585 RID: 9605
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002585")]
	public PlantType icon;

	// Token: 0x04002586 RID: 9606
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002586")]
	public AdvantureLevel needLevel;
}
