#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
220,
233,
234,
235,
236,
237,
238,
239,
240,
241,
244,
245,
246,
422,
423,
424,
452,
453,
454,
481,
482,
483,
600,
601,
602,
605,
643,
644,
645,
646,
647,
651,
653,
655,
657,
663,
671,
672,
673,
674,
675,
676,
677,
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
689,
690,
691,
692,
693,
694,
695,
791,
792,
793,
794,
795,
796,
797,
798,
799,
800,
801,
802,
803,
804,
805,
806,
807,
809,
810,
811,
812,
813,
814,
815,
877,
886,
887,
958,
965,
968,
970,
975,
976,
978,
979,
983,
984,
986,
987,
990,
991,
992,
995,
997,
1000,
1002,
1004,
1013,
1081,
1083,
1085,
1095,
1096,
1097,
1099,
1105,
1106,
1107,
1108,
1109,
1117,
1118,
1119,
1123,
1124,
1126,
1130,
1131,
1132,
1429,
1620,
1621,
10132,
10133,
10135,
10136,
10137,
10138,
10139,
10141,
10142,
10143,
10144,
10162,
10164,
10171,
10173,
10175,
10177,
10180,
10230,
10231,
10233,
10234,
10235,
10236,
10237,
10239,
10241,
11407,
11411,
11413,
11414,
11415,
11416,
11858,
11859,
11860,
11861,
11882,
11883,
11884,
11886,
11887,
11941,
12025,
12028,
12037,
12038,
12039,
12040,
12041,
12042,
12377,
12378,
12383,
12384,
12419,
12462,
12469,
12476,
12487,
12491,
12517,
12600,
12602,
12613,
12615,
12616,
12617,
12624,
12639,
12659,
12660,
12668,
12670,
12677,
12678,
12681,
12683,
12688,
12694,
12695,
12702,
12704,
12716,
12719,
12720,
12721,
12732,
12742,
12748,
12749,
12750,
12752,
12753,
12770,
12772,
12787,
12809,
12810,
12835,
12840,
12870,
12871,
13492,
13506,
13595,
13596,
13818,
13819,
13826,
13827,
13828,
13834,
13904,
14435,
14436,
14858,
14859,
14860,
14866,
14876,
15888,
15909,
15911,
15913,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal (int);
int ves_icall_System_Array_IsValueOfElementTypeInternal (int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy (int,int,int,int,int);
int ves_icall_System_Array_GetLengthInternal_raw (int,int,int);
int ves_icall_System_Array_GetLowerBoundInternal_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
void ves_icall_System_Array_GetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_InitializeInternal_raw (int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
void ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
int ves_icall_System_GC_GetCollectionCount (int);
int ves_icall_System_GC_GetMaxGeneration ();
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
int64_t ves_icall_System_GC_GetTotalAllocatedBytes_raw (int,int);
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
int ves_icall_RuntimeMethodHandle_GetFunctionPointer_raw (int,int);
void ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw (int,int,int);
void ves_icall_RuntimeMethodHandle_ReboxToNullable_raw (int,int,int,int);
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
int ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
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
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
int64_t ves_icall_System_Threading_Monitor_Monitor_get_lock_contention_count ();
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
void ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureHelper_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw (int,int,int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalBox_raw (int,int,int);
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_LoaderAllocatorScout_Destroy (int);
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
int ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_CustomAttributeBuilder_GetBlob_raw (int,int,int,int,int,int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_System_Diagnostics_Debugger_IsAttached_internal ();
int ves_icall_System_Diagnostics_Debugger_IsLogging ();
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_System_Diagnostics_StackFrame_GetFrameInfo (int,int,int,int,int,int,int,int);
void ves_icall_System_Diagnostics_StackTrace_GetTrace (int,int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 220,
ves_icall_System_Array_InternalCreate,
// token 233,
ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal,
// token 234,
ves_icall_System_Array_IsValueOfElementTypeInternal,
// token 235,
ves_icall_System_Array_CanChangePrimitive,
// token 236,
ves_icall_System_Array_FastCopy,
// token 237,
ves_icall_System_Array_GetLengthInternal_raw,
// token 238,
ves_icall_System_Array_GetLowerBoundInternal_raw,
// token 239,
ves_icall_System_Array_GetGenericValue_icall,
// token 240,
ves_icall_System_Array_GetValueImpl_raw,
// token 241,
ves_icall_System_Array_SetGenericValue_icall,
// token 244,
ves_icall_System_Array_SetValueImpl_raw,
// token 245,
ves_icall_System_Array_InitializeInternal_raw,
// token 246,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 422,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 423,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 424,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 452,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 453,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 454,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 481,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 482,
ves_icall_System_Enum_InternalGetCorElementType,
// token 483,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 600,
ves_icall_System_Environment_get_ProcessorCount,
// token 601,
ves_icall_System_Environment_get_TickCount,
// token 602,
ves_icall_System_Environment_get_TickCount64,
// token 605,
ves_icall_System_Environment_FailFast_raw,
// token 643,
ves_icall_System_GC_GetCollectionCount,
// token 644,
ves_icall_System_GC_GetMaxGeneration,
// token 645,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 646,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 647,
ves_icall_System_GC_GetTotalAllocatedBytes_raw,
// token 651,
ves_icall_System_GC_SuppressFinalize_raw,
// token 653,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 655,
ves_icall_System_GC_GetGCMemoryInfo,
// token 657,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 663,
ves_icall_System_Object_MemberwiseClone_raw,
// token 671,
ves_icall_System_Math_Acos,
// token 672,
ves_icall_System_Math_Acosh,
// token 673,
ves_icall_System_Math_Asin,
// token 674,
ves_icall_System_Math_Asinh,
// token 675,
ves_icall_System_Math_Atan,
// token 676,
ves_icall_System_Math_Atan2,
// token 677,
ves_icall_System_Math_Atanh,
// token 678,
ves_icall_System_Math_Cbrt,
// token 679,
ves_icall_System_Math_Ceiling,
// token 680,
ves_icall_System_Math_Cos,
// token 681,
ves_icall_System_Math_Cosh,
// token 682,
ves_icall_System_Math_Exp,
// token 683,
ves_icall_System_Math_Floor,
// token 684,
ves_icall_System_Math_Log,
// token 685,
ves_icall_System_Math_Log10,
// token 686,
ves_icall_System_Math_Pow,
// token 687,
ves_icall_System_Math_Sin,
// token 689,
ves_icall_System_Math_Sinh,
// token 690,
ves_icall_System_Math_Sqrt,
// token 691,
ves_icall_System_Math_Tan,
// token 692,
ves_icall_System_Math_Tanh,
// token 693,
ves_icall_System_Math_FusedMultiplyAdd,
// token 694,
ves_icall_System_Math_Log2,
// token 695,
ves_icall_System_Math_ModF,
// token 791,
ves_icall_System_MathF_Acos,
// token 792,
ves_icall_System_MathF_Acosh,
// token 793,
ves_icall_System_MathF_Asin,
// token 794,
ves_icall_System_MathF_Asinh,
// token 795,
ves_icall_System_MathF_Atan,
// token 796,
ves_icall_System_MathF_Atan2,
// token 797,
ves_icall_System_MathF_Atanh,
// token 798,
ves_icall_System_MathF_Cbrt,
// token 799,
ves_icall_System_MathF_Ceiling,
// token 800,
ves_icall_System_MathF_Cos,
// token 801,
ves_icall_System_MathF_Cosh,
// token 802,
ves_icall_System_MathF_Exp,
// token 803,
ves_icall_System_MathF_Floor,
// token 804,
ves_icall_System_MathF_Log,
// token 805,
ves_icall_System_MathF_Log10,
// token 806,
ves_icall_System_MathF_Pow,
// token 807,
ves_icall_System_MathF_Sin,
// token 809,
ves_icall_System_MathF_Sinh,
// token 810,
ves_icall_System_MathF_Sqrt,
// token 811,
ves_icall_System_MathF_Tan,
// token 812,
ves_icall_System_MathF_Tanh,
// token 813,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 814,
ves_icall_System_MathF_Log2,
// token 815,
ves_icall_System_MathF_ModF,
// token 877,
ves_icall_RuntimeMethodHandle_GetFunctionPointer_raw,
// token 886,
ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw,
// token 887,
ves_icall_RuntimeMethodHandle_ReboxToNullable_raw,
// token 958,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 965,
ves_icall_RuntimeType_make_array_type_raw,
// token 968,
ves_icall_RuntimeType_make_byref_type_raw,
// token 970,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 975,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 976,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 978,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 979,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 983,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 984,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 986,
ves_icall_System_RuntimeType_getFullName_raw,
// token 987,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 990,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 991,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 992,
ves_icall_RuntimeType_GetFields_native_raw,
// token 995,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 997,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 1000,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 1002,
ves_icall_RuntimeType_GetName_raw,
// token 1004,
ves_icall_RuntimeType_GetNamespace_raw,
// token 1013,
ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw,
// token 1081,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 1083,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 1085,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1095,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 1096,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 1097,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1099,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1105,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1106,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1107,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1108,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1109,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1117,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1118,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 1119,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1123,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 1124,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1126,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1130,
ves_icall_System_String_FastAllocateString_raw,
// token 1131,
ves_icall_System_String_InternalIsInterned_raw,
// token 1132,
ves_icall_System_String_InternalIntern_raw,
// token 1429,
ves_icall_System_Type_internal_from_handle_raw,
// token 1620,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1621,
ves_icall_System_ValueType_Equals_raw,
// token 10132,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 10133,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 10135,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 10136,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 10137,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 10138,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 10139,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 10141,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 10142,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 10143,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 10144,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 10162,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 10164,
mono_monitor_exit_icall_raw,
// token 10171,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 10173,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 10175,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 10177,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 10180,
ves_icall_System_Threading_Monitor_Monitor_get_lock_contention_count,
// token 10230,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 10231,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 10233,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 10234,
ves_icall_System_Threading_Thread_GetState_raw,
// token 10235,
ves_icall_System_Threading_Thread_SetState_raw,
// token 10236,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 10237,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 10239,
ves_icall_System_Threading_Thread_YieldInternal,
// token 10241,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 11407,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 11411,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 11413,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 11414,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 11415,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 11416,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 11858,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 11859,
ves_icall_System_GCHandle_InternalFree_raw,
// token 11860,
ves_icall_System_GCHandle_InternalGet_raw,
// token 11861,
ves_icall_System_GCHandle_InternalSet_raw,
// token 11882,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 11883,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 11884,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 11886,
ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureHelper_raw,
// token 11887,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 11941,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 12025,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw,
// token 12028,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 12037,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 12038,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 12039,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw,
// token 12040,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw,
// token 12041,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 12042,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalBox_raw,
// token 12377,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 12378,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 12383,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 12384,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 12419,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 12462,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 12469,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 12476,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 12487,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 12491,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 12517,
ves_icall_System_Reflection_LoaderAllocatorScout_Destroy,
// token 12600,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 12602,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 12613,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 12615,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 12616,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 12617,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 12624,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 12639,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 12659,
ves_icall_reflection_get_token_raw,
// token 12660,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 12668,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 12670,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 12677,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 12678,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 12681,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 12683,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 12688,
ves_icall_reflection_get_token_raw,
// token 12694,
ves_icall_get_method_info_raw,
// token 12695,
ves_icall_get_method_attributes,
// token 12702,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 12704,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 12716,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 12719,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 12720,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 12721,
ves_icall_reflection_get_token_raw,
// token 12732,
ves_icall_InternalInvoke_raw,
// token 12742,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 12748,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 12749,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 12750,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 12752,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 12753,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 12770,
ves_icall_InvokeClassConstructor_raw,
// token 12772,
ves_icall_InternalInvoke_raw,
// token 12787,
ves_icall_reflection_get_token_raw,
// token 12809,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 12810,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 12835,
ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw,
// token 12840,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 12870,
ves_icall_reflection_get_token_raw,
// token 12871,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 13492,
ves_icall_CustomAttributeBuilder_GetBlob_raw,
// token 13506,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 13595,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 13596,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 13818,
ves_icall_ModuleBuilder_basic_init_raw,
// token 13819,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 13826,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 13827,
ves_icall_ModuleBuilder_getToken_raw,
// token 13828,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 13834,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 13904,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 14435,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 14436,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 14858,
ves_icall_System_Diagnostics_Debugger_IsAttached_internal,
// token 14859,
ves_icall_System_Diagnostics_Debugger_IsLogging,
// token 14860,
ves_icall_System_Diagnostics_Debugger_Log,
// token 14866,
ves_icall_System_Diagnostics_StackFrame_GetFrameInfo,
// token 14876,
ves_icall_System_Diagnostics_StackTrace_GetTrace,
// token 15888,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 15909,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 15911,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 15913,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_flags [] = {
0,
0,
0,
0,
0,
4,
4,
0,
4,
0,
4,
4,
4,
0,
0,
0,
4,
4,
4,
4,
0,
4,
0,
0,
0,
4,
0,
0,
4,
4,
4,
4,
4,
0,
4,
4,
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
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
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
4,
4,
4,
4,
4,
4,
0,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
};
