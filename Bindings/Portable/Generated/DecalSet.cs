// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// DecalSet.cs
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
	/// %Decal renderer component.
	/// </summary>
	public unsafe partial class DecalSet : Drawable
	{
		public DecalSet (IntPtr handle) : base (handle)
		{
		}

		protected DecalSet (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int DecalSet_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (DecalSet_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr DecalSet_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (DecalSet_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int DecalSet_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(DecalSet));
			return new StringHash (DecalSet_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr DecalSet_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(DecalSet));
			return Marshal.PtrToStringAnsi (DecalSet_GetTypeNameStatic ());
		}

		public DecalSet () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr DecalSet_DecalSet (IntPtr context);

		public DecalSet (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(DecalSet));
			handle = DecalSet_DecalSet ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void DecalSet_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(DecalSet));
			DecalSet_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void DecalSet_ApplyAttributes (IntPtr handle);

		/// <summary>
		/// Apply attribute changes that can not be applied immediately. Called after scene load or a network update.
		/// </summary>
		public override void ApplyAttributes ()
		{
			Runtime.ValidateRefCounted (this);
			DecalSet_ApplyAttributes (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void DecalSet_OnSetEnabled (IntPtr handle);

		/// <summary>
		/// Handle enabled/disabled state change.
		/// </summary>
		public override void OnSetEnabled ()
		{
			Runtime.ValidateRefCounted (this);
			DecalSet_OnSetEnabled (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern UpdateGeometryType DecalSet_GetUpdateGeometryType (IntPtr handle);

		/// <summary>
		/// Return whether a geometry update is necessary, and if it can happen in a worker thread.
		/// </summary>
		private UpdateGeometryType GetUpdateGeometryType ()
		{
			Runtime.ValidateRefCounted (this);
			return DecalSet_GetUpdateGeometryType (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void DecalSet_SetMaterial (IntPtr handle, IntPtr material);

		/// <summary>
		/// Set material. The material should use a small negative depth bias to avoid Z-fighting.
		/// </summary>
		private void SetMaterial (Material material)
		{
			Runtime.ValidateRefCounted (this);
			DecalSet_SetMaterial (handle, (object)material == null ? IntPtr.Zero : material.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void DecalSet_SetMaxVertices (IntPtr handle, uint num);

		/// <summary>
		/// Set maximum number of decal vertices.
		/// </summary>
		private void SetMaxVertices (uint num)
		{
			Runtime.ValidateRefCounted (this);
			DecalSet_SetMaxVertices (handle, num);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void DecalSet_SetMaxIndices (IntPtr handle, uint num);

		/// <summary>
		/// Set maximum number of decal vertex indices.
		/// </summary>
		private void SetMaxIndices (uint num)
		{
			Runtime.ValidateRefCounted (this);
			DecalSet_SetMaxIndices (handle, num);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool DecalSet_AddDecal (IntPtr handle, IntPtr target, ref Urho.Vector3 worldPosition, ref Urho.Quaternion worldRotation, float size, float aspectRatio, float depth, ref Urho.Vector2 topLeftUV, ref Urho.Vector2 bottomRightUV, float timeToLive, float normalCutoff, uint subGeometry);

		/// <summary>
		/// Add a decal at world coordinates, using a target drawable's geometry for reference. If the decal needs to move with the target, the decal component should be created to the target's node. Return true if successful.
		/// </summary>
		public bool AddDecal (Drawable target, Urho.Vector3 worldPosition, Urho.Quaternion worldRotation, float size, float aspectRatio, float depth, Urho.Vector2 topLeftUV, Urho.Vector2 bottomRightUV, float timeToLive, float normalCutoff, uint subGeometry)
		{
			Runtime.ValidateRefCounted (this);
			return DecalSet_AddDecal (handle, (object)target == null ? IntPtr.Zero : target.Handle, ref worldPosition, ref worldRotation, size, aspectRatio, depth, ref topLeftUV, ref bottomRightUV, timeToLive, normalCutoff, subGeometry);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void DecalSet_RemoveDecals (IntPtr handle, uint num);

		/// <summary>
		/// Remove n oldest decals.
		/// </summary>
		public void RemoveDecals (uint num)
		{
			Runtime.ValidateRefCounted (this);
			DecalSet_RemoveDecals (handle, num);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void DecalSet_RemoveAllDecals (IntPtr handle);

		/// <summary>
		/// Remove all decals.
		/// </summary>
		public void RemoveAllDecals ()
		{
			Runtime.ValidateRefCounted (this);
			DecalSet_RemoveAllDecals (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr DecalSet_GetMaterial (IntPtr handle);

		/// <summary>
		/// Return material.
		/// </summary>
		private Material GetMaterial ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Material> (DecalSet_GetMaterial (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint DecalSet_GetNumDecals (IntPtr handle);

		/// <summary>
		/// Return number of decals.
		/// </summary>
		private uint GetNumDecals ()
		{
			Runtime.ValidateRefCounted (this);
			return DecalSet_GetNumDecals (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint DecalSet_GetNumVertices (IntPtr handle);

		/// <summary>
		/// Retur number of vertices in the decals.
		/// </summary>
		private uint GetNumVertices ()
		{
			Runtime.ValidateRefCounted (this);
			return DecalSet_GetNumVertices (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint DecalSet_GetNumIndices (IntPtr handle);

		/// <summary>
		/// Retur number of vertex indices in the decals.
		/// </summary>
		private uint GetNumIndices ()
		{
			Runtime.ValidateRefCounted (this);
			return DecalSet_GetNumIndices (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint DecalSet_GetMaxVertices (IntPtr handle);

		/// <summary>
		/// Return maximum number of decal vertices.
		/// </summary>
		private uint GetMaxVertices ()
		{
			Runtime.ValidateRefCounted (this);
			return DecalSet_GetMaxVertices (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint DecalSet_GetMaxIndices (IntPtr handle);

		/// <summary>
		/// Return maximum number of decal vertex indices.
		/// </summary>
		private uint GetMaxIndices ()
		{
			Runtime.ValidateRefCounted (this);
			return DecalSet_GetMaxIndices (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ResourceRef DecalSet_GetMaterialAttr (IntPtr handle);

		/// <summary>
		/// Return material attribute.
		/// </summary>
		private ResourceRef GetMaterialAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return DecalSet_GetMaterialAttr (handle);
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
		/// Return whether a geometry update is necessary, and if it can happen in a worker thread.
		/// </summary>
		public override UpdateGeometryType UpdateGeometryType {
			get {
				return GetUpdateGeometryType ();
			}
		}

		/// <summary>
		/// Return material.
		/// Or
		/// Set material. The material should use a small negative depth bias to avoid Z-fighting.
		/// </summary>
		public Material Material {
			get {
				return GetMaterial ();
			}
			set {
				SetMaterial (value);
			}
		}

		/// <summary>
		/// Return maximum number of decal vertices.
		/// Or
		/// Set maximum number of decal vertices.
		/// </summary>
		public uint MaxVertices {
			get {
				return GetMaxVertices ();
			}
			set {
				SetMaxVertices (value);
			}
		}

		/// <summary>
		/// Return maximum number of decal vertex indices.
		/// Or
		/// Set maximum number of decal vertex indices.
		/// </summary>
		public uint MaxIndices {
			get {
				return GetMaxIndices ();
			}
			set {
				SetMaxIndices (value);
			}
		}

		/// <summary>
		/// Return number of decals.
		/// </summary>
		public uint NumDecals {
			get {
				return GetNumDecals ();
			}
		}

		/// <summary>
		/// Retur number of vertices in the decals.
		/// </summary>
		public uint NumVertices {
			get {
				return GetNumVertices ();
			}
		}

		/// <summary>
		/// Retur number of vertex indices in the decals.
		/// </summary>
		public uint NumIndices {
			get {
				return GetNumIndices ();
			}
		}

		/// <summary>
		/// Return material attribute.
		/// </summary>
		public ResourceRef MaterialAttr {
			get {
				return GetMaterialAttr ();
			}
		}
	}
}
