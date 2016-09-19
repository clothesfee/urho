// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// SplinePath.cs
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
	/// Spline for creating smooth movement based on Speed along a set of Control Points modified by the Interpolation Mode.
	/// </summary>
	public unsafe partial class SplinePath : Component
	{
		public SplinePath (IntPtr handle) : base (handle)
		{
		}

		protected SplinePath (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int SplinePath_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (SplinePath_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SplinePath_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (SplinePath_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int SplinePath_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(SplinePath));
			return new StringHash (SplinePath_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SplinePath_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(SplinePath));
			return Marshal.PtrToStringAnsi (SplinePath_GetTypeNameStatic ());
		}

		public SplinePath () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SplinePath_SplinePath (IntPtr context);

		public SplinePath (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(SplinePath));
			handle = SplinePath_SplinePath ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(SplinePath));
			SplinePath_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_ApplyAttributes (IntPtr handle);

		/// <summary>
		/// Apply Attributes to the SplinePath.
		/// </summary>
		public override void ApplyAttributes ()
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_ApplyAttributes (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_DrawDebugGeometry (IntPtr handle, IntPtr debug, bool depthTest);

		/// <summary>
		/// Draw the Debug Geometry.
		/// </summary>
		public override void DrawDebugGeometry (DebugRenderer debug, bool depthTest)
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_DrawDebugGeometry (handle, (object)debug == null ? IntPtr.Zero : debug.Handle, depthTest);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_AddControlPoint (IntPtr handle, IntPtr point, uint index);

		/// <summary>
		/// Add a Node to the SplinePath as a Control Point.
		/// </summary>
		public void AddControlPoint (Node point, uint index)
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_AddControlPoint (handle, (object)point == null ? IntPtr.Zero : point.Handle, index);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_RemoveControlPoint (IntPtr handle, IntPtr point);

		/// <summary>
		/// Remove a Node Control Point from the SplinePath.
		/// </summary>
		public void RemoveControlPoint (Node point)
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_RemoveControlPoint (handle, (object)point == null ? IntPtr.Zero : point.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_ClearControlPoints (IntPtr handle);

		/// <summary>
		/// Clear the Control Points from the SplinePath.
		/// </summary>
		public void ClearControlPoints ()
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_ClearControlPoints (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_SetInterpolationMode (IntPtr handle, InterpolationMode interpolationMode);

		/// <summary>
		/// Set the Interpolation Mode.
		/// </summary>
		private void SetInterpolationMode (InterpolationMode interpolationMode)
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_SetInterpolationMode (handle, interpolationMode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_SetSpeed (IntPtr handle, float speed);

		/// <summary>
		/// Set the movement Speed.
		/// </summary>
		private void SetSpeed (float speed)
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_SetSpeed (handle, speed);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_SetPosition (IntPtr handle, float factor);

		/// <summary>
		/// Set the controlled Node's position on the SplinePath.
		/// </summary>
		public void SetPosition (float factor)
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_SetPosition (handle, factor);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_SetControlledNode (IntPtr handle, IntPtr controlled);

		/// <summary>
		/// Set the Node to be moved along the SplinePath.
		/// </summary>
		private void SetControlledNode (Node controlled)
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_SetControlledNode (handle, (object)controlled == null ? IntPtr.Zero : controlled.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern InterpolationMode SplinePath_GetInterpolationMode (IntPtr handle);

		/// <summary>
		/// Get the Interpolation Mode.
		/// </summary>
		private InterpolationMode GetInterpolationMode ()
		{
			Runtime.ValidateRefCounted (this);
			return SplinePath_GetInterpolationMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float SplinePath_GetSpeed (IntPtr handle);

		/// <summary>
		/// Get the movement Speed.
		/// </summary>
		private float GetSpeed ()
		{
			Runtime.ValidateRefCounted (this);
			return SplinePath_GetSpeed (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float SplinePath_GetLength (IntPtr handle);

		/// <summary>
		/// Get the length of SplinePath;
		/// </summary>
		private float GetLength ()
		{
			Runtime.ValidateRefCounted (this);
			return SplinePath_GetLength (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Vector3 SplinePath_GetPosition (IntPtr handle);

		/// <summary>
		/// Get the parent Node's last position on the spline.
		/// </summary>
		private Vector3 GetPosition ()
		{
			Runtime.ValidateRefCounted (this);
			return SplinePath_GetPosition (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SplinePath_GetControlledNode (IntPtr handle);

		/// <summary>
		/// Get the controlled Node.
		/// </summary>
		private Node GetControlledNode ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Node> (SplinePath_GetControlledNode (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Vector3 SplinePath_GetPoint (IntPtr handle, float factor);

		/// <summary>
		/// Get a point on the SplinePath from 0.f to 1.f where 0 is the start and 1 is the end.
		/// </summary>
		public Vector3 GetPoint (float factor)
		{
			Runtime.ValidateRefCounted (this);
			return SplinePath_GetPoint (handle, factor);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_Move (IntPtr handle, float timeStep);

		/// <summary>
		/// Move the controlled Node to the next position along the SplinePath based off the Speed value.
		/// </summary>
		public void Move (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_Move (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_Reset (IntPtr handle);

		/// <summary>
		/// Reset movement along the path.
		/// </summary>
		public void Reset ()
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_Reset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool SplinePath_IsFinished (IntPtr handle);

		/// <summary>
		/// Returns whether the movement along the SplinePath is complete.
		/// </summary>
		private bool IsFinished ()
		{
			Runtime.ValidateRefCounted (this);
			return SplinePath_IsFinished (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SplinePath_SetControlledIdAttr (IntPtr handle, uint value);

		/// <summary>
		/// Set Controlled Node ID attribute.
		/// </summary>
		private void SetControlledIdAttr (uint value)
		{
			Runtime.ValidateRefCounted (this);
			SplinePath_SetControlledIdAttr (handle, value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint SplinePath_GetControlledIdAttr (IntPtr handle);

		/// <summary>
		/// Get Controlled Node ID attribute.
		/// </summary>
		private uint GetControlledIdAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return SplinePath_GetControlledIdAttr (handle);
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
		/// Get the Interpolation Mode.
		/// Or
		/// Set the Interpolation Mode.
		/// </summary>
		public InterpolationMode InterpolationMode {
			get {
				return GetInterpolationMode ();
			}
			set {
				SetInterpolationMode (value);
			}
		}

		/// <summary>
		/// Get the movement Speed.
		/// Or
		/// Set the movement Speed.
		/// </summary>
		public float Speed {
			get {
				return GetSpeed ();
			}
			set {
				SetSpeed (value);
			}
		}

		/// <summary>
		/// Get the parent Node's last position on the spline.
		/// </summary>
		public Vector3 Position {
			get {
				return GetPosition ();
			}
		}

		/// <summary>
		/// Get the controlled Node.
		/// Or
		/// Set the Node to be moved along the SplinePath.
		/// </summary>
		public Node ControlledNode {
			get {
				return GetControlledNode ();
			}
			set {
				SetControlledNode (value);
			}
		}

		/// <summary>
		/// Get the length of SplinePath;
		/// </summary>
		public float Length {
			get {
				return GetLength ();
			}
		}

		/// <summary>
		/// Returns whether the movement along the SplinePath is complete.
		/// </summary>
		public bool Finished {
			get {
				return IsFinished ();
			}
		}

		/// <summary>
		/// Get Controlled Node ID attribute.
		/// Or
		/// Set Controlled Node ID attribute.
		/// </summary>
		public uint ControlledIdAttr {
			get {
				return GetControlledIdAttr ();
			}
			set {
				SetControlledIdAttr (value);
			}
		}
	}
}
