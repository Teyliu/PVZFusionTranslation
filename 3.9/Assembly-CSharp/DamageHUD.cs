using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020002C4 RID: 708
[Token(Token = "0x20002C4")]
public class DamageHUD : MonoBehaviour
{
	// Token: 0x06000C6E RID: 3182 RVA: 0x00046E94 File Offset: 0x00045094
	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x41FFA0", Offset = "0x41E5A0", VA = "0x18041FFA0")]
	private void Awake()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.text = component;
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00046EB0 File Offset: 0x000450B0
	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x420150", Offset = "0x41E750", VA = "0x180420150")]
	private void Update()
	{
		int num = 0;
		Bullet bullet = this.follow;
		int num2 = 0;
		if (!(bullet == num2))
		{
			Bullet bullet2 = this.follow;
			TextMeshProUGUI textMeshProUGUI = this.text;
			if ((bullet2.board.showBulletDamage ? 1 : 0) == num)
			{
			}
			bool activeSelf = bullet2.gameObject.activeSelf;
			textMeshProUGUI.enabled = activeSelf;
			if (this.text.enabled)
			{
				Transform transform = base.transform;
				Transform transform2 = this.follow.transform;
				Vector3 vector;
				float z = vector.z;
				Transform transform3 = base.transform;
				Transform transform4 = base.transform;
				Vector3 vector2;
				float z2 = vector2.z;
				Vector3 vector3;
				float z3 = vector3.z;
				Bullet bullet3 = this.follow;
				TextMeshProUGUI textMeshProUGUI2 = this.text;
				int damage = bullet3._damage;
				string text;
				textMeshProUGUI2.text = text;
			}
			return;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00046F8C File Offset: 0x0004518C
	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x41FFF0", Offset = "0x41E5F0", VA = "0x18041FFF0")]
	private void PositionUpdate()
	{
		Transform transform = base.transform;
		Transform transform2 = this.follow.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform3 = base.transform;
		Transform transform4 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x00046FE0 File Offset: 0x000451E0
	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public DamageHUD()
	{
	}

	// Token: 0x04000889 RID: 2185
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000889")]
	public Bullet follow;

	// Token: 0x0400088A RID: 2186
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400088A")]
	public TextMeshProUGUI text;
}
