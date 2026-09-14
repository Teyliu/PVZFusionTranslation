using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B9D RID: 2973
	[Token(Token = "0x2000B9D")]
	[Serializable]
	public class OnKeyPressNode : EventNodeBase
	{
		// Token: 0x06003DF1 RID: 15857 RVA: 0x00146FB8 File Offset: 0x001451B8
		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x7FCEB0", Offset = "0x7FB4B0", VA = "0x1807FCEB0", Slot = "4")]
		public override PortDefinition[] GetInputPorts()
		{
			return null;
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x00146FC8 File Offset: 0x001451C8
		[Token(Token = "0x6003DF2")]
		[Address(RVA = "0x7FCEF0", Offset = "0x7FB4F0", VA = "0x1807FCEF0", Slot = "5")]
		public override PortDefinition[] GetOutputPorts()
		{
			PortDefinition[] array = new PortDefinition[1];
			int num;
			PortDefinition portDefinition = new PortDefinition(this.trigger_PortName, (PortType)num, (PortDirection)((uint)1));
			num = 0;
			if (portDefinition != 0)
			{
			}
			array[0] = portDefinition;
			return array;
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00147000 File Offset: 0x00145200
		[Token(Token = "0x6003DF3")]
		[Address(RVA = "0x7FCDB0", Offset = "0x7FB3B0", VA = "0x1807FCDB0", Slot = "6")]
		public override void Execute()
		{
			if (this.targetKey != KeyCode.None)
			{
				KeyCode keyCode = this.targetKey;
				EventNodeDebug.Log(string.Format("[OnKeyPressNode] 触发按键事件: {0}", keyCode));
				string text = this.trigger_PortName;
				base.TriggerConnectedNodes(text);
				return;
			}
			string nodeId = this.nodeId;
			EventNodeDebug.LogWarning("[OnKeyPressNode] targetKey 为 None，无法触发按键事件，节点ID: " + nodeId);
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x00147054 File Offset: 0x00145254
		[Token(Token = "0x6003DF4")]
		[Address(RVA = "0x7FCFE0", Offset = "0x7FB5E0", VA = "0x1807FCFE0", Slot = "10")]
		public override int ShowEditorUI(RuntimeNodeUI ui)
		{
			TheButton buttonPrefab = ui.buttonPrefab;
			RectTransform valueEditContainer = ui.valueEditContainer;
			TheButton theButton = global::UnityEngine.Object.Instantiate<TheButton>(buttonPrefab, valueEditContainer);
			TheButton button = theButton;
			TextMeshProUGUI componentInChildren = button.GetComponentInChildren<TextMeshProUGUI>();
			TextMeshProUGUI tmp = componentInChildren;
			TextMeshProUGUI tmp2 = tmp;
			if (this.targetKey != KeyCode.None)
			{
				KeyCode keyCode = this.targetKey;
				string text;
				tmp2.text = text;
			}
			tmp2.text = "请设置按键";
			TheButton button2 = button;
			bool _lock = false;
			UnityEvent theEvent_up = button2.theEvent_up;
			UnityAction unityAction = delegate
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			};
			theEvent_up.AddListener(unityAction);
			return 1;
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00147108 File Offset: 0x00145308
		[Token(Token = "0x6003DF5")]
		[Address(RVA = "0x7FD200", Offset = "0x7FB800", VA = "0x1807FD200")]
		private UniTask<KeyCode> WaitSettingKey(CancellationToken cancellationToken)
		{
			return default(UniTask<KeyCode>);
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00147128 File Offset: 0x00145328
		[Token(Token = "0x6003DF6")]
		[Address(RVA = "0x7FD2F0", Offset = "0x7FB8F0", VA = "0x1807FD2F0")]
		public OnKeyPressNode()
		{
		}

		// Token: 0x04002E98 RID: 11928
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002E98")]
		public KeyCode targetKey;

		// Token: 0x04002E99 RID: 11929
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002E99")]
		public string trigger_PortName = "触发";
	}
}
