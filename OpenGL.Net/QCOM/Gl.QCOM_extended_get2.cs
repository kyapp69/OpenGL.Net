
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] glExtGetShadersQCOM: Binding for glExtGetShadersQCOM.
		/// </summary>
		/// <param name="shaders">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="numShaders">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
		public static void ExtGetShadersQCOM(UInt32[] shaders, Int32[] numShaders)
		{
			Debug.Assert(numShaders.Length >= 1);
			unsafe {
				fixed (UInt32* p_shaders = shaders)
				fixed (Int32* p_numShaders = numShaders)
				{
					Debug.Assert(Delegates.pglExtGetShadersQCOM != null, "pglExtGetShadersQCOM not implemented");
					Delegates.pglExtGetShadersQCOM(p_shaders, (Int32)shaders.Length, p_numShaders);
					LogCommand("glExtGetShadersQCOM", null, shaders, shaders.Length, numShaders					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glExtGetProgramsQCOM: Binding for glExtGetProgramsQCOM.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="numPrograms">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
		public static void ExtGetProgramsQCOM(UInt32[] programs, Int32[] numPrograms)
		{
			Debug.Assert(numPrograms.Length >= 1);
			unsafe {
				fixed (UInt32* p_programs = programs)
				fixed (Int32* p_numPrograms = numPrograms)
				{
					Debug.Assert(Delegates.pglExtGetProgramsQCOM != null, "pglExtGetProgramsQCOM not implemented");
					Delegates.pglExtGetProgramsQCOM(p_programs, (Int32)programs.Length, p_numPrograms);
					LogCommand("glExtGetProgramsQCOM", null, programs, programs.Length, numPrograms					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glExtIsProgramBinaryQCOM: Binding for glExtIsProgramBinaryQCOM.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
		public static bool ExtIsProgramBinaryQCOM(UInt32 program)
		{
			bool retValue;

			Debug.Assert(Delegates.pglExtIsProgramBinaryQCOM != null, "pglExtIsProgramBinaryQCOM not implemented");
			retValue = Delegates.pglExtIsProgramBinaryQCOM(program);
			LogCommand("glExtIsProgramBinaryQCOM", retValue, program			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glExtGetProgramBinarySourceQCOM: Binding for glExtGetProgramBinarySourceQCOM.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="shadertype">
		/// A <see cref="T:ShaderType"/>.
		/// </param>
		/// <param name="source">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
		public static void ExtGetProgramBinarySourceQCOM(UInt32 program, ShaderType shadertype, String source, Int32[] length)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglExtGetProgramBinarySourceQCOM != null, "pglExtGetProgramBinarySourceQCOM not implemented");
					Delegates.pglExtGetProgramBinarySourceQCOM(program, (Int32)shadertype, source, p_length);
					LogCommand("glExtGetProgramBinarySourceQCOM", null, program, shadertype, source, length					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glExtGetShadersQCOM(UInt32* shaders, Int32 maxShaders, Int32* numShaders);

			[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glExtGetShadersQCOM pglExtGetShadersQCOM;

			[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glExtGetProgramsQCOM(UInt32* programs, Int32 maxPrograms, Int32* numPrograms);

			[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glExtGetProgramsQCOM pglExtGetProgramsQCOM;

			[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool glExtIsProgramBinaryQCOM(UInt32 program);

			[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glExtIsProgramBinaryQCOM pglExtIsProgramBinaryQCOM;

			[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glExtGetProgramBinarySourceQCOM(UInt32 program, Int32 shadertype, String source, Int32* length);

			[RequiredByFeature("GL_QCOM_extended_get2", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glExtGetProgramBinarySourceQCOM pglExtGetProgramBinarySourceQCOM;

		}
	}

}
