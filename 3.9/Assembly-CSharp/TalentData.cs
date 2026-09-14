using System;
using Cpp2IlInjected;
using TMPro;

// Token: 0x02000A1D RID: 2589
[Token(Token = "0x2000A1D")]
[Serializable]
public class TalentData
{
	// Token: 0x06003538 RID: 13624 RVA: 0x0011A890 File Offset: 0x00118A90
	[Token(Token = "0x6003538")]
	[Address(RVA = "0x782820", Offset = "0x780E20", VA = "0x180782820")]
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

	// Token: 0x06003539 RID: 13625 RVA: 0x0011A910 File Offset: 0x00118B10
	[Token(Token = "0x6003539")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public TalentData()
	{
	}

	// Token: 0x04002693 RID: 9875
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002693")]
	public int id;

	// Token: 0x04002694 RID: 9876
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4002694")]
	public int cost;

	// Token: 0x04002695 RID: 9877
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002695")]
	public string name;

	// Token: 0x04002696 RID: 9878
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002696")]
	public string description;

	// Token: 0x04002697 RID: 9879
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002697")]
	public PlantType icon;

	// Token: 0x04002698 RID: 9880
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4002698")]
	public AdvantureLevel needLevel;
}
