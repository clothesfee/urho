// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// MessageBox.cs
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

namespace Urho.Gui
{
	/// <summary>
	/// Message box dialog. Manages its lifetime automatically, so the application does not need to hold a reference to it, and shouldn't attempt to destroy it manually.
	/// </summary>
	public unsafe partial class MessageBox : UrhoObject
	{
		public MessageBox (IntPtr handle) : base (handle)
		{
		}

		protected MessageBox (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int MessageBox_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (MessageBox_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr MessageBox_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (MessageBox_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int MessageBox_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(MessageBox));
			return new StringHash (MessageBox_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr MessageBox_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(MessageBox));
			return Marshal.PtrToStringAnsi (MessageBox_GetTypeNameStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr MessageBox_MessageBox (IntPtr context, string messageString, string titleString, IntPtr layoutFile, IntPtr styleFile);

		public MessageBox (Context context, string messageString, string titleString, Urho.Resources.XmlFile layoutFile, Urho.Resources.XmlFile styleFile) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(MessageBox));
			handle = MessageBox_MessageBox ((object)context == null ? IntPtr.Zero : context.Handle, messageString, titleString, (object)layoutFile == null ? IntPtr.Zero : layoutFile.Handle, (object)styleFile == null ? IntPtr.Zero : styleFile.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void MessageBox_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(MessageBox));
			MessageBox_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void MessageBox_SetTitle (IntPtr handle, string text);

		/// <summary>
		/// Set title text. No-ops if there is no title text element.
		/// </summary>
		private void SetTitle (string text)
		{
			Runtime.ValidateRefCounted (this);
			MessageBox_SetTitle (handle, text);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void MessageBox_SetMessage (IntPtr handle, string text);

		/// <summary>
		/// Set message text. No-ops if there is no message text element.
		/// </summary>
		private void SetMessage (string text)
		{
			Runtime.ValidateRefCounted (this);
			MessageBox_SetMessage (handle, text);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr MessageBox_GetTitle (IntPtr handle);

		/// <summary>
		/// Return title text. Return empty string if there is no title text element.
		/// </summary>
		private string GetTitle ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (MessageBox_GetTitle (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr MessageBox_GetMessage (IntPtr handle);

		/// <summary>
		/// Return message text. Return empty string if there is no message text element.
		/// </summary>
		private string GetMessage ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (MessageBox_GetMessage (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr MessageBox_GetWindow (IntPtr handle);

		/// <summary>
		/// Return dialog window.
		/// </summary>
		private UIElement GetWindow ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<UIElement> (MessageBox_GetWindow (handle));
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

		/// <summary>
		/// Return title text. Return empty string if there is no title text element.
		/// Or
		/// Set title text. No-ops if there is no title text element.
		/// </summary>
		public string Title {
			get {
				return GetTitle ();
			}
			set {
				SetTitle (value);
			}
		}

		/// <summary>
		/// Return message text. Return empty string if there is no message text element.
		/// Or
		/// Set message text. No-ops if there is no message text element.
		/// </summary>
		public string Message {
			get {
				return GetMessage ();
			}
			set {
				SetMessage (value);
			}
		}

		/// <summary>
		/// Return dialog window.
		/// </summary>
		public UIElement Window {
			get {
				return GetWindow ();
			}
		}
	}
}
