// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// StaticSprite2D.cs
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
	/// Static sprite component.
	/// </summary>
	public unsafe partial class StaticSprite2D : Drawable2D
	{
		public StaticSprite2D (IntPtr handle) : base (handle)
		{
		}

		protected StaticSprite2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int StaticSprite2D_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (StaticSprite2D_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr StaticSprite2D_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (StaticSprite2D_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int StaticSprite2D_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(StaticSprite2D));
			return new StringHash (StaticSprite2D_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr StaticSprite2D_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(StaticSprite2D));
			return Marshal.PtrToStringAnsi (StaticSprite2D_GetTypeNameStatic ());
		}

		public StaticSprite2D () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr StaticSprite2D_StaticSprite2D (IntPtr context);

		public StaticSprite2D (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(StaticSprite2D));
			handle = StaticSprite2D_StaticSprite2D ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory. Drawable2D must be registered first.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(StaticSprite2D));
			StaticSprite2D_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetSprite (IntPtr handle, IntPtr sprite);

		/// <summary>
		/// Set sprite.
		/// </summary>
		private void SetSprite (Sprite2D sprite)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetSprite (handle, (object)sprite == null ? IntPtr.Zero : sprite.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetBlendMode (IntPtr handle, BlendMode blendMode);

		/// <summary>
		/// Set blend mode.
		/// </summary>
		private void SetBlendMode (BlendMode blendMode)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetBlendMode (handle, blendMode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetFlip (IntPtr handle, bool flipX, bool flipY);

		/// <summary>
		/// Set flip.
		/// </summary>
		public void SetFlip (bool flipX, bool flipY)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetFlip (handle, flipX, flipY);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetFlipX (IntPtr handle, bool flipX);

		/// <summary>
		/// Set flip X.
		/// </summary>
		private void SetFlipX (bool flipX)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetFlipX (handle, flipX);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetFlipY (IntPtr handle, bool flipY);

		/// <summary>
		/// Set flip Y.
		/// </summary>
		private void SetFlipY (bool flipY)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetFlipY (handle, flipY);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set color.
		/// </summary>
		private void SetColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetAlpha (IntPtr handle, float alpha);

		/// <summary>
		/// Set alpha.
		/// </summary>
		private void SetAlpha (float alpha)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetAlpha (handle, alpha);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetUseHotSpot (IntPtr handle, bool useHotSpot);

		/// <summary>
		/// Set use hot spot.
		/// </summary>
		private void SetUseHotSpot (bool useHotSpot)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetUseHotSpot (handle, useHotSpot);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetHotSpot (IntPtr handle, ref Urho.Vector2 hotspot);

		/// <summary>
		/// Set hot spot.
		/// </summary>
		private void SetHotSpot (Urho.Vector2 hotspot)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetHotSpot (handle, ref hotspot);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void StaticSprite2D_SetCustomMaterial (IntPtr handle, IntPtr customMaterial);

		/// <summary>
		/// Set custom material.
		/// </summary>
		private void SetCustomMaterial (Material customMaterial)
		{
			Runtime.ValidateRefCounted (this);
			StaticSprite2D_SetCustomMaterial (handle, (object)customMaterial == null ? IntPtr.Zero : customMaterial.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr StaticSprite2D_GetSprite (IntPtr handle);

		/// <summary>
		/// Return sprite.
		/// </summary>
		private Sprite2D GetSprite ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Sprite2D> (StaticSprite2D_GetSprite (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern BlendMode StaticSprite2D_GetBlendMode (IntPtr handle);

		/// <summary>
		/// Return blend mode.
		/// </summary>
		private BlendMode GetBlendMode ()
		{
			Runtime.ValidateRefCounted (this);
			return StaticSprite2D_GetBlendMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool StaticSprite2D_GetFlipX (IntPtr handle);

		/// <summary>
		/// Return flip X.
		/// </summary>
		private bool GetFlipX ()
		{
			Runtime.ValidateRefCounted (this);
			return StaticSprite2D_GetFlipX (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool StaticSprite2D_GetFlipY (IntPtr handle);

		/// <summary>
		/// Return flip Y.
		/// </summary>
		private bool GetFlipY ()
		{
			Runtime.ValidateRefCounted (this);
			return StaticSprite2D_GetFlipY (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color StaticSprite2D_GetColor (IntPtr handle);

		/// <summary>
		/// Return color.
		/// </summary>
		private Urho.Color GetColor ()
		{
			Runtime.ValidateRefCounted (this);
			return StaticSprite2D_GetColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float StaticSprite2D_GetAlpha (IntPtr handle);

		/// <summary>
		/// Return alpha.
		/// </summary>
		private float GetAlpha ()
		{
			Runtime.ValidateRefCounted (this);
			return StaticSprite2D_GetAlpha (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool StaticSprite2D_GetUseHotSpot (IntPtr handle);

		/// <summary>
		/// Return use hot spot.
		/// </summary>
		private bool GetUseHotSpot ()
		{
			Runtime.ValidateRefCounted (this);
			return StaticSprite2D_GetUseHotSpot (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector2 StaticSprite2D_GetHotSpot (IntPtr handle);

		/// <summary>
		/// Return hot spot.
		/// </summary>
		private Urho.Vector2 GetHotSpot ()
		{
			Runtime.ValidateRefCounted (this);
			return StaticSprite2D_GetHotSpot (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr StaticSprite2D_GetCustomMaterial (IntPtr handle);

		/// <summary>
		/// Return custom material.
		/// </summary>
		private Material GetCustomMaterial ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Material> (StaticSprite2D_GetCustomMaterial (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ResourceRef StaticSprite2D_GetSpriteAttr (IntPtr handle);

		/// <summary>
		/// Return sprite attribute.
		/// </summary>
		private ResourceRef GetSpriteAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return StaticSprite2D_GetSpriteAttr (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ResourceRef StaticSprite2D_GetCustomMaterialAttr (IntPtr handle);

		/// <summary>
		/// Return custom material attribute.
		/// </summary>
		private ResourceRef GetCustomMaterialAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return StaticSprite2D_GetCustomMaterialAttr (handle);
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
		/// Return sprite.
		/// Or
		/// Set sprite.
		/// </summary>
		public Sprite2D Sprite {
			get {
				return GetSprite ();
			}
			set {
				SetSprite (value);
			}
		}

		/// <summary>
		/// Return blend mode.
		/// Or
		/// Set blend mode.
		/// </summary>
		public BlendMode BlendMode {
			get {
				return GetBlendMode ();
			}
			set {
				SetBlendMode (value);
			}
		}

		/// <summary>
		/// Return flip X.
		/// Or
		/// Set flip X.
		/// </summary>
		public bool FlipX {
			get {
				return GetFlipX ();
			}
			set {
				SetFlipX (value);
			}
		}

		/// <summary>
		/// Return flip Y.
		/// Or
		/// Set flip Y.
		/// </summary>
		public bool FlipY {
			get {
				return GetFlipY ();
			}
			set {
				SetFlipY (value);
			}
		}

		/// <summary>
		/// Return color.
		/// Or
		/// Set color.
		/// </summary>
		public Urho.Color Color {
			get {
				return GetColor ();
			}
			set {
				SetColor (value);
			}
		}

		/// <summary>
		/// Return alpha.
		/// Or
		/// Set alpha.
		/// </summary>
		public float Alpha {
			get {
				return GetAlpha ();
			}
			set {
				SetAlpha (value);
			}
		}

		/// <summary>
		/// Return use hot spot.
		/// Or
		/// Set use hot spot.
		/// </summary>
		public bool UseHotSpot {
			get {
				return GetUseHotSpot ();
			}
			set {
				SetUseHotSpot (value);
			}
		}

		/// <summary>
		/// Return hot spot.
		/// Or
		/// Set hot spot.
		/// </summary>
		public Urho.Vector2 HotSpot {
			get {
				return GetHotSpot ();
			}
			set {
				SetHotSpot (value);
			}
		}

		/// <summary>
		/// Return custom material.
		/// Or
		/// Set custom material.
		/// </summary>
		public Material CustomMaterial {
			get {
				return GetCustomMaterial ();
			}
			set {
				SetCustomMaterial (value);
			}
		}

		/// <summary>
		/// Return sprite attribute.
		/// </summary>
		public ResourceRef SpriteAttr {
			get {
				return GetSpriteAttr ();
			}
		}

		/// <summary>
		/// Return custom material attribute.
		/// </summary>
		public ResourceRef CustomMaterialAttr {
			get {
				return GetCustomMaterialAttr ();
			}
		}
	}
}
