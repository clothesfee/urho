// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Scene.cs
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
	/// Root scene node, represents the whole scene.
	/// </summary>
	public unsafe partial class Scene : Node
	{
		public Scene (IntPtr handle) : base (handle)
		{
		}

		protected Scene (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Scene_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Scene_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Scene_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Scene_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Scene));
			return new StringHash (Scene_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Scene));
			return Marshal.PtrToStringAnsi (Scene_GetTypeNameStatic ());
		}

		public Scene () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_Scene (IntPtr context);

		public Scene (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Scene));
			handle = Scene_Scene ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory. Node must be registered first.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Scene));
			Scene_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_Load (IntPtr handle, IntPtr source, bool setInstanceDefault);

		/// <summary>
		/// Load from binary data. Removes all existing child nodes and components first. Return true if successful.
		/// </summary>
		public override bool Load (File source, bool setInstanceDefault)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_Load (handle, (object)source == null ? IntPtr.Zero : source.Handle, setInstanceDefault);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_Save (IntPtr handle, IntPtr dest);

		/// <summary>
		/// Save to binary data. Return true if successful.
		/// </summary>
		public override bool Save (File dest)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_Save (handle, (object)dest == null ? IntPtr.Zero : dest.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_LoadXML (IntPtr handle, ref Urho.Resources.XmlElement source, bool setInstanceDefault);

		/// <summary>
		/// Load from XML data. Removes all existing child nodes and components first. Return true if successful.
		/// </summary>
		public override bool LoadXml (Urho.Resources.XmlElement source, bool setInstanceDefault)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_LoadXML (handle, ref source, setInstanceDefault);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_MarkNetworkUpdate (IntPtr handle);

		/// <summary>
		/// Mark for attribute check on the next network update.
		/// </summary>
		public override void MarkNetworkUpdate ()
		{
			Runtime.ValidateRefCounted (this);
			Scene_MarkNetworkUpdate (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_AddReplicationState (IntPtr handle, NodeReplicationState* state);

		/// <summary>
		/// Add a replication state that is tracking this scene.
		/// </summary>
		public override void AddReplicationState (NodeReplicationState* state)
		{
			Runtime.ValidateRefCounted (this);
			Scene_AddReplicationState (handle, state);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_LoadXML0 (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load from an XML file. Return true if successful.
		/// </summary>
		public bool LoadXml (File source)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_LoadXML0 (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_LoadJSON (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load from a JSON file. Return true if successful.
		/// </summary>
		public bool LoadJson (File source)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_LoadJSON (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_SaveXML (IntPtr handle, IntPtr dest, string indentation);

		/// <summary>
		/// Save to an XML file. Return true if successful.
		/// </summary>
		public override bool SaveXml (File dest, string indentation)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_SaveXML (handle, (object)dest == null ? IntPtr.Zero : dest.Handle, indentation);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_SaveJSON (IntPtr handle, IntPtr dest, string indentation);

		/// <summary>
		/// Save to a JSON file. Return true if successful.
		/// </summary>
		public override bool SaveJson (File dest, string indentation)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_SaveJSON (handle, (object)dest == null ? IntPtr.Zero : dest.Handle, indentation);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_LoadAsync (IntPtr handle, IntPtr file, LoadMode mode);

		/// <summary>
		/// Load from a binary file asynchronously. Return true if started successfully. The LOAD_RESOURCES_ONLY mode can also be used to preload resources from object prefab files.
		/// </summary>
		public bool LoadAsync (File file, LoadMode mode)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_LoadAsync (handle, (object)file == null ? IntPtr.Zero : file.Handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_LoadAsyncXML (IntPtr handle, IntPtr file, LoadMode mode);

		/// <summary>
		/// Load from an XML file asynchronously. Return true if started successfully. The LOAD_RESOURCES_ONLY mode can also be used to preload resources from object prefab files.
		/// </summary>
		public bool LoadAsyncXml (File file, LoadMode mode)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_LoadAsyncXML (handle, (object)file == null ? IntPtr.Zero : file.Handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_LoadAsyncJSON (IntPtr handle, IntPtr file, LoadMode mode);

		/// <summary>
		/// Load from a JSON file asynchronously. Return true if started successfully. The LOAD_RESOURCES_ONLY mode can also be used to preload resources from object prefab files.
		/// </summary>
		public bool LoadAsyncJson (File file, LoadMode mode)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_LoadAsyncJSON (handle, (object)file == null ? IntPtr.Zero : file.Handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_StopAsyncLoading (IntPtr handle);

		/// <summary>
		/// Stop asynchronous loading.
		/// </summary>
		public void StopAsyncLoading ()
		{
			Runtime.ValidateRefCounted (this);
			Scene_StopAsyncLoading (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_Instantiate (IntPtr handle, IntPtr source, ref Urho.Vector3 position, ref Urho.Quaternion rotation, CreateMode mode);

		/// <summary>
		/// Instantiate scene content from binary data. Return root node if successful.
		/// </summary>
		public Node Instantiate (File source, Urho.Vector3 position, Urho.Quaternion rotation, CreateMode mode)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Node> (Scene_Instantiate (handle, (object)source == null ? IntPtr.Zero : source.Handle, ref position, ref rotation, mode));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_InstantiateXML (IntPtr handle, ref Urho.Resources.XmlElement source, ref Urho.Vector3 position, ref Urho.Quaternion rotation, CreateMode mode);

		/// <summary>
		/// Instantiate scene content from XML data. Return root node if successful.
		/// </summary>
		public Node InstantiateXml (Urho.Resources.XmlElement source, Urho.Vector3 position, Urho.Quaternion rotation, CreateMode mode)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Node> (Scene_InstantiateXML (handle, ref source, ref position, ref rotation, mode));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_InstantiateXML1 (IntPtr handle, IntPtr source, ref Urho.Vector3 position, ref Urho.Quaternion rotation, CreateMode mode);

		/// <summary>
		/// Instantiate scene content from XML data. Return root node if successful.
		/// </summary>
		public Node InstantiateXml (File source, Urho.Vector3 position, Urho.Quaternion rotation, CreateMode mode)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Node> (Scene_InstantiateXML1 (handle, (object)source == null ? IntPtr.Zero : source.Handle, ref position, ref rotation, mode));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_InstantiateJSON (IntPtr handle, IntPtr source, ref Urho.Vector3 position, ref Urho.Quaternion rotation, CreateMode mode);

		/// <summary>
		/// Instantiate scene content from JSON data. Return root node if successful.
		/// </summary>
		public Node InstantiateJson (File source, Urho.Vector3 position, Urho.Quaternion rotation, CreateMode mode)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Node> (Scene_InstantiateJSON (handle, (object)source == null ? IntPtr.Zero : source.Handle, ref position, ref rotation, mode));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_Clear (IntPtr handle, bool clearReplicated, bool clearLocal);

		/// <summary>
		/// Clear scene completely of either replicated, local or all nodes and components.
		/// </summary>
		public void Clear (bool clearReplicated, bool clearLocal)
		{
			Runtime.ValidateRefCounted (this);
			Scene_Clear (handle, clearReplicated, clearLocal);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_SetUpdateEnabled (IntPtr handle, bool enable);

		/// <summary>
		/// Enable or disable scene update.
		/// </summary>
		private void SetUpdateEnabled (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Scene_SetUpdateEnabled (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_SetTimeScale (IntPtr handle, float scale);

		/// <summary>
		/// Set update time scale. 1.0 = real time (default.)
		/// </summary>
		private void SetTimeScale (float scale)
		{
			Runtime.ValidateRefCounted (this);
			Scene_SetTimeScale (handle, scale);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_SetElapsedTime (IntPtr handle, float time);

		/// <summary>
		/// Set elapsed time in seconds. This can be used to prevent inaccuracy in the timer if the scene runs for a long time.
		/// </summary>
		private void SetElapsedTime (float time)
		{
			Runtime.ValidateRefCounted (this);
			Scene_SetElapsedTime (handle, time);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_SetSmoothingConstant (IntPtr handle, float constant);

		/// <summary>
		/// Set network client motion smoothing constant.
		/// </summary>
		private void SetSmoothingConstant (float constant)
		{
			Runtime.ValidateRefCounted (this);
			Scene_SetSmoothingConstant (handle, constant);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_SetSnapThreshold (IntPtr handle, float threshold);

		/// <summary>
		/// Set network client motion smoothing snap threshold.
		/// </summary>
		private void SetSnapThreshold (float threshold)
		{
			Runtime.ValidateRefCounted (this);
			Scene_SetSnapThreshold (handle, threshold);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_SetAsyncLoadingMs (IntPtr handle, int ms);

		/// <summary>
		/// Set maximum milliseconds per frame to spend on async scene loading.
		/// </summary>
		private void SetAsyncLoadingMs (int ms)
		{
			Runtime.ValidateRefCounted (this);
			Scene_SetAsyncLoadingMs (handle, ms);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_AddRequiredPackageFile (IntPtr handle, IntPtr package);

		/// <summary>
		/// Add a required package file for networking. To be called on the server.
		/// </summary>
		public void AddRequiredPackageFile (PackageFile package)
		{
			Runtime.ValidateRefCounted (this);
			Scene_AddRequiredPackageFile (handle, (object)package == null ? IntPtr.Zero : package.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_ClearRequiredPackageFiles (IntPtr handle);

		/// <summary>
		/// Clear required package files.
		/// </summary>
		public void ClearRequiredPackageFiles ()
		{
			Runtime.ValidateRefCounted (this);
			Scene_ClearRequiredPackageFiles (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_RegisterVar (IntPtr handle, string name);

		/// <summary>
		/// Register a node user variable hash reverse mapping (for editing.)
		/// </summary>
		public void RegisterVar (string name)
		{
			Runtime.ValidateRefCounted (this);
			Scene_RegisterVar (handle, name);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_UnregisterVar (IntPtr handle, string name);

		/// <summary>
		/// Unregister a node user variable hash reverse mapping.
		/// </summary>
		public void UnregisterVar (string name)
		{
			Runtime.ValidateRefCounted (this);
			Scene_UnregisterVar (handle, name);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_UnregisterAllVars (IntPtr handle);

		/// <summary>
		/// Clear all registered node user variable hash reverse mappings.
		/// </summary>
		public void UnregisterAllVars ()
		{
			Runtime.ValidateRefCounted (this);
			Scene_UnregisterAllVars (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_GetNode (IntPtr handle, uint id);

		/// <summary>
		/// Return node from the whole scene by ID, or null if not found.
		/// </summary>
		public Node GetNode (uint id)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Node> (Scene_GetNode (handle, id));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_GetComponent (IntPtr handle, uint id);

		/// <summary>
		/// Return component from the whole scene by ID, or null if not found.
		/// </summary>
		public Component GetComponent (uint id)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Component> (Scene_GetComponent (handle, id));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_IsUpdateEnabled (IntPtr handle);

		/// <summary>
		/// Return whether updates are enabled.
		/// </summary>
		private bool IsUpdateEnabled ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_IsUpdateEnabled (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_IsAsyncLoading (IntPtr handle);

		/// <summary>
		/// Return whether an asynchronous loading operation is in progress.
		/// </summary>
		private bool IsAsyncLoading ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_IsAsyncLoading (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Scene_GetAsyncProgress (IntPtr handle);

		/// <summary>
		/// Return asynchronous loading progress between 0.0 and 1.0, or 1.0 if not in progress.
		/// </summary>
		private float GetAsyncProgress ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetAsyncProgress (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern LoadMode Scene_GetAsyncLoadMode (IntPtr handle);

		/// <summary>
		/// Return the load mode of the current asynchronous loading operation.
		/// </summary>
		private LoadMode GetAsyncLoadMode ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetAsyncLoadMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_GetFileName (IntPtr handle);

		/// <summary>
		/// Return source file name.
		/// </summary>
		private string GetFileName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Scene_GetFileName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Scene_GetChecksum (IntPtr handle);

		/// <summary>
		/// Return source file checksum.
		/// </summary>
		private uint GetChecksum ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetChecksum (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Scene_GetTimeScale (IntPtr handle);

		/// <summary>
		/// Return update time scale.
		/// </summary>
		private float GetTimeScale ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetTimeScale (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Scene_GetElapsedTime (IntPtr handle);

		/// <summary>
		/// Return elapsed time in seconds.
		/// </summary>
		private float GetElapsedTime ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetElapsedTime (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Scene_GetSmoothingConstant (IntPtr handle);

		/// <summary>
		/// Return motion smoothing constant.
		/// </summary>
		private float GetSmoothingConstant ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetSmoothingConstant (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Scene_GetSnapThreshold (IntPtr handle);

		/// <summary>
		/// Return motion smoothing snap threshold.
		/// </summary>
		private float GetSnapThreshold ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetSnapThreshold (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Scene_GetAsyncLoadingMs (IntPtr handle);

		/// <summary>
		/// Return maximum milliseconds per frame to spend on async loading.
		/// </summary>
		private int GetAsyncLoadingMs ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetAsyncLoadingMs (handle);
		}

		private IReadOnlyList<PackageFile> _GetRequiredPackageFiles_cache;

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_GetRequiredPackageFiles (IntPtr handle);

		/// <summary>
		/// Return required package files.
		/// </summary>
		private IReadOnlyList<PackageFile> GetRequiredPackageFiles ()
		{
			Runtime.ValidateRefCounted (this);
			return _GetRequiredPackageFiles_cache != null ? _GetRequiredPackageFiles_cache : _GetRequiredPackageFiles_cache = Runtime.CreateVectorSharedPtrProxy<PackageFile> (Scene_GetRequiredPackageFiles (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_GetVarName (IntPtr handle, int hash);

		/// <summary>
		/// Return a node user variable name, or empty if not registered.
		/// </summary>
		public string GetVarName (StringHash hash)
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Scene_GetVarName (handle, hash.Code));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_Update (IntPtr handle, float timeStep);

		/// <summary>
		/// Update scene. Called by HandleUpdate.
		/// </summary>
		public void Update (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			Scene_Update (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_BeginThreadedUpdate (IntPtr handle);

		/// <summary>
		/// Begin a threaded update. During threaded update components can choose to delay dirty processing.
		/// </summary>
		public void BeginThreadedUpdate ()
		{
			Runtime.ValidateRefCounted (this);
			Scene_BeginThreadedUpdate (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_EndThreadedUpdate (IntPtr handle);

		/// <summary>
		/// End a threaded update. Notify components that marked themselves for delayed dirty processing.
		/// </summary>
		public void EndThreadedUpdate ()
		{
			Runtime.ValidateRefCounted (this);
			Scene_EndThreadedUpdate (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_DelayedMarkedDirty (IntPtr handle, IntPtr component);

		/// <summary>
		/// Add a component to the delayed dirty notify queue. Is thread-safe.
		/// </summary>
		public void DelayedMarkedDirty (Component component)
		{
			Runtime.ValidateRefCounted (this);
			Scene_DelayedMarkedDirty (handle, (object)component == null ? IntPtr.Zero : component.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Scene_IsThreadedUpdate (IntPtr handle);

		/// <summary>
		/// Return threaded update flag.
		/// </summary>
		private bool IsThreadedUpdate ()
		{
			Runtime.ValidateRefCounted (this);
			return Scene_IsThreadedUpdate (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Scene_GetFreeNodeID (IntPtr handle, CreateMode mode);

		/// <summary>
		/// Get free node ID, either non-local or local.
		/// </summary>
		public uint GetFreeNodeID (CreateMode mode)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetFreeNodeID (handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Scene_GetFreeComponentID (IntPtr handle, CreateMode mode);

		/// <summary>
		/// Get free component ID, either non-local or local.
		/// </summary>
		public uint GetFreeComponentID (CreateMode mode)
		{
			Runtime.ValidateRefCounted (this);
			return Scene_GetFreeComponentID (handle, mode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_NodeTagAdded (IntPtr handle, IntPtr node, string tag);

		/// <summary>
		/// Cache node by tag if tag not zero, no checking if already added. Used internaly in Node::AddTag.
		/// </summary>
		public void NodeTagAdded (Node node, string tag)
		{
			Runtime.ValidateRefCounted (this);
			Scene_NodeTagAdded (handle, (object)node == null ? IntPtr.Zero : node.Handle, tag);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_NodeTagRemoved (IntPtr handle, IntPtr node, string tag);

		/// <summary>
		/// Cache node by tag if tag not zero.
		/// </summary>
		public void NodeTagRemoved (Node node, string tag)
		{
			Runtime.ValidateRefCounted (this);
			Scene_NodeTagRemoved (handle, (object)node == null ? IntPtr.Zero : node.Handle, tag);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_SetVarNamesAttr (IntPtr handle, string value);

		/// <summary>
		/// Set node user variable reverse mappings.
		/// </summary>
		public void SetVarNamesAttr (string value)
		{
			Runtime.ValidateRefCounted (this);
			Scene_SetVarNamesAttr (handle, value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Scene_GetVarNamesAttr (IntPtr handle);

		/// <summary>
		/// Return node user variable reverse mappings.
		/// </summary>
		private string GetVarNamesAttr ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Scene_GetVarNamesAttr (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_PrepareNetworkUpdate (IntPtr handle);

		/// <summary>
		/// Prepare network update by comparing attributes and marking replication states dirty as necessary.
		/// </summary>
		public override void PrepareNetworkUpdate ()
		{
			Runtime.ValidateRefCounted (this);
			Scene_PrepareNetworkUpdate (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_CleanupConnection (IntPtr handle, IntPtr connection);

		/// <summary>
		/// Clean up all references to a network connection that is about to be removed.
		/// </summary>
		public override void CleanupConnection (Connection connection)
		{
			Runtime.ValidateRefCounted (this);
			Scene_CleanupConnection (handle, (object)connection == null ? IntPtr.Zero : connection.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_MarkNetworkUpdate2 (IntPtr handle, IntPtr node);

		/// <summary>
		/// Mark a node for attribute check on the next network update.
		/// </summary>
		public void MarkNetworkUpdate (Node node)
		{
			Runtime.ValidateRefCounted (this);
			Scene_MarkNetworkUpdate2 (handle, (object)node == null ? IntPtr.Zero : node.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_MarkNetworkUpdate3 (IntPtr handle, IntPtr component);

		/// <summary>
		/// Mark a component for attribute check on the next network update.
		/// </summary>
		public void MarkNetworkUpdate (Component component)
		{
			Runtime.ValidateRefCounted (this);
			Scene_MarkNetworkUpdate3 (handle, (object)component == null ? IntPtr.Zero : component.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Scene_MarkReplicationDirty (IntPtr handle, IntPtr node);

		/// <summary>
		/// Mark a node dirty in scene replication states. The node does not need to have own replication state yet.
		/// </summary>
		public void MarkReplicationDirty (Node node)
		{
			Runtime.ValidateRefCounted (this);
			Scene_MarkReplicationDirty (handle, (object)node == null ? IntPtr.Zero : node.Handle);
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
		/// Return whether updates are enabled.
		/// Or
		/// Enable or disable scene update.
		/// </summary>
		public bool UpdateEnabled {
			get {
				return IsUpdateEnabled ();
			}
			set {
				SetUpdateEnabled (value);
			}
		}

		/// <summary>
		/// Return update time scale.
		/// Or
		/// Set update time scale. 1.0 = real time (default.)
		/// </summary>
		public float TimeScale {
			get {
				return GetTimeScale ();
			}
			set {
				SetTimeScale (value);
			}
		}

		/// <summary>
		/// Return elapsed time in seconds.
		/// Or
		/// Set elapsed time in seconds. This can be used to prevent inaccuracy in the timer if the scene runs for a long time.
		/// </summary>
		public float ElapsedTime {
			get {
				return GetElapsedTime ();
			}
			set {
				SetElapsedTime (value);
			}
		}

		/// <summary>
		/// Return motion smoothing constant.
		/// Or
		/// Set network client motion smoothing constant.
		/// </summary>
		public float SmoothingConstant {
			get {
				return GetSmoothingConstant ();
			}
			set {
				SetSmoothingConstant (value);
			}
		}

		/// <summary>
		/// Return motion smoothing snap threshold.
		/// Or
		/// Set network client motion smoothing snap threshold.
		/// </summary>
		public float SnapThreshold {
			get {
				return GetSnapThreshold ();
			}
			set {
				SetSnapThreshold (value);
			}
		}

		/// <summary>
		/// Return maximum milliseconds per frame to spend on async loading.
		/// Or
		/// Set maximum milliseconds per frame to spend on async scene loading.
		/// </summary>
		public int AsyncLoadingMs {
			get {
				return GetAsyncLoadingMs ();
			}
			set {
				SetAsyncLoadingMs (value);
			}
		}

		/// <summary>
		/// Return whether an asynchronous loading operation is in progress.
		/// </summary>
		public bool AsyncLoading {
			get {
				return IsAsyncLoading ();
			}
		}

		/// <summary>
		/// Return asynchronous loading progress between 0.0 and 1.0, or 1.0 if not in progress.
		/// </summary>
		public float AsyncProgress {
			get {
				return GetAsyncProgress ();
			}
		}

		/// <summary>
		/// Return the load mode of the current asynchronous loading operation.
		/// </summary>
		public LoadMode AsyncLoadMode {
			get {
				return GetAsyncLoadMode ();
			}
		}

		/// <summary>
		/// Return source file name.
		/// </summary>
		public string FileName {
			get {
				return GetFileName ();
			}
		}

		/// <summary>
		/// Return source file checksum.
		/// </summary>
		public uint Checksum {
			get {
				return GetChecksum ();
			}
		}

		/// <summary>
		/// Return required package files.
		/// </summary>
		public IReadOnlyList<PackageFile> RequiredPackageFiles {
			get {
				return GetRequiredPackageFiles ();
			}
		}

		/// <summary>
		/// Return threaded update flag.
		/// </summary>
		public bool ThreadedUpdate {
			get {
				return IsThreadedUpdate ();
			}
		}

		/// <summary>
		/// Return node user variable reverse mappings.
		/// </summary>
		public string VarNamesAttr {
			get {
				return GetVarNamesAttr ();
			}
		}
	}
}
