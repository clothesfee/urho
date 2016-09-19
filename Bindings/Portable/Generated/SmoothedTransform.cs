// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// SmoothedTransform.cs
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
	/// Transform smoothing component for network updates.
	/// </summary>
	public unsafe partial class SmoothedTransform : Component
	{
		public SmoothedTransform (IntPtr handle) : base (handle)
		{
		}

		protected SmoothedTransform (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int SmoothedTransform_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (SmoothedTransform_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SmoothedTransform_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (SmoothedTransform_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int SmoothedTransform_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(SmoothedTransform));
			return new StringHash (SmoothedTransform_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SmoothedTransform_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(SmoothedTransform));
			return Marshal.PtrToStringAnsi (SmoothedTransform_GetTypeNameStatic ());
		}

		public SmoothedTransform () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SmoothedTransform_SmoothedTransform (IntPtr context);

		public SmoothedTransform (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(SmoothedTransform));
			handle = SmoothedTransform_SmoothedTransform ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SmoothedTransform_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(SmoothedTransform));
			SmoothedTransform_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SmoothedTransform_Update (IntPtr handle, float constant, float squaredSnapThreshold);

		/// <summary>
		/// Update smoothing.
		/// </summary>
		public void Update (float constant, float squaredSnapThreshold)
		{
			Runtime.ValidateRefCounted (this);
			SmoothedTransform_Update (handle, constant, squaredSnapThreshold);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SmoothedTransform_SetTargetPosition (IntPtr handle, ref Urho.Vector3 position);

		/// <summary>
		/// Set target position in parent space.
		/// </summary>
		private void SetTargetPosition (Urho.Vector3 position)
		{
			Runtime.ValidateRefCounted (this);
			SmoothedTransform_SetTargetPosition (handle, ref position);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SmoothedTransform_SetTargetRotation (IntPtr handle, ref Urho.Quaternion rotation);

		/// <summary>
		/// Set target rotation in parent space.
		/// </summary>
		private void SetTargetRotation (Urho.Quaternion rotation)
		{
			Runtime.ValidateRefCounted (this);
			SmoothedTransform_SetTargetRotation (handle, ref rotation);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SmoothedTransform_SetTargetWorldPosition (IntPtr handle, ref Urho.Vector3 position);

		/// <summary>
		/// Set target position in world space.
		/// </summary>
		public void SetTargetWorldPosition (Urho.Vector3 position)
		{
			Runtime.ValidateRefCounted (this);
			SmoothedTransform_SetTargetWorldPosition (handle, ref position);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SmoothedTransform_SetTargetWorldRotation (IntPtr handle, ref Urho.Quaternion rotation);

		/// <summary>
		/// Set target rotation in world space.
		/// </summary>
		public void SetTargetWorldRotation (Urho.Quaternion rotation)
		{
			Runtime.ValidateRefCounted (this);
			SmoothedTransform_SetTargetWorldRotation (handle, ref rotation);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector3 SmoothedTransform_GetTargetPosition (IntPtr handle);

		/// <summary>
		/// Return target position in parent space.
		/// </summary>
		private Urho.Vector3 GetTargetPosition ()
		{
			Runtime.ValidateRefCounted (this);
			return SmoothedTransform_GetTargetPosition (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Quaternion SmoothedTransform_GetTargetRotation (IntPtr handle);

		/// <summary>
		/// Return target rotation in parent space.
		/// </summary>
		private Urho.Quaternion GetTargetRotation ()
		{
			Runtime.ValidateRefCounted (this);
			return SmoothedTransform_GetTargetRotation (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Vector3 SmoothedTransform_GetTargetWorldPosition (IntPtr handle);

		/// <summary>
		/// Return target position in world space.
		/// </summary>
		private Vector3 GetTargetWorldPosition ()
		{
			Runtime.ValidateRefCounted (this);
			return SmoothedTransform_GetTargetWorldPosition (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Quaternion SmoothedTransform_GetTargetWorldRotation (IntPtr handle);

		/// <summary>
		/// Return target rotation in world space.
		/// </summary>
		private Quaternion GetTargetWorldRotation ()
		{
			Runtime.ValidateRefCounted (this);
			return SmoothedTransform_GetTargetWorldRotation (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool SmoothedTransform_IsInProgress (IntPtr handle);

		/// <summary>
		/// Return whether smoothing is in progress.
		/// </summary>
		private bool IsInProgress ()
		{
			Runtime.ValidateRefCounted (this);
			return SmoothedTransform_IsInProgress (handle);
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
		/// Return target position in parent space.
		/// Or
		/// Set target position in parent space.
		/// </summary>
		public Urho.Vector3 TargetPosition {
			get {
				return GetTargetPosition ();
			}
			set {
				SetTargetPosition (value);
			}
		}

		/// <summary>
		/// Return target rotation in parent space.
		/// Or
		/// Set target rotation in parent space.
		/// </summary>
		public Urho.Quaternion TargetRotation {
			get {
				return GetTargetRotation ();
			}
			set {
				SetTargetRotation (value);
			}
		}

		/// <summary>
		/// Return target position in world space.
		/// </summary>
		public Vector3 TargetWorldPosition {
			get {
				return GetTargetWorldPosition ();
			}
		}

		/// <summary>
		/// Return target rotation in world space.
		/// </summary>
		public Quaternion TargetWorldRotation {
			get {
				return GetTargetWorldRotation ();
			}
		}

		/// <summary>
		/// Return whether smoothing is in progress.
		/// </summary>
		public bool InProgress {
			get {
				return IsInProgress ();
			}
		}
	}
}
