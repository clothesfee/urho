// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// ShaderPrecache.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho
{
	/// <summary>
	/// Utility class for collecting used shader combinations during runtime for precaching.
	/// </summary>
	public unsafe partial class ShaderPrecache : UrhoObject
	{
		public ShaderPrecache (IntPtr handle) : base (handle)
		{
		}

		protected ShaderPrecache (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ShaderPrecache_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (ShaderPrecache_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ShaderPrecache_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ShaderPrecache_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ShaderPrecache_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(ShaderPrecache));
			return new StringHash (ShaderPrecache_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ShaderPrecache_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(ShaderPrecache));
			return Marshal.PtrToStringAnsi (ShaderPrecache_GetTypeNameStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ShaderPrecache_ShaderPrecache (IntPtr context, string fileName);

		public ShaderPrecache (Context context, string fileName) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(ShaderPrecache));
			handle = ShaderPrecache_ShaderPrecache ((object)context == null ? IntPtr.Zero : context.Handle, fileName);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ShaderPrecache_StoreShaders (IntPtr handle, IntPtr vs, IntPtr ps);

		/// <summary>
		/// Collect a shader combination. Called by Graphics when shaders have been set.
		/// </summary>
		public void StoreShaders (ShaderVariation vs, ShaderVariation ps)
		{
			Runtime.ValidateRefCounted (this);
			ShaderPrecache_StoreShaders (handle, (object)vs == null ? IntPtr.Zero : vs.Handle, (object)ps == null ? IntPtr.Zero : ps.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ShaderPrecache_LoadShaders (IntPtr graphics, IntPtr source);

		/// <summary>
		/// Load shaders from an XML file.
		/// </summary>
		public static void LoadShaders (Graphics graphics, File source)
		{
			Runtime.Validate (typeof(ShaderPrecache));
			ShaderPrecache_LoadShaders ((object)graphics == null ? IntPtr.Zero : graphics.Handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}
	}
}
