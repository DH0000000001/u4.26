// Copyright Epic Games, Inc. All Rights Reserved.

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class FDatasmithFacadeDirectLink : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FDatasmithFacadeDirectLink(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FDatasmithFacadeDirectLink obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FDatasmithFacadeDirectLink() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          DatasmithFacadeCSharpPINVOKE.delete_FDatasmithFacadeDirectLink(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static bool Init() {
    bool ret = DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeDirectLink_Init__SWIG_0();
    return ret;
  }

  public static bool Init(bool bUseDatasmithExporterUI, string RemoteEngineDirPath) {
    bool ret = DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeDirectLink_Init__SWIG_1(bUseDatasmithExporterUI, RemoteEngineDirPath);
    return ret;
  }

  public static int ValidateCommunicationSetup() {
    int ret = DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeDirectLink_ValidateCommunicationSetup();
    return ret;
  }

  public static bool Shutdown() {
    bool ret = DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeDirectLink_Shutdown();
    return ret;
  }

  public bool InitializeForScene(FDatasmithFacadeScene FacadeScene) {
    bool ret = DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeDirectLink_InitializeForScene(swigCPtr, FDatasmithFacadeScene.getCPtr(FacadeScene));
    return ret;
  }

  public bool UpdateScene(FDatasmithFacadeScene FacadeScene) {
    bool ret = DatasmithFacadeCSharpPINVOKE.FDatasmithFacadeDirectLink_UpdateScene(swigCPtr, FDatasmithFacadeScene.getCPtr(FacadeScene));
    return ret;
  }

  public FDatasmithFacadeDirectLink() : this(DatasmithFacadeCSharpPINVOKE.new_FDatasmithFacadeDirectLink(), true) {
  }

}