// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Zone.cs
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
	/// %Component that describes global rendering properties.
	/// </summary>
	public unsafe partial class Zone : Drawable
	{
		public Zone (IntPtr handle) : base (handle)
		{
		}

		protected Zone (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Zone_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Zone_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Zone_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Zone_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Zone_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Zone));
			return new StringHash (Zone_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Zone_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Zone));
			return Marshal.PtrToStringAnsi (Zone_GetTypeNameStatic ());
		}

		public Zone () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Zone_Zone (IntPtr context);

		public Zone (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Zone));
			handle = Zone_Zone ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory. Drawable must be registered first.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Zone));
			Zone_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_DrawDebugGeometry (IntPtr handle, IntPtr debug, bool depthTest);

		/// <summary>
		/// Visualize the component as debug geometry.
		/// </summary>
		public override void DrawDebugGeometry (DebugRenderer debug, bool depthTest)
		{
			Runtime.ValidateRefCounted (this);
			Zone_DrawDebugGeometry (handle, (object)debug == null ? IntPtr.Zero : debug.Handle, depthTest);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetBoundingBox (IntPtr handle, ref Urho.BoundingBox box);

		/// <summary>
		/// Set local-space bounding box. Will be used as an oriented bounding box to test whether objects or the camera are inside.
		/// </summary>
		public void SetBoundingBox (Urho.BoundingBox box)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetBoundingBox (handle, ref box);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetAmbientColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set ambient color
		/// </summary>
		private void SetAmbientColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetAmbientColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetFogColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set fog color.
		/// </summary>
		private void SetFogColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetFogColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetFogStart (IntPtr handle, float start);

		/// <summary>
		/// Set fog start distance.
		/// </summary>
		private void SetFogStart (float start)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetFogStart (handle, start);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetFogEnd (IntPtr handle, float end);

		/// <summary>
		/// Set fog end distance.
		/// </summary>
		private void SetFogEnd (float end)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetFogEnd (handle, end);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetFogHeight (IntPtr handle, float height);

		/// <summary>
		/// Set fog height distance relative to the scene node's world position. Effective only in height fog mode.
		/// </summary>
		private void SetFogHeight (float height)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetFogHeight (handle, height);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetFogHeightScale (IntPtr handle, float scale);

		/// <summary>
		/// Set fog height scale. Effective only in height fog mode.
		/// </summary>
		private void SetFogHeightScale (float scale)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetFogHeightScale (handle, scale);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetPriority (IntPtr handle, int priority);

		/// <summary>
		/// Set zone priority. If an object or camera is inside several zones, the one with highest priority is used.
		/// </summary>
		private void SetPriority (int priority)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetPriority (handle, priority);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetHeightFog (IntPtr handle, bool enable);

		/// <summary>
		/// Set height fog mode.
		/// </summary>
		private void SetHeightFog (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetHeightFog (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetOverride (IntPtr handle, bool enable);

		/// <summary>
		/// Set override mode. If camera is inside an override zone, that zone will be used for all rendered objects instead of their own zone.
		/// </summary>
		private void SetOverride (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetOverride (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetAmbientGradient (IntPtr handle, bool enable);

		/// <summary>
		/// Set ambient gradient mode. In gradient mode ambient color is interpolated from neighbor zones.
		/// </summary>
		private void SetAmbientGradient (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetAmbientGradient (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Zone_SetZoneTexture (IntPtr handle, IntPtr texture);

		/// <summary>
		/// Set zone texture. This will be bound to the zone texture unit when rendering objects inside the zone. Note that the default shaders do not use it.
		/// </summary>
		private void SetZoneTexture (Texture texture)
		{
			Runtime.ValidateRefCounted (this);
			Zone_SetZoneTexture (handle, (object)texture == null ? IntPtr.Zero : texture.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Matrix3x4 Zone_GetInverseWorldTransform (IntPtr handle);

		/// <summary>
		/// Return inverse world transform.
		/// </summary>
		private Urho.Matrix3x4 GetInverseWorldTransform ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetInverseWorldTransform (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Zone_GetAmbientColor (IntPtr handle);

		/// <summary>
		/// Return zone's own ambient color, disregarding gradient mode.
		/// </summary>
		private Urho.Color GetAmbientColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetAmbientColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Zone_GetAmbientStartColor (IntPtr handle);

		/// <summary>
		/// Return ambient start color. Not safe to call from worker threads due to possible octree query.
		/// </summary>
		private Urho.Color GetAmbientStartColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetAmbientStartColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Zone_GetAmbientEndColor (IntPtr handle);

		/// <summary>
		/// Return ambient end color. Not safe to call from worker threads due to possible octree query.
		/// </summary>
		private Urho.Color GetAmbientEndColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetAmbientEndColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Zone_GetFogColor (IntPtr handle);

		/// <summary>
		/// Return fog color.
		/// </summary>
		private Urho.Color GetFogColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetFogColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Zone_GetFogStart (IntPtr handle);

		/// <summary>
		/// Return fog start distance.
		/// </summary>
		private float GetFogStart ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetFogStart (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Zone_GetFogEnd (IntPtr handle);

		/// <summary>
		/// Return fog end distance.
		/// </summary>
		private float GetFogEnd ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetFogEnd (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Zone_GetFogHeight (IntPtr handle);

		/// <summary>
		/// Return fog height distance relative to the scene node's world position.
		/// </summary>
		private float GetFogHeight ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetFogHeight (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Zone_GetFogHeightScale (IntPtr handle);

		/// <summary>
		/// Return fog height scale.
		/// </summary>
		private float GetFogHeightScale ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetFogHeightScale (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Zone_GetPriority (IntPtr handle);

		/// <summary>
		/// Return zone priority.
		/// </summary>
		private int GetPriority ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetPriority (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Zone_GetHeightFog (IntPtr handle);

		/// <summary>
		/// Return whether height fog mode is enabled.
		/// </summary>
		private bool GetHeightFog ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetHeightFog (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Zone_GetOverride (IntPtr handle);

		/// <summary>
		/// Return whether override mode is enabled.
		/// </summary>
		private bool GetOverride ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetOverride (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Zone_GetAmbientGradient (IntPtr handle);

		/// <summary>
		/// Return whether ambient gradient mode is enabled.
		/// </summary>
		private bool GetAmbientGradient ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetAmbientGradient (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Zone_GetZoneTexture (IntPtr handle);

		/// <summary>
		/// Return zone texture.
		/// </summary>
		private Texture GetZoneTexture ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Texture> (Zone_GetZoneTexture (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Zone_IsInside (IntPtr handle, ref Urho.Vector3 point);

		/// <summary>
		/// Check whether a point is inside.
		/// </summary>
		public bool IsInside (Urho.Vector3 point)
		{
			Runtime.ValidateRefCounted (this);
			return Zone_IsInside (handle, ref point);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ResourceRef Zone_GetZoneTextureAttr (IntPtr handle);

		/// <summary>
		/// Return zone texture attribute.
		/// </summary>
		private ResourceRef GetZoneTextureAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return Zone_GetZoneTextureAttr (handle);
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
		/// Return zone's own ambient color, disregarding gradient mode.
		/// Or
		/// Set ambient color
		/// </summary>
		public Urho.Color AmbientColor {
			get {
				return GetAmbientColor ();
			}
			set {
				SetAmbientColor (value);
			}
		}

		/// <summary>
		/// Return fog color.
		/// Or
		/// Set fog color.
		/// </summary>
		public Urho.Color FogColor {
			get {
				return GetFogColor ();
			}
			set {
				SetFogColor (value);
			}
		}

		/// <summary>
		/// Return fog start distance.
		/// Or
		/// Set fog start distance.
		/// </summary>
		public float FogStart {
			get {
				return GetFogStart ();
			}
			set {
				SetFogStart (value);
			}
		}

		/// <summary>
		/// Return fog end distance.
		/// Or
		/// Set fog end distance.
		/// </summary>
		public float FogEnd {
			get {
				return GetFogEnd ();
			}
			set {
				SetFogEnd (value);
			}
		}

		/// <summary>
		/// Return fog height distance relative to the scene node's world position.
		/// Or
		/// Set fog height distance relative to the scene node's world position. Effective only in height fog mode.
		/// </summary>
		public float FogHeight {
			get {
				return GetFogHeight ();
			}
			set {
				SetFogHeight (value);
			}
		}

		/// <summary>
		/// Return fog height scale.
		/// Or
		/// Set fog height scale. Effective only in height fog mode.
		/// </summary>
		public float FogHeightScale {
			get {
				return GetFogHeightScale ();
			}
			set {
				SetFogHeightScale (value);
			}
		}

		/// <summary>
		/// Return zone priority.
		/// Or
		/// Set zone priority. If an object or camera is inside several zones, the one with highest priority is used.
		/// </summary>
		public int Priority {
			get {
				return GetPriority ();
			}
			set {
				SetPriority (value);
			}
		}

		/// <summary>
		/// Return whether height fog mode is enabled.
		/// Or
		/// Set height fog mode.
		/// </summary>
		public bool HeightFog {
			get {
				return GetHeightFog ();
			}
			set {
				SetHeightFog (value);
			}
		}

		/// <summary>
		/// Return whether override mode is enabled.
		/// Or
		/// Set override mode. If camera is inside an override zone, that zone will be used for all rendered objects instead of their own zone.
		/// </summary>
		public bool Override {
			get {
				return GetOverride ();
			}
			set {
				SetOverride (value);
			}
		}

		/// <summary>
		/// Return whether ambient gradient mode is enabled.
		/// Or
		/// Set ambient gradient mode. In gradient mode ambient color is interpolated from neighbor zones.
		/// </summary>
		public bool AmbientGradient {
			get {
				return GetAmbientGradient ();
			}
			set {
				SetAmbientGradient (value);
			}
		}

		/// <summary>
		/// Return zone texture.
		/// Or
		/// Set zone texture. This will be bound to the zone texture unit when rendering objects inside the zone. Note that the default shaders do not use it.
		/// </summary>
		public Texture ZoneTexture {
			get {
				return GetZoneTexture ();
			}
			set {
				SetZoneTexture (value);
			}
		}

		/// <summary>
		/// Return inverse world transform.
		/// </summary>
		public Urho.Matrix3x4 InverseWorldTransform {
			get {
				return GetInverseWorldTransform ();
			}
		}

		/// <summary>
		/// Return ambient start color. Not safe to call from worker threads due to possible octree query.
		/// </summary>
		public Urho.Color AmbientStartColor {
			get {
				return GetAmbientStartColor ();
			}
		}

		/// <summary>
		/// Return ambient end color. Not safe to call from worker threads due to possible octree query.
		/// </summary>
		public Urho.Color AmbientEndColor {
			get {
				return GetAmbientEndColor ();
			}
		}

		/// <summary>
		/// Return zone texture attribute.
		/// </summary>
		public ResourceRef ZoneTextureAttr {
			get {
				return GetZoneTextureAttr ();
			}
		}
	}
}
