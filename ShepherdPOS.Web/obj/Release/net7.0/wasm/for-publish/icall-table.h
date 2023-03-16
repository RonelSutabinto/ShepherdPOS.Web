#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
184,
192,
193,
194,
195,
196,
197,
198,
199,
200,
203,
204,
366,
367,
369,
397,
398,
399,
419,
420,
421,
422,
507,
508,
509,
512,
545,
546,
548,
550,
552,
554,
559,
567,
568,
569,
570,
571,
572,
573,
574,
575,
576,
577,
578,
579,
580,
581,
582,
583,
585,
586,
587,
588,
589,
590,
591,
678,
679,
680,
681,
682,
683,
684,
685,
686,
687,
688,
689,
690,
691,
692,
693,
694,
696,
697,
698,
699,
700,
701,
702,
826,
834,
837,
839,
844,
845,
847,
848,
852,
853,
855,
856,
859,
860,
861,
864,
866,
869,
871,
873,
942,
944,
946,
955,
956,
957,
958,
960,
967,
968,
969,
970,
971,
979,
980,
981,
985,
986,
988,
992,
993,
994,
1260,
1436,
1437,
8204,
8205,
8207,
8208,
8209,
8210,
8211,
8213,
8215,
8217,
8218,
8227,
8229,
8235,
8236,
8238,
8240,
8242,
8253,
8262,
8263,
8265,
8266,
8267,
8268,
8269,
8271,
8273,
9279,
9283,
9285,
9286,
9287,
9288,
9422,
9423,
9424,
9425,
9445,
9446,
9447,
9449,
9490,
9541,
9543,
9554,
9555,
9556,
9925,
9926,
9929,
9930,
9960,
9981,
9987,
9994,
10004,
10008,
10085,
10087,
10100,
10102,
10103,
10104,
10111,
10124,
10144,
10145,
10153,
10155,
10162,
10163,
10166,
10168,
10173,
10179,
10180,
10187,
10189,
10201,
10204,
10205,
10206,
10217,
10226,
10232,
10233,
10234,
10236,
10237,
10255,
10257,
10271,
10294,
10295,
10315,
10345,
10346,
10733,
10734,
10876,
11113,
11114,
11120,
11121,
11122,
11127,
11188,
11496,
11497,
12495,
12516,
12523,
12525,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementType_raw (int,int);
int ves_icall_System_Array_IsValueOfElementType_raw (int,int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy_raw (int,int,int,int,int,int);
int ves_icall_System_Array_GetLength_raw (int,int,int);
int ves_icall_System_Array_GetLowerBound_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
int ves_icall_System_Array_GetValueImpl_raw (int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
int ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
void ves_icall_System_Enum_InternalBoxEnum_raw (int,int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
int ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw (int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int mono_object_hash_icall_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetCallingAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
void ves_icall_AssemblyExtensions_ApplyUpdate (int,int,int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 184,
ves_icall_System_Array_InternalCreate,
// token 192,
ves_icall_System_Array_GetCorElementTypeOfElementType_raw,
// token 193,
ves_icall_System_Array_IsValueOfElementType_raw,
// token 194,
ves_icall_System_Array_CanChangePrimitive,
// token 195,
ves_icall_System_Array_FastCopy_raw,
// token 196,
ves_icall_System_Array_GetLength_raw,
// token 197,
ves_icall_System_Array_GetLowerBound_raw,
// token 198,
ves_icall_System_Array_GetGenericValue_icall,
// token 199,
ves_icall_System_Array_GetValueImpl_raw,
// token 200,
ves_icall_System_Array_SetGenericValue_icall,
// token 203,
ves_icall_System_Array_SetValueImpl_raw,
// token 204,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 366,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 367,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 369,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 397,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 398,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 399,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 419,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 420,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 421,
ves_icall_System_Enum_InternalGetCorElementType,
// token 422,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 507,
ves_icall_System_Environment_get_ProcessorCount,
// token 508,
ves_icall_System_Environment_get_TickCount,
// token 509,
ves_icall_System_Environment_get_TickCount64,
// token 512,
ves_icall_System_Environment_FailFast_raw,
// token 545,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 546,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 548,
ves_icall_System_GC_SuppressFinalize_raw,
// token 550,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 552,
ves_icall_System_GC_GetGCMemoryInfo,
// token 554,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 559,
ves_icall_System_Object_MemberwiseClone_raw,
// token 567,
ves_icall_System_Math_Acos,
// token 568,
ves_icall_System_Math_Acosh,
// token 569,
ves_icall_System_Math_Asin,
// token 570,
ves_icall_System_Math_Asinh,
// token 571,
ves_icall_System_Math_Atan,
// token 572,
ves_icall_System_Math_Atan2,
// token 573,
ves_icall_System_Math_Atanh,
// token 574,
ves_icall_System_Math_Cbrt,
// token 575,
ves_icall_System_Math_Ceiling,
// token 576,
ves_icall_System_Math_Cos,
// token 577,
ves_icall_System_Math_Cosh,
// token 578,
ves_icall_System_Math_Exp,
// token 579,
ves_icall_System_Math_Floor,
// token 580,
ves_icall_System_Math_Log,
// token 581,
ves_icall_System_Math_Log10,
// token 582,
ves_icall_System_Math_Pow,
// token 583,
ves_icall_System_Math_Sin,
// token 585,
ves_icall_System_Math_Sinh,
// token 586,
ves_icall_System_Math_Sqrt,
// token 587,
ves_icall_System_Math_Tan,
// token 588,
ves_icall_System_Math_Tanh,
// token 589,
ves_icall_System_Math_FusedMultiplyAdd,
// token 590,
ves_icall_System_Math_Log2,
// token 591,
ves_icall_System_Math_ModF,
// token 678,
ves_icall_System_MathF_Acos,
// token 679,
ves_icall_System_MathF_Acosh,
// token 680,
ves_icall_System_MathF_Asin,
// token 681,
ves_icall_System_MathF_Asinh,
// token 682,
ves_icall_System_MathF_Atan,
// token 683,
ves_icall_System_MathF_Atan2,
// token 684,
ves_icall_System_MathF_Atanh,
// token 685,
ves_icall_System_MathF_Cbrt,
// token 686,
ves_icall_System_MathF_Ceiling,
// token 687,
ves_icall_System_MathF_Cos,
// token 688,
ves_icall_System_MathF_Cosh,
// token 689,
ves_icall_System_MathF_Exp,
// token 690,
ves_icall_System_MathF_Floor,
// token 691,
ves_icall_System_MathF_Log,
// token 692,
ves_icall_System_MathF_Log10,
// token 693,
ves_icall_System_MathF_Pow,
// token 694,
ves_icall_System_MathF_Sin,
// token 696,
ves_icall_System_MathF_Sinh,
// token 697,
ves_icall_System_MathF_Sqrt,
// token 698,
ves_icall_System_MathF_Tan,
// token 699,
ves_icall_System_MathF_Tanh,
// token 700,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 701,
ves_icall_System_MathF_Log2,
// token 702,
ves_icall_System_MathF_ModF,
// token 826,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 834,
ves_icall_RuntimeType_make_array_type_raw,
// token 837,
ves_icall_RuntimeType_make_byref_type_raw,
// token 839,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 844,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 845,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 847,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 848,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 852,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 853,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 855,
ves_icall_System_RuntimeType_getFullName_raw,
// token 856,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 859,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 860,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 861,
ves_icall_RuntimeType_GetFields_native_raw,
// token 864,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 866,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 869,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 871,
ves_icall_RuntimeType_GetName_raw,
// token 873,
ves_icall_RuntimeType_GetNamespace_raw,
// token 942,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 944,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 946,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 955,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 956,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 957,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 958,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 960,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 967,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 968,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 969,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 970,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 971,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 979,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 980,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 981,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 985,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 986,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 988,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 992,
ves_icall_System_String_FastAllocateString_raw,
// token 993,
ves_icall_System_String_InternalIsInterned_raw,
// token 994,
ves_icall_System_String_InternalIntern_raw,
// token 1260,
ves_icall_System_Type_internal_from_handle_raw,
// token 1436,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1437,
ves_icall_System_ValueType_Equals_raw,
// token 8204,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 8205,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 8207,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 8208,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 8209,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 8210,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 8211,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 8213,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 8215,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 8217,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 8218,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 8227,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 8229,
mono_monitor_exit_icall_raw,
// token 8235,
ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw,
// token 8236,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 8238,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 8240,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 8242,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 8253,
ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw,
// token 8262,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 8263,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 8265,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 8266,
ves_icall_System_Threading_Thread_GetState_raw,
// token 8267,
ves_icall_System_Threading_Thread_SetState_raw,
// token 8268,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 8269,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 8271,
ves_icall_System_Threading_Thread_YieldInternal,
// token 8273,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 9279,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 9283,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 9285,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 9286,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 9287,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 9288,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 9422,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 9423,
ves_icall_System_GCHandle_InternalFree_raw,
// token 9424,
ves_icall_System_GCHandle_InternalGet_raw,
// token 9425,
ves_icall_System_GCHandle_InternalSet_raw,
// token 9445,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 9446,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 9447,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 9449,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 9490,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 9541,
mono_object_hash_icall_raw,
// token 9543,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 9554,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 9555,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 9556,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 9925,
ves_icall_System_Reflection_Assembly_GetCallingAssembly_raw,
// token 9926,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 9929,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 9930,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 9960,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 9981,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 9987,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 9994,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 10004,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 10008,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 10085,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 10087,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 10100,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 10102,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 10103,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 10104,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 10111,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 10124,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 10144,
ves_icall_reflection_get_token_raw,
// token 10145,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 10153,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 10155,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 10162,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 10163,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 10166,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 10168,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 10173,
ves_icall_reflection_get_token_raw,
// token 10179,
ves_icall_get_method_info_raw,
// token 10180,
ves_icall_get_method_attributes,
// token 10187,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 10189,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 10201,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 10204,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 10205,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 10206,
ves_icall_reflection_get_token_raw,
// token 10217,
ves_icall_InternalInvoke_raw,
// token 10226,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 10232,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 10233,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 10234,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 10236,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 10237,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 10255,
ves_icall_InvokeClassConstructor_raw,
// token 10257,
ves_icall_InternalInvoke_raw,
// token 10271,
ves_icall_reflection_get_token_raw,
// token 10294,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 10295,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 10315,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 10345,
ves_icall_reflection_get_token_raw,
// token 10346,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 10733,
ves_icall_AssemblyExtensions_ApplyUpdate,
// token 10734,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 10876,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 11113,
ves_icall_ModuleBuilder_basic_init_raw,
// token 11114,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 11120,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 11121,
ves_icall_ModuleBuilder_getToken_raw,
// token 11122,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 11127,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 11188,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 11496,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 11497,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 12495,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 12516,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 12523,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 12525,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_handles [] = {
0,
1,
1,
0,
1,
1,
1,
0,
1,
0,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
0,
1,
0,
0,
0,
1,
1,
1,
1,
1,
0,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
};
