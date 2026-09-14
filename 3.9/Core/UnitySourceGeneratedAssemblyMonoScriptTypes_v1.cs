using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Token: 0x06000016 RID: 22 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x945800", Offset = "0x943E00", VA = "0x180945800")]
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		return default(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}

	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	private struct MonoScriptData
	{
		// Token: 0x04000007 RID: 7
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000007")]
		public byte[] FilePathsData;

		// Token: 0x04000008 RID: 8
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000008")]
		public byte[] TypesData;

		// Token: 0x04000009 RID: 9
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000009")]
		public int TotalTypes;

		// Token: 0x0400000A RID: 10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400000A")]
		public int TotalFiles;

		// Token: 0x0400000B RID: 11
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000B")]
		public bool IsEditorOnly;
	}
}
