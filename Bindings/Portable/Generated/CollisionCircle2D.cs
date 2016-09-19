// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// CollisionCircle2D.cs
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

namespace Urho.Urho2D
{
	/// <summary>
	/// 2D circle collision component.
	/// </summary>
	public unsafe partial class CollisionCircle2D : CollisionShape2D
	{
		public CollisionCircle2D (IntPtr handle) : base (handle)
		{
		}

		protected CollisionCircle2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int CollisionCircle2D_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (CollisionCircle2D_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr CollisionCircle2D_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (CollisionCircle2D_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int CollisionCircle2D_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(CollisionCircle2D));
			return new StringHash (CollisionCircle2D_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr CollisionCircle2D_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(CollisionCircle2D));
			return Marshal.PtrToStringAnsi (CollisionCircle2D_GetTypeNameStatic ());
		}

		public CollisionCircle2D () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr CollisionCircle2D_CollisionCircle2D (IntPtr context);

		public CollisionCircle2D (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(CollisionCircle2D));
			handle = CollisionCircle2D_CollisionCircle2D ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionCircle2D_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(CollisionCircle2D));
			CollisionCircle2D_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionCircle2D_SetRadius (IntPtr handle, float radius);

		/// <summary>
		/// Set radius.
		/// </summary>
		private void SetRadius (float radius)
		{
			Runtime.ValidateRefCounted (this);
			CollisionCircle2D_SetRadius (handle, radius);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionCircle2D_SetCenter (IntPtr handle, ref Urho.Vector2 center);

		/// <summary>
		/// Set center.
		/// </summary>
		private void SetCenter (Urho.Vector2 center)
		{
			Runtime.ValidateRefCounted (this);
			CollisionCircle2D_SetCenter (handle, ref center);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionCircle2D_SetCenter0 (IntPtr handle, float x, float y);

		/// <summary>
		/// Set center.
		/// </summary>
		public void SetCenter (float x, float y)
		{
			Runtime.ValidateRefCounted (this);
			CollisionCircle2D_SetCenter0 (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float CollisionCircle2D_GetRadius (IntPtr handle);

		/// <summary>
		/// Return radius.
		/// </summary>
		private float GetRadius ()
		{
			Runtime.ValidateRefCounted (this);
			return CollisionCircle2D_GetRadius (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector2 CollisionCircle2D_GetCenter (IntPtr handle);

		/// <summary>
		/// Return center.
		/// </summary>
		private Urho.Vector2 GetCenter ()
		{
			Runtime.ValidateRefCounted (this);
			return CollisionCircle2D_GetCenter (handle);
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

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return radius.
		/// Or
		/// Set radius.
		/// </summary>
		public float Radius {
			get {
				return GetRadius ();
			}
			set {
				SetRadius (value);
			}
		}

		/// <summary>
		/// Return center.
		/// Or
		/// Set center.
		/// </summary>
		public Urho.Vector2 Center {
			get {
				return GetCenter ();
			}
			set {
				SetCenter (value);
			}
		}
	}
}
